using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YB_MelihEfeOmer_RezervasyonApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DatasFixef : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("6f47dbc8-2007-4da4-9a88-39d3ad709823"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("8617e082-3112-4a12-b58f-08d6acfbfbf5"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ad77ec3f-d3ea-4858-b3db-95ea1ccf3a42"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c6d90c07-feeb-4d51-8316-3eb7597b0116"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c83d438e-92bc-4809-94ca-c6c60e98e8b3"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ea5140ed-ef60-4f04-bd2c-2b5c3510edad"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("111110f2-05c7-4196-bea8-87d0c4ea8842"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("57d2b89e-b545-4c1b-8bbd-4355066d459b"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("4bc7a753-e4db-42d5-88b8-10f491ade819"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("56cc9a9b-6419-46c2-b030-11c918b5bab9"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("4a49b00e-6cd3-4009-afbf-23b2902acb2a"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("6dc9470f-ea1c-417c-9169-9e3e7373a9f7"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("d4051c5a-8d63-4f91-bf3f-bb30e62a9ec3"));

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CheckinTime", "CheckoutTime", "CreatedTime", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("99326cba-e915-4711-81de-375352b8659a"), "İzmir/Alsancak", new TimeOnly(8, 0, 0), new TimeOnly(23, 59, 0), new DateTime(2024, 7, 22, 17, 51, 10, 350, DateTimeKind.Local).AddTicks(8032), "ibishotel@hotmail.com", false, false, "İbis", "09998887766", (byte)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c37e28d3-5467-4f6d-bb83-45f64a921b1f"), "İstanbul/Eminönü", new TimeOnly(8, 0, 0), new TimeOnly(23, 59, 0), new DateTime(2024, 7, 22, 17, 51, 10, 350, DateTimeKind.Local).AddTicks(8104), "turkuaz@hotmail.com", false, false, "Turkuaz", "55554443265", (byte)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Capacity", "CreatedTime", "Description", "IsActive", "IsDeleted", "Name", "PricePerNight", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("4f403c13-91d5-425a-8c19-9e2752a639bc"), (byte)1, new DateTime(2024, 7, 22, 17, 51, 10, 350, DateTimeKind.Local).AddTicks(8316), "Single type room", false, false, "Single", 500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9602a99d-3db7-43ef-8cb8-3f9928534171"), (byte)2, new DateTime(2024, 7, 22, 17, 51, 10, 350, DateTimeKind.Local).AddTicks(8240), "Suit type room", false, false, "Suit", 1000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aa0c0a7a-0e98-47cc-95ce-3e4fbaa0734c"), (byte)4, new DateTime(2024, 7, 22, 17, 51, 10, 350, DateTimeKind.Local).AddTicks(8281), "King type room", false, false, "King", 4000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedTime", "HotelId", "IsActive", "IsDeleted", "RoomNumber", "RoomTypeId", "Status", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("66d1a3aa-46b0-4056-8a2d-53b40e28d866"), new DateTime(2024, 7, 22, 17, 51, 10, 350, DateTimeKind.Local).AddTicks(8560), new Guid("c37e28d3-5467-4f6d-bb83-45f64a921b1f"), false, false, 102, new Guid("4f403c13-91d5-425a-8c19-9e2752a639bc"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a8a15b45-5d89-4975-b004-6c31ccd6531e"), new DateTime(2024, 7, 22, 17, 51, 10, 350, DateTimeKind.Local).AddTicks(8518), new Guid("c37e28d3-5467-4f6d-bb83-45f64a921b1f"), false, false, 101, new Guid("4f403c13-91d5-425a-8c19-9e2752a639bc"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ba754e20-15a0-48d7-b8e7-bfbb434178df"), new DateTime(2024, 7, 22, 17, 51, 10, 350, DateTimeKind.Local).AddTicks(8414), new Guid("99326cba-e915-4711-81de-375352b8659a"), false, false, 102, new Guid("9602a99d-3db7-43ef-8cb8-3f9928534171"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d1441bd8-c51f-4080-9a73-036efa06adf1"), new DateTime(2024, 7, 22, 17, 51, 10, 350, DateTimeKind.Local).AddTicks(8450), new Guid("99326cba-e915-4711-81de-375352b8659a"), false, false, 201, new Guid("aa0c0a7a-0e98-47cc-95ce-3e4fbaa0734c"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d46f4910-9845-4a6e-9de5-468c6c319e77"), new DateTime(2024, 7, 22, 17, 51, 10, 350, DateTimeKind.Local).AddTicks(8484), new Guid("99326cba-e915-4711-81de-375352b8659a"), false, false, 202, new Guid("4f403c13-91d5-425a-8c19-9e2752a639bc"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eccff4b6-7b8b-4d86-8278-0cb989e389c6"), new DateTime(2024, 7, 22, 17, 51, 10, 350, DateTimeKind.Local).AddTicks(8359), new Guid("99326cba-e915-4711-81de-375352b8659a"), false, false, 101, new Guid("9602a99d-3db7-43ef-8cb8-3f9928534171"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CreatedTime", "DateOfBirth", "Email", "FirstName", "HireDate", "HotelId", "IsActive", "IsDeleted", "LastName", "Phone", "Position", "Salary", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("2a1b2c33-fdc4-4d43-9bf8-2c09ada4327c"), new DateTime(2024, 7, 22, 17, 51, 10, 350, DateTimeKind.Local).AddTicks(8142), new DateOnly(1970, 1, 1), "ThisIsStaff@hotmail.com", "Ali", new DateOnly(2010, 1, 1), new Guid("99326cba-e915-4711-81de-375352b8659a"), false, false, "Vali", "09995554433", "Manager", 50000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c5b16e84-c3b7-49f4-a31d-2758265eab4f"), new DateTime(2024, 7, 22, 17, 51, 10, 350, DateTimeKind.Local).AddTicks(8193), new DateOnly(1980, 1, 1), "ThisIsStaff2@hotmail.com", "Murat", new DateOnly(1981, 1, 1), new Guid("c37e28d3-5467-4f6d-bb83-45f64a921b1f"), false, false, "Duran", "09995554433", "Manager", 50000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("66d1a3aa-46b0-4056-8a2d-53b40e28d866"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a8a15b45-5d89-4975-b004-6c31ccd6531e"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ba754e20-15a0-48d7-b8e7-bfbb434178df"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("d1441bd8-c51f-4080-9a73-036efa06adf1"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("d46f4910-9845-4a6e-9de5-468c6c319e77"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("eccff4b6-7b8b-4d86-8278-0cb989e389c6"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("2a1b2c33-fdc4-4d43-9bf8-2c09ada4327c"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("c5b16e84-c3b7-49f4-a31d-2758265eab4f"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("99326cba-e915-4711-81de-375352b8659a"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("c37e28d3-5467-4f6d-bb83-45f64a921b1f"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("4f403c13-91d5-425a-8c19-9e2752a639bc"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("9602a99d-3db7-43ef-8cb8-3f9928534171"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("aa0c0a7a-0e98-47cc-95ce-3e4fbaa0734c"));

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CheckinTime", "CheckoutTime", "CreatedTime", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("4bc7a753-e4db-42d5-88b8-10f491ade819"), "İzmir/Alsancak", new TimeOnly(8, 0, 0), new TimeOnly(23, 59, 0), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ibishotel@hotmail.com", false, false, "İbis", "09998887766", (byte)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("56cc9a9b-6419-46c2-b030-11c918b5bab9"), "İstanbul/Eminönü", new TimeOnly(8, 0, 0), new TimeOnly(23, 59, 0), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "turkuaz@hotmail.com", false, false, "Turkuaz", "55554443265", (byte)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Capacity", "CreatedTime", "Description", "IsActive", "IsDeleted", "Name", "PricePerNight", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("4a49b00e-6cd3-4009-afbf-23b2902acb2a"), (byte)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "King type room", false, false, "King", 4000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6dc9470f-ea1c-417c-9169-9e3e7373a9f7"), (byte)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Suit type room", false, false, "Suit", 1000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d4051c5a-8d63-4f91-bf3f-bb30e62a9ec3"), (byte)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Single type room", false, false, "Single", 500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedTime", "HotelId", "IsActive", "IsDeleted", "RoomNumber", "RoomTypeId", "Status", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("6f47dbc8-2007-4da4-9a88-39d3ad709823"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4bc7a753-e4db-42d5-88b8-10f491ade819"), false, false, 201, new Guid("4a49b00e-6cd3-4009-afbf-23b2902acb2a"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8617e082-3112-4a12-b58f-08d6acfbfbf5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4bc7a753-e4db-42d5-88b8-10f491ade819"), false, false, 102, new Guid("6dc9470f-ea1c-417c-9169-9e3e7373a9f7"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ad77ec3f-d3ea-4858-b3db-95ea1ccf3a42"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4bc7a753-e4db-42d5-88b8-10f491ade819"), false, false, 101, new Guid("6dc9470f-ea1c-417c-9169-9e3e7373a9f7"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c6d90c07-feeb-4d51-8316-3eb7597b0116"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("56cc9a9b-6419-46c2-b030-11c918b5bab9"), false, false, 102, new Guid("d4051c5a-8d63-4f91-bf3f-bb30e62a9ec3"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c83d438e-92bc-4809-94ca-c6c60e98e8b3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("56cc9a9b-6419-46c2-b030-11c918b5bab9"), false, false, 101, new Guid("d4051c5a-8d63-4f91-bf3f-bb30e62a9ec3"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ea5140ed-ef60-4f04-bd2c-2b5c3510edad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4bc7a753-e4db-42d5-88b8-10f491ade819"), false, false, 202, new Guid("d4051c5a-8d63-4f91-bf3f-bb30e62a9ec3"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CreatedTime", "DateOfBirth", "Email", "FirstName", "HireDate", "HotelId", "IsActive", "IsDeleted", "LastName", "Phone", "Position", "Salary", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("111110f2-05c7-4196-bea8-87d0c4ea8842"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1970, 1, 1), "ThisIsStaff@hotmail.com", "Ali", new DateOnly(2010, 1, 1), new Guid("4bc7a753-e4db-42d5-88b8-10f491ade819"), false, false, "Vali", "09995554433", "Manager", 50000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("57d2b89e-b545-4c1b-8bbd-4355066d459b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1980, 1, 1), "ThisIsStaff2@hotmail.com", "Murat", new DateOnly(1981, 1, 1), new Guid("56cc9a9b-6419-46c2-b030-11c918b5bab9"), false, false, "Duran", "09995554433", "Manager", 50000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
