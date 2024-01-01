using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class Randevu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kliniks_Hospitals_HospitalId",
                table: "Kliniks");


            migrationBuilder.AlterColumn<int>(
                name: "HospitalId",
                table: "Kliniks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RandevuId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Randevus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoktorId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Randevus_Doctors_DoktorId",
                        column: x => x.DoktorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_RandevuId",
                table: "AspNetUsers",
                column: "RandevuId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevus_DoktorId",
                table: "Randevus",
                column: "DoktorId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_AspNetUsers_Randevus_RandevuId",
            //    table: "AspNetUsers",
            //    column: "RandevuId",
            //    principalTable: "Randevus",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Kliniks_Hospitals_HospitalId",
            //    table: "Kliniks",
            //    column: "HospitalId",
            //    principalTable: "Hospitals",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_AspNetUsers_Randevus_RandevuId",
            //    table: "AspNetUsers");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Kliniks_Hospitals_HospitalId",
            //    table: "Kliniks");

            migrationBuilder.DropTable(
                name: "Randevus");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_RandevuId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RandevuId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "HospitalId",
                table: "Kliniks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");



            migrationBuilder.AddForeignKey(
                name: "FK_Kliniks_Hospitals_HospitalId",
                table: "Kliniks",
                column: "HospitalId",
                principalTable: "Hospitals",
                principalColumn: "Id");
        }
    }
}
