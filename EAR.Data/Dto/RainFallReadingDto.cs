namespace EAR.Data.Dto
{
    public class RainFallReadingDto
    {
        public string Id { get; set; }
        public DateTime DateTime { get; set; }
        public string? Measure { get; set; }
        public double Value { get; set; }
    }
}