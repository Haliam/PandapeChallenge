using AutoMapper;
using Pandape.Domain.Entities;
using Pandape.Domain.Models;

namespace Pandape.Application.Mapping
{
    public class CandidateAppProfile : Profile
    {
        public CandidateAppProfile() 
        { 
            CreateMap<Candidate, CandidateModel>().ReverseMap();
        }
    }
}
