using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace carpe_diem_v2.Migrations
{
    public partial class M02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoUsuario",
                table: "Hospedes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CadastroImovel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fotos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoEspaco = table.Column<int>(type: "int", nullable: false),
                    TipoAcomodacao = table.Column<int>(type: "int", nullable: false),
                    QuantHospedes = table.Column<int>(type: "int", nullable: false),
                    QuantCamas = table.Column<int>(type: "int", nullable: false),
                    QuantBanheiros = table.Column<int>(type: "int", nullable: false),
                    OpOferecer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoraCheckin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraCheckout = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DistPraia = table.Column<int>(type: "int", nullable: false),
                    ValorDiaria = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InfAdicionais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisponibilizarImovel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DesativarImovel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HospedeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroImovel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CadastroImovel_Hospedes_HospedeId",
                        column: x => x.HospedeId,
                        principalTable: "Hospedes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CadastroImovel_HospedeId",
                table: "CadastroImovel",
                column: "HospedeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CadastroImovel");

            migrationBuilder.DropColumn(
                name: "TipoUsuario",
                table: "Hospedes");
        }
    }
}
