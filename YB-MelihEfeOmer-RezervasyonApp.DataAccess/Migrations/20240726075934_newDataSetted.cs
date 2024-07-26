using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YB_MelihEfeOmer_RezervasyonApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newDataSetted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
