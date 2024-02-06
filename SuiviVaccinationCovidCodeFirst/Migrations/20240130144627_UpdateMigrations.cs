using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuiviVaccinationCovidCodeFirst.Migrations
{
    public partial class UpdateMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vaccins",
                columns: table => new
                {
                    VaccinId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccins", x => x.VaccinId);
                });

            migrationBuilder.CreateTable(
                name: "Immunizations",
                columns: table => new
                {
                    ImmunisationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NAMPatient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Covid19Id = table.Column<int>(type: "int", nullable: true),
                    Variant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoseId = table.Column<int>(type: "int", nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VaccinId = table.Column<int>(type: "int", nullable: true),
                    NumeroDose = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Immunizations", x => x.ImmunisationId);
                    table.ForeignKey(
                        name: "FK_Immunizations_Vaccins_VaccinId",
                        column: x => x.VaccinId,
                        principalTable: "Vaccins",
                        principalColumn: "VaccinId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Immunizations_VaccinId",
                table: "Immunizations",
                column: "VaccinId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Immunizations");

            migrationBuilder.DropTable(
                name: "Vaccins");
        }
    }
}
