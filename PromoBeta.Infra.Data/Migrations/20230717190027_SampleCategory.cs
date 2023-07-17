using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PromoBeta.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class SampleCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*
            migrationBuilder.Sql("INSERT INTO Categories (Name,Description,Active)" +
                "VALUES ('Tradicional',null,1)");
            */
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.Sql("DELETE FROM Categories");
        }
    }
}
