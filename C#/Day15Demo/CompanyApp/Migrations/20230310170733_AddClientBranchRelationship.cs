using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyApp.Migrations
{
    /// <inheritdoc />
    public partial class AddClientBranchRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Branches_BranchID",
                table: "Employee");

            migrationBuilder.AlterColumn<int>(
                name: "BranchID",
                table: "Employee",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "BranchClient",
                columns: table => new
                {
                    BranchesID = table.Column<int>(type: "int", nullable: false),
                    ClientsCID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchClient", x => new { x.BranchesID, x.ClientsCID });
                    table.ForeignKey(
                        name: "FK_BranchClient_Branches_BranchesID",
                        column: x => x.BranchesID,
                        principalTable: "Branches",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchClient_Clients_ClientsCID",
                        column: x => x.ClientsCID,
                        principalTable: "Clients",
                        principalColumn: "CID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BranchClient_ClientsCID",
                table: "BranchClient",
                column: "ClientsCID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Branches_BranchID",
                table: "Employee",
                column: "BranchID",
                principalTable: "Branches",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Branches_BranchID",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "BranchClient");

            migrationBuilder.AlterColumn<int>(
                name: "BranchID",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Branches_BranchID",
                table: "Employee",
                column: "BranchID",
                principalTable: "Branches",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
