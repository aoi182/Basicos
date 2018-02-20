namespace WebApplication.Model
{
    public class ConsultInvoicePaymentResponse
    {
        public string AgreementIdReceiver;
        public string AgreementIdSender;
        public FinancialData_Rs FinancialData;
        public string IdTran;
        public string InqDate;
        public Invoices[] Invoices;
        public string Message;
        public string OfficeId;
        public string RequestId;
        public Status_Type Status;
        public string UserId;
    }
}