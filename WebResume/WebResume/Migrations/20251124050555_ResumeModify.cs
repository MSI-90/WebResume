using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class ResumeModify : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "purpose_resume",
                table: "resume",
                type: "character varying(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "resume",
                keyColumn: "resume_id",
                keyValue: new Guid("7b8b80fb-1c94-4e46-a069-ee51901b3d3e"),
                column: "purpose_resume",
                value: null);

            migrationBuilder.UpdateData(
                table: "resume",
                keyColumn: "resume_id",
                keyValue: new Guid("ce078d47-3f43-423f-8c16-a039f805ee88"),
                column: "purpose_resume",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "purpose_resume",
                table: "resume");
        }
    }
}
