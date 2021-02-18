using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieShop.Infrastructure.Migrations
{
    public partial class updateMovieCast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cast_MovieCast_MovieCastMovieId",
                table: "Cast");

            migrationBuilder.DropIndex(
                name: "IX_Cast_MovieCastMovieId",
                table: "Cast");

            migrationBuilder.DropColumn(
                name: "MovieCastMovieId",
                table: "Cast");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCast_CastId",
                table: "MovieCast",
                column: "CastId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCast_Cast_CastId",
                table: "MovieCast",
                column: "CastId",
                principalTable: "Cast",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieCast_Cast_CastId",
                table: "MovieCast");

            migrationBuilder.DropIndex(
                name: "IX_MovieCast_CastId",
                table: "MovieCast");

            migrationBuilder.AddColumn<int>(
                name: "MovieCastMovieId",
                table: "Cast",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cast_MovieCastMovieId",
                table: "Cast",
                column: "MovieCastMovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cast_MovieCast_MovieCastMovieId",
                table: "Cast",
                column: "MovieCastMovieId",
                principalTable: "MovieCast",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
