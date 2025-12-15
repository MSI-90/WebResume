using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class EducationEntityCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "education",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    education_institution = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    faculty = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    speciality = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    achievements = table.Column<string>(type: "text", maxLength: 4000, nullable: true),
                    year_of_completion = table.Column<long>(type: "bigint", nullable: false),
                    educationKind = table.Column<int>(type: "integer", nullable: false),
                    ResumeId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_education", x => x.id);
                    table.ForeignKey(
                        name: "FK_education_resume_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "resume",
                        principalColumn: "resume_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_education_ResumeId",
                table: "education",
                column: "ResumeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "education");
        }
    }
}
