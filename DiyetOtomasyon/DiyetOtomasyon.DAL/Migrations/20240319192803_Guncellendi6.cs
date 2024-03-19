using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiyetOtomasyon.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Guncellendi6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Meals",
                newName: "MealName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MealName",
                table: "Meals",
                newName: "Name");
        }
    }
}
