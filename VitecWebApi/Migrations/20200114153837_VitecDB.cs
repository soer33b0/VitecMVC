﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace VitecWebApi.Migrations
{
    public partial class VitecDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "ProductItems",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "ProductItems",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
