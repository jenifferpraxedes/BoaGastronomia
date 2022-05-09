using Microsoft.EntityFrameworkCore.Migrations;

namespace BoaGastronomia.Infra.Data.Migrations
{
    public partial class correction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Ratings_RatingId",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_RatingId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "RatingId",
                table: "Ingredients");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RatingId",
                table: "Ingredients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_RatingId",
                table: "Ingredients",
                column: "RatingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Ratings_RatingId",
                table: "Ingredients",
                column: "RatingId",
                principalTable: "Ratings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
