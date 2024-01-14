using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apivendas.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterandoRequerimentosDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estoque_Produtos_IdProduto",
                table: "Estoque");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estoque",
                table: "Estoque");

            migrationBuilder.RenameTable(
                name: "Estoque",
                newName: "Estoques");

            migrationBuilder.RenameIndex(
                name: "IX_Estoque_IdProduto",
                table: "Estoques",
                newName: "IX_Estoques_IdProduto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estoques",
                table: "Estoques",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Estoques_Produtos_IdProduto",
                table: "Estoques",
                column: "IdProduto",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estoques_Produtos_IdProduto",
                table: "Estoques");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estoques",
                table: "Estoques");

            migrationBuilder.RenameTable(
                name: "Estoques",
                newName: "Estoque");

            migrationBuilder.RenameIndex(
                name: "IX_Estoques_IdProduto",
                table: "Estoque",
                newName: "IX_Estoque_IdProduto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estoque",
                table: "Estoque",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Estoque_Produtos_IdProduto",
                table: "Estoque",
                column: "IdProduto",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
