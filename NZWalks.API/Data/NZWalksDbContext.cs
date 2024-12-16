using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<Region>Regions { get; set; }
        public DbSet<Difficulty> Difficulties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeding data for Difficulties
            // Easy, Medium, Hard

            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = Guid.Parse("83f93977-eeb7-4216-87bd-65ae85c6e0b3"),
                    Name = "Easy"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("7d332bfe-f9be-4b66-9e71-425c74d3fcd0"),
                    Name = "Medium"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("6952775b-308b-47e1-be6d-25e6dbf32f81"),
                    Name = "Hard"
                }
            };

            var regions = new List<Region>()
            {
                new Region()
                {
                 Id = Guid.Parse("2169e2cd-bd7b-420c-d8ff-08dd1471c86e"),
                 Code = "AUK",
                 Name = "Auckland",
                 RegionImageUrl = "https://t3.ftcdn.net/jpg/03/00/16/12/360_F_300161208_La3EDfz9cNa0X4zAXy5f6L1jeSakZ5Sl.jpg"
                },
                new Region()
                {
                 Id = Guid.Parse("ebf2bfa2-72c3-4616-4cbc-08dd1473d2d3"),
                 Code = "WLG",
                 Name = "Wellington",
                 RegionImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTZve4c12xSi2SQQVBuA-pxU-kt6gcS7wbhoA&s"
                },
                new Region()
                {
                 Id = Guid.Parse("021d6a13-7850-4da2-d5ac-08dd1474e97f"),
                 Code = "NRT",
                 Name = "Northland",
                 RegionImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS4lYpVRo00V_Z0zfCi3mrpR6ZHXyiU0Dtzxg&s"
                },
                new Region()
                {
                 Id = Guid.Parse("e536197d-1224-4608-f6c9-08dd153ea57d"),
                 Code = "QLS",
                 Name = "Queenstown Region",
                 RegionImageUrl = "https://www.google.com/imgres?q=queenstown%20wallapper&imgurl=https%3A%2F%2Fwallpapercat.com%2Fw%2Ffull%2F9%2F1%2F0%2F1535936-3840x2160-desktop-4k-queenstown-new-zealand-background-photo.jpg&imgrefurl=https%3A%2F%2Fwallpapercat.com%2Fqueenstown-new-zealand-wallpapers&docid=t3o2nTA5SAj41M&tbnid=Vh_9vUM_ihhjhM&vet=12ahUKEwjRhcSH9ZCKAxUpVPEDHe3_OJ4QM3oECGQQAA..i&w=3840&h=2160&hcb=2&ved=2ahUKEwjRhcSH9ZCKAxUpVPEDHe3_OJ4QM3oECGQQAA"
                },
                new Region()
                {
                 Id = Guid.Parse("7e086a07-0187-4490-8b8b-08dd154956fb"),
                 Code = "CTB",
                 Name = "Canterbury",
                 RegionImageUrl = "https://c4.wallpaperflare.com/wallpaper/782/88/989/blue-pink-and-green-textile-wallpaper-preview.jpg"
                },
                new Region()
                {
                 Id = Guid.Parse("2f12b662-9550-4d45-d824-08dd15cdf6d8"),
                 Code = "WKO",
                 Name = "Waikato",
                 RegionImageUrl = "https://media.gettyimages.com/id/1149987475/photo/hamilton-aerial-view.jpg?s=1024x1024&w=gi&k=20&c=SAd3OWPyQmjaVb0KbRB7qrRWISbuidfgKJmSj6SwOZU="
                },
                new Region
                {
                    Id = Guid.Parse("14ceba71-4b51-4777-9b17-46602cf66153"),
                    Name = "Bay Of Plenty",
                    Code = "BOP",
                    RegionImageUrl = null
                },
                new Region
                {
                    Id = Guid.Parse("906cb139-415a-4bbb-a174-1a1faf9fb1f6"),
                    Name = "Nelson",
                    Code = "NSN",
                    RegionImageUrl = "https://images.pexels.com/photos/13918194/pexels-photo-13918194.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region
                {
                    Id = Guid.Parse("f077a22e-4248-4bf6-b564-c7cf4e250263"),
                    Name = "Southland",
                    Code = "STL",
                    RegionImageUrl = null
                },
                new Region
                {
                    Id = Guid.Parse("6340ff43-4e2f-4034-802a-85518d5dd21c"),
                    Name = "Deneme",
                    Code = "DNM",
                    RegionImageUrl = null
                }
            };

            // Data seeding
            modelBuilder.Entity<Difficulty>().HasData(difficulties);
            modelBuilder.Entity<Region>().HasData(regions);

        }
    }
}
