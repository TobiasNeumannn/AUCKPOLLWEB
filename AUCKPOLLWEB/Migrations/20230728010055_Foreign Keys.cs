using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AUCKPOLLWEB.Migrations
{
    /// <inheritdoc />
    public partial class ForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_regions_airQuality_airQualitysampleID",
                table: "regions");

            migrationBuilder.DropForeignKey(
                name: "FK_regions_estuaryQuality_estuaryQualitysampleID",
                table: "regions");

            migrationBuilder.DropForeignKey(
                name: "FK_regions_gWaterQuality_gWaterQualitysampleID",
                table: "regions");

            migrationBuilder.DropIndex(
                name: "IX_regions_airQualitysampleID",
                table: "regions");

            migrationBuilder.DropIndex(
                name: "IX_regions_estuaryQualitysampleID",
                table: "regions");

            migrationBuilder.DropIndex(
                name: "IX_regions_gWaterQualitysampleID",
                table: "regions");

            migrationBuilder.DropColumn(
                name: "airQualitysampleID",
                table: "regions");

            migrationBuilder.DropColumn(
                name: "estuaryQualitysampleID",
                table: "regions");

            migrationBuilder.DropColumn(
                name: "gWaterQualitysampleID",
                table: "regions");

            migrationBuilder.RenameColumn(
                name: "regionID",
                table: "regions",
                newName: "ID");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "gWaterQuality",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RegionID",
                table: "gWaterQuality",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "estuaryQuality",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RegionID",
                table: "estuaryQuality",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "airQuality",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RegionID",
                table: "airQuality",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_gWaterQuality_RegionID",
                table: "gWaterQuality",
                column: "RegionID");

            migrationBuilder.CreateIndex(
                name: "IX_estuaryQuality_RegionID",
                table: "estuaryQuality",
                column: "RegionID");

            migrationBuilder.CreateIndex(
                name: "IX_airQuality_RegionID",
                table: "airQuality",
                column: "RegionID");

            migrationBuilder.AddForeignKey(
                name: "FK_airQuality_regions_RegionID",
                table: "airQuality",
                column: "RegionID",
                principalTable: "regions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_estuaryQuality_regions_RegionID",
                table: "estuaryQuality",
                column: "RegionID",
                principalTable: "regions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gWaterQuality_regions_RegionID",
                table: "gWaterQuality",
                column: "RegionID",
                principalTable: "regions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_airQuality_regions_RegionID",
                table: "airQuality");

            migrationBuilder.DropForeignKey(
                name: "FK_estuaryQuality_regions_RegionID",
                table: "estuaryQuality");

            migrationBuilder.DropForeignKey(
                name: "FK_gWaterQuality_regions_RegionID",
                table: "gWaterQuality");

            migrationBuilder.DropIndex(
                name: "IX_gWaterQuality_RegionID",
                table: "gWaterQuality");

            migrationBuilder.DropIndex(
                name: "IX_estuaryQuality_RegionID",
                table: "estuaryQuality");

            migrationBuilder.DropIndex(
                name: "IX_airQuality_RegionID",
                table: "airQuality");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "gWaterQuality");

            migrationBuilder.DropColumn(
                name: "RegionID",
                table: "gWaterQuality");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "estuaryQuality");

            migrationBuilder.DropColumn(
                name: "RegionID",
                table: "estuaryQuality");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "airQuality");

            migrationBuilder.DropColumn(
                name: "RegionID",
                table: "airQuality");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "regions",
                newName: "regionID");

            migrationBuilder.AddColumn<int>(
                name: "airQualitysampleID",
                table: "regions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "estuaryQualitysampleID",
                table: "regions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "gWaterQualitysampleID",
                table: "regions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_regions_airQualitysampleID",
                table: "regions",
                column: "airQualitysampleID");

            migrationBuilder.CreateIndex(
                name: "IX_regions_estuaryQualitysampleID",
                table: "regions",
                column: "estuaryQualitysampleID");

            migrationBuilder.CreateIndex(
                name: "IX_regions_gWaterQualitysampleID",
                table: "regions",
                column: "gWaterQualitysampleID");

            migrationBuilder.AddForeignKey(
                name: "FK_regions_airQuality_airQualitysampleID",
                table: "regions",
                column: "airQualitysampleID",
                principalTable: "airQuality",
                principalColumn: "sampleID");

            migrationBuilder.AddForeignKey(
                name: "FK_regions_estuaryQuality_estuaryQualitysampleID",
                table: "regions",
                column: "estuaryQualitysampleID",
                principalTable: "estuaryQuality",
                principalColumn: "sampleID");

            migrationBuilder.AddForeignKey(
                name: "FK_regions_gWaterQuality_gWaterQualitysampleID",
                table: "regions",
                column: "gWaterQualitysampleID",
                principalTable: "gWaterQuality",
                principalColumn: "sampleID");
        }
    }
}
