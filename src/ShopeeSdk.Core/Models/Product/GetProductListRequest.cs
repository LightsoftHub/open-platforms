using Light.Shopee.Enums;
using System;
using System.Linq;

namespace Light.Shopee.Models.Product
{
    public class GetProductListRequest : BaseRequest
    {
        public GetProductListRequest()
        {
            SetPage();
            ByStatus();
        }

        public void SetPage(int offset = 0, int page_size = 100)
        {
            Add("offset", offset);
            Add("page_size", page_size);
        }

        public void ByStatus(ProductStatus? status = null)
        {
            if (status.HasValue)
            {
                // NORMAL/BANNED/DELETED/UNLIST
                Add("item_status", status.Value);
            }
            else
            {
                var statusList = Enum.GetValues(typeof(ProductStatus))
                    .Cast<ProductStatus>()
                    .Select(s => s.ToString());

                Add("item_status", statusList);
            }
        }

        public void ByUpdateTime(DateTime? from = null, DateTime? to = null)
        {
            if (from.HasValue && to.HasValue)
            {
                Add("update_time_from", from);
                Add("update_time_to", to);
            }
        }
    }
}
