using Microsoft.EntityFrameworkCore.Migrations;

namespace MySalon_Master.Migrations
{
    public partial class addTimeRangeID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TimeRangeID",
                table: "Appointment",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeRangeID",
                table: "Appointment");
        }
    }
}
