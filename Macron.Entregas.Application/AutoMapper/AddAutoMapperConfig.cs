using AutoMapper;

namespace Macron.Entregas.Application.AutoMapper
{
    public class AddAutoMapperConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DomainToViewModelProfile>();
                cfg.AddProfile<ViewModelToDomainProfile>();

            });
        }
    }
}
