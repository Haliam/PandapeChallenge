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

        public GetAllCandidatesViewModel GetAll(GetAllCandidatesResponse response)
        {
            var viewModel = new GetAllCandidatesViewModel();

            viewModel.Candidates = Mapper.Map<IEnumerable<CandidateViewModel>>(response.CandidatesDto).ToList();

            return viewModel;
        }

        public GetDetailsCandidateViewModel Details(GetDetailsCandidateResponse response)
        {
            var viewModel = new GetDetailsCandidateViewModel();

            viewModel.Candidate = Mapper.Map<CandidateViewModel>(response.CandidateDto);

            viewModel.CandidateExperiences = Mapper.Map<List<CandidateExperienceViewModel>>(response.CandidateExperiencesDto);

            return viewModel;
        }

        public EditCandidateViewModel Edit(GetByIdCandidateResponse response)
        {
            var viewModel = new EditCandidateViewModel();

            viewModel.Candidate = Mapper.Map<CandidateViewModel>(response.CandidateDto);

            return viewModel;
        }

        public DeleteCandidateViewModel Delete(GetByIdCandidateResponse response)
        {
            var viewModel = new DeleteCandidateViewModel();

            viewModel.Candidate = Mapper.Map<CandidateViewModel>(response.CandidateDto);

            return viewModel;
        }
    }
}