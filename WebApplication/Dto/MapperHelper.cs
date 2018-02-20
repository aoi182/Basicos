using AutoMapper;
using WebApplication.Model;

namespace WebApplication.Dto
{
    public class MapperHelper
    {
        private IMapper mapper;

        public MapperHelper()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AgreementOffice, AgreementOfficeDto>();
                cfg.CreateMap<AgreementData, AgreementDataDto>();
                cfg.CreateMap<FinancialData_Rs, FinancialData_RsDto>();
                cfg.CreateMap<Invoices, InvoicesDto>();
            });
            mapper = config.CreateMapper();
        }

        public TDestination Map<TSource, TDestination>(TSource source) where TSource : class
        {
            return mapper.Map<TSource, TDestination>(source);
        }
    }
}