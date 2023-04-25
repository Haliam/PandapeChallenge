
using Pandape.Application.CQRS.Responses;

namespace Pandape.Host.Mvc.ViewModels
{
    public interface ICandidateViewModelFactory 
    {
        AllCandidatesViewModel GetAll(GetAllCandidatesResponse getAllCandidatesResponse);

        DetailsCandidateViewModel Details(GetDetailsCandidateResponse getDetailsCandidateResponse);

        EditCandidateViewModel Edit(GetByIdCandidateResponse getByIdCandidateResponse);

        DeleteCandidateViewModel Delete(GetByIdCandidateResponse getByIdCandidateResponse);
    }
}
