using Microsoft.EntityFrameworkCore.Migrations;

namespace MySalon_Master.Data.Migrations
{
    public partial class s : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Appointment",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Appointment",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
