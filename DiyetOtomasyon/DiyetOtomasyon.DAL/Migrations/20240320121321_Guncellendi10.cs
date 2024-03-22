using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiyetOtomasyon.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Guncellendi10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealTimes_MealTimes_MealTimeId",
                table: "MealTimes");

            migrationBuilder.DropForeignKey(
                name: "FK_Portions_Portions_PortionId",
                table: "Portions");

            migrationBuilder.DropIndex(
                name: "IX_Portions_PortionId",
                table: "Portions");

            migrationBuilder.DropIndex(
                name: "IX_MealTimes_MealTimeId",
                table: "MealTimes");

            migrationBuilder.DropColumn(
                name: "PortionId",
                table: "Portions");

            migrationBuilder.DropColumn(
                name: "MealTimeId",
                table: "MealTimes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PortionId",
                table: "Portions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MealTimeId",
                table: "MealTimes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Portions_PortionId",
                table: "Portions",
                column: "PortionId");

            migrationBuilder.CreateIndex(
                name: "IX_MealTimes_MealTimeId",
                table: "MealTimes",
                column: "MealTimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_MealTimes_MealTimes_MealTimeId",
                table: "MealTimes",
                column: "MealTimeId",
                principalTable: "MealTimes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Portions_Portions_PortionId",
                table: "Portions",
                column: "PortionId",
                principalTable: "Portions",
                principalColumn: "Id");
        }
    }
}
