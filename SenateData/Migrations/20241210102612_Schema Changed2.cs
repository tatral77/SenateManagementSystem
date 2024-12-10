using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SenateData.Migrations
{
    /// <inheritdoc />
    public partial class SchemaChanged2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BasicPayScales",
                table: "BasicPayScales");

            migrationBuilder.EnsureSchema(
                name: "HRM");

            migrationBuilder.RenameTable(
                name: "BasicPayScales",
                newName: "BasicPayScale",
                newSchema: "HRM");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Resolution",
                table: "ResolutionStatus",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasicPayScale",
                schema: "HRM",
                table: "BasicPayScale",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BasicPayScale",
                schema: "HRM",
                table: "BasicPayScale");

            migrationBuilder.RenameTable(
                name: "BasicPayScale",
                schema: "HRM",
                newName: "BasicPayScales");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Resolution",
                table: "ResolutionStatus",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasicPayScales",
                table: "BasicPayScales",
                column: "Id");
        }
    }
}
