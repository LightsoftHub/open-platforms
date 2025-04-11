using Light.Lazada.Common;
using Light.Lazada.Models.Fulfillments;
using System.Threading.Tasks;

namespace Light.Lazada
{
    public interface IFulfillmentClient
    {
        // https://open.lazada.com/apps/doc/api?path=%2Forder%2Fshipment%2Fproviders%2Fget
        Task<LazResult<ShipmentProviderResult>> GetShipmentProvider(string orderId, string[] orderItemIds);

        // https://open.lazada.com/apps/doc/api?path=%2Forder%2Ffulfill%2Fpack
        Task<LazResult<PackResult>> Pack(string orderId, string[] orderItemIds);

        // https://open.lazada.com/apps/doc/api?path=%2Forder%2Fpackage%2Frts
        Task<LazResult<ReadyToShipResult>> ReadyToShip(string packageId);

        Task<LazResult<PrintAWBData>> PrintAWB(string packageId, bool pdf = true);
    }
}
