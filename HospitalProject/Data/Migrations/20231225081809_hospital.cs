using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class hospital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.CreateTable(
                name: "Kliniks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HospitalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kliniks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kliniks_Hospitals_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospitals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HospitalKliniks",
                columns: table => new
                {
                    HospitalsId = table.Column<int>(type: "int", nullable: false),
                    KliniksId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalKliniks", x => new { x.HospitalsId, x.KliniksId });
                    table.ForeignKey(
                        name: "FK_HospitalKliniks_Hospitals_HospitalsId",
                        column: x => x.HospitalsId,
                        principalTable: "Hospitals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalKliniks_Kliniks_KliniksId",
                        column: x => x.KliniksId,
                        principalTable: "Kliniks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

    

      

            migrationBuilder.CreateIndex(
                name: "IX_HospitalKliniks_KliniksId",
                table: "HospitalKliniks",
                column: "KliniksId");

            migrationBuilder.CreateIndex(
                name: "IX_Kliniks_HospitalId",
                table: "Kliniks",
                column: "HospitalId");

         

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Hospitals_HospitalId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Kliniks_KlinikId",
                table: "Doctors");

            migrationBuilder.DropTable(
                name: "HospitalKliniks");

            migrationBuilder.DropTable(
                name: "Kliniks");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_HospitalId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_KlinikId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "HospitalId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "KlinikId",
                table: "Doctors");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

           

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
