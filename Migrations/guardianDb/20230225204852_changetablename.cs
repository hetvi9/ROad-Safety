using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RodeSafetyTool.Migrations.guardianDb
{
    /// <inheritdoc />
    public partial class changetablename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "guardians",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Relation = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(1000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_guardians", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "guardians");
        }
    }
}
