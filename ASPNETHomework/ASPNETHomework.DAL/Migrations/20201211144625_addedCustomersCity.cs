using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPNETHomework.DAL.Migrations
{
    public partial class addedCustomersCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Customers",
                newName: "City");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "City",
                table: "Customers",
                newName: "Address");
        }
    }
}
