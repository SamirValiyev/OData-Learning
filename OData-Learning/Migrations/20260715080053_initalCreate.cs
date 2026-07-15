using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OData_Learning.Migrations
{
    /// <inheritdoc />
    public partial class initalCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GradeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "First" },
                    { 2, "Second" },
                    { 3, "Third" },
                    { 4, "Fourth" },
                    { 5, "Fifth" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedDate", "EmailAddress", "FirstName", "GradeId", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "rauf.salahov@example.com", "Rauf", 1, "Salahov" },
                    { 2, new DateTime(2026, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "zahra.nabiyeva@example.com", "Zahra", 2, "Nabiyeva" },
                    { 3, new DateTime(2026, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "emil.musayev@example.com", "Emil", 3, "Musayev" },
                    { 4, new DateTime(2026, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "narmin.shiriyeva@example.com", "Narmin", 4, "Shiriyeva" },
                    { 5, new DateTime(2026, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "javid.orujov@example.com", "Javid", 5, "Orujov" },
                    { 6, new DateTime(2026, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "konul.isgandarova@example.com", "Konul", 1, "Isgandarova" },
                    { 7, new DateTime(2026, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "fuad.bayramli@example.com", "Fuad", 2, "Bayramli" },
                    { 8, new DateTime(2026, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "sabina.huseynli@example.com", "Sabina", 3, "Huseynli" },
                    { 9, new DateTime(2026, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "elnur.veliyev@example.com", "Elnur", 4, "Veliyev" },
                    { 10, new DateTime(2026, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "amina.safarli@example.com", "Amina", 5, "Safarli" },
                    { 11, new DateTime(2026, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "tofig.guliyev@example.com", "Tofig", 1, "Guliyev" },
                    { 12, new DateTime(2026, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "lala.karimzade@example.com", "Lala", 5, "Karimzade" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_GradeId",
                table: "Students",
                column: "GradeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Grades");
        }
    }
}
