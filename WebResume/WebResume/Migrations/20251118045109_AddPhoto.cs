using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class AddPhoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "middle_name",
                table: "resume",
                type: "character varying(70)",
                maxLength: 70,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(70)",
                oldMaxLength: 70);

            migrationBuilder.AddColumn<Guid>(
                name: "photo_id",
                table: "resume",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "photo",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    file_name = table.Column<string>(type: "text", nullable: true),
                    length = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_photo", x => x.id);
                });

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
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_resume_photo_photo_id",
                table: "resume");

            migrationBuilder.DropTable(
                name: "photo");

            migrationBuilder.DropIndex(
                name: "IX_resume_photo_id",
                table: "resume");

            migrationBuilder.DropColumn(
                name: "photo_id",
                table: "resume");

            migrationBuilder.AlterColumn<string>(
                name: "middle_name",
                table: "resume",
                type: "character varying(70)",
                maxLength: 70,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(70)",
                oldMaxLength: 70,
                oldNullable: true);
        }
    }
}
