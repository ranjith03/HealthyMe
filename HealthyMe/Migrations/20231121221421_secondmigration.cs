using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthyMe.Migrations
{
    /// <inheritdoc />
    public partial class secondmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meal_AspNetUsers_UserId",
                table: "Meal");

            migrationBuilder.DropForeignKey(
                name: "FK_MealItem_Food_FdcId",
                table: "MealItem");

            migrationBuilder.DropForeignKey(
                name: "FK_MealItem_Meal_MealId",
                table: "MealItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MealItem",
                table: "MealItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Meal",
                table: "Meal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Food",
                table: "Food");

            migrationBuilder.RenameTable(
                name: "MealItem",
                newName: "MealItems");

            migrationBuilder.RenameTable(
                name: "Meal",
                newName: "Meals");

            migrationBuilder.RenameTable(
                name: "Food",
                newName: "Foods");

            migrationBuilder.RenameIndex(
                name: "IX_MealItem_MealId",
                table: "MealItems",
                newName: "IX_MealItems_MealId");

            migrationBuilder.RenameIndex(
                name: "IX_MealItem_FdcId",
                table: "MealItems",
                newName: "IX_MealItems_FdcId");

            migrationBuilder.RenameIndex(
                name: "IX_Meal_UserId",
                table: "Meals",
                newName: "IX_Meals_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MealItems",
                table: "MealItems",
                column: "MealItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Meals",
                table: "Meals",
                column: "mealId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Foods",
                table: "Foods",
                column: "FdcId");

            migrationBuilder.AddForeignKey(
                name: "FK_MealItems_Foods_FdcId",
                table: "MealItems",
                column: "FdcId",
                principalTable: "Foods",
                principalColumn: "FdcId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MealItems_Meals_MealId",
                table: "MealItems",
                column: "MealId",
                principalTable: "Meals",
                principalColumn: "mealId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Meals_AspNetUsers_UserId",
                table: "Meals",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealItems_Foods_FdcId",
                table: "MealItems");

            migrationBuilder.DropForeignKey(
                name: "FK_MealItems_Meals_MealId",
                table: "MealItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Meals_AspNetUsers_UserId",
                table: "Meals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Meals",
                table: "Meals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MealItems",
                table: "MealItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Foods",
                table: "Foods");

            migrationBuilder.RenameTable(
                name: "Meals",
                newName: "Meal");

            migrationBuilder.RenameTable(
                name: "MealItems",
                newName: "MealItem");

            migrationBuilder.RenameTable(
                name: "Foods",
                newName: "Food");

            migrationBuilder.RenameIndex(
                name: "IX_Meals_UserId",
                table: "Meal",
                newName: "IX_Meal_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_MealItems_MealId",
                table: "MealItem",
                newName: "IX_MealItem_MealId");

            migrationBuilder.RenameIndex(
                name: "IX_MealItems_FdcId",
                table: "MealItem",
                newName: "IX_MealItem_FdcId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Meal",
                table: "Meal",
                column: "mealId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MealItem",
                table: "MealItem",
                column: "MealItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Food",
                table: "Food",
                column: "FdcId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meal_AspNetUsers_UserId",
                table: "Meal",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MealItem_Food_FdcId",
                table: "MealItem",
                column: "FdcId",
                principalTable: "Food",
                principalColumn: "FdcId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MealItem_Meal_MealId",
                table: "MealItem",
                column: "MealId",
                principalTable: "Meal",
                principalColumn: "mealId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
