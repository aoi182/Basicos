﻿using System;
using WebApplication.Model;

namespace WebApplication.Dto
{
    [Serializable]
    public class InvoicesDto
    {
        public string EndPaymentDate { get; set; }
        public string ExpirationDate { get; set; }
        public string InvoiceId { get; set; }
        public InvoiceStatus_type InvoiceStatus { get; set; }
        public string TotalValue { get; set; }
    }
}