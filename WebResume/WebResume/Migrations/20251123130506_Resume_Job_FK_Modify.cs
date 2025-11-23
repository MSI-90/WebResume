using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class Resume_Job_FK_Modify : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_resume_job_info_job_id",
                table: "resume");

            migrationBuilder.DropIndex(
                name: "IX_resume_job_id",
                table: "resume");

            migrationBuilder.DropColumn(
                name: "job_id",
                table: "resume");

            migrationBuilder.AddColumn<Guid>(
                name: "ResumeId",
                table: "job_info",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_job_info_ResumeId",
                table: "job_info",
                column: "ResumeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_job_info_resume_ResumeId",
                table: "job_info",
                column: "ResumeId",
                principalTable: "resume",
                principalColumn: "resume_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_job_info_resume_ResumeId",
                table: "job_info");

            migrationBuilder.DropIndex(
                name: "IX_job_info_ResumeId",
                table: "job_info");

            migrationBuilder.DropColumn(
                name: "ResumeId",
                table: "job_info");

            migrationBuilder.AddColumn<Guid>(
                name: "job_id",
                table: "resume",
                type: "uuid",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "resume",
                keyColumn: "resume_id",
                keyValue: new Guid("7b8b80fb-1c94-4e46-a069-ee51901b3d3e"),
                column: "job_id",
                value: null);

            migrationBuilder.UpdateData(
                table: "resume",
                keyColumn: "resume_id",
                keyValue: new Guid("ce078d47-3f43-423f-8c16-a039f805ee88"),
                column: "job_id",
                value: null);

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
        }
    }
}
