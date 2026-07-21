using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HogwardsApp.Migrations
{
    /// <inheritdoc />
    public partial class _003_AddActiveWizardView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        migrationBuilder.Sql(@"
        CREATE VIEW vw_ActiveWizards
        AS
        SELECT w.WizardId, w.[Name], w.House, w.BloodStatus
        FROM Wizards w
        WHERE IsActive = 1;
    ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW vw_ActiveWizards;");
        }
    }
}
