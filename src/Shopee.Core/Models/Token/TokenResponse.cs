namespace Light.Shopee.Models.Token
{
    public class TokenResponse : ShopeeResult
    {
        public string access_token { get; set; }

        public int expire_in { get; set; }

        public string refresh_token { get; set; }
    }
}