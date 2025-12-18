using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class AdditionalInformation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "additional_information",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    military_service = table.Column<bool>(type: "boolean", nullable: false),
                    driver_license = table.Column<bool>(type: "boolean", nullable: false),
                    personal_qualities = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: true),
                    professional_skills = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: true),
                    about_yourself = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: true),
                    ResumeId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_additional_information", x => x.id);
                    table.ForeignKey(
                        name: "FK_additional_information_resume_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "resume",
                        principalColumn: "resume_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_additional_information_ResumeId",
                table: "additional_information",
                column: "ResumeId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "additional_information");
        }
    }
}
