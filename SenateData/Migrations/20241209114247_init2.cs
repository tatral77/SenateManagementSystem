using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SenateData.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_PostSubType_PostSubTypeId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_PostType_PostTypeId",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostType",
                table: "PostType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostSubType",
                table: "PostSubType");

            migrationBuilder.RenameTable(
                name: "PostType",
                newName: "postTypes");

            migrationBuilder.RenameTable(
                name: "PostSubType",
                newName: "PostSubTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_postTypes",
                table: "postTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostSubTypes",
                table: "PostSubTypes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "PostStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostStatuses", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_PostSubTypes_PostSubTypeId",
                table: "Posts",
                column: "PostSubTypeId",
                principalTable: "PostSubTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_postTypes_PostTypeId",
                table: "Posts",
                column: "PostTypeId",
                principalTable: "postTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_PostSubTypes_PostSubTypeId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_postTypes_PostTypeId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "PostStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_postTypes",
                table: "postTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostSubTypes",
                table: "PostSubTypes");

            migrationBuilder.RenameTable(
                name: "postTypes",
                newName: "PostType");

            migrationBuilder.RenameTable(
                name: "PostSubTypes",
                newName: "PostSubType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostType",
                table: "PostType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostSubType",
                table: "PostSubType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_PostSubType_PostSubTypeId",
                table: "Posts",
                column: "PostSubTypeId",
                principalTable: "PostSubType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_PostType_PostTypeId",
                table: "Posts",
                column: "PostTypeId",
                principalTable: "PostType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
