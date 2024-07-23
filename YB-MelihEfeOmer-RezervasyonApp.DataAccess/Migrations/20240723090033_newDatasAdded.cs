using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YB_MelihEfeOmer_RezervasyonApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newDatasAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BRBookingGuest",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("f987e9ac-0119-4e79-965f-29082a7acf49"), new Guid("f09faf7a-8f71-4e87-8777-cc89057cddbc") });

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("9685765c-af41-44cf-9b8c-2cdbe38e1572"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("9b273348-a54b-4b4c-a39a-ab0d9aac0bad"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b82aac65-08b2-4c6d-9bbf-8c5b0577471b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c52efb0c-cb0e-445a-b3a8-990a13b6b76a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("da6de807-c136-4356-bbfb-1a08b8916cde"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("afebe0be-8793-4409-84a4-59a39360102a"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("fd34bb28-2bde-433c-87a8-894c8997423a"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("f987e9ac-0119-4e79-965f-29082a7acf49"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("f09faf7a-8f71-4e87-8777-cc89057cddbc"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("4b684e12-6673-4814-9d54-01cdbe6316db"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("5c8278c8-e67e-40e1-8eed-ae043b9dc2f4"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("ac5ee7c8-afbb-4ef9-891a-1130b984519b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("aadbf26e-985d-4b28-8ea9-84397e6604e9"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("b1316992-4e60-4f0f-986c-68d1f1043042"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("18e870ac-20f3-403f-b978-777e651faeaa"));

            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "Id", "Address", "CreatedTime", "DateOfBirth", "Email", "FirstName", "IdentityNumber", "IsActive", "IsDeleted", "LastName", "Phone", "UpdatedTime" },
                values: new object[] { new Guid("cb49eba7-c6d4-4668-af91-fafcaf0d481c"), "aa", new DateTime(2024, 7, 23, 12, 0, 33, 22, DateTimeKind.Local).AddTicks(421), new DateOnly(1999, 9, 9), "aaa", "Test", null, false, false, "Test", "5656", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CheckinTime", "CheckoutTime", "CreatedTime", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("a990f016-ec3b-4aa9-a98e-e08331691876"), "İstanbul/Eminönü", new TimeOnly(8, 0, 0), new TimeOnly(23, 59, 0), new DateTime(2024, 7, 23, 12, 0, 33, 22, DateTimeKind.Local).AddTicks(79), "turkuaz@hotmail.com", false, false, "Turkuaz", "55554443265", (byte)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e66d5f65-e52e-419f-bc7e-d195c11a97aa"), "İzmir/Alsancak", new TimeOnly(8, 0, 0), new TimeOnly(23, 59, 0), new DateTime(2024, 7, 23, 12, 0, 33, 22, DateTimeKind.Local).AddTicks(23), "ibishotel@hotmail.com", false, false, "İbis", "09998887766", (byte)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Capacity", "CreatedTime", "Description", "IsActive", "IsDeleted", "Name", "PricePerNight", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("23e13b86-0514-424b-b805-febf8d8ed0cb"), (byte)4, new DateTime(2024, 7, 23, 12, 0, 33, 22, DateTimeKind.Local).AddTicks(227), "King type room", false, false, "King", 4000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3afba231-d67d-4eeb-985f-0dd1b6bf5776"), (byte)2, new DateTime(2024, 7, 23, 12, 0, 33, 22, DateTimeKind.Local).AddTicks(191), "Suit type room", false, false, "Suit", 1000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("76edbb82-91f8-47d9-b738-66c8e7f0758c"), (byte)1, new DateTime(2024, 7, 23, 12, 0, 33, 22, DateTimeKind.Local).AddTicks(252), "Single type room", false, false, "Single", 500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedTime", "HotelId", "IsActive", "IsDeleted", "RoomNumber", "RoomTypeId", "Status", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("00ccbe8e-9f9b-4ddd-886a-fd429be9ab7d"), new DateTime(2024, 7, 23, 12, 0, 33, 22, DateTimeKind.Local).AddTicks(331), new Guid("e66d5f65-e52e-419f-bc7e-d195c11a97aa"), false, false, 201, new Guid("23e13b86-0514-424b-b805-febf8d8ed0cb"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0c78e094-4873-4d73-9541-9462f9337f68"), new DateTime(2024, 7, 23, 12, 0, 33, 22, DateTimeKind.Local).AddTicks(356), new Guid("e66d5f65-e52e-419f-bc7e-d195c11a97aa"), false, false, 202, new Guid("76edbb82-91f8-47d9-b738-66c8e7f0758c"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3a43d430-9439-4281-88dd-d9a5679df58c"), new DateTime(2024, 7, 23, 12, 0, 33, 22, DateTimeKind.Local).AddTicks(401), new Guid("a990f016-ec3b-4aa9-a98e-e08331691876"), false, false, 102, new Guid("76edbb82-91f8-47d9-b738-66c8e7f0758c"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("78fc7744-4908-4410-bea2-cf5552334768"), new DateTime(2024, 7, 23, 12, 0, 33, 22, DateTimeKind.Local).AddTicks(377), new Guid("a990f016-ec3b-4aa9-a98e-e08331691876"), false, false, 101, new Guid("76edbb82-91f8-47d9-b738-66c8e7f0758c"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a935b41a-bdbc-49e5-bd13-d80256733795"), new DateTime(2024, 7, 23, 12, 0, 33, 22, DateTimeKind.Local).AddTicks(283), new Guid("e66d5f65-e52e-419f-bc7e-d195c11a97aa"), false, false, 101, new Guid("3afba231-d67d-4eeb-985f-0dd1b6bf5776"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c8866c93-763c-4d84-b3f0-5b5bc99a7a1b"), new DateTime(2024, 7, 23, 12, 0, 33, 22, DateTimeKind.Local).AddTicks(310), new Guid("e66d5f65-e52e-419f-bc7e-d195c11a97aa"), false, false, 102, new Guid("3afba231-d67d-4eeb-985f-0dd1b6bf5776"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CreatedTime", "DateOfBirth", "Email", "FirstName", "HireDate", "HotelId", "IsActive", "IsDeleted", "LastName", "Phone", "Position", "Salary", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("50cdf700-fcfe-4f36-be68-33dca656b065"), new DateTime(2024, 7, 23, 12, 0, 33, 22, DateTimeKind.Local).AddTicks(163), new DateOnly(1980, 1, 1), "ThisIsStaff2@hotmail.com", "Murat", new DateOnly(1981, 1, 1), new Guid("a990f016-ec3b-4aa9-a98e-e08331691876"), false, false, "Duran", "09995554433", "Manager", 50000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9f89e8bf-4156-4699-825a-ee049d28bc18"), new DateTime(2024, 7, 23, 12, 0, 33, 22, DateTimeKind.Local).AddTicks(129), new DateOnly(1970, 1, 1), "ThisIsStaff@hotmail.com", "Ali", new DateOnly(2010, 1, 1), new Guid("e66d5f65-e52e-419f-bc7e-d195c11a97aa"), false, false, "Vali", "09995554433", "Manager", 50000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CheckinDate", "CheckoutDate", "CreatedTime", "IsActive", "IsDeleted", "RoomId", "TotalPrice", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("90ae6cc1-4b69-4fa0-a13b-f9384951e1cc"), new DateOnly(2024, 7, 23), new DateOnly(2024, 7, 28), new DateTime(2024, 7, 23, 12, 0, 33, 22, DateTimeKind.Local).AddTicks(500), false, false, new Guid("a935b41a-bdbc-49e5-bd13-d80256733795"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e42727e9-7719-491b-8d35-23c400f21ab8"), new DateOnly(2024, 8, 1), new DateOnly(2024, 8, 2), new DateTime(2024, 7, 23, 12, 0, 33, 22, DateTimeKind.Local).AddTicks(521), false, false, new Guid("a935b41a-bdbc-49e5-bd13-d80256733795"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "BRBookingGuest",
                columns: new[] { "BookingId", "GuestId", "CreatedTime", "IsActive", "IsDeleted", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("90ae6cc1-4b69-4fa0-a13b-f9384951e1cc"), new Guid("cb49eba7-c6d4-4668-af91-fafcaf0d481c"), new DateTime(2024, 7, 23, 12, 0, 33, 22, DateTimeKind.Local).AddTicks(454), false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e42727e9-7719-491b-8d35-23c400f21ab8"), new Guid("cb49eba7-c6d4-4668-af91-fafcaf0d481c"), new DateTime(2024, 7, 23, 12, 0, 33, 22, DateTimeKind.Local).AddTicks(477), false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BRBookingGuest",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("90ae6cc1-4b69-4fa0-a13b-f9384951e1cc"), new Guid("cb49eba7-c6d4-4668-af91-fafcaf0d481c") });

            migrationBuilder.DeleteData(
                table: "BRBookingGuest",
                keyColumns: new[] { "BookingId", "GuestId" },
                keyValues: new object[] { new Guid("e42727e9-7719-491b-8d35-23c400f21ab8"), new Guid("cb49eba7-c6d4-4668-af91-fafcaf0d481c") });

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("00ccbe8e-9f9b-4ddd-886a-fd429be9ab7d"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("0c78e094-4873-4d73-9541-9462f9337f68"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("3a43d430-9439-4281-88dd-d9a5679df58c"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("78fc7744-4908-4410-bea2-cf5552334768"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c8866c93-763c-4d84-b3f0-5b5bc99a7a1b"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("50cdf700-fcfe-4f36-be68-33dca656b065"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("9f89e8bf-4156-4699-825a-ee049d28bc18"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("90ae6cc1-4b69-4fa0-a13b-f9384951e1cc"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("e42727e9-7719-491b-8d35-23c400f21ab8"));

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("cb49eba7-c6d4-4668-af91-fafcaf0d481c"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("a990f016-ec3b-4aa9-a98e-e08331691876"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("23e13b86-0514-424b-b805-febf8d8ed0cb"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("76edbb82-91f8-47d9-b738-66c8e7f0758c"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a935b41a-bdbc-49e5-bd13-d80256733795"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("e66d5f65-e52e-419f-bc7e-d195c11a97aa"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("3afba231-d67d-4eeb-985f-0dd1b6bf5776"));

            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "Id", "Address", "CreatedTime", "DateOfBirth", "Email", "FirstName", "IdentityNumber", "IsActive", "IsDeleted", "LastName", "Phone", "UpdatedTime" },
                values: new object[] { new Guid("f09faf7a-8f71-4e87-8777-cc89057cddbc"), "aa", new DateTime(2024, 7, 23, 11, 54, 53, 481, DateTimeKind.Local).AddTicks(3813), new DateOnly(1999, 9, 9), "aaa", "Test", null, false, false, "Test", "5656", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CheckinTime", "CheckoutTime", "CreatedTime", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("4b684e12-6673-4814-9d54-01cdbe6316db"), "İstanbul/Eminönü", new TimeOnly(8, 0, 0), new TimeOnly(23, 59, 0), new DateTime(2024, 7, 23, 11, 54, 53, 481, DateTimeKind.Local).AddTicks(3412), "turkuaz@hotmail.com", false, false, "Turkuaz", "55554443265", (byte)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b1316992-4e60-4f0f-986c-68d1f1043042"), "İzmir/Alsancak", new TimeOnly(8, 0, 0), new TimeOnly(23, 59, 0), new DateTime(2024, 7, 23, 11, 54, 53, 481, DateTimeKind.Local).AddTicks(3353), "ibishotel@hotmail.com", false, false, "İbis", "09998887766", (byte)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Capacity", "CreatedTime", "Description", "IsActive", "IsDeleted", "Name", "PricePerNight", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("18e870ac-20f3-403f-b978-777e651faeaa"), (byte)2, new DateTime(2024, 7, 23, 11, 54, 53, 481, DateTimeKind.Local).AddTicks(3548), "Suit type room", false, false, "Suit", 1000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5c8278c8-e67e-40e1-8eed-ae043b9dc2f4"), (byte)1, new DateTime(2024, 7, 23, 11, 54, 53, 481, DateTimeKind.Local).AddTicks(3604), "Single type room", false, false, "Single", 500m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ac5ee7c8-afbb-4ef9-891a-1130b984519b"), (byte)4, new DateTime(2024, 7, 23, 11, 54, 53, 481, DateTimeKind.Local).AddTicks(3579), "King type room", false, false, "King", 4000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedTime", "HotelId", "IsActive", "IsDeleted", "RoomNumber", "RoomTypeId", "Status", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("9685765c-af41-44cf-9b8c-2cdbe38e1572"), new DateTime(2024, 7, 23, 11, 54, 53, 481, DateTimeKind.Local).AddTicks(3790), new Guid("4b684e12-6673-4814-9d54-01cdbe6316db"), false, false, 102, new Guid("5c8278c8-e67e-40e1-8eed-ae043b9dc2f4"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9b273348-a54b-4b4c-a39a-ab0d9aac0bad"), new DateTime(2024, 7, 23, 11, 54, 53, 481, DateTimeKind.Local).AddTicks(3724), new Guid("b1316992-4e60-4f0f-986c-68d1f1043042"), false, false, 202, new Guid("5c8278c8-e67e-40e1-8eed-ae043b9dc2f4"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aadbf26e-985d-4b28-8ea9-84397e6604e9"), new DateTime(2024, 7, 23, 11, 54, 53, 481, DateTimeKind.Local).AddTicks(3643), new Guid("b1316992-4e60-4f0f-986c-68d1f1043042"), false, false, 101, new Guid("18e870ac-20f3-403f-b978-777e651faeaa"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b82aac65-08b2-4c6d-9bbf-8c5b0577471b"), new DateTime(2024, 7, 23, 11, 54, 53, 481, DateTimeKind.Local).AddTicks(3673), new Guid("b1316992-4e60-4f0f-986c-68d1f1043042"), false, false, 102, new Guid("18e870ac-20f3-403f-b978-777e651faeaa"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c52efb0c-cb0e-445a-b3a8-990a13b6b76a"), new DateTime(2024, 7, 23, 11, 54, 53, 481, DateTimeKind.Local).AddTicks(3762), new Guid("4b684e12-6673-4814-9d54-01cdbe6316db"), false, false, 101, new Guid("5c8278c8-e67e-40e1-8eed-ae043b9dc2f4"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("da6de807-c136-4356-bbfb-1a08b8916cde"), new DateTime(2024, 7, 23, 11, 54, 53, 481, DateTimeKind.Local).AddTicks(3699), new Guid("b1316992-4e60-4f0f-986c-68d1f1043042"), false, false, 201, new Guid("ac5ee7c8-afbb-4ef9-891a-1130b984519b"), "Avaliable", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CreatedTime", "DateOfBirth", "Email", "FirstName", "HireDate", "HotelId", "IsActive", "IsDeleted", "LastName", "Phone", "Position", "Salary", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("afebe0be-8793-4409-84a4-59a39360102a"), new DateTime(2024, 7, 23, 11, 54, 53, 481, DateTimeKind.Local).AddTicks(3510), new DateOnly(1980, 1, 1), "ThisIsStaff2@hotmail.com", "Murat", new DateOnly(1981, 1, 1), new Guid("4b684e12-6673-4814-9d54-01cdbe6316db"), false, false, "Duran", "09995554433", "Manager", 50000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fd34bb28-2bde-433c-87a8-894c8997423a"), new DateTime(2024, 7, 23, 11, 54, 53, 481, DateTimeKind.Local).AddTicks(3450), new DateOnly(1970, 1, 1), "ThisIsStaff@hotmail.com", "Ali", new DateOnly(2010, 1, 1), new Guid("b1316992-4e60-4f0f-986c-68d1f1043042"), false, false, "Vali", "09995554433", "Manager", 50000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CheckinDate", "CheckoutDate", "CreatedTime", "IsActive", "IsDeleted", "RoomId", "TotalPrice", "UpdatedTime" },
                values: new object[] { new Guid("f987e9ac-0119-4e79-965f-29082a7acf49"), new DateOnly(1, 1, 1), new DateOnly(1, 1, 1), new DateTime(2024, 7, 23, 11, 54, 53, 481, DateTimeKind.Local).AddTicks(3882), false, false, new Guid("aadbf26e-985d-4b28-8ea9-84397e6604e9"), 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "BRBookingGuest",
                columns: new[] { "BookingId", "GuestId", "CreatedTime", "IsActive", "IsDeleted", "UpdatedTime" },
                values: new object[] { new Guid("f987e9ac-0119-4e79-965f-29082a7acf49"), new Guid("f09faf7a-8f71-4e87-8777-cc89057cddbc"), new DateTime(2024, 7, 23, 11, 54, 53, 481, DateTimeKind.Local).AddTicks(3850), false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
