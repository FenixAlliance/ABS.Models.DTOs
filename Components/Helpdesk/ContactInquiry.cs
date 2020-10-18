using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FenixAlliance.Models.DTOs.Components.Support
{
    public class ContactInquiry
    {

        public string ContactID { get; set; }
        public string OrganizationID { get; set; }
        public bool GuestEnquiry { get; set; }


        public DateTime Timestamp { get; set; } = DateTime.Now;

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Given / Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Organization Name")]
        public string OrganizationName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Job Role")]
        public string JobRole { get; set; }

        [Required]
        [Display(Name = "Organization Domain")]
        public string OrganizationDomain { get; set; }

        [Display(Name = "Country")]
        public string CountryID { get; set; }
        [Required]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        [Required]
        [Display(Name = "Message")]
        public string Message { get; set; }

        // Honeypots
        [NotMapped]
        [DataType(DataType.Text)]
        public string _Name { get; set; }

        [NotMapped]
        [DataType(DataType.Text)]
        public string _LastName { get; set; }

        [NotMapped]
        [DataType(DataType.EmailAddress)]
        public string _Email { get; set; }

        [NotMapped]
        [DataType(DataType.PhoneNumber)]
        public string _PhoneNumber { get; set; }

        [NotMapped]
        [DataType(DataType.MultilineText)]
        public string _Message { get; set; }

        [NotMapped]

        public Dictionary<byte[], string> Uploads { get; set; }

    }
}
