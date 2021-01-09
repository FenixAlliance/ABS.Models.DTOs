namespace FenixAlliance.ABM.Models.DTOs.Requests.Store
{
    public class CheckoutRequest
    {
        public string CartID { get; set; }
        public bool Services { get; set; }
        public bool Products { get; set; }
        public bool Subscriptions { get; set; }
    }
}
