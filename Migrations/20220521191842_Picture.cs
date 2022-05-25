using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DogRazor.Migrations
{
    public partial class Picture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "Dog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Dog");
        }
    }
}
