using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class CitizenshipEntityModify : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "country_name",
                table: "citizenship",
                type: "character varying(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "alpha2_code",
                table: "citizenship",
                type: "character varying(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "alpha3_code",
                table: "citizenship",
                type: "character varying(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "country_name_ru",
                table: "citizenship",
                type: "character varying(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "numeric_code",
                table: "citizenship",
                type: "character varying(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "alpha2_code",
                table: "citizenship");

            migrationBuilder.DropColumn(
                name: "alpha3_code",
                table: "citizenship");

            migrationBuilder.DropColumn(
                name: "country_name_ru",
                table: "citizenship");

            migrationBuilder.DropColumn(
                name: "numeric_code",
                table: "citizenship");

            migrationBuilder.AlterColumn<string>(
                name: "country_name",
                table: "citizenship",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(60)",
                oldMaxLength: 60);
        }
    }
}
