using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YB_MelihEfeOmer_RezervasyonApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newDataSetted3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("38d95d98-443d-409d-992c-4e1eade9b812"), new Guid("9cb7c7be-ae79-4a8c-aebc-d87289700ed9") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("43d97cf9-5dfa-4c92-97ad-5307409ed7b8"), new Guid("103153ef-548a-4b0e-8181-bea256481a84") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("4e1c7cef-4630-43ab-b4bb-3c101176e4f5"), new Guid("b1748721-3387-4831-8900-f992482099fd") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("8b625fef-809b-4e66-8ece-a0d09e4eff7f"), new Guid("02e8c85c-da54-4074-a1e1-473c2c38b8cc") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("9c4b6924-f4d0-40bc-872d-9bfb8242eb55"), new Guid("4f42ba1f-2b1a-4032-8e3b-56101b5faf39") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("aecd7393-96a3-4d33-84c7-08f6177c5e00"), new Guid("48f2e42c-dcf8-41f5-b120-82556a80b57b") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("cd6654e7-e51c-434a-8dfd-9857feae9063"), new Guid("ba889f71-5a25-4f90-9856-ab6bfc66cea3") });

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("0eafeef7-4c8c-4929-a3fa-cc09d816bc0f"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("416e2bc4-cdef-4e18-91a9-8ab8ee8107b3"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("d4038f75-8fd9-48b6-97d1-438295968971"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("38d95d98-443d-409d-992c-4e1eade9b812"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("43d97cf9-5dfa-4c92-97ad-5307409ed7b8"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("4e1c7cef-4630-43ab-b4bb-3c101176e4f5"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("8b625fef-809b-4e66-8ece-a0d09e4eff7f"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("9c4b6924-f4d0-40bc-872d-9bfb8242eb55"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("aecd7393-96a3-4d33-84c7-08f6177c5e00"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("cd6654e7-e51c-434a-8dfd-9857feae9063"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("02e8c85c-da54-4074-a1e1-473c2c38b8cc"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("103153ef-548a-4b0e-8181-bea256481a84"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("48f2e42c-dcf8-41f5-b120-82556a80b57b"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("4f42ba1f-2b1a-4032-8e3b-56101b5faf39"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("9cb7c7be-ae79-4a8c-aebc-d87289700ed9"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("b1748721-3387-4831-8900-f992482099fd"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("ba889f71-5a25-4f90-9856-ab6bfc66cea3"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("208b24af-fd91-4c2d-9dc0-426f049d1923"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("266d4ba4-1d78-47d0-a683-4d92483e08ce"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("6b93575f-56a5-40f7-8c08-9fe75341573c"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("8a8e6a2a-b1ee-4ed3-9cd4-ba0862c61551"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("93356ce6-81f4-4cde-a15e-79a640a27492"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a9be0c84-7700-4e25-a443-2d9fe9a68ad6"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("d681e8d3-29ac-4247-a88c-7410629f8596"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("1b80125c-a94d-4c36-aaac-9974b35b2313"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("8b46fb2c-96f7-4d8f-9ff5-455fb38c358c"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("a682ebfe-a0eb-4aa1-b2b1-e9561afdf2bd"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("16a6f3b6-84a3-4565-9ade-1d1ce091ae99"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("34c07445-759a-45ef-8464-bf4ddf6a6201"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("4b22ae83-834a-4700-a009-0ea689f36419"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("82757736-fd93-4aa6-ae1d-17d590766d86"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("a37ac234-16c0-4e3b-a350-e2166de6e7b5"));

            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "Id", "Address", "CreatedTime", "DateOfBirth", "Email", "FirstName", "IdentityNumber", "IsActive", "IsDeleted", "LastName", "Phone", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("15be594c-966d-4d3c-8cdd-185a2c16a23b"), "İstanbul Şişli", new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2539), new DateOnly(1980, 11, 10), "can.yurt@example.com", "Can", "45678912301", true, false, "Yurt", "05678912345", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("26f1e987-dec2-41e6-aa5f-c1c570504578"), "İstanbul Kadıköy", new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2619), new DateOnly(1986, 2, 20), "ege.kurt@example.com", "Ege", "67890123456", true, false, "Kurt", "05556667788", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6a23c468-7a24-4cff-9330-f09efa97aeab"), "Bursa Nilüfer", new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2536), new DateOnly(1985, 4, 12), "burak.ozdemir@example.com", "Burak", "12345678902", true, false, "Özdemir", "01234567893", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8d784768-9c34-4bda-a2bc-2b522085fa04"), "İzmir Alsancak", new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2620), new DateOnly(1995, 7, 15), "elif.sonmez@example.com", "Elif", "54321098765", true, false, "Sönmez", "07778889900", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("934bb9eb-5d42-486b-824e-f8d4bcd2d742"), "Ankara Çankaya", new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2491), new DateOnly(1990, 6, 30), "mehmet.kara@example.com", "Mehmet", "12345678901", true, false, "Kara", "01234567892", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a962a452-934a-4cfd-a678-c1a12c23758c"), "Antalya Konyaaltı", new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2538), new DateOnly(1992, 8, 22), "zeynep.aydin@example.com", "Zeynep", "10987654322", true, false, "Aydın", "09876543213", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d1677225-1aa5-484a-849d-f26956279522"), "İzmir Karşıyaka", new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2494), new DateOnly(1988, 12, 25), "ayse.yilmaz@example.com", "Ayşe", "10987654321", true, false, "Yılmaz", "09876543212", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CheckinTime", "CheckoutTime", "CreatedTime", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("045ffc63-66ce-4c80-9810-87d7a393677f"), "Antalya/Belek", new TimeOnly(14, 0, 0), new TimeOnly(12, 0, 0), new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2346), "hiltonhotel@example.com", true, false, "Hilton", "01234567890", (byte)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4ef75300-35bf-42c6-abe5-336d2ef35dcb"), "Bodrum/Yalıkavak", new TimeOnly(15, 0, 0), new TimeOnly(11, 0, 0), new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2361), "marriotthotel@example.com", true, false, "Marriott", "09876543210", (byte)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7aba79bd-e6b2-41f7-a3d7-a6f85ff28c64"), "Ankara Çankaya", new TimeOnly(14, 0, 0), new TimeOnly(12, 0, 0), new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2580), "radissonblu@example.com", true, false, "Radisson Blu", "02223334455", (byte)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Capacity", "CreatedTime", "Description", "IsActive", "IsDeleted", "Name", "PricePerNight", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("1db1fdd6-213f-4bf0-a1b0-ac49ccc2941f"), (byte)3, new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2447), "Deluxe room with sea view", true, false, "Deluxe", 2000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("20ea6585-a22e-4c38-ac32-05d933fa7b11"), (byte)2, new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2450), "Executive room with additional amenities", true, false, "Executive", 3500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5ec9600f-1905-41e8-a4e7-38c01388e3ba"), (byte)4, new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2592), "Luxurious Presidential Suite", true, false, "Royal S", 5000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("97a95cb3-f95c-46e2-80b7-913d525c6f7f"), (byte)1, new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2451), "Standard room", true, false, "Standard", 700m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c4b2acb3-d9c4-4b52-8a13-e99edcb57810"), (byte)3, new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2594), "Spacious Junior Suite with extra amenities", true, false, "Junior S.", 2500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedTime", "HotelId", "IsActive", "IsDeleted", "RoomNumber", "RoomTypeId", "Status", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("1941dd5d-2313-4498-b9f4-9ac303648da1"), new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2607), new Guid("7aba79bd-e6b2-41f7-a3d7-a6f85ff28c64"), true, false, 102, new Guid("c4b2acb3-d9c4-4b52-8a13-e99edcb57810"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1d7f4ed8-75c0-45ec-b5de-9ca849733e7f"), new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2467), new Guid("045ffc63-66ce-4c80-9810-87d7a393677f"), true, false, 201, new Guid("1db1fdd6-213f-4bf0-a1b0-ac49ccc2941f"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("282a28e2-15b7-411e-9403-3f64e607815d"), new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2468), new Guid("045ffc63-66ce-4c80-9810-87d7a393677f"), true, false, 202, new Guid("20ea6585-a22e-4c38-ac32-05d933fa7b11"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4f11eb3c-48e3-4886-8595-3800b2071a68"), new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2471), new Guid("4ef75300-35bf-42c6-abe5-336d2ef35dcb"), true, false, 302, new Guid("1db1fdd6-213f-4bf0-a1b0-ac49ccc2941f"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5e6bb513-651e-4081-a4c2-99fde106565d"), new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2470), new Guid("4ef75300-35bf-42c6-abe5-336d2ef35dcb"), true, false, 301, new Guid("97a95cb3-f95c-46e2-80b7-913d525c6f7f"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7f6ebc0a-cf38-443c-8011-01dd83c173f2"), new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2472), new Guid("4ef75300-35bf-42c6-abe5-336d2ef35dcb"), true, false, 303, new Guid("20ea6585-a22e-4c38-ac32-05d933fa7b11"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a37d4708-0a18-4acf-9091-d8d1e479c363"), new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2608), new Guid("7aba79bd-e6b2-41f7-a3d7-a6f85ff28c64"), true, false, 103, new Guid("c4b2acb3-d9c4-4b52-8a13-e99edcb57810"), "Occupied", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b398eda2-90f3-4896-8c96-a008b23230f2"), new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2605), new Guid("7aba79bd-e6b2-41f7-a3d7-a6f85ff28c64"), true, false, 101, new Guid("5ec9600f-1905-41e8-a4e7-38c01388e3ba"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CreatedTime", "DateOfBirth", "Email", "FirstName", "HireDate", "HotelId", "IsActive", "IsDeleted", "LastName", "Phone", "Position", "Salary", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("74a56b44-8777-4847-a658-5559ebb3d131"), new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2427), new DateOnly(1982, 3, 10), "selin.demir@example.com", "Selin", new DateOnly(2018, 4, 1), new Guid("4ef75300-35bf-42c6-abe5-336d2ef35dcb"), true, false, "Demir", "09876543211", "Chef", 40000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c8978a3-f817-4463-a447-1de0e3b1245f"), new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2415), new DateOnly(1985, 5, 15), "emre.yilmaz@example.com", "Emre", new DateOnly(2015, 6, 1), new Guid("045ffc63-66ce-4c80-9810-87d7a393677f"), true, false, "Yılmaz", "01234567891", "Receptionist", 30000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CheckinDate", "CheckoutDate", "CreatedTime", "IsActive", "IsDeleted", "RoomId", "TotalPrice", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("234bfb32-8b1e-42e4-bafc-7e0d310d009e"), new DateOnly(2024, 9, 20), new DateOnly(2024, 9, 25), new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2511), true, false, new Guid("5e6bb513-651e-4081-a4c2-99fde106565d"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4ffbfa1a-4628-4955-b0cf-1a1ec6918b7e"), new DateOnly(2024, 10, 1), new DateOnly(2024, 10, 5), new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2555), true, false, new Guid("7f6ebc0a-cf38-443c-8011-01dd83c173f2"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("68908bb0-ff6b-456a-aaab-669f023be384"), new DateOnly(2024, 10, 15), new DateOnly(2024, 10, 20), new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2646), true, false, new Guid("1941dd5d-2313-4498-b9f4-9ac303648da1"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6fc6022c-9162-4fd8-99d7-0dded4789219"), new DateOnly(2024, 10, 5), new DateOnly(2024, 10, 10), new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2632), true, false, new Guid("b398eda2-90f3-4896-8c96-a008b23230f2"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("76fb6102-fdc8-4bf6-8582-90135dde6ee7"), new DateOnly(2024, 9, 10), new DateOnly(2024, 9, 15), new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2508), true, false, new Guid("1d7f4ed8-75c0-45ec-b5de-9ca849733e7f"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb4a1d63-6970-41d4-a5f1-fb38862d6133"), new DateOnly(2024, 9, 15), new DateOnly(2024, 9, 18), new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2554), true, false, new Guid("4f11eb3c-48e3-4886-8595-3800b2071a68"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f60de4d0-d5e7-42d1-ae81-c6e5d06f7d9d"), new DateOnly(2024, 9, 5), new DateOnly(2024, 9, 10), new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2553), true, false, new Guid("282a28e2-15b7-411e-9403-3f64e607815d"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "BRBookingGuests",
                columns: new[] { "BookingId", "GuestId", "CreatedTime", "IsActive", "IsDeleted", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("234bfb32-8b1e-42e4-bafc-7e0d310d009e"), new Guid("d1677225-1aa5-484a-849d-f26956279522"), new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2525), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4ffbfa1a-4628-4955-b0cf-1a1ec6918b7e"), new Guid("15be594c-966d-4d3c-8cdd-185a2c16a23b"), new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2569), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("68908bb0-ff6b-456a-aaab-669f023be384"), new Guid("8d784768-9c34-4bda-a2bc-2b522085fa04"), new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2660), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6fc6022c-9162-4fd8-99d7-0dded4789219"), new Guid("26f1e987-dec2-41e6-aa5f-c1c570504578"), new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2659), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("76fb6102-fdc8-4bf6-8582-90135dde6ee7"), new Guid("934bb9eb-5d42-486b-824e-f8d4bcd2d742"), new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2523), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb4a1d63-6970-41d4-a5f1-fb38862d6133"), new Guid("a962a452-934a-4cfd-a678-c1a12c23758c"), new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2568), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f60de4d0-d5e7-42d1-ae81-c6e5d06f7d9d"), new Guid("6a23c468-7a24-4cff-9330-f09efa97aeab"), new DateTime(2024, 7, 26, 11, 1, 56, 232, DateTimeKind.Local).AddTicks(2567), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("234bfb32-8b1e-42e4-bafc-7e0d310d009e"), new Guid("d1677225-1aa5-484a-849d-f26956279522") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("4ffbfa1a-4628-4955-b0cf-1a1ec6918b7e"), new Guid("15be594c-966d-4d3c-8cdd-185a2c16a23b") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("68908bb0-ff6b-456a-aaab-669f023be384"), new Guid("8d784768-9c34-4bda-a2bc-2b522085fa04") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("6fc6022c-9162-4fd8-99d7-0dded4789219"), new Guid("26f1e987-dec2-41e6-aa5f-c1c570504578") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("76fb6102-fdc8-4bf6-8582-90135dde6ee7"), new Guid("934bb9eb-5d42-486b-824e-f8d4bcd2d742") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("cb4a1d63-6970-41d4-a5f1-fb38862d6133"), new Guid("a962a452-934a-4cfd-a678-c1a12c23758c") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("f60de4d0-d5e7-42d1-ae81-c6e5d06f7d9d"), new Guid("6a23c468-7a24-4cff-9330-f09efa97aeab") });

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a37d4708-0a18-4acf-9091-d8d1e479c363"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("74a56b44-8777-4847-a658-5559ebb3d131"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("8c8978a3-f817-4463-a447-1de0e3b1245f"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("234bfb32-8b1e-42e4-bafc-7e0d310d009e"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("4ffbfa1a-4628-4955-b0cf-1a1ec6918b7e"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("68908bb0-ff6b-456a-aaab-669f023be384"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("6fc6022c-9162-4fd8-99d7-0dded4789219"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("76fb6102-fdc8-4bf6-8582-90135dde6ee7"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("cb4a1d63-6970-41d4-a5f1-fb38862d6133"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("f60de4d0-d5e7-42d1-ae81-c6e5d06f7d9d"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("15be594c-966d-4d3c-8cdd-185a2c16a23b"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("26f1e987-dec2-41e6-aa5f-c1c570504578"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("6a23c468-7a24-4cff-9330-f09efa97aeab"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("8d784768-9c34-4bda-a2bc-2b522085fa04"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("934bb9eb-5d42-486b-824e-f8d4bcd2d742"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("a962a452-934a-4cfd-a678-c1a12c23758c"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("d1677225-1aa5-484a-849d-f26956279522"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("1941dd5d-2313-4498-b9f4-9ac303648da1"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("1d7f4ed8-75c0-45ec-b5de-9ca849733e7f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("282a28e2-15b7-411e-9403-3f64e607815d"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("4f11eb3c-48e3-4886-8595-3800b2071a68"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("5e6bb513-651e-4081-a4c2-99fde106565d"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("7f6ebc0a-cf38-443c-8011-01dd83c173f2"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b398eda2-90f3-4896-8c96-a008b23230f2"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("045ffc63-66ce-4c80-9810-87d7a393677f"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("4ef75300-35bf-42c6-abe5-336d2ef35dcb"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("7aba79bd-e6b2-41f7-a3d7-a6f85ff28c64"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("1db1fdd6-213f-4bf0-a1b0-ac49ccc2941f"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("20ea6585-a22e-4c38-ac32-05d933fa7b11"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("5ec9600f-1905-41e8-a4e7-38c01388e3ba"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("97a95cb3-f95c-46e2-80b7-913d525c6f7f"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("c4b2acb3-d9c4-4b52-8a13-e99edcb57810"));

            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "Id", "Address", "CreatedTime", "DateOfBirth", "Email", "FirstName", "IdentityNumber", "IsActive", "IsDeleted", "LastName", "Phone", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("02e8c85c-da54-4074-a1e1-473c2c38b8cc"), "İzmir Alsancak", new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5155), new DateOnly(1995, 7, 15), "elif.sonmez@example.com", "Elif", "54321098765", true, false, "Sönmez", "07778889900", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("103153ef-548a-4b0e-8181-bea256481a84"), "İstanbul Kadıköy", new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5153), new DateOnly(1986, 2, 20), "ege.kurt@example.com", "Ege", "67890123456", true, false, "Kurt", "05556667788", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("48f2e42c-dcf8-41f5-b120-82556a80b57b"), "Bursa Nilüfer", new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5068), new DateOnly(1985, 4, 12), "burak.ozdemir@example.com", "Burak", "12345678902", true, false, "Özdemir", "01234567893", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4f42ba1f-2b1a-4032-8e3b-56101b5faf39"), "Ankara Çankaya", new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5019), new DateOnly(1990, 6, 30), "mehmet.kara@example.com", "Mehmet", "12345678901", true, false, "Kara", "01234567892", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9cb7c7be-ae79-4a8c-aebc-d87289700ed9"), "Antalya Konyaaltı", new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5070), new DateOnly(1992, 8, 22), "zeynep.aydin@example.com", "Zeynep", "10987654322", true, false, "Aydın", "09876543213", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b1748721-3387-4831-8900-f992482099fd"), "İzmir Karşıyaka", new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5024), new DateOnly(1988, 12, 25), "ayse.yilmaz@example.com", "Ayşe", "10987654321", true, false, "Yılmaz", "09876543212", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ba889f71-5a25-4f90-9856-ab6bfc66cea3"), "İstanbul Şişli", new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5073), new DateOnly(1980, 11, 10), "can.yurt@example.com", "Can", "45678912301", true, false, "Yurt", "05678912345", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CheckinTime", "CheckoutTime", "CreatedTime", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("1b80125c-a94d-4c36-aaac-9974b35b2313"), "Ankara Çankaya", new TimeOnly(14, 0, 0), new TimeOnly(12, 0, 0), new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5113), "radissonblu@example.com", true, false, "Radisson Blu", "02223334455", (byte)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b46fb2c-96f7-4d8f-9ff5-455fb38c358c"), "Antalya/Belek", new TimeOnly(14, 0, 0), new TimeOnly(12, 0, 0), new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(4872), "hiltonhotel@example.com", true, false, "Hilton", "01234567890", (byte)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a682ebfe-a0eb-4aa1-b2b1-e9561afdf2bd"), "Bodrum/Yalıkavak", new TimeOnly(15, 0, 0), new TimeOnly(11, 0, 0), new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(4888), "marriotthotel@example.com", true, false, "Marriott", "09876543210", (byte)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Capacity", "CreatedTime", "Description", "IsActive", "IsDeleted", "Name", "PricePerNight", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("16a6f3b6-84a3-4565-9ade-1d1ce091ae99"), (byte)3, new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(4973), "Deluxe room with sea view", true, false, "Deluxe", 2000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("34c07445-759a-45ef-8464-bf4ddf6a6201"), (byte)3, new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5126), "Spacious Junior Suite with extra amenities", true, false, "Junior S.", 2500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4b22ae83-834a-4700-a009-0ea689f36419"), (byte)2, new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(4976), "Executive room with additional amenities", true, false, "Executive", 3500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("82757736-fd93-4aa6-ae1d-17d590766d86"), (byte)1, new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(4977), "Standard room", true, false, "Standard", 700m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a37ac234-16c0-4e3b-a350-e2166de6e7b5"), (byte)4, new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5125), "Luxurious Presidential Suite", true, false, "Presidential", 5000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedTime", "HotelId", "IsActive", "IsDeleted", "RoomNumber", "RoomTypeId", "Status", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("0eafeef7-4c8c-4929-a3fa-cc09d816bc0f"), new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5140), new Guid("1b80125c-a94d-4c36-aaac-9974b35b2313"), true, false, 103, new Guid("34c07445-759a-45ef-8464-bf4ddf6a6201"), "Occupied", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("208b24af-fd91-4c2d-9dc0-426f049d1923"), new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(4993), new Guid("8b46fb2c-96f7-4d8f-9ff5-455fb38c358c"), true, false, 201, new Guid("16a6f3b6-84a3-4565-9ade-1d1ce091ae99"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("266d4ba4-1d78-47d0-a683-4d92483e08ce"), new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(4997), new Guid("a682ebfe-a0eb-4aa1-b2b1-e9561afdf2bd"), true, false, 301, new Guid("82757736-fd93-4aa6-ae1d-17d590766d86"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6b93575f-56a5-40f7-8c08-9fe75341573c"), new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5000), new Guid("a682ebfe-a0eb-4aa1-b2b1-e9561afdf2bd"), true, false, 303, new Guid("4b22ae83-834a-4700-a009-0ea689f36419"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8a8e6a2a-b1ee-4ed3-9cd4-ba0862c61551"), new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5139), new Guid("1b80125c-a94d-4c36-aaac-9974b35b2313"), true, false, 102, new Guid("34c07445-759a-45ef-8464-bf4ddf6a6201"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("93356ce6-81f4-4cde-a15e-79a640a27492"), new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5138), new Guid("1b80125c-a94d-4c36-aaac-9974b35b2313"), true, false, 101, new Guid("a37ac234-16c0-4e3b-a350-e2166de6e7b5"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a9be0c84-7700-4e25-a443-2d9fe9a68ad6"), new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(4995), new Guid("8b46fb2c-96f7-4d8f-9ff5-455fb38c358c"), true, false, 202, new Guid("4b22ae83-834a-4700-a009-0ea689f36419"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d681e8d3-29ac-4247-a88c-7410629f8596"), new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(4998), new Guid("a682ebfe-a0eb-4aa1-b2b1-e9561afdf2bd"), true, false, 302, new Guid("16a6f3b6-84a3-4565-9ade-1d1ce091ae99"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CreatedTime", "DateOfBirth", "Email", "FirstName", "HireDate", "HotelId", "IsActive", "IsDeleted", "LastName", "Phone", "Position", "Salary", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("416e2bc4-cdef-4e18-91a9-8ab8ee8107b3"), new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(4957), new DateOnly(1982, 3, 10), "selin.demir@example.com", "Selin", new DateOnly(2018, 4, 1), new Guid("a682ebfe-a0eb-4aa1-b2b1-e9561afdf2bd"), true, false, "Demir", "09876543211", "Chef", 40000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d4038f75-8fd9-48b6-97d1-438295968971"), new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(4940), new DateOnly(1985, 5, 15), "emre.yilmaz@example.com", "Emre", new DateOnly(2015, 6, 1), new Guid("8b46fb2c-96f7-4d8f-9ff5-455fb38c358c"), true, false, "Yılmaz", "01234567891", "Receptionist", 30000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CheckinDate", "CheckoutDate", "CreatedTime", "IsActive", "IsDeleted", "RoomId", "TotalPrice", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("38d95d98-443d-409d-992c-4e1eade9b812"), new DateOnly(2024, 9, 15), new DateOnly(2024, 9, 18), new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5086), true, false, new Guid("d681e8d3-29ac-4247-a88c-7410629f8596"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("43d97cf9-5dfa-4c92-97ad-5307409ed7b8"), new DateOnly(2024, 10, 5), new DateOnly(2024, 10, 10), new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5166), true, false, new Guid("93356ce6-81f4-4cde-a15e-79a640a27492"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4e1c7cef-4630-43ab-b4bb-3c101176e4f5"), new DateOnly(2024, 9, 20), new DateOnly(2024, 9, 25), new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5042), true, false, new Guid("266d4ba4-1d78-47d0-a683-4d92483e08ce"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b625fef-809b-4e66-8ece-a0d09e4eff7f"), new DateOnly(2024, 10, 15), new DateOnly(2024, 10, 20), new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5167), true, false, new Guid("8a8e6a2a-b1ee-4ed3-9cd4-ba0862c61551"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9c4b6924-f4d0-40bc-872d-9bfb8242eb55"), new DateOnly(2024, 9, 10), new DateOnly(2024, 9, 15), new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5038), true, false, new Guid("208b24af-fd91-4c2d-9dc0-426f049d1923"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aecd7393-96a3-4d33-84c7-08f6177c5e00"), new DateOnly(2024, 9, 5), new DateOnly(2024, 9, 10), new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5085), true, false, new Guid("a9be0c84-7700-4e25-a443-2d9fe9a68ad6"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cd6654e7-e51c-434a-8dfd-9857feae9063"), new DateOnly(2024, 10, 1), new DateOnly(2024, 10, 5), new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5088), true, false, new Guid("6b93575f-56a5-40f7-8c08-9fe75341573c"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "BRBookingGuests",
                columns: new[] { "BookingId", "GuestId", "CreatedTime", "IsActive", "IsDeleted", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("38d95d98-443d-409d-992c-4e1eade9b812"), new Guid("9cb7c7be-ae79-4a8c-aebc-d87289700ed9"), new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5102), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("43d97cf9-5dfa-4c92-97ad-5307409ed7b8"), new Guid("103153ef-548a-4b0e-8181-bea256481a84"), new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5192), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4e1c7cef-4630-43ab-b4bb-3c101176e4f5"), new Guid("b1748721-3387-4831-8900-f992482099fd"), new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5056), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b625fef-809b-4e66-8ece-a0d09e4eff7f"), new Guid("02e8c85c-da54-4074-a1e1-473c2c38b8cc"), new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5193), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9c4b6924-f4d0-40bc-872d-9bfb8242eb55"), new Guid("4f42ba1f-2b1a-4032-8e3b-56101b5faf39"), new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5055), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aecd7393-96a3-4d33-84c7-08f6177c5e00"), new Guid("48f2e42c-dcf8-41f5-b120-82556a80b57b"), new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5099), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cd6654e7-e51c-434a-8dfd-9857feae9063"), new Guid("ba889f71-5a25-4f90-9856-ab6bfc66cea3"), new DateTime(2024, 7, 26, 11, 1, 0, 995, DateTimeKind.Local).AddTicks(5103), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
