﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace FordSuperheroes.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Superhero",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeroName = table.Column<string>(nullable: true),
                    HeroMainPowers = table.Column<string>(nullable: true),
                    HeroSecondaryPowers = table.Column<string>(nullable: true),
                    HeroAlias = table.Column<string>(nullable: true),
                    CatchPhrase = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Superhero", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Superhero");
        }
    }
}
