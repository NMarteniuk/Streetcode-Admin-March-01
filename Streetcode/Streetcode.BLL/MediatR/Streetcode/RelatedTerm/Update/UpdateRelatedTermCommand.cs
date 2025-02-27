﻿using FluentResults;
using MediatR;
using Streetcode.BLL.Dto.Streetcode.TextContent;

namespace Streetcode.BLL.MediatR.Streetcode.RelatedTerm.Update
{
    public record UpdateRelatedTermCommand(int id, RelatedTermDto RelatedTerm) : IRequest<Result<Unit>>
    {
    }
}
