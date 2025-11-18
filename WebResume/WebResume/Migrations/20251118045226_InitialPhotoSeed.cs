using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class InitialPhotoSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "photo",
                columns: new[] { "id", "file_name", "length" },
                values: new object[,]
                {
                    { new Guid("4041131f-cfd4-408a-8932-ce86cad50dba"), "filename", 108485L },
                    { new Guid("7cf4a689-7387-4f97-9939-49beca8f68ea"), "1filename2", 3413L }
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "photo",
                keyColumn: "id",
                keyValue: new Guid("4041131f-cfd4-408a-8932-ce86cad50dba"));

            migrationBuilder.DeleteData(
                table: "photo",
                keyColumn: "id",
                keyValue: new Guid("7cf4a689-7387-4f97-9939-49beca8f68ea"));

            migrationBuilder.UpdateData(
                table: "resume",
                keyColumn: "resume_id",
                keyValue: new Guid("7b8b80fb-1c94-4e46-a069-ee51901b3d3e"),
                column: "photo_id",
                value: null);

            migrationBuilder.UpdateData(
                table: "resume",
                keyColumn: "resume_id",
                keyValue: new Guid("ce078d47-3f43-423f-8c16-a039f805ee88"),
                column: "photo_id",
                value: null);
        }
    }
}
