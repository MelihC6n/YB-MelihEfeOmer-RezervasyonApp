using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YB_MelihEfeOmer_RezervasyonApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class dataAddingFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("04128377-6194-487d-9f23-83c41f1e3b09"), new Guid("3ed2c82d-5090-4358-8692-17d3f525adcb") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("04128377-6194-487d-9f23-83c41f1e3b09"), new Guid("98e0c313-607b-4821-a372-c89749e0767c") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("04128377-6194-487d-9f23-83c41f1e3b09"), new Guid("dafdf0dd-2e70-41b7-9f04-7df40fb1ca63") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("0990a4f9-c889-4869-91d4-d1a877f7bdec"), new Guid("3ed2c82d-5090-4358-8692-17d3f525adcb") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("0990a4f9-c889-4869-91d4-d1a877f7bdec"), new Guid("599afa1b-7344-411f-af5d-64629d57881e") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("6171fb42-0bbe-42ca-a1aa-c68c5cb1702c"), new Guid("683fc9b9-3720-48ed-b099-dde2adc3642f") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("b3164b86-7d06-4d61-8b96-bd5d64678b0f"), new Guid("2645fc2a-aef1-4ba5-b255-14d173d9a2fc") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("b3164b86-7d06-4d61-8b96-bd5d64678b0f"), new Guid("4c6dc875-c3d4-4465-b330-e6d12f397a0a") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("b3164b86-7d06-4d61-8b96-bd5d64678b0f"), new Guid("6253468b-cb86-4b62-8af3-58fe1bd3b41b") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("b3164b86-7d06-4d61-8b96-bd5d64678b0f"), new Guid("8e927139-f5c7-4452-9773-68373c1782fa") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("b3164b86-7d06-4d61-8b96-bd5d64678b0f"), new Guid("dafdf0dd-2e70-41b7-9f04-7df40fb1ca63") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("c162c01f-1f9f-4217-b8a1-471c89eabacb"), new Guid("4c6dc875-c3d4-4465-b330-e6d12f397a0a") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("c162c01f-1f9f-4217-b8a1-471c89eabacb"), new Guid("8e927139-f5c7-4452-9773-68373c1782fa") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("c162c01f-1f9f-4217-b8a1-471c89eabacb"), new Guid("a876fc73-5bc1-41e7-8260-b16000f5108f") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("c2812a82-964d-4316-921d-082021dbff2b"), new Guid("e4c6401f-c088-40c1-933f-a3fe5a44877d") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("ee1ae452-8622-407c-bd31-6ebf53017602"), new Guid("a4bc697e-4d84-427b-9fc4-6658dc109311") });

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("8d98bfb0-56dd-42cc-bc81-5dbbc5cee506"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("fbdf305b-a041-42fb-874f-69d743a0129f"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("04128377-6194-487d-9f23-83c41f1e3b09"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("0990a4f9-c889-4869-91d4-d1a877f7bdec"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("6171fb42-0bbe-42ca-a1aa-c68c5cb1702c"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("b3164b86-7d06-4d61-8b96-bd5d64678b0f"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("c162c01f-1f9f-4217-b8a1-471c89eabacb"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("c2812a82-964d-4316-921d-082021dbff2b"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("ee1ae452-8622-407c-bd31-6ebf53017602"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("2645fc2a-aef1-4ba5-b255-14d173d9a2fc"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("3ed2c82d-5090-4358-8692-17d3f525adcb"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("4c6dc875-c3d4-4465-b330-e6d12f397a0a"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("599afa1b-7344-411f-af5d-64629d57881e"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("6253468b-cb86-4b62-8af3-58fe1bd3b41b"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("683fc9b9-3720-48ed-b099-dde2adc3642f"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("8e927139-f5c7-4452-9773-68373c1782fa"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("98e0c313-607b-4821-a372-c89749e0767c"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("a4bc697e-4d84-427b-9fc4-6658dc109311"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("a876fc73-5bc1-41e7-8260-b16000f5108f"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("dafdf0dd-2e70-41b7-9f04-7df40fb1ca63"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("e4c6401f-c088-40c1-933f-a3fe5a44877d"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("07311b31-cd85-4ea9-ba98-cea1a3e20aad"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("5acb0baa-063d-4c45-8545-d9d50b548d56"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("7398466f-dc74-4809-a44a-fdafbffc9e75"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("7c2cbe0b-4e5d-4c38-8d85-69edc6c8cfb9"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("7f430e33-cdb0-4cf7-998f-ca7c23fc0f08"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("866465a1-e1fc-455e-8bff-fbb0fae04182"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("bc13bed4-0aa8-4047-9076-4d00e76e8dc7"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("26055b9f-4dea-4286-aeb9-a92ddb45b1bf"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("49312820-250b-4f73-b7e8-a74a45ff7aeb"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("78554b09-9daa-435b-adbb-45f0f092aec9"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("819e11f8-0f98-48ac-94cd-779705cfede3"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("83bc4a50-3a6c-4b78-b153-7d6574f6d793"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("8ce9c3e7-eb53-4039-9c68-936c0cb103d1"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("96d889c4-68e5-400d-a7a3-8780f95aef07"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("e71394f8-56fa-42dd-8efb-441227947720"));

            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "Id", "Address", "CreatedTime", "DateOfBirth", "Email", "FirstName", "IdentityNumber", "IsActive", "IsDeleted", "LastName", "Phone", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("07e89e34-3b8f-4b25-aa19-102d083d7187"), "Ankara Etimesgut", new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9491), new DateOnly(1994, 11, 12), "derya.kaya@example.com", "Derya", "56789012345", true, false, "Kaya", "03134567890", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("17fce284-3b95-4c98-a2dd-0f6e35dbe842"), "Konya Meram", new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9496), new DateOnly(1989, 7, 20), "mert.yilmaz@example.com", "Mert", "89012345678", true, false, "Yılmaz", "03325678901", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1e587ae7-13be-49c9-aa52-6a21f8778102"), "İzmir Bornova", new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9388), new DateOnly(1982, 4, 5), "ayse.yurt@example.com", "Ayşe", "76543210923", true, false, "Yurt", "02325252525", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("295e1506-5428-4fb9-8805-061aced2e2b0"), "Trabzon Akçaabat", new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9393), new DateOnly(1988, 2, 8), "huseyin.koc@example.com", "Hüseyin", "43210987656", true, false, "Koç", "04622987654", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("434f66a3-5133-4b74-9900-5de8f5f5dc79"), "İstanbul Beylikdüzü", new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9497), new DateOnly(1992, 10, 30), "seda.demirtas@example.com", "Seda", "90123456789", true, false, "Demirtaş", "02124567890", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4cb35a91-9175-4731-98c4-ace3a91f5643"), "Ankara Çankaya", new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9380), new DateOnly(1985, 5, 12), "ali.kara@example.com", "Ali", "98765432101", true, false, "Kara", "03121234567", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5c9ed631-1c4e-4d4b-9287-dbebffcc13c2"), "İzmir Karşıyaka", new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9493), new DateOnly(1987, 6, 25), "gokhan.aydin@example.com", "Gökhan", "67890123456", true, false, "Aydın", "02345678901", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6f52134a-3010-4e4e-abc2-a1957594a76c"), "Bursa Osmangazi", new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9494), new DateOnly(1995, 3, 8), "eylul.yalcin@example.com", "Eylül", "78901234567", true, false, "Yalçın", "02225678901", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("86806108-b61b-4ace-90a4-3022a65b4ed0"), "Bolu Merkez", new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9392), new DateOnly(1993, 6, 19), "zeynep.arslan@example.com", "Zeynep", "54321098745", true, false, "Arslan", "03782567891", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ac616ce8-f79f-499b-8538-90ae2245c480"), "Antalya Lara", new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9390), new DateOnly(1975, 11, 15), "mehmet.celik@example.com", "Mehmet", "65432109834", true, false, "Çelik", "02426262626", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ad2493d2-3fdc-44b0-a867-21d8592045b7"), "Kayseri Melikgazi", new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9395), new DateOnly(1997, 8, 30), "elif.guven@example.com", "Elif", "32109876567", true, false, "Güven", "03512345678", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b7123bd7-dcfd-480b-af66-8a0449e5091e"), "İstanbul Kadıköy", new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9386), new DateOnly(1990, 9, 23), "veli.yilmaz@example.com", "Veli", "87654321012", true, false, "Yılmaz", "02129876543", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CheckinTime", "CheckoutTime", "CreatedTime", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("39dd0a88-b29f-4a9a-905a-d8ad20f64e4f"), "Bolu/Yedigöller", new TimeOnly(13, 0, 0), new TimeOnly(10, 0, 0), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9244), "mountainlodge@example.com", true, false, "Mountain Lodge", "03782567890", (byte)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5723b7af-8968-4554-b471-0f36b63fb6a6"), "Antalya/Kaleiçi", new TimeOnly(15, 0, 0), new TimeOnly(11, 0, 0), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9241), "seasideresort@example.com", true, false, "Seaside Resort", "02428888888", (byte)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("72b94698-b471-4d94-9b22-b15013986051"), "İstanbul/Beşiktaş", new TimeOnly(14, 0, 0), new TimeOnly(12, 0, 0), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9228), "grandhorizon@example.com", true, false, "Grand Horizon", "02121234567", (byte)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Capacity", "CreatedTime", "Description", "IsActive", "IsDeleted", "Name", "PricePerNight", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("4b6cc5bd-8ae2-4bff-ab6f-36e2daa4f238"), (byte)4, new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9318), "Luxurious top-floor room with city view", true, false, "Royal S", 3500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("55d56d46-185c-48a3-afac-5861189df945"), (byte)3, new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9322), "Comfortable suite with additional space", true, false, "Standard", 2000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("875da4e9-144c-433a-b047-4acee9c0ab3f"), (byte)3, new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9321), "Suite with separate living and sleeping areas", true, false, "Executive", 2500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9ebbc780-28c1-473f-a78d-523831110fe6"), (byte)2, new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9314), "Spacious room with modern amenities", true, false, "Superior", 1500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ff4a57be-b09e-49fd-8a63-32cb98f48368"), (byte)1, new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9319), "Standard room with basic facilities", true, false, "Classic", 800m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedTime", "HotelId", "IsActive", "IsDeleted", "RoomNumber", "RoomTypeId", "Status", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("0a89147e-a714-47a6-b4ef-99e8820b9012"), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9355), new Guid("5723b7af-8968-4554-b471-0f36b63fb6a6"), true, false, 401, new Guid("55d56d46-185c-48a3-afac-5861189df945"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("580fc069-24ed-4d0f-b647-c4fd32e7a7ae"), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9350), new Guid("5723b7af-8968-4554-b471-0f36b63fb6a6"), true, false, 202, new Guid("875da4e9-144c-433a-b047-4acee9c0ab3f"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("78904955-2d0c-4f13-a060-22aa49215c42"), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9345), new Guid("72b94698-b471-4d94-9b22-b15013986051"), true, false, 101, new Guid("9ebbc780-28c1-473f-a78d-523831110fe6"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7f1f2582-013d-4437-b208-ea7414ad1cdb"), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9353), new Guid("39dd0a88-b29f-4a9a-905a-d8ad20f64e4f"), true, false, 303, new Guid("4b6cc5bd-8ae2-4bff-ab6f-36e2daa4f238"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("97948af0-e4da-43cd-9927-8f7556e7048c"), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9349), new Guid("5723b7af-8968-4554-b471-0f36b63fb6a6"), true, false, 201, new Guid("ff4a57be-b09e-49fd-8a63-32cb98f48368"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("af5b9506-e7cb-4a5c-87a5-6a932078c926"), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9347), new Guid("72b94698-b471-4d94-9b22-b15013986051"), true, false, 102, new Guid("4b6cc5bd-8ae2-4bff-ab6f-36e2daa4f238"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b2296c96-151c-455d-ac23-7371de6e3c68"), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9357), new Guid("5723b7af-8968-4554-b471-0f36b63fb6a6"), true, false, 402, new Guid("ff4a57be-b09e-49fd-8a63-32cb98f48368"), "Occupied", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fbe62d94-1d3f-4e18-a690-d996afa6aa75"), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9352), new Guid("39dd0a88-b29f-4a9a-905a-d8ad20f64e4f"), true, false, 302, new Guid("9ebbc780-28c1-473f-a78d-523831110fe6"), "Occupied", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fc520449-49a6-476a-bd47-fd59e32cdd4e"), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9351), new Guid("39dd0a88-b29f-4a9a-905a-d8ad20f64e4f"), true, false, 301, new Guid("55d56d46-185c-48a3-afac-5861189df945"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CheckinDate", "CheckoutDate", "CreatedTime", "IsActive", "IsDeleted", "RoomId", "TotalPrice", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("016672c1-6f7a-4673-b739-5805ce970d89"), new DateOnly(2024, 10, 5), new DateOnly(2024, 10, 10), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9436), true, false, new Guid("7f1f2582-013d-4437-b208-ea7414ad1cdb"), 25000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("088b1f41-b184-4ea5-aad5-c0031b4059bb"), new DateOnly(2024, 8, 10), new DateOnly(2024, 8, 15), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9427), true, false, new Guid("af5b9506-e7cb-4a5c-87a5-6a932078c926"), 17500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("13c1556d-411e-4a5f-8bea-fa15646dbbf1"), new DateOnly(2024, 9, 15), new DateOnly(2024, 9, 20), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9432), true, false, new Guid("580fc069-24ed-4d0f-b647-c4fd32e7a7ae"), 12500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("41bdb9ac-86cf-4d52-beb3-690f98ec123b"), new DateOnly(2024, 10, 15), new DateOnly(2024, 10, 20), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9438), true, false, new Guid("0a89147e-a714-47a6-b4ef-99e8820b9012"), 10000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4fb82c6d-fca5-4de7-9245-a3c348e2a219"), new DateOnly(2024, 9, 1), new DateOnly(2024, 9, 4), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9430), true, false, new Guid("97948af0-e4da-43cd-9927-8f7556e7048c"), 2400m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b0a4ccdb-c3ea-4267-b038-794f758d0efb"), new DateOnly(2024, 10, 1), new DateOnly(2024, 10, 8), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9434), true, false, new Guid("fc520449-49a6-476a-bd47-fd59e32cdd4e"), 14000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b88f4b65-c8da-46d5-b02e-156e2170a834"), new DateOnly(2024, 8, 1), new DateOnly(2024, 8, 7), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9415), true, false, new Guid("78904955-2d0c-4f13-a060-22aa49215c42"), 9000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "BRBookingGuests",
                columns: new[] { "BookingId", "GuestId", "CreatedTime", "IsActive", "IsDeleted", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("016672c1-6f7a-4673-b739-5805ce970d89"), new Guid("295e1506-5428-4fb9-8805-061aced2e2b0"), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9473), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("016672c1-6f7a-4673-b739-5805ce970d89"), new Guid("434f66a3-5133-4b74-9900-5de8f5f5dc79"), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9515), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("088b1f41-b184-4ea5-aad5-c0031b4059bb"), new Guid("07e89e34-3b8f-4b25-aa19-102d083d7187"), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9510), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("088b1f41-b184-4ea5-aad5-c0031b4059bb"), new Guid("5c9ed631-1c4e-4d4b-9287-dbebffcc13c2"), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9512), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("088b1f41-b184-4ea5-aad5-c0031b4059bb"), new Guid("6f52134a-3010-4e4e-abc2-a1957594a76c"), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9514), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("088b1f41-b184-4ea5-aad5-c0031b4059bb"), new Guid("b7123bd7-dcfd-480b-af66-8a0449e5091e"), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9468), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("13c1556d-411e-4a5f-8bea-fa15646dbbf1"), new Guid("07e89e34-3b8f-4b25-aa19-102d083d7187"), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9515), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("13c1556d-411e-4a5f-8bea-fa15646dbbf1"), new Guid("6f52134a-3010-4e4e-abc2-a1957594a76c"), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9516), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("13c1556d-411e-4a5f-8bea-fa15646dbbf1"), new Guid("ac616ce8-f79f-499b-8538-90ae2245c480"), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9472), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("41bdb9ac-86cf-4d52-beb3-690f98ec123b"), new Guid("434f66a3-5133-4b74-9900-5de8f5f5dc79"), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9518), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("41bdb9ac-86cf-4d52-beb3-690f98ec123b"), new Guid("5c9ed631-1c4e-4d4b-9287-dbebffcc13c2"), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9517), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("41bdb9ac-86cf-4d52-beb3-690f98ec123b"), new Guid("ad2493d2-3fdc-44b0-a867-21d8592045b7"), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9474), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4fb82c6d-fca5-4de7-9245-a3c348e2a219"), new Guid("1e587ae7-13be-49c9-aa52-6a21f8778102"), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9470), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b0a4ccdb-c3ea-4267-b038-794f758d0efb"), new Guid("86806108-b61b-4ace-90a4-3022a65b4ed0"), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9473), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b88f4b65-c8da-46d5-b02e-156e2170a834"), new Guid("4cb35a91-9175-4731-98c4-ace3a91f5643"), new DateTime(2024, 7, 26, 11, 26, 42, 624, DateTimeKind.Local).AddTicks(9467), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("016672c1-6f7a-4673-b739-5805ce970d89"), new Guid("295e1506-5428-4fb9-8805-061aced2e2b0") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("016672c1-6f7a-4673-b739-5805ce970d89"), new Guid("434f66a3-5133-4b74-9900-5de8f5f5dc79") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("088b1f41-b184-4ea5-aad5-c0031b4059bb"), new Guid("07e89e34-3b8f-4b25-aa19-102d083d7187") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("088b1f41-b184-4ea5-aad5-c0031b4059bb"), new Guid("5c9ed631-1c4e-4d4b-9287-dbebffcc13c2") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("088b1f41-b184-4ea5-aad5-c0031b4059bb"), new Guid("6f52134a-3010-4e4e-abc2-a1957594a76c") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("088b1f41-b184-4ea5-aad5-c0031b4059bb"), new Guid("b7123bd7-dcfd-480b-af66-8a0449e5091e") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("13c1556d-411e-4a5f-8bea-fa15646dbbf1"), new Guid("07e89e34-3b8f-4b25-aa19-102d083d7187") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("13c1556d-411e-4a5f-8bea-fa15646dbbf1"), new Guid("6f52134a-3010-4e4e-abc2-a1957594a76c") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("13c1556d-411e-4a5f-8bea-fa15646dbbf1"), new Guid("ac616ce8-f79f-499b-8538-90ae2245c480") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("41bdb9ac-86cf-4d52-beb3-690f98ec123b"), new Guid("434f66a3-5133-4b74-9900-5de8f5f5dc79") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("41bdb9ac-86cf-4d52-beb3-690f98ec123b"), new Guid("5c9ed631-1c4e-4d4b-9287-dbebffcc13c2") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("41bdb9ac-86cf-4d52-beb3-690f98ec123b"), new Guid("ad2493d2-3fdc-44b0-a867-21d8592045b7") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("4fb82c6d-fca5-4de7-9245-a3c348e2a219"), new Guid("1e587ae7-13be-49c9-aa52-6a21f8778102") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("b0a4ccdb-c3ea-4267-b038-794f758d0efb"), new Guid("86806108-b61b-4ace-90a4-3022a65b4ed0") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("b88f4b65-c8da-46d5-b02e-156e2170a834"), new Guid("4cb35a91-9175-4731-98c4-ace3a91f5643") });

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("17fce284-3b95-4c98-a2dd-0f6e35dbe842"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b2296c96-151c-455d-ac23-7371de6e3c68"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("fbe62d94-1d3f-4e18-a690-d996afa6aa75"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("016672c1-6f7a-4673-b739-5805ce970d89"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("088b1f41-b184-4ea5-aad5-c0031b4059bb"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("13c1556d-411e-4a5f-8bea-fa15646dbbf1"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("41bdb9ac-86cf-4d52-beb3-690f98ec123b"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("4fb82c6d-fca5-4de7-9245-a3c348e2a219"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("b0a4ccdb-c3ea-4267-b038-794f758d0efb"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("b88f4b65-c8da-46d5-b02e-156e2170a834"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("07e89e34-3b8f-4b25-aa19-102d083d7187"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("1e587ae7-13be-49c9-aa52-6a21f8778102"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("295e1506-5428-4fb9-8805-061aced2e2b0"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("434f66a3-5133-4b74-9900-5de8f5f5dc79"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("4cb35a91-9175-4731-98c4-ace3a91f5643"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("5c9ed631-1c4e-4d4b-9287-dbebffcc13c2"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("6f52134a-3010-4e4e-abc2-a1957594a76c"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("86806108-b61b-4ace-90a4-3022a65b4ed0"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("ac616ce8-f79f-499b-8538-90ae2245c480"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("ad2493d2-3fdc-44b0-a867-21d8592045b7"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("b7123bd7-dcfd-480b-af66-8a0449e5091e"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("0a89147e-a714-47a6-b4ef-99e8820b9012"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("580fc069-24ed-4d0f-b647-c4fd32e7a7ae"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("78904955-2d0c-4f13-a060-22aa49215c42"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("7f1f2582-013d-4437-b208-ea7414ad1cdb"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("97948af0-e4da-43cd-9927-8f7556e7048c"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("af5b9506-e7cb-4a5c-87a5-6a932078c926"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("fc520449-49a6-476a-bd47-fd59e32cdd4e"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("39dd0a88-b29f-4a9a-905a-d8ad20f64e4f"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("5723b7af-8968-4554-b471-0f36b63fb6a6"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("72b94698-b471-4d94-9b22-b15013986051"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("4b6cc5bd-8ae2-4bff-ab6f-36e2daa4f238"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("55d56d46-185c-48a3-afac-5861189df945"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("875da4e9-144c-433a-b047-4acee9c0ab3f"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("9ebbc780-28c1-473f-a78d-523831110fe6"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("ff4a57be-b09e-49fd-8a63-32cb98f48368"));

            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "Id", "Address", "CreatedTime", "DateOfBirth", "Email", "FirstName", "IdentityNumber", "IsActive", "IsDeleted", "LastName", "Phone", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("2645fc2a-aef1-4ba5-b255-14d173d9a2fc"), "Konya Meram", new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8957), new DateOnly(1989, 7, 20), "mert.yilmaz@example.com", "Mert", "89012345678", true, false, "Yılmaz", "03325678901", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3ed2c82d-5090-4358-8692-17d3f525adcb"), "İstanbul Beylikdüzü", new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8959), new DateOnly(1992, 10, 30), "seda.demirtas@example.com", "Seda", "90123456789", true, false, "Demirtaş", "02124567890", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4c6dc875-c3d4-4465-b330-e6d12f397a0a"), "Bursa Osmangazi", new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8955), new DateOnly(1995, 3, 8), "eylul.yalcin@example.com", "Eylül", "78901234567", true, false, "Yalçın", "02225678901", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("599afa1b-7344-411f-af5d-64629d57881e"), "Trabzon Akçaabat", new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8866), new DateOnly(1988, 2, 8), "huseyin.koc@example.com", "Hüseyin", "43210987656", true, false, "Koç", "04622987654", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6253468b-cb86-4b62-8af3-58fe1bd3b41b"), "İstanbul Kadıköy", new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8857), new DateOnly(1990, 9, 23), "veli.yilmaz@example.com", "Veli", "87654321012", true, false, "Yılmaz", "02129876543", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("683fc9b9-3720-48ed-b099-dde2adc3642f"), "İzmir Bornova", new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8861), new DateOnly(1982, 4, 5), "ayse.yurt@example.com", "Ayşe", "76543210923", true, false, "Yurt", "02325252525", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8e927139-f5c7-4452-9773-68373c1782fa"), "Ankara Etimesgut", new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8950), new DateOnly(1994, 11, 12), "derya.kaya@example.com", "Derya", "56789012345", true, false, "Kaya", "03134567890", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("98e0c313-607b-4821-a372-c89749e0767c"), "Kayseri Melikgazi", new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8868), new DateOnly(1997, 8, 30), "elif.guven@example.com", "Elif", "32109876567", true, false, "Güven", "03512345678", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a4bc697e-4d84-427b-9fc4-6658dc109311"), "Bolu Merkez", new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8864), new DateOnly(1993, 6, 19), "zeynep.arslan@example.com", "Zeynep", "54321098745", true, false, "Arslan", "03782567891", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a876fc73-5bc1-41e7-8260-b16000f5108f"), "Antalya Lara", new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8862), new DateOnly(1975, 11, 15), "mehmet.celik@example.com", "Mehmet", "65432109834", true, false, "Çelik", "02426262626", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dafdf0dd-2e70-41b7-9f04-7df40fb1ca63"), "İzmir Karşıyaka", new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8954), new DateOnly(1987, 6, 25), "gokhan.aydin@example.com", "Gökhan", "67890123456", true, false, "Aydın", "02345678901", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e4c6401f-c088-40c1-933f-a3fe5a44877d"), "Ankara Çankaya", new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8849), new DateOnly(1985, 5, 12), "ali.kara@example.com", "Ali", "98765432101", true, false, "Kara", "03121234567", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CheckinTime", "CheckoutTime", "CreatedTime", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("26055b9f-4dea-4286-aeb9-a92ddb45b1bf"), "İstanbul/Beşiktaş", new TimeOnly(14, 0, 0), new TimeOnly(12, 0, 0), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8689), "grandhorizon@example.com", true, false, "Grand Horizon", "02121234567", (byte)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("49312820-250b-4f73-b7e8-a74a45ff7aeb"), "Antalya/Kaleiçi", new TimeOnly(15, 0, 0), new TimeOnly(11, 0, 0), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8704), "seasideresort@example.com", true, false, "Seaside Resort", "02428888888", (byte)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("78554b09-9daa-435b-adbb-45f0f092aec9"), "Bolu/Yedigöller", new TimeOnly(13, 0, 0), new TimeOnly(10, 0, 0), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8706), "mountainlodge@example.com", true, false, "Mountain Lodge", "03782567890", (byte)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Capacity", "CreatedTime", "Description", "IsActive", "IsDeleted", "Name", "PricePerNight", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("819e11f8-0f98-48ac-94cd-779705cfede3"), (byte)1, new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8791), "Standard room with basic facilities", true, false, "Classic", 800m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("83bc4a50-3a6c-4b78-b153-7d6574f6d793"), (byte)3, new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8794), "Comfortable suite with additional space", true, false, "Standard", 2000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8ce9c3e7-eb53-4039-9c68-936c0cb103d1"), (byte)4, new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8790), "Luxurious top-floor room with city view", true, false, "Royal S", 3500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("96d889c4-68e5-400d-a7a3-8780f95aef07"), (byte)3, new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8793), "Suite with separate living and sleeping areas", true, false, "Executive", 2500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e71394f8-56fa-42dd-8efb-441227947720"), (byte)2, new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8783), "Spacious room with modern amenities", true, false, "Superior", 1500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedTime", "HotelId", "IsActive", "IsDeleted", "RoomNumber", "RoomTypeId", "Status", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("07311b31-cd85-4ea9-ba98-cea1a3e20aad"), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8823), new Guid("78554b09-9daa-435b-adbb-45f0f092aec9"), true, false, 301, new Guid("83bc4a50-3a6c-4b78-b153-7d6574f6d793"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5acb0baa-063d-4c45-8545-d9d50b548d56"), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8820), new Guid("49312820-250b-4f73-b7e8-a74a45ff7aeb"), true, false, 201, new Guid("819e11f8-0f98-48ac-94cd-779705cfede3"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7398466f-dc74-4809-a44a-fdafbffc9e75"), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8825), new Guid("78554b09-9daa-435b-adbb-45f0f092aec9"), true, false, 303, new Guid("8ce9c3e7-eb53-4039-9c68-936c0cb103d1"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7c2cbe0b-4e5d-4c38-8d85-69edc6c8cfb9"), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8821), new Guid("49312820-250b-4f73-b7e8-a74a45ff7aeb"), true, false, 202, new Guid("96d889c4-68e5-400d-a7a3-8780f95aef07"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7f430e33-cdb0-4cf7-998f-ca7c23fc0f08"), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8817), new Guid("26055b9f-4dea-4286-aeb9-a92ddb45b1bf"), true, false, 102, new Guid("8ce9c3e7-eb53-4039-9c68-936c0cb103d1"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("866465a1-e1fc-455e-8bff-fbb0fae04182"), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8826), new Guid("49312820-250b-4f73-b7e8-a74a45ff7aeb"), true, false, 401, new Guid("83bc4a50-3a6c-4b78-b153-7d6574f6d793"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8d98bfb0-56dd-42cc-bc81-5dbbc5cee506"), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8828), new Guid("49312820-250b-4f73-b7e8-a74a45ff7aeb"), true, false, 402, new Guid("819e11f8-0f98-48ac-94cd-779705cfede3"), "Occupied", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc13bed4-0aa8-4047-9076-4d00e76e8dc7"), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8814), new Guid("26055b9f-4dea-4286-aeb9-a92ddb45b1bf"), true, false, 101, new Guid("e71394f8-56fa-42dd-8efb-441227947720"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fbdf305b-a041-42fb-874f-69d743a0129f"), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8824), new Guid("78554b09-9daa-435b-adbb-45f0f092aec9"), true, false, 302, new Guid("e71394f8-56fa-42dd-8efb-441227947720"), "Occupied", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CheckinDate", "CheckoutDate", "CreatedTime", "IsActive", "IsDeleted", "RoomId", "TotalPrice", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("04128377-6194-487d-9f23-83c41f1e3b09"), new DateOnly(2024, 10, 15), new DateOnly(2024, 10, 20), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8912), true, false, new Guid("866465a1-e1fc-455e-8bff-fbb0fae04182"), 10000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0990a4f9-c889-4869-91d4-d1a877f7bdec"), new DateOnly(2024, 10, 5), new DateOnly(2024, 10, 10), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8910), true, false, new Guid("7398466f-dc74-4809-a44a-fdafbffc9e75"), 25000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6171fb42-0bbe-42ca-a1aa-c68c5cb1702c"), new DateOnly(2024, 9, 1), new DateOnly(2024, 9, 4), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8903), true, false, new Guid("5acb0baa-063d-4c45-8545-d9d50b548d56"), 2400m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b3164b86-7d06-4d61-8b96-bd5d64678b0f"), new DateOnly(2024, 8, 10), new DateOnly(2024, 8, 15), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8901), true, false, new Guid("7f430e33-cdb0-4cf7-998f-ca7c23fc0f08"), 17500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c162c01f-1f9f-4217-b8a1-471c89eabacb"), new DateOnly(2024, 9, 15), new DateOnly(2024, 9, 20), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8905), true, false, new Guid("7c2cbe0b-4e5d-4c38-8d85-69edc6c8cfb9"), 12500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c2812a82-964d-4316-921d-082021dbff2b"), new DateOnly(2024, 8, 1), new DateOnly(2024, 8, 7), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8887), true, false, new Guid("bc13bed4-0aa8-4047-9076-4d00e76e8dc7"), 9000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ee1ae452-8622-407c-bd31-6ebf53017602"), new DateOnly(2024, 10, 1), new DateOnly(2024, 10, 8), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8908), true, false, new Guid("07311b31-cd85-4ea9-ba98-cea1a3e20aad"), 14000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "BRBookingGuests",
                columns: new[] { "BookingId", "GuestId", "CreatedTime", "IsActive", "IsDeleted", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("04128377-6194-487d-9f23-83c41f1e3b09"), new Guid("3ed2c82d-5090-4358-8692-17d3f525adcb"), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(9001), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("04128377-6194-487d-9f23-83c41f1e3b09"), new Guid("98e0c313-607b-4821-a372-c89749e0767c"), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8935), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("04128377-6194-487d-9f23-83c41f1e3b09"), new Guid("dafdf0dd-2e70-41b7-9f04-7df40fb1ca63"), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(9000), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0990a4f9-c889-4869-91d4-d1a877f7bdec"), new Guid("3ed2c82d-5090-4358-8692-17d3f525adcb"), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8997), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0990a4f9-c889-4869-91d4-d1a877f7bdec"), new Guid("599afa1b-7344-411f-af5d-64629d57881e"), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8935), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6171fb42-0bbe-42ca-a1aa-c68c5cb1702c"), new Guid("683fc9b9-3720-48ed-b099-dde2adc3642f"), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8931), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b3164b86-7d06-4d61-8b96-bd5d64678b0f"), new Guid("2645fc2a-aef1-4ba5-b255-14d173d9a2fc"), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8995), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b3164b86-7d06-4d61-8b96-bd5d64678b0f"), new Guid("4c6dc875-c3d4-4465-b330-e6d12f397a0a"), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8994), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b3164b86-7d06-4d61-8b96-bd5d64678b0f"), new Guid("6253468b-cb86-4b62-8af3-58fe1bd3b41b"), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8930), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b3164b86-7d06-4d61-8b96-bd5d64678b0f"), new Guid("8e927139-f5c7-4452-9773-68373c1782fa"), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8992), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b3164b86-7d06-4d61-8b96-bd5d64678b0f"), new Guid("dafdf0dd-2e70-41b7-9f04-7df40fb1ca63"), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8993), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c162c01f-1f9f-4217-b8a1-471c89eabacb"), new Guid("4c6dc875-c3d4-4465-b330-e6d12f397a0a"), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8999), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c162c01f-1f9f-4217-b8a1-471c89eabacb"), new Guid("8e927139-f5c7-4452-9773-68373c1782fa"), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8998), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c162c01f-1f9f-4217-b8a1-471c89eabacb"), new Guid("a876fc73-5bc1-41e7-8260-b16000f5108f"), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8932), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c2812a82-964d-4316-921d-082021dbff2b"), new Guid("e4c6401f-c088-40c1-933f-a3fe5a44877d"), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8928), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ee1ae452-8622-407c-bd31-6ebf53017602"), new Guid("a4bc697e-4d84-427b-9fc4-6658dc109311"), new DateTime(2024, 7, 26, 11, 20, 48, 661, DateTimeKind.Local).AddTicks(8933), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
