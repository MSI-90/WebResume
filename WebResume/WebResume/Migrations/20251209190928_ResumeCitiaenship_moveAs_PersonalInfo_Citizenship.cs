using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class ResumeCitiaenship_moveAs_PersonalInfo_Citizenship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_resume_citizenship_resume_resume_id",
                table: "resume_citizenship");

            migrationBuilder.AddForeignKey(
                name: "FK_resume_citizenship_personal_info_resume_id",
                table: "resume_citizenship",
                column: "resume_id",
                principalTable: "personal_info",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_resume_citizenship_personal_info_resume_id",
                table: "resume_citizenship");

            migrationBuilder.AddForeignKey(
                name: "FK_resume_citizenship_resume_resume_id",
                table: "resume_citizenship",
                column: "resume_id",
                principalTable: "resume",
                principalColumn: "resume_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
