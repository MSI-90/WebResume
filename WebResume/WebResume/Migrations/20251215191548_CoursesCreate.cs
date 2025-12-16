using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class CoursesCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    course_name = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    organization_training = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    duration_of_training = table.Column<long>(type: "bigint", maxLength: 300, nullable: true),
                    achievements = table.Column<string>(type: "text", maxLength: 4000, nullable: true),
                    YearOfCompletion = table.Column<long>(type: "bigint", nullable: false),
                    ResumeId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.id);
                    table.ForeignKey(
                        name: "FK_courses_resume_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "resume",
                        principalColumn: "resume_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_courses_ResumeId",
                table: "courses",
                column: "ResumeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "courses");
        }
    }
}
