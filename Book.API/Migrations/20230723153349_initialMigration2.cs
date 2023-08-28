using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Book.API.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("035e6c0e-75b8-45dc-a348-c9952a7c2882"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("51044623-e18a-41df-a495-19cede61e2aa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6f07f310-89e7-4a87-8529-65236b0a22c9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a4c4892b-145a-46b2-bfca-e78853d40cba"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("10689c18-0bd0-4ac5-b693-4f460d6c1d3e"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2617c53c-d79f-4321-a294-c1582ab6f2de"));

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CategoryType", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0e3a5b02-05d3-4f59-a45a-2a5f7cedf725"), 6, new DateTime(2023, 7, 23, 18, 33, 49, 427, DateTimeKind.Local).AddTicks(4046), false, "Toprak Ana", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb63e0f5-1290-41ad-ac69-1959cb1a8ee8"), 2, new DateTime(2023, 7, 23, 18, 33, 49, 427, DateTimeKind.Local).AddTicks(4050), false, "Tahıla Karsı", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d5affa3a-1fc4-4750-ad4e-0c52b8612497"), 5, new DateTime(2023, 7, 23, 18, 33, 49, 427, DateTimeKind.Local).AddTicks(4048), false, "Puslu Kıtalar Atlası", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e2e344e8-4f49-4595-ac05-47fcd779382b"), 6, new DateTime(2023, 7, 23, 18, 33, 49, 427, DateTimeKind.Local).AddTicks(4031), false, "Cemile", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedDate", "Name", "Password", "SignUpDate", "Token", "UpdatedDate", "UserType" },
                values: new object[,]
                {
                    { new Guid("d16f6c48-1529-472a-9d03-918209117875"), new DateTime(2023, 7, 23, 18, 33, 49, 427, DateTimeKind.Local).AddTicks(4232), "Admin", "1234", new DateTime(2023, 7, 23, 18, 33, 49, 427, DateTimeKind.Local).AddTicks(4233), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { new Guid("d9a7c9b9-48f7-422f-9be6-97d9e08303c8"), new DateTime(2023, 7, 23, 18, 33, 49, 427, DateTimeKind.Local).AddTicks(4237), "umutulupinar", "1234", new DateTime(2023, 7, 23, 18, 33, 49, 427, DateTimeKind.Local).AddTicks(4237), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0e3a5b02-05d3-4f59-a45a-2a5f7cedf725"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cb63e0f5-1290-41ad-ac69-1959cb1a8ee8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d5affa3a-1fc4-4750-ad4e-0c52b8612497"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e2e344e8-4f49-4595-ac05-47fcd779382b"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d16f6c48-1529-472a-9d03-918209117875"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d9a7c9b9-48f7-422f-9be6-97d9e08303c8"));

            migrationBuilder.DropColumn(
                name: "Password",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Token",
                table: "User");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CategoryType", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("035e6c0e-75b8-45dc-a348-c9952a7c2882"), 2, new DateTime(2023, 7, 21, 19, 36, 33, 473, DateTimeKind.Local).AddTicks(1061), false, "Tahıla Karsı", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("51044623-e18a-41df-a495-19cede61e2aa"), 5, new DateTime(2023, 7, 21, 19, 36, 33, 473, DateTimeKind.Local).AddTicks(1059), false, "Puslu Kıtalar Atlası", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6f07f310-89e7-4a87-8529-65236b0a22c9"), 6, new DateTime(2023, 7, 21, 19, 36, 33, 473, DateTimeKind.Local).AddTicks(1042), false, "Cemile", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a4c4892b-145a-46b2-bfca-e78853d40cba"), 6, new DateTime(2023, 7, 21, 19, 36, 33, 473, DateTimeKind.Local).AddTicks(1057), false, "Toprak Ana", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedDate", "Name", "SignUpDate", "UpdatedDate", "UserType" },
                values: new object[,]
                {
                    { new Guid("10689c18-0bd0-4ac5-b693-4f460d6c1d3e"), new DateTime(2023, 7, 21, 19, 36, 33, 473, DateTimeKind.Local).AddTicks(1223), "Admin", new DateTime(2023, 7, 21, 19, 36, 33, 473, DateTimeKind.Local).AddTicks(1223), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { new Guid("2617c53c-d79f-4321-a294-c1582ab6f2de"), new DateTime(2023, 7, 21, 19, 36, 33, 473, DateTimeKind.Local).AddTicks(1226), "umutulupinar", new DateTime(2023, 7, 21, 19, 36, 33, 473, DateTimeKind.Local).AddTicks(1227), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });
        }
    }
}
