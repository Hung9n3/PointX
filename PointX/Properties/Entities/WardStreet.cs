namespace PointX.Properties.Entities
{
    public class WardStreet
    {
        public int id { get; set; }
        public Ward Ward { get; set; } = new Ward();
        public District District { get; set; } = new District();
    }
}
