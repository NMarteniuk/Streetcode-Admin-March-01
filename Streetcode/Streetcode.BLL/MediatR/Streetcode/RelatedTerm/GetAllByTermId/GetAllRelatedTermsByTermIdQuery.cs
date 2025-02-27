﻿using FluentResults;
using MediatR;
using Streetcode.BLL.Dto.Streetcode.TextContent;

namespace Streetcode.BLL.MediatR.Streetcode.RelatedTerm.GetAllByTermId
{
    public record GetAllRelatedTermsByTermIdQuery(int id) : IRequest<Result<IEnumerable<RelatedTermDto>>>
    {
    }
}
