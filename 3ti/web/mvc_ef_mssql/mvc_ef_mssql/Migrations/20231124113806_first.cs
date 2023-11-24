using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mvc_ef_mssql.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[] { 1, 23, "Adam", "Nowak" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[] { 2, 22, "monika", "Kika" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[] { 3, 42, "Janusz", "Banusz" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
