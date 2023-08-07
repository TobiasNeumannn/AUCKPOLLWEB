using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AUCKPOLLWEB.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "regions",
                columns: table => new
                {
                    regionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    region_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    region_pop = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_regions", x => x.regionID);
                });

            migrationBuilder.CreateTable(
                name: "airQuality",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    regionID = table.Column<int>(type: "int", nullable: false),
                    collection_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    value = table.Column<float>(type: "real", nullable: false),
                    unit = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_airQuality", x => x.ID);
                    table.ForeignKey(
                        name: "FK_airQuality_regions_regionID",
                        column: x => x.regionID,
                        principalTable: "regions",
                        principalColumn: "regionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "estuaryQuality",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    regionID = table.Column<int>(type: "int", nullable: false),
                    collection_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    indicator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    value = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estuaryQuality", x => x.ID);
                    table.ForeignKey(
                        name: "FK_estuaryQuality_regions_regionID",
                        column: x => x.regionID,
                        principalTable: "regions",
                        principalColumn: "regionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gWaterQuality",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    regionID = table.Column<int>(type: "int", nullable: false),
                    collection_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    indicator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    value = table.Column<float>(type: "real", nullable: false),
                    unit = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gWaterQuality", x => x.ID);
                    table.ForeignKey(
                        name: "FK_gWaterQuality_regions_regionID",
                        column: x => x.regionID,
                        principalTable: "regions",
                        principalColumn: "regionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_airQuality_regionID",
                table: "airQuality",
                column: "regionID");

            migrationBuilder.CreateIndex(
                name: "IX_estuaryQuality_regionID",
                table: "estuaryQuality",
                column: "regionID");

            migrationBuilder.CreateIndex(
                name: "IX_gWaterQuality_regionID",
                table: "gWaterQuality",
                column: "regionID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "airQuality");

            migrationBuilder.DropTable(
                name: "estuaryQuality");

            migrationBuilder.DropTable(
                name: "gWaterQuality");

            migrationBuilder.DropTable(
                name: "regions");
        }
    }
}
