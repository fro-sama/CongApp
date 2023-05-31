using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CongApp.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedAssignee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Assignee",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Assignee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Assignee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Assignee");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Assignee");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Assignee",
                newName: "Name");
        }
    }
}
