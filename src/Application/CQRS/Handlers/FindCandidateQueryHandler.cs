﻿using Pandape.Application.AppServices;
using Pandape.Application.CQRS.Queries;
using Pandape.Application.CQRS.Responses;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Pandape.Application.CQRS.Handlers
{
    public class FindCandidateQueryHandler : QueryHandlerBase<FindCandidateQuery, FindCandidateResponse>
    {
        public FindCandidateQueryHandler(IQueryCandidateAppService queryCandidateAppService) 
            : base(queryCandidateAppService)
        {
        }

        public override Task<FindCandidateResponse> Handle(FindCandidateQuery query, CancellationToken cancellationToken) =>
            QueryCandidateAppService.Find(query);
    }
}
