using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SenateData.Migrations
{
    /// <inheritdoc />
    public partial class seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VistType",
                table: "VisitTypes",
                newName: "Description");

            migrationBuilder.AddColumn<int>(
                name: "AppointmentModeId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BPSFrom",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BPSTo",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeePoolId",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeePoolsId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsGazetted",
                table: "Posts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "JobDescription",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JobExperience",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfPosts",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PermanentPosts",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PostStatusId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PostSubTypeId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PostTypeId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RequiredQualification",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SanctionDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SanctionNumber",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TemporaryPosts",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpgradationDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "EducationLevels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDistrict",
                table: "Cities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "BasicPayScales",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "EmployeePool",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePool", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostSubType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostSubType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostType", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BasicPayScales",
                columns: new[] { "Id", "Description", "IsActive" },
                values: new object[,]
                {
                    { 1, "BS-1", true },
                    { 2, "BS-2", true },
                    { 3, "BS-3", true },
                    { 4, "BS-4", true },
                    { 5, "BS-5", true },
                    { 6, "BS-6", true },
                    { 7, "BS-7", true },
                    { 8, "BS-8", true },
                    { 9, "BS-9", true },
                    { 10, "BS-10", true },
                    { 11, "BS-11", true },
                    { 12, "BS-12", true },
                    { 13, "BS-13", true },
                    { 14, "BS-14", true },
                    { 15, "BS-15", true },
                    { 16, "BS-16", true },
                    { 17, "BS-17", true },
                    { 18, "BS-18", true },
                    { 19, "BS-19", true },
                    { 20, "BS-20", true },
                    { 21, "BS-21", true },
                    { 22, "BS-22", true },
                    { 23, "Not Mentioned", true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_EmployeePoolId",
                table: "Posts",
                column: "EmployeePoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostSubTypeId",
                table: "Posts",
                column: "PostSubTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostTypeId",
                table: "Posts",
                column: "PostTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_EmployeePool_EmployeePoolId",
                table: "Posts",
                column: "EmployeePoolId",
                principalTable: "EmployeePool",
                principalColumn: "Id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_EmployeePool_EmployeePoolId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_PostSubType_PostSubTypeId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_PostType_PostTypeId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "EmployeePool");

            migrationBuilder.DropTable(
                name: "PostSubType");

            migrationBuilder.DropTable(
                name: "PostType");

            migrationBuilder.DropIndex(
                name: "IX_Posts_EmployeePoolId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_PostSubTypeId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_PostTypeId",
                table: "Posts");

            migrationBuilder.DeleteData(
                table: "BasicPayScales",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BasicPayScales",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BasicPayScales",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BasicPayScales",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BasicPayScales",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BasicPayScales",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BasicPayScales",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BasicPayScales",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BasicPayScales",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BasicPayScales",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BasicPayScales",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BasicPayScales",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BasicPayScales",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BasicPayScales",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BasicPayScales",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BasicPayScales",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BasicPayScales",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "BasicPayScales",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "BasicPayScales",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "BasicPayScales",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "BasicPayScales",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "BasicPayScales",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "BasicPayScales",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DropColumn(
                name: "AppointmentModeId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "BPSFrom",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "BPSTo",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "EmployeePoolId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "EmployeePoolsId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "IsGazetted",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "JobDescription",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "JobExperience",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "NumberOfPosts",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PermanentPosts",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PostStatusId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PostSubTypeId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PostTypeId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "RequiredQualification",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "SanctionDate",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "SanctionNumber",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "TemporaryPosts",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UpgradationDate",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "EducationLevels");

            migrationBuilder.DropColumn(
                name: "IsDistrict",
                table: "Cities");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "VisitTypes",
                newName: "VistType");

            migrationBuilder.AlterColumn<int>(
                name: "Description",
                table: "BasicPayScales",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
