using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class LanguageInfoModify : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_language_infos_languages_LanguageId",
                table: "language_infos");

            migrationBuilder.AlterColumn<Guid>(
                name: "LanguageId",
                table: "language_infos",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_language_infos_languages_LanguageId",
                table: "language_infos",
                column: "LanguageId",
                principalTable: "languages",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_language_infos_languages_LanguageId",
                table: "language_infos");

            migrationBuilder.AlterColumn<Guid>(
                name: "LanguageId",
                table: "language_infos",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_language_infos_languages_LanguageId",
                table: "language_infos",
                column: "LanguageId",
                principalTable: "languages",
                principalColumn: "id");
        }
    }
}
