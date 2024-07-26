using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YB_MelihEfeOmer_RezervasyonApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newDataSetted2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("29bbc89c-78de-41c3-9eb8-f9b5229c0e2c"), new Guid("bc067eba-e5c8-4801-83bc-f2cc33796360") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("4a13c025-8234-440c-9885-66e8ea795f38"), new Guid("cb201a57-e759-4ae1-abc7-800d95ba60d3") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("58094ce7-c2db-4ffe-836a-4f12c00a10af"), new Guid("72ac912b-58fa-4bd4-ab8e-51ab54a88fcb") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("61b6ed7c-5e1d-4c66-980d-e2bf55f60d35"), new Guid("0f405f0b-a999-42b2-8e66-898d1e9bcf72") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("7414bc74-4ea1-452e-8bbf-3afbd74d006a"), new Guid("643447f1-41e4-4108-960c-5a6238d8cdd4") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("9488f069-d113-4713-99ff-0ef16f3bbf24"), new Guid("02b317f3-5d36-4cb7-a9ec-4c54ea631a17") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuests",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("9ef23a72-f15b-46e8-bb19-6812e95d264c"), new Guid("e292e5b5-adc2-4801-8205-538872f66e50") });

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a5887466-ba0d-46ed-be31-f62e98ff936e"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("587d4462-92be-46ed-a32d-7bbc78bbabb6"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("6ecd27d0-b1ca-47a1-a513-ef67342e31c1"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("29bbc89c-78de-41c3-9eb8-f9b5229c0e2c"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("4a13c025-8234-440c-9885-66e8ea795f38"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("58094ce7-c2db-4ffe-836a-4f12c00a10af"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("61b6ed7c-5e1d-4c66-980d-e2bf55f60d35"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("7414bc74-4ea1-452e-8bbf-3afbd74d006a"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("9488f069-d113-4713-99ff-0ef16f3bbf24"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("9ef23a72-f15b-46e8-bb19-6812e95d264c"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("02b317f3-5d36-4cb7-a9ec-4c54ea631a17"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("0f405f0b-a999-42b2-8e66-898d1e9bcf72"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("643447f1-41e4-4108-960c-5a6238d8cdd4"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("72ac912b-58fa-4bd4-ab8e-51ab54a88fcb"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("bc067eba-e5c8-4801-83bc-f2cc33796360"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("cb201a57-e759-4ae1-abc7-800d95ba60d3"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("e292e5b5-adc2-4801-8205-538872f66e50"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("0487e1bf-ae68-4a98-a940-45d75f8f6ccf"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("098c20f4-59bd-497d-a29f-6c6c14e1a1ee"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("250c05fc-0810-4fe5-addf-c5d334c6fd7b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("62d1962b-b17d-4bb3-b1c6-c6af731f090b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b4fc3887-e80a-4bc3-808a-ed09f8ce9831"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("bb526eb4-02d9-4c4b-877c-0125d7af745b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("da461c7d-e8d1-4009-b1b8-d8156068d816"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("104276d2-de0a-42c9-a1f1-a7eb55cee642"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("2f84d742-03b0-4fc3-a0b7-34f27fcb38f1"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("cb8e20ad-be96-4754-9d2c-237124a40220"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("2ea73e95-e4a3-421b-bf1d-648e818f1c69"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("4978f098-8a3e-4c1a-a477-9064e69bd394"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("5e3f4479-05f1-4e4c-8a40-12435c1550b1"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("6816c7d7-0ded-49f6-b74d-e6b5d17ddbe3"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("f68fcf94-169d-4675-a790-24f0d9bd4a3f"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("02b317f3-5d36-4cb7-a9ec-4c54ea631a17"), "Antalya Konyaaltı", new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(7969), new DateOnly(1992, 8, 22), "zeynep.aydin@example.com", "Zeynep", "10987654322", true, false, "Aydın", "09876543213", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0f405f0b-a999-42b2-8e66-898d1e9bcf72"), "İstanbul Kadıköy", new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(8052), new DateOnly(1986, 2, 20), "ege.kurt@example.com", "Ege", "67890123456", true, false, "Kurt", "05556667788", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("643447f1-41e4-4108-960c-5a6238d8cdd4"), "İzmir Karşıyaka", new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(7895), new DateOnly(1988, 12, 25), "ayse.yilmaz@example.com", "Ayşe", "10987654321", true, false, "Yılmaz", "09876543212", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("72ac912b-58fa-4bd4-ab8e-51ab54a88fcb"), "Ankara Çankaya", new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(7890), new DateOnly(1990, 6, 30), "mehmet.kara@example.com", "Mehmet", "12345678901", true, false, "Kara", "01234567892", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc067eba-e5c8-4801-83bc-f2cc33796360"), "İzmir Alsancak", new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(8054), new DateOnly(1995, 7, 15), "elif.sonmez@example.com", "Elif", "54321098765", true, false, "Sönmez", "07778889900", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb201a57-e759-4ae1-abc7-800d95ba60d3"), "İstanbul Şişli", new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(7970), new DateOnly(1980, 11, 10), "can.yurt@example.com", "Can", "45678912301", true, false, "Yurt", "05678912345", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e292e5b5-adc2-4801-8205-538872f66e50"), "Bursa Nilüfer", new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(7967), new DateOnly(1985, 4, 12), "burak.ozdemir@example.com", "Burak", "12345678902", true, false, "Özdemir", "01234567893", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CheckinTime", "CheckoutTime", "CreatedTime", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("104276d2-de0a-42c9-a1f1-a7eb55cee642"), "Antalya/Belek", new TimeOnly(14, 0, 0), new TimeOnly(12, 0, 0), new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(7762), "hiltonhotel@example.com", true, false, "Hilton", "01234567890", (byte)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2f84d742-03b0-4fc3-a0b7-34f27fcb38f1"), "Ankara Çankaya", new TimeOnly(14, 0, 0), new TimeOnly(12, 0, 0), new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(8011), "radissonblu@example.com", true, false, "Radisson Blu", "02223334455", (byte)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb8e20ad-be96-4754-9d2c-237124a40220"), "Bodrum/Yalıkavak", new TimeOnly(15, 0, 0), new TimeOnly(11, 0, 0), new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(7779), "marriotthotel@example.com", true, false, "Marriott", "09876543210", (byte)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Capacity", "CreatedTime", "Description", "IsActive", "IsDeleted", "Name", "PricePerNight", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("2ea73e95-e4a3-421b-bf1d-648e818f1c69"), (byte)3, new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(8026), "Spacious Junior Suite with extra amenities", true, false, "Junior Suite", 2500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4978f098-8a3e-4c1a-a477-9064e69bd394"), (byte)4, new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(8025), "Luxurious Presidential Suite", true, false, "Presidential Suite", 5000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5e3f4479-05f1-4e4c-8a40-12435c1550b1"), (byte)3, new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(7843), "Deluxe room with sea view", true, false, "Deluxe", 2000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6816c7d7-0ded-49f6-b74d-e6b5d17ddbe3"), (byte)2, new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(7845), "Executive room with additional amenities", true, false, "Executive", 3500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f68fcf94-169d-4675-a790-24f0d9bd4a3f"), (byte)1, new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(7849), "Standard room", true, false, "Standard", 700m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedTime", "HotelId", "IsActive", "IsDeleted", "RoomNumber", "RoomTypeId", "Status", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("0487e1bf-ae68-4a98-a940-45d75f8f6ccf"), new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(7863), new Guid("104276d2-de0a-42c9-a1f1-a7eb55cee642"), true, false, 201, new Guid("5e3f4479-05f1-4e4c-8a40-12435c1550b1"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("098c20f4-59bd-497d-a29f-6c6c14e1a1ee"), new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(8038), new Guid("2f84d742-03b0-4fc3-a0b7-34f27fcb38f1"), true, false, 101, new Guid("4978f098-8a3e-4c1a-a477-9064e69bd394"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("250c05fc-0810-4fe5-addf-c5d334c6fd7b"), new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(7870), new Guid("cb8e20ad-be96-4754-9d2c-237124a40220"), true, false, 302, new Guid("5e3f4479-05f1-4e4c-8a40-12435c1550b1"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("62d1962b-b17d-4bb3-b1c6-c6af731f090b"), new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(7869), new Guid("cb8e20ad-be96-4754-9d2c-237124a40220"), true, false, 301, new Guid("f68fcf94-169d-4675-a790-24f0d9bd4a3f"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a5887466-ba0d-46ed-be31-f62e98ff936e"), new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(8041), new Guid("2f84d742-03b0-4fc3-a0b7-34f27fcb38f1"), true, false, 103, new Guid("2ea73e95-e4a3-421b-bf1d-648e818f1c69"), "Occupied", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b4fc3887-e80a-4bc3-808a-ed09f8ce9831"), new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(7872), new Guid("cb8e20ad-be96-4754-9d2c-237124a40220"), true, false, 303, new Guid("6816c7d7-0ded-49f6-b74d-e6b5d17ddbe3"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bb526eb4-02d9-4c4b-877c-0125d7af745b"), new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(8039), new Guid("2f84d742-03b0-4fc3-a0b7-34f27fcb38f1"), true, false, 102, new Guid("2ea73e95-e4a3-421b-bf1d-648e818f1c69"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("da461c7d-e8d1-4009-b1b8-d8156068d816"), new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(7866), new Guid("104276d2-de0a-42c9-a1f1-a7eb55cee642"), true, false, 202, new Guid("6816c7d7-0ded-49f6-b74d-e6b5d17ddbe3"), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CreatedTime", "DateOfBirth", "Email", "FirstName", "HireDate", "HotelId", "IsActive", "IsDeleted", "LastName", "Phone", "Position", "Salary", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("587d4462-92be-46ed-a32d-7bbc78bbabb6"), new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(7815), new DateOnly(1985, 5, 15), "emre.yilmaz@example.com", "Emre", new DateOnly(2015, 6, 1), new Guid("104276d2-de0a-42c9-a1f1-a7eb55cee642"), true, false, "Yılmaz", "01234567891", "Receptionist", 30000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6ecd27d0-b1ca-47a1-a513-ef67342e31c1"), new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(7826), new DateOnly(1982, 3, 10), "selin.demir@example.com", "Selin", new DateOnly(2018, 4, 1), new Guid("cb8e20ad-be96-4754-9d2c-237124a40220"), true, false, "Demir", "09876543211", "Chef", 40000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CheckinDate", "CheckoutDate", "CreatedTime", "IsActive", "IsDeleted", "RoomId", "TotalPrice", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("29bbc89c-78de-41c3-9eb8-f9b5229c0e2c"), new DateOnly(2024, 10, 15), new DateOnly(2024, 10, 20), new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(8066), true, false, new Guid("bb526eb4-02d9-4c4b-877c-0125d7af745b"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4a13c025-8234-440c-9885-66e8ea795f38"), new DateOnly(2024, 10, 1), new DateOnly(2024, 10, 5), new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(7987), true, false, new Guid("b4fc3887-e80a-4bc3-808a-ed09f8ce9831"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("58094ce7-c2db-4ffe-836a-4f12c00a10af"), new DateOnly(2024, 9, 10), new DateOnly(2024, 9, 15), new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(7910), true, false, new Guid("0487e1bf-ae68-4a98-a940-45d75f8f6ccf"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("61b6ed7c-5e1d-4c66-980d-e2bf55f60d35"), new DateOnly(2024, 10, 5), new DateOnly(2024, 10, 10), new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(8064), true, false, new Guid("098c20f4-59bd-497d-a29f-6c6c14e1a1ee"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7414bc74-4ea1-452e-8bbf-3afbd74d006a"), new DateOnly(2024, 9, 20), new DateOnly(2024, 9, 25), new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(7914), true, false, new Guid("62d1962b-b17d-4bb3-b1c6-c6af731f090b"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9488f069-d113-4713-99ff-0ef16f3bbf24"), new DateOnly(2024, 9, 15), new DateOnly(2024, 9, 18), new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(7984), true, false, new Guid("250c05fc-0810-4fe5-addf-c5d334c6fd7b"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9ef23a72-f15b-46e8-bb19-6812e95d264c"), new DateOnly(2024, 9, 5), new DateOnly(2024, 9, 10), new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(7983), true, false, new Guid("da461c7d-e8d1-4009-b1b8-d8156068d816"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "BRBookingGuests",
                columns: new[] { "BookingId", "GuestId", "CreatedTime", "IsActive", "IsDeleted", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("29bbc89c-78de-41c3-9eb8-f9b5229c0e2c"), new Guid("bc067eba-e5c8-4801-83bc-f2cc33796360"), new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(8078), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4a13c025-8234-440c-9885-66e8ea795f38"), new Guid("cb201a57-e759-4ae1-abc7-800d95ba60d3"), new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(8001), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("58094ce7-c2db-4ffe-836a-4f12c00a10af"), new Guid("72ac912b-58fa-4bd4-ab8e-51ab54a88fcb"), new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(7926), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("61b6ed7c-5e1d-4c66-980d-e2bf55f60d35"), new Guid("0f405f0b-a999-42b2-8e66-898d1e9bcf72"), new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(8077), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7414bc74-4ea1-452e-8bbf-3afbd74d006a"), new Guid("643447f1-41e4-4108-960c-5a6238d8cdd4"), new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(7953), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9488f069-d113-4713-99ff-0ef16f3bbf24"), new Guid("02b317f3-5d36-4cb7-a9ec-4c54ea631a17"), new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(8000), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9ef23a72-f15b-46e8-bb19-6812e95d264c"), new Guid("e292e5b5-adc2-4801-8205-538872f66e50"), new DateTime(2024, 7, 26, 10, 59, 34, 343, DateTimeKind.Local).AddTicks(7999), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
