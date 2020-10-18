namespace FenixAlliance.Models.DTOs.Authorization
{
    public partial class JsonWebTokenHeader
    {
        /// <summary>
        /// Signing Algorithm
        /// </summary>
        public string alg { get; set; }
        /// <summary>
        /// JWK Set URL
        /// </summary>
        public string jku { get; set; }
        /// <summary>
        /// key ID
        /// </summary>
        public string kid { get; set; }
        /// <summary>
        /// Token Type
        /// </summary>
        public string typ { get; set; } = "JWT";
    }



}
