using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YB_MelihEfeOmer_RezervasyonApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class databaseupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Rooms_RoomId",
                table: "Bookings");

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

            migrationBuilder.DropColumn(
                name: "RoomNumber",
                table: "Bookings");

            migrationBuilder.AlterColumn<Guid>(
                name: "RoomId",
                table: "Bookings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Rooms_RoomId",
                table: "Bookings",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Rooms_RoomId",
                table: "Bookings");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "RoomId",
                table: "Bookings",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<int>(
                name: "RoomNumber",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Rooms_RoomId",
                table: "Bookings",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");
        }
    }
}
