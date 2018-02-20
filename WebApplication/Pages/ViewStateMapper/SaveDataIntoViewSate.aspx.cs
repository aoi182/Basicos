using System;
using System.Web.UI;
using WebApplication.Dto;
using WebApplication.Model;

namespace WebApplication.Pages.ViewStateMapper
{
    public partial class SaveDataIntoViewSate : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            //ViewState["data"] = CreateData();
            ViewState["data"] = new ConsultInvoicePaymentResponse();
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            var data = (ConsultInvoicePaymentResponseDto)ViewState["data"];
        }
        
        private ConsultInvoicePaymentResponseDto CreateData()
        {
            var source = new ConsultInvoicePaymentResponse
            {
                AgreementIdReceiver = "AgreementIdReceiver",
                AgreementIdSender = "AgreementIdSender",
                IdTran = "IdTran",
                InqDate = "InqDate",
                Message = "Message",
                OfficeId = "OfficeId",
                Status = Status_Type.Item01,
                UserId = "UserId",
                RequestId = "RequestId",
                FinancialData = new FinancialData_Rs
                {
                    OwnerId = "OwnerId",
                    OwnerIdType = "OwnerIdType",
                    OwnerLastName1 = "OwnerLastName1",
                    OwnerLastName2 = "OwnerLastName2",
                    OwnerName1 = "OwnerName1",
                    OwnerName2 = "OwnerName2",
                    AgreementData = new AgreementData
                    {
                        Description = "Description",
                        Id = "Id",
                        ShortName = "ShortName",
                        AgreementOffice = new AgreementOffice
                        {
                            Description = "Description",
                            Id = "Id",
                            ShortName = "ShortName"
                        }
                    }
                },
                Invoices = new Invoices[] {
                    new Invoices
                    {
                        EndPaymentDate = "EndPaymentDate",
                        ExpirationDate="ExpirationDate",
                        InvoiceId="InvoiceId_01",
                        InvoiceStatus=InvoiceStatus_type.Item0,
                        TotalValue="TotalValue"
                    },
                    new Invoices
                    {
                        EndPaymentDate = "EndPaymentDate",
                        ExpirationDate="ExpirationDate",
                        InvoiceId="InvoiceId_02",
                        InvoiceStatus=InvoiceStatus_type.Item1,
                        TotalValue="TotalValue"
                    }
                },
            };

            MapperHelper mapper = new MapperHelper();

            return mapper.Map<ConsultInvoicePaymentResponse, ConsultInvoicePaymentResponseDto>(source);
        }
    }
}