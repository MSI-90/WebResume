using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSocialNetworkTablesAndModifyContacts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contact_social");

            migrationBuilder.DropTable(
                name: "social_network");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "contact_info",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SocialNetwork_SocialLink",
                table: "contact_info");

            migrationBuilder.DropColumn(
                name: "SocialNetwork_SocialType",
                table: "contact_info");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "contact_info",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "social_network",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    icon = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_social_network", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "contact_social",
                columns: table => new
                {
                    contact_info = table.Column<Guid>(type: "uuid", nullable: false),
                    social_network = table.Column<Guid>(type: "uuid", nullable: false),
                    social_link = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contact_social", x => new { x.contact_info, x.social_network });
                    table.ForeignKey(
                        name: "FK_contact_social_contact_info_contact_info",
                        column: x => x.contact_info,
                        principalTable: "contact_info",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contact_social_social_network_social_network",
                        column: x => x.social_network,
                        principalTable: "social_network",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_contact_social_social_network",
                table: "contact_social",
                column: "social_network");
        }
    }
}
