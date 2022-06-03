using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TARge20.Data.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FirmaPeakontor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegistriNumber = table.Column<int>(type: "int", nullable: false),
                    Nimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Luhinimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aadress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kontaktisik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KontaktTel = table.Column<int>(type: "int", nullable: false),
                    KontaktEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirmaPeakontor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tootaja",
                columns: table => new
                {
                    tootajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Eesnimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perenimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Isikukood = table.Column<int>(type: "int", nullable: false),
                    kontaktaadress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kontaktEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToolAlates = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToolKuni = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tootaja", x => x.tootajaId);
                });

            migrationBuilder.CreateTable(
                name: "FirmaHarukontor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirmaPeakontorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RegistriNr = table.Column<int>(type: "int", nullable: false),
                    Nimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Luhinimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aadress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kontaktisik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KontaktTel = table.Column<int>(type: "int", nullable: false),
                    KontaktEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirmaHarukontor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FirmaHarukontor_FirmaPeakontor_FirmaPeakontorId",
                        column: x => x.FirmaPeakontorId,
                        principalTable: "FirmaPeakontor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vihje",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirmaPeakontorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    VihjeSisu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pohjus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kuupaev = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vihje", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vihje_FirmaPeakontor_FirmaPeakontorId",
                        column: x => x.FirmaPeakontorId,
                        principalTable: "FirmaPeakontor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AmetiNimetus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tootajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EsemeNimetus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kvalifikatsioonid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TooUlesanded = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmetiNimetus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AmetiNimetus_Tootaja_tootajaId",
                        column: x => x.tootajaId,
                        principalTable: "Tootaja",
                        principalColumn: "tootajaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HaigusLehed",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tootajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AlgusKP = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LoppKP = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pohjus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HaigusLehed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HaigusLehed_Tootaja_tootajaId",
                        column: x => x.tootajaId,
                        principalTable: "Tootaja",
                        principalColumn: "tootajaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Laenatud",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tootajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EsemeNimetus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EsemeKood = table.Column<int>(type: "int", nullable: false),
                    LaenutusKP = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TagastusKP = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laenatud", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Laenatud_Tootaja_tootajaId",
                        column: x => x.tootajaId,
                        principalTable: "Tootaja",
                        principalColumn: "tootajaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lapsed",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tootajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Eesnimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perenimi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lapsed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lapsed_Tootaja_tootajaId",
                        column: x => x.tootajaId,
                        principalTable: "Tootaja",
                        principalColumn: "tootajaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Palve",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirmaPeakontorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    tootajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PalveSisu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pohjus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ettepanek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kuupaev = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Palve", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Palve_FirmaPeakontor_FirmaPeakontorId",
                        column: x => x.FirmaPeakontorId,
                        principalTable: "FirmaPeakontor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Palve_Tootaja_tootajaId",
                        column: x => x.tootajaId,
                        principalTable: "Tootaja",
                        principalColumn: "tootajaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PuhkusteNimekiri",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tootajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AlguseKP = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LoppKP = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuhkusteNimekiri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PuhkusteNimekiri_Tootaja_tootajaId",
                        column: x => x.tootajaId,
                        principalTable: "Tootaja",
                        principalColumn: "tootajaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TerviseKontroll",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tootajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    KontrollKP = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Asutus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tulemus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TerviseKontroll", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TerviseKontroll_Tootaja_tootajaId",
                        column: x => x.tootajaId,
                        principalTable: "Tootaja",
                        principalColumn: "tootajaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ligipaasuload",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirmaPeakontorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FirmaHarukontorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    tootajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Kasutajatunnus = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Parool = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ViimaneKulastus = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ligipaasuload", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ligipaasuload_FirmaHarukontor_FirmaHarukontorId",
                        column: x => x.FirmaHarukontorId,
                        principalTable: "FirmaHarukontor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ligipaasuload_FirmaPeakontor_FirmaPeakontorId",
                        column: x => x.FirmaPeakontorId,
                        principalTable: "FirmaPeakontor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ligipaasuload_Tootaja_tootajaId",
                        column: x => x.tootajaId,
                        principalTable: "Tootaja",
                        principalColumn: "tootajaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AmetiNimetus_tootajaId",
                table: "AmetiNimetus",
                column: "tootajaId");

            migrationBuilder.CreateIndex(
                name: "IX_FirmaHarukontor_FirmaPeakontorId",
                table: "FirmaHarukontor",
                column: "FirmaPeakontorId");

            migrationBuilder.CreateIndex(
                name: "IX_HaigusLehed_tootajaId",
                table: "HaigusLehed",
                column: "tootajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Laenatud_tootajaId",
                table: "Laenatud",
                column: "tootajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Lapsed_tootajaId",
                table: "Lapsed",
                column: "tootajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ligipaasuload_FirmaHarukontorId",
                table: "Ligipaasuload",
                column: "FirmaHarukontorId");

            migrationBuilder.CreateIndex(
                name: "IX_Ligipaasuload_FirmaPeakontorId",
                table: "Ligipaasuload",
                column: "FirmaPeakontorId");

            migrationBuilder.CreateIndex(
                name: "IX_Ligipaasuload_tootajaId",
                table: "Ligipaasuload",
                column: "tootajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Palve_FirmaPeakontorId",
                table: "Palve",
                column: "FirmaPeakontorId");

            migrationBuilder.CreateIndex(
                name: "IX_Palve_tootajaId",
                table: "Palve",
                column: "tootajaId");

            migrationBuilder.CreateIndex(
                name: "IX_PuhkusteNimekiri_tootajaId",
                table: "PuhkusteNimekiri",
                column: "tootajaId");

            migrationBuilder.CreateIndex(
                name: "IX_TerviseKontroll_tootajaId",
                table: "TerviseKontroll",
                column: "tootajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vihje_FirmaPeakontorId",
                table: "Vihje",
                column: "FirmaPeakontorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmetiNimetus");

            migrationBuilder.DropTable(
                name: "HaigusLehed");

            migrationBuilder.DropTable(
                name: "Laenatud");

            migrationBuilder.DropTable(
                name: "Lapsed");

            migrationBuilder.DropTable(
                name: "Ligipaasuload");

            migrationBuilder.DropTable(
                name: "Palve");

            migrationBuilder.DropTable(
                name: "PuhkusteNimekiri");

            migrationBuilder.DropTable(
                name: "TerviseKontroll");

            migrationBuilder.DropTable(
                name: "Vihje");

            migrationBuilder.DropTable(
                name: "FirmaHarukontor");

            migrationBuilder.DropTable(
                name: "Tootaja");

            migrationBuilder.DropTable(
                name: "FirmaPeakontor");
        }
    }
}
