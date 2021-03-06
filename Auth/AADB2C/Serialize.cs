using Newtonsoft.Json;

namespace FenixAlliance.ABM.Models.DTOs.Auth.AADB2C
{
    public static class Serialize
    {
        public static string ToJson(this B2CDecodedToken self) => JsonConvert.SerializeObject(self, AADB2CTokenConverter.Settings);
    }
}