using Light.Lazada.Common;
using Light.Lazada.Models.Fulfillments;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Light.Lazada
{
    public class FulfillmentClient : LazadaHttpClient, IFulfillmentClient
    {
        public FulfillmentClient(IHttpClientFactory httpClientFactory, ILazadaCredential provider) : base(httpClientFactory, provider)
        {
        }

        public async Task<LazResult<ShipmentProviderResult>> GetShipmentProvider(string orderId, string[] orderItemIds)
        {
            var path = "/order/shipment/providers/get";

            var requestData = new
            {
                orders = new[]
                {
                    new
                    {
                        order_id = orderId,
                        order_item_ids = orderItemIds,
                    }
                }
            };

            var request = new Dictionary<string, string>()
            {
                { "getShipmentProvidersReq", JsonSerializer.Serialize(requestData) },
            };

            var response = await TryGetAsync(path, request);

            var result = await response.Read<ShipmentProviderResult>();

            return result;
        }

        public async Task<LazResult<PackResult>> Pack(string orderId, string[] orderItemIds)
        {
            var path = "/order/fulfill/pack";

            var packReq = new
            {
                pack_order_list = new[]
                {
                    new
                    {
                        order_id = orderId,
                        order_item_list = orderItemIds
                    }
                },
                delivery_type = "dropship",
                shipping_allocate_type = "TFS" // TFS is local, NTFS is cross-border store
            };

            var request = new Dictionary<string, string>()
            {
                { "packReq", JsonSerializer.Serialize(packReq) },
            };

            var response = await TryPostAsync(path, request);

            var result = await response.Read<PackResult>();

            return result;
        }

        public async Task<LazResult<ReadyToShipResult>> ReadyToShip(string packageId)
        {
            var path = "/order/package/rts";

            var readyToShipReq = new
            {
                packages = new[]
                {
                    new
                    {
                        package_id = packageId,
                    }
                }
            };

            var request = new Dictionary<string, string>()
            {
                { "readyToShipReq", JsonSerializer.Serialize(readyToShipReq) },
            };

            var response = await TryPostAsync(path, request);

            var result = await response.Read<ReadyToShipResult>();

            return result;
        }

        public async Task<LazResult<PrintAWBData>> PrintAWB(string packageId, bool pdf = true)
        {
            var path = "/order/package/document/get";

            var getDocumentReq = new
            {
                doc_type = pdf ? "PDF" : "HTML",
                packages = new List<object>
                {
                    new
                    {
                        package_id = packageId,
                    }
                }
            };

            var getDocumentReqJson = JsonSerializer.Serialize(getDocumentReq);

            var request = new Dictionary<string, string>()
            {
                { "getDocumentReq", getDocumentReqJson },
            };

            var response = await TryGetAsync(path, request);

            var result = await response.Read<PrintAWBResult>();

            var printAwbResult = result?.Data;

            if (printAwbResult?.Success is true)
            {
                return LazResult<PrintAWBData>.Success(printAwbResult.Data);
            }

            return LazResult<PrintAWBData>.Failed("Error when get AWB data");
        }
    }
}