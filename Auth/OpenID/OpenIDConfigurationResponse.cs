using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FenixAlliance.ABM.Models.DTOs.Auth.OpenID
{
    public partial class OpenIdConfigurationResponse
    {
        [JsonProperty("issuer")]
        public Uri Issuer { get; set; }

        [JsonProperty("authorization_endpoint")]
        public Uri AuthorizationEndpoint { get; set; }

        [JsonProperty("token_endpoint")]
        public Uri TokenEndpoint { get; set; }

        [JsonProperty("end_session_endpoint")]
        public Uri EndSessionEndpoint { get; set; }

        [JsonProperty("jwks_uri")]
        public Uri JwksUri { get; set; }

        [JsonProperty("response_modes_supported")]
        public List<string> ResponseModesSupported { get; set; }

        [JsonProperty("response_types_supported")]
        public List<string> ResponseTypesSupported { get; set; }

        [JsonProperty("scopes_supported")]
        public List<string> ScopesSupported { get; set; }

        [JsonProperty("subject_types_supported")]
        public List<string> SubjectTypesSupported { get; set; }

        [JsonProperty("id_token_signing_alg_values_supported")]
        public List<string> IdTokenSigningAlgValuesSupported { get; set; }

        [JsonProperty("token_endpoint_auth_methods_supported")]
        public List<string> TokenEndpointAuthMethodsSupported { get; set; }

        [JsonProperty("claims_supported")]
        public List<string> ClaimsSupported { get; set; }
    }


}