using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Eggcellent.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GradedEgg",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    EggSize = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradedEgg", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RejectedEgg",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    RejectionReason = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RejectedEgg", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SoldEgg",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    EggSize = table.Column<int>(type: "integer", nullable: false),
                    PricePerEgg = table.Column<double>(type: "double precision", nullable: false),
                    TotalPrice = table.Column<double>(type: "double precision", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoldEgg", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UngradedEgg",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UngradedEgg", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GradedEgg");

            migrationBuilder.DropTable(
                name: "RejectedEgg");

            migrationBuilder.DropTable(
                name: "SoldEgg");

            migrationBuilder.DropTable(
                name: "UngradedEgg");
        }
    }
}
