using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HogwardsApp.Migrations
{
    /// <inheritdoc />
    public partial class _002_AddIsActiveToWizards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Wizards",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Wizards");
        }
    }
}
