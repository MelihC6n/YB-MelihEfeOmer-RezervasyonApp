using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YB_MelihEfeOmer_RezervasyonApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class dataAddFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("1605fc67-d031-4e54-b872-53bcabde7543"), new Guid("f9cce1c4-cd5c-4ec5-a37d-5e8c3d41c5d6") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("29690c18-f14b-4235-944b-05660631475f"), new Guid("f9cce1c4-cd5c-4ec5-a37d-5e8c3d41c5d6") });

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("1015a3ab-0203-4c78-a5f8-074565d28159"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("6d1a079d-8ba5-4ad4-bf19-749e193a7d0b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("98b44101-d5d1-4f37-9773-21dc715502bd"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("d51aa5ff-b10d-458c-9827-44ba21715588"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ffc4d23e-c4f8-4d45-b50a-61821f738a86"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("b93f68d3-b1ec-4bf9-b5f9-a2ef58b2c386"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("d6e9838f-673b-449e-a4da-121ccc4bad37"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("1605fc67-d031-4e54-b872-53bcabde7543"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("29690c18-f14b-4235-944b-05660631475f"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("f9cce1c4-cd5c-4ec5-a37d-5e8c3d41c5d6"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("94525f48-c2d7-40df-9eb1-05e497a3b017"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("4526b32f-357a-4840-83bf-c623eb165b16"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("c82931f9-eb9c-4a13-a7d5-010d403dee55"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("3900fda2-7190-486a-b525-c0ebddefd668"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("ab82cf27-2085-4fd1-b0c4-00247dc3e6ef"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("c5f47aa4-c21a-4c9b-be83-d914f209f970"));

            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "Id", "Address", "CreatedTime", "DateOfBirth", "Email", "FirstName", "IdentityNumber", "IsActive", "IsDeleted", "LastName", "Phone", "UpdatedTime" },
                values: new object[] { new Guid("24269b24-8c02-443b-807c-265d64d46e8c"), "İstanbul Beylikdüzü Bişeyler mahallesi", new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1893), new DateOnly(1999, 9, 9), "aaa@test.com", "Ali", "61006494392", false, false, "Veli", "56569856", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CheckinTime", "CheckoutTime", "CreatedTime", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("b6a4d4d6-676e-44ae-86ff-3e71ff15da52"), "İzmir/Alsancak", new TimeOnly(8, 0, 0), new TimeOnly(23, 59, 0), new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1593), "ibishotel@hotmail.com", false, false, "İbis", "09998887766", (byte)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d7873d75-56b1-4fc2-bb73-c739a75b11cf"), "İstanbul/Eminönü", new TimeOnly(8, 0, 0), new TimeOnly(23, 59, 0), new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1648), "turkuaz@hotmail.com", false, false, "Turkuaz", "55554443265", (byte)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Capacity", "CreatedTime", "Description", "IsActive", "IsDeleted", "Name", "PricePerNight", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("3cf45b63-53d6-4325-abca-06570b622a61"), (byte)4, new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1807), "King type room", false, false, "King", 4000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("497f996c-d4cb-47ba-8b52-28f5a9e3d408"), (byte)1, new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1817), "Single type room", false, false, "Single", 500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc99ab14-371a-4c33-a075-dcf8cf3b2b60"), (byte)2, new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1792), "Suit type room", false, false, "Suit", 1000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedTime", "HotelId", "IsActive", "IsDeleted", "RoomNumber", "RoomTypeId", "Status", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("190a8926-536b-4668-8f46-090534a18142"), new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1829), new Guid("b6a4d4d6-676e-44ae-86ff-3e71ff15da52"), false, false, 101, new Guid("dc99ab14-371a-4c33-a075-dcf8cf3b2b60"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("84d31dfa-f6c7-44ff-bd84-fd8380ee5a36"), new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1860), new Guid("b6a4d4d6-676e-44ae-86ff-3e71ff15da52"), false, false, 202, new Guid("497f996c-d4cb-47ba-8b52-28f5a9e3d408"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("86c036b1-faba-470d-8860-43fd96ae1588"), new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1839), new Guid("b6a4d4d6-676e-44ae-86ff-3e71ff15da52"), false, false, 102, new Guid("dc99ab14-371a-4c33-a075-dcf8cf3b2b60"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("87078621-e5eb-468c-a90b-cc6ad0ff6b64"), new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1878), new Guid("d7873d75-56b1-4fc2-bb73-c739a75b11cf"), false, false, 102, new Guid("497f996c-d4cb-47ba-8b52-28f5a9e3d408"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8eea7d60-5cca-42ad-a0c1-8ebe777fb1c0"), new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1869), new Guid("d7873d75-56b1-4fc2-bb73-c739a75b11cf"), false, false, 101, new Guid("497f996c-d4cb-47ba-8b52-28f5a9e3d408"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("99b55501-433f-4fa5-843e-135ea0543995"), new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1850), new Guid("b6a4d4d6-676e-44ae-86ff-3e71ff15da52"), false, false, 201, new Guid("3cf45b63-53d6-4325-abca-06570b622a61"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CreatedTime", "DateOfBirth", "Email", "FirstName", "HireDate", "HotelId", "IsActive", "IsDeleted", "LastName", "Phone", "Position", "Salary", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("e4e58589-134e-4cf9-940a-a1ea7c9a1fc4"), new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1750), new DateOnly(1970, 1, 1), "ThisIsStaff@hotmail.com", "Ali", new DateOnly(2010, 1, 1), new Guid("b6a4d4d6-676e-44ae-86ff-3e71ff15da52"), false, false, "Vali", "09995554433", "Manager", 50000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f297e6e2-480d-4910-92f4-6e13f5a4fd03"), new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1777), new DateOnly(1980, 1, 1), "ThisIsStaff2@hotmail.com", "Murat", new DateOnly(1981, 1, 1), new Guid("d7873d75-56b1-4fc2-bb73-c739a75b11cf"), false, false, "Duran", "09995554433", "Manager", 50000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CheckinDate", "CheckoutDate", "CreatedTime", "IsActive", "IsDeleted", "RoomId", "TotalPrice", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("25479c99-babb-4b95-b1a7-34097708a61f"), new DateOnly(2024, 7, 23), new DateOnly(2024, 7, 28), new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1907), false, false, new Guid("190a8926-536b-4668-8f46-090534a18142"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9615b8a8-e68d-42f4-8615-14c0e2e679a4"), new DateOnly(2024, 8, 1), new DateOnly(2024, 8, 2), new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1918), false, false, new Guid("190a8926-536b-4668-8f46-090534a18142"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "BRBookingGuests",
                columns: new[] { "BookingId", "GuestId", "CreatedTime", "IsActive", "IsDeleted", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("25479c99-babb-4b95-b1a7-34097708a61f"), new Guid("24269b24-8c02-443b-807c-265d64d46e8c"), new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1932), false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9615b8a8-e68d-42f4-8615-14c0e2e679a4"), new Guid("24269b24-8c02-443b-807c-265d64d46e8c"), new DateTime(2024, 7, 26, 9, 48, 1, 410, DateTimeKind.Local).AddTicks(1943), false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("25479c99-babb-4b95-b1a7-34097708a61f"), new Guid("24269b24-8c02-443b-807c-265d64d46e8c") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("9615b8a8-e68d-42f4-8615-14c0e2e679a4"), new Guid("24269b24-8c02-443b-807c-265d64d46e8c") });

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("84d31dfa-f6c7-44ff-bd84-fd8380ee5a36"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("86c036b1-faba-470d-8860-43fd96ae1588"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("87078621-e5eb-468c-a90b-cc6ad0ff6b64"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("8eea7d60-5cca-42ad-a0c1-8ebe777fb1c0"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("99b55501-433f-4fa5-843e-135ea0543995"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("e4e58589-134e-4cf9-940a-a1ea7c9a1fc4"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("f297e6e2-480d-4910-92f4-6e13f5a4fd03"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("25479c99-babb-4b95-b1a7-34097708a61f"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("9615b8a8-e68d-42f4-8615-14c0e2e679a4"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("24269b24-8c02-443b-807c-265d64d46e8c"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("d7873d75-56b1-4fc2-bb73-c739a75b11cf"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("3cf45b63-53d6-4325-abca-06570b622a61"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("497f996c-d4cb-47ba-8b52-28f5a9e3d408"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("190a8926-536b-4668-8f46-090534a18142"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("b6a4d4d6-676e-44ae-86ff-3e71ff15da52"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("dc99ab14-371a-4c33-a075-dcf8cf3b2b60"));

            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "Id", "Address", "CreatedTime", "DateOfBirth", "Email", "FirstName", "IdentityNumber", "IsActive", "IsDeleted", "LastName", "Phone", "UpdatedTime" },
                values: new object[] { new Guid("f9cce1c4-cd5c-4ec5-a37d-5e8c3d41c5d6"), "aa", new DateTime(2024, 7, 24, 21, 35, 46, 641, DateTimeKind.Local).AddTicks(4247), new DateOnly(1999, 9, 9), "aaa", "Test", "11111111111", false, false, "Test", "5656", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CheckinTime", "CheckoutTime", "CreatedTime", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("94525f48-c2d7-40df-9eb1-05e497a3b017"), "İstanbul/Eminönü", new TimeOnly(8, 0, 0), new TimeOnly(23, 59, 0), new DateTime(2024, 7, 24, 21, 35, 46, 641, DateTimeKind.Local).AddTicks(3866), "turkuaz@hotmail.com", false, false, "Turkuaz", "55554443265", (byte)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ab82cf27-2085-4fd1-b0c4-00247dc3e6ef"), "İzmir/Alsancak", new TimeOnly(8, 0, 0), new TimeOnly(23, 59, 0), new DateTime(2024, 7, 24, 21, 35, 46, 641, DateTimeKind.Local).AddTicks(3786), "ibishotel@hotmail.com", false, false, "İbis", "09998887766", (byte)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Capacity", "CreatedTime", "Description", "IsActive", "IsDeleted", "Name", "PricePerNight", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("4526b32f-357a-4840-83bf-c623eb165b16"), (byte)1, new DateTime(2024, 7, 24, 21, 35, 46, 641, DateTimeKind.Local).AddTicks(4076), "Single type room", false, false, "Single", 500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c5f47aa4-c21a-4c9b-be83-d914f209f970"), (byte)2, new DateTime(2024, 7, 24, 21, 35, 46, 641, DateTimeKind.Local).AddTicks(4017), "Suit type room", false, false, "Suit", 1000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c82931f9-eb9c-4a13-a7d5-010d403dee55"), (byte)4, new DateTime(2024, 7, 24, 21, 35, 46, 641, DateTimeKind.Local).AddTicks(4052), "King type room", false, false, "King", 4000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedTime", "HotelId", "IsActive", "IsDeleted", "RoomNumber", "RoomTypeId", "Status", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("1015a3ab-0203-4c78-a5f8-074565d28159"), new DateTime(2024, 7, 24, 21, 35, 46, 641, DateTimeKind.Local).AddTicks(4194), new Guid("94525f48-c2d7-40df-9eb1-05e497a3b017"), false, false, 101, new Guid("4526b32f-357a-4840-83bf-c623eb165b16"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3900fda2-7190-486a-b525-c0ebddefd668"), new DateTime(2024, 7, 24, 21, 35, 46, 641, DateTimeKind.Local).AddTicks(4104), new Guid("ab82cf27-2085-4fd1-b0c4-00247dc3e6ef"), false, false, 101, new Guid("c5f47aa4-c21a-4c9b-be83-d914f209f970"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6d1a079d-8ba5-4ad4-bf19-749e193a7d0b"), new DateTime(2024, 7, 24, 21, 35, 46, 641, DateTimeKind.Local).AddTicks(4151), new Guid("ab82cf27-2085-4fd1-b0c4-00247dc3e6ef"), false, false, 201, new Guid("c82931f9-eb9c-4a13-a7d5-010d403dee55"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("98b44101-d5d1-4f37-9773-21dc715502bd"), new DateTime(2024, 7, 24, 21, 35, 46, 641, DateTimeKind.Local).AddTicks(4219), new Guid("94525f48-c2d7-40df-9eb1-05e497a3b017"), false, false, 102, new Guid("4526b32f-357a-4840-83bf-c623eb165b16"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d51aa5ff-b10d-458c-9827-44ba21715588"), new DateTime(2024, 7, 24, 21, 35, 46, 641, DateTimeKind.Local).AddTicks(4174), new Guid("ab82cf27-2085-4fd1-b0c4-00247dc3e6ef"), false, false, 202, new Guid("4526b32f-357a-4840-83bf-c623eb165b16"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ffc4d23e-c4f8-4d45-b50a-61821f738a86"), new DateTime(2024, 7, 24, 21, 35, 46, 641, DateTimeKind.Local).AddTicks(4131), new Guid("ab82cf27-2085-4fd1-b0c4-00247dc3e6ef"), false, false, 102, new Guid("c5f47aa4-c21a-4c9b-be83-d914f209f970"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CreatedTime", "DateOfBirth", "Email", "FirstName", "HireDate", "HotelId", "IsActive", "IsDeleted", "LastName", "Phone", "Position", "Salary", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("b93f68d3-b1ec-4bf9-b5f9-a2ef58b2c386"), new DateTime(2024, 7, 24, 21, 35, 46, 641, DateTimeKind.Local).AddTicks(3976), new DateOnly(1980, 1, 1), "ThisIsStaff2@hotmail.com", "Murat", new DateOnly(1981, 1, 1), new Guid("94525f48-c2d7-40df-9eb1-05e497a3b017"), false, false, "Duran", "09995554433", "Manager", 50000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d6e9838f-673b-449e-a4da-121ccc4bad37"), new DateTime(2024, 7, 24, 21, 35, 46, 641, DateTimeKind.Local).AddTicks(3920), new DateOnly(1970, 1, 1), "ThisIsStaff@hotmail.com", "Ali", new DateOnly(2010, 1, 1), new Guid("ab82cf27-2085-4fd1-b0c4-00247dc3e6ef"), false, false, "Vali", "09995554433", "Manager", 50000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CheckinDate", "CheckoutDate", "CreatedTime", "IsActive", "IsDeleted", "RoomId", "TotalPrice", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("1605fc67-d031-4e54-b872-53bcabde7543"), new DateOnly(2024, 7, 23), new DateOnly(2024, 7, 28), new DateTime(2024, 7, 24, 21, 35, 46, 641, DateTimeKind.Local).AddTicks(4286), false, false, new Guid("3900fda2-7190-486a-b525-c0ebddefd668"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("29690c18-f14b-4235-944b-05660631475f"), new DateOnly(2024, 8, 1), new DateOnly(2024, 8, 2), new DateTime(2024, 7, 24, 21, 35, 46, 641, DateTimeKind.Local).AddTicks(4316), false, false, new Guid("3900fda2-7190-486a-b525-c0ebddefd668"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "BRBookingGuests",
                columns: new[] { "BookingId", "GuestId", "CreatedTime", "IsActive", "IsDeleted", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("1605fc67-d031-4e54-b872-53bcabde7543"), new Guid("f9cce1c4-cd5c-4ec5-a37d-5e8c3d41c5d6"), new DateTime(2024, 7, 24, 21, 35, 46, 641, DateTimeKind.Local).AddTicks(4353), false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("29690c18-f14b-4235-944b-05660631475f"), new Guid("f9cce1c4-cd5c-4ec5-a37d-5e8c3d41c5d6"), new DateTime(2024, 7, 24, 21, 35, 46, 641, DateTimeKind.Local).AddTicks(4377), false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
