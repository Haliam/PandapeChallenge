using Pandape.Application.CQRS.Responses;
using System.Collections.Generic;

namespace Pandape.Host.Mvc.ViewModels
{
    public class CandidateViewModelFactory : ICandidateViewModelFactory
    {

        public GetAllCandidatesViewModel GetAll(GetAllCandidatesResponse getAllCandidatesResponse)
        {
            var viewModel = new GetAllCandidatesViewModel();

            var candidates = getAllCandidatesResponse.Candidates;

            viewModel.Candidates = new List<CandidateViewModel>();

            foreach (var item in candidates)
            {
                var candidateViewModel = new CandidateViewModel();

                candidateViewModel.Id = item.Id;
                candidateViewModel.Name = item.Name;
                candidateViewModel.SurName = item.SurName;
                candidateViewModel.BirthDate = item.BirthDate;
                candidateViewModel.Email = item.Email;
                candidateViewModel.ModifyDate = item.ModifyDate;
                candidateViewModel.InsertDate = item.InsertDate;

                viewModel.Candidates.Add(candidateViewModel);
            }

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