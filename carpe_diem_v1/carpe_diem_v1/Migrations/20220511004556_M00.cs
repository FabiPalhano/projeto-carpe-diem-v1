using Microsoft.EntityFrameworkCore.Migrations;

namespace carpe_diem_v1.Migrations
{
    public partial class M00 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hospedes",
                columns: table => new
                {
                    Cpf = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    EmailHospede = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    NomeCompHospede = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    DataNascimento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospedes", x => x.Cpf);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hospedes");
        }
    }
}
