using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cookery.Infrastructure.Migrations
{
    public partial class NutritionalInformationAndRecipeRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NutritionalInformationRecipe",
                columns: table => new
                {
                    NutritionalInformationId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionalInformationRecipe", x => new { x.NutritionalInformationId, x.RecipeId });
                    table.ForeignKey(
                        name: "FK_NutritionalInformationRecipe_nutritionalInformations_NutritionalInformationId",
                        column: x => x.NutritionalInformationId,
                        principalTable: "nutritionalInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NutritionalInformationRecipe_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NutritionalInformationRecipe_RecipeId",
                table: "NutritionalInformationRecipe",
                column: "RecipeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NutritionalInformationRecipe");
        }
    }
}
