namespace Light.Shopee.Models.PushConfig
{
    public enum PushConfigType
    {
        ShopAuthorizationForPartners = 1,
        ShopDeauthorizationForPartners = 2,
        OrderStatusUpdatePush = 3,
        TrackingNoPush = 4,
        ShopeeUpdates = 5,
        BannedItemPush = 6,
        ItemPromotionPush = 7,
        ReservedStockChangePush = 8,
        PromotionnUpdatePush = 9,
        WebchatPush = 10,
        VideoUploadPush = 11,
        OpenapiAuthorizationExpiryPush = 12,
        BrandRegisterResult = 13,
    }
}
