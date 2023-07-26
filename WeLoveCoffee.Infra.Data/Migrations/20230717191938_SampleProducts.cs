using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeLoveCoffee.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class SampleProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*
            migrationBuilder.Sql("INSERT INTO Products (Name,Description,Price,Image,CategoryId,CompanyId,Active)" +
                "VALUES ('Melitta Café','',15,null,1,1,1)");

            migrationBuilder.Sql("INSERT INTO Products (Name,Description,Price,Image,CategoryId,CompanyId,Active)" +
                "VALUES ('Pimpinela Café','',15,null,1,1,1)");

            migrationBuilder.Sql("INSERT INTO Products (Name,Description,Price,Image,CategoryId,CompanyId,Active)" +
                "VALUES ('3 Corações Café','',15,null,1,1,1)");
            */
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.Sql("DELETE FROM Products");
        }
    }
}
