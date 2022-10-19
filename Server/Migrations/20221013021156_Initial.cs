using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MudSpeRece.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Receptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Userid = table.Column<int>(type: "int", nullable: false),
                    RecDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Containa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkDivisionId = table.Column<int>(type: "int", nullable: false),
                    Checkbox = table.Column<int>(type: "int", nullable: false),
                    Checkbox1 = table.Column<int>(type: "int", nullable: false),
                    Checkbox2 = table.Column<int>(type: "int", nullable: false),
                    Checkbox3 = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receptions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Receptions",
                columns: new[] { "Id", "Body", "Checkbox", "Checkbox1", "Checkbox2", "Checkbox3", "Containa", "CreatedAt", "CusName", "RecDate", "RecName", "RegName", "UpdatedAt", "Userid", "WorkDivisionId" },
                values: new object[] { 1, "いい仕事してますね", 0, 0, 0, 0, "2M", new DateTime(2022, 10, 13, 11, 11, 55, 928, DateTimeKind.Local).AddTicks(8180), "得意先商事", new DateTime(2022, 10, 13, 11, 11, 55, 928, DateTimeKind.Local).AddTicks(8148), "金山昌弘", "タイガー", new DateTime(2022, 10, 13, 11, 11, 55, 928, DateTimeKind.Local).AddTicks(8182), 3, 1 });

            migrationBuilder.InsertData(
                table: "Receptions",
                columns: new[] { "Id", "Body", "Checkbox", "Checkbox1", "Checkbox2", "Checkbox3", "Containa", "CreatedAt", "CusName", "RecDate", "RecName", "RegName", "UpdatedAt", "Userid", "WorkDivisionId" },
                values: new object[] { 2, "いい仕事してますね2", 0, 0, 0, 0, "3M", new DateTime(2022, 10, 13, 11, 11, 55, 928, DateTimeKind.Local).AddTicks(8191), "得意先商事2", new DateTime(2022, 10, 13, 11, 11, 55, 928, DateTimeKind.Local).AddTicks(8186), "金山昌弘2", "タイガー2", new DateTime(2022, 10, 13, 11, 11, 55, 928, DateTimeKind.Local).AddTicks(8192), 4, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receptions");
        }
    }
}
