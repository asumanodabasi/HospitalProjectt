using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class RandeIl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountyId",
                table: "Randevus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HastaneId",
                table: "Randevus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IlId",
                table: "Randevus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KlinikId",
                table: "Randevus",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountyId",
                table: "Randevus");

            migrationBuilder.DropColumn(
                name: "HastaneId",
                table: "Randevus");

            migrationBuilder.DropColumn(
                name: "IlId",
                table: "Randevus");

            migrationBuilder.DropColumn(
                name: "KlinikId",
                table: "Randevus");
        }
    }
}
