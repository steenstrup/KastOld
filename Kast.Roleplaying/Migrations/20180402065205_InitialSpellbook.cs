using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Kast.Roleplaying.Migrations
{
    public partial class InitialSpellbook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SpellBooks",
                columns: table => new
                {
                    SpellBookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellBooks", x => x.SpellBookId);
                });

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    SpellId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CastingTime = table.Column<string>(nullable: true),
                    ClassesCanCast = table.Column<string>(nullable: true),
                    Components = table.Column<string>(nullable: true),
                    Concentration = table.Column<bool>(nullable: false),
                    Damage = table.Column<string>(nullable: true),
                    DamageType = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    InClass = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    Material = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Range = table.Column<string>(nullable: true),
                    Retual = table.Column<bool>(nullable: false),
                    Schole = table.Column<string>(nullable: true),
                    SpellBookId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.SpellId);
                    table.ForeignKey(
                        name: "FK_Spells_SpellBooks_SpellBookId",
                        column: x => x.SpellBookId,
                        principalTable: "SpellBooks",
                        principalColumn: "SpellBookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Spells_SpellBookId",
                table: "Spells",
                column: "SpellBookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "SpellBooks");
        }
    }
}
