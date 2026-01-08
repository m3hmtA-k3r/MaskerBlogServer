using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaskerBlog.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_identity_BETWEEN_BLOG_comment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BlogID",
                table: "Comment",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Comment_BlogID",
                table: "Comment",
                column: "BlogID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Blogs_BlogID",
                table: "Comment",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Blogs_BlogID",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_BlogID",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "BlogID",
                table: "Comment");
        }
    }
}
