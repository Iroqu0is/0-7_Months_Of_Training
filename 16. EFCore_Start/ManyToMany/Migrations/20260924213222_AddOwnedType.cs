using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManyToMany.Migrations
{
    /// <inheritdoc />
    public partial class AddOwnedType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "BookAuthors",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "BookAuthors");
        }
    }
}
