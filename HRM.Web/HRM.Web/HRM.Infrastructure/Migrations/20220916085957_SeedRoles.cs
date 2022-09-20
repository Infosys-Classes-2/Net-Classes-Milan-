using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRM.Infrastructure.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f2de9ff-116f-4ac3-b25c-27e14cbba0a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60c03f99-9db0-4636-ab50-367b4004798e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "23413427-71f6-4380-a609-51c1f76cbcab", "82216c1d-cf71-4aaa-9de7-bfbc00e52fb5", "HR", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8e2059f8-579d-436f-a43d-05466d30496c", "adf35ad0-1f0f-420c-a4ca-87e0c28416a2", "Admin", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23413427-71f6-4380-a609-51c1f76cbcab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e2059f8-579d-436f-a43d-05466d30496c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1f2de9ff-116f-4ac3-b25c-27e14cbba0a1", "0f6ccee8-34f2-4330-a167-583f383788fc", "HR", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "60c03f99-9db0-4636-ab50-367b4004798e", "a81dcbb2-dce3-4f0a-aafc-31dc8fb0d90b", "Admin", null });
        }
    }
}
