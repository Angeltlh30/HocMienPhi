using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DOTNET_hocmienphi.repository.Migrations
{
    /// <inheritdoc />
    public partial class MentorFreetimes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplyRequest_Users_UserId",
                table: "ApplyRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Mentors_MentorId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Users_UserId",
                table: "Booking");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Booking",
                table: "Booking");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplyRequest",
                table: "ApplyRequest");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0799edca-2dd8-4eae-9f3f-3d754a33e1de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("126ca690-1925-4999-9c9d-d51a2c3e93a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("154e8adb-00fc-42d8-90f9-94016ae12577"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1633cd23-2c7b-4027-88d6-3bc1fc2d2a5a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("185e92d9-8d08-4381-aa49-b23f1e244b4f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("198f9dbf-277c-44ad-b1f3-f57e8b42acb7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19a5eacc-a145-4a59-8402-4aba48f61511"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ada8b9d-08fc-4e00-a19d-07a211e18a4e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("206d0c59-8ba6-40d5-b835-5ed42c88048f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("211a25cb-2c48-4ae7-b011-2293e36e1fbc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("21934229-da69-4f89-8de0-c36dbe97b52d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23fee404-85b9-401c-b44f-f3565fbe2331"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2497c5b7-ed53-45ba-ab9c-e08d1e33ef37"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a1c2fa7-63e7-4620-9347-8f2368612fde"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2fffe2ba-d173-412c-85a9-9faf92cc7983"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30b6aa4f-02de-406b-817a-fc8b8edd65e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36a7a48c-d613-47be-a3a5-5c607b03eca3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("381864a8-abad-4b12-8f7b-392f07e7fcab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("396e9a69-2741-4cc9-9031-924915d380a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3dc9d8ba-f34b-486b-9712-ce361d9c9253"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3f981276-cb9d-4d70-8bc6-99af82631a52"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("414dc608-34c8-4680-a205-a3e4d15154dc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41840d37-81e4-4898-8967-471b0e1c85cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42ba0eb1-cdd5-4507-abe4-9193acc2c318"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ba66411-ba66-4df3-9140-8f885e21946b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c65bdd5-2d11-459c-8d64-de73a3e57466"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e6217a6-8be6-43a2-b69a-fe3f7bd26fe3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("512f0ad2-1c63-4793-96b9-40bfac2ed67c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5334063d-b88a-406c-973f-94af31679a07"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("54494872-4fa4-4f0c-9b18-6f322da988df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55f5f46a-3f32-4f69-8ee8-50248b6b6c95"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5750b0af-70fe-4c22-8ba1-439f0e686402"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("57f78ae8-bb27-4fcd-84fc-1525736ee176"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("58c2e2cc-3e98-40ca-a979-63f919ed7207"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5bbbae6f-09ec-4ed7-84a5-9eec81de84fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5c846913-e1a6-4032-a5d0-2fa5da8b882c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d4ea791-5bdf-497f-bab7-13272dce9d8c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("60de8690-0a41-4675-9208-6c6aa14dad2e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("63adda1e-04d9-4a9d-a899-551824545c38"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66246a11-95d6-4c3e-82fb-051899cdd308"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66bf81d1-f3cf-4d21-91f4-7411a54838e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68e78f42-c3ea-4d59-8534-5d3243554fe0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a733d8f-6c44-4edd-aed5-19d9a9a7213b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e34983c-a18e-48ad-a79a-f8df5b20c2f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e6554e6-dd93-4316-a4d5-7b527cbf46cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("716d73ed-cbf7-41ed-b5af-4acde1b0d7c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("718de223-5693-4d99-99ef-508b9ce5aa9d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72fe79db-b330-474b-9eea-53702b559550"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("73880886-f48b-43da-a1c4-524d8eefa2fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("749cb9ad-9206-4973-b61a-f346b1264ac5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("786b90ab-6c95-40a4-b637-0a19f346bdab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7cc4170e-c282-40b8-bd3a-f98d1d797443"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8203f15f-584d-494b-90b7-1d22410af38b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("83a60160-5b0a-4534-bedd-c8de069ec9a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("89299884-8cf9-4bdc-b164-daaf03a4747e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8aed3a82-c97a-4fb3-a721-fede1e6aafe2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8bf20d33-4100-418b-8e17-965b766d5d48"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e5d10f7-26cb-4b75-ad42-4eb0ba245525"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f1eabdd-a4d7-44e4-893f-f05320319cb4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("912cefc2-7ac6-408a-93f6-b81503f1c62c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("94116936-6d9f-452a-907f-16d495bc412c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95523254-e736-4e70-910b-5d7cc08f9e3f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9565afeb-e7ba-47fe-a71f-8de6038cd296"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95d956e8-7f7a-4714-80a1-ecfad8918615"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99ad021b-5abd-484a-90ec-b25f1cef0272"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d37f31c-0574-44c8-8eaf-3e5e779ccdf8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4b7b238-a1f6-40c1-b432-237ee3791a20"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a5a251c9-b9c8-4fa9-8cde-82e978e5e512"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a8b4da04-8cfc-4266-874e-bd1729543015"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ab8ba314-c132-49e6-af14-945420fba8ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac4ea93e-b723-42d4-bb24-a614a2de121d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad8d67b7-5c11-44cb-831a-f87812ad7906"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3fc837b-eae6-4f43-9a05-b65156a0b5d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5d070a7-d74a-4575-bdf2-c7dd6fef4c27"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5ec933a-2209-4691-b784-7aa5c13695e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b71be76e-e7fa-41d9-93bc-2734c30666ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b9bc9c34-8591-4077-a14b-b23125342a57"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bc6198b1-1557-4f75-a1fc-f19eb6571631"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be51e70b-8abd-4eab-ae96-37bfc5604b06"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c0ff6091-efff-4bdc-bc07-dc9baaf7312b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c18cdc85-7fae-4580-b31c-83e9016ab6f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c48709f1-cedc-43f9-9232-1c512e64cc0d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7639003-af1e-4975-851c-f3d3a02a10af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c773adac-bb01-4a39-8abb-6d8f31bea5f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca50e80c-4929-44dc-93fb-7e430243040b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca8d84ac-a4b3-4e33-b196-680bf2ee6cc0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd3ce254-eb0e-4d50-8f6d-c8937beaef76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8625589-bf6c-40c0-bd5f-90331df6f398"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3644dda-ff37-4bfa-bce7-c38a2726fc9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4395be2-1f26-4d4b-b01f-4f0d47c16e67"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ec47cca7-f751-4224-936b-a9a253a346e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0f84d84-320e-4628-8ca0-811fa11dba98"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2852916-8cef-438d-b544-5ac65abfa6da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f338b9ea-8162-4b22-bddd-32bf926ddd03"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f359b9d7-7df3-4b3e-b5ce-1fc41185d863"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f7781313-890f-4e26-894b-0b33dc445670"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f78b25b3-da26-4598-8c65-5696d9aa31a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f8c437e5-2bd8-40bf-a885-4f5807843807"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc58d28f-33b2-41c3-baa6-6455d001f852"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe28c845-a397-49d2-bccf-00227f087baf"));

            migrationBuilder.RenameTable(
                name: "Booking",
                newName: "Bookings");

            migrationBuilder.RenameTable(
                name: "ApplyRequest",
                newName: "ApplyRequests");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_UserId",
                table: "Bookings",
                newName: "IX_Bookings_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_MentorId",
                table: "Bookings",
                newName: "IX_Bookings_MentorId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplyRequest_UserId",
                table: "ApplyRequests",
                newName: "IX_ApplyRequests_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplyRequests",
                table: "ApplyRequests",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "MentorFreetimes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DateOfWeek = table.Column<int>(type: "integer", nullable: false),
                    StartTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    EndTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    MentorId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MentorFreetimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MentorFreetimes_Mentors_MentorId",
                        column: x => x.MentorId,
                        principalTable: "Mentors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "FirstName", "IsDeleted", "LastName", "Password", "Phone", "Role" },
                values: new object[,]
                {
                    { new Guid("007cd769-ee51-482f-9c67-cb857153b668"), "10", "Email11@gmail.com", "FirstName11", false, "LastName11", "123123", "123123", "Student" },
                    { new Guid("00e9ebec-15ad-45ca-ba40-97d4e7a7c961"), "10", "Email74@gmail.com", "FirstName74", false, "LastName74", "123123", "123123", "Student" },
                    { new Guid("01db8bc4-6c7a-4ade-8c0d-f82706ad6d44"), "10", "Email88@gmail.com", "FirstName88", false, "LastName88", "123123", "123123", "Student" },
                    { new Guid("0271806b-8d4f-4732-8213-07c9fc3ffb67"), "10", "Email18@gmail.com", "FirstName18", false, "LastName18", "123123", "123123", "Student" },
                    { new Guid("04b821c8-2b2f-4ccc-9cea-4a4af7a23d03"), "10", "Email72@gmail.com", "FirstName72", false, "LastName72", "123123", "123123", "Student" },
                    { new Guid("06ab4fdc-ffe5-480c-8ac0-55d2e250a0bd"), "10", "Email6@gmail.com", "FirstName6", false, "LastName6", "123123", "123123", "Student" },
                    { new Guid("0819d1b0-5c2e-4dee-8234-cf4be253b883"), "10", "Email79@gmail.com", "FirstName79", false, "LastName79", "123123", "123123", "Student" },
                    { new Guid("08ca8b8c-c61c-44bf-9375-f80ac0d7d5d0"), "10", "Email10@gmail.com", "FirstName10", false, "LastName10", "123123", "123123", "Student" },
                    { new Guid("0b8b6631-0f55-4677-9df5-9d5f8920a8a4"), "10", "Email75@gmail.com", "FirstName75", false, "LastName75", "123123", "123123", "Student" },
                    { new Guid("0d688a23-ccbc-4b3e-85fd-1d2793b19555"), "10", "Email29@gmail.com", "FirstName29", false, "LastName29", "123123", "123123", "Student" },
                    { new Guid("0ec5009e-738b-40e2-b60c-f0798ba50467"), "10", "Email61@gmail.com", "FirstName61", false, "LastName61", "123123", "123123", "Student" },
                    { new Guid("11b35b30-27c3-4695-9cdb-edd7156d71d5"), "10", "Email51@gmail.com", "FirstName51", false, "LastName51", "123123", "123123", "Student" },
                    { new Guid("136c8433-c43f-432d-9f11-534e0ddd8d03"), "10", "Email36@gmail.com", "FirstName36", false, "LastName36", "123123", "123123", "Student" },
                    { new Guid("19dd7d6b-ebbe-4eec-ac6f-9fee48748b8b"), "10", "Email73@gmail.com", "FirstName73", false, "LastName73", "123123", "123123", "Student" },
                    { new Guid("1de2ee05-5b81-4c89-a7b2-acaac323f053"), "10", "Email66@gmail.com", "FirstName66", false, "LastName66", "123123", "123123", "Student" },
                    { new Guid("1ef3cab6-2ab1-476a-aca8-05cacf5afeb7"), "10", "Email19@gmail.com", "FirstName19", false, "LastName19", "123123", "123123", "Student" },
                    { new Guid("244e8adf-8890-4c07-bf82-86e21bd5042e"), "10", "Email90@gmail.com", "FirstName90", false, "LastName90", "123123", "123123", "Student" },
                    { new Guid("25ae4719-ae23-48d1-beb5-64bbf9e6c56a"), "10", "Email44@gmail.com", "FirstName44", false, "LastName44", "123123", "123123", "Student" },
                    { new Guid("2e5b7f17-1336-4de5-b2f2-70e2412b2583"), "10", "Email58@gmail.com", "FirstName58", false, "LastName58", "123123", "123123", "Student" },
                    { new Guid("2ff6f05c-542b-4385-8a6b-1de08cd7a503"), "10", "Email71@gmail.com", "FirstName71", false, "LastName71", "123123", "123123", "Student" },
                    { new Guid("3430ea43-ea0a-4f2a-8e92-0d135b05436c"), "10", "Email78@gmail.com", "FirstName78", false, "LastName78", "123123", "123123", "Student" },
                    { new Guid("386ea04d-6ffe-42d7-a9a8-d6f6c5214681"), "10", "Email65@gmail.com", "FirstName65", false, "LastName65", "123123", "123123", "Student" },
                    { new Guid("3dc2cd22-dedf-4e43-9d67-a60e6e41f079"), "10", "Email37@gmail.com", "FirstName37", false, "LastName37", "123123", "123123", "Student" },
                    { new Guid("3df82ee8-6f2c-4f3a-bfc1-a04fdd5bcea4"), "10", "Email12@gmail.com", "FirstName12", false, "LastName12", "123123", "123123", "Student" },
                    { new Guid("41df63e7-83b0-4576-ad9b-4cc1ddef0258"), "10", "Email47@gmail.com", "FirstName47", false, "LastName47", "123123", "123123", "Student" },
                    { new Guid("435d0085-a682-4a8b-9e6d-20a3be1d4e59"), "10", "Email89@gmail.com", "FirstName89", false, "LastName89", "123123", "123123", "Student" },
                    { new Guid("456f57fe-08dd-45ab-9698-103339e9fe77"), "10", "Email5@gmail.com", "FirstName5", false, "LastName5", "123123", "123123", "Student" },
                    { new Guid("4734bad7-6a93-4891-bfc6-c28acb03b1bc"), "10", "Email35@gmail.com", "FirstName35", false, "LastName35", "123123", "123123", "Student" },
                    { new Guid("49db8845-3f51-45bd-aef2-e57d0db15039"), "10", "Email27@gmail.com", "FirstName27", false, "LastName27", "123123", "123123", "Student" },
                    { new Guid("4a1b8346-ac03-4cf8-900d-4507002b1c49"), "10", "Email60@gmail.com", "FirstName60", false, "LastName60", "123123", "123123", "Student" },
                    { new Guid("4a5e2d52-b612-471d-bfce-7521259b9a97"), "10", "Email59@gmail.com", "FirstName59", false, "LastName59", "123123", "123123", "Student" },
                    { new Guid("4c5fc0fe-0aef-4974-9bfe-c081b6b144e3"), "10", "Email70@gmail.com", "FirstName70", false, "LastName70", "123123", "123123", "Student" },
                    { new Guid("52c8edb9-5991-4575-ac32-0d46e264ee73"), "10", "Email39@gmail.com", "FirstName39", false, "LastName39", "123123", "123123", "Student" },
                    { new Guid("533848c2-99d5-40f6-9c87-032ccb612703"), "10", "Email9@gmail.com", "FirstName9", false, "LastName9", "123123", "123123", "Student" },
                    { new Guid("57a03ea2-3e38-44db-84db-fd44caaa6745"), "10", "Email68@gmail.com", "FirstName68", false, "LastName68", "123123", "123123", "Student" },
                    { new Guid("5e9ef8f2-daab-4fba-9c26-7fd78e511f2a"), "10", "Email64@gmail.com", "FirstName64", false, "LastName64", "123123", "123123", "Student" },
                    { new Guid("62f1ad15-fba5-4056-a585-065bf9b9ebab"), "10", "Email0@gmail.com", "FirstName0", false, "LastName0", "123123", "123123", "Student" },
                    { new Guid("63bc3c12-3f73-4ce9-bcb0-23a48110470d"), "10", "Email38@gmail.com", "FirstName38", false, "LastName38", "123123", "123123", "Student" },
                    { new Guid("64301bb6-3442-41ab-9c1e-c26f9d70c658"), "10", "Email54@gmail.com", "FirstName54", false, "LastName54", "123123", "123123", "Student" },
                    { new Guid("68f14dc3-861c-4f6c-9ddb-b207fefd31d3"), "10", "Email21@gmail.com", "FirstName21", false, "LastName21", "123123", "123123", "Student" },
                    { new Guid("6a285add-1732-405b-9d02-d30f5ceb2a32"), "10", "Email15@gmail.com", "FirstName15", false, "LastName15", "123123", "123123", "Student" },
                    { new Guid("6bf96592-7d8f-41d8-aee1-c3fab66a3685"), "10", "Email98@gmail.com", "FirstName98", false, "LastName98", "123123", "123123", "Student" },
                    { new Guid("6dbe629b-66cd-47bb-8cb0-e3fd4b03015e"), "10", "Email55@gmail.com", "FirstName55", false, "LastName55", "123123", "123123", "Student" },
                    { new Guid("6dcf889e-4fe3-49a9-b166-3312455d272f"), "10", "Email69@gmail.com", "FirstName69", false, "LastName69", "123123", "123123", "Student" },
                    { new Guid("73b63a03-b78c-446d-9091-7c4629f98b6a"), "10", "Email50@gmail.com", "FirstName50", false, "LastName50", "123123", "123123", "Student" },
                    { new Guid("74badefb-1b33-483f-9c65-b114ee10858c"), "10", "Email49@gmail.com", "FirstName49", false, "LastName49", "123123", "123123", "Student" },
                    { new Guid("7536bfbf-5a1c-421b-9a86-c16051855ad7"), "10", "Email7@gmail.com", "FirstName7", false, "LastName7", "123123", "123123", "Student" },
                    { new Guid("761aa13b-bfe3-4b29-8741-d6072986a87b"), "10", "Email24@gmail.com", "FirstName24", false, "LastName24", "123123", "123123", "Student" },
                    { new Guid("7679f71c-08f6-4353-a285-412ea96abbf0"), "10", "Email17@gmail.com", "FirstName17", false, "LastName17", "123123", "123123", "Student" },
                    { new Guid("769fae5e-2ed8-4fbb-b415-425ece41f623"), "10", "Email63@gmail.com", "FirstName63", false, "LastName63", "123123", "123123", "Student" },
                    { new Guid("7749ca6d-c51e-4422-8c12-4744ec1cb5e4"), "10", "Email52@gmail.com", "FirstName52", false, "LastName52", "123123", "123123", "Student" },
                    { new Guid("7a4516b5-8e92-4fd6-9307-b1451475e637"), "10", "Email95@gmail.com", "FirstName95", false, "LastName95", "123123", "123123", "Student" },
                    { new Guid("7effe25a-b38c-44b5-bac6-2a9983841411"), "10", "Email3@gmail.com", "FirstName3", false, "LastName3", "123123", "123123", "Student" },
                    { new Guid("8299dcc3-e846-49b5-82d1-7cfe336c0f38"), "10", "Email56@gmail.com", "FirstName56", false, "LastName56", "123123", "123123", "Student" },
                    { new Guid("831789d8-709c-401d-b59b-533e83d587fd"), "10", "Email77@gmail.com", "FirstName77", false, "LastName77", "123123", "123123", "Student" },
                    { new Guid("83b98411-372d-4661-9326-3486895ab280"), "10", "Email48@gmail.com", "FirstName48", false, "LastName48", "123123", "123123", "Student" },
                    { new Guid("84f4bdac-3533-4f42-b9de-cbb20ca0ea80"), "10", "Email34@gmail.com", "FirstName34", false, "LastName34", "123123", "123123", "Student" },
                    { new Guid("873d6aad-dedf-41f4-9c5b-6ecb73452052"), "10", "Email4@gmail.com", "FirstName4", false, "LastName4", "123123", "123123", "Student" },
                    { new Guid("91e8ee4e-b9f7-498e-ae9b-13dcdb073184"), "10", "Email28@gmail.com", "FirstName28", false, "LastName28", "123123", "123123", "Student" },
                    { new Guid("945d1eb7-a380-408b-ac1b-91820217ca63"), "10", "Email42@gmail.com", "FirstName42", false, "LastName42", "123123", "123123", "Student" },
                    { new Guid("9802d23c-b056-47d2-8589-1a0579a91d76"), "10", "Email99@gmail.com", "FirstName99", false, "LastName99", "123123", "123123", "Student" },
                    { new Guid("9ecb6c43-a1c6-4b87-89fe-96914a5485f3"), "10", "Email86@gmail.com", "FirstName86", false, "LastName86", "123123", "123123", "Student" },
                    { new Guid("9fa8ec7a-2143-4214-9364-343674cfde87"), "10", "Email31@gmail.com", "FirstName31", false, "LastName31", "123123", "123123", "Student" },
                    { new Guid("a67f7900-0057-4213-ac4f-18a46ea68b38"), "10", "Email14@gmail.com", "FirstName14", false, "LastName14", "123123", "123123", "Student" },
                    { new Guid("aa17fe42-b4de-4445-a62d-b57bba3148dd"), "10", "Email41@gmail.com", "FirstName41", false, "LastName41", "123123", "123123", "Student" },
                    { new Guid("aaa928fa-19fd-4837-a27c-93445947cc9a"), "10", "Email46@gmail.com", "FirstName46", false, "LastName46", "123123", "123123", "Student" },
                    { new Guid("ab815c9d-24cd-4845-a423-ad0e9e41e164"), "10", "Email67@gmail.com", "FirstName67", false, "LastName67", "123123", "123123", "Student" },
                    { new Guid("ad408f3a-127a-4ce2-92d3-5d00b087d580"), "10", "Email91@gmail.com", "FirstName91", false, "LastName91", "123123", "123123", "Student" },
                    { new Guid("ade571f8-3a64-4ce3-aeaf-1cb5bf67ff55"), "10", "Email45@gmail.com", "FirstName45", false, "LastName45", "123123", "123123", "Student" },
                    { new Guid("aefb5779-0261-44e8-aa70-dae20c6fe82d"), "10", "Email20@gmail.com", "FirstName20", false, "LastName20", "123123", "123123", "Student" },
                    { new Guid("b07fc6ab-5932-4f5f-99e7-1644960319f7"), "10", "Email25@gmail.com", "FirstName25", false, "LastName25", "123123", "123123", "Student" },
                    { new Guid("b87557ae-1d93-4f3d-bb84-9623d2746f4c"), "10", "Email82@gmail.com", "FirstName82", false, "LastName82", "123123", "123123", "Student" },
                    { new Guid("b895fc21-3b09-4d82-ae14-a7b049c68cde"), "10", "Email84@gmail.com", "FirstName84", false, "LastName84", "123123", "123123", "Student" },
                    { new Guid("bba35854-16bc-46b2-8f37-703d239851b5"), "10", "Email30@gmail.com", "FirstName30", false, "LastName30", "123123", "123123", "Student" },
                    { new Guid("bd4df244-844c-41f8-9d80-e1e8753c189b"), "10", "Email87@gmail.com", "FirstName87", false, "LastName87", "123123", "123123", "Student" },
                    { new Guid("c1c6c249-3a17-4714-9556-31fff980a166"), "10", "Email62@gmail.com", "FirstName62", false, "LastName62", "123123", "123123", "Student" },
                    { new Guid("c3bff8ad-75fe-43b5-8f55-2494042c5f92"), "10", "Email2@gmail.com", "FirstName2", false, "LastName2", "123123", "123123", "Student" },
                    { new Guid("c3f0bb51-969e-4c02-b80b-a25341842bc0"), "10", "Email76@gmail.com", "FirstName76", false, "LastName76", "123123", "123123", "Student" },
                    { new Guid("c6052888-acc6-407a-a58c-a39aef5edd06"), "10", "Email80@gmail.com", "FirstName80", false, "LastName80", "123123", "123123", "Student" },
                    { new Guid("c6d85803-38c2-414b-aaf7-7903dce696a9"), "10", "Email43@gmail.com", "FirstName43", false, "LastName43", "123123", "123123", "Student" },
                    { new Guid("c77f49a4-79da-4029-9d0a-1a5a813d0a2e"), "10", "Email81@gmail.com", "FirstName81", false, "LastName81", "123123", "123123", "Student" },
                    { new Guid("cc66a418-a2b7-46eb-a4e2-4613cdddf662"), "10", "Email85@gmail.com", "FirstName85", false, "LastName85", "123123", "123123", "Student" },
                    { new Guid("cd5ff73f-3753-4264-a698-aca43e910857"), "10", "Email1@gmail.com", "FirstName1", false, "LastName1", "123123", "123123", "Student" },
                    { new Guid("ce7ab4c2-329c-4fbd-8e79-ae6adeea0654"), "10", "Email13@gmail.com", "FirstName13", false, "LastName13", "123123", "123123", "Student" },
                    { new Guid("cee6e6d0-e4fd-4bef-bacf-27ad53b5fdae"), "10", "Email33@gmail.com", "FirstName33", false, "LastName33", "123123", "123123", "Student" },
                    { new Guid("d0124ab1-74c9-43ea-ad98-6d18b3b6dfad"), "10", "Email83@gmail.com", "FirstName83", false, "LastName83", "123123", "123123", "Student" },
                    { new Guid("d1e98eb4-15c0-45fd-91db-1f938a734ad7"), "10", "Email97@gmail.com", "FirstName97", false, "LastName97", "123123", "123123", "Student" },
                    { new Guid("dcd936fe-d7a7-4fc7-91a9-22c43596408a"), "10", "Email93@gmail.com", "FirstName93", false, "LastName93", "123123", "123123", "Student" },
                    { new Guid("e7f9ad4f-0270-4f21-a0ca-aba79fcb0687"), "10", "Email94@gmail.com", "FirstName94", false, "LastName94", "123123", "123123", "Student" },
                    { new Guid("e9a9324b-9306-49d9-b933-055ca499d337"), "10", "Email96@gmail.com", "FirstName96", false, "LastName96", "123123", "123123", "Student" },
                    { new Guid("eb001f5a-5801-4621-9c0c-97c21c3a743f"), "10", "Email53@gmail.com", "FirstName53", false, "LastName53", "123123", "123123", "Student" },
                    { new Guid("eecbfc2a-9555-489d-80db-27e9bf33b507"), "10", "Email8@gmail.com", "FirstName8", false, "LastName8", "123123", "123123", "Student" },
                    { new Guid("f212babf-eb0f-40fa-8e17-3c78c7f90480"), "10", "Email16@gmail.com", "FirstName16", false, "LastName16", "123123", "123123", "Student" },
                    { new Guid("f387ae99-7e41-46fc-9471-cb2d2d12a03b"), "10", "Email57@gmail.com", "FirstName57", false, "LastName57", "123123", "123123", "Student" },
                    { new Guid("f45e5f7b-5109-4f60-9033-e3f31aa7dcac"), "10", "Email40@gmail.com", "FirstName40", false, "LastName40", "123123", "123123", "Student" },
                    { new Guid("f5714239-7f0c-485d-bfbf-4535f583d68f"), "10", "Email23@gmail.com", "FirstName23", false, "LastName23", "123123", "123123", "Student" },
                    { new Guid("f87658f0-a2c1-4e1c-bacf-5a9c94fe05a2"), "10", "Email32@gmail.com", "FirstName32", false, "LastName32", "123123", "123123", "Student" },
                    { new Guid("f992a476-aa4a-4b60-abe6-0f36e5d54ada"), "10", "Email26@gmail.com", "FirstName26", false, "LastName26", "123123", "123123", "Student" },
                    { new Guid("fd1f5fc6-0abb-4a1d-ba79-624f8324f3c4"), "10", "Email92@gmail.com", "FirstName92", false, "LastName92", "123123", "123123", "Student" },
                    { new Guid("fda04a78-ad12-49e6-8909-db0e7d88e0f3"), "10", "Email22@gmail.com", "FirstName22", false, "LastName22", "123123", "123123", "Student" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MentorFreetimes_MentorId",
                table: "MentorFreetimes",
                column: "MentorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplyRequests_Users_UserId",
                table: "ApplyRequests",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Mentors_MentorId",
                table: "Bookings",
                column: "MentorId",
                principalTable: "Mentors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Users_UserId",
                table: "Bookings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplyRequests_Users_UserId",
                table: "ApplyRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Mentors_MentorId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Users_UserId",
                table: "Bookings");

            migrationBuilder.DropTable(
                name: "MentorFreetimes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplyRequests",
                table: "ApplyRequests");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("007cd769-ee51-482f-9c67-cb857153b668"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00e9ebec-15ad-45ca-ba40-97d4e7a7c961"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("01db8bc4-6c7a-4ade-8c0d-f82706ad6d44"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0271806b-8d4f-4732-8213-07c9fc3ffb67"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("04b821c8-2b2f-4ccc-9cea-4a4af7a23d03"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("06ab4fdc-ffe5-480c-8ac0-55d2e250a0bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0819d1b0-5c2e-4dee-8234-cf4be253b883"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("08ca8b8c-c61c-44bf-9375-f80ac0d7d5d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b8b6631-0f55-4677-9df5-9d5f8920a8a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0d688a23-ccbc-4b3e-85fd-1d2793b19555"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ec5009e-738b-40e2-b60c-f0798ba50467"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11b35b30-27c3-4695-9cdb-edd7156d71d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("136c8433-c43f-432d-9f11-534e0ddd8d03"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19dd7d6b-ebbe-4eec-ac6f-9fee48748b8b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1de2ee05-5b81-4c89-a7b2-acaac323f053"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ef3cab6-2ab1-476a-aca8-05cacf5afeb7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("244e8adf-8890-4c07-bf82-86e21bd5042e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("25ae4719-ae23-48d1-beb5-64bbf9e6c56a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e5b7f17-1336-4de5-b2f2-70e2412b2583"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ff6f05c-542b-4385-8a6b-1de08cd7a503"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3430ea43-ea0a-4f2a-8e92-0d135b05436c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("386ea04d-6ffe-42d7-a9a8-d6f6c5214681"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3dc2cd22-dedf-4e43-9d67-a60e6e41f079"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3df82ee8-6f2c-4f3a-bfc1-a04fdd5bcea4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41df63e7-83b0-4576-ad9b-4cc1ddef0258"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("435d0085-a682-4a8b-9e6d-20a3be1d4e59"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("456f57fe-08dd-45ab-9698-103339e9fe77"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4734bad7-6a93-4891-bfc6-c28acb03b1bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("49db8845-3f51-45bd-aef2-e57d0db15039"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4a1b8346-ac03-4cf8-900d-4507002b1c49"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4a5e2d52-b612-471d-bfce-7521259b9a97"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c5fc0fe-0aef-4974-9bfe-c081b6b144e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("52c8edb9-5991-4575-ac32-0d46e264ee73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("533848c2-99d5-40f6-9c87-032ccb612703"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("57a03ea2-3e38-44db-84db-fd44caaa6745"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5e9ef8f2-daab-4fba-9c26-7fd78e511f2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62f1ad15-fba5-4056-a585-065bf9b9ebab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("63bc3c12-3f73-4ce9-bcb0-23a48110470d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("64301bb6-3442-41ab-9c1e-c26f9d70c658"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68f14dc3-861c-4f6c-9ddb-b207fefd31d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a285add-1732-405b-9d02-d30f5ceb2a32"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6bf96592-7d8f-41d8-aee1-c3fab66a3685"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6dbe629b-66cd-47bb-8cb0-e3fd4b03015e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6dcf889e-4fe3-49a9-b166-3312455d272f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("73b63a03-b78c-446d-9091-7c4629f98b6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74badefb-1b33-483f-9c65-b114ee10858c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7536bfbf-5a1c-421b-9a86-c16051855ad7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("761aa13b-bfe3-4b29-8741-d6072986a87b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7679f71c-08f6-4353-a285-412ea96abbf0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("769fae5e-2ed8-4fbb-b415-425ece41f623"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7749ca6d-c51e-4422-8c12-4744ec1cb5e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a4516b5-8e92-4fd6-9307-b1451475e637"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7effe25a-b38c-44b5-bac6-2a9983841411"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8299dcc3-e846-49b5-82d1-7cfe336c0f38"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("831789d8-709c-401d-b59b-533e83d587fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("83b98411-372d-4661-9326-3486895ab280"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84f4bdac-3533-4f42-b9de-cbb20ca0ea80"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("873d6aad-dedf-41f4-9c5b-6ecb73452052"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("91e8ee4e-b9f7-498e-ae9b-13dcdb073184"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("945d1eb7-a380-408b-ac1b-91820217ca63"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9802d23c-b056-47d2-8589-1a0579a91d76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ecb6c43-a1c6-4b87-89fe-96914a5485f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9fa8ec7a-2143-4214-9364-343674cfde87"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a67f7900-0057-4213-ac4f-18a46ea68b38"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa17fe42-b4de-4445-a62d-b57bba3148dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aaa928fa-19fd-4837-a27c-93445947cc9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ab815c9d-24cd-4845-a423-ad0e9e41e164"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad408f3a-127a-4ce2-92d3-5d00b087d580"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ade571f8-3a64-4ce3-aeaf-1cb5bf67ff55"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aefb5779-0261-44e8-aa70-dae20c6fe82d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b07fc6ab-5932-4f5f-99e7-1644960319f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b87557ae-1d93-4f3d-bb84-9623d2746f4c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b895fc21-3b09-4d82-ae14-a7b049c68cde"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bba35854-16bc-46b2-8f37-703d239851b5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd4df244-844c-41f8-9d80-e1e8753c189b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c1c6c249-3a17-4714-9556-31fff980a166"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3bff8ad-75fe-43b5-8f55-2494042c5f92"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3f0bb51-969e-4c02-b80b-a25341842bc0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6052888-acc6-407a-a58c-a39aef5edd06"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6d85803-38c2-414b-aaf7-7903dce696a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c77f49a4-79da-4029-9d0a-1a5a813d0a2e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cc66a418-a2b7-46eb-a4e2-4613cdddf662"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd5ff73f-3753-4264-a698-aca43e910857"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ce7ab4c2-329c-4fbd-8e79-ae6adeea0654"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cee6e6d0-e4fd-4bef-bacf-27ad53b5fdae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0124ab1-74c9-43ea-ad98-6d18b3b6dfad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d1e98eb4-15c0-45fd-91db-1f938a734ad7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dcd936fe-d7a7-4fc7-91a9-22c43596408a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e7f9ad4f-0270-4f21-a0ca-aba79fcb0687"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e9a9324b-9306-49d9-b933-055ca499d337"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb001f5a-5801-4621-9c0c-97c21c3a743f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eecbfc2a-9555-489d-80db-27e9bf33b507"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f212babf-eb0f-40fa-8e17-3c78c7f90480"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f387ae99-7e41-46fc-9471-cb2d2d12a03b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f45e5f7b-5109-4f60-9033-e3f31aa7dcac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5714239-7f0c-485d-bfbf-4535f583d68f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f87658f0-a2c1-4e1c-bacf-5a9c94fe05a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f992a476-aa4a-4b60-abe6-0f36e5d54ada"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fd1f5fc6-0abb-4a1d-ba79-624f8324f3c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fda04a78-ad12-49e6-8909-db0e7d88e0f3"));

            migrationBuilder.RenameTable(
                name: "Bookings",
                newName: "Booking");

            migrationBuilder.RenameTable(
                name: "ApplyRequests",
                newName: "ApplyRequest");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_UserId",
                table: "Booking",
                newName: "IX_Booking_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_MentorId",
                table: "Booking",
                newName: "IX_Booking_MentorId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplyRequests_UserId",
                table: "ApplyRequest",
                newName: "IX_ApplyRequest_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Booking",
                table: "Booking",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplyRequest",
                table: "ApplyRequest",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "FirstName", "IsDeleted", "LastName", "Password", "Phone", "Role" },
                values: new object[,]
                {
                    { new Guid("0799edca-2dd8-4eae-9f3f-3d754a33e1de"), "10", "Email39@gmail.com", "FirstName39", false, "LastName39", "123123", "123123", "Student" },
                    { new Guid("126ca690-1925-4999-9c9d-d51a2c3e93a0"), "10", "Email46@gmail.com", "FirstName46", false, "LastName46", "123123", "123123", "Student" },
                    { new Guid("154e8adb-00fc-42d8-90f9-94016ae12577"), "10", "Email68@gmail.com", "FirstName68", false, "LastName68", "123123", "123123", "Student" },
                    { new Guid("1633cd23-2c7b-4027-88d6-3bc1fc2d2a5a"), "10", "Email22@gmail.com", "FirstName22", false, "LastName22", "123123", "123123", "Student" },
                    { new Guid("185e92d9-8d08-4381-aa49-b23f1e244b4f"), "10", "Email87@gmail.com", "FirstName87", false, "LastName87", "123123", "123123", "Student" },
                    { new Guid("198f9dbf-277c-44ad-b1f3-f57e8b42acb7"), "10", "Email85@gmail.com", "FirstName85", false, "LastName85", "123123", "123123", "Student" },
                    { new Guid("19a5eacc-a145-4a59-8402-4aba48f61511"), "10", "Email29@gmail.com", "FirstName29", false, "LastName29", "123123", "123123", "Student" },
                    { new Guid("1ada8b9d-08fc-4e00-a19d-07a211e18a4e"), "10", "Email37@gmail.com", "FirstName37", false, "LastName37", "123123", "123123", "Student" },
                    { new Guid("206d0c59-8ba6-40d5-b835-5ed42c88048f"), "10", "Email90@gmail.com", "FirstName90", false, "LastName90", "123123", "123123", "Student" },
                    { new Guid("211a25cb-2c48-4ae7-b011-2293e36e1fbc"), "10", "Email8@gmail.com", "FirstName8", false, "LastName8", "123123", "123123", "Student" },
                    { new Guid("21934229-da69-4f89-8de0-c36dbe97b52d"), "10", "Email10@gmail.com", "FirstName10", false, "LastName10", "123123", "123123", "Student" },
                    { new Guid("23fee404-85b9-401c-b44f-f3565fbe2331"), "10", "Email9@gmail.com", "FirstName9", false, "LastName9", "123123", "123123", "Student" },
                    { new Guid("2497c5b7-ed53-45ba-ab9c-e08d1e33ef37"), "10", "Email81@gmail.com", "FirstName81", false, "LastName81", "123123", "123123", "Student" },
                    { new Guid("2a1c2fa7-63e7-4620-9347-8f2368612fde"), "10", "Email19@gmail.com", "FirstName19", false, "LastName19", "123123", "123123", "Student" },
                    { new Guid("2fffe2ba-d173-412c-85a9-9faf92cc7983"), "10", "Email32@gmail.com", "FirstName32", false, "LastName32", "123123", "123123", "Student" },
                    { new Guid("30b6aa4f-02de-406b-817a-fc8b8edd65e2"), "10", "Email15@gmail.com", "FirstName15", false, "LastName15", "123123", "123123", "Student" },
                    { new Guid("36a7a48c-d613-47be-a3a5-5c607b03eca3"), "10", "Email43@gmail.com", "FirstName43", false, "LastName43", "123123", "123123", "Student" },
                    { new Guid("381864a8-abad-4b12-8f7b-392f07e7fcab"), "10", "Email52@gmail.com", "FirstName52", false, "LastName52", "123123", "123123", "Student" },
                    { new Guid("396e9a69-2741-4cc9-9031-924915d380a8"), "10", "Email64@gmail.com", "FirstName64", false, "LastName64", "123123", "123123", "Student" },
                    { new Guid("3dc9d8ba-f34b-486b-9712-ce361d9c9253"), "10", "Email45@gmail.com", "FirstName45", false, "LastName45", "123123", "123123", "Student" },
                    { new Guid("3f981276-cb9d-4d70-8bc6-99af82631a52"), "10", "Email49@gmail.com", "FirstName49", false, "LastName49", "123123", "123123", "Student" },
                    { new Guid("414dc608-34c8-4680-a205-a3e4d15154dc"), "10", "Email1@gmail.com", "FirstName1", false, "LastName1", "123123", "123123", "Student" },
                    { new Guid("41840d37-81e4-4898-8967-471b0e1c85cf"), "10", "Email17@gmail.com", "FirstName17", false, "LastName17", "123123", "123123", "Student" },
                    { new Guid("42ba0eb1-cdd5-4507-abe4-9193acc2c318"), "10", "Email98@gmail.com", "FirstName98", false, "LastName98", "123123", "123123", "Student" },
                    { new Guid("4ba66411-ba66-4df3-9140-8f885e21946b"), "10", "Email61@gmail.com", "FirstName61", false, "LastName61", "123123", "123123", "Student" },
                    { new Guid("4c65bdd5-2d11-459c-8d64-de73a3e57466"), "10", "Email33@gmail.com", "FirstName33", false, "LastName33", "123123", "123123", "Student" },
                    { new Guid("4e6217a6-8be6-43a2-b69a-fe3f7bd26fe3"), "10", "Email21@gmail.com", "FirstName21", false, "LastName21", "123123", "123123", "Student" },
                    { new Guid("512f0ad2-1c63-4793-96b9-40bfac2ed67c"), "10", "Email84@gmail.com", "FirstName84", false, "LastName84", "123123", "123123", "Student" },
                    { new Guid("5334063d-b88a-406c-973f-94af31679a07"), "10", "Email80@gmail.com", "FirstName80", false, "LastName80", "123123", "123123", "Student" },
                    { new Guid("54494872-4fa4-4f0c-9b18-6f322da988df"), "10", "Email93@gmail.com", "FirstName93", false, "LastName93", "123123", "123123", "Student" },
                    { new Guid("55f5f46a-3f32-4f69-8ee8-50248b6b6c95"), "10", "Email14@gmail.com", "FirstName14", false, "LastName14", "123123", "123123", "Student" },
                    { new Guid("5750b0af-70fe-4c22-8ba1-439f0e686402"), "10", "Email74@gmail.com", "FirstName74", false, "LastName74", "123123", "123123", "Student" },
                    { new Guid("57f78ae8-bb27-4fcd-84fc-1525736ee176"), "10", "Email26@gmail.com", "FirstName26", false, "LastName26", "123123", "123123", "Student" },
                    { new Guid("58c2e2cc-3e98-40ca-a979-63f919ed7207"), "10", "Email54@gmail.com", "FirstName54", false, "LastName54", "123123", "123123", "Student" },
                    { new Guid("5bbbae6f-09ec-4ed7-84a5-9eec81de84fc"), "10", "Email12@gmail.com", "FirstName12", false, "LastName12", "123123", "123123", "Student" },
                    { new Guid("5c846913-e1a6-4032-a5d0-2fa5da8b882c"), "10", "Email34@gmail.com", "FirstName34", false, "LastName34", "123123", "123123", "Student" },
                    { new Guid("5d4ea791-5bdf-497f-bab7-13272dce9d8c"), "10", "Email62@gmail.com", "FirstName62", false, "LastName62", "123123", "123123", "Student" },
                    { new Guid("60de8690-0a41-4675-9208-6c6aa14dad2e"), "10", "Email76@gmail.com", "FirstName76", false, "LastName76", "123123", "123123", "Student" },
                    { new Guid("63adda1e-04d9-4a9d-a899-551824545c38"), "10", "Email94@gmail.com", "FirstName94", false, "LastName94", "123123", "123123", "Student" },
                    { new Guid("66246a11-95d6-4c3e-82fb-051899cdd308"), "10", "Email44@gmail.com", "FirstName44", false, "LastName44", "123123", "123123", "Student" },
                    { new Guid("66bf81d1-f3cf-4d21-91f4-7411a54838e7"), "10", "Email79@gmail.com", "FirstName79", false, "LastName79", "123123", "123123", "Student" },
                    { new Guid("68e78f42-c3ea-4d59-8534-5d3243554fe0"), "10", "Email92@gmail.com", "FirstName92", false, "LastName92", "123123", "123123", "Student" },
                    { new Guid("6a733d8f-6c44-4edd-aed5-19d9a9a7213b"), "10", "Email78@gmail.com", "FirstName78", false, "LastName78", "123123", "123123", "Student" },
                    { new Guid("6e34983c-a18e-48ad-a79a-f8df5b20c2f1"), "10", "Email4@gmail.com", "FirstName4", false, "LastName4", "123123", "123123", "Student" },
                    { new Guid("6e6554e6-dd93-4316-a4d5-7b527cbf46cd"), "10", "Email77@gmail.com", "FirstName77", false, "LastName77", "123123", "123123", "Student" },
                    { new Guid("716d73ed-cbf7-41ed-b5af-4acde1b0d7c8"), "10", "Email28@gmail.com", "FirstName28", false, "LastName28", "123123", "123123", "Student" },
                    { new Guid("718de223-5693-4d99-99ef-508b9ce5aa9d"), "10", "Email75@gmail.com", "FirstName75", false, "LastName75", "123123", "123123", "Student" },
                    { new Guid("72fe79db-b330-474b-9eea-53702b559550"), "10", "Email35@gmail.com", "FirstName35", false, "LastName35", "123123", "123123", "Student" },
                    { new Guid("73880886-f48b-43da-a1c4-524d8eefa2fb"), "10", "Email31@gmail.com", "FirstName31", false, "LastName31", "123123", "123123", "Student" },
                    { new Guid("749cb9ad-9206-4973-b61a-f346b1264ac5"), "10", "Email66@gmail.com", "FirstName66", false, "LastName66", "123123", "123123", "Student" },
                    { new Guid("786b90ab-6c95-40a4-b637-0a19f346bdab"), "10", "Email24@gmail.com", "FirstName24", false, "LastName24", "123123", "123123", "Student" },
                    { new Guid("7cc4170e-c282-40b8-bd3a-f98d1d797443"), "10", "Email36@gmail.com", "FirstName36", false, "LastName36", "123123", "123123", "Student" },
                    { new Guid("8203f15f-584d-494b-90b7-1d22410af38b"), "10", "Email82@gmail.com", "FirstName82", false, "LastName82", "123123", "123123", "Student" },
                    { new Guid("83a60160-5b0a-4534-bedd-c8de069ec9a8"), "10", "Email23@gmail.com", "FirstName23", false, "LastName23", "123123", "123123", "Student" },
                    { new Guid("89299884-8cf9-4bdc-b164-daaf03a4747e"), "10", "Email70@gmail.com", "FirstName70", false, "LastName70", "123123", "123123", "Student" },
                    { new Guid("8aed3a82-c97a-4fb3-a721-fede1e6aafe2"), "10", "Email72@gmail.com", "FirstName72", false, "LastName72", "123123", "123123", "Student" },
                    { new Guid("8bf20d33-4100-418b-8e17-965b766d5d48"), "10", "Email41@gmail.com", "FirstName41", false, "LastName41", "123123", "123123", "Student" },
                    { new Guid("8e5d10f7-26cb-4b75-ad42-4eb0ba245525"), "10", "Email63@gmail.com", "FirstName63", false, "LastName63", "123123", "123123", "Student" },
                    { new Guid("8f1eabdd-a4d7-44e4-893f-f05320319cb4"), "10", "Email13@gmail.com", "FirstName13", false, "LastName13", "123123", "123123", "Student" },
                    { new Guid("912cefc2-7ac6-408a-93f6-b81503f1c62c"), "10", "Email20@gmail.com", "FirstName20", false, "LastName20", "123123", "123123", "Student" },
                    { new Guid("94116936-6d9f-452a-907f-16d495bc412c"), "10", "Email6@gmail.com", "FirstName6", false, "LastName6", "123123", "123123", "Student" },
                    { new Guid("95523254-e736-4e70-910b-5d7cc08f9e3f"), "10", "Email56@gmail.com", "FirstName56", false, "LastName56", "123123", "123123", "Student" },
                    { new Guid("9565afeb-e7ba-47fe-a71f-8de6038cd296"), "10", "Email60@gmail.com", "FirstName60", false, "LastName60", "123123", "123123", "Student" },
                    { new Guid("95d956e8-7f7a-4714-80a1-ecfad8918615"), "10", "Email83@gmail.com", "FirstName83", false, "LastName83", "123123", "123123", "Student" },
                    { new Guid("99ad021b-5abd-484a-90ec-b25f1cef0272"), "10", "Email51@gmail.com", "FirstName51", false, "LastName51", "123123", "123123", "Student" },
                    { new Guid("9d37f31c-0574-44c8-8eaf-3e5e779ccdf8"), "10", "Email7@gmail.com", "FirstName7", false, "LastName7", "123123", "123123", "Student" },
                    { new Guid("a4b7b238-a1f6-40c1-b432-237ee3791a20"), "10", "Email97@gmail.com", "FirstName97", false, "LastName97", "123123", "123123", "Student" },
                    { new Guid("a5a251c9-b9c8-4fa9-8cde-82e978e5e512"), "10", "Email57@gmail.com", "FirstName57", false, "LastName57", "123123", "123123", "Student" },
                    { new Guid("a8b4da04-8cfc-4266-874e-bd1729543015"), "10", "Email53@gmail.com", "FirstName53", false, "LastName53", "123123", "123123", "Student" },
                    { new Guid("ab8ba314-c132-49e6-af14-945420fba8ad"), "10", "Email86@gmail.com", "FirstName86", false, "LastName86", "123123", "123123", "Student" },
                    { new Guid("ac4ea93e-b723-42d4-bb24-a614a2de121d"), "10", "Email55@gmail.com", "FirstName55", false, "LastName55", "123123", "123123", "Student" },
                    { new Guid("ad8d67b7-5c11-44cb-831a-f87812ad7906"), "10", "Email71@gmail.com", "FirstName71", false, "LastName71", "123123", "123123", "Student" },
                    { new Guid("b3fc837b-eae6-4f43-9a05-b65156a0b5d4"), "10", "Email16@gmail.com", "FirstName16", false, "LastName16", "123123", "123123", "Student" },
                    { new Guid("b5d070a7-d74a-4575-bdf2-c7dd6fef4c27"), "10", "Email67@gmail.com", "FirstName67", false, "LastName67", "123123", "123123", "Student" },
                    { new Guid("b5ec933a-2209-4691-b784-7aa5c13695e2"), "10", "Email11@gmail.com", "FirstName11", false, "LastName11", "123123", "123123", "Student" },
                    { new Guid("b71be76e-e7fa-41d9-93bc-2734c30666ba"), "10", "Email18@gmail.com", "FirstName18", false, "LastName18", "123123", "123123", "Student" },
                    { new Guid("b9bc9c34-8591-4077-a14b-b23125342a57"), "10", "Email48@gmail.com", "FirstName48", false, "LastName48", "123123", "123123", "Student" },
                    { new Guid("bc6198b1-1557-4f75-a1fc-f19eb6571631"), "10", "Email88@gmail.com", "FirstName88", false, "LastName88", "123123", "123123", "Student" },
                    { new Guid("be51e70b-8abd-4eab-ae96-37bfc5604b06"), "10", "Email89@gmail.com", "FirstName89", false, "LastName89", "123123", "123123", "Student" },
                    { new Guid("c0ff6091-efff-4bdc-bc07-dc9baaf7312b"), "10", "Email91@gmail.com", "FirstName91", false, "LastName91", "123123", "123123", "Student" },
                    { new Guid("c18cdc85-7fae-4580-b31c-83e9016ab6f0"), "10", "Email47@gmail.com", "FirstName47", false, "LastName47", "123123", "123123", "Student" },
                    { new Guid("c48709f1-cedc-43f9-9232-1c512e64cc0d"), "10", "Email65@gmail.com", "FirstName65", false, "LastName65", "123123", "123123", "Student" },
                    { new Guid("c7639003-af1e-4975-851c-f3d3a02a10af"), "10", "Email69@gmail.com", "FirstName69", false, "LastName69", "123123", "123123", "Student" },
                    { new Guid("c773adac-bb01-4a39-8abb-6d8f31bea5f7"), "10", "Email30@gmail.com", "FirstName30", false, "LastName30", "123123", "123123", "Student" },
                    { new Guid("ca50e80c-4929-44dc-93fb-7e430243040b"), "10", "Email3@gmail.com", "FirstName3", false, "LastName3", "123123", "123123", "Student" },
                    { new Guid("ca8d84ac-a4b3-4e33-b196-680bf2ee6cc0"), "10", "Email73@gmail.com", "FirstName73", false, "LastName73", "123123", "123123", "Student" },
                    { new Guid("cd3ce254-eb0e-4d50-8f6d-c8937beaef76"), "10", "Email42@gmail.com", "FirstName42", false, "LastName42", "123123", "123123", "Student" },
                    { new Guid("d8625589-bf6c-40c0-bd5f-90331df6f398"), "10", "Email58@gmail.com", "FirstName58", false, "LastName58", "123123", "123123", "Student" },
                    { new Guid("e3644dda-ff37-4bfa-bce7-c38a2726fc9a"), "10", "Email0@gmail.com", "FirstName0", false, "LastName0", "123123", "123123", "Student" },
                    { new Guid("e4395be2-1f26-4d4b-b01f-4f0d47c16e67"), "10", "Email25@gmail.com", "FirstName25", false, "LastName25", "123123", "123123", "Student" },
                    { new Guid("ec47cca7-f751-4224-936b-a9a253a346e4"), "10", "Email50@gmail.com", "FirstName50", false, "LastName50", "123123", "123123", "Student" },
                    { new Guid("f0f84d84-320e-4628-8ca0-811fa11dba98"), "10", "Email96@gmail.com", "FirstName96", false, "LastName96", "123123", "123123", "Student" },
                    { new Guid("f2852916-8cef-438d-b544-5ac65abfa6da"), "10", "Email40@gmail.com", "FirstName40", false, "LastName40", "123123", "123123", "Student" },
                    { new Guid("f338b9ea-8162-4b22-bddd-32bf926ddd03"), "10", "Email38@gmail.com", "FirstName38", false, "LastName38", "123123", "123123", "Student" },
                    { new Guid("f359b9d7-7df3-4b3e-b5ce-1fc41185d863"), "10", "Email2@gmail.com", "FirstName2", false, "LastName2", "123123", "123123", "Student" },
                    { new Guid("f7781313-890f-4e26-894b-0b33dc445670"), "10", "Email27@gmail.com", "FirstName27", false, "LastName27", "123123", "123123", "Student" },
                    { new Guid("f78b25b3-da26-4598-8c65-5696d9aa31a0"), "10", "Email59@gmail.com", "FirstName59", false, "LastName59", "123123", "123123", "Student" },
                    { new Guid("f8c437e5-2bd8-40bf-a885-4f5807843807"), "10", "Email5@gmail.com", "FirstName5", false, "LastName5", "123123", "123123", "Student" },
                    { new Guid("fc58d28f-33b2-41c3-baa6-6455d001f852"), "10", "Email99@gmail.com", "FirstName99", false, "LastName99", "123123", "123123", "Student" },
                    { new Guid("fe28c845-a397-49d2-bccf-00227f087baf"), "10", "Email95@gmail.com", "FirstName95", false, "LastName95", "123123", "123123", "Student" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplyRequest_Users_UserId",
                table: "ApplyRequest",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Mentors_MentorId",
                table: "Booking",
                column: "MentorId",
                principalTable: "Mentors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Users_UserId",
                table: "Booking",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
