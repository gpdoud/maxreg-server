using Microsoft.EntityFrameworkCore.Migrations;

namespace maxreg_server.Migrations
{
    public partial class garbage2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Guest",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Guest_EventId",
                table: "Guest",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Guest_Events_EventId",
                table: "Guest",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guest_Events_EventId",
                table: "Guest");

            migrationBuilder.DropIndex(
                name: "IX_Guest_EventId",
                table: "Guest");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Guest");
        }
    }
}
