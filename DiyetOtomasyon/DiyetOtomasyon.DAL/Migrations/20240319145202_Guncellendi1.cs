using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiyetOtomasyon.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Guncellendi1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonMeals_MealTime_MealTimeId",
                table: "PersonMeals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MealTime",
                table: "MealTime");

            migrationBuilder.RenameTable(
                name: "MealTime",
                newName: "MealTimes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MealTimes",
                table: "MealTimes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonMeals_MealTimes_MealTimeId",
                table: "PersonMeals",
                column: "MealTimeId",
                principalTable: "MealTimes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonMeals_MealTimes_MealTimeId",
                table: "PersonMeals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MealTimes",
                table: "MealTimes");

            migrationBuilder.RenameTable(
                name: "MealTimes",
                newName: "MealTime");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MealTime",
                table: "MealTime",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonMeals_MealTime_MealTimeId",
                table: "PersonMeals",
                column: "MealTimeId",
                principalTable: "MealTime",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
