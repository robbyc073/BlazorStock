using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorStock_DataAccess.Migrations
{
    public partial class addTotalColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "StoredTransactions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "StoredTransactions");
        }
    }
}
