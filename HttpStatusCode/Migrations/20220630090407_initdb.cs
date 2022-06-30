using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HttpStatusCode.Migrations
{
    public partial class initdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CategoryDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryDescription", "CategoryName", "CreateDate", "DeleteDate", "Status", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Elektronik zamazingonlar", "Elektronik", new DateTime(2022, 6, 30, 12, 4, 7, 735, DateTimeKind.Local).AddTicks(3750), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 2, "Tekstil zamazingonlar", "Tekstil", new DateTime(2022, 6, 30, 12, 4, 7, 735, DateTimeKind.Local).AddTicks(3763), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 3, "Yemek zamazingonlar", "Yiyecek", new DateTime(2022, 6, 30, 12, 4, 7, 735, DateTimeKind.Local).AddTicks(3763), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 4, "Meşrubat zamazingonlar", "İçecek", new DateTime(2022, 6, 30, 12, 4, 7, 735, DateTimeKind.Local).AddTicks(3766), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
