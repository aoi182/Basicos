using System;

namespace WebApplication.Dto
{
    [Serializable]
    public class AgreementDataDto
    {
        public AgreementOfficeDto AgreementOffice { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }
        public string ShortName { get; set; }
    }
}