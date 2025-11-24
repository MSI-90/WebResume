using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class AddPersonalInfo_Citizenship_Modify : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CitizenshipResume");

            migrationBuilder.CreateTable(
                name: "resume_citizenship",
                columns: table => new
                {
                    resume_id = table.Column<Guid>(type: "uuid", nullable: false),
                    citizenship_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resume_citizenship", x => new { x.resume_id, x.citizenship_id });
                    table.ForeignKey(
                        name: "FK_resume_citizenship_citizenship_citizenship_id",
                        column: x => x.citizenship_id,
                        principalTable: "citizenship",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_resume_citizenship_resume_resume_id",
                        column: x => x.resume_id,
                        principalTable: "resume",
                        principalColumn: "resume_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_resume_citizenship_citizenship_id",
                table: "resume_citizenship",
                column: "citizenship_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "resume_citizenship");

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
        }
    }
}
