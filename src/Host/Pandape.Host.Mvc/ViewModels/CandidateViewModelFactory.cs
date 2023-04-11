using AutoMapper;
using Pandape.Application.CQRS.Responses;
using System.Collections.Generic;
using System.Linq;

namespace Pandape.Host.Mvc.ViewModels
{
    public class CandidateViewModelFactory : ViewModelFactoryBase, ICandidateViewModelFactory
    {
        public CandidateViewModelFactory(IMapper mapper) : base(mapper)
        {
        }

        public GetAllCandidatesViewModel GetAll(GetAllCandidatesResponse getAllCandidatesResponse)
        {
            var viewModel = new GetAllCandidatesViewModel();

            var candidates = getAllCandidatesResponse.Candidates;

            viewModel.Candidates = Mapper.Map<IEnumerable<CandidateViewModel>>(candidates).ToList();

            return viewModel;
        }

        public GetDetailsCandidateViewModel Details(GetDetailsCandidateResponse getDetailsCandidateResponse)
        {
            var viewModel = new GetDetailsCandidateViewModel();

            viewModel.Candidate = getDetailsCandidateResponse.Candidate;

            viewModel.CandidateExperiences = getDetailsCandidateResponse.CandidateExperiences;

            return viewModel;
        }

        public EditCandidateViewModel Edit(GetByIdCandidateResponse getByIdCandidateResponse)
        {
            var viewModel = new EditCandidateViewModel();

            viewModel.Candidate = getByIdCandidateResponse.Candidate;

            return viewModel;
        }

        public DeleteCandidateViewModel Delete(GetByIdCandidateResponse getByIdCandidateResponse)
        {
            var viewModel = new DeleteCandidateViewModel();

            viewModel.Candidate = getByIdCandidateResponse.Candidate;

            return viewModel;
        }
    }
}