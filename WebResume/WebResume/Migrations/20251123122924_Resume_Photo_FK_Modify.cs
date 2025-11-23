using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class Resume_Photo_FK_Modify : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_resume_photo_photo_id",
                table: "resume");

            migrationBuilder.DropIndex(
                name: "IX_resume_photo_id",
                table: "resume");

            migrationBuilder.DropColumn(
                name: "photo_id",
                table: "resume");

            migrationBuilder.AddColumn<Guid>(
                name: "ResumeId",
                table: "photo",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "photo",
                keyColumn: "id",
                keyValue: new Guid("4041131f-cfd4-408a-8932-ce86cad50dba"),
                column: "ResumeId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "photo",
                keyColumn: "id",
                keyValue: new Guid("7cf4a689-7387-4f97-9939-49beca8f68ea"),
                column: "ResumeId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_photo_ResumeId",
                table: "photo",
                column: "ResumeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_photo_resume_ResumeId",
                table: "photo",
                column: "ResumeId",
                principalTable: "resume",
                principalColumn: "resume_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_photo_resume_ResumeId",
                table: "photo");

            migrationBuilder.DropIndex(
                name: "IX_photo_ResumeId",
                table: "photo");

            migrationBuilder.DropColumn(
                name: "ResumeId",
                table: "photo");

            migrationBuilder.AddColumn<Guid>(
                name: "photo_id",
                table: "resume",
                type: "uuid",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "resume",
                keyColumn: "resume_id",
                keyValue: new Guid("7b8b80fb-1c94-4e46-a069-ee51901b3d3e"),
                column: "photo_id",
                value: new Guid("4041131f-cfd4-408a-8932-ce86cad50dba"));

            migrationBuilder.UpdateData(
                table: "resume",
                keyColumn: "resume_id",
                keyValue: new Guid("ce078d47-3f43-423f-8c16-a039f805ee88"),
                column: "photo_id",
                value: new Guid("7cf4a689-7387-4f97-9939-49beca8f68ea"));

            migrationBuilder.CreateIndex(
                name: "IX_resume_photo_id",
                table: "resume",
                column: "photo_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_resume_photo_photo_id",
                table: "resume",
                column: "photo_id",
                principalTable: "photo",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
