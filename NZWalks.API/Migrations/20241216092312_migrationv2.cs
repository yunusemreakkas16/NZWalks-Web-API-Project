using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class migrationv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LenghtInKm",
                table: "Walks",
                newName: "LengthInKm");

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[] { new Guid("6340ff43-4e2f-4034-802a-85518d5dd21c"), "DNM", "Deneme", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("6340ff43-4e2f-4034-802a-85518d5dd21c"));

            migrationBuilder.RenameColumn(
                name: "LengthInKm",
                table: "Walks",
                newName: "LenghtInKm");
        }
    }
}
