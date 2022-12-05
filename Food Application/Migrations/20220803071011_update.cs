using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Food_Application.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ingridiens_dishes_Dishid",
                table: "ingridiens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dishes",
                table: "dishes");

            migrationBuilder.RenameTable(
                name: "dishes",
                newName: "Dishs");

            migrationBuilder.AlterColumn<double>(
                name: "quantity",
                table: "ingridiens",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "price",
                table: "ingridiens",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<double>(
                name: "mas",
                table: "ingridiens",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "price",
                table: "Dishs",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<double>(
                name: "portions",
                table: "Dishs",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dishs",
                table: "Dishs",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_ingridiens_Dishs_Dishid",
                table: "ingridiens",
                column: "Dishid",
                principalTable: "Dishs",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ingridiens_Dishs_Dishid",
                table: "ingridiens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dishs",
                table: "Dishs");

            migrationBuilder.RenameTable(
                name: "Dishs",
                newName: "dishes");

            migrationBuilder.AlterColumn<int>(
                name: "quantity",
                table: "ingridiens",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "price",
                table: "ingridiens",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "mas",
                table: "ingridiens",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "price",
                table: "dishes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "portions",
                table: "dishes",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_dishes",
                table: "dishes",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_ingridiens_dishes_Dishid",
                table: "ingridiens",
                column: "Dishid",
                principalTable: "dishes",
                principalColumn: "id");
        }
    }
}
