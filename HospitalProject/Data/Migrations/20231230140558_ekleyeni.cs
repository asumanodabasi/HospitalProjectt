using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class ekleyeni : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropIndex(
            //    name: "IX_Randevus_UserId",
            //    table: "Randevus");

            //migrationBuilder.AlterColumn<string>(
            //    name: "UserId",
            //    table: "Randevus",
            //    type: "nvarchar(max)",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(450)",
            //    oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Randevus",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Randevus_UserId",
                table: "Randevus",
                column: "UserId");
        }
    }
}
