using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class ResumePhoto_ResumeJob_Realtions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_resume_job_info_job_id",
                table: "resume");

            migrationBuilder.DropForeignKey(
                name: "FK_resume_photo_photo_id",
                table: "resume");

            migrationBuilder.DropIndex(
                name: "IX_resume_job_id",
                table: "resume");

            migrationBuilder.CreateIndex(
                name: "IX_resume_job_id",
                table: "resume",
                column: "job_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_resume_job_info_job_id",
                table: "resume",
                column: "job_id",
                principalTable: "job_info",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_resume_photo_photo_id",
                table: "resume",
                column: "photo_id",
                principalTable: "photo",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_resume_job_info_job_id",
                table: "resume");

            migrationBuilder.DropForeignKey(
                name: "FK_resume_photo_photo_id",
                table: "resume");

            migrationBuilder.DropIndex(
                name: "IX_resume_job_id",
                table: "resume");

            migrationBuilder.CreateIndex(
                name: "IX_resume_job_id",
                table: "resume",
                column: "job_id");

            migrationBuilder.AddForeignKey(
                name: "FK_resume_job_info_job_id",
                table: "resume",
                column: "job_id",
                principalTable: "job_info",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_resume_photo_photo_id",
                table: "resume",
                column: "photo_id",
                principalTable: "photo",
                principalColumn: "id");
        }
    }
}
