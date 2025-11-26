using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class AddPersonalInfo_Citizenship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "citizenship",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    country_name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_citizenship", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "personal_info",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    city = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    is_dual_citizenship = table.Column<bool>(type: "boolean", nullable: false),
                    birthday = table.Column<DateOnly>(type: "date", nullable: false),
                    is_children = table.Column<bool>(type: "boolean", nullable: false),
                    sex = table.Column<int>(type: "integer", nullable: false),
                    moving = table.Column<int>(type: "integer", nullable: false),
                    maritalStatus = table.Column<int>(type: "integer", nullable: false),
                    ResumeId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personal_info", x => x.id);
                    table.ForeignKey(
                        name: "FK_personal_info_resume_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "resume",
                        principalColumn: "resume_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CitizenshipResume",
                columns: table => new
                {
                    CitizenshipsId = table.Column<Guid>(type: "uuid", nullable: false),
                    ResumesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitizenshipResume", x => new { x.CitizenshipsId, x.ResumesId });
                    table.ForeignKey(
                        name: "FK_CitizenshipResume_citizenship_CitizenshipsId",
                        column: x => x.CitizenshipsId,
                        principalTable: "citizenship",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CitizenshipResume_resume_ResumesId",
                        column: x => x.ResumesId,
                        principalTable: "resume",
                        principalColumn: "resume_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CitizenshipResume_ResumesId",
                table: "CitizenshipResume",
                column: "ResumesId");

            migrationBuilder.CreateIndex(
                name: "IX_personal_info_ResumeId",
                table: "personal_info",
                column: "ResumeId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CitizenshipResume");

            migrationBuilder.DropTable(
                name: "personal_info");

            migrationBuilder.DropTable(
                name: "citizenship");
        }
    }
}
