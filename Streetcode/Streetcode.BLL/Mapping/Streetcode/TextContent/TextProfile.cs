using AutoMapper;
using Streetcode.BLL.Dto.Streetcode.TextContent.Text;
using Streetcode.BLL.DTO.Streetcode.TextContent.Text;
using Streetcode.DAL.Entities.Streetcode.TextContent;

namespace Streetcode.BLL.Mapping.Streetcode.TextContent;

public class TextProfile : Profile
{
    public TextProfile()
    {
        CreateMap<Text, TextDto>().ReverseMap();
        CreateMap<TextCreateDto, Text>().ReverseMap();
        CreateMap<UpdateTextRequestDto, Text>();
        CreateMap<Text, UpdateTextResponseDto>();
        CreateMap<CreateTextRequestDto, Text>();
        CreateMap<Text, CreateTextResponseDto>();
    }
}
