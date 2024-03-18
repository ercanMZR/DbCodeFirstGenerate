using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbFirstCodeGenerate.Migrations
{
    /// <inheritdoc />
    public partial class WorkAssigmentCreatedAndUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_ServiceRecords_ServiceRecordServiceID",
                table: "Invoice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoice",
                table: "Invoice");

            migrationBuilder.RenameTable(
                name: "Invoice",
                newName: "Invoices");

            migrationBuilder.RenameIndex(
                name: "IX_Invoice_ServiceRecordServiceID",
                table: "Invoices",
                newName: "IX_Invoices_ServiceRecordServiceID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices",
                column: "InvoiceID");

            migrationBuilder.CreateTable(
                name: "WorkAssignments",
                columns: table => new
                {
                    WorkAssigmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelID = table.Column<int>(type: "int", nullable: true),
                    ServiceID = table.Column<int>(type: "int", nullable: true),
                    ServiceRecordServiceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkAssignments", x => x.WorkAssigmentID);
                    table.ForeignKey(
                        name: "FK_WorkAssignments_Personel_PersonelID",
                        column: x => x.PersonelID,
                        principalTable: "Personel",
                        principalColumn: "PersonelID");
                    table.ForeignKey(
                        name: "FK_WorkAssignments_ServiceRecords_ServiceRecordServiceID",
                        column: x => x.ServiceRecordServiceID,
                        principalTable: "ServiceRecords",
                        principalColumn: "ServiceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkAssignments_PersonelID",
                table: "WorkAssignments",
                column: "PersonelID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkAssignments_ServiceRecordServiceID",
                table: "WorkAssignments",
                column: "ServiceRecordServiceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_ServiceRecords_ServiceRecordServiceID",
                table: "Invoices",
                column: "ServiceRecordServiceID",
                principalTable: "ServiceRecords",
                principalColumn: "ServiceID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_ServiceRecords_ServiceRecordServiceID",
                table: "Invoices");

            migrationBuilder.DropTable(
                name: "WorkAssignments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices");

            migrationBuilder.RenameTable(
                name: "Invoices",
                newName: "Invoice");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_ServiceRecordServiceID",
                table: "Invoice",
                newName: "IX_Invoice_ServiceRecordServiceID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoice",
                table: "Invoice",
                column: "InvoiceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_ServiceRecords_ServiceRecordServiceID",
                table: "Invoice",
                column: "ServiceRecordServiceID",
                principalTable: "ServiceRecords",
                principalColumn: "ServiceID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
