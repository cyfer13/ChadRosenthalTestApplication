using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChadRosenthal.Application.Repository.EFCore.Migrations
{
    public partial class identitycontinued : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CardholderId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardholderId",
                table: "AspNetUsers");
        }
    }
}
