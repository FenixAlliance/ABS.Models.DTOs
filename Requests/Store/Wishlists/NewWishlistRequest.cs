namespace FenixAlliance.ABM.Models.DTOs.Requests.Store.WishLists
{
    public class NewWishListRequest
    {
        public string Title { get; set; }
        public string CartID { get; set; }
        public bool Public { get; set; }
    }
}
