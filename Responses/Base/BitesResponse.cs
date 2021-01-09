namespace FenixAlliance.ABM.Models.DTOs.Responses.Base
{
    public class PhotoResponse
    {
        public byte[] Bytes { get; set; }

        public string ContentType { get; set; }

        public string Base64String { get; set; }
    }
}