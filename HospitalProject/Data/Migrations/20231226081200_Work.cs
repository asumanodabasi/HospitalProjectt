using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class Work : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RandevuId",
                table: "Randevus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkHourId",
                table: "Randevus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "WorkingHourId",
                table: "Randevus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Kliniks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkId",
                table: "Doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Randevus_RandevuId",
                table: "Randevus",
                column: "RandevuId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevus_WorkingHourId",
                table: "Randevus",
                column: "WorkingHourId");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevus_Randevus_RandevuId",
                table: "Randevus",
                column: "RandevuId",
                principalTable: "Randevus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevus_WorkHours_WorkingHourId",
                table: "Randevus",
                column: "WorkingHourId",
                principalTable: "WorkHours",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevus_Randevus_RandevuId",
                table: "Randevus");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevus_WorkHours_WorkingHourId",
                table: "Randevus");

            migrationBuilder.DropIndex(
                name: "IX_Randevus_RandevuId",
                table: "Randevus");

            migrationBuilder.DropIndex(
                name: "IX_Randevus_WorkingHourId",
                table: "Randevus");

            migrationBuilder.DropColumn(
                name: "RandevuId",
                table: "Randevus");

            migrationBuilder.DropColumn(
                name: "WorkHourId",
                table: "Randevus");

            migrationBuilder.DropColumn(
                name: "WorkingHourId",
                table: "Randevus");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Kliniks");

            migrationBuilder.DropColumn(
                name: "WorkId",
                table: "Doctors");
        }
    }
}
