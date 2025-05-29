namespace Light.GrabSdk.GrabExpress.Common.Enums
{
    /// <summary>
    /// Delivery fee (paid to driver) payment method i.e. CASH, CASHLESS. Default value (if not sent): CASHLESS
    /// Note: This value can change dynamically for COD and non-COD flow. Please implement a solution such that value for paymentMethod can be changed for COD and non-COD flow immediately without code changes.
    /// Note: This is required if promoCode is supplied.
    /// </summary>

    public enum PaymentMethod
    {
        CASHLESS, // default
        CASH
    }
}
