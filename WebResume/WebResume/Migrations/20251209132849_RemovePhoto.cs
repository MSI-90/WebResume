using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class RemovePhoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "photo");

            migrationBuilder.AddColumn<Guid>(
                name: "PhotoId",
                table: "resume",
                type: "uuid",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "resume",
                keyColumn: "resume_id",
                keyValue: new Guid("7b8b80fb-1c94-4e46-a069-ee51901b3d3e"),
                column: "PhotoId",
                value: null);

            migrationBuilder.UpdateData(
                table: "resume",
                keyColumn: "resume_id",
                keyValue: new Guid("ce078d47-3f43-423f-8c16-a039f805ee88"),
                column: "PhotoId",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoId",
                table: "resume");

            migrationBuilder.CreateTable(
                name: "photo",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    ResumeId = table.Column<Guid>(type: "uuid", nullable: false),
                    file_name = table.Column<string>(type: "text", nullable: true),
                    length = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_photo", x => x.id);
                    table.ForeignKey(
                        name: "FK_photo_resume_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "resume",
                        principalColumn: "resume_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "photo",
                columns: new[] { "id", "file_name", "length", "ResumeId" },
                values: new object[,]
                {
                    { new Guid("4041131f-cfd4-408a-8932-ce86cad50dba"), "filename", 108485L, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7cf4a689-7387-4f97-9939-49beca8f68ea"), "1filename2", 3413L, new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_photo_ResumeId",
                table: "photo",
                column: "ResumeId",
                unique: true);
        }
    }
}
