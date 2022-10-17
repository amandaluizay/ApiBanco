using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ContaBancarias",
                table: "ContaBancarias");

            migrationBuilder.RenameTable(
                name: "ContaBancarias",
                newName: "ContaBancaria");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContaBancaria",
                table: "ContaBancaria",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ContaBancaria",
                table: "ContaBancaria");

            migrationBuilder.RenameTable(
                name: "ContaBancaria",
                newName: "ContaBancarias");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContaBancarias",
                table: "ContaBancarias",
                column: "Id");
        }
    }
}
