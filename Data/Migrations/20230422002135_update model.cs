using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace address_book.Data.Migrations
{
    public partial class updatemodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContactAddress",
                table: "Contact",
                newName: "Address");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Contact",
                newName: "ContactAddress");
        }
    }
}
