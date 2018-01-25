using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DOMS.Repository.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedUserId",
                table: "DOMS_Product",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "DOMS_Product",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_DOMS_Product_CreatedUserId",
                table: "DOMS_Product",
                column: "CreatedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DOMS_Product_AspNetUsers_CreatedUserId",
                table: "DOMS_Product",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DOMS_Product_AspNetUsers_CreatedUserId",
                table: "DOMS_Product");

            migrationBuilder.DropIndex(
                name: "IX_DOMS_Product_CreatedUserId",
                table: "DOMS_Product");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "DOMS_Product");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "DOMS_Product");
        }
    }
}
