using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eTransport.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locatii",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagineUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descriere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocatieId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locatii", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locatii_Locatii_LocatieId",
                        column: x => x.LocatieId,
                        principalTable: "Locatii",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MarciUtilaje",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagineUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detalii = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarciUtilaje", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Soferi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagineUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeComplet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Biografie = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soferi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servicii",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descriere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pret = table.Column<double>(type: "float", nullable: false),
                    ImagineUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServiciuCategorie = table.Column<int>(type: "int", nullable: false),
                    LocatieId = table.Column<int>(type: "int", nullable: false),
                    MarcaUtilajId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicii", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servicii_Locatii_LocatieId",
                        column: x => x.LocatieId,
                        principalTable: "Locatii",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Servicii_MarciUtilaje_MarcaUtilajId",
                        column: x => x.MarcaUtilajId,
                        principalTable: "MarciUtilaje",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SoferiServicii",
                columns: table => new
                {
                    SoferId = table.Column<int>(type: "int", nullable: false),
                    ServiciuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoferiServicii", x => new { x.SoferId, x.ServiciuId });
                    table.ForeignKey(
                        name: "FK_SoferiServicii_Servicii_ServiciuId",
                        column: x => x.ServiciuId,
                        principalTable: "Servicii",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SoferiServicii_Soferi_SoferId",
                        column: x => x.SoferId,
                        principalTable: "Soferi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Locatii_LocatieId",
                table: "Locatii",
                column: "LocatieId");

            migrationBuilder.CreateIndex(
                name: "IX_Servicii_LocatieId",
                table: "Servicii",
                column: "LocatieId");

            migrationBuilder.CreateIndex(
                name: "IX_Servicii_MarcaUtilajId",
                table: "Servicii",
                column: "MarcaUtilajId");

            migrationBuilder.CreateIndex(
                name: "IX_SoferiServicii_ServiciuId",
                table: "SoferiServicii",
                column: "ServiciuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SoferiServicii");

            migrationBuilder.DropTable(
                name: "Servicii");

            migrationBuilder.DropTable(
                name: "Soferi");

            migrationBuilder.DropTable(
                name: "Locatii");

            migrationBuilder.DropTable(
                name: "MarciUtilaje");
        }
    }
}
