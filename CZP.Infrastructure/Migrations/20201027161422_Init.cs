using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CZP.Infrastructure.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddressInfo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddDateTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Province = table.Column<string>(maxLength: 50, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    District = table.Column<string>(maxLength: 50, nullable: true),
                    StreetHouseNumber = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressInfo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ManagerInfos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddDateTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Account = table.Column<string>(maxLength: 50, nullable: true),
                    Password = table.Column<string>(maxLength: 50, nullable: true),
                    LoginDateTime = table.Column<DateTime>(nullable: true),
                    AddManagerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerInfos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EnterpriseInfos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddDateTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    EnterpriseName = table.Column<string>(maxLength: 50, nullable: true),
                    EnterpriseHomePageImage = table.Column<string>(maxLength: 1000, nullable: true),
                    EnterpriseIntroduction = table.Column<string>(maxLength: 500, nullable: true),
                    IsShow = table.Column<bool>(nullable: false),
                    IsRecommend = table.Column<bool>(nullable: false),
                    SetRecommendDateTime = table.Column<DateTime>(nullable: true),
                    EnterpriseAddressID = table.Column<int>(nullable: true),
                    ManagerInfoID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnterpriseInfos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EnterpriseInfos_AddressInfo_EnterpriseAddressID",
                        column: x => x.EnterpriseAddressID,
                        principalTable: "AddressInfo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EnterpriseInfos_ManagerInfos_ManagerInfoID",
                        column: x => x.ManagerInfoID,
                        principalTable: "ManagerInfos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EnterpriseInfos_EnterpriseAddressID",
                table: "EnterpriseInfos",
                column: "EnterpriseAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_EnterpriseInfos_ManagerInfoID",
                table: "EnterpriseInfos",
                column: "ManagerInfoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnterpriseInfos");

            migrationBuilder.DropTable(
                name: "AddressInfo");

            migrationBuilder.DropTable(
                name: "ManagerInfos");
        }
    }
}
