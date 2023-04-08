using MediatR;
using Microsoft.AspNetCore.Mvc;
using Pandape.Application.CQRS.Commands;
using Pandape.Application.CQRS.Queries;
using Pandape.Domain.Entities;
using System.Threading.Tasks;

namespace Pandape.Host.Mvc.Controllers
{
    public class CandidatesController : Controller
    {
        protected IMediator Mediator { get; }

        public CandidatesController(IMediator mediator) => Mediator = mediator;


        // GET: Candidates
        public async Task<IActionResult> Index()
        {
            var response = await Mediator.Send(new GetAllCandidatesQuery());

            return View(response.Candidates);
        }


        // GET: Candidates/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var response = await Mediator.Send(new GetDetailsCandidateQuery(id));

            return View(response.Candidate);
        }

        // GET: Candidates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Candidates/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,SurName,BirthDate,Email,InsertDate,ModifyDate")] Candidate candidate)
        {
            if (ModelState.IsValid)
            {
                var response = await Mediator.Send(new InsertCandidateCommand(candidate));

                return RedirectToAction(nameof(Index));
            }

            return View(candidate);
        }

        // GET: Candidates/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var response = await Mediator.Send(new GetByIdCandidateQuery(id));

            return View(response.Candidate);
        }

        // POST: Candidates/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,SurName,BirthDate,Email,InsertDate,ModifyDate")] Candidate candidate)
        {
            if (ModelState.IsValid)
            {
                var response = await Mediator.Send(new UpdateCandidateCommand(id, candidate));

                return RedirectToAction(nameof(Index));
            }

            return View(candidate);
        }

        // GET: Candidates/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var response = await Mediator.Send(new GetByIdCandidateQuery(id));

            return View(response.Candidate);
        }

        // POST: Candidates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var response = await Mediator.Send(new DeleteCandidateCommand(id));

            return RedirectToAction(nameof(Index));
        }
    }
}
