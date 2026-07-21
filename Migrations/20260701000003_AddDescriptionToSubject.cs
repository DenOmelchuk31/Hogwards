using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HogwardsApp.Migrations
{
    /// <inheritdoc />
    public partial class AddDescriptionToSubject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogMessage = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    DateTriggered = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AuditLog__3214EC072F746CE8", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Teacher = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Subjects__3214EC0728027920", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wizards",
                columns: table => new
                {
                    WizardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    House = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BloodStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValue: "Unknown")
                        .Annotation("Relational:DefaultConstraintName", "DF_Wizards_BloodStatus")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Wizards__EB46AA85B9AAC671", x => x.WizardId);
                });

            migrationBuilder.CreateTable(
                name: "HousePoints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WizardId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    DateRecorded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HousePoi__3214EC07E3B512F1", x => x.Id);
                    table.ForeignKey(
                        name: "FK__HousePoin__Subje__18EBB532",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__HousePoin__Wizar__17F790F9",
                        column: x => x.WizardId,
                        principalTable: "Wizards",
                        principalColumn: "WizardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wands",
                columns: table => new
                {
                    WandID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoreMaterial = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Length = table.Column<decimal>(type: "decimal(4,1)", nullable: false),
                    WizardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Wands__BB49E3E85774A3C1", x => x.WandID);
                    table.ForeignKey(
                        name: "FK_Wands_Wizards",
                        column: x => x.WizardId,
                        principalTable: "Wizards",
                        principalColumn: "WizardId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_HousePoints_SubjectId",
                table: "HousePoints",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_HousePoints_WizardId",
                table: "HousePoints",
                column: "WizardId");

            migrationBuilder.CreateIndex(
                name: "UQ_Wands_WizardId",
                table: "Wands",
                column: "WizardId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wizards_Name",
                table: "Wizards",
                column: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditLogs");

            migrationBuilder.DropTable(
                name: "HousePoints");

            migrationBuilder.DropTable(
                name: "Wands");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Wizards");
        }
    }
}
