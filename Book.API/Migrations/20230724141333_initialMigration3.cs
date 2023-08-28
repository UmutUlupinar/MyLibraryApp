using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Book.API.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Checkouts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CategoryType", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("acde91c1-76af-4b97-91b1-59c7d034b493"), 6, new DateTime(2023, 7, 24, 17, 13, 33, 492, DateTimeKind.Local).AddTicks(4892), false, "Cemile", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("da6072a4-0154-4eed-9bc9-e0ca9212561a"), 6, new DateTime(2023, 7, 24, 17, 13, 33, 492, DateTimeKind.Local).AddTicks(4933), false, "Toprak Ana", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc0b55cb-51fd-4e08-86f2-0aeb4db6fd99"), 5, new DateTime(2023, 7, 24, 17, 13, 33, 492, DateTimeKind.Local).AddTicks(4935), false, "Puslu Kıtalar Atlası", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fa9a551b-1190-48aa-8f60-610e744178f0"), 2, new DateTime(2023, 7, 24, 17, 13, 33, 492, DateTimeKind.Local).AddTicks(4936), false, "Tahıla Karsı", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedDate", "Name", "Password", "SignUpDate", "Token", "UpdatedDate", "UserType" },
                values: new object[,]
                {
                    { new Guid("7fb4546d-e885-4809-ab36-79bd2d9eb7c3"), new DateTime(2023, 7, 24, 17, 13, 33, 492, DateTimeKind.Local).AddTicks(5057), "Admin", "1234", new DateTime(2023, 7, 24, 17, 13, 33, 492, DateTimeKind.Local).AddTicks(5057), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { new Guid("b134ad06-e879-4fd0-a5c6-29b74a9ee412"), new DateTime(2023, 7, 24, 17, 13, 33, 492, DateTimeKind.Local).AddTicks(5059), "umutulupinar", "1234", new DateTime(2023, 7, 24, 17, 13, 33, 492, DateTimeKind.Local).AddTicks(5060), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("acde91c1-76af-4b97-91b1-59c7d034b493"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("da6072a4-0154-4eed-9bc9-e0ca9212561a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dc0b55cb-51fd-4e08-86f2-0aeb4db6fd99"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fa9a551b-1190-48aa-8f60-610e744178f0"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7fb4546d-e885-4809-ab36-79bd2d9eb7c3"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b134ad06-e879-4fd0-a5c6-29b74a9ee412"));

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Checkouts");

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
    }
}
