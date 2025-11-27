using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class DeletePropertyFromPhoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_deleted",
                table: "photo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "is_deleted",
                table: "photo",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "photo",
                keyColumn: "id",
                keyValue: new Guid("4041131f-cfd4-408a-8932-ce86cad50dba"),
                column: "is_deleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "photo",
                keyColumn: "id",
                keyValue: new Guid("7cf4a689-7387-4f97-9939-49beca8f68ea"),
                column: "is_deleted",
                value: false);
        }
    }
}
