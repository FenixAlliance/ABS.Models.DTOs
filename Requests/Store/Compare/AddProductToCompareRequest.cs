﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FenixAlliance.Models.DTOs.Requests
{
    public class AddProductToCompareRequest
    {
        public string CartID { get; set; }
        public string ProductID { get; set; }
    }
}