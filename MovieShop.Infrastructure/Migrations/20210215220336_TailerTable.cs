﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieShop.Infrastructure.Migrations
{
    public partial class TailerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trailer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    TrailerUrl = table.Column<string>(type: "nvarchar(2004)", maxLength: 2004, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(2004)", maxLength: 2004, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trailer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trailer_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_MovieId",
                table: "Trailer",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trailer");
        }
    }
}
