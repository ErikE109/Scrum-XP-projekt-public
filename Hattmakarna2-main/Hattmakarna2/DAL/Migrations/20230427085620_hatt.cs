using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class hatt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dekorationer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Typ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pris = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dekorationer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kunder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postnummer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Land = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonNummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LagerfördHatt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pris = table.Column<double>(type: "float", nullable: false),
                    Materialkostnad = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LagerfördHatt", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Typ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MeterPris = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lösenord = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Beställningar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KundID = table.Column<int>(type: "int", nullable: false),
                    PersonalId = table.Column<int>(type: "int", nullable: false),
                    LeveransAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postnummer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Land = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalUtgift = table.Column<double>(type: "float", nullable: false),
                    TotalPris = table.Column<double>(type: "float", nullable: false),
                    Beskrivning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkapadDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsBetald = table.Column<bool>(type: "bit", nullable: false),
                    IsBekräftad = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beställningar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Beställningar_Kunder_KundID",
                        column: x => x.KundID,
                        principalTable: "Kunder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Beställningar_Personal_PersonalId",
                        column: x => x.PersonalId,
                        principalTable: "Personal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hattar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Storlek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pris = table.Column<double>(type: "float", nullable: false),
                    Materialkostnad = table.Column<double>(type: "float", nullable: false),
                    TidsÅtgång = table.Column<double>(type: "float", nullable: false),
                    Typ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BeställningsID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hattar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hattar_Beställningar_BeställningsID",
                        column: x => x.BeställningsID,
                        principalTable: "Beställningar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HattDekorationer",
                columns: table => new
                {
                    HattId = table.Column<int>(type: "int", nullable: false),
                    DekorationId = table.Column<int>(type: "int", nullable: false),
                    Antal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HattDekorationer", x => new { x.HattId, x.DekorationId });
                    table.ForeignKey(
                        name: "FK_HattDekorationer_Dekorationer_DekorationId",
                        column: x => x.DekorationId,
                        principalTable: "Dekorationer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HattDekorationer_Hattar_HattId",
                        column: x => x.HattId,
                        principalTable: "Hattar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HattMaterial",
                columns: table => new
                {
                    HattId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    Mängd = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HattMaterial", x => new { x.HattId, x.MaterialId });
                    table.ForeignKey(
                        name: "FK_HattMaterial_Hattar_HattId",
                        column: x => x.HattId,
                        principalTable: "Hattar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HattMaterial_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Dekorationer",
                columns: new[] { "Id", "Pris", "Typ" },
                values: new object[,]
                {
                    { 1, 100.0, "Fjädrar" },
                    { 2, 150.0, "Band" },
                    { 3, 125.0, "Blommor" }
                });

            migrationBuilder.InsertData(
                table: "Kunder",
                columns: new[] { "Id", "Adress", "Email", "Land", "Name", "Ort", "Postnummer", "TelefonNummer" },
                values: new object[] { 1, "abcgatan 5", "123@abc.se", "Sverige", "Erik", "Örebro", "123 56", "0701234567" });

            migrationBuilder.InsertData(
                table: "LagerfördHatt",
                columns: new[] { "Id", "Materialkostnad", "Namn", "Pris" },
                values: new object[] { 1, 800.0, "Doktorshatt", 8000.0 });

            migrationBuilder.InsertData(
                table: "Material",
                columns: new[] { "Id", "MeterPris", "Typ" },
                values: new object[,]
                {
                    { 1, 100.0, "Bomull" },
                    { 2, 125.0, "Linne" },
                    { 3, 150.0, "Ull" },
                    { 4, 175.0, "Silke" },
                    { 5, 200.0, "Satin" },
                    { 6, 225.0, "Tweed" },
                    { 7, 75.0, "Polyester" }
                });

            migrationBuilder.InsertData(
                table: "Personal",
                columns: new[] { "Id", "Lösenord", "Name" },
                values: new object[,]
                {
                    { 1, "123", "Judith" },
                    { 2, "123", "Otto" }
                });

            migrationBuilder.InsertData(
                table: "Beställningar",
                columns: new[] { "Id", "Beskrivning", "IsBekräftad", "IsBetald", "KundID", "Land", "LeveransAdress", "Ort", "PersonalId", "Postnummer", "SkapadDatum", "Status", "TotalPris", "TotalUtgift" },
                values: new object[] { 1, "abc", false, false, 1, "Sverige", "abcgatan", "Örebro", 1, "12345", new DateTime(2023, 4, 27, 10, 56, 20, 183, DateTimeKind.Local).AddTicks(1807), "Ny beställning", 1500.0, 800.0 });

            migrationBuilder.InsertData(
                table: "Hattar",
                columns: new[] { "Id", "BeställningsID", "Materialkostnad", "Pris", "Storlek", "TidsÅtgång", "Typ" },
                values: new object[] { 1, 1, 800.0, 1500.0, "M", 0.0, "Lagerförd hatt" });

            migrationBuilder.CreateIndex(
                name: "IX_Beställningar_KundID",
                table: "Beställningar",
                column: "KundID");

            migrationBuilder.CreateIndex(
                name: "IX_Beställningar_PersonalId",
                table: "Beställningar",
                column: "PersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_Hattar_BeställningsID",
                table: "Hattar",
                column: "BeställningsID");

            migrationBuilder.CreateIndex(
                name: "IX_HattDekorationer_DekorationId",
                table: "HattDekorationer",
                column: "DekorationId");

            migrationBuilder.CreateIndex(
                name: "IX_HattMaterial_MaterialId",
                table: "HattMaterial",
                column: "MaterialId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HattDekorationer");

            migrationBuilder.DropTable(
                name: "HattMaterial");

            migrationBuilder.DropTable(
                name: "LagerfördHatt");

            migrationBuilder.DropTable(
                name: "Dekorationer");

            migrationBuilder.DropTable(
                name: "Hattar");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "Beställningar");

            migrationBuilder.DropTable(
                name: "Kunder");

            migrationBuilder.DropTable(
                name: "Personal");
        }
    }
}
