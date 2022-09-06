using PointX.Properties.Entities;

namespace PointX.Properties.DTO
{
    public class UpNationDTO : Nation
    {
        public List<int> ProvinceIds { get; set; } = new List<int>();
    }
}
