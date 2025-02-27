﻿using FluentResults;
using MediatR;
using Streetcode.BLL.Dto.AdditionalContent.Coordinates.Types;

namespace Streetcode.BLL.MediatR.AdditionalContent.Coordinate.Create;

public record CreateCoordinateCommand(StreetcodeCoordinateDto StreetcodeCoordinate) : IRequest<Result<Unit>>;