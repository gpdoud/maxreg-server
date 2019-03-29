using Microsoft.EntityFrameworkCore.Migrations;

namespace maxreg_server.Migrations
{
    public partial class garbage4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GuestId",
                table: "Attendees");

            migrationBuilder.AddColumn<int>(
                name: "AttendeeId",
                table: "Guest",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Guest_AttendeeId",
                table: "Guest",
                column: "AttendeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Guest_Attendees_AttendeeId",
                table: "Guest",
                column: "AttendeeId",
                principalTable: "Attendees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guest_Attendees_AttendeeId",
                table: "Guest");

            migrationBuilder.DropIndex(
                name: "IX_Guest_AttendeeId",
                table: "Guest");

            migrationBuilder.DropColumn(
                name: "AttendeeId",
                table: "Guest");

            migrationBuilder.AddColumn<int>(
                name: "GuestId",
                table: "Attendees",
                nullable: false,
                defaultValue: 0);
        }
    }
}
