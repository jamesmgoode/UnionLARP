using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UnionLARP.Data.Migrations
{
    public partial class IsAlive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAlive",
                table: "Characters",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SpecialPowerId",
                table: "Characters",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAlive",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "SpecialPowerId",
                table: "Characters");
        }
    }
}
