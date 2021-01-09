namespace FenixAlliance.ABM.Models.DTOs.Requests.Store.Wishlists
{
    public class NewWishlistRequest
    {
        public string Title { get; set; }
        public string CartID { get; set; }
        public bool Public { get; set; }
    }
}
