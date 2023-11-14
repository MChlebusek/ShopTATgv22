using System.Text.Json.Serialization;

namespace Shop.Core.Dto.ChuckNorrisDtos
{
    public class ChuckNorrisResultDto
    {
        public string Categories { get; set; }
        public DateTime CreatedAt { get; set; }
        public Uri IconUrl { get; set; }
        public string Id { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Url { get; set; }
        public string Value { get; set; }
    }
}