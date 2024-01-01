using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class doctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevus_Doctors_DoktorId",
                table: "Randevus");

            migrationBuilder.DropIndex(
                name: "IX_Randevus_DoktorId",
                table: "Randevus");

            migrationBuilder.AlterColumn<string>(
                name: "DoktorId",
                table: "Randevus",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Randevus",
                type: "int",
                nullable: false,
                defaultValue: 0);




        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevus_Doctors_DoctorId",
                table: "Randevus");

            migrationBuilder.DropIndex(
                name: "IX_Randevus_DoctorId",
                table: "Randevus");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Randevus");

            migrationBuilder.AlterColumn<int>(
                name: "DoktorId",
                table: "Randevus",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

          

           
        }
    }
}
