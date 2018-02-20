using AutoMapper.Model;

namespace AutoMapper.Dto
{
    public class MapperHelper
    {
        private readonly IMapper _mapper;

        public MapperHelper()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AgreementOffice, AgreementOfficeDto>();
                cfg.CreateMap<AgreementData, AgreementDataDto>();
                cfg.CreateMap<FinancialData_Rs, FinancialData_RsDto>();
                cfg.CreateMap<Invoices, InvoicesDto>();
            });
            _mapper = config.CreateMapper();
        }

        public TDestination Map<TSource, TDestination>(TSource source) where TSource : class
        {
            return _mapper.Map<TSource, TDestination>(source);
        }
    }
}