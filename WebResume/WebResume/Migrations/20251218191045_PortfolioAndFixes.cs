using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class PortfolioAndFixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_additional_information_resume_ResumeId",
                table: "additional_information");

            migrationBuilder.DropForeignKey(
                name: "FK_computer_skill_resume_ResumeId",
                table: "computer_skill");

            migrationBuilder.DropForeignKey(
                name: "FK_courses_resume_ResumeId",
                table: "courses");

            migrationBuilder.DropForeignKey(
                name: "FK_education_resume_ResumeId",
                table: "education");

            migrationBuilder.DropForeignKey(
                name: "FK_experience_resume_ResumeId",
                table: "experience");

            migrationBuilder.DropForeignKey(
                name: "FK_job_info_resume_ResumeId",
                table: "job_info");

            migrationBuilder.DropForeignKey(
                name: "FK_language_infos_resume_ResumeId",
                table: "language_infos");

            migrationBuilder.DropForeignKey(
                name: "FK_personal_info_resume_ResumeId",
                table: "personal_info");

            migrationBuilder.RenameColumn(
                name: "ResumeId",
                table: "personal_info",
                newName: "resume_id");

            migrationBuilder.RenameIndex(
                name: "IX_personal_info_ResumeId",
                table: "personal_info",
                newName: "IX_personal_info_resume_id");

            migrationBuilder.RenameColumn(
                name: "ResumeId",
                table: "language_infos",
                newName: "resume_id");

            migrationBuilder.RenameIndex(
                name: "IX_language_infos_ResumeId",
                table: "language_infos",
                newName: "IX_language_infos_resume_id");

            migrationBuilder.RenameColumn(
                name: "ResumeId",
                table: "job_info",
                newName: "resume_id");

            migrationBuilder.RenameIndex(
                name: "IX_job_info_ResumeId",
                table: "job_info",
                newName: "IX_job_info_resume_id");

            migrationBuilder.RenameColumn(
                name: "ResumeId",
                table: "experience",
                newName: "resume_id");

            migrationBuilder.RenameIndex(
                name: "IX_experience_ResumeId",
                table: "experience",
                newName: "IX_experience_resume_id");

            migrationBuilder.RenameColumn(
                name: "ResumeId",
                table: "education",
                newName: "resume_id");

            migrationBuilder.RenameIndex(
                name: "IX_education_ResumeId",
                table: "education",
                newName: "IX_education_resume_id");

            migrationBuilder.RenameColumn(
                name: "ResumeId",
                table: "courses",
                newName: "resume_id");

            migrationBuilder.RenameIndex(
                name: "IX_courses_ResumeId",
                table: "courses",
                newName: "IX_courses_resume_id");

            migrationBuilder.RenameColumn(
                name: "ResumeId",
                table: "computer_skill",
                newName: "resume_id");

            migrationBuilder.RenameIndex(
                name: "IX_computer_skill_ResumeId",
                table: "computer_skill",
                newName: "IX_computer_skill_resume_id");

            migrationBuilder.RenameColumn(
                name: "ResumeId",
                table: "additional_information",
                newName: "resume_id");

            migrationBuilder.RenameIndex(
                name: "IX_additional_information_ResumeId",
                table: "additional_information",
                newName: "IX_additional_information_resume_id");

            migrationBuilder.CreateTable(
                name: "portfolio",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    description = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: true),
                    url = table.Column<string>(type: "character varying(3000)", maxLength: 3000, nullable: true),
                    resume_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_portfolio", x => x.id);
                    table.ForeignKey(
                        name: "FK_portfolio_resume_resume_id",
                        column: x => x.resume_id,
                        principalTable: "resume",
                        principalColumn: "resume_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_portfolio_resume_id",
                table: "portfolio",
                column: "resume_id");

            migrationBuilder.AddForeignKey(
                name: "FK_additional_information_resume_resume_id",
                table: "additional_information",
                column: "resume_id",
                principalTable: "resume",
                principalColumn: "resume_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_computer_skill_resume_resume_id",
                table: "computer_skill",
                column: "resume_id",
                principalTable: "resume",
                principalColumn: "resume_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_courses_resume_resume_id",
                table: "courses",
                column: "resume_id",
                principalTable: "resume",
                principalColumn: "resume_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_education_resume_resume_id",
                table: "education",
                column: "resume_id",
                principalTable: "resume",
                principalColumn: "resume_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_experience_resume_resume_id",
                table: "experience",
                column: "resume_id",
                principalTable: "resume",
                principalColumn: "resume_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_job_info_resume_resume_id",
                table: "job_info",
                column: "resume_id",
                principalTable: "resume",
                principalColumn: "resume_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_language_infos_resume_resume_id",
                table: "language_infos",
                column: "resume_id",
                principalTable: "resume",
                principalColumn: "resume_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_personal_info_resume_resume_id",
                table: "personal_info",
                column: "resume_id",
                principalTable: "resume",
                principalColumn: "resume_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_additional_information_resume_resume_id",
                table: "additional_information");

            migrationBuilder.DropForeignKey(
                name: "FK_computer_skill_resume_resume_id",
                table: "computer_skill");

            migrationBuilder.DropForeignKey(
                name: "FK_courses_resume_resume_id",
                table: "courses");

            migrationBuilder.DropForeignKey(
                name: "FK_education_resume_resume_id",
                table: "education");

            migrationBuilder.DropForeignKey(
                name: "FK_experience_resume_resume_id",
                table: "experience");

            migrationBuilder.DropForeignKey(
                name: "FK_job_info_resume_resume_id",
                table: "job_info");

            migrationBuilder.DropForeignKey(
                name: "FK_language_infos_resume_resume_id",
                table: "language_infos");

            migrationBuilder.DropForeignKey(
                name: "FK_personal_info_resume_resume_id",
                table: "personal_info");

            migrationBuilder.DropTable(
                name: "portfolio");

            migrationBuilder.RenameColumn(
                name: "resume_id",
                table: "personal_info",
                newName: "ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_personal_info_resume_id",
                table: "personal_info",
                newName: "IX_personal_info_ResumeId");

            migrationBuilder.RenameColumn(
                name: "resume_id",
                table: "language_infos",
                newName: "ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_language_infos_resume_id",
                table: "language_infos",
                newName: "IX_language_infos_ResumeId");

            migrationBuilder.RenameColumn(
                name: "resume_id",
                table: "job_info",
                newName: "ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_job_info_resume_id",
                table: "job_info",
                newName: "IX_job_info_ResumeId");

            migrationBuilder.RenameColumn(
                name: "resume_id",
                table: "experience",
                newName: "ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_experience_resume_id",
                table: "experience",
                newName: "IX_experience_ResumeId");

            migrationBuilder.RenameColumn(
                name: "resume_id",
                table: "education",
                newName: "ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_education_resume_id",
                table: "education",
                newName: "IX_education_ResumeId");

            migrationBuilder.RenameColumn(
                name: "resume_id",
                table: "courses",
                newName: "ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_courses_resume_id",
                table: "courses",
                newName: "IX_courses_ResumeId");

            migrationBuilder.RenameColumn(
                name: "resume_id",
                table: "computer_skill",
                newName: "ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_computer_skill_resume_id",
                table: "computer_skill",
                newName: "IX_computer_skill_ResumeId");

            migrationBuilder.RenameColumn(
                name: "resume_id",
                table: "additional_information",
                newName: "ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_additional_information_resume_id",
                table: "additional_information",
                newName: "IX_additional_information_ResumeId");

            migrationBuilder.AddForeignKey(
                name: "FK_additional_information_resume_ResumeId",
                table: "additional_information",
                column: "ResumeId",
                principalTable: "resume",
                principalColumn: "resume_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_computer_skill_resume_ResumeId",
                table: "computer_skill",
                column: "ResumeId",
                principalTable: "resume",
                principalColumn: "resume_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_courses_resume_ResumeId",
                table: "courses",
                column: "ResumeId",
                principalTable: "resume",
                principalColumn: "resume_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_education_resume_ResumeId",
                table: "education",
                column: "ResumeId",
                principalTable: "resume",
                principalColumn: "resume_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_experience_resume_ResumeId",
                table: "experience",
                column: "ResumeId",
                principalTable: "resume",
                principalColumn: "resume_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_job_info_resume_ResumeId",
                table: "job_info",
                column: "ResumeId",
                principalTable: "resume",
                principalColumn: "resume_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_language_infos_resume_ResumeId",
                table: "language_infos",
                column: "ResumeId",
                principalTable: "resume",
                principalColumn: "resume_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_personal_info_resume_ResumeId",
                table: "personal_info",
                column: "ResumeId",
                principalTable: "resume",
                principalColumn: "resume_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
