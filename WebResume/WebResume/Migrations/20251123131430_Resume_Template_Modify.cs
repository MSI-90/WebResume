using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class Resume_Template_Modify : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_resume_template_template_id",
                table: "resume");

            migrationBuilder.AddForeignKey(
                name: "FK_resume_template_template_id",
                table: "resume",
                column: "template_id",
                principalTable: "template",
                principalColumn: "template_id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_resume_template_template_id",
                table: "resume");

            migrationBuilder.AddForeignKey(
                name: "FK_resume_template_template_id",
                table: "resume",
                column: "template_id",
                principalTable: "template",
                principalColumn: "template_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
