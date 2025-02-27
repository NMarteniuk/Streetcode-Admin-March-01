﻿using AutoMapper;
using Streetcode.BLL.DTO.Analytics.StatisticRecord;
using Streetcode.DAL.Entities.Analytics;

namespace Streetcode.BLL.Mapping.Analytics;

public class StatisticRecordProfile : Profile
{
    public StatisticRecordProfile()
    {
        CreateMap<CreateStatisticRecordRequestDto, StatisticRecord>();
        CreateMap<StatisticRecord, CreateStatisticRecordResponseDto>();
    }
}
