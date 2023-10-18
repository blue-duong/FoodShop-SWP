using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodShop_SWP.Migrations
{
    public partial class initity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Product_tb_ProductCategory_ProductCategoryId",
                table: "tb_Product");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_User_Roles_RolesId",
                table: "tb_User");

            migrationBuilder.DropIndex(
                name: "IX_tb_User_RolesId",
                table: "tb_User");

            migrationBuilder.DropColumn(
                name: "RolesId",
                table: "tb_User");

            migrationBuilder.AlterColumn<int>(
                name: "ProductCategoryId",
                table: "tb_Product",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Product_tb_ProductCategory_ProductCategoryId",
                table: "tb_Product",
                column: "ProductCategoryId",
                principalTable: "tb_ProductCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Product_tb_ProductCategory_ProductCategoryId",
                table: "tb_Product");

            migrationBuilder.AddColumn<int>(
                name: "RolesId",
                table: "tb_User",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductCategoryId",
                table: "tb_Product",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_tb_User_RolesId",
                table: "tb_User",
                column: "RolesId");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Product_tb_ProductCategory_ProductCategoryId",
                table: "tb_Product",
                column: "ProductCategoryId",
                principalTable: "tb_ProductCategory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_User_Roles_RolesId",
                table: "tb_User",
                column: "RolesId",
                principalTable: "Roles",
                principalColumn: "Id");
        }
    }
}
