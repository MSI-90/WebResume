using Entites.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class UpdateContactInfoWithJSON : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SocialNetwork_SocialLink",
                table: "contact_info");

            migrationBuilder.DropColumn(
                name: "SocialNetwork_SocialType",
                table: "contact_info");

            migrationBuilder.AddColumn<SocialNetworkInfo>(
                name: "social_network",
                table: "contact_info",
                type: "jsonb",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "social_network",
                table: "contact_info");

            migrationBuilder.AddColumn<string>(
                name: "SocialNetwork_SocialLink",
                table: "contact_info",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SocialNetwork_SocialType",
                table: "contact_info",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
