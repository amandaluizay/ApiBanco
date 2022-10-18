using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContaBancaria",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CPF = table.Column<string>(type: "varchar(100)", nullable: false),
                    Agencia = table.Column<string>(type: "varchar(200)", nullable: false),
                    ContaCorrente = table.Column<string>(type: "varchar(200)", nullable: false),
                    Senha8dig = table.Column<int>(type: "INT", nullable: false),
                    Senha6dig = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaBancaria", x => x.Id);
                    table.UniqueConstraint("AK_ContaBancaria_CPF", x => x.CPF);
                });

            migrationBuilder.CreateTable(
                name: "ContaJuridica",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cnpj = table.Column<string>(type: "varchar(100)", nullable: false),
                    ChaveJ = table.Column<string>(type: "varchar(200)", nullable: false),
                    Usuario = table.Column<string>(type: "varchar(200)", nullable: false),
                    Senha8Dig = table.Column<int>(type: "INT", nullable: false),
                    Senha6Dig = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaJuridica", x => x.Id);
                    table.UniqueConstraint("AK_ContaJuridica_Cnpj", x => x.Cnpj);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContaBancaria");

            migrationBuilder.DropTable(
                name: "ContaJuridica");
        }
    }
}
