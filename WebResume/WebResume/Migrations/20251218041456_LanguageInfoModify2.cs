using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class LanguageInfoModify2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_language_infos_languages_LanguageId",
                table: "language_infos");

            migrationBuilder.RenameColumn(
                name: "LanguageId",
                table: "language_infos",
                newName: "language_id");

            migrationBuilder.RenameIndex(
                name: "IX_language_infos_LanguageId",
                table: "language_infos",
                newName: "IX_language_infos_language_id");

            migrationBuilder.AddForeignKey(
                name: "FK_language_infos_languages_language_id",
                table: "language_infos",
                column: "language_id",
                principalTable: "languages",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_language_infos_languages_language_id",
                table: "language_infos");

            migrationBuilder.RenameColumn(
                name: "language_id",
                table: "language_infos",
                newName: "LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_language_infos_language_id",
                table: "language_infos",
                newName: "IX_language_infos_LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_language_infos_languages_LanguageId",
                table: "language_infos",
                column: "LanguageId",
                principalTable: "languages",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
