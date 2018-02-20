using AutoMapper.Dto;
using AutoMapper.Model;

namespace AutoMapper
{
    class Program
    {
        static void Main(string[] args)
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

            var dto = mapper.Map<ConsultInvoicePaymentResponse, ConsultInvoicePaymentResponseDto>(source);
        }
    }
}