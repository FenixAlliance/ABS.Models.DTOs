namespace FenixAlliance.ABM.Models.DTOs.Auth.AADB2C
{
    public class AADB2COptions
    {

        public string ApiUrl { get; set; }

        public string Domain { get; set; }

        public string ClientId { get; set; }

        public string Instance { get; set; }

        public string ApiScopes { get; set; }

        public string RedirectUri { get; set; }

        public string CallbackPath { get; set; }

        public string ClientSecret { get; set; }

        public string EditProfilePolicyId { get; set; }

        public string SignUpSignInPolicyId { get; set; }

        public string ResetPasswordPolicyId { get; set; }

        public string DefaultPolicy => SignUpSignInPolicyId;

        public const string PolicyAuthenticationProperty = "Policy";

        public string Authority => $"{Instance}/{Domain}/{DefaultPolicy}/v2.0";


    }
}
