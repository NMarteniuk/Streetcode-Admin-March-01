﻿using FluentResults;
using MediatR;
using Streetcode.BLL.Dto.Media.Video;

namespace Streetcode.BLL.MediatR.Media.Video.GetById;

public record GetVideoByIdQuery(int Id) : IRequest<Result<VideoDto>>;
