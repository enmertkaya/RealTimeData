using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealTimeData.DataAccessLayer.Migrations
{
    public partial class basket_fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "Baskets");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "Baskets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
