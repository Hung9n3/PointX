namespace PointX.Properties.Entities
{
    public class District : BaseEntity 
    {
        public ICollection<Ward> Wards { get; set; } = new List<Ward>();
        public bool isCity { get; set; } = false;
    }
}
