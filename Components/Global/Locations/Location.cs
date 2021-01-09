namespace FenixAlliance.ABM.Models.DTOs.Components.Global.Locations
{
    public class Location
    {
        public string ID { get; set; }

        public double Longitud { get; set; }
        public double Latitud { get; set; }

        public string Title { get; set; }
        public string Business { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Unit { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string CountryID { get; set; }



        public bool IsRoutable { get; set; }
        public bool IsGlobalPrimary { get; set; }
        public bool IsCountryPrimary { get; set; }
        public bool CanGenerateLabels { get; set; }
        public bool IsDefaultSenderAddress { get; set; }
        public bool IsDefaultReturnAddress { get; set; }
        public bool IsDefailtSuppingLocation { get; set; }


    }
}
