namespace Streetcode.BLL.Dto.AdditionalContent.Tag
{
    public class StreetcodeTagDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public bool IsVisible { get; set; }
        public int Index { get; set; }
    }
}
