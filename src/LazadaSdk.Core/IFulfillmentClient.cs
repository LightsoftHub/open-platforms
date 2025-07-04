using Light.Lazada.Common;
using Light.Lazada.Models.Fulfillments;
using System.Threading.Tasks;

namespace Light.Lazada
{
    public interface IFulfillmentClient
    {
        // https://open.lazada.com/apps/doc/api?path=%2Forder%2Fshipment%2Fproviders%2Fget
        Task<ILazResponse<ShipmentProviderResult>> GetShipmentProvider(string orderId, string[] orderItemIds);

        // https://open.lazada.com/apps/doc/api?path=%2Forder%2Ffulfill%2Fpack
        Task<ILazResponse<PackResult>> Pack(string orderId, string[] orderItemIds);

        // https://open.lazada.com/apps/doc/api?path=%2Forder%2Fpackage%2Frts
        Task<ILazResponse<ReadyToShipResult>> ReadyToShip(string packageId);

        Task<ILazResponse<PrintAWBData>> PrintAWB(string packageId, bool pdf = true);
    }
}
