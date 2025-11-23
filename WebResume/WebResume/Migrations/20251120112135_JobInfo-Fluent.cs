using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class JobInfoFluent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_resume_JobInfo_job_id",
                table: "resume");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobInfo",
                table: "JobInfo");

            migrationBuilder.RenameTable(
                name: "JobInfo",
                newName: "job_info");

            migrationBuilder.RenameColumn(
                name: "Currency",
                table: "job_info",
                newName: "currency");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "job_info",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "WorkShedule",
                table: "job_info",
                newName: "work_shedule");

            migrationBuilder.RenameColumn(
                name: "JobTitle",
                table: "job_info",
                newName: "job_title");

            migrationBuilder.RenameColumn(
                name: "EmploymentType",
                table: "job_info",
                newName: "employment_type");

            migrationBuilder.RenameColumn(
                name: "DesiredSalary",
                table: "job_info",
                newName: "desired_salary");

            migrationBuilder.RenameColumn(
                name: "ByAgreement",
                table: "job_info",
                newName: "agreement");

            migrationBuilder.AlterColumn<string>(
                name: "job_title",
                table: "job_info",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "desired_salary",
                table: "job_info",
                type: "decimal",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_job_info",
                table: "job_info",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_resume_job_info_job_id",
                table: "resume",
                column: "job_id",
                principalTable: "job_info",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_resume_job_info_job_id",
                table: "resume");

            migrationBuilder.DropPrimaryKey(
                name: "PK_job_info",
                table: "job_info");

            migrationBuilder.RenameTable(
                name: "job_info",
                newName: "JobInfo");

            migrationBuilder.RenameColumn(
                name: "currency",
                table: "JobInfo",
                newName: "Currency");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "JobInfo",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "work_shedule",
                table: "JobInfo",
                newName: "WorkShedule");

            migrationBuilder.RenameColumn(
                name: "job_title",
                table: "JobInfo",
                newName: "JobTitle");

            migrationBuilder.RenameColumn(
                name: "employment_type",
                table: "JobInfo",
                newName: "EmploymentType");

            migrationBuilder.RenameColumn(
                name: "desired_salary",
                table: "JobInfo",
                newName: "DesiredSalary");

            migrationBuilder.RenameColumn(
                name: "agreement",
                table: "JobInfo",
                newName: "ByAgreement");

            migrationBuilder.AlterColumn<string>(
                name: "JobTitle",
                table: "JobInfo",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DesiredSalary",
                table: "JobInfo",
                type: "numeric",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobInfo",
                table: "JobInfo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_resume_JobInfo_job_id",
                table: "resume",
                column: "job_id",
                principalTable: "JobInfo",
                principalColumn: "Id");
        }
    }
}
