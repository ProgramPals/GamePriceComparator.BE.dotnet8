using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addedImageData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverImage",
                table: "Games");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "GameImages",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "GameImages");

            migrationBuilder.AddColumn<byte[]>(
                name: "CoverImage",
                table: "Games",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
