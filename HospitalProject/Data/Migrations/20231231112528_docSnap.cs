using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class docSnap : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevus_Doctors_DoctorId",
                table: "Randevus");

            migrationBuilder.DropColumn(
                name: "DoktorId",
                table: "Randevus");
        }
    }
}
