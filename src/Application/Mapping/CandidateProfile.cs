using AutoMapper;
using Pandape.Application.CQRS.Commands;
using Pandape.Application.CQRS.Responses;
using Pandape.Domain.Entities;
using System.Collections.Generic;

namespace Pandape.Application.Mapping
{
    public class CandidateProfile : Profile
    {
        public CandidateProfile() 
        { 
            CreateMap<Candidate, InsertCandidateCommand>().ReverseMap();

            CreateMap<Candidate, InsertCandidateResponse>().ReverseMap();

            CreateMap<IEnumerable<Candidate>, GetAllCandidatesResponse>().ReverseMap();
        }
    }
}
