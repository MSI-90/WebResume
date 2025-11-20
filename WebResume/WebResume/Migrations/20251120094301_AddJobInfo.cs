using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class AddJobInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "job_title",
                table: "resume");

            migrationBuilder.AddColumn<Guid>(
                name: "job_id",
                table: "resume",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "JobInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    JobTitle = table.Column<string>(type: "text", nullable: true),
                    DesiredSalary = table.Column<decimal>(type: "numeric", nullable: true),
                    Currency = table.Column<int>(type: "integer", nullable: true),
                    ByAgreement = table.Column<bool>(type: "boolean", nullable: false),
                    EmploymentType = table.Column<int>(type: "integer", nullable: true),
                    WorkShedule = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobInfo", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "resume",
                keyColumn: "resume_id",
                keyValue: new Guid("7b8b80fb-1c94-4e46-a069-ee51901b3d3e"),
                column: "job_id",
                value: null);

            migrationBuilder.UpdateData(
                table: "resume",
                keyColumn: "resume_id",
                keyValue: new Guid("ce078d47-3f43-423f-8c16-a039f805ee88"),
                column: "job_id",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_resume_job_id",
                table: "resume",
                column: "job_id");

            migrationBuilder.AddForeignKey(
                name: "FK_resume_JobInfo_job_id",
                table: "resume",
                column: "job_id",
                principalTable: "JobInfo",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_resume_JobInfo_job_id",
                table: "resume");

            migrationBuilder.DropTable(
                name: "JobInfo");

            migrationBuilder.DropIndex(
                name: "IX_resume_job_id",
                table: "resume");

            migrationBuilder.DropColumn(
                name: "job_id",
                table: "resume");

            migrationBuilder.AddColumn<string>(
                name: "job_title",
                table: "resume",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "resume",
                keyColumn: "resume_id",
                keyValue: new Guid("7b8b80fb-1c94-4e46-a069-ee51901b3d3e"),
                column: "job_title",
                value: "Specialist");

            migrationBuilder.UpdateData(
                table: "resume",
                keyColumn: "resume_id",
                keyValue: new Guid("ce078d47-3f43-423f-8c16-a039f805ee88"),
                column: "job_title",
                value: "Programmer");
        }
    }
}
