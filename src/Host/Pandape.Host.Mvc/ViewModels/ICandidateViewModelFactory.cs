
using Pandape.Application.CQRS.Responses;

namespace Pandape.Host.Mvc.ViewModels
{
    public interface ICandidateViewModelFactory 
    {
        GetAllCandidatesViewModel GetAll(GetAllCandidatesResponse getAllCandidatesResponse);

        GetDetailsCandidateViewModel Details(GetDetailsCandidateResponse getDetailsCandidateResponse);

        EditCandidateViewModel Edit(GetByIdCandidateResponse getByIdCandidateResponse);

        DeleteCandidateViewModel Delete(GetByIdCandidateResponse getByIdCandidateResponse);
    }
}
