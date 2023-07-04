using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PromoBeta.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class SampleProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Products(Name,Description,Price,Image,CategoryId)" +
                "VALUES('Produto 01','Produto 01',10.5,null,1)");

            migrationBuilder.Sql("INSERT INTO Products(Name,Description,Price,Image,CategoryId)" +
                "VALUES('Produto 02','Produto 02',12.5,null,1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Products");
        }
    }
}
