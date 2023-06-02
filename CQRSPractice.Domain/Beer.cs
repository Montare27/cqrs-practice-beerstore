namespace CQRSPractice.Domain
{
    public class Beer
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Production { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public float AlcoholPercentage { get; set; }
    }
}
