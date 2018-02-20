using System;
using WebApplication.Model;

namespace WebApplication.Dto
{
    [Serializable]
    public class ConsultInvoicePaymentResponseDto
    {
        public string AgreementIdReceiver;
        public string AgreementIdSender;
        public FinancialData_RsDto FinancialData;
        public string IdTran;
        public string InqDate;
        public InvoicesDto[] Invoices;
        public string Message;
        public string OfficeId;
        public string RequestId;
        public Status_Type Status;
        public string UserId;
    }
}
