using Microsoft.EntityFrameworkCore.Migrations;

namespace maxreg_server.Migrations
{
    public partial class new3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendees_Guest_GuestId",
                table: "Attendees");

            migrationBuilder.DropIndex(
                name: "IX_Attendees_GuestId",
                table: "Attendees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Attendees_GuestId",
                table: "Attendees",
                column: "GuestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendees_Guest_GuestId",
                table: "Attendees",
                column: "GuestId",
                principalTable: "Guest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
