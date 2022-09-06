namespace PointX.Properties.Entities
{
    public class Nation : BaseEntity
    {
        public ICollection<Province> Provinces { get; set; } = new HashSet<Province>();

    }
}
