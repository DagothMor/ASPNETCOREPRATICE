using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPNETHomework.DAL.Migrations
{
    public partial class EditedProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Providers_ProviderId1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProviderId1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProviderId1",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "ProviderId",
                table: "Products",
                type: "integer",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProviderId",
                table: "Products",
                column: "ProviderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Providers_ProviderId",
                table: "Products",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Providers_ProviderId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProviderId",
                table: "Products");

            migrationBuilder.AlterColumn<long>(
                name: "ProviderId",
                table: "Products",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProviderId1",
                table: "Products",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProviderId1",
                table: "Products",
                column: "ProviderId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Providers_ProviderId1",
                table: "Products",
                column: "ProviderId1",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
