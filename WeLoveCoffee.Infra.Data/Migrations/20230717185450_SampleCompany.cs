﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeLoveCoffee.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class SampleCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*
            migrationBuilder.Sql("INSERT INTO Companies (TaxIdNumber,Name,Description,Active)" +
                "VALUES ('50946701000196','DEXS','DEXS SOLUTIONS TECNOLOGIA E INTERNET',1)");
            */
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.Sql("DELETE FROM Companies");
        }
    }
}