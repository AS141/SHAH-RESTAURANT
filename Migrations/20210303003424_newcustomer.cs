using Microsoft.EntityFrameworkCore.Migrations;

namespace SHAH_RESTAURANT.Migrations
{
    public partial class newcustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "mobile",
                table: "Customer",
                newName: "Mobile");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Mobile",
                table: "Customer",
                newName: "mobile");
        }
    }
}
