using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HogwardsApp.Migrations
{
    /// <inheritdoc />
    public partial class CreateSpGetWizardsByHouse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        CREATE PROCEDURE sp_GetWizardsByHouse
            @House NVARCHAR(20)
        AS
        BEGIN
            SELECT * FROM Wizards WHERE House = @House
        END
    ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROCEDURE sp_GetWizardsByHouse");
        }
    }
}
