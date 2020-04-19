using Microsoft.EntityFrameworkCore.Migrations;

namespace SystemClothes.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Clothes");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Clothes");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Clothes");

            migrationBuilder.DropColumn(
                name: "Values",
                table: "Clothes");

            migrationBuilder.RenameColumn(
                name: "pagamento",
                table: "Buy",
                newName: "Pagamento");

            migrationBuilder.AddColumn<string>(
                name: "Marca",
                table: "Clothes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Quantidade",
                table: "Clothes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tamanho",
                table: "Clothes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Valor",
                table: "Clothes",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "Buy",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Marca",
                table: "Clothes");

            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Clothes");

            migrationBuilder.DropColumn(
                name: "Tamanho",
                table: "Clothes");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Clothes");

            migrationBuilder.RenameColumn(
                name: "Pagamento",
                table: "Buy",
                newName: "pagamento");

            migrationBuilder.AddColumn<string>(
                name: "Amount",
                table: "Clothes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Clothes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "Clothes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Values",
                table: "Clothes",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<double>(
                name: "Valor",
                table: "Buy",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
