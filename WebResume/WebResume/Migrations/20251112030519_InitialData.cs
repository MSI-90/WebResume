using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "special_info",
                columns: new[] { "special_info_id", "description", "title" },
                values: new object[,]
                {
                    { new Guid("208c6dbc-77d1-4580-a5e8-3e972e2e1cb7"), "Takes advantage of the service's loyalty and exploits it to commit fraudulent or illegal actions, resulting in financial losses for the service. It is not recommended to provide any services to the client.", "Scammer" },
                    { new Guid("f4b94a1a-ac14-420e-9c67-37ef9b46445f"), "The client is acting suspiciously towards the service, additional attention should be paid to their actions within the service.", "Suspicious activity" }
                });

            migrationBuilder.InsertData(
                table: "template",
                columns: new[] { "template_id", "name", "template_kind" },
                values: new object[,]
                {
                    { new Guid("132805d2-3fc3-457c-86de-40116433c062"), "Premium template", 1 },
                    { new Guid("db58c76e-bcb5-4c6a-ad60-0e61bf3ac11c"), "Default template", 0 }
                });

            migrationBuilder.InsertData(
                table: "resume",
                columns: new[] { "resume_id", "created_at", "first_name", "job_title", "last_name", "middle_name", "template_id", "update_at" },
                values: new object[,]
                {
                    { new Guid("7b8b80fb-1c94-4e46-a069-ee51901b3d3e"), new DateTime(2025, 11, 12, 9, 43, 42, 361, DateTimeKind.Utc), "Sergey", "Specialist", "Miller", "Ivanovich", new Guid("db58c76e-bcb5-4c6a-ad60-0e61bf3ac11c"), new DateTime(2025, 11, 12, 23, 43, 42, 361, DateTimeKind.Utc) },
                    { new Guid("ce078d47-3f43-423f-8c16-a039f805ee88"), new DateTime(2025, 11, 12, 10, 1, 42, 361, DateTimeKind.Utc), "John", "Programmer", "Doe", "middle", new Guid("132805d2-3fc3-457c-86de-40116433c062"), new DateTime(2025, 11, 12, 10, 1, 42, 361, DateTimeKind.Utc) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "resume",
                keyColumn: "resume_id",
                keyValue: new Guid("7b8b80fb-1c94-4e46-a069-ee51901b3d3e"));

            migrationBuilder.DeleteData(
                table: "resume",
                keyColumn: "resume_id",
                keyValue: new Guid("ce078d47-3f43-423f-8c16-a039f805ee88"));

            migrationBuilder.DeleteData(
                table: "special_info",
                keyColumn: "special_info_id",
                keyValue: new Guid("208c6dbc-77d1-4580-a5e8-3e972e2e1cb7"));

            migrationBuilder.DeleteData(
                table: "special_info",
                keyColumn: "special_info_id",
                keyValue: new Guid("f4b94a1a-ac14-420e-9c67-37ef9b46445f"));

            migrationBuilder.DeleteData(
                table: "template",
                keyColumn: "template_id",
                keyValue: new Guid("132805d2-3fc3-457c-86de-40116433c062"));

            migrationBuilder.DeleteData(
                table: "template",
                keyColumn: "template_id",
                keyValue: new Guid("db58c76e-bcb5-4c6a-ad60-0e61bf3ac11c"));
        }
    }
}
