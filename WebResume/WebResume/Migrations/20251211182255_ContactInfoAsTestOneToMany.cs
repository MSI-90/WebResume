using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class ContactInfoAsTestOneToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contact_info",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    phone = table.Column<long>(type: "bigint", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    resume_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contact_info", x => x.id);
                    table.ForeignKey(
                        name: "FK_contact_info_resume_resume_id",
                        column: x => x.resume_id,
                        principalTable: "resume",
                        principalColumn: "resume_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "social_network",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    icon = table.Column<string>(type: "text", nullable: false)
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
                name: "IX_contact_info_resume_id",
                table: "contact_info",
                column: "resume_id");

            migrationBuilder.CreateIndex(
                name: "IX_contact_social_social_network",
                table: "contact_social",
                column: "social_network");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contact_social");

            migrationBuilder.DropTable(
                name: "contact_info");

            migrationBuilder.DropTable(
                name: "social_network");
        }
    }
}
