using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DOTNET_hocmienphi.repository.Migrations
{
    /// <inheritdoc />
    public partial class RemoveMeetingTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meetings");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0501e018-c250-443e-9e69-faf64f623791"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0bcc5798-8b74-460b-9c02-0dc2aee7ad5d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("15351b10-a317-4939-9d08-99d60b39b11d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1706e07e-b7cf-4c99-8294-14c3e9b95894"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1768e4a8-dd3a-4653-b3dc-5a417c76ed2d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("199b4d01-573f-4eb3-aedb-6bd895552ce4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a8f6cd3-8dcd-496e-8795-7ebd05074162"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1befd3cd-6bec-41e4-8c5d-c1c774ca37b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2114501e-7db7-40bf-be71-3b17d3d58db7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a9c3007-6d6e-4f67-bc6b-dfd2cf9f7b1f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2c427b6e-cfa7-4b90-9344-bc52c9bb450e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2eac6858-9d2d-43e9-a6cc-717676a23b70"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("32b04dc1-6c43-4f83-bb4d-e64dd00ae452"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33d87290-4039-48e2-a438-d83c5dc03474"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("348fa082-e384-4025-882c-143357bd1556"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34c0fad2-6e96-4eb0-b620-1821b31eaff6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35fc2031-417f-4531-aa20-7dfa3d4d1e34"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36dfa8d5-e585-49c7-af9e-7a25cb8b8172"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ba43a0f-e9f9-44be-a2b4-5ec0bc5ca946"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3cb84481-3f13-41f5-b8d9-e1eecc74f35c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3d11886c-f192-45b1-8ca2-d3cc40711ed9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e239b25-6ee1-4c54-9caf-96d538d8d80b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ecc20d5-3efc-40d1-b867-c482519baf52"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3f59dfae-f135-42d1-838e-305dcce6d34c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("412b3e12-d158-4237-bc65-840560a0e7b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4207d355-9a86-4465-a6cc-69df00c2d38b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("48b5ff0d-da5a-4a9d-b58e-5a63cdc7ed3f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ec04ff9-f901-4436-8fbe-2bae740ba5e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f703f48-8058-4717-be75-c00b009b7d1a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("512ceb34-24d2-4487-a64b-634142b5d080"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51540255-b7a3-4e61-a6f2-9e74e92eb5e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5555708e-aadd-42ff-aefc-be52cf7b8593"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5888af6e-fb6f-4598-92ea-569a6a8355d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("58e180c7-9a3a-40ab-9f8b-df7516e05c03"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5e332eca-d86f-4e5a-9269-225cfd6832c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f1b5b51-4f80-4685-925f-f81bb5c85e09"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6435fbbb-b240-4349-92d0-796681a347b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("64dd0ee7-d47b-4fcc-bf69-6d61edd0a56b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("696b0b5d-78a2-4e4f-a18f-94d63015f154"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6bf8e044-4670-4749-adff-b24106f75b1f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e63b985-9ad7-4dcb-9c70-aec285b8148b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6fb1ac4d-713c-41aa-a5fc-046734bcd009"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("703ffab8-8ae6-48db-a118-56bb92be5162"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("70f896c6-3f26-48f1-901a-f08011338d56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("76f55a5a-d5db-42d0-9203-7f88abaaf670"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("76fe7e29-c32f-4e3d-a06c-a2a3571611a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78bb8a2e-6e10-4571-9c82-99e2f3c7854b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78bf1856-ede8-40e7-a975-db3bbaccf77a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c083b13-be58-4fca-ad1f-ef7d309e4e1c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d5cc50b-a97b-48c3-8793-ce80351923f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("80eb0192-57aa-44e6-a23c-900ca5588c9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("883b3a09-c196-415e-90e1-5ad8b27aa0c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("893b836c-5859-4c04-afc1-121768edcd13"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ad54848-5ebd-4294-8b99-989a7fecfaec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b7fa11b-a34c-441c-a50c-7ce1c0468576"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8cc374e4-f029-479f-9220-c72012ee9582"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ffacf42-afc3-497a-8076-820e30f745e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9311ad48-e21b-471a-8d8a-3aeee5ac3495"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("93dcdf10-5f9a-4c7b-baba-1b6be1dd4e2d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9af2bb54-90de-43fe-94d0-414f4ddb7d7d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d96bc65-f153-465f-965d-6469ee91ae3b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9f8eeb2c-4992-4f62-b32c-ee439d1458ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a8e77aaa-a916-49aa-8165-9867c6ef17a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abd93f44-b421-4efa-a2c9-31bd6befbf5e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae32ebec-076b-473e-ba34-c1f4f3db0f16"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae595186-a58f-42f0-98a6-0b291449bec1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3eb6701-ffcf-4aac-8d68-f39658bd16e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b4bfac18-f670-4097-af32-9d9f30cb45ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6ed2adf-e135-45e8-8413-d5edc5d1c76e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b99ba7d6-ac28-4556-bc2c-dbb681aefe20"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bdf0ec18-1f43-4d28-91ba-5a33f01225bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be82c598-d203-4884-a3d3-ccc116a17dd9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf026c9f-b552-4d53-a802-7e77f439d0eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c15c3aa0-7747-41c7-b64b-0d32e3cde23c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c58765c3-66d6-4fa5-b41a-5e8f2cd4317f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5a2312c-5617-4277-9aef-e4ff1027b459"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7ce0945-8e8d-4d81-a6f6-8b993ec924ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cae35a44-164c-4262-a1bd-83a57b5d95f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cecb5265-1afe-4c52-8955-bfc6110f209a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d220888e-49b1-47b2-bd23-00eaba7a86e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3cf8311-7b8b-4e8e-ac93-7b780906e9eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7ad36a7-e2bb-4d8f-9bf3-c4ef7de1d729"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc691b69-4303-4c55-b0aa-3d9cd5ea38cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de01b024-7626-470f-b73b-3d58a82ebac9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de72d37f-0778-4c53-80d0-2c47b96af874"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dea10dfc-4ce7-4db1-9daf-1fa7b1d74a58"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dea12766-a202-416f-acf8-0f32897dbbe9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dfb85c8c-fe4f-4d71-aeeb-f8df0159d524"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e08a578e-261f-4682-923c-e0931cfd6e47"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e1aadaf9-937c-4a2a-bd3b-617033b11af4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e2418b47-f1ca-4903-bdeb-a729d63decf2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e28e883b-c277-4a3f-a29d-eb12d2a25824"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3baeb8e-036e-4e3a-999e-b328e08e7183"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e7c41d29-bce6-433b-bcd5-7423af33dc96"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0ba932e-3dcf-4c04-a958-fdb8e73d8742"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f171212d-447b-4ea5-96a9-7a2e4c8a4825"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f58e9bdb-4f48-4118-a387-cbfbbf3a0c79"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f81b9553-28d5-4d66-9637-a87817059205"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fac0c029-8f61-4982-ae0d-5a8605664c29"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe31ac8e-d595-4d18-879a-2e1401675bb2"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "FirstName", "IsDeleted", "LastName", "Password", "Phone", "Role" },
                values: new object[,]
                {
                    { new Guid("01ba6713-f19e-4872-b01a-62df645f5e05"), "10", "Email1@gmail.com", "FirstName1", false, "LastName1", "123123", "123123", "Student" },
                    { new Guid("05579774-4c1c-4ddb-b653-3372c8d6f3f1"), "10", "Email50@gmail.com", "FirstName50", false, "LastName50", "123123", "123123", "Student" },
                    { new Guid("06374b0e-6f9c-499c-a1bc-8a71f033fe95"), "10", "Email99@gmail.com", "FirstName99", false, "LastName99", "123123", "123123", "Student" },
                    { new Guid("071c11c0-f664-4e5b-86d5-dc2c8df384d7"), "10", "Email71@gmail.com", "FirstName71", false, "LastName71", "123123", "123123", "Student" },
                    { new Guid("076620a8-27fd-4eaf-b753-a44f8fe83811"), "10", "Email11@gmail.com", "FirstName11", false, "LastName11", "123123", "123123", "Student" },
                    { new Guid("087fda32-964d-467a-ba14-f58d31458daa"), "10", "Email70@gmail.com", "FirstName70", false, "LastName70", "123123", "123123", "Student" },
                    { new Guid("0a302f66-d864-4423-85aa-9290b327d561"), "10", "Email2@gmail.com", "FirstName2", false, "LastName2", "123123", "123123", "Student" },
                    { new Guid("0ba32d23-8458-40bc-a5cd-f96589f801cc"), "10", "Email95@gmail.com", "FirstName95", false, "LastName95", "123123", "123123", "Student" },
                    { new Guid("0be70daf-5882-4d1e-a15c-8b5543082c9a"), "10", "Email0@gmail.com", "FirstName0", false, "LastName0", "123123", "123123", "Student" },
                    { new Guid("0c674cab-391b-4342-998d-6a7553503e09"), "10", "Email30@gmail.com", "FirstName30", false, "LastName30", "123123", "123123", "Student" },
                    { new Guid("0ceba2b6-f35b-4aff-94f3-8e25019b4588"), "10", "Email23@gmail.com", "FirstName23", false, "LastName23", "123123", "123123", "Student" },
                    { new Guid("0f1086fd-0c09-49ed-9a79-b5998938613d"), "10", "Email69@gmail.com", "FirstName69", false, "LastName69", "123123", "123123", "Student" },
                    { new Guid("1484bc9d-c097-4e3b-ae2f-949e3c8660ab"), "10", "Email72@gmail.com", "FirstName72", false, "LastName72", "123123", "123123", "Student" },
                    { new Guid("1595f079-c951-4234-9a01-2b96b63f39b3"), "10", "Email21@gmail.com", "FirstName21", false, "LastName21", "123123", "123123", "Student" },
                    { new Guid("16d1aa24-98c5-406f-a817-2a187146a720"), "10", "Email49@gmail.com", "FirstName49", false, "LastName49", "123123", "123123", "Student" },
                    { new Guid("191a49ec-240a-4853-b91d-e94fdfa4cbc1"), "10", "Email58@gmail.com", "FirstName58", false, "LastName58", "123123", "123123", "Student" },
                    { new Guid("1cee7c1f-2ddd-46c7-8f8e-372f0fe981db"), "10", "Email27@gmail.com", "FirstName27", false, "LastName27", "123123", "123123", "Student" },
                    { new Guid("1ea13e0d-25b2-4a91-8c45-dd1cd2254ef3"), "10", "Email48@gmail.com", "FirstName48", false, "LastName48", "123123", "123123", "Student" },
                    { new Guid("1ef1dc44-272b-4745-96cd-d4054a74ee7e"), "10", "Email83@gmail.com", "FirstName83", false, "LastName83", "123123", "123123", "Student" },
                    { new Guid("1f74514d-8fa6-40e1-b725-3b6a464688d7"), "10", "Email96@gmail.com", "FirstName96", false, "LastName96", "123123", "123123", "Student" },
                    { new Guid("206e30dd-6952-428f-9c76-dbb746e6bf3e"), "10", "Email81@gmail.com", "FirstName81", false, "LastName81", "123123", "123123", "Student" },
                    { new Guid("2222ff3b-f5d5-4bcd-8161-cd756b177daf"), "10", "Email35@gmail.com", "FirstName35", false, "LastName35", "123123", "123123", "Student" },
                    { new Guid("22f66d30-3541-45ba-ab8c-783dd81282a0"), "10", "Email9@gmail.com", "FirstName9", false, "LastName9", "123123", "123123", "Student" },
                    { new Guid("2849184c-0e77-44b4-84a1-d944e7fa13f0"), "10", "Email15@gmail.com", "FirstName15", false, "LastName15", "123123", "123123", "Student" },
                    { new Guid("28514bce-dd14-441b-8e30-af74ed4a5fcd"), "10", "Email26@gmail.com", "FirstName26", false, "LastName26", "123123", "123123", "Student" },
                    { new Guid("2a4f1efd-6fbc-4625-bb41-ef474668fa1c"), "10", "Email39@gmail.com", "FirstName39", false, "LastName39", "123123", "123123", "Student" },
                    { new Guid("2a8f96e6-2211-4dfb-a877-3f8e83fdd5f1"), "10", "Email3@gmail.com", "FirstName3", false, "LastName3", "123123", "123123", "Student" },
                    { new Guid("2dd63b76-11b3-4fda-a903-f81544860927"), "10", "Email57@gmail.com", "FirstName57", false, "LastName57", "123123", "123123", "Student" },
                    { new Guid("3093aa3d-5f94-4e46-b882-559cacca5e39"), "10", "Email92@gmail.com", "FirstName92", false, "LastName92", "123123", "123123", "Student" },
                    { new Guid("35520e62-6636-421a-b2f7-54cabffc0601"), "10", "Email94@gmail.com", "FirstName94", false, "LastName94", "123123", "123123", "Student" },
                    { new Guid("37c22a71-8d4b-4380-a8e9-7383d6dedf0a"), "10", "Email78@gmail.com", "FirstName78", false, "LastName78", "123123", "123123", "Student" },
                    { new Guid("39d83be3-0f87-462a-b84b-3354fef9a789"), "10", "Email87@gmail.com", "FirstName87", false, "LastName87", "123123", "123123", "Student" },
                    { new Guid("39e26fbf-824f-4ed3-900f-05c5f792c6d1"), "10", "Email6@gmail.com", "FirstName6", false, "LastName6", "123123", "123123", "Student" },
                    { new Guid("3aa72c07-007c-4315-8c8e-05ee1b7f2e84"), "10", "Email86@gmail.com", "FirstName86", false, "LastName86", "123123", "123123", "Student" },
                    { new Guid("40dd4f70-713d-4973-aea4-c4402bdb984d"), "10", "Email54@gmail.com", "FirstName54", false, "LastName54", "123123", "123123", "Student" },
                    { new Guid("44e94cf5-cd76-4740-805b-ff5c6b72c142"), "10", "Email4@gmail.com", "FirstName4", false, "LastName4", "123123", "123123", "Student" },
                    { new Guid("486093f2-e4fd-4bc3-9fe1-46603b667963"), "10", "Email8@gmail.com", "FirstName8", false, "LastName8", "123123", "123123", "Student" },
                    { new Guid("48d04b22-83b6-4cf8-8321-df1a5eb13c06"), "10", "Email53@gmail.com", "FirstName53", false, "LastName53", "123123", "123123", "Student" },
                    { new Guid("4d434ca1-d815-48cb-bc78-7a8f7011554a"), "10", "Email18@gmail.com", "FirstName18", false, "LastName18", "123123", "123123", "Student" },
                    { new Guid("50ca4ca2-3227-4a2d-802e-b23e0bef5d4b"), "10", "Email7@gmail.com", "FirstName7", false, "LastName7", "123123", "123123", "Student" },
                    { new Guid("523b3583-af40-4daf-9b24-dd7c653f531a"), "10", "Email36@gmail.com", "FirstName36", false, "LastName36", "123123", "123123", "Student" },
                    { new Guid("52f87912-b697-4928-b198-462fab275eb8"), "10", "Email33@gmail.com", "FirstName33", false, "LastName33", "123123", "123123", "Student" },
                    { new Guid("540687e6-d0f5-4f1f-b79c-5af3b176f397"), "10", "Email62@gmail.com", "FirstName62", false, "LastName62", "123123", "123123", "Student" },
                    { new Guid("54be4c96-4a06-488e-8d7a-59a377be0522"), "10", "Email74@gmail.com", "FirstName74", false, "LastName74", "123123", "123123", "Student" },
                    { new Guid("56ecbc77-92b4-4440-9a66-8cd70a5bd082"), "10", "Email51@gmail.com", "FirstName51", false, "LastName51", "123123", "123123", "Student" },
                    { new Guid("591eecda-28a1-418a-9a85-3dc7e89541a2"), "10", "Email65@gmail.com", "FirstName65", false, "LastName65", "123123", "123123", "Student" },
                    { new Guid("5d284395-5f08-43ce-964e-3136afce28e8"), "10", "Email25@gmail.com", "FirstName25", false, "LastName25", "123123", "123123", "Student" },
                    { new Guid("5d375162-1dae-4e4f-8b77-dfb014a0e927"), "10", "Email46@gmail.com", "FirstName46", false, "LastName46", "123123", "123123", "Student" },
                    { new Guid("5d88ec62-0b61-4b03-a304-0813c2f9608c"), "10", "Email41@gmail.com", "FirstName41", false, "LastName41", "123123", "123123", "Student" },
                    { new Guid("60194826-4f93-49ac-8bee-5fceff95da80"), "10", "Email79@gmail.com", "FirstName79", false, "LastName79", "123123", "123123", "Student" },
                    { new Guid("64b117b9-0dec-475c-bc79-bad835a8213c"), "10", "Email76@gmail.com", "FirstName76", false, "LastName76", "123123", "123123", "Student" },
                    { new Guid("65da931e-d837-465d-8925-32bba0206d02"), "10", "Email12@gmail.com", "FirstName12", false, "LastName12", "123123", "123123", "Student" },
                    { new Guid("685aa15e-b212-4e2a-bdb6-d64d99c743a0"), "10", "Email60@gmail.com", "FirstName60", false, "LastName60", "123123", "123123", "Student" },
                    { new Guid("68d634d2-b2b5-4c93-a9bc-9d44c6ed2490"), "10", "Email29@gmail.com", "FirstName29", false, "LastName29", "123123", "123123", "Student" },
                    { new Guid("68f435bd-e5f9-44dd-9a29-1e6115d2b84c"), "10", "Email90@gmail.com", "FirstName90", false, "LastName90", "123123", "123123", "Student" },
                    { new Guid("6b16568d-b32c-4ac5-8a12-8cde9cc8a76f"), "10", "Email40@gmail.com", "FirstName40", false, "LastName40", "123123", "123123", "Student" },
                    { new Guid("72e704c8-776d-4573-b494-8f2bc89cd273"), "10", "Email89@gmail.com", "FirstName89", false, "LastName89", "123123", "123123", "Student" },
                    { new Guid("73a495b9-5d40-4876-a0d6-bf983d9dcf2b"), "10", "Email43@gmail.com", "FirstName43", false, "LastName43", "123123", "123123", "Student" },
                    { new Guid("742cff2e-75af-4ffe-99ed-04d59dcf7833"), "10", "Email52@gmail.com", "FirstName52", false, "LastName52", "123123", "123123", "Student" },
                    { new Guid("75701ee2-a6e8-47b2-a67f-53606b4f8813"), "10", "Email55@gmail.com", "FirstName55", false, "LastName55", "123123", "123123", "Student" },
                    { new Guid("783848b3-c7ac-4be9-8c23-9305663bbfd8"), "10", "Email5@gmail.com", "FirstName5", false, "LastName5", "123123", "123123", "Student" },
                    { new Guid("784017b0-bee6-45d6-ad3e-c78bab2d6627"), "10", "Email63@gmail.com", "FirstName63", false, "LastName63", "123123", "123123", "Student" },
                    { new Guid("8c376d3a-5936-4107-9f3e-9656a7ec0b88"), "10", "Email16@gmail.com", "FirstName16", false, "LastName16", "123123", "123123", "Student" },
                    { new Guid("8f9675b2-66a5-4013-a77d-0fc74c682ef5"), "10", "Email56@gmail.com", "FirstName56", false, "LastName56", "123123", "123123", "Student" },
                    { new Guid("932493ae-8a34-4495-8899-a739b7fbd895"), "10", "Email91@gmail.com", "FirstName91", false, "LastName91", "123123", "123123", "Student" },
                    { new Guid("95ccd093-e07a-4c43-8f84-cd7d5fadb5f8"), "10", "Email85@gmail.com", "FirstName85", false, "LastName85", "123123", "123123", "Student" },
                    { new Guid("9b0ff290-40f4-48bf-aebb-a4de5c11f522"), "10", "Email32@gmail.com", "FirstName32", false, "LastName32", "123123", "123123", "Student" },
                    { new Guid("a0e1776c-730d-459a-aefb-050d67bbfab2"), "10", "Email44@gmail.com", "FirstName44", false, "LastName44", "123123", "123123", "Student" },
                    { new Guid("a19fb543-a30c-4592-a254-a91170d15836"), "10", "Email80@gmail.com", "FirstName80", false, "LastName80", "123123", "123123", "Student" },
                    { new Guid("a6c421c7-b034-45c7-b831-ceea12dc65f0"), "10", "Email20@gmail.com", "FirstName20", false, "LastName20", "123123", "123123", "Student" },
                    { new Guid("aacd1c7e-8e1b-41b0-b360-4da8b9d53eab"), "10", "Email64@gmail.com", "FirstName64", false, "LastName64", "123123", "123123", "Student" },
                    { new Guid("ab85bb94-8c55-4d74-87fd-0b3a8cb30e0a"), "10", "Email31@gmail.com", "FirstName31", false, "LastName31", "123123", "123123", "Student" },
                    { new Guid("ae7395c0-d32f-433c-a76b-c8f7ee0271ec"), "10", "Email13@gmail.com", "FirstName13", false, "LastName13", "123123", "123123", "Student" },
                    { new Guid("b0f6d4fa-d34e-4417-8ce4-21537caaa7ae"), "10", "Email93@gmail.com", "FirstName93", false, "LastName93", "123123", "123123", "Student" },
                    { new Guid("b740c423-8b26-4e22-9854-f5fbea7431a6"), "10", "Email66@gmail.com", "FirstName66", false, "LastName66", "123123", "123123", "Student" },
                    { new Guid("b8c9ea9c-5d57-4546-9486-019e5bb8ec4e"), "10", "Email34@gmail.com", "FirstName34", false, "LastName34", "123123", "123123", "Student" },
                    { new Guid("ba5fffa1-0510-4860-bf60-e01e0f5c9a95"), "10", "Email98@gmail.com", "FirstName98", false, "LastName98", "123123", "123123", "Student" },
                    { new Guid("bbade27a-719b-4e6c-800e-075e8e13dc9d"), "10", "Email24@gmail.com", "FirstName24", false, "LastName24", "123123", "123123", "Student" },
                    { new Guid("c14fa471-3551-4426-9c63-30ccd64ac03c"), "10", "Email68@gmail.com", "FirstName68", false, "LastName68", "123123", "123123", "Student" },
                    { new Guid("c15bad87-868b-45dc-b18c-4ce543e7c560"), "10", "Email37@gmail.com", "FirstName37", false, "LastName37", "123123", "123123", "Student" },
                    { new Guid("c1762971-c884-4bab-a799-bf8969c6b720"), "10", "Email77@gmail.com", "FirstName77", false, "LastName77", "123123", "123123", "Student" },
                    { new Guid("cb210f79-5497-437f-83b6-9507eacc197a"), "10", "Email67@gmail.com", "FirstName67", false, "LastName67", "123123", "123123", "Student" },
                    { new Guid("cc85a273-6391-4132-9da3-70009982e286"), "10", "Email59@gmail.com", "FirstName59", false, "LastName59", "123123", "123123", "Student" },
                    { new Guid("cd8acdb3-0e2f-4e2a-bc84-e7558585a1ee"), "10", "Email28@gmail.com", "FirstName28", false, "LastName28", "123123", "123123", "Student" },
                    { new Guid("cdf1f3b0-194e-4c40-9020-f72bd3fb2acd"), "10", "Email47@gmail.com", "FirstName47", false, "LastName47", "123123", "123123", "Student" },
                    { new Guid("cf725cbf-6cbc-499e-bbc8-70fd35169ada"), "10", "Email82@gmail.com", "FirstName82", false, "LastName82", "123123", "123123", "Student" },
                    { new Guid("cf7cca50-3969-4e57-a444-78da5e9cc492"), "10", "Email22@gmail.com", "FirstName22", false, "LastName22", "123123", "123123", "Student" },
                    { new Guid("d37f9274-0df2-4551-9e57-d0f63d16b991"), "10", "Email88@gmail.com", "FirstName88", false, "LastName88", "123123", "123123", "Student" },
                    { new Guid("d7db4acb-d2f3-4052-bd31-5a7964c24927"), "10", "Email14@gmail.com", "FirstName14", false, "LastName14", "123123", "123123", "Student" },
                    { new Guid("d8e249a7-8bbe-4d33-9f5f-474780c8f57a"), "10", "Email38@gmail.com", "FirstName38", false, "LastName38", "123123", "123123", "Student" },
                    { new Guid("dbb3e065-c0c7-4c0b-a620-a89739d9317e"), "10", "Email45@gmail.com", "FirstName45", false, "LastName45", "123123", "123123", "Student" },
                    { new Guid("e280d18e-e234-4dbd-bf83-03c0b16b5702"), "10", "Email73@gmail.com", "FirstName73", false, "LastName73", "123123", "123123", "Student" },
                    { new Guid("e39343b1-36ba-447f-8846-e9f68efe21a3"), "10", "Email17@gmail.com", "FirstName17", false, "LastName17", "123123", "123123", "Student" },
                    { new Guid("eb1b03f1-435b-4b12-af1a-9203fa9d6363"), "10", "Email19@gmail.com", "FirstName19", false, "LastName19", "123123", "123123", "Student" },
                    { new Guid("f1dbb672-fdc2-46bc-9d24-3afde36b8424"), "10", "Email97@gmail.com", "FirstName97", false, "LastName97", "123123", "123123", "Student" },
                    { new Guid("f44784ae-3f67-4b8f-947a-5be815742d60"), "10", "Email10@gmail.com", "FirstName10", false, "LastName10", "123123", "123123", "Student" },
                    { new Guid("f4b54438-cf18-46c7-a62f-7aa6b7357529"), "10", "Email84@gmail.com", "FirstName84", false, "LastName84", "123123", "123123", "Student" },
                    { new Guid("f8fba9ce-7d16-4396-bbbd-f982edca904a"), "10", "Email75@gmail.com", "FirstName75", false, "LastName75", "123123", "123123", "Student" },
                    { new Guid("f960f3f2-7f65-4f11-85ab-f88bff5775f2"), "10", "Email61@gmail.com", "FirstName61", false, "LastName61", "123123", "123123", "Student" },
                    { new Guid("fc0423c0-6b40-4ece-8d30-3ff40409b773"), "10", "Email42@gmail.com", "FirstName42", false, "LastName42", "123123", "123123", "Student" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("01ba6713-f19e-4872-b01a-62df645f5e05"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("05579774-4c1c-4ddb-b653-3372c8d6f3f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("06374b0e-6f9c-499c-a1bc-8a71f033fe95"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("071c11c0-f664-4e5b-86d5-dc2c8df384d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("076620a8-27fd-4eaf-b753-a44f8fe83811"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("087fda32-964d-467a-ba14-f58d31458daa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0a302f66-d864-4423-85aa-9290b327d561"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ba32d23-8458-40bc-a5cd-f96589f801cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0be70daf-5882-4d1e-a15c-8b5543082c9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0c674cab-391b-4342-998d-6a7553503e09"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ceba2b6-f35b-4aff-94f3-8e25019b4588"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f1086fd-0c09-49ed-9a79-b5998938613d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1484bc9d-c097-4e3b-ae2f-949e3c8660ab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1595f079-c951-4234-9a01-2b96b63f39b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("16d1aa24-98c5-406f-a817-2a187146a720"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("191a49ec-240a-4853-b91d-e94fdfa4cbc1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1cee7c1f-2ddd-46c7-8f8e-372f0fe981db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ea13e0d-25b2-4a91-8c45-dd1cd2254ef3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ef1dc44-272b-4745-96cd-d4054a74ee7e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1f74514d-8fa6-40e1-b725-3b6a464688d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("206e30dd-6952-428f-9c76-dbb746e6bf3e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2222ff3b-f5d5-4bcd-8161-cd756b177daf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22f66d30-3541-45ba-ab8c-783dd81282a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2849184c-0e77-44b4-84a1-d944e7fa13f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("28514bce-dd14-441b-8e30-af74ed4a5fcd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a4f1efd-6fbc-4625-bb41-ef474668fa1c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a8f96e6-2211-4dfb-a877-3f8e83fdd5f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2dd63b76-11b3-4fda-a903-f81544860927"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3093aa3d-5f94-4e46-b882-559cacca5e39"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35520e62-6636-421a-b2f7-54cabffc0601"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("37c22a71-8d4b-4380-a8e9-7383d6dedf0a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39d83be3-0f87-462a-b84b-3354fef9a789"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39e26fbf-824f-4ed3-900f-05c5f792c6d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3aa72c07-007c-4315-8c8e-05ee1b7f2e84"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40dd4f70-713d-4973-aea4-c4402bdb984d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44e94cf5-cd76-4740-805b-ff5c6b72c142"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("486093f2-e4fd-4bc3-9fe1-46603b667963"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("48d04b22-83b6-4cf8-8321-df1a5eb13c06"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4d434ca1-d815-48cb-bc78-7a8f7011554a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50ca4ca2-3227-4a2d-802e-b23e0bef5d4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("523b3583-af40-4daf-9b24-dd7c653f531a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("52f87912-b697-4928-b198-462fab275eb8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("540687e6-d0f5-4f1f-b79c-5af3b176f397"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("54be4c96-4a06-488e-8d7a-59a377be0522"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56ecbc77-92b4-4440-9a66-8cd70a5bd082"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("591eecda-28a1-418a-9a85-3dc7e89541a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d284395-5f08-43ce-964e-3136afce28e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d375162-1dae-4e4f-8b77-dfb014a0e927"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d88ec62-0b61-4b03-a304-0813c2f9608c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("60194826-4f93-49ac-8bee-5fceff95da80"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("64b117b9-0dec-475c-bc79-bad835a8213c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("65da931e-d837-465d-8925-32bba0206d02"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("685aa15e-b212-4e2a-bdb6-d64d99c743a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68d634d2-b2b5-4c93-a9bc-9d44c6ed2490"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68f435bd-e5f9-44dd-9a29-1e6115d2b84c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6b16568d-b32c-4ac5-8a12-8cde9cc8a76f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72e704c8-776d-4573-b494-8f2bc89cd273"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("73a495b9-5d40-4876-a0d6-bf983d9dcf2b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("742cff2e-75af-4ffe-99ed-04d59dcf7833"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("75701ee2-a6e8-47b2-a67f-53606b4f8813"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("783848b3-c7ac-4be9-8c23-9305663bbfd8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("784017b0-bee6-45d6-ad3e-c78bab2d6627"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8c376d3a-5936-4107-9f3e-9656a7ec0b88"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f9675b2-66a5-4013-a77d-0fc74c682ef5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("932493ae-8a34-4495-8899-a739b7fbd895"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95ccd093-e07a-4c43-8f84-cd7d5fadb5f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b0ff290-40f4-48bf-aebb-a4de5c11f522"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0e1776c-730d-459a-aefb-050d67bbfab2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a19fb543-a30c-4592-a254-a91170d15836"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6c421c7-b034-45c7-b831-ceea12dc65f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aacd1c7e-8e1b-41b0-b360-4da8b9d53eab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ab85bb94-8c55-4d74-87fd-0b3a8cb30e0a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae7395c0-d32f-433c-a76b-c8f7ee0271ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0f6d4fa-d34e-4417-8ce4-21537caaa7ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b740c423-8b26-4e22-9854-f5fbea7431a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8c9ea9c-5d57-4546-9486-019e5bb8ec4e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ba5fffa1-0510-4860-bf60-e01e0f5c9a95"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bbade27a-719b-4e6c-800e-075e8e13dc9d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c14fa471-3551-4426-9c63-30ccd64ac03c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c15bad87-868b-45dc-b18c-4ce543e7c560"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c1762971-c884-4bab-a799-bf8969c6b720"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb210f79-5497-437f-83b6-9507eacc197a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cc85a273-6391-4132-9da3-70009982e286"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd8acdb3-0e2f-4e2a-bc84-e7558585a1ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cdf1f3b0-194e-4c40-9020-f72bd3fb2acd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cf725cbf-6cbc-499e-bbc8-70fd35169ada"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cf7cca50-3969-4e57-a444-78da5e9cc492"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d37f9274-0df2-4551-9e57-d0f63d16b991"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7db4acb-d2f3-4052-bd31-5a7964c24927"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8e249a7-8bbe-4d33-9f5f-474780c8f57a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dbb3e065-c0c7-4c0b-a620-a89739d9317e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e280d18e-e234-4dbd-bf83-03c0b16b5702"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e39343b1-36ba-447f-8846-e9f68efe21a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb1b03f1-435b-4b12-af1a-9203fa9d6363"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f1dbb672-fdc2-46bc-9d24-3afde36b8424"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f44784ae-3f67-4b8f-947a-5be815742d60"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f4b54438-cf18-46c7-a62f-7aa6b7357529"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f8fba9ce-7d16-4396-bbbd-f982edca904a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f960f3f2-7f65-4f11-85ab-f88bff5775f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc0423c0-6b40-4ece-8d30-3ff40409b773"));

            migrationBuilder.CreateTable(
                name: "Meetings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false)
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
                    { new Guid("0501e018-c250-443e-9e69-faf64f623791"), "10", "Email22@gmail.com", "FirstName22", false, "LastName22", "123123", "123123", "Student" },
                    { new Guid("0bcc5798-8b74-460b-9c02-0dc2aee7ad5d"), "10", "Email28@gmail.com", "FirstName28", false, "LastName28", "123123", "123123", "Student" },
                    { new Guid("15351b10-a317-4939-9d08-99d60b39b11d"), "10", "Email75@gmail.com", "FirstName75", false, "LastName75", "123123", "123123", "Student" },
                    { new Guid("1706e07e-b7cf-4c99-8294-14c3e9b95894"), "10", "Email26@gmail.com", "FirstName26", false, "LastName26", "123123", "123123", "Student" },
                    { new Guid("1768e4a8-dd3a-4653-b3dc-5a417c76ed2d"), "10", "Email98@gmail.com", "FirstName98", false, "LastName98", "123123", "123123", "Student" },
                    { new Guid("199b4d01-573f-4eb3-aedb-6bd895552ce4"), "10", "Email54@gmail.com", "FirstName54", false, "LastName54", "123123", "123123", "Student" },
                    { new Guid("1a8f6cd3-8dcd-496e-8795-7ebd05074162"), "10", "Email82@gmail.com", "FirstName82", false, "LastName82", "123123", "123123", "Student" },
                    { new Guid("1befd3cd-6bec-41e4-8c5d-c1c774ca37b4"), "10", "Email43@gmail.com", "FirstName43", false, "LastName43", "123123", "123123", "Student" },
                    { new Guid("2114501e-7db7-40bf-be71-3b17d3d58db7"), "10", "Email19@gmail.com", "FirstName19", false, "LastName19", "123123", "123123", "Student" },
                    { new Guid("2a9c3007-6d6e-4f67-bc6b-dfd2cf9f7b1f"), "10", "Email44@gmail.com", "FirstName44", false, "LastName44", "123123", "123123", "Student" },
                    { new Guid("2c427b6e-cfa7-4b90-9344-bc52c9bb450e"), "10", "Email52@gmail.com", "FirstName52", false, "LastName52", "123123", "123123", "Student" },
                    { new Guid("2eac6858-9d2d-43e9-a6cc-717676a23b70"), "10", "Email88@gmail.com", "FirstName88", false, "LastName88", "123123", "123123", "Student" },
                    { new Guid("32b04dc1-6c43-4f83-bb4d-e64dd00ae452"), "10", "Email53@gmail.com", "FirstName53", false, "LastName53", "123123", "123123", "Student" },
                    { new Guid("33d87290-4039-48e2-a438-d83c5dc03474"), "10", "Email1@gmail.com", "FirstName1", false, "LastName1", "123123", "123123", "Student" },
                    { new Guid("348fa082-e384-4025-882c-143357bd1556"), "10", "Email89@gmail.com", "FirstName89", false, "LastName89", "123123", "123123", "Student" },
                    { new Guid("34c0fad2-6e96-4eb0-b620-1821b31eaff6"), "10", "Email97@gmail.com", "FirstName97", false, "LastName97", "123123", "123123", "Student" },
                    { new Guid("35fc2031-417f-4531-aa20-7dfa3d4d1e34"), "10", "Email25@gmail.com", "FirstName25", false, "LastName25", "123123", "123123", "Student" },
                    { new Guid("36dfa8d5-e585-49c7-af9e-7a25cb8b8172"), "10", "Email35@gmail.com", "FirstName35", false, "LastName35", "123123", "123123", "Student" },
                    { new Guid("3ba43a0f-e9f9-44be-a2b4-5ec0bc5ca946"), "10", "Email85@gmail.com", "FirstName85", false, "LastName85", "123123", "123123", "Student" },
                    { new Guid("3cb84481-3f13-41f5-b8d9-e1eecc74f35c"), "10", "Email33@gmail.com", "FirstName33", false, "LastName33", "123123", "123123", "Student" },
                    { new Guid("3d11886c-f192-45b1-8ca2-d3cc40711ed9"), "10", "Email37@gmail.com", "FirstName37", false, "LastName37", "123123", "123123", "Student" },
                    { new Guid("3e239b25-6ee1-4c54-9caf-96d538d8d80b"), "10", "Email38@gmail.com", "FirstName38", false, "LastName38", "123123", "123123", "Student" },
                    { new Guid("3ecc20d5-3efc-40d1-b867-c482519baf52"), "10", "Email3@gmail.com", "FirstName3", false, "LastName3", "123123", "123123", "Student" },
                    { new Guid("3f59dfae-f135-42d1-838e-305dcce6d34c"), "10", "Email0@gmail.com", "FirstName0", false, "LastName0", "123123", "123123", "Student" },
                    { new Guid("412b3e12-d158-4237-bc65-840560a0e7b9"), "10", "Email2@gmail.com", "FirstName2", false, "LastName2", "123123", "123123", "Student" },
                    { new Guid("4207d355-9a86-4465-a6cc-69df00c2d38b"), "10", "Email42@gmail.com", "FirstName42", false, "LastName42", "123123", "123123", "Student" },
                    { new Guid("48b5ff0d-da5a-4a9d-b58e-5a63cdc7ed3f"), "10", "Email24@gmail.com", "FirstName24", false, "LastName24", "123123", "123123", "Student" },
                    { new Guid("4ec04ff9-f901-4436-8fbe-2bae740ba5e9"), "10", "Email17@gmail.com", "FirstName17", false, "LastName17", "123123", "123123", "Student" },
                    { new Guid("4f703f48-8058-4717-be75-c00b009b7d1a"), "10", "Email36@gmail.com", "FirstName36", false, "LastName36", "123123", "123123", "Student" },
                    { new Guid("512ceb34-24d2-4487-a64b-634142b5d080"), "10", "Email18@gmail.com", "FirstName18", false, "LastName18", "123123", "123123", "Student" },
                    { new Guid("51540255-b7a3-4e61-a6f2-9e74e92eb5e7"), "10", "Email87@gmail.com", "FirstName87", false, "LastName87", "123123", "123123", "Student" },
                    { new Guid("5555708e-aadd-42ff-aefc-be52cf7b8593"), "10", "Email99@gmail.com", "FirstName99", false, "LastName99", "123123", "123123", "Student" },
                    { new Guid("5888af6e-fb6f-4598-92ea-569a6a8355d6"), "10", "Email81@gmail.com", "FirstName81", false, "LastName81", "123123", "123123", "Student" },
                    { new Guid("58e180c7-9a3a-40ab-9f8b-df7516e05c03"), "10", "Email96@gmail.com", "FirstName96", false, "LastName96", "123123", "123123", "Student" },
                    { new Guid("5e332eca-d86f-4e5a-9269-225cfd6832c1"), "10", "Email56@gmail.com", "FirstName56", false, "LastName56", "123123", "123123", "Student" },
                    { new Guid("5f1b5b51-4f80-4685-925f-f81bb5c85e09"), "10", "Email5@gmail.com", "FirstName5", false, "LastName5", "123123", "123123", "Student" },
                    { new Guid("6435fbbb-b240-4349-92d0-796681a347b0"), "10", "Email63@gmail.com", "FirstName63", false, "LastName63", "123123", "123123", "Student" },
                    { new Guid("64dd0ee7-d47b-4fcc-bf69-6d61edd0a56b"), "10", "Email20@gmail.com", "FirstName20", false, "LastName20", "123123", "123123", "Student" },
                    { new Guid("696b0b5d-78a2-4e4f-a18f-94d63015f154"), "10", "Email4@gmail.com", "FirstName4", false, "LastName4", "123123", "123123", "Student" },
                    { new Guid("6bf8e044-4670-4749-adff-b24106f75b1f"), "10", "Email65@gmail.com", "FirstName65", false, "LastName65", "123123", "123123", "Student" },
                    { new Guid("6e63b985-9ad7-4dcb-9c70-aec285b8148b"), "10", "Email31@gmail.com", "FirstName31", false, "LastName31", "123123", "123123", "Student" },
                    { new Guid("6fb1ac4d-713c-41aa-a5fc-046734bcd009"), "10", "Email16@gmail.com", "FirstName16", false, "LastName16", "123123", "123123", "Student" },
                    { new Guid("703ffab8-8ae6-48db-a118-56bb92be5162"), "10", "Email90@gmail.com", "FirstName90", false, "LastName90", "123123", "123123", "Student" },
                    { new Guid("70f896c6-3f26-48f1-901a-f08011338d56"), "10", "Email50@gmail.com", "FirstName50", false, "LastName50", "123123", "123123", "Student" },
                    { new Guid("76f55a5a-d5db-42d0-9203-7f88abaaf670"), "10", "Email68@gmail.com", "FirstName68", false, "LastName68", "123123", "123123", "Student" },
                    { new Guid("76fe7e29-c32f-4e3d-a06c-a2a3571611a9"), "10", "Email60@gmail.com", "FirstName60", false, "LastName60", "123123", "123123", "Student" },
                    { new Guid("78bb8a2e-6e10-4571-9c82-99e2f3c7854b"), "10", "Email29@gmail.com", "FirstName29", false, "LastName29", "123123", "123123", "Student" },
                    { new Guid("78bf1856-ede8-40e7-a975-db3bbaccf77a"), "10", "Email58@gmail.com", "FirstName58", false, "LastName58", "123123", "123123", "Student" },
                    { new Guid("7c083b13-be58-4fca-ad1f-ef7d309e4e1c"), "10", "Email46@gmail.com", "FirstName46", false, "LastName46", "123123", "123123", "Student" },
                    { new Guid("7d5cc50b-a97b-48c3-8793-ce80351923f5"), "10", "Email12@gmail.com", "FirstName12", false, "LastName12", "123123", "123123", "Student" },
                    { new Guid("80eb0192-57aa-44e6-a23c-900ca5588c9a"), "10", "Email48@gmail.com", "FirstName48", false, "LastName48", "123123", "123123", "Student" },
                    { new Guid("883b3a09-c196-415e-90e1-5ad8b27aa0c3"), "10", "Email32@gmail.com", "FirstName32", false, "LastName32", "123123", "123123", "Student" },
                    { new Guid("893b836c-5859-4c04-afc1-121768edcd13"), "10", "Email72@gmail.com", "FirstName72", false, "LastName72", "123123", "123123", "Student" },
                    { new Guid("8ad54848-5ebd-4294-8b99-989a7fecfaec"), "10", "Email7@gmail.com", "FirstName7", false, "LastName7", "123123", "123123", "Student" },
                    { new Guid("8b7fa11b-a34c-441c-a50c-7ce1c0468576"), "10", "Email92@gmail.com", "FirstName92", false, "LastName92", "123123", "123123", "Student" },
                    { new Guid("8cc374e4-f029-479f-9220-c72012ee9582"), "10", "Email62@gmail.com", "FirstName62", false, "LastName62", "123123", "123123", "Student" },
                    { new Guid("8ffacf42-afc3-497a-8076-820e30f745e3"), "10", "Email13@gmail.com", "FirstName13", false, "LastName13", "123123", "123123", "Student" },
                    { new Guid("9311ad48-e21b-471a-8d8a-3aeee5ac3495"), "10", "Email78@gmail.com", "FirstName78", false, "LastName78", "123123", "123123", "Student" },
                    { new Guid("93dcdf10-5f9a-4c7b-baba-1b6be1dd4e2d"), "10", "Email95@gmail.com", "FirstName95", false, "LastName95", "123123", "123123", "Student" },
                    { new Guid("9af2bb54-90de-43fe-94d0-414f4ddb7d7d"), "10", "Email71@gmail.com", "FirstName71", false, "LastName71", "123123", "123123", "Student" },
                    { new Guid("9d96bc65-f153-465f-965d-6469ee91ae3b"), "10", "Email94@gmail.com", "FirstName94", false, "LastName94", "123123", "123123", "Student" },
                    { new Guid("9f8eeb2c-4992-4f62-b32c-ee439d1458ca"), "10", "Email14@gmail.com", "FirstName14", false, "LastName14", "123123", "123123", "Student" },
                    { new Guid("a8e77aaa-a916-49aa-8165-9867c6ef17a1"), "10", "Email55@gmail.com", "FirstName55", false, "LastName55", "123123", "123123", "Student" },
                    { new Guid("abd93f44-b421-4efa-a2c9-31bd6befbf5e"), "10", "Email79@gmail.com", "FirstName79", false, "LastName79", "123123", "123123", "Student" },
                    { new Guid("ae32ebec-076b-473e-ba34-c1f4f3db0f16"), "10", "Email74@gmail.com", "FirstName74", false, "LastName74", "123123", "123123", "Student" },
                    { new Guid("ae595186-a58f-42f0-98a6-0b291449bec1"), "10", "Email69@gmail.com", "FirstName69", false, "LastName69", "123123", "123123", "Student" },
                    { new Guid("b3eb6701-ffcf-4aac-8d68-f39658bd16e4"), "10", "Email70@gmail.com", "FirstName70", false, "LastName70", "123123", "123123", "Student" },
                    { new Guid("b4bfac18-f670-4097-af32-9d9f30cb45ff"), "10", "Email47@gmail.com", "FirstName47", false, "LastName47", "123123", "123123", "Student" },
                    { new Guid("b6ed2adf-e135-45e8-8413-d5edc5d1c76e"), "10", "Email86@gmail.com", "FirstName86", false, "LastName86", "123123", "123123", "Student" },
                    { new Guid("b99ba7d6-ac28-4556-bc2c-dbb681aefe20"), "10", "Email80@gmail.com", "FirstName80", false, "LastName80", "123123", "123123", "Student" },
                    { new Guid("bdf0ec18-1f43-4d28-91ba-5a33f01225bb"), "10", "Email27@gmail.com", "FirstName27", false, "LastName27", "123123", "123123", "Student" },
                    { new Guid("be82c598-d203-4884-a3d3-ccc116a17dd9"), "10", "Email30@gmail.com", "FirstName30", false, "LastName30", "123123", "123123", "Student" },
                    { new Guid("bf026c9f-b552-4d53-a802-7e77f439d0eb"), "10", "Email61@gmail.com", "FirstName61", false, "LastName61", "123123", "123123", "Student" },
                    { new Guid("c15c3aa0-7747-41c7-b64b-0d32e3cde23c"), "10", "Email10@gmail.com", "FirstName10", false, "LastName10", "123123", "123123", "Student" },
                    { new Guid("c58765c3-66d6-4fa5-b41a-5e8f2cd4317f"), "10", "Email91@gmail.com", "FirstName91", false, "LastName91", "123123", "123123", "Student" },
                    { new Guid("c5a2312c-5617-4277-9aef-e4ff1027b459"), "10", "Email73@gmail.com", "FirstName73", false, "LastName73", "123123", "123123", "Student" },
                    { new Guid("c7ce0945-8e8d-4d81-a6f6-8b993ec924ec"), "10", "Email57@gmail.com", "FirstName57", false, "LastName57", "123123", "123123", "Student" },
                    { new Guid("cae35a44-164c-4262-a1bd-83a57b5d95f1"), "10", "Email45@gmail.com", "FirstName45", false, "LastName45", "123123", "123123", "Student" },
                    { new Guid("cecb5265-1afe-4c52-8955-bfc6110f209a"), "10", "Email66@gmail.com", "FirstName66", false, "LastName66", "123123", "123123", "Student" },
                    { new Guid("d220888e-49b1-47b2-bd23-00eaba7a86e6"), "10", "Email9@gmail.com", "FirstName9", false, "LastName9", "123123", "123123", "Student" },
                    { new Guid("d3cf8311-7b8b-4e8e-ac93-7b780906e9eb"), "10", "Email6@gmail.com", "FirstName6", false, "LastName6", "123123", "123123", "Student" },
                    { new Guid("d7ad36a7-e2bb-4d8f-9bf3-c4ef7de1d729"), "10", "Email34@gmail.com", "FirstName34", false, "LastName34", "123123", "123123", "Student" },
                    { new Guid("dc691b69-4303-4c55-b0aa-3d9cd5ea38cf"), "10", "Email77@gmail.com", "FirstName77", false, "LastName77", "123123", "123123", "Student" },
                    { new Guid("de01b024-7626-470f-b73b-3d58a82ebac9"), "10", "Email67@gmail.com", "FirstName67", false, "LastName67", "123123", "123123", "Student" },
                    { new Guid("de72d37f-0778-4c53-80d0-2c47b96af874"), "10", "Email21@gmail.com", "FirstName21", false, "LastName21", "123123", "123123", "Student" },
                    { new Guid("dea10dfc-4ce7-4db1-9daf-1fa7b1d74a58"), "10", "Email84@gmail.com", "FirstName84", false, "LastName84", "123123", "123123", "Student" },
                    { new Guid("dea12766-a202-416f-acf8-0f32897dbbe9"), "10", "Email8@gmail.com", "FirstName8", false, "LastName8", "123123", "123123", "Student" },
                    { new Guid("dfb85c8c-fe4f-4d71-aeeb-f8df0159d524"), "10", "Email64@gmail.com", "FirstName64", false, "LastName64", "123123", "123123", "Student" },
                    { new Guid("e08a578e-261f-4682-923c-e0931cfd6e47"), "10", "Email39@gmail.com", "FirstName39", false, "LastName39", "123123", "123123", "Student" },
                    { new Guid("e1aadaf9-937c-4a2a-bd3b-617033b11af4"), "10", "Email49@gmail.com", "FirstName49", false, "LastName49", "123123", "123123", "Student" },
                    { new Guid("e2418b47-f1ca-4903-bdeb-a729d63decf2"), "10", "Email40@gmail.com", "FirstName40", false, "LastName40", "123123", "123123", "Student" },
                    { new Guid("e28e883b-c277-4a3f-a29d-eb12d2a25824"), "10", "Email59@gmail.com", "FirstName59", false, "LastName59", "123123", "123123", "Student" },
                    { new Guid("e3baeb8e-036e-4e3a-999e-b328e08e7183"), "10", "Email76@gmail.com", "FirstName76", false, "LastName76", "123123", "123123", "Student" },
                    { new Guid("e7c41d29-bce6-433b-bcd5-7423af33dc96"), "10", "Email51@gmail.com", "FirstName51", false, "LastName51", "123123", "123123", "Student" },
                    { new Guid("f0ba932e-3dcf-4c04-a958-fdb8e73d8742"), "10", "Email41@gmail.com", "FirstName41", false, "LastName41", "123123", "123123", "Student" },
                    { new Guid("f171212d-447b-4ea5-96a9-7a2e4c8a4825"), "10", "Email15@gmail.com", "FirstName15", false, "LastName15", "123123", "123123", "Student" },
                    { new Guid("f58e9bdb-4f48-4118-a387-cbfbbf3a0c79"), "10", "Email93@gmail.com", "FirstName93", false, "LastName93", "123123", "123123", "Student" },
                    { new Guid("f81b9553-28d5-4d66-9637-a87817059205"), "10", "Email23@gmail.com", "FirstName23", false, "LastName23", "123123", "123123", "Student" },
                    { new Guid("fac0c029-8f61-4982-ae0d-5a8605664c29"), "10", "Email83@gmail.com", "FirstName83", false, "LastName83", "123123", "123123", "Student" },
                    { new Guid("fe31ac8e-d595-4d18-879a-2e1401675bb2"), "10", "Email11@gmail.com", "FirstName11", false, "LastName11", "123123", "123123", "Student" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_UserId",
                table: "Meetings",
                column: "UserId");
        }
    }
}
