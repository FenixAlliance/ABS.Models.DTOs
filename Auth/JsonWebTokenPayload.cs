using System.Collections.Generic;

namespace FenixAlliance.ABM.Models.DTOs.Auth
{
    public partial class JsonWebTokenPayload
    {
        /// <summary>
        /// The audience for this token. (By default, the application ID)
        /// </summary>
        public string aud { get; set; }
        /// <summary>
        /// The Application ID for this token.
        /// </summary>
        public string cid { get; set; }
        /// <summary>
        /// The issuer of this token.
        /// </summary>
        public string iss { get; set; }
        /// <summary>
        /// The Alliance ID for this user.
        /// </summary>
        public string aid { get; set; }
        /// <summary>
        /// The acting enrollment
        /// </summary>
        public string sub { get; set; }
        /// <summary>
        /// The acting tenant
        /// </summary>
        public string act { get; set; }
        /// <summary>
        /// Issued at
        /// </summary>
        public long iat { get; set; }
        /// <summary>
        /// Not try to refresh Before.
        /// </summary>
        public long nbf { get; set; }
        /// <summary>
        /// Expiration time
        /// </summary>
        public long exp { get; set; }
        public List<string> Scopes { get; set; }
    }

}
