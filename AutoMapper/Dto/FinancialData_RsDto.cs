using System;

namespace AutoMapper.Dto
{
    [Serializable]
    public class FinancialData_RsDto
    {
        public AgreementDataDto AgreementData { get; set; }
        public string OwnerId { get; set; }
        public string OwnerIdType { get; set; }
        public string OwnerLastName1 { get; set; }
        public string OwnerLastName2 { get; set; }
        public string OwnerName1 { get; set; }
        public string OwnerName2 { get; set; }
    }
}