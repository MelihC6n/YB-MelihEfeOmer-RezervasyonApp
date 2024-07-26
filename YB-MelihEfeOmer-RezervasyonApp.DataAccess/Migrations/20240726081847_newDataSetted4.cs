using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YB_MelihEfeOmer_RezervasyonApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newDataSetted4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("12735335-a78b-4d9f-9b2f-5d374622b73a"), "Konya Meram", new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5590), new DateOnly(1989, 7, 20), "mert.yilmaz@example.com", "Mert", "89012345678", true, false, "Yılmaz", "03325678901", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("266c13e1-0715-42e0-b2ff-87408a3cfd40"), "İzmir Karşıyaka", new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5587), new DateOnly(1987, 6, 25), "gokhan.aydin@example.com", "Gökhan", "67890123456", true, false, "Aydın", "02345678901", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2c845461-aca4-44b2-a8a6-a2ad0cc04777"), "Ankara Çankaya", new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5462), new DateOnly(1985, 5, 12), "ali.kara@example.com", "Ali", "98765432101", true, false, "Kara", "03121234567", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4b81d1c1-1636-4b78-8b06-1b2726ef2814"), "Bolu Merkez", new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5476), new DateOnly(1993, 6, 19), "zeynep.arslan@example.com", "Zeynep", "54321098745", true, false, "Arslan", "03782567891", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("50559e11-8527-4db3-83e5-6eb2733fd481"), "İstanbul Beylikdüzü", new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5591), new DateOnly(1992, 10, 30), "seda.demirtas@example.com", "Seda", "90123456789", true, false, "Demirtaş", "02124567890", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("609fa045-92ab-4fc2-bd4d-9d010590cf1e"), "Ankara Etimesgut", new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5585), new DateOnly(1994, 11, 12), "derya.kaya@example.com", "Derya", "56789012345", true, false, "Kaya", "03134567890", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("63238c02-8f49-42fd-9a6c-63b07a0a2c3e"), "Antalya Lara", new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5474), new DateOnly(1975, 11, 15), "mehmet.celik@example.com", "Mehmet", "65432109834", true, false, "Çelik", "02426262626", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("914e95c7-59d7-4e60-94a7-822b16bf409b"), "Trabzon Akçaabat", new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5477), new DateOnly(1988, 2, 8), "huseyin.koc@example.com", "Hüseyin", "43210987656", true, false, "Koç", "04622987654", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("af3d13c1-9aeb-4fe6-9fa6-59d0ea34a281"), "Kayseri Melikgazi", new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5479), new DateOnly(1997, 8, 30), "elif.guven@example.com", "Elif", "32109876567", true, false, "Güven", "03512345678", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d72c3831-717a-44a9-9c81-daab97528618"), "Bursa Osmangazi", new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5588), new DateOnly(1995, 3, 8), "eylul.yalcin@example.com", "Eylül", "78901234567", true, false, "Yalçın", "02225678901", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dde1efdd-811e-48f8-89b4-815a7ec284bd"), "İstanbul Kadıköy", new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5471), new DateOnly(1990, 9, 23), "veli.yilmaz@example.com", "Veli", "87654321012", true, false, "Yılmaz", "02129876543", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eb46ab5c-6ba1-44bf-90b1-d4177d070771"), "İzmir Bornova", new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5473), new DateOnly(1982, 4, 5), "ayse.yurt@example.com", "Ayşe", "76543210923", true, false, "Yurt", "02325252525", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CheckinTime", "CheckoutTime", "CreatedTime", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("20c95b7a-ae09-43cd-bcbc-2539544a31ac"), "Bolu/Yedigöller", new TimeOnly(13, 0, 0), new TimeOnly(10, 0, 0), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5320), "mountainlodge@example.com", true, false, "Mountain Lodge", "03782567890", (byte)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ac1232b0-5e97-44c1-86d8-9f7fc8d705cd"), "İstanbul/Beşiktaş", new TimeOnly(14, 0, 0), new TimeOnly(12, 0, 0), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5301), "grandhorizon@example.com", true, false, "Grand Horizon", "02121234567", (byte)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e99209ed-bf91-4d6a-8216-f1442e793d59"), "Antalya/Kaleiçi", new TimeOnly(15, 0, 0), new TimeOnly(11, 0, 0), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5318), "seasideresort@example.com", true, false, "Seaside Resort", "02428888888", (byte)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Capacity", "CreatedTime", "Description", "IsActive", "IsDeleted", "Name", "PricePerNight", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("63cedc4d-0449-490d-908c-2c8d24efb129"), (byte)1, new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5399), "Standard room with basic facilities", true, false, "Classic", 800m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a582c99d-df8b-422f-aaf3-df064cd80092"), (byte)3, new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5402), "Comfortable suite with additional space", true, false, "Standard Suite", 2000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b6f443f2-c6ca-46e4-8a54-c7b3b4827ea8"), (byte)2, new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5392), "Spacious room with modern amenities", true, false, "Superior", 1500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e1484ce7-5f40-4d0f-b59d-1242521d0e52"), (byte)3, new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5400), "Suite with separate living and sleeping areas", true, false, "Executive Suite", 2500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fd88e90e-2eb7-4f37-89e3-9bf4d17da174"), (byte)4, new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5397), "Luxurious top-floor room with city view", true, false, "Penthouse", 3500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedTime", "HotelId", "IsActive", "IsDeleted", "RoomNumber", "RoomTypeId", "Status", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("012c9631-8c0a-4bba-bab3-b543f86a557b"), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5436), new Guid("20c95b7a-ae09-43cd-bcbc-2539544a31ac"), true, false, 303, new Guid("fd88e90e-2eb7-4f37-89e3-9bf4d17da174"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("09982455-dadd-48e3-a450-86dcae1a9635"), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5424), new Guid("ac1232b0-5e97-44c1-86d8-9f7fc8d705cd"), true, false, 101, new Guid("b6f443f2-c6ca-46e4-8a54-c7b3b4827ea8"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6921376a-a9b1-4665-995a-ac8dc43d404d"), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5430), new Guid("ac1232b0-5e97-44c1-86d8-9f7fc8d705cd"), true, false, 102, new Guid("fd88e90e-2eb7-4f37-89e3-9bf4d17da174"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("71b7ea8e-43c4-41f3-be97-b1330ae324a3"), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5432), new Guid("e99209ed-bf91-4d6a-8216-f1442e793d59"), true, false, 202, new Guid("e1484ce7-5f40-4d0f-b59d-1242521d0e52"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("72eb3075-4e1a-4568-a9ef-2baa57815b5d"), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5434), new Guid("20c95b7a-ae09-43cd-bcbc-2539544a31ac"), true, false, 301, new Guid("a582c99d-df8b-422f-aaf3-df064cd80092"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("90e7bf50-ec8f-4ba6-b0d7-a411801fa659"), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5438), new Guid("e99209ed-bf91-4d6a-8216-f1442e793d59"), true, false, 402, new Guid("63cedc4d-0449-490d-908c-2c8d24efb129"), "Occupied", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b79b6afe-d191-481b-bba9-71a180e7be43"), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5431), new Guid("e99209ed-bf91-4d6a-8216-f1442e793d59"), true, false, 201, new Guid("63cedc4d-0449-490d-908c-2c8d24efb129"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dcb1e0b9-5caa-47b8-96be-8faffe2bd419"), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5437), new Guid("e99209ed-bf91-4d6a-8216-f1442e793d59"), true, false, 401, new Guid("a582c99d-df8b-422f-aaf3-df064cd80092"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f759a038-3425-4f76-bb37-42f1b7047f8b"), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5435), new Guid("20c95b7a-ae09-43cd-bcbc-2539544a31ac"), true, false, 302, new Guid("b6f443f2-c6ca-46e4-8a54-c7b3b4827ea8"), "Occupied", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CheckinDate", "CheckoutDate", "CreatedTime", "IsActive", "IsDeleted", "RoomId", "TotalPrice", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("1cd83c31-de1f-419a-99ea-54d680363302"), new DateOnly(2024, 8, 10), new DateOnly(2024, 8, 15), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5514), true, false, new Guid("6921376a-a9b1-4665-995a-ac8dc43d404d"), 17500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("58cd8298-3cdf-41be-8492-ca8d764ca9b9"), new DateOnly(2024, 10, 15), new DateOnly(2024, 10, 20), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5525), true, false, new Guid("dcb1e0b9-5caa-47b8-96be-8faffe2bd419"), 10000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("688857a4-d44e-43a3-84f7-3b80028ce3a8"), new DateOnly(2024, 9, 15), new DateOnly(2024, 9, 20), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5519), true, false, new Guid("71b7ea8e-43c4-41f3-be97-b1330ae324a3"), 12500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6f05fac4-6ec6-4c0a-9130-13ba033e2407"), new DateOnly(2024, 8, 1), new DateOnly(2024, 8, 7), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5499), true, false, new Guid("09982455-dadd-48e3-a450-86dcae1a9635"), 9000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("771ffbe2-ff52-42e7-ac6c-a622a2151240"), new DateOnly(2024, 10, 1), new DateOnly(2024, 10, 8), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5521), true, false, new Guid("72eb3075-4e1a-4568-a9ef-2baa57815b5d"), 14000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8dbcfbf1-3bc5-4ed1-8942-c2278dd6ae6a"), new DateOnly(2024, 10, 5), new DateOnly(2024, 10, 10), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5523), true, false, new Guid("012c9631-8c0a-4bba-bab3-b543f86a557b"), 25000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cf8811eb-4d64-4626-ad6e-2626561ce044"), new DateOnly(2024, 9, 1), new DateOnly(2024, 9, 4), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5516), true, false, new Guid("b79b6afe-d191-481b-bba9-71a180e7be43"), 2400m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "BRBookingGuests",
                columns: new[] { "BookingId", "GuestId", "CreatedTime", "IsActive", "IsDeleted", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("1cd83c31-de1f-419a-99ea-54d680363302"), new Guid("12735335-a78b-4d9f-9b2f-5d374622b73a"), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5608), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1cd83c31-de1f-419a-99ea-54d680363302"), new Guid("266c13e1-0715-42e0-b2ff-87408a3cfd40"), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5605), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1cd83c31-de1f-419a-99ea-54d680363302"), new Guid("609fa045-92ab-4fc2-bd4d-9d010590cf1e"), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5604), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1cd83c31-de1f-419a-99ea-54d680363302"), new Guid("d72c3831-717a-44a9-9c81-daab97528618"), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5606), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1cd83c31-de1f-419a-99ea-54d680363302"), new Guid("dde1efdd-811e-48f8-89b4-815a7ec284bd"), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5562), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("58cd8298-3cdf-41be-8492-ca8d764ca9b9"), new Guid("266c13e1-0715-42e0-b2ff-87408a3cfd40"), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5611), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("58cd8298-3cdf-41be-8492-ca8d764ca9b9"), new Guid("50559e11-8527-4db3-83e5-6eb2733fd481"), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5612), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("58cd8298-3cdf-41be-8492-ca8d764ca9b9"), new Guid("af3d13c1-9aeb-4fe6-9fa6-59d0ea34a281"), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5568), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("688857a4-d44e-43a3-84f7-3b80028ce3a8"), new Guid("609fa045-92ab-4fc2-bd4d-9d010590cf1e"), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5610), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("688857a4-d44e-43a3-84f7-3b80028ce3a8"), new Guid("63238c02-8f49-42fd-9a6c-63b07a0a2c3e"), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5564), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("688857a4-d44e-43a3-84f7-3b80028ce3a8"), new Guid("d72c3831-717a-44a9-9c81-daab97528618"), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5610), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6f05fac4-6ec6-4c0a-9130-13ba033e2407"), new Guid("2c845461-aca4-44b2-a8a6-a2ad0cc04777"), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5560), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("771ffbe2-ff52-42e7-ac6c-a622a2151240"), new Guid("4b81d1c1-1636-4b78-8b06-1b2726ef2814"), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5566), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8dbcfbf1-3bc5-4ed1-8942-c2278dd6ae6a"), new Guid("50559e11-8527-4db3-83e5-6eb2733fd481"), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5609), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8dbcfbf1-3bc5-4ed1-8942-c2278dd6ae6a"), new Guid("914e95c7-59d7-4e60-94a7-822b16bf409b"), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5567), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cf8811eb-4d64-4626-ad6e-2626561ce044"), new Guid("eb46ab5c-6ba1-44bf-90b1-d4177d070771"), new DateTime(2024, 7, 26, 11, 18, 47, 278, DateTimeKind.Local).AddTicks(5563), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("1cd83c31-de1f-419a-99ea-54d680363302"), new Guid("12735335-a78b-4d9f-9b2f-5d374622b73a") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("1cd83c31-de1f-419a-99ea-54d680363302"), new Guid("266c13e1-0715-42e0-b2ff-87408a3cfd40") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("1cd83c31-de1f-419a-99ea-54d680363302"), new Guid("609fa045-92ab-4fc2-bd4d-9d010590cf1e") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("1cd83c31-de1f-419a-99ea-54d680363302"), new Guid("d72c3831-717a-44a9-9c81-daab97528618") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("1cd83c31-de1f-419a-99ea-54d680363302"), new Guid("dde1efdd-811e-48f8-89b4-815a7ec284bd") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("58cd8298-3cdf-41be-8492-ca8d764ca9b9"), new Guid("266c13e1-0715-42e0-b2ff-87408a3cfd40") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("58cd8298-3cdf-41be-8492-ca8d764ca9b9"), new Guid("50559e11-8527-4db3-83e5-6eb2733fd481") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("58cd8298-3cdf-41be-8492-ca8d764ca9b9"), new Guid("af3d13c1-9aeb-4fe6-9fa6-59d0ea34a281") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("688857a4-d44e-43a3-84f7-3b80028ce3a8"), new Guid("609fa045-92ab-4fc2-bd4d-9d010590cf1e") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("688857a4-d44e-43a3-84f7-3b80028ce3a8"), new Guid("63238c02-8f49-42fd-9a6c-63b07a0a2c3e") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("688857a4-d44e-43a3-84f7-3b80028ce3a8"), new Guid("d72c3831-717a-44a9-9c81-daab97528618") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("6f05fac4-6ec6-4c0a-9130-13ba033e2407"), new Guid("2c845461-aca4-44b2-a8a6-a2ad0cc04777") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("771ffbe2-ff52-42e7-ac6c-a622a2151240"), new Guid("4b81d1c1-1636-4b78-8b06-1b2726ef2814") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("8dbcfbf1-3bc5-4ed1-8942-c2278dd6ae6a"), new Guid("50559e11-8527-4db3-83e5-6eb2733fd481") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("8dbcfbf1-3bc5-4ed1-8942-c2278dd6ae6a"), new Guid("914e95c7-59d7-4e60-94a7-822b16bf409b") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("cf8811eb-4d64-4626-ad6e-2626561ce044"), new Guid("eb46ab5c-6ba1-44bf-90b1-d4177d070771") });

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("90e7bf50-ec8f-4ba6-b0d7-a411801fa659"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f759a038-3425-4f76-bb37-42f1b7047f8b"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("1cd83c31-de1f-419a-99ea-54d680363302"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("58cd8298-3cdf-41be-8492-ca8d764ca9b9"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("688857a4-d44e-43a3-84f7-3b80028ce3a8"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("6f05fac4-6ec6-4c0a-9130-13ba033e2407"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("771ffbe2-ff52-42e7-ac6c-a622a2151240"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("8dbcfbf1-3bc5-4ed1-8942-c2278dd6ae6a"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("cf8811eb-4d64-4626-ad6e-2626561ce044"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("12735335-a78b-4d9f-9b2f-5d374622b73a"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("266c13e1-0715-42e0-b2ff-87408a3cfd40"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("2c845461-aca4-44b2-a8a6-a2ad0cc04777"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("4b81d1c1-1636-4b78-8b06-1b2726ef2814"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("50559e11-8527-4db3-83e5-6eb2733fd481"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("609fa045-92ab-4fc2-bd4d-9d010590cf1e"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("63238c02-8f49-42fd-9a6c-63b07a0a2c3e"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("914e95c7-59d7-4e60-94a7-822b16bf409b"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("af3d13c1-9aeb-4fe6-9fa6-59d0ea34a281"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("d72c3831-717a-44a9-9c81-daab97528618"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("dde1efdd-811e-48f8-89b4-815a7ec284bd"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("eb46ab5c-6ba1-44bf-90b1-d4177d070771"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("012c9631-8c0a-4bba-bab3-b543f86a557b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("09982455-dadd-48e3-a450-86dcae1a9635"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("6921376a-a9b1-4665-995a-ac8dc43d404d"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("71b7ea8e-43c4-41f3-be97-b1330ae324a3"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("72eb3075-4e1a-4568-a9ef-2baa57815b5d"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b79b6afe-d191-481b-bba9-71a180e7be43"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("dcb1e0b9-5caa-47b8-96be-8faffe2bd419"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("20c95b7a-ae09-43cd-bcbc-2539544a31ac"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("ac1232b0-5e97-44c1-86d8-9f7fc8d705cd"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("e99209ed-bf91-4d6a-8216-f1442e793d59"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("63cedc4d-0449-490d-908c-2c8d24efb129"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("a582c99d-df8b-422f-aaf3-df064cd80092"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("b6f443f2-c6ca-46e4-8a54-c7b3b4827ea8"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("e1484ce7-5f40-4d0f-b59d-1242521d0e52"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("fd88e90e-2eb7-4f37-89e3-9bf4d17da174"));

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
    }
}
