using Light.Shopee.Enums;
using System;

namespace Light.Shopee.Models.Returns
{
    /// <summary>
    /// Warning: create from -> to limit 15 days
    /// </summary>
    public class GetReturnListRequest : BaseRequest
    {
        public GetReturnListRequest(ReturnStatus? status = null)
        {
            SetPage(0); // first page is 0

            if (status.HasValue)
            {
                Add(() => status);
            }
        }

        public void SetPage(int page_no, int page_size = 100)
        {
            Add(() => page_no); // default = 0 not 1 (warning)
            Add(() => page_size); // default = 40, maximum page size = 100
        }

        public void ByCreateTime(DateTime? create_time_from, DateTime? create_time_to)
        {
            if (create_time_from.HasValue)
            {
                Add(() => create_time_from);
            }

            if (create_time_to.HasValue)
            {
                Add(() => create_time_to);
            }
        }

        public void ByUpdateTime(DateTime? update_time_from, DateTime? update_time_to)
        {
            if (update_time_from.HasValue)
            {
                Add(() => update_time_from);
            }

            if (update_time_to.HasValue)
            {
                Add(() => update_time_to);
            }
        }
    }
}
