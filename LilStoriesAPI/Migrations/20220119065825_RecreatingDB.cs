using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LilStoriesAPI.Migrations
{
    public partial class RecreatingDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Stories",
                table: "Stories");

            migrationBuilder.RenameTable(
                name: "Stories",
                newName: "tb_story");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "tb_story",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "tb_story",
                newName: "genre");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "tb_story",
                newName: "content");

            migrationBuilder.RenameColumn(
                name: "Author",
                table: "tb_story",
                newName: "author");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_story",
                newName: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_story",
                table: "tb_story",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_story",
                table: "tb_story");

            migrationBuilder.RenameTable(
                name: "tb_story",
                newName: "Stories");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Stories",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "genre",
                table: "Stories",
                newName: "Genre");

            migrationBuilder.RenameColumn(
                name: "content",
                table: "Stories",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "author",
                table: "Stories",
                newName: "Author");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Stories",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stories",
                table: "Stories",
                column: "Id");
        }
    }
}
