using Microsoft.EntityFrameworkCore.Migrations;

namespace BuscaCep.WebApi.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cep = table.Column<string>(nullable: true),
                    Logradouro = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Localidade = table.Column<string>(nullable: true),
                    Uf = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "Id", "Bairro", "Cep", "Complemento", "Localidade", "Logradouro", "Uf" },
                values: new object[] { 1, "Pedregulho", "12515160", "", "Guaratinguetá", "Rua Alfonso Giannico", "SP" });

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "Id", "Bairro", "Cep", "Complemento", "Localidade", "Logradouro", "Uf" },
                values: new object[] { 2, "Pedregulho", "12345678", "", "Guaratinguetá", "Rua Alfonso Giannico", "SP" });

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "Id", "Bairro", "Cep", "Complemento", "Localidade", "Logradouro", "Uf" },
                values: new object[] { 3, "Pedregulho", "87654321", "", "Guaratinguetá", "Rua Alfonso Giannico", "SP" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enderecos");
        }
    }
}
