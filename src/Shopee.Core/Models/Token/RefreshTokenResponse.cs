namespace Light.Shopee.Models.Token
{
    public class RefreshTokenResponse
    {
        public long shop_id { get; set; }

        public string error { get; set; }

        public string access_token { get; set; }

        public int expire_in { get; set; }

        public string message { get; set; }

        public string request_id { get; set; }

        public long partner_id { get; set; }

        public string refresh_token { get; set; }
    }
}