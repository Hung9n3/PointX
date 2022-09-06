namespace PointX.Properties.Entities
{
    public class Street:BaseEntity
    {
        public ICollection<WardStreet> WardStreets { get; set; } = new HashSet<WardStreet>();

    }
}
