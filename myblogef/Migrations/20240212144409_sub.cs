using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myblogef.Migrations
{
    public partial class sub : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "subs",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    BlugId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subs", x => new { x.BlugId, x.UserId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "subs");
        }
    }
}
