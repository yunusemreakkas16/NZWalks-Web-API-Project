﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NZWalks.API.Data;

#nullable disable

namespace NZWalks.API.Migrations
{
    [DbContext(typeof(NZWalksDbContext))]
    partial class NZWalksDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NZWalks.API.Models.Domain.Difficulty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Difficulties");

                    b.HasData(
                        new
                        {
                            Id = new Guid("83f93977-eeb7-4216-87bd-65ae85c6e0b3"),
                            Name = "Easy"
                        },
                        new
                        {
                            Id = new Guid("7d332bfe-f9be-4b66-9e71-425c74d3fcd0"),
                            Name = "Medium"
                        },
                        new
                        {
                            Id = new Guid("6952775b-308b-47e1-be6d-25e6dbf32f81"),
                            Name = "Hard"
                        });
                });

            modelBuilder.Entity("NZWalks.API.Models.Domain.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FileDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileExtension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FileSizeInBytes")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("NZWalks.API.Models.Domain.Region", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegionImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2169e2cd-bd7b-420c-d8ff-08dd1471c86e"),
                            Code = "AUK",
                            Name = "Auckland",
                            RegionImageUrl = "https://t3.ftcdn.net/jpg/03/00/16/12/360_F_300161208_La3EDfz9cNa0X4zAXy5f6L1jeSakZ5Sl.jpg"
                        },
                        new
                        {
                            Id = new Guid("ebf2bfa2-72c3-4616-4cbc-08dd1473d2d3"),
                            Code = "WLG",
                            Name = "Wellington",
                            RegionImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTZve4c12xSi2SQQVBuA-pxU-kt6gcS7wbhoA&s"
                        },
                        new
                        {
                            Id = new Guid("021d6a13-7850-4da2-d5ac-08dd1474e97f"),
                            Code = "NRT",
                            Name = "Northland",
                            RegionImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS4lYpVRo00V_Z0zfCi3mrpR6ZHXyiU0Dtzxg&s"
                        },
                        new
                        {
                            Id = new Guid("e536197d-1224-4608-f6c9-08dd153ea57d"),
                            Code = "QLS",
                            Name = "Queenstown Region",
                            RegionImageUrl = "https://www.google.com/imgres?q=queenstown%20wallapper&imgurl=https%3A%2F%2Fwallpapercat.com%2Fw%2Ffull%2F9%2F1%2F0%2F1535936-3840x2160-desktop-4k-queenstown-new-zealand-background-photo.jpg&imgrefurl=https%3A%2F%2Fwallpapercat.com%2Fqueenstown-new-zealand-wallpapers&docid=t3o2nTA5SAj41M&tbnid=Vh_9vUM_ihhjhM&vet=12ahUKEwjRhcSH9ZCKAxUpVPEDHe3_OJ4QM3oECGQQAA..i&w=3840&h=2160&hcb=2&ved=2ahUKEwjRhcSH9ZCKAxUpVPEDHe3_OJ4QM3oECGQQAA"
                        },
                        new
                        {
                            Id = new Guid("7e086a07-0187-4490-8b8b-08dd154956fb"),
                            Code = "CTB",
                            Name = "Canterbury",
                            RegionImageUrl = "https://c4.wallpaperflare.com/wallpaper/782/88/989/blue-pink-and-green-textile-wallpaper-preview.jpg"
                        },
                        new
                        {
                            Id = new Guid("2f12b662-9550-4d45-d824-08dd15cdf6d8"),
                            Code = "WKO",
                            Name = "Waikato",
                            RegionImageUrl = "https://media.gettyimages.com/id/1149987475/photo/hamilton-aerial-view.jpg?s=1024x1024&w=gi&k=20&c=SAd3OWPyQmjaVb0KbRB7qrRWISbuidfgKJmSj6SwOZU="
                        },
                        new
                        {
                            Id = new Guid("14ceba71-4b51-4777-9b17-46602cf66153"),
                            Code = "BOP",
                            Name = "Bay Of Plenty"
                        },
                        new
                        {
                            Id = new Guid("906cb139-415a-4bbb-a174-1a1faf9fb1f6"),
                            Code = "NSN",
                            Name = "Nelson",
                            RegionImageUrl = "https://images.pexels.com/photos/13918194/pexels-photo-13918194.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new
                        {
                            Id = new Guid("f077a22e-4248-4bf6-b564-c7cf4e250263"),
                            Code = "STL",
                            Name = "Southland"
                        },
                        new
                        {
                            Id = new Guid("6340ff43-4e2f-4034-802a-85518d5dd21c"),
                            Code = "DNM",
                            Name = "Deneme"
                        });
                });

            modelBuilder.Entity("NZWalks.API.Models.Domain.Walk", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DifficultyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("LengthInKm")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RegionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WalkImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DifficultyId");

                    b.HasIndex("RegionId");

                    b.ToTable("Walks");
                });

            modelBuilder.Entity("NZWalks.API.Models.Domain.Walk", b =>
                {
                    b.HasOne("NZWalks.API.Models.Domain.Difficulty", "Difficulty")
                        .WithMany()
                        .HasForeignKey("DifficultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NZWalks.API.Models.Domain.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Difficulty");

                    b.Navigation("Region");
                });
#pragma warning restore 612, 618
        }
    }
}
