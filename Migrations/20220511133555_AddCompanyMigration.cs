using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.CarDealership.BMW.Migrations
{
    public partial class AddCompanyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdditionalEquipment",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Characteristics = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cost = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalEquipment", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BodyType",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    Duties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Requirements = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<long>(type: "bigint", nullable: false),
                    PassportData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Staff_Position_PositionID",
                        column: x => x.PositionID,
                        principalTable: "Position",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Manufactures",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufactures", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Manufactures_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Auto",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufID = table.Column<long>(type: "bigint", nullable: true),
                    BTID = table.Column<long>(type: "bigint", nullable: true),
                    DateManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    COLOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumEngine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Characteristics = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AE1 = table.Column<long>(type: "bigint", nullable: true),
                    AE2 = table.Column<long>(type: "bigint", nullable: true),
                    AE3 = table.Column<long>(type: "bigint", nullable: true),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    StaffID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auto", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Auto_BodyType_BTID",
                        column: x => x.BTID,
                        principalTable: "BodyType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Auto_Manufactures_ManufID",
                        column: x => x.ManufID,
                        principalTable: "Manufactures",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Auto_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalEquipmentAuto",
                columns: table => new
                {
                    AdditionalEquipmentID = table.Column<long>(type: "bigint", nullable: false),
                    AutoID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalEquipmentAuto", x => new { x.AdditionalEquipmentID, x.AutoID });
                    table.ForeignKey(
                        name: "FK_AdditionalEquipmentAuto_AdditionalEquipment_AdditionalEquipmentID",
                        column: x => x.AdditionalEquipmentID,
                        principalTable: "AdditionalEquipment",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdditionalEquipmentAuto_Auto_AutoID",
                        column: x => x.AutoID,
                        principalTable: "Auto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<long>(type: "bigint", nullable: false),
                    PassData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AutoID = table.Column<long>(type: "bigint", nullable: true),
                    DateOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateSale = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkCompletion = table.Column<bool>(type: "bit", nullable: false),
                    MarkPrice = table.Column<bool>(type: "bit", nullable: false),
                    PrecPrePlay = table.Column<int>(type: "int", nullable: false),
                    StaffID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Customers_Auto_AutoID",
                        column: x => x.AutoID,
                        principalTable: "Auto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalEquipmentAuto_AutoID",
                table: "AdditionalEquipmentAuto",
                column: "AutoID");

            migrationBuilder.CreateIndex(
                name: "IX_Auto_BTID",
                table: "Auto",
                column: "BTID");

            migrationBuilder.CreateIndex(
                name: "IX_Auto_ManufID",
                table: "Auto",
                column: "ManufID");

            migrationBuilder.CreateIndex(
                name: "IX_Auto_StaffID",
                table: "Auto",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AutoID",
                table: "Customers",
                column: "AutoID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_StaffID",
                table: "Customers",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Manufactures_StaffID",
                table: "Manufactures",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_PositionID",
                table: "Staff",
                column: "PositionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalEquipmentAuto");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "AdditionalEquipment");

            migrationBuilder.DropTable(
                name: "Auto");

            migrationBuilder.DropTable(
                name: "BodyType");

            migrationBuilder.DropTable(
                name: "Manufactures");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Position");
        }
    }
}
