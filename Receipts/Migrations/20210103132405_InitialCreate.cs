using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Receipts.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Receipts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IngredientRecipe",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Quantity = table.Column<string>(type: "TEXT", nullable: true),
                    Ingredient = table.Column<string>(type: "TEXT", nullable: true),
                    ReceiptId1 = table.Column<Guid>(type: "TEXT", nullable: true),
                    ReceiptId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientRecipe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IngredientRecipe_Receipts_ReceiptId",
                        column: x => x.ReceiptId,
                        principalTable: "Receipts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientRecipe_Receipts_ReceiptId1",
                        column: x => x.ReceiptId1,
                        principalTable: "Receipts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StepRecipe",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Step = table.Column<string>(type: "TEXT", nullable: true),
                    ReceiptId1 = table.Column<Guid>(type: "TEXT", nullable: true),
                    ReceiptId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StepRecipe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StepRecipe_Receipts_ReceiptId",
                        column: x => x.ReceiptId,
                        principalTable: "Receipts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StepRecipe_Receipts_ReceiptId1",
                        column: x => x.ReceiptId1,
                        principalTable: "Receipts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientRecipe_ReceiptId",
                table: "IngredientRecipe",
                column: "ReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientRecipe_ReceiptId1",
                table: "IngredientRecipe",
                column: "ReceiptId1");

            migrationBuilder.CreateIndex(
                name: "IX_StepRecipe_ReceiptId",
                table: "StepRecipe",
                column: "ReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_StepRecipe_ReceiptId1",
                table: "StepRecipe",
                column: "ReceiptId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientRecipe");

            migrationBuilder.DropTable(
                name: "StepRecipe");

            migrationBuilder.DropTable(
                name: "Receipts");
        }
    }
}
