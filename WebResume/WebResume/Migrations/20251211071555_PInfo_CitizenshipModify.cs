using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class PInfo_CitizenshipModify : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pinfo_citizenship");

            migrationBuilder.CreateTable(
                name: "CitizenshipPersonalInfo",
                columns: table => new
                {
                    CitizenshipsId = table.Column<Guid>(type: "uuid", nullable: false),
                    PersonalInfosId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitizenshipPersonalInfo", x => new { x.CitizenshipsId, x.PersonalInfosId });
                    table.ForeignKey(
                        name: "FK_CitizenshipPersonalInfo_citizenship_CitizenshipsId",
                        column: x => x.CitizenshipsId,
                        principalTable: "citizenship",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CitizenshipPersonalInfo_personal_info_PersonalInfosId",
                        column: x => x.PersonalInfosId,
                        principalTable: "personal_info",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CitizenshipPersonalInfo_PersonalInfosId",
                table: "CitizenshipPersonalInfo",
                column: "PersonalInfosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CitizenshipPersonalInfo");

            migrationBuilder.CreateTable(
                name: "pinfo_citizenship",
                columns: table => new
                {
                    pinfo_id = table.Column<Guid>(type: "uuid", nullable: false),
                    citizenship_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pinfo_citizenship", x => new { x.pinfo_id, x.citizenship_id });
                    table.ForeignKey(
                        name: "FK_pinfo_citizenship_citizenship_citizenship_id",
                        column: x => x.citizenship_id,
                        principalTable: "citizenship",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pinfo_citizenship_personal_info_pinfo_id",
                        column: x => x.pinfo_id,
                        principalTable: "personal_info",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pinfo_citizenship_citizenship_id",
                table: "pinfo_citizenship",
                column: "citizenship_id");
        }
    }
}
