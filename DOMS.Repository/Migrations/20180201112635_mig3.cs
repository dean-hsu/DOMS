using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DOMS.Repository.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DOMS_Brand_DOMS_Country_CountryId",
                table: "DOMS_Brand");

            migrationBuilder.DropForeignKey(
                name: "FK_DOMS_Catalogue_DOMS_Family_FamilyId",
                table: "DOMS_Catalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_DOMS_Order_DOMS_Delivery_DeliveryId",
                table: "DOMS_Order");

            migrationBuilder.DropForeignKey(
                name: "FK_DOMS_Order_AspNetUsers_UserId",
                table: "DOMS_Order");

            migrationBuilder.DropForeignKey(
                name: "FK_DOMS_Product_DOMS_Brand_BrandId",
                table: "DOMS_Product");

            migrationBuilder.DropForeignKey(
                name: "FK_DOMS_Product_DOMS_Catalogue_CatalogueId",
                table: "DOMS_Product");

            migrationBuilder.DropForeignKey(
                name: "FK_DOMS_Product_AspNetUsers_CreatedUserId",
                table: "DOMS_Product");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUserId",
                table: "DOMS_Product",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "CatalogueId",
                table: "DOMS_Product",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "DOMS_Product",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedUserName",
                table: "DOMS_Product",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "DOMS_Order",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryId",
                table: "DOMS_Order",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "DOMS_Order",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "FamilyId",
                table: "DOMS_Catalogue",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "DOMS_Brand",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DOMS_Brand_DOMS_Country_CountryId",
                table: "DOMS_Brand",
                column: "CountryId",
                principalTable: "DOMS_Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DOMS_Catalogue_DOMS_Family_FamilyId",
                table: "DOMS_Catalogue",
                column: "FamilyId",
                principalTable: "DOMS_Family",
                principalColumn: "FamilyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DOMS_Order_DOMS_Delivery_DeliveryId",
                table: "DOMS_Order",
                column: "DeliveryId",
                principalTable: "DOMS_Delivery",
                principalColumn: "DeliveryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DOMS_Order_AspNetUsers_UserId",
                table: "DOMS_Order",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DOMS_Product_DOMS_Brand_BrandId",
                table: "DOMS_Product",
                column: "BrandId",
                principalTable: "DOMS_Brand",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DOMS_Product_DOMS_Catalogue_CatalogueId",
                table: "DOMS_Product",
                column: "CatalogueId",
                principalTable: "DOMS_Catalogue",
                principalColumn: "CatalogueId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DOMS_Product_AspNetUsers_CreatedUserId",
                table: "DOMS_Product",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DOMS_Brand_DOMS_Country_CountryId",
                table: "DOMS_Brand");

            migrationBuilder.DropForeignKey(
                name: "FK_DOMS_Catalogue_DOMS_Family_FamilyId",
                table: "DOMS_Catalogue");

            migrationBuilder.DropForeignKey(
                name: "FK_DOMS_Order_DOMS_Delivery_DeliveryId",
                table: "DOMS_Order");

            migrationBuilder.DropForeignKey(
                name: "FK_DOMS_Order_AspNetUsers_UserId",
                table: "DOMS_Order");

            migrationBuilder.DropForeignKey(
                name: "FK_DOMS_Product_DOMS_Brand_BrandId",
                table: "DOMS_Product");

            migrationBuilder.DropForeignKey(
                name: "FK_DOMS_Product_DOMS_Catalogue_CatalogueId",
                table: "DOMS_Product");

            migrationBuilder.DropForeignKey(
                name: "FK_DOMS_Product_AspNetUsers_CreatedUserId",
                table: "DOMS_Product");

            migrationBuilder.DropColumn(
                name: "CreatedUserName",
                table: "DOMS_Product");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "DOMS_Order");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUserId",
                table: "DOMS_Product",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CatalogueId",
                table: "DOMS_Product",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "DOMS_Product",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "DOMS_Order",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryId",
                table: "DOMS_Order",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "FamilyId",
                table: "DOMS_Catalogue",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "DOMS_Brand",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_DOMS_Brand_DOMS_Country_CountryId",
                table: "DOMS_Brand",
                column: "CountryId",
                principalTable: "DOMS_Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DOMS_Catalogue_DOMS_Family_FamilyId",
                table: "DOMS_Catalogue",
                column: "FamilyId",
                principalTable: "DOMS_Family",
                principalColumn: "FamilyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DOMS_Order_DOMS_Delivery_DeliveryId",
                table: "DOMS_Order",
                column: "DeliveryId",
                principalTable: "DOMS_Delivery",
                principalColumn: "DeliveryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DOMS_Order_AspNetUsers_UserId",
                table: "DOMS_Order",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DOMS_Product_DOMS_Brand_BrandId",
                table: "DOMS_Product",
                column: "BrandId",
                principalTable: "DOMS_Brand",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DOMS_Product_DOMS_Catalogue_CatalogueId",
                table: "DOMS_Product",
                column: "CatalogueId",
                principalTable: "DOMS_Catalogue",
                principalColumn: "CatalogueId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DOMS_Product_AspNetUsers_CreatedUserId",
                table: "DOMS_Product",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
