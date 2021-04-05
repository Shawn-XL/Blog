using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class ArticleTagsManytoMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleTag_Articles_ArticlePicturesId",
                table: "ArticleTag");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticleTag_Tag_ArticleTagsId",
                table: "ArticleTag");

            migrationBuilder.RenameColumn(
                name: "ArticleTagsId",
                table: "ArticleTag",
                newName: "TagId");

            migrationBuilder.RenameColumn(
                name: "ArticlePicturesId",
                table: "ArticleTag",
                newName: "ArticleId");

            migrationBuilder.RenameIndex(
                name: "IX_ArticleTag_ArticleTagsId",
                table: "ArticleTag",
                newName: "IX_ArticleTag_TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleTag_Articles_ArticleId",
                table: "ArticleTag",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleTag_Tag_TagId",
                table: "ArticleTag",
                column: "TagId",
                principalTable: "Tag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleTag_Articles_ArticleId",
                table: "ArticleTag");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticleTag_Tag_TagId",
                table: "ArticleTag");

            migrationBuilder.RenameColumn(
                name: "TagId",
                table: "ArticleTag",
                newName: "ArticleTagsId");

            migrationBuilder.RenameColumn(
                name: "ArticleId",
                table: "ArticleTag",
                newName: "ArticlePicturesId");

            migrationBuilder.RenameIndex(
                name: "IX_ArticleTag_TagId",
                table: "ArticleTag",
                newName: "IX_ArticleTag_ArticleTagsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleTag_Articles_ArticlePicturesId",
                table: "ArticleTag",
                column: "ArticlePicturesId",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleTag_Tag_ArticleTagsId",
                table: "ArticleTag",
                column: "ArticleTagsId",
                principalTable: "Tag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
