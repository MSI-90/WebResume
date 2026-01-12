using Entites.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class updateContactInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<SocialNetworkInfo>(
                name: "social_network",
                table: "contact_info",
                type: "jsonb",
                nullable: true,
                oldClrType: typeof(SocialNetworkInfo),
                oldType: "jsonb");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<SocialNetworkInfo>(
                name: "social_network",
                table: "contact_info",
                type: "jsonb",
                nullable: false,
                oldClrType: typeof(SocialNetworkInfo),
                oldType: "jsonb",
                oldNullable: true);
        }
    }
}
