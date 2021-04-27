using Microsoft.EntityFrameworkCore.Migrations;

namespace NaturalSelection.Persistance.Migrations
{
    public partial class init_V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AppicationUserUserName",
                table: "Forums",
                newName: "UserName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Forums",
                newName: "AppicationUserUserName");
        }
    }
}
