using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Linea_Denuncia_API.Migrations
{
    /// <inheritdoc />
    public partial class NV03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Denuncia",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Anonim",
                table: "Denuncia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Complete_Name",
                table: "Denuncia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Country_id",
                table: "Denuncia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Create_Date",
                table: "Denuncia",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Detalle",
                table: "Denuncia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EO_Id",
                table: "Denuncia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Denuncia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Folio",
                table: "Denuncia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Denuncia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "State_id",
                table: "Denuncia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "User_Password",
                table: "Denuncia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Denuncia",
                table: "Denuncia",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Countrys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Complete_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countrys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countrys");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Denuncia",
                table: "Denuncia");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Denuncia");

            migrationBuilder.DropColumn(
                name: "Anonim",
                table: "Denuncia");

            migrationBuilder.DropColumn(
                name: "Complete_Name",
                table: "Denuncia");

            migrationBuilder.DropColumn(
                name: "Country_id",
                table: "Denuncia");

            migrationBuilder.DropColumn(
                name: "Create_Date",
                table: "Denuncia");

            migrationBuilder.DropColumn(
                name: "Detalle",
                table: "Denuncia");

            migrationBuilder.DropColumn(
                name: "EO_Id",
                table: "Denuncia");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Denuncia");

            migrationBuilder.DropColumn(
                name: "Folio",
                table: "Denuncia");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Denuncia");

            migrationBuilder.DropColumn(
                name: "State_id",
                table: "Denuncia");

            migrationBuilder.DropColumn(
                name: "User_Password",
                table: "Denuncia");
        }
    }
}
