namespace Light.GrabSdk.GrabMart.Enums
{
    public enum Order_State
    {
        None,
        ACCEPTED, // -- main
        REJECT,
        ERROR,
        DRIVER_ALLOCATED, // -- main: driver founded
        DRIVER_ARRIVED, // -- main
        COLLECTED, // -- main: shipped
        DELIVERED, // -- main: completed
        CANCELLED, // -- main
    }
}
