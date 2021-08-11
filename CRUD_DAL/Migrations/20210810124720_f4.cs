using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_DAL.Migrations
{
    public partial class f4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SkillId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SkillId",
                table: "Employees");
        }
    }
}
