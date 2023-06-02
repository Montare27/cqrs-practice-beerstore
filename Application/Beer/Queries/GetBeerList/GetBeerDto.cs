namespace Application.Beer.Queries.GetBeerList
{
    public class GetBeerDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public float AlcoholPercentage { get; set; }
    }  
}
