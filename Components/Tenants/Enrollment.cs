using FenixAlliance.Models.DTOs.Components.ID;

namespace FenixAlliance.Models.DTOs.Components.Businesses
{
    public class Enrollment
    {
        public string ID { get; set; }
        public Holder Holder { get; set; }
        public Tenant Tenant { get; set; }

        public string AID { get; set; }
        public string SPID { get; set; }
        public string PName { get; set; }
        public string CO { get; set; }
        public string CO_F_URL { get; set; }
        public string Avtr_URL { get; set; }
        public string Fb_URL { get; set; }
        public string Twtr_URL { get; set; }
        public string LnIn_URL { get; set; }
        public string Web_URL { get; set; }
        public bool Current { get; set; }
        public bool AsOwner { get; set; }
        public bool AsAdmin { get; set; }
        public bool AsGuest { get; set; }
        public string FwID { get; set; }
        public string FwBkID { get; set; }
    }
}
