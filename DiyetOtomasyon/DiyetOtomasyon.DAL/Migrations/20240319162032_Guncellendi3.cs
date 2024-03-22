using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiyetOtomasyon.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Guncellendi3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Size",
                table: "Portions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PortionId",
                table: "Portions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PortionId",
                table: "PersonMeals",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                name: "IX_PersonMeals_PortionId",
                table: "PersonMeals",
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
                name: "FK_PersonMeals_Portions_PortionId",
                table: "PersonMeals",
                column: "PortionId",
                principalTable: "Portions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Portions_Portions_PortionId",
                table: "Portions",
                column: "PortionId",
                principalTable: "Portions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealTimes_MealTimes_MealTimeId",
                table: "MealTimes");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonMeals_Portions_PortionId",
                table: "PersonMeals");

            migrationBuilder.DropForeignKey(
                name: "FK_Portions_Portions_PortionId",
                table: "Portions");

            migrationBuilder.DropIndex(
                name: "IX_Portions_PortionId",
                table: "Portions");

            migrationBuilder.DropIndex(
                name: "IX_PersonMeals_PortionId",
                table: "PersonMeals");

            migrationBuilder.DropIndex(
                name: "IX_MealTimes_MealTimeId",
                table: "MealTimes");

            migrationBuilder.DropColumn(
                name: "PortionId",
                table: "Portions");

            migrationBuilder.DropColumn(
                name: "PortionId",
                table: "PersonMeals");

            migrationBuilder.DropColumn(
                name: "MealTimeId",
                table: "MealTimes");

            migrationBuilder.AlterColumn<int>(
                name: "Size",
                table: "Portions",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
