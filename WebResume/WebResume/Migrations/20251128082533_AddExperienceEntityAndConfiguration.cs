using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class AddExperienceEntityAndConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "experience",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    job_title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    company_name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    job_responsibilites = table.Column<string>(type: "character varying(10000)", maxLength: 10000, nullable: true),
                    achivements = table.Column<string>(type: "character varying(3000)", maxLength: 3000, nullable: true),
                    start_job = table.Column<DateOnly>(type: "date", nullable: true),
                    end_job = table.Column<DateOnly>(type: "date", nullable: true),
                    ResumeId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_experience", x => x.Id);
                    table.ForeignKey(
                        name: "FK_experience_resume_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "resume",
                        principalColumn: "resume_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_experience_ResumeId",
                table: "experience",
                column: "ResumeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "experience");
        }
    }
}
