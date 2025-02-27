﻿using FluentResults;
using MediatR;
using Streetcode.BLL.Dto.Partners;

namespace Streetcode.BLL.MediatR.Partners.GetById;

public record GetPartnerByIdQuery(int Id) : IRequest<Result<PartnerDto>>;
