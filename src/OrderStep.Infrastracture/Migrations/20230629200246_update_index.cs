using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderStep.Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class update_index : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RightId",
                table: "Rights",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ActionId",
                table: "Actions",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Rights",
                newName: "RightId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Actions",
                newName: "ActionId");
        }
    }
}
