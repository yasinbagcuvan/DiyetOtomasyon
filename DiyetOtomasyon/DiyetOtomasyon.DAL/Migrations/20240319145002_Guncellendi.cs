using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiyetOtomasyon.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Guncellendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonMeal_Meals_MealId",
                table: "PersonMeal");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonMeal_Persons_PersonId",
                table: "PersonMeal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonMeal",
                table: "PersonMeal");

            migrationBuilder.RenameTable(
                name: "PersonMeal",
                newName: "PersonMeals");

            migrationBuilder.RenameColumn(
                name: "MealTime",
                table: "PersonMeals",
                newName: "MealTimeId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonMeal_MealId",
                table: "PersonMeals",
                newName: "IX_PersonMeals_MealId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonMeals",
                table: "PersonMeals",
                columns: new[] { "PersonId", "MealId", "CreatedDate" });

            migrationBuilder.CreateTable(
                name: "MealTime",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealTime", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonMeals_MealTimeId",
                table: "PersonMeals",
                column: "MealTimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonMeals_MealTime_MealTimeId",
                table: "PersonMeals",
                column: "MealTimeId",
                principalTable: "MealTime",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonMeals_Meals_MealId",
                table: "PersonMeals",
                column: "MealId",
                principalTable: "Meals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonMeals_Persons_PersonId",
                table: "PersonMeals",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonMeals_MealTime_MealTimeId",
                table: "PersonMeals");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonMeals_Meals_MealId",
                table: "PersonMeals");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonMeals_Persons_PersonId",
                table: "PersonMeals");

            migrationBuilder.DropTable(
                name: "MealTime");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonMeals",
                table: "PersonMeals");

            migrationBuilder.DropIndex(
                name: "IX_PersonMeals_MealTimeId",
                table: "PersonMeals");

            migrationBuilder.RenameTable(
                name: "PersonMeals",
                newName: "PersonMeal");

            migrationBuilder.RenameColumn(
                name: "MealTimeId",
                table: "PersonMeal",
                newName: "MealTime");

            migrationBuilder.RenameIndex(
                name: "IX_PersonMeals_MealId",
                table: "PersonMeal",
                newName: "IX_PersonMeal_MealId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonMeal",
                table: "PersonMeal",
                columns: new[] { "PersonId", "MealId", "CreatedDate" });

            migrationBuilder.AddForeignKey(
                name: "FK_PersonMeal_Meals_MealId",
                table: "PersonMeal",
                column: "MealId",
                principalTable: "Meals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonMeal_Persons_PersonId",
                table: "PersonMeal",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
