using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class yeni : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        

         

           

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.DropForeignKey(
                name: "FK_Randevus_WorkHours_WorkingHourId",
                table: "Randevus");

            migrationBuilder.DropIndex(
                name: "IX_Randevus_WorkingHourId",
                table: "Randevus");

            migrationBuilder.DropColumn(
                name: "WorkingHourId",
                table: "Randevus");

       

            migrationBuilder.CreateTable(
                name: "RandevuWorkingHour",
                columns: table => new
                {
                    RandevusId = table.Column<int>(type: "int", nullable: false),
                    WorkHoursId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RandevuWorkingHour", x => new { x.RandevusId, x.WorkHoursId });
                    table.ForeignKey(
                        name: "FK_RandevuWorkingHour_Randevus_RandevusId",
                        column: x => x.RandevusId,
                        principalTable: "Randevus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RandevuWorkingHour_WorkHours_WorkHoursId",
                        column: x => x.WorkHoursId,
                        principalTable: "WorkHours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RandevuWorkingHour_WorkHoursId",
                table: "RandevuWorkingHour",
                column: "WorkHoursId");

        }
    }
}
