namespace RoyalDelivery.ViewModels
{
    public class ControlPanelViewModel
    {
        public string Title { get; } = "Vezérlőpult";

        // Example counters / stats
        public int OrdersToday { get; set; } = 12;
        public int ActiveCouriers { get; set; } = 4;
        public int PendingOrders { get; set; } = 3;
    }
}
