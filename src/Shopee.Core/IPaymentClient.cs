using Light.Shopee.Models;
using Light.Shopee.Models.Payment;
using System;
using System.Threading.Tasks;

namespace Light.Shopee
{
    public interface IPaymentClient
    {
        // https://open.shopee.com/documents/v2/v2.payment.get_escrow_detail?module=97&type=1
        Task<IShopeeResult<EscrowDetailResponse>> GetEscrowDetail(string order_sn);
        Task<string> GetEscrowUrl(string order_sn);

        // https://open.shopee.com/documents/v2/v2.payment.get_escrow_list?module=97&type=1
        Task<IShopeeResult<EscrowListResponse>> GetEscrowList(DateTime from, DateTime to);
    }
}