using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC.Migrations
{
    public partial class addnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcceptInviation",
                table: "ProjectMembers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AcceptInviation",
                table: "ProjectMembers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
