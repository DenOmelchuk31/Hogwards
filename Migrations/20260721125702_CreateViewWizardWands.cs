using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HogwardsApp.Migrations
{
    /// <inheritdoc />
    public partial class CreateViewWizardWands : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        CREATE VIEW vw_WizardWands AS
        SELECT 
            w.Name AS WizardName,
            w.House AS House,
            wa.CoreMaterial AS WandMaterial
        FROM Wizards w
        JOIN Wands wa ON w.WizardId = wa.WizardId
    ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW vw_WizardWands");
        }
    }
}
