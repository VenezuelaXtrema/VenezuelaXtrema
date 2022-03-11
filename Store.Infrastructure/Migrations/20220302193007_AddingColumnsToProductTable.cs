using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store.Infrastructure.Migrations
{
    public partial class AddingColumnsToProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                schema: "Security",
                table: "Products");

            migrationBuilder.EnsureSchema(
                name: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                schema: "Security",
                newName: "Product",
                newSchema: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                schema: "Security",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 2, 15, 30, 6, 853, DateTimeKind.Local).AddTicks(9836),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 1, 21, 13, 23, 80, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                schema: "Security",
                table: "AspNetUserRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 2, 15, 30, 6, 853, DateTimeKind.Local).AddTicks(8260),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 1, 21, 13, 23, 80, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                schema: "Security",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 2, 15, 30, 6, 853, DateTimeKind.Local).AddTicks(9090),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 1, 21, 13, 23, 80, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                schema: "Products",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 2, 15, 30, 6, 854, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                schema: "Products",
                table: "Product",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Products",
                table: "Product",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyAt",
                schema: "Products",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "ModifyBy",
                schema: "Products",
                table: "Product",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                schema: "Products",
                table: "Product",
                type: "decimal(18)",
                precision: 18,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                schema: "Products",
                table: "Product",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                schema: "Products",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                schema: "Products",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "Products",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Products",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ModifyAt",
                schema: "Products",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ModifyBy",
                schema: "Products",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Price",
                schema: "Products",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "Product",
                schema: "Products",
                newName: "Products",
                newSchema: "Security");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                schema: "Security",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 1, 21, 13, 23, 80, DateTimeKind.Local).AddTicks(2645),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 2, 15, 30, 6, 853, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                schema: "Security",
                table: "AspNetUserRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 1, 21, 13, 23, 80, DateTimeKind.Local).AddTicks(1480),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 2, 15, 30, 6, 853, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                schema: "Security",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 1, 21, 13, 23, 80, DateTimeKind.Local).AddTicks(2149),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 2, 15, 30, 6, 853, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                schema: "Security",
                table: "Products",
                column: "ProductId");
        }
    }
}
