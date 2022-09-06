using Microsoft.EntityFrameworkCore;
using PointX.Properties.Entities;

namespace PointX.Migrations
{
    public class PointXContext:DbContext
    {
        public PointXContext(DbContextOptions<PointXContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public DbSet<Nation> Nations { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<WardStreet> WardStreets { get; set; }
        public DbSet<Ward> Wards { get; set; }
        public DbSet<Street> Streets { get; set; }
    }
}
