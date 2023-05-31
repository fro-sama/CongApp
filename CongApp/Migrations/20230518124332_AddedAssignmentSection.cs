using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CongApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedAssignmentSection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Section",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Section",
                table: "Assignments");
        }
    }
}
