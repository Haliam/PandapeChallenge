using AutoMapper;
using Pandape.Domain.Models.Candidate;
using Pandape.Host.Mvc.ViewModels;

namespace Pandape.Host.Mvc.Mapping
{
    public class CandidateProfile : Profile
    {
        public CandidateProfile() 
        { 
            CreateMap<CandidateModel, CandidateViewModel>().ReverseMap();
        }
    }
}
