namespace Light.GrabSdk.GrabExpress.Common.Enums
{
    /// <summary>
    /// Person paying the delivery fee.
    /// Valid values are SENDER, RECIPIENT. Default value(if not sent) is SENDER.
    /// Note: Sending a RECIPIENT value for CASHLESS payments will result in an error.
    /// </summary>
    public enum Payer
    {
        SENDER, // default
        RECIPIENT
    }
}
