using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnionAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mudurlukler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MudurlukKodu = table.Column<int>(type: "int", nullable: false),
                    MudurlukAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MudurlukBolgeKodu = table.Column<int>(type: "int", nullable: false),
                    Enlem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Boylam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mudurlukler", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Mudurlukler",
                columns: new[] { "Id", "Boylam", "CreatedDate", "Enlem", "MudurlukAdi", "MudurlukBolgeKodu", "MudurlukKodu" },
                values: new object[,]
                {
                    { new Guid("08ac6656-2a24-4a20-8d62-5521f888080c"), "", new DateTime(2023, 7, 5, 23, 24, 12, 943, DateTimeKind.Local).AddTicks(5647), "", "BANDIRMA", 0, 3 },
                    { new Guid("3e48217e-5628-4bad-8402-98e180197552"), "", new DateTime(2023, 7, 5, 23, 24, 12, 943, DateTimeKind.Local).AddTicks(5651), "", "BİGA", 0, 5 },
                    { new Guid("41d65b69-b698-4766-b676-15b9149e66ef"), "", new DateTime(2023, 7, 5, 23, 24, 12, 943, DateTimeKind.Local).AddTicks(5668), "", "GEMLİK", 0, 8 },
                    { new Guid("472ea8fc-149a-4f0d-b6d2-e3f528d284a0"), "", new DateTime(2023, 7, 5, 23, 24, 12, 943, DateTimeKind.Local).AddTicks(5670), "", "İNEGÖL", 0, 9 },
                    { new Guid("52eaee61-be42-408b-a4db-21d6565152db"), "", new DateTime(2023, 7, 5, 23, 24, 12, 943, DateTimeKind.Local).AddTicks(5666), "", "OSMANGAZİ", 0, 7 },
                    { new Guid("59da4d64-5a4e-4f1f-a2cd-5f7e782f319e"), "", new DateTime(2023, 7, 5, 23, 24, 12, 943, DateTimeKind.Local).AddTicks(5671), "", "M.KEMALPAŞA", 0, 10 },
                    { new Guid("786b2e85-d113-47f0-bdfd-eb581666a15b"), "", new DateTime(2023, 7, 5, 23, 24, 12, 943, DateTimeKind.Local).AddTicks(5653), "", "YALOVA", 0, 6 },
                    { new Guid("9b97c6e9-094d-46a0-a632-c64ea3ebe947"), "", new DateTime(2023, 7, 5, 23, 24, 12, 943, DateTimeKind.Local).AddTicks(5645), "", "EDREMİT", 0, 2 },
                    { new Guid("cc08d56c-08da-4689-8a13-3be5f5724bb7"), "", new DateTime(2023, 7, 5, 23, 24, 12, 943, DateTimeKind.Local).AddTicks(5577), "", "BALIKESİR", 0, 1 },
                    { new Guid("e497a112-ced8-42b8-8181-8e605310223e"), "", new DateTime(2023, 7, 5, 23, 24, 12, 943, DateTimeKind.Local).AddTicks(5649), "", "ÇANAKKALE", 0, 4 },
                    { new Guid("e7d50ab9-972e-4bea-97cd-83b378daf358"), "", new DateTime(2023, 7, 5, 23, 24, 12, 943, DateTimeKind.Local).AddTicks(5674), "", "YILDIRIM", 0, 12 },
                    { new Guid("fde04bc6-bf93-46a9-9ded-cba411d86861"), "", new DateTime(2023, 7, 5, 23, 24, 12, 943, DateTimeKind.Local).AddTicks(5673), "", "NİLÜFER", 0, 11 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mudurlukler");
        }
    }
}
