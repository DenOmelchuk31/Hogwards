using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HogwardsApp.Migrations
{
    /// <inheritdoc />
    public partial class AddUniqueConstraintToWizardName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "IX_Wizards_Name",
                table: "Wizards",
                newName: "IX_Wizards_Name1");

            migrationBuilder.CreateIndex(
                name: "IX_Wizards_Name",
                table: "Wizards",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Wizards_Name",
                table: "Wizards");

            migrationBuilder.RenameIndex(
                name: "IX_Wizards_Name1",
                table: "Wizards",
                newName: "IX_Wizards_Name");
        }
    }
}
