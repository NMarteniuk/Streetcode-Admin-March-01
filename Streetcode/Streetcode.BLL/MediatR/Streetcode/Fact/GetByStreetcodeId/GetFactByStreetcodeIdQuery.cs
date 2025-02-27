﻿using FluentResults;
using MediatR;
using Streetcode.BLL.Dto.Streetcode.TextContent.Fact;

namespace Streetcode.BLL.MediatR.Streetcode.Fact.GetByStreetcodeId;

public record GetFactByStreetcodeIdQuery(int StreetcodeId) : IRequest<Result<IEnumerable<FactDto>>>;