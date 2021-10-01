using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class Inicial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Consolas",
                table: "Consolas");

            migrationBuilder.RenameTable(
                name: "Consolas",
                newName: "Productos");

            migrationBuilder.RenameColumn(
                name: "VersionConsola",
                table: "Productos",
                newName: "VideoJuego_Tipo");

            migrationBuilder.RenameColumn(
                name: "NombreConsola",
                table: "Productos",
                newName: "Version");

            migrationBuilder.RenameColumn(
                name: "FabricanteConsola",
                table: "Productos",
                newName: "Tipo");

            migrationBuilder.AlterColumn<int>(
                name: "TipoAlmacenamiento",
                table: "Productos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PrecioVenta",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "PrecioCompra",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "NumeroControles",
                table: "Productos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Fabricante",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productos",
                table: "Productos",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Productos",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Fabricante",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Productos");

            migrationBuilder.RenameTable(
                name: "Productos",
                newName: "Consolas");

            migrationBuilder.RenameColumn(
                name: "VideoJuego_Tipo",
                table: "Consolas",
                newName: "VersionConsola");

            migrationBuilder.RenameColumn(
                name: "Version",
                table: "Consolas",
                newName: "NombreConsola");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Consolas",
                newName: "FabricanteConsola");

            migrationBuilder.AlterColumn<int>(
                name: "TipoAlmacenamiento",
                table: "Consolas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PrecioVenta",
                table: "Consolas",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PrecioCompra",
                table: "Consolas",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NumeroControles",
                table: "Consolas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Consolas",
                table: "Consolas",
                column: "Id");
        }
    }
}
