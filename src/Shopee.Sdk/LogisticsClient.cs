using Light.Shopee.Models;
using Light.Shopee.Models.Logistics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Light.Shopee
{
    internal class LogisticsClient : ShopeeHttpClient, ILogisticsClient
    {
        public LogisticsClient(IHttpClientFactory httpClientFactory, IShopeeCredential credential) : base(httpClientFactory, credential)
        {
        }

        public Task<IShopeeResult<ShippingParameterResponse>> GetShippingParameter(string order_sn) =>
            TryGetAsync<ShippingParameterResponse>("/api/v2/logistics/get_shipping_parameter",
                BaseRequest.Create(() => order_sn));

        public Task<IShopeeResult<TrackingNumberResponse>> GetTrackingNumber(string order_sn) =>
            TryGetAsync<TrackingNumberResponse>("/api/v2/logistics/get_tracking_number",
                BaseRequest.Create(() => order_sn));

        public Task<IShopeeResult> ShipOrderPickup(string ordersn, long addressId, string pickupTimeId)
        {
            var path = "/api/v2/logistics/ship_order";

            var request = new
            {
                order_sn = ordersn,
                pickup = new
                {
                    address_id = addressId,
                    pickup_time_id = pickupTimeId
                }
            };

            return TryPostAsync(path, request);
        }

        public async Task<IShopeeResult<ShippingDocumentParameterResponse>> GetShippingDocumentParameter(string[] ordersnList)
        {
            if (ordersnList.Length > 50)
            {
                return ShopeeResult<ShippingDocumentParameterResponse>.Failed("Limit 50 orders per request");
            }

            var path = "/api/v2/logistics/get_shipping_document_parameter";

            var orderListdto = ordersnList.Select(s => new { order_sn = s }).ToArray();

            var request = new { order_list = orderListdto };

            return await TryPostAsync<ShippingDocumentParameterResponse>(path, request);
        }

        public async Task<IShopeeResult<CreateShippingDocumentResponse>> CreateShippingDocument(CreateShippingDocumentRequest[] orderListReq)
        {
            if (orderListReq.Length > 50)
            {
                return ShopeeResult<CreateShippingDocumentResponse>.Failed("Limit 50 orders per request");
            }

            var path = "/api/v2/logistics/create_shipping_document";

            var request = new { order_list = orderListReq };

            return await TryPostAsync<CreateShippingDocumentResponse>(path, request);
        }

        public async Task<IShopeeResult<ShippingDocumentStatusResponse>> GetShippingDocumentResult(string[] ordersnList)
        {
            if (ordersnList.Length > 50)
            {
                return ShopeeResult<ShippingDocumentStatusResponse>.Failed("Limit 50 orders per request");
            }

            var path = "/api/v2/logistics/get_shipping_document_result";

            var orderListdto = ordersnList.Select(s => new { order_sn = s }).ToArray();

            var request = new { order_list = orderListdto };

            return await TryPostAsync<ShippingDocumentStatusResponse>(path, request);
        }

        public async Task<IShopeeResult<string>> DownloadShippingDocument(string[] ordersnList, string documentType = null)
        {
            var path = "/api/v2/logistics/download_shipping_document";

            var request = new
            {
                //shipping_document_type = "NORMAL_AIR_WAYBILL",
                shipping_document_type = documentType ?? "THERMAL_AIR_WAYBILL",
                order_list = ordersnList.Select(s => new { order_sn = s }).ToArray()
            };

            var response = await PostAsJsonAsync(path, request);

            var responseContentType = response.Content.Headers.ContentType.ToString();

            if (responseContentType.Contains("application/pdf"))
            {
                var stream = await response.Content.ReadAsStreamAsync();

                byte[] bytes;
                using (var memoryStream = new MemoryStream())
                {
                    stream.CopyTo(memoryStream);
                    bytes = memoryStream.ToArray();
                }

                string base64 = Convert.ToBase64String(bytes);

                return ShopeeResult<string>.Success(base64);
            }
            else if (responseContentType.Contains("application/json"))
            {
                var errorResult = await response.Read();
                return ShopeeResult<string>.Failed(errorResult.Message);
            }

            return ShopeeResult<string>.Failed($"Error when read response Content-Type is: {responseContentType}");
        }

        public Task<IShopeeResult<AddressListResponse>> GetAddressList() =>
            TryGetAsync<AddressListResponse>("/api/v2/logistics/get_address_list");

        public Task<IShopeeResult<TrackingInfoResponse>> GetTrackingInfo(string order_sn) =>
            TryGetAsync<TrackingInfoResponse>("/api/v2/logistics/get_tracking_info",
                BaseRequest.Create(() => order_sn));

        public Task<IShopeeResult> SetAddressConfig(long addressId)
        {
            var path = "/api/v2/logistics/set_address_config";

            var request = new SetAddressConfigRequest
            {
                //ShowPickUpAddress = false,
                AddressTypeConfig = new AddressTypeConfig
                {
                    AddressId = addressId,
                    AddressType = new List<string> { "DEFAULT_ADDRESS", "PICKUP_ADDRESS", "RETURN_ADDRESS" }
                }
            };

            return TryPostAsync(path, request);
        }
    }
}