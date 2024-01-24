using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apivendas.Migrations
{
    /// <inheritdoc />
    public partial class Updating_ProdutoId_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_VendaItems_ProdutoId",
                table: "VendaItems",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_VendaItems_Produtos_ProdutoId",
                table: "VendaItems",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VendaItems_Produtos_ProdutoId",
                table: "VendaItems");

            migrationBuilder.DropIndex(
                name: "IX_VendaItems_ProdutoId",
                table: "VendaItems");
        }
    }
}
