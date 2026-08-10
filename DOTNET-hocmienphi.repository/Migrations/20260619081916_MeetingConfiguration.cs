using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DOTNET_hocmienphi.repository.Migrations
{
    /// <inheritdoc />
    public partial class MeetingConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Meetings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meetings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meetings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "FirstName", "IsDeleted", "LastName", "Password", "Phone", "Role" },
                values: new object[,]
                {
                    { new Guid("02d99124-625b-4c19-a1e1-5e7c68dd0931"), "10", "Email28@gmail.com", "FirstName28", false, "LastName28", "123123", "123123", "Student" },
                    { new Guid("0666846a-def5-4cc8-a077-6583639a44d9"), "10", "Email82@gmail.com", "FirstName82", false, "LastName82", "123123", "123123", "Student" },
                    { new Guid("0c6f1c4d-25d8-42d9-a4cf-2329196c71f9"), "10", "Email20@gmail.com", "FirstName20", false, "LastName20", "123123", "123123", "Student" },
                    { new Guid("10a70254-bdf0-4a7d-ab8c-fbd11314f1bc"), "10", "Email57@gmail.com", "FirstName57", false, "LastName57", "123123", "123123", "Student" },
                    { new Guid("10efbd44-6f1e-4248-8eb5-78c46e0705b3"), "10", "Email98@gmail.com", "FirstName98", false, "LastName98", "123123", "123123", "Student" },
                    { new Guid("12157c6e-fa17-4aae-a6ca-420248a05b37"), "10", "Email41@gmail.com", "FirstName41", false, "LastName41", "123123", "123123", "Student" },
                    { new Guid("133858ef-0fe5-4c6a-a50a-974b1540fcff"), "10", "Email77@gmail.com", "FirstName77", false, "LastName77", "123123", "123123", "Student" },
                    { new Guid("1525a95c-29d3-4730-b47e-3724ce73fe05"), "10", "Email92@gmail.com", "FirstName92", false, "LastName92", "123123", "123123", "Student" },
                    { new Guid("1741a198-499d-44b1-9a18-d537d2095947"), "10", "Email80@gmail.com", "FirstName80", false, "LastName80", "123123", "123123", "Student" },
                    { new Guid("1a4ca1fa-f47c-44be-a6d4-05c9cbf0c356"), "10", "Email55@gmail.com", "FirstName55", false, "LastName55", "123123", "123123", "Student" },
                    { new Guid("1c0fe1f5-c708-4742-b1af-b060f3992670"), "10", "Email75@gmail.com", "FirstName75", false, "LastName75", "123123", "123123", "Student" },
                    { new Guid("1da90569-c05f-45e9-9b99-f4600a53a66b"), "10", "Email12@gmail.com", "FirstName12", false, "LastName12", "123123", "123123", "Student" },
                    { new Guid("1ece4746-3c02-40f9-8051-8cad6704e9d1"), "10", "Email39@gmail.com", "FirstName39", false, "LastName39", "123123", "123123", "Student" },
                    { new Guid("25abf871-9d58-45d2-a6be-bed5a7fd8c9c"), "10", "Email27@gmail.com", "FirstName27", false, "LastName27", "123123", "123123", "Student" },
                    { new Guid("286ae138-ec65-4c84-9c6f-e3c25dfde814"), "10", "Email48@gmail.com", "FirstName48", false, "LastName48", "123123", "123123", "Student" },
                    { new Guid("2980d81f-d8d2-4d44-a19b-6a4e5a20791c"), "10", "Email26@gmail.com", "FirstName26", false, "LastName26", "123123", "123123", "Student" },
                    { new Guid("2a8c98f0-7397-4b44-9d38-7fb6fdf4db06"), "10", "Email85@gmail.com", "FirstName85", false, "LastName85", "123123", "123123", "Student" },
                    { new Guid("2b207ccc-b6ef-41b9-9f7a-b028e9ef9d11"), "10", "Email47@gmail.com", "FirstName47", false, "LastName47", "123123", "123123", "Student" },
                    { new Guid("2b9fb8ca-0d64-4826-a64b-b7801bae6628"), "10", "Email93@gmail.com", "FirstName93", false, "LastName93", "123123", "123123", "Student" },
                    { new Guid("33a344ed-d8bb-43e9-96f9-1b5e8f9ad12b"), "10", "Email32@gmail.com", "FirstName32", false, "LastName32", "123123", "123123", "Student" },
                    { new Guid("37983300-bc4c-4f5b-88c5-f5a0d6c6b1d3"), "10", "Email42@gmail.com", "FirstName42", false, "LastName42", "123123", "123123", "Student" },
                    { new Guid("379f1bb8-7866-4ec3-be24-c962fee55fd2"), "10", "Email89@gmail.com", "FirstName89", false, "LastName89", "123123", "123123", "Student" },
                    { new Guid("390353e3-d850-489f-9f90-78b161616c41"), "10", "Email34@gmail.com", "FirstName34", false, "LastName34", "123123", "123123", "Student" },
                    { new Guid("396ff2b9-26bb-4408-82a2-902731a21e37"), "10", "Email72@gmail.com", "FirstName72", false, "LastName72", "123123", "123123", "Student" },
                    { new Guid("3a740fe1-d92f-4846-aa01-53b72917d818"), "10", "Email9@gmail.com", "FirstName9", false, "LastName9", "123123", "123123", "Student" },
                    { new Guid("3dcf8f48-b7c0-455a-b944-fccb49e24272"), "10", "Email1@gmail.com", "FirstName1", false, "LastName1", "123123", "123123", "Student" },
                    { new Guid("41a6aa81-11f5-4763-bc35-3237dfd774b8"), "10", "Email23@gmail.com", "FirstName23", false, "LastName23", "123123", "123123", "Student" },
                    { new Guid("42daffba-a4c2-471b-aa1c-c8f649b8f115"), "10", "Email17@gmail.com", "FirstName17", false, "LastName17", "123123", "123123", "Student" },
                    { new Guid("4be76f75-3ee0-4a9c-81fe-b37d99c31cb7"), "10", "Email8@gmail.com", "FirstName8", false, "LastName8", "123123", "123123", "Student" },
                    { new Guid("4c9c85c3-a6c3-4b7b-b8b5-15a09d09899d"), "10", "Email44@gmail.com", "FirstName44", false, "LastName44", "123123", "123123", "Student" },
                    { new Guid("4f4c3566-8763-4e75-950e-795972b87b53"), "10", "Email65@gmail.com", "FirstName65", false, "LastName65", "123123", "123123", "Student" },
                    { new Guid("5081fc31-537e-449b-8541-8a48ad5e176a"), "10", "Email19@gmail.com", "FirstName19", false, "LastName19", "123123", "123123", "Student" },
                    { new Guid("50ee3d02-ef1f-49ac-9331-ed1833c2ce07"), "10", "Email6@gmail.com", "FirstName6", false, "LastName6", "123123", "123123", "Student" },
                    { new Guid("5346ff80-c21e-4331-aeff-d90a995856ac"), "10", "Email36@gmail.com", "FirstName36", false, "LastName36", "123123", "123123", "Student" },
                    { new Guid("58f39452-e030-4663-b330-6876b0d8fe8b"), "10", "Email95@gmail.com", "FirstName95", false, "LastName95", "123123", "123123", "Student" },
                    { new Guid("5ef7b9b0-08b2-4b95-b27b-5942bfdecc8a"), "10", "Email4@gmail.com", "FirstName4", false, "LastName4", "123123", "123123", "Student" },
                    { new Guid("5f36fd9b-70a2-4370-bf9e-cd65fe24e04d"), "10", "Email81@gmail.com", "FirstName81", false, "LastName81", "123123", "123123", "Student" },
                    { new Guid("6125d47a-3d0b-4462-ab3e-2d4e66e52ea3"), "10", "Email66@gmail.com", "FirstName66", false, "LastName66", "123123", "123123", "Student" },
                    { new Guid("65a0b3e4-65cb-490c-b10a-d75ec49609b8"), "10", "Email2@gmail.com", "FirstName2", false, "LastName2", "123123", "123123", "Student" },
                    { new Guid("664acfa4-8630-4d9f-8292-fe991a4da1e9"), "10", "Email25@gmail.com", "FirstName25", false, "LastName25", "123123", "123123", "Student" },
                    { new Guid("666e34d3-f9b5-4f7a-979f-4cddde1a179d"), "10", "Email22@gmail.com", "FirstName22", false, "LastName22", "123123", "123123", "Student" },
                    { new Guid("6702a71b-d352-4624-b2bb-c8d0bfd2872b"), "10", "Email3@gmail.com", "FirstName3", false, "LastName3", "123123", "123123", "Student" },
                    { new Guid("6c6f1f15-4ae1-4311-b4b7-75f9f034d9c5"), "10", "Email61@gmail.com", "FirstName61", false, "LastName61", "123123", "123123", "Student" },
                    { new Guid("6d9635aa-e0a1-460a-a555-f7bfbcc8d51c"), "10", "Email79@gmail.com", "FirstName79", false, "LastName79", "123123", "123123", "Student" },
                    { new Guid("70db1c40-1eeb-48e0-9092-8ca3db84159f"), "10", "Email14@gmail.com", "FirstName14", false, "LastName14", "123123", "123123", "Student" },
                    { new Guid("7809525f-1d6b-4bee-82e5-bddb68138d7e"), "10", "Email52@gmail.com", "FirstName52", false, "LastName52", "123123", "123123", "Student" },
                    { new Guid("78665603-1e1b-41a0-bf34-8cb80ff475bb"), "10", "Email78@gmail.com", "FirstName78", false, "LastName78", "123123", "123123", "Student" },
                    { new Guid("79f3d1c1-7786-48ef-8ebe-9c35549b768d"), "10", "Email63@gmail.com", "FirstName63", false, "LastName63", "123123", "123123", "Student" },
                    { new Guid("7b3849ed-2db3-4b6b-beed-5f246a9d8395"), "10", "Email91@gmail.com", "FirstName91", false, "LastName91", "123123", "123123", "Student" },
                    { new Guid("86d7d320-05d0-44af-a385-62e486b069a4"), "10", "Email86@gmail.com", "FirstName86", false, "LastName86", "123123", "123123", "Student" },
                    { new Guid("8704bff7-fd2e-4b64-bd4c-756628b5d592"), "10", "Email46@gmail.com", "FirstName46", false, "LastName46", "123123", "123123", "Student" },
                    { new Guid("88ef378a-1e6c-4c74-8f42-83518104dbe1"), "10", "Email5@gmail.com", "FirstName5", false, "LastName5", "123123", "123123", "Student" },
                    { new Guid("8aea45aa-8a93-4a3b-9a70-2a65098fe1f0"), "10", "Email87@gmail.com", "FirstName87", false, "LastName87", "123123", "123123", "Student" },
                    { new Guid("8d88f6cc-6fd9-405e-8798-77f638b87e20"), "10", "Email16@gmail.com", "FirstName16", false, "LastName16", "123123", "123123", "Student" },
                    { new Guid("8da63c40-10b2-4520-93bb-975bd51c03f3"), "10", "Email84@gmail.com", "FirstName84", false, "LastName84", "123123", "123123", "Student" },
                    { new Guid("9020b07f-8116-4073-907e-b6a19d2b61e7"), "10", "Email59@gmail.com", "FirstName59", false, "LastName59", "123123", "123123", "Student" },
                    { new Guid("9336bc86-2f14-4353-9235-642f178d9403"), "10", "Email68@gmail.com", "FirstName68", false, "LastName68", "123123", "123123", "Student" },
                    { new Guid("9355f3b7-5ebb-4256-acaa-fde79a8c2f12"), "10", "Email54@gmail.com", "FirstName54", false, "LastName54", "123123", "123123", "Student" },
                    { new Guid("940a63cd-0100-441d-9e8e-40a17b041257"), "10", "Email33@gmail.com", "FirstName33", false, "LastName33", "123123", "123123", "Student" },
                    { new Guid("94cb9541-fced-4dc1-ba3c-c53876ddf905"), "10", "Email24@gmail.com", "FirstName24", false, "LastName24", "123123", "123123", "Student" },
                    { new Guid("9584ef93-41c7-4468-9117-fe22e1ed1092"), "10", "Email21@gmail.com", "FirstName21", false, "LastName21", "123123", "123123", "Student" },
                    { new Guid("9c7ce40b-e5a5-4cee-a854-ab0e2155c20b"), "10", "Email51@gmail.com", "FirstName51", false, "LastName51", "123123", "123123", "Student" },
                    { new Guid("9f0650c8-7729-4c20-aa20-5cb38fe3dfe9"), "10", "Email97@gmail.com", "FirstName97", false, "LastName97", "123123", "123123", "Student" },
                    { new Guid("9f4949d4-e10b-4d0f-8591-8a315bf2273c"), "10", "Email11@gmail.com", "FirstName11", false, "LastName11", "123123", "123123", "Student" },
                    { new Guid("a39646bb-b10a-4aa9-a095-9d8e8512edc8"), "10", "Email64@gmail.com", "FirstName64", false, "LastName64", "123123", "123123", "Student" },
                    { new Guid("a43c05f6-8b84-4ffb-8930-f45a10a5cb0a"), "10", "Email29@gmail.com", "FirstName29", false, "LastName29", "123123", "123123", "Student" },
                    { new Guid("a511cbcb-4488-4d40-8b83-9bc38a30afbe"), "10", "Email49@gmail.com", "FirstName49", false, "LastName49", "123123", "123123", "Student" },
                    { new Guid("a53dc8a9-a04d-44b4-8cdb-9bbd62fa54d0"), "10", "Email50@gmail.com", "FirstName50", false, "LastName50", "123123", "123123", "Student" },
                    { new Guid("a901d9fc-2863-402b-b801-1f8a1fcf55ff"), "10", "Email83@gmail.com", "FirstName83", false, "LastName83", "123123", "123123", "Student" },
                    { new Guid("aa63a555-cc64-407d-8a35-b174254655c2"), "10", "Email90@gmail.com", "FirstName90", false, "LastName90", "123123", "123123", "Student" },
                    { new Guid("ad53c2b2-8da8-433c-93c3-c6eaa8c29575"), "10", "Email76@gmail.com", "FirstName76", false, "LastName76", "123123", "123123", "Student" },
                    { new Guid("b284abd0-affe-490b-b3b3-9d79a3be8135"), "10", "Email37@gmail.com", "FirstName37", false, "LastName37", "123123", "123123", "Student" },
                    { new Guid("b5e6a695-2456-4be7-bdeb-f91a32f7b868"), "10", "Email96@gmail.com", "FirstName96", false, "LastName96", "123123", "123123", "Student" },
                    { new Guid("b652d514-8745-4cd7-87d1-522a7e09db2e"), "10", "Email18@gmail.com", "FirstName18", false, "LastName18", "123123", "123123", "Student" },
                    { new Guid("b96a4fd4-1a37-4a0c-8a3e-d1beb989fe70"), "10", "Email45@gmail.com", "FirstName45", false, "LastName45", "123123", "123123", "Student" },
                    { new Guid("b99abb8a-e596-41bd-bb47-096cf4395b27"), "10", "Email38@gmail.com", "FirstName38", false, "LastName38", "123123", "123123", "Student" },
                    { new Guid("baa623c1-8a81-4def-a6b6-4b9b7546b57f"), "10", "Email70@gmail.com", "FirstName70", false, "LastName70", "123123", "123123", "Student" },
                    { new Guid("bb25545e-e820-47bd-b63d-212d77d738b0"), "10", "Email31@gmail.com", "FirstName31", false, "LastName31", "123123", "123123", "Student" },
                    { new Guid("bbf220aa-41fa-428e-ad9f-6d04507791be"), "10", "Email88@gmail.com", "FirstName88", false, "LastName88", "123123", "123123", "Student" },
                    { new Guid("bc77c420-61fb-4de5-8fa2-4481e2d5be98"), "10", "Email0@gmail.com", "FirstName0", false, "LastName0", "123123", "123123", "Student" },
                    { new Guid("bceb4660-ec26-488d-a882-6966175e7082"), "10", "Email74@gmail.com", "FirstName74", false, "LastName74", "123123", "123123", "Student" },
                    { new Guid("c2fdf3db-7746-4507-8630-1dcffa2568ef"), "10", "Email35@gmail.com", "FirstName35", false, "LastName35", "123123", "123123", "Student" },
                    { new Guid("ca65d9c1-f1a4-40bc-8b15-9514f5d0a690"), "10", "Email62@gmail.com", "FirstName62", false, "LastName62", "123123", "123123", "Student" },
                    { new Guid("cd0a0d5e-d883-4ad2-b146-d5cfa653bee1"), "10", "Email58@gmail.com", "FirstName58", false, "LastName58", "123123", "123123", "Student" },
                    { new Guid("d3045b8b-5d3b-408e-aa97-fb53b9e34f55"), "10", "Email67@gmail.com", "FirstName67", false, "LastName67", "123123", "123123", "Student" },
                    { new Guid("d834c5e3-3a82-4aa7-a907-cec6ee6b9cce"), "10", "Email43@gmail.com", "FirstName43", false, "LastName43", "123123", "123123", "Student" },
                    { new Guid("db07aa97-81cb-48d0-b0f0-9822c280c34f"), "10", "Email56@gmail.com", "FirstName56", false, "LastName56", "123123", "123123", "Student" },
                    { new Guid("deb7ab49-9a4b-4756-8ea4-3a68b329bec0"), "10", "Email13@gmail.com", "FirstName13", false, "LastName13", "123123", "123123", "Student" },
                    { new Guid("e25e8a2f-a70c-4ac5-9a9e-4a9ccd3df7c4"), "10", "Email99@gmail.com", "FirstName99", false, "LastName99", "123123", "123123", "Student" },
                    { new Guid("e57980f7-f2e2-4e07-9e4d-a4daacdffc3b"), "10", "Email40@gmail.com", "FirstName40", false, "LastName40", "123123", "123123", "Student" },
                    { new Guid("e66020b5-0604-4d45-9a7c-693f20cfd7b0"), "10", "Email15@gmail.com", "FirstName15", false, "LastName15", "123123", "123123", "Student" },
                    { new Guid("ecd0e615-5588-466e-bce5-2d76861e213d"), "10", "Email30@gmail.com", "FirstName30", false, "LastName30", "123123", "123123", "Student" },
                    { new Guid("ecf9104d-cbcf-40a6-b457-736372a479be"), "10", "Email69@gmail.com", "FirstName69", false, "LastName69", "123123", "123123", "Student" },
                    { new Guid("ed245216-141e-4821-89b8-eabfb2134531"), "10", "Email60@gmail.com", "FirstName60", false, "LastName60", "123123", "123123", "Student" },
                    { new Guid("f17eaf07-e7e4-493a-954d-19dc63b3c9ad"), "10", "Email7@gmail.com", "FirstName7", false, "LastName7", "123123", "123123", "Student" },
                    { new Guid("f4c7012c-9fcb-4bf6-b4de-96218ed23454"), "10", "Email94@gmail.com", "FirstName94", false, "LastName94", "123123", "123123", "Student" },
                    { new Guid("f7b95114-0c63-40d0-94e7-80df90b8b098"), "10", "Email71@gmail.com", "FirstName71", false, "LastName71", "123123", "123123", "Student" },
                    { new Guid("fa92eb63-1dfc-4077-8510-253fb57619f9"), "10", "Email10@gmail.com", "FirstName10", false, "LastName10", "123123", "123123", "Student" },
                    { new Guid("fc41b310-04bf-42b3-b72b-c5257236cd4a"), "10", "Email53@gmail.com", "FirstName53", false, "LastName53", "123123", "123123", "Student" },
                    { new Guid("fec449c4-aaef-42de-8436-75024d001ca0"), "10", "Email73@gmail.com", "FirstName73", false, "LastName73", "123123", "123123", "Student" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_UserId",
                table: "Meetings",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meetings");

            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("02d99124-625b-4c19-a1e1-5e7c68dd0931"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0666846a-def5-4cc8-a077-6583639a44d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0c6f1c4d-25d8-42d9-a4cf-2329196c71f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10a70254-bdf0-4a7d-ab8c-fbd11314f1bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10efbd44-6f1e-4248-8eb5-78c46e0705b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("12157c6e-fa17-4aae-a6ca-420248a05b37"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("133858ef-0fe5-4c6a-a50a-974b1540fcff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1525a95c-29d3-4730-b47e-3724ce73fe05"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1741a198-499d-44b1-9a18-d537d2095947"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a4ca1fa-f47c-44be-a6d4-05c9cbf0c356"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c0fe1f5-c708-4742-b1af-b060f3992670"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1da90569-c05f-45e9-9b99-f4600a53a66b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ece4746-3c02-40f9-8051-8cad6704e9d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("25abf871-9d58-45d2-a6be-bed5a7fd8c9c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("286ae138-ec65-4c84-9c6f-e3c25dfde814"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2980d81f-d8d2-4d44-a19b-6a4e5a20791c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a8c98f0-7397-4b44-9d38-7fb6fdf4db06"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2b207ccc-b6ef-41b9-9f7a-b028e9ef9d11"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2b9fb8ca-0d64-4826-a64b-b7801bae6628"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33a344ed-d8bb-43e9-96f9-1b5e8f9ad12b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("37983300-bc4c-4f5b-88c5-f5a0d6c6b1d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("379f1bb8-7866-4ec3-be24-c962fee55fd2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("390353e3-d850-489f-9f90-78b161616c41"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("396ff2b9-26bb-4408-82a2-902731a21e37"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a740fe1-d92f-4846-aa01-53b72917d818"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3dcf8f48-b7c0-455a-b944-fccb49e24272"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41a6aa81-11f5-4763-bc35-3237dfd774b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42daffba-a4c2-471b-aa1c-c8f649b8f115"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4be76f75-3ee0-4a9c-81fe-b37d99c31cb7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c9c85c3-a6c3-4b7b-b8b5-15a09d09899d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f4c3566-8763-4e75-950e-795972b87b53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5081fc31-537e-449b-8541-8a48ad5e176a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50ee3d02-ef1f-49ac-9331-ed1833c2ce07"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5346ff80-c21e-4331-aeff-d90a995856ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("58f39452-e030-4663-b330-6876b0d8fe8b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ef7b9b0-08b2-4b95-b27b-5942bfdecc8a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f36fd9b-70a2-4370-bf9e-cd65fe24e04d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6125d47a-3d0b-4462-ab3e-2d4e66e52ea3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("65a0b3e4-65cb-490c-b10a-d75ec49609b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("664acfa4-8630-4d9f-8292-fe991a4da1e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("666e34d3-f9b5-4f7a-979f-4cddde1a179d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6702a71b-d352-4624-b2bb-c8d0bfd2872b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c6f1f15-4ae1-4311-b4b7-75f9f034d9c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d9635aa-e0a1-460a-a555-f7bfbcc8d51c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("70db1c40-1eeb-48e0-9092-8ca3db84159f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7809525f-1d6b-4bee-82e5-bddb68138d7e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78665603-1e1b-41a0-bf34-8cb80ff475bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("79f3d1c1-7786-48ef-8ebe-9c35549b768d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7b3849ed-2db3-4b6b-beed-5f246a9d8395"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86d7d320-05d0-44af-a385-62e486b069a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8704bff7-fd2e-4b64-bd4c-756628b5d592"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("88ef378a-1e6c-4c74-8f42-83518104dbe1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8aea45aa-8a93-4a3b-9a70-2a65098fe1f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d88f6cc-6fd9-405e-8798-77f638b87e20"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8da63c40-10b2-4520-93bb-975bd51c03f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9020b07f-8116-4073-907e-b6a19d2b61e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9336bc86-2f14-4353-9235-642f178d9403"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9355f3b7-5ebb-4256-acaa-fde79a8c2f12"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("940a63cd-0100-441d-9e8e-40a17b041257"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("94cb9541-fced-4dc1-ba3c-c53876ddf905"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9584ef93-41c7-4468-9117-fe22e1ed1092"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c7ce40b-e5a5-4cee-a854-ab0e2155c20b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9f0650c8-7729-4c20-aa20-5cb38fe3dfe9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9f4949d4-e10b-4d0f-8591-8a315bf2273c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a39646bb-b10a-4aa9-a095-9d8e8512edc8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a43c05f6-8b84-4ffb-8930-f45a10a5cb0a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a511cbcb-4488-4d40-8b83-9bc38a30afbe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a53dc8a9-a04d-44b4-8cdb-9bbd62fa54d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a901d9fc-2863-402b-b801-1f8a1fcf55ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa63a555-cc64-407d-8a35-b174254655c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad53c2b2-8da8-433c-93c3-c6eaa8c29575"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b284abd0-affe-490b-b3b3-9d79a3be8135"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5e6a695-2456-4be7-bdeb-f91a32f7b868"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b652d514-8745-4cd7-87d1-522a7e09db2e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b96a4fd4-1a37-4a0c-8a3e-d1beb989fe70"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b99abb8a-e596-41bd-bb47-096cf4395b27"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("baa623c1-8a81-4def-a6b6-4b9b7546b57f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bb25545e-e820-47bd-b63d-212d77d738b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bbf220aa-41fa-428e-ad9f-6d04507791be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bc77c420-61fb-4de5-8fa2-4481e2d5be98"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bceb4660-ec26-488d-a882-6966175e7082"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c2fdf3db-7746-4507-8630-1dcffa2568ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca65d9c1-f1a4-40bc-8b15-9514f5d0a690"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd0a0d5e-d883-4ad2-b146-d5cfa653bee1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3045b8b-5d3b-408e-aa97-fb53b9e34f55"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d834c5e3-3a82-4aa7-a907-cec6ee6b9cce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("db07aa97-81cb-48d0-b0f0-9822c280c34f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("deb7ab49-9a4b-4756-8ea4-3a68b329bec0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e25e8a2f-a70c-4ac5-9a9e-4a9ccd3df7c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e57980f7-f2e2-4e07-9e4d-a4daacdffc3b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e66020b5-0604-4d45-9a7c-693f20cfd7b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ecd0e615-5588-466e-bce5-2d76861e213d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ecf9104d-cbcf-40a6-b457-736372a479be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed245216-141e-4821-89b8-eabfb2134531"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f17eaf07-e7e4-493a-954d-19dc63b3c9ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f4c7012c-9fcb-4bf6-b4de-96218ed23454"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f7b95114-0c63-40d0-94e7-80df90b8b098"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa92eb63-1dfc-4077-8510-253fb57619f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc41b310-04bf-42b3-b72b-c5257236cd4a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fec449c4-aaef-42de-8436-75024d001ca0"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);
        }
    }
}
