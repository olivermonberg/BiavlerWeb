using Microsoft.EntityFrameworkCore.Migrations;

namespace BiavlerWeb.Migrations
{
    public partial class aendring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Bemaerkning",
                table: "Varroataellinger",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Bemaerkning",
                table: "Varroataellinger",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
