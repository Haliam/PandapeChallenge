using AutoMapper;

namespace Pandape.Host.Mvc.Mapping
{
    public class AutoMapperConfig
    {

        public AutoMapperConfig()
        {
            InitializeAutomapper();
        }

        private void InitializeAutomapper()
        {
            var config = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new CandidateProfile());
            });

            IMapper mapper = config.CreateMapper();
        }
    }
}
