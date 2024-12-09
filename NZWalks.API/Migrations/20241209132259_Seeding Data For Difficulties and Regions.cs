using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataForDifficultiesandRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6952775b-308b-47e1-be6d-25e6dbf32f81"), "Hard" },
                    { new Guid("7d332bfe-f9be-4b66-9e71-425c74d3fcd0"), "Medium" },
                    { new Guid("83f93977-eeb7-4216-87bd-65ae85c6e0b3"), "Easy" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("021d6a13-7850-4da2-d5ac-08dd1474e97f"), "NRT", "Northland", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS4lYpVRo00V_Z0zfCi3mrpR6ZHXyiU0Dtzxg&s" },
                    { new Guid("14ceba71-4b51-4777-9b17-46602cf66153"), "BOP", "Bay Of Plenty", null },
                    { new Guid("2169e2cd-bd7b-420c-d8ff-08dd1471c86e"), "AUK", "Auckland", "https://t3.ftcdn.net/jpg/03/00/16/12/360_F_300161208_La3EDfz9cNa0X4zAXy5f6L1jeSakZ5Sl.jpg" },
                    { new Guid("2f12b662-9550-4d45-d824-08dd15cdf6d8"), "WKO", "Waikato", "https://media.gettyimages.com/id/1149987475/photo/hamilton-aerial-view.jpg?s=1024x1024&w=gi&k=20&c=SAd3OWPyQmjaVb0KbRB7qrRWISbuidfgKJmSj6SwOZU=" },
                    { new Guid("7e086a07-0187-4490-8b8b-08dd154956fb"), "CTB", "Canterbury", "https://c4.wallpaperflare.com/wallpaper/782/88/989/blue-pink-and-green-textile-wallpaper-preview.jpg" },
                    { new Guid("906cb139-415a-4bbb-a174-1a1faf9fb1f6"), "NSN", "Nelson", "https://images.pexels.com/photos/13918194/pexels-photo-13918194.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("e536197d-1224-4608-f6c9-08dd153ea57d"), "QLS", "Queenstown Region", "https://www.google.com/imgres?q=queenstown%20wallapper&imgurl=https%3A%2F%2Fwallpapercat.com%2Fw%2Ffull%2F9%2F1%2F0%2F1535936-3840x2160-desktop-4k-queenstown-new-zealand-background-photo.jpg&imgrefurl=https%3A%2F%2Fwallpapercat.com%2Fqueenstown-new-zealand-wallpapers&docid=t3o2nTA5SAj41M&tbnid=Vh_9vUM_ihhjhM&vet=12ahUKEwjRhcSH9ZCKAxUpVPEDHe3_OJ4QM3oECGQQAA..i&w=3840&h=2160&hcb=2&ved=2ahUKEwjRhcSH9ZCKAxUpVPEDHe3_OJ4QM3oECGQQAA" },
                    { new Guid("ebf2bfa2-72c3-4616-4cbc-08dd1473d2d3"), "WLG", "Wellington", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTZve4c12xSi2SQQVBuA-pxU-kt6gcS7wbhoA&s" },
                    { new Guid("f077a22e-4248-4bf6-b564-c7cf4e250263"), "STL", "Southland", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("6952775b-308b-47e1-be6d-25e6dbf32f81"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("7d332bfe-f9be-4b66-9e71-425c74d3fcd0"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("83f93977-eeb7-4216-87bd-65ae85c6e0b3"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("021d6a13-7850-4da2-d5ac-08dd1474e97f"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("14ceba71-4b51-4777-9b17-46602cf66153"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("2169e2cd-bd7b-420c-d8ff-08dd1471c86e"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("2f12b662-9550-4d45-d824-08dd15cdf6d8"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("7e086a07-0187-4490-8b8b-08dd154956fb"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("906cb139-415a-4bbb-a174-1a1faf9fb1f6"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("e536197d-1224-4608-f6c9-08dd153ea57d"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("ebf2bfa2-72c3-4616-4cbc-08dd1473d2d3"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f077a22e-4248-4bf6-b564-c7cf4e250263"));
        }
    }
}
