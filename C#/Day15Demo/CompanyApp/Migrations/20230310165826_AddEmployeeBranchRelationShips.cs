using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyApp.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeBranchRelationShips : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BranchID",
                table: "Employee",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_BranchID",
                table: "Employee",
                column: "BranchID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Branches_BranchID",
                table: "Employee",
                column: "BranchID",
                principalTable: "Branches",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Branches_BranchID",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_BranchID",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "BranchID",
                table: "Employee");
        }
    }
}
