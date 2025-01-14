﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeLoveCoffee.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class SampleCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories (Name,Description,Active) " +
                                 "VALUES ('Extraordinário','Café Extraordinário: acima de 90 pontos',1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categories");
        }
    }
}
