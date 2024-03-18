namespace EAR.Common.Models
{
    public class RainFallReading
    {
        public string Id { get; set; }
        public DateTime DateTime { get; set; }
        public string? Measure { get; set; }
        public double Value { get; set; }
    }
}