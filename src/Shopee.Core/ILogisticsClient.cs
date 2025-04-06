using Light.Shopee.Models;
using Light.Shopee.Models.Logistics;
using System.Threading.Tasks;

namespace Light.Shopee
{
    public interface ILogisticsClient
    {
        // https://open.shopee.com/documents/v2/v2.logistics.get_shipping_parameter?module=95&type=1
        Task<IShopeeResult<ShippingParameterResponse>> GetShippingParameter(string order_sn);

        // https://open.shopee.com/documents/v2/v2.logistics.get_tracking_number?module=95&type=1
        Task<IShopeeResult<TrackingNumberResponse>> GetTrackingNumber(string order_sn);

        /* API Call Flow
         * ShipOrder 
         *  -> GetShippingDocumentParameter
         *  -> CreateShippingDocument
         *  -> GetShippingDocumentResult
         *  -> DownloadShippingDocument
         */

        // https://open.shopee.com/documents/v2/v2.logistics.ship_order?module=95&type=1
        Task<IShopeeResult> ShipOrderPickup(string ordersn, long addressId, string pickupTimeId);

        // https://open.shopee.com/documents/v2/v2.logistics.get_shipping_document_parameter?module=95&type=1
        Task<IShopeeResult<ShippingDocumentParameterResponse>> GetShippingDocumentParameter(string[] ordersnList);

        // https://open.shopee.com/documents/v2/v2.logistics.create_shipping_document?module=95&type=1
        Task<IShopeeResult<CreateShippingDocumentResponse>> CreateShippingDocument(CreateShippingDocumentRequest[] orderListReq);

        // https://open.shopee.com/documents/v2/v2.logistics.get_shipping_document_result?module=95&type=1
        Task<IShopeeResult<ShippingDocumentStatusResponse>> GetShippingDocumentResult(string[] ordersnList);

        //https://open.shopee.com/documents/v2/v2.logistics.download_shipping_document?module=95&type=1
        Task<IShopeeResult<string>> DownloadShippingDocument(string[] ordersnList, string documentType = null);

        // https://open.shopee.com/documents/v2/v2.logistics.get_address_list?module=95&type=1
        Task<IShopeeResult<AddressListResponse>> GetAddressList();

        // https://open.shopee.com/documents/v2/v2.logistics.get_tracking_info?module=95&type=1
        Task<IShopeeResult<TrackingInfoResponse>> GetTrackingInfo(string order_sn);

        // https://open.shopee.com/documents/v2/v2.logistics.set_address_config?module=95&type=1
        Task<IShopeeResult> SetAddressConfig(long addressId);
    }
}