using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cafeManagement.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRestorauntEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RestorauntLocation",
                table: "RestorauntManagers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RestorauntName",
                table: "RestorauntManagers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RestorauntLocation",
                table: "RestorauntManagers");

            migrationBuilder.DropColumn(
                name: "RestorauntName",
                table: "RestorauntManagers");
        }
    }
}
