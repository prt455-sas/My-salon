using Microsoft.EntityFrameworkCore.Migrations;

namespace MySalon_Master.Migrations
{
    public partial class UpdateBookTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "time",
                table: "Appointment",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "time",
                table: "Appointment",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
