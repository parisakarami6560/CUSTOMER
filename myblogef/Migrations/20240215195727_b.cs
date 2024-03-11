using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myblogef.Migrations
{
    public partial class b : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BankAccountNumber",
                table: "customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "customers",
                type: "int",
                nullable: true,
                computedColumnSql: "DATEDIFF(year,DateofBrith,GETDATE()) ",
                oldClrType: typeof(int),
                oldType: "int",
                oldComputedColumnSql: "DATEDIFF(year,DateofBrith,GETDATE()) ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BankAccountNumber",
                table: "customers",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "customers",
                type: "int",
                nullable: false,
                computedColumnSql: "DATEDIFF(year,DateofBrith,GETDATE()) ",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComputedColumnSql: "DATEDIFF(year,DateofBrith,GETDATE()) ");
        }
    }
}
