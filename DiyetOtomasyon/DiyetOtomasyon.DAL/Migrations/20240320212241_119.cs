using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiyetOtomasyon.DAL.Migrations
{
    /// <inheritdoc />
    public partial class _119 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonMeals",
                table: "PersonMeals");

            migrationBuilder.DropIndex(
                name: "IX_PersonMeals_MealId",
                table: "PersonMeals");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonMeals",
                table: "PersonMeals",
                columns: new[] { "MealId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_PersonMeals_PersonId",
                table: "PersonMeals",
                column: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonMeals",
                table: "PersonMeals");

            migrationBuilder.DropIndex(
                name: "IX_PersonMeals_PersonId",
                table: "PersonMeals");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonMeals",
                table: "PersonMeals",
                columns: new[] { "PersonId", "MealId", "CreatedDate" });

            migrationBuilder.CreateIndex(
                name: "IX_PersonMeals_MealId",
                table: "PersonMeals",
                column: "MealId");
        }
    }
}
