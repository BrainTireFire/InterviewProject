using Microsoft.EntityFrameworkCore.Migrations;

namespace InterviewProject.Data.Migrations
{
    public partial class AddTestColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Notes",
                type: "nvarchar(256)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TextTransalted",
                table: "Notes",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TextTransalted",
                table: "Notes");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Notes",
                type: "nvarchar(256)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)");
        }
    }
}
