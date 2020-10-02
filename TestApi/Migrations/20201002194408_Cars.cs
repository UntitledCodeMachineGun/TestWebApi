using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApi.Migrations
{
    public partial class Cars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vendor = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    CarClass = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "CarClass", "Model", "Price", "Vendor" },
                values: new object[] { 1, "S", "M3", 54000f, "BMW" });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "CarClass", "Model", "Price", "Vendor" },
                values: new object[] { 2, "J", "FX50", 25000f, "Infiniti" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarModels");
        }
    }
}
