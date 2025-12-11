using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class PInfo_Citizenship_Modify : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_resume_citizenship_citizenship_citizenship_id",
                table: "resume_citizenship");

            migrationBuilder.DropForeignKey(
                name: "FK_resume_citizenship_personal_info_resume_id",
                table: "resume_citizenship");

            migrationBuilder.DropPrimaryKey(
                name: "PK_resume_citizenship",
                table: "resume_citizenship");

            migrationBuilder.RenameTable(
                name: "resume_citizenship",
                newName: "pinfo_citizenship");

            migrationBuilder.RenameColumn(
                name: "resume_id",
                table: "pinfo_citizenship",
                newName: "pinfo_id");

            migrationBuilder.RenameIndex(
                name: "IX_resume_citizenship_citizenship_id",
                table: "pinfo_citizenship",
                newName: "IX_pinfo_citizenship_citizenship_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pinfo_citizenship",
                table: "pinfo_citizenship",
                columns: new[] { "pinfo_id", "citizenship_id" });

            migrationBuilder.AddForeignKey(
                name: "FK_pinfo_citizenship_citizenship_citizenship_id",
                table: "pinfo_citizenship",
                column: "citizenship_id",
                principalTable: "citizenship",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_pinfo_citizenship_personal_info_pinfo_id",
                table: "pinfo_citizenship",
                column: "pinfo_id",
                principalTable: "personal_info",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pinfo_citizenship_citizenship_citizenship_id",
                table: "pinfo_citizenship");

            migrationBuilder.DropForeignKey(
                name: "FK_pinfo_citizenship_personal_info_pinfo_id",
                table: "pinfo_citizenship");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pinfo_citizenship",
                table: "pinfo_citizenship");

            migrationBuilder.RenameTable(
                name: "pinfo_citizenship",
                newName: "resume_citizenship");

            migrationBuilder.RenameColumn(
                name: "pinfo_id",
                table: "resume_citizenship",
                newName: "resume_id");

            migrationBuilder.RenameIndex(
                name: "IX_pinfo_citizenship_citizenship_id",
                table: "resume_citizenship",
                newName: "IX_resume_citizenship_citizenship_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_resume_citizenship",
                table: "resume_citizenship",
                columns: new[] { "resume_id", "citizenship_id" });

            migrationBuilder.AddForeignKey(
                name: "FK_resume_citizenship_citizenship_citizenship_id",
                table: "resume_citizenship",
                column: "citizenship_id",
                principalTable: "citizenship",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_resume_citizenship_personal_info_resume_id",
                table: "resume_citizenship",
                column: "resume_id",
                principalTable: "personal_info",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
