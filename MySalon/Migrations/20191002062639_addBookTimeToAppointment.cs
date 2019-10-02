using Microsoft.EntityFrameworkCore.Migrations;

namespace MySalon_Master.Migrations
{
    public partial class addBookTimeToAppointment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookTime",
                table: "Appointment",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookTime",
                table: "Appointment");
        }
    }
}
