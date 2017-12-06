using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DOMS.WebApp.Data.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DOMS_Order_DOMS_Customer_PurchaserCustomerId",
                table: "DOMS_Order");

            migrationBuilder.RenameColumn(
                name: "PurchaserCustomerId",
                table: "DOMS_Order",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_DOMS_Order_PurchaserCustomerId",
                table: "DOMS_Order",
                newName: "IX_DOMS_Order_CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_DOMS_Order_DOMS_Customer_CustomerId",
                table: "DOMS_Order",
                column: "CustomerId",
                principalTable: "DOMS_Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DOMS_Order_DOMS_Customer_CustomerId",
                table: "DOMS_Order");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "DOMS_Order",
                newName: "PurchaserCustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_DOMS_Order_CustomerId",
                table: "DOMS_Order",
                newName: "IX_DOMS_Order_PurchaserCustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_DOMS_Order_DOMS_Customer_PurchaserCustomerId",
                table: "DOMS_Order",
                column: "PurchaserCustomerId",
                principalTable: "DOMS_Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
