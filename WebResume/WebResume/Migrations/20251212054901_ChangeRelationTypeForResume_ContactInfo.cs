using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class ChangeRelationTypeForResume_ContactInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_contact_info_resume_id",
                table: "contact_info");

            migrationBuilder.CreateIndex(
                name: "IX_contact_info_resume_id",
                table: "contact_info",
                column: "resume_id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_contact_info_resume_id",
                table: "contact_info");

            migrationBuilder.CreateIndex(
                name: "IX_contact_info_resume_id",
                table: "contact_info",
                column: "resume_id");
        }
    }
}
