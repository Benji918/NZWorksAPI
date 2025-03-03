namespace NZWorksAPI.Models.Domain
{
    public class Work
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInKilometers { get; set; }
        public string? WorkImageUrl { get; set; }

        public Guid DifficultyId { get; set; }
        public Guid RegionId { get; set; }

        //Navigation property
        public Difficulty Difficulty { get; set; }
        public Region Region { get; set; }
    }
}
