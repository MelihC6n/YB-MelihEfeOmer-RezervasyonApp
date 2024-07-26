using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YB_MelihEfeOmer_RezervasyonApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newDataSetted5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
