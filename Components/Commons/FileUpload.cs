﻿namespace FenixAlliance.Models.DTOs.Components.Commons
{
    public class FileUpload
    {
        public byte[] Bytes { get; set; }

        public string ContentType { get; set; }

        public string Base64String { get; set; }
    }
}
