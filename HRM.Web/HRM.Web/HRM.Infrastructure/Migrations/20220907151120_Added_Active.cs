using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable


namespace HRM.Infrastructure.Migrations
{
    public partial class Added_Active : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Employees",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Employees");
        }
    }
}
