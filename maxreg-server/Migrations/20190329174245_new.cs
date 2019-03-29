using Microsoft.EntityFrameworkCore.Migrations;

namespace maxreg_server.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Guest_GuestId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_GuestId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "GuestId",
                table: "Events");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GuestId",
                table: "Events",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_GuestId",
                table: "Events",
                column: "GuestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Guest_GuestId",
                table: "Events",
                column: "GuestId",
                principalTable: "Guest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
