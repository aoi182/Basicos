using System;
using www.sugiro.net;

namespace WcfServiceLibrary
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        
        public ConsultDepositResponse ConsultDeposit(ConsultDepositRequest request)
        {
            return new ConsultDepositResponse(new ConsultDepositResponseBody
            {
                AgreementIdReceiver = "rec",
                AgreementIdSender = "sen",
                FinancialData = new FinancialDataRs(),
                IdTran = "2323",
                InqDate = "inq date",
                Message = "mess",
                OfficeId = "offid",
                RequestId = "rqs",
                Status = "status", 
                UserId = "usrId"
            });
        }
    }
}
