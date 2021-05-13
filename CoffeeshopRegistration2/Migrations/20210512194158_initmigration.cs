using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeshopRegistration2.Migrations
{
    public partial class initmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Birthday = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CoffeeTemp = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CoffeeType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TeaTemp = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TeaType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
