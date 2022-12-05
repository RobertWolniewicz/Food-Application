using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Food_Application.Migrations
{
    public partial class DishIngridien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ingridiens_Dishs_Dishid",
                table: "ingridiens");

            migrationBuilder.DropIndex(
                name: "IX_ingridiens_Dishid",
                table: "ingridiens");

            migrationBuilder.DropColumn(
                name: "Dishid",
                table: "ingridiens");

            migrationBuilder.AlterColumn<double>(
                name: "price",
                table: "ingridiens",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "dishIngridiens",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    mas = table.Column<double>(type: "REAL", nullable: true),
                    quantity = table.Column<double>(type: "REAL", nullable: true),
                    DishId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dishIngridiens", x => x.id);
                    table.ForeignKey(
                        name: "FK_dishIngridiens_Dishs_DishId",
                        column: x => x.DishId,
                        principalTable: "Dishs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dishIngridiens_DishId",
                table: "dishIngridiens",
                column: "DishId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dishIngridiens");

            migrationBuilder.AlterColumn<double>(
                name: "price",
                table: "ingridiens",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AddColumn<int>(
                name: "Dishid",
                table: "ingridiens",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ingridiens_Dishid",
                table: "ingridiens",
                column: "Dishid");

            migrationBuilder.AddForeignKey(
                name: "FK_ingridiens_Dishs_Dishid",
                table: "ingridiens",
                column: "Dishid",
                principalTable: "Dishs",
                principalColumn: "id");
        }
    }
}
