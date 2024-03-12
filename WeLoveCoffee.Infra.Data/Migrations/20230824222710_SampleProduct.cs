using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeLoveCoffee.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class SampleProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Products (Name,Description,Price,Image,CategoryId,CompanyId,Active) " +
                                 "VALUES ('Orfeu','Orfeu',15.5,null,1,1,1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Products");
        }
    }
}
