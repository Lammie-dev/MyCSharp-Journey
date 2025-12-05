using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentWebApplication.Migrations
{
    /// <inheritdoc />
    public partial class newCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Average",
                table: "Students",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Grade",
                table: "Students",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Average",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Students");
        }
    }
}
