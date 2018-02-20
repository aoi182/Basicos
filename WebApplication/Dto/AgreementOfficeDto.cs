using System;

namespace WebApplication.Dto
{
    [Serializable]
    public class AgreementOfficeDto
    {
        public string Description { get; set; }
        public string Id { get; set; }
        public string ShortName { get; set; }
    }
}