namespace Light.Shopee.Models.Product
{
    public class GetItemBaseInfoRequest : BaseRequest
    {
        public GetItemBaseInfoRequest(long[] item_id_list,
            bool need_tax_info = false,
            bool need_complaint_policy = false)
        {
            Add(() => item_id_list);

            if (need_tax_info)
                Add(() => need_tax_info);

            if (need_complaint_policy)
                Add(() => need_complaint_policy);
        }
    }
}
