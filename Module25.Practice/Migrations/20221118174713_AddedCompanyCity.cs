using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Module25.Practice.Migrations
{
    /// <inheritdoc />
    public partial class AddedCompanyCity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Companies");
        }
    }
}
