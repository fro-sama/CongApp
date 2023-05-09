using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CongApp.Migrations
{
    /// <inheritdoc />
    public partial class AddingMeetingAssignmentRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MeetingId",
                table: "Assignments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_MeetingId",
                table: "Assignments",
                column: "MeetingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Meetings_MeetingId",
                table: "Assignments",
                column: "MeetingId",
                principalTable: "Meetings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Meetings_MeetingId",
                table: "Assignments");

            migrationBuilder.DropIndex(
                name: "IX_Assignments_MeetingId",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "MeetingId",
                table: "Assignments");
        }
    }
}
