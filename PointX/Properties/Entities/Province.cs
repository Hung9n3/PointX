namespace PointX.Properties.Entities
{
    public class Province:BaseEntity
    {
        public ICollection<District> Districts { get; set; } = new List<District>();
        public bool isCity { get; set; } = false;

    }
}
