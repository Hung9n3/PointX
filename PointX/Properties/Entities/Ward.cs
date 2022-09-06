namespace PointX.Properties.Entities
{
    public class Ward:BaseEntity
    {
        public ICollection<WardStreet> WardStreets { get; set; } = new HashSet<WardStreet>();

    }
}
