using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class Klinik : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KlinikId",
                table: "Hospitals",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KlinikId",
                table: "Hospitals");
        }
    }
}
