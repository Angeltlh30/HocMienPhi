using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DOTNET_hocmienphi.repository.Migrations
{
    /// <inheritdoc />
    public partial class ChangeMentorFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00c3da93-57d5-4e0b-b774-b4bfb1160f2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0136a24b-43ff-4f33-82e7-5ce70a819cbd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b0699cc-b726-41bf-afef-f55554fcc6ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("100464ec-ede3-42b0-8a1c-24bd4084fc38"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("115eb520-d368-4b71-8e03-917a5ae23d7e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("12810f96-a4b9-469c-8439-e8d8bb5b81c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("14ca906c-64d8-4342-a372-b0c640e6303f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("181162ce-31b9-4d89-ac96-b6c34f50205c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c9abaa1-b81f-48f4-894f-233201dd84a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1cd237a7-2753-4055-beff-edbeb2131ca9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1cf3d78b-ac90-4cdc-ad6c-8a6f98d763d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d7c5dd5-106b-4f83-a798-9c9d70c89ee5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e95f099-4e08-4d80-8e9f-409c106e5e0c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1fe2fbb1-b547-422a-9cae-7ce4c99ab301"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20dfc7b6-1578-4d3c-b6b3-10e3685230ab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22114a16-85f4-4ddf-9d29-1ae90cef46c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22e71c2c-2730-46f7-b4c6-eca061f554fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2573022b-2526-4986-98fd-31fa0e018a2c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("28b0c24e-e97d-4487-9285-1c056a8c44af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2dfe3836-86df-4e0b-a6be-1dfc98c1e245"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("307e22b8-c7cb-4629-a7dc-54f1bad5a115"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("355e0108-3166-4f91-9a96-eaffa08fb6ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3f4973ae-fc7c-40a9-aaf7-9554862186bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3fabf8ff-b653-4204-8e10-de0c013be95d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45008283-b464-47e3-86bb-b696a4baaf4e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("48d0f8c9-ae04-4683-963e-5207183519bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4bb53bde-7c6b-45c4-a072-4a3d4816472c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4bb5bcab-ab74-41e6-9349-98a2497d6284"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f916359-f8b2-417c-a249-e34ea6f8ae22"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("522b556a-8c9e-4435-adb4-26138c097da6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("556e15b3-596a-42bc-ac40-c15bed1a3f7f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("57bd49ce-a36d-4d87-937a-852aa246ec36"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5bdc2356-1bb6-48a3-8a74-5775c532cfd9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5bf2b4d2-d692-4839-ab77-1659f7b7179c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d35b81e-e1e2-4a87-ac28-54af371c5fbd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ee183ac-97bd-473f-9e24-afb2dacb4ffe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6426d2c2-04c4-42ef-ad0f-b9583e0a6246"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68c7995a-dd78-4691-91a6-c99a19fa0336"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f86cf32-0b1a-44c4-92de-5aeffdc64695"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71b398d7-a5e2-4ade-80b0-6b8e6e67308b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74062231-04e7-4628-973c-230fdf16819b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7510be2e-c751-485c-b64c-4ad8496a3f8c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("762deec3-5323-488f-be42-57841bd186b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7667d5a6-1bc6-448c-80b5-218d7ba6ed48"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7748be6f-2b36-4df8-be91-2391cbc1d98c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7b32e7ef-04c7-4ca2-a128-e1be30a7ab9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("819dcad3-d5d7-4a6d-b97a-049e59b190c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86507b3d-ddbc-49a7-87bd-47b7502bdb56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f4d8940-a05d-4c11-8673-56b4ab6d3a73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f59f6b7-d846-4b17-84c0-a9c9da6d5a36"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("934bf105-9ff1-4944-bec8-9823e59938b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("967e28ad-b990-4441-ab17-e6b306f62e52"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96fac293-d0c9-4a78-ac24-4bafc408cc03"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("982b560d-387e-45a0-a40c-c0fe3178c357"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9acab135-437e-47c8-8a2b-302eeb2f2111"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c14ba75-e53e-4df8-85f2-d54ab0400100"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9eab64d8-ab11-4fa0-b101-43abaa3445e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9f78ab67-f71a-42d4-aef4-da2526bf30f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a02508b8-ef4a-430a-a528-13acadb531fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0c52f2f-5739-47e6-9130-b3d6c94ff54a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a25a291c-6868-4868-a726-2e7595030053"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a3953c93-46d5-486e-bb3f-c2677a0fb7be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a49e7606-2379-47e3-be13-48b60053578a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a80b76e0-b601-412a-9563-26f9ba4bb9ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a833be8a-1a99-4129-a84d-716786cd463d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aacd5d84-3100-402b-8e93-8cfd6f95bd28"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("af459baa-37bf-4bac-a04d-26419307aac7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("af5d5a00-c8df-4552-92eb-2208161b3668"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b13a537d-29e6-4d6b-ba4b-0c7648b2936c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b2cec74a-6395-48ee-8107-48494327367e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3013911-08ea-4292-af26-b21980d094e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b85c2145-2cee-4ddc-b84b-4093e476f8af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8a10942-5a49-4932-94b4-605d8de1bee9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bb639511-44fd-40d0-94a8-7f60a187cc93"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bc9fd52c-cdf8-458f-83a8-de7a4f33fa6f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be406f0a-f52d-4206-9c75-13a154bbea33"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c1bad89f-b587-49c9-a8b0-01f05dccad94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c2b9abec-343b-447f-853d-c22960d6095e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3390945-ec83-468f-a4a2-32e3dd82ee0e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3ae786a-e593-430b-9264-a7b71c1c87e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6a92001-dff7-4ac7-af26-0b1f4525d10e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d056d758-cbfc-4041-a5de-4e95a39f36be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d502bc46-b8e7-46c6-b5ba-944cdd987aa7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5d36b57-af2f-4b01-996f-851e4512bc78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d82dec76-1164-4773-92ca-143d65dde3e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("db14a0f4-1987-4a26-b470-d88e66ece3ab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dd640eb8-74f1-4ae1-897b-6785d1f3f900"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e169e1f4-2c42-47da-a5c0-b60cb02dc085"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3b1087d-6e3a-49d0-adcd-67459e2f84ed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e87a8bdd-299f-4619-b917-67b76eee3c99"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e9d1742d-997e-48b0-8441-1a4fefe10b3e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ec42b80d-7dc5-4edb-8e9c-366733feb245"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("edb5297f-61ae-41f0-9a36-9350614b759f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f12c912f-1dd3-48ab-be75-ba7956a2e515"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f1b81755-ec14-4d02-b8c9-e3d5fa283c31"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f1d06f83-4344-4758-83a5-ea6f010520ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f364e560-1dfa-4d64-99c0-bcf93ae4acab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f6047979-de63-4ef9-bfc6-ffe998546539"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fdd5f1d6-d6b2-4232-9ade-8a7eaffb9d11"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe070dba-2fa2-4d9a-97f7-d9953789814a"));

            migrationBuilder.AlterColumn<string>(
                name: "OrganizationName",
                table: "Mentors",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "CurrentPosition",
                table: "Mentors",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "FirstName", "IsDeleted", "LastName", "Password", "Phone", "Role" },
                values: new object[,]
                {
                    { new Guid("036cf484-f238-4fda-a2d1-229aa7603325"), "10", "Email90@gmail.com", "FirstName90", false, "LastName90", "123123", "123123", "Student" },
                    { new Guid("043837cb-0c1c-4488-bc00-7eac05db761b"), "10", "Email64@gmail.com", "FirstName64", false, "LastName64", "123123", "123123", "Student" },
                    { new Guid("05a9744a-2364-4178-bc20-d463e884fe7c"), "10", "Email77@gmail.com", "FirstName77", false, "LastName77", "123123", "123123", "Student" },
                    { new Guid("05dfcdf5-fede-4ec8-bce2-b0436fc8e25d"), "10", "Email54@gmail.com", "FirstName54", false, "LastName54", "123123", "123123", "Student" },
                    { new Guid("06caffc2-3a64-44c3-b349-2c2898ce9f36"), "10", "Email36@gmail.com", "FirstName36", false, "LastName36", "123123", "123123", "Student" },
                    { new Guid("09e95129-9798-4a44-984a-6a5316d3004b"), "10", "Email9@gmail.com", "FirstName9", false, "LastName9", "123123", "123123", "Student" },
                    { new Guid("0bac07e6-c041-4a0f-8b4b-cd8abab53f51"), "10", "Email48@gmail.com", "FirstName48", false, "LastName48", "123123", "123123", "Student" },
                    { new Guid("106ca2f9-a0e0-4244-a044-59954687f432"), "10", "Email67@gmail.com", "FirstName67", false, "LastName67", "123123", "123123", "Student" },
                    { new Guid("11303d87-b0e1-44dd-ae7e-01840051fff4"), "10", "Email76@gmail.com", "FirstName76", false, "LastName76", "123123", "123123", "Student" },
                    { new Guid("12d41424-c674-49c4-8c68-36917c3b59bc"), "10", "Email29@gmail.com", "FirstName29", false, "LastName29", "123123", "123123", "Student" },
                    { new Guid("137be492-e0bf-42b0-8687-40c25179c8b9"), "10", "Email10@gmail.com", "FirstName10", false, "LastName10", "123123", "123123", "Student" },
                    { new Guid("13ac9bc7-8d04-4685-8f7e-753792e41066"), "10", "Email96@gmail.com", "FirstName96", false, "LastName96", "123123", "123123", "Student" },
                    { new Guid("17e38c9f-0b26-4fb4-8e42-36effe463972"), "10", "Email78@gmail.com", "FirstName78", false, "LastName78", "123123", "123123", "Student" },
                    { new Guid("1f69a1c4-364e-4edd-a816-8f480bd50f94"), "10", "Email62@gmail.com", "FirstName62", false, "LastName62", "123123", "123123", "Student" },
                    { new Guid("21115a53-b043-4d51-a433-35c26997444d"), "10", "Email33@gmail.com", "FirstName33", false, "LastName33", "123123", "123123", "Student" },
                    { new Guid("24b74e71-0b7c-48cc-93d7-994eed80e539"), "10", "Email52@gmail.com", "FirstName52", false, "LastName52", "123123", "123123", "Student" },
                    { new Guid("29cfba7c-2aff-4093-adf4-04f6686c2e94"), "10", "Email39@gmail.com", "FirstName39", false, "LastName39", "123123", "123123", "Student" },
                    { new Guid("2c64b465-eeb5-4d05-b001-a1f6d17f4f8e"), "10", "Email18@gmail.com", "FirstName18", false, "LastName18", "123123", "123123", "Student" },
                    { new Guid("2e0175ea-66da-4dc1-be89-e5fb0e903359"), "10", "Email20@gmail.com", "FirstName20", false, "LastName20", "123123", "123123", "Student" },
                    { new Guid("352250c3-f7d7-4852-8d92-bb3a15b88ed2"), "10", "Email59@gmail.com", "FirstName59", false, "LastName59", "123123", "123123", "Student" },
                    { new Guid("352dc896-17ff-4712-8e7d-2b179e072416"), "10", "Email34@gmail.com", "FirstName34", false, "LastName34", "123123", "123123", "Student" },
                    { new Guid("38effd1e-5571-4532-85b7-16a4c39f7d99"), "10", "Email1@gmail.com", "FirstName1", false, "LastName1", "123123", "123123", "Student" },
                    { new Guid("415d87a3-8f91-49ab-8d0f-64b11a2d3c47"), "10", "Email72@gmail.com", "FirstName72", false, "LastName72", "123123", "123123", "Student" },
                    { new Guid("41fe6376-5766-436e-8e92-c228c4ea236f"), "10", "Email16@gmail.com", "FirstName16", false, "LastName16", "123123", "123123", "Student" },
                    { new Guid("42e3b639-4886-437e-9d05-1e16de8270c7"), "10", "Email81@gmail.com", "FirstName81", false, "LastName81", "123123", "123123", "Student" },
                    { new Guid("44a66cb6-406e-4655-88c1-633bba56f79c"), "10", "Email65@gmail.com", "FirstName65", false, "LastName65", "123123", "123123", "Student" },
                    { new Guid("45a9392d-76eb-4e25-a724-3989fc7cd2d0"), "10", "Email24@gmail.com", "FirstName24", false, "LastName24", "123123", "123123", "Student" },
                    { new Guid("4899a681-a70b-4605-a691-c49519494a63"), "10", "Email30@gmail.com", "FirstName30", false, "LastName30", "123123", "123123", "Student" },
                    { new Guid("4a51fc21-823d-426b-90c2-39a0e2281996"), "10", "Email38@gmail.com", "FirstName38", false, "LastName38", "123123", "123123", "Student" },
                    { new Guid("50e99ea0-52a7-45c6-9816-28aee11a437a"), "10", "Email51@gmail.com", "FirstName51", false, "LastName51", "123123", "123123", "Student" },
                    { new Guid("51ee6ad3-044e-471e-ac80-ac63d98abe8e"), "10", "Email98@gmail.com", "FirstName98", false, "LastName98", "123123", "123123", "Student" },
                    { new Guid("51f5fde6-b52b-4405-833d-9915a073166d"), "10", "Email35@gmail.com", "FirstName35", false, "LastName35", "123123", "123123", "Student" },
                    { new Guid("52b649b5-04f7-47ff-afab-fb349ebd1f42"), "10", "Email8@gmail.com", "FirstName8", false, "LastName8", "123123", "123123", "Student" },
                    { new Guid("5336c8f9-90bb-4507-9eda-ae7e51603d26"), "10", "Email80@gmail.com", "FirstName80", false, "LastName80", "123123", "123123", "Student" },
                    { new Guid("574f7616-59f0-460e-9510-2516a2d25d8b"), "10", "Email7@gmail.com", "FirstName7", false, "LastName7", "123123", "123123", "Student" },
                    { new Guid("57ad933b-2f05-49ba-8593-c8c84798f125"), "10", "Email69@gmail.com", "FirstName69", false, "LastName69", "123123", "123123", "Student" },
                    { new Guid("5a17ae64-8fb6-44b6-87f0-99108da2ae92"), "10", "Email58@gmail.com", "FirstName58", false, "LastName58", "123123", "123123", "Student" },
                    { new Guid("5d714a2e-58f0-4d98-9a7f-967a6b1ca34e"), "10", "Email55@gmail.com", "FirstName55", false, "LastName55", "123123", "123123", "Student" },
                    { new Guid("608f0e25-1e9b-492a-942f-69a74110ca75"), "10", "Email42@gmail.com", "FirstName42", false, "LastName42", "123123", "123123", "Student" },
                    { new Guid("60f88585-47f2-4368-8673-509eac182c32"), "10", "Email84@gmail.com", "FirstName84", false, "LastName84", "123123", "123123", "Student" },
                    { new Guid("6160d100-9b5a-4e9d-a0cf-0a364537b0ba"), "10", "Email95@gmail.com", "FirstName95", false, "LastName95", "123123", "123123", "Student" },
                    { new Guid("627ae19c-f525-42c2-b810-b3e9de091284"), "10", "Email40@gmail.com", "FirstName40", false, "LastName40", "123123", "123123", "Student" },
                    { new Guid("673ec6cb-c51c-42d8-bcfc-127ca84543df"), "10", "Email70@gmail.com", "FirstName70", false, "LastName70", "123123", "123123", "Student" },
                    { new Guid("68e82509-7915-438b-939b-b219e1364ec9"), "10", "Email15@gmail.com", "FirstName15", false, "LastName15", "123123", "123123", "Student" },
                    { new Guid("72328a99-e164-4a96-b4df-1ebf4aab0ac1"), "10", "Email89@gmail.com", "FirstName89", false, "LastName89", "123123", "123123", "Student" },
                    { new Guid("7237fd72-3f7b-4fb8-b63d-bc968f90633e"), "10", "Email13@gmail.com", "FirstName13", false, "LastName13", "123123", "123123", "Student" },
                    { new Guid("77f592de-7ef1-4fb3-8331-bc01d24f3efa"), "10", "Email17@gmail.com", "FirstName17", false, "LastName17", "123123", "123123", "Student" },
                    { new Guid("7cba846a-a156-443c-8a81-7287ef626bd5"), "10", "Email71@gmail.com", "FirstName71", false, "LastName71", "123123", "123123", "Student" },
                    { new Guid("7ceacf8b-a506-4cae-af70-484b062d7309"), "10", "Email0@gmail.com", "FirstName0", false, "LastName0", "123123", "123123", "Student" },
                    { new Guid("7cfb8c9e-6a18-4aca-b39a-5e8346b42ece"), "10", "Email83@gmail.com", "FirstName83", false, "LastName83", "123123", "123123", "Student" },
                    { new Guid("7d1f4a0b-0824-4d3a-b4f5-d7a98f238b5d"), "10", "Email94@gmail.com", "FirstName94", false, "LastName94", "123123", "123123", "Student" },
                    { new Guid("7e393d7a-1564-4506-82c8-993e96c48254"), "10", "Email75@gmail.com", "FirstName75", false, "LastName75", "123123", "123123", "Student" },
                    { new Guid("80749e9e-1950-4694-b9a5-9ad0b52c0040"), "10", "Email60@gmail.com", "FirstName60", false, "LastName60", "123123", "123123", "Student" },
                    { new Guid("8176a4db-86ef-4324-b6a0-b6976d8feb47"), "10", "Email2@gmail.com", "FirstName2", false, "LastName2", "123123", "123123", "Student" },
                    { new Guid("82f04fae-f3b2-4d74-b33d-263b33eb3ec2"), "10", "Email6@gmail.com", "FirstName6", false, "LastName6", "123123", "123123", "Student" },
                    { new Guid("85d8ee1c-4f73-46ec-bc1e-509c21fffc3c"), "10", "Email49@gmail.com", "FirstName49", false, "LastName49", "123123", "123123", "Student" },
                    { new Guid("8a011ae7-8e34-40e4-a7ae-6c439aa44f9d"), "10", "Email63@gmail.com", "FirstName63", false, "LastName63", "123123", "123123", "Student" },
                    { new Guid("912f2196-2f31-4b40-be02-a70031a047b3"), "10", "Email37@gmail.com", "FirstName37", false, "LastName37", "123123", "123123", "Student" },
                    { new Guid("949b6f51-4087-4934-a9c2-ca647df77246"), "10", "Email87@gmail.com", "FirstName87", false, "LastName87", "123123", "123123", "Student" },
                    { new Guid("94b99311-d66e-4fd3-83b9-e1203973871a"), "10", "Email99@gmail.com", "FirstName99", false, "LastName99", "123123", "123123", "Student" },
                    { new Guid("9630035d-4a10-4fa1-a260-c784a3f4099f"), "10", "Email26@gmail.com", "FirstName26", false, "LastName26", "123123", "123123", "Student" },
                    { new Guid("98310dbf-0813-4d62-976f-c92198cf6276"), "10", "Email68@gmail.com", "FirstName68", false, "LastName68", "123123", "123123", "Student" },
                    { new Guid("9ccca6ac-df0d-4a05-88f8-2f53df22dd32"), "10", "Email41@gmail.com", "FirstName41", false, "LastName41", "123123", "123123", "Student" },
                    { new Guid("9ebaf55d-9697-401c-ae30-d6e362bdec84"), "10", "Email4@gmail.com", "FirstName4", false, "LastName4", "123123", "123123", "Student" },
                    { new Guid("a2a86521-0aaf-4f18-9da4-7362ec46cec2"), "10", "Email19@gmail.com", "FirstName19", false, "LastName19", "123123", "123123", "Student" },
                    { new Guid("a4f5e310-fc82-42ce-bae8-65b943b9d245"), "10", "Email92@gmail.com", "FirstName92", false, "LastName92", "123123", "123123", "Student" },
                    { new Guid("a6be7ae2-1553-49a5-84e0-7330d6305d8a"), "10", "Email31@gmail.com", "FirstName31", false, "LastName31", "123123", "123123", "Student" },
                    { new Guid("a7941979-c8dc-4eee-8926-d5586bde0b8e"), "10", "Email45@gmail.com", "FirstName45", false, "LastName45", "123123", "123123", "Student" },
                    { new Guid("a8f10abc-3166-49bd-a2bf-ed97eccad6e7"), "10", "Email32@gmail.com", "FirstName32", false, "LastName32", "123123", "123123", "Student" },
                    { new Guid("a97bf36a-12ea-471f-bde9-2e4b636c66ab"), "10", "Email28@gmail.com", "FirstName28", false, "LastName28", "123123", "123123", "Student" },
                    { new Guid("a99c3c11-25e9-4cb1-8502-0ca27a827aa1"), "10", "Email86@gmail.com", "FirstName86", false, "LastName86", "123123", "123123", "Student" },
                    { new Guid("a9d25eb2-71c6-475a-b93c-6f766f4e8d2b"), "10", "Email12@gmail.com", "FirstName12", false, "LastName12", "123123", "123123", "Student" },
                    { new Guid("b0a3ea58-123c-42e4-89fc-627324942291"), "10", "Email44@gmail.com", "FirstName44", false, "LastName44", "123123", "123123", "Student" },
                    { new Guid("b7fc812f-cb40-4cf2-b2f3-bb9c5831690d"), "10", "Email93@gmail.com", "FirstName93", false, "LastName93", "123123", "123123", "Student" },
                    { new Guid("b9d0ae23-78c3-4eb1-8da9-21fa06d31ac0"), "10", "Email5@gmail.com", "FirstName5", false, "LastName5", "123123", "123123", "Student" },
                    { new Guid("bebefbd3-22a6-4633-b58a-601a67075e2f"), "10", "Email79@gmail.com", "FirstName79", false, "LastName79", "123123", "123123", "Student" },
                    { new Guid("bf299662-ef67-4d42-bd46-fecb0d298caa"), "10", "Email82@gmail.com", "FirstName82", false, "LastName82", "123123", "123123", "Student" },
                    { new Guid("bf550f09-12c1-4814-b719-a86a4e7e66f9"), "10", "Email56@gmail.com", "FirstName56", false, "LastName56", "123123", "123123", "Student" },
                    { new Guid("c09a320c-917f-4d52-a3f5-7073d1aea315"), "10", "Email14@gmail.com", "FirstName14", false, "LastName14", "123123", "123123", "Student" },
                    { new Guid("c660a3cb-f0d2-40d4-a794-01b2b63757a7"), "10", "Email3@gmail.com", "FirstName3", false, "LastName3", "123123", "123123", "Student" },
                    { new Guid("c991a890-1d25-4108-a63e-53c57b89271c"), "10", "Email46@gmail.com", "FirstName46", false, "LastName46", "123123", "123123", "Student" },
                    { new Guid("cb214e4d-32eb-4e82-aea4-4dbe5d4cf91a"), "10", "Email47@gmail.com", "FirstName47", false, "LastName47", "123123", "123123", "Student" },
                    { new Guid("ce380213-6b1e-4465-936b-123f15c528d2"), "10", "Email61@gmail.com", "FirstName61", false, "LastName61", "123123", "123123", "Student" },
                    { new Guid("cf2d7de0-7009-4524-b3d5-c89ab136aa9a"), "10", "Email11@gmail.com", "FirstName11", false, "LastName11", "123123", "123123", "Student" },
                    { new Guid("d0f0faf0-e3a3-4d2d-a70a-252a93863ff9"), "10", "Email73@gmail.com", "FirstName73", false, "LastName73", "123123", "123123", "Student" },
                    { new Guid("d6db34f4-68c8-44f9-a828-97f8a8d018ff"), "10", "Email53@gmail.com", "FirstName53", false, "LastName53", "123123", "123123", "Student" },
                    { new Guid("d9e556ec-3dcf-4768-8fb2-00d4e14a8877"), "10", "Email57@gmail.com", "FirstName57", false, "LastName57", "123123", "123123", "Student" },
                    { new Guid("da87538a-86a0-42a3-8d05-db8941c85c87"), "10", "Email43@gmail.com", "FirstName43", false, "LastName43", "123123", "123123", "Student" },
                    { new Guid("db39eb5e-f2fe-4fbf-811c-2895833637cb"), "10", "Email22@gmail.com", "FirstName22", false, "LastName22", "123123", "123123", "Student" },
                    { new Guid("db76cdb5-78ba-4805-91a8-691e55aa8a97"), "10", "Email66@gmail.com", "FirstName66", false, "LastName66", "123123", "123123", "Student" },
                    { new Guid("dc9b03cd-7676-4b15-b2b1-baa7e86a7585"), "10", "Email21@gmail.com", "FirstName21", false, "LastName21", "123123", "123123", "Student" },
                    { new Guid("dfe9cb35-38ac-4d44-bebd-2eee0ad45a38"), "10", "Email27@gmail.com", "FirstName27", false, "LastName27", "123123", "123123", "Student" },
                    { new Guid("e263c2be-2113-4f90-b88f-b6732d365cee"), "10", "Email50@gmail.com", "FirstName50", false, "LastName50", "123123", "123123", "Student" },
                    { new Guid("e52a1559-8e8f-458b-a5cb-2e25be8d8bf3"), "10", "Email74@gmail.com", "FirstName74", false, "LastName74", "123123", "123123", "Student" },
                    { new Guid("e608014b-0d4e-48ee-a379-0815bd2da346"), "10", "Email88@gmail.com", "FirstName88", false, "LastName88", "123123", "123123", "Student" },
                    { new Guid("e75520ea-d6ab-4373-ab90-5565bc54f68d"), "10", "Email25@gmail.com", "FirstName25", false, "LastName25", "123123", "123123", "Student" },
                    { new Guid("eea14388-ae4a-4e2b-99aa-5c4fa73a8c6b"), "10", "Email97@gmail.com", "FirstName97", false, "LastName97", "123123", "123123", "Student" },
                    { new Guid("eff38645-e044-4e89-ba7e-8b81b14bb99d"), "10", "Email85@gmail.com", "FirstName85", false, "LastName85", "123123", "123123", "Student" },
                    { new Guid("f896e2e8-3202-43f9-aae6-1f6ec6837cdf"), "10", "Email23@gmail.com", "FirstName23", false, "LastName23", "123123", "123123", "Student" },
                    { new Guid("fe8d24af-412a-4594-93b7-babef637542e"), "10", "Email91@gmail.com", "FirstName91", false, "LastName91", "123123", "123123", "Student" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("036cf484-f238-4fda-a2d1-229aa7603325"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("043837cb-0c1c-4488-bc00-7eac05db761b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("05a9744a-2364-4178-bc20-d463e884fe7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("05dfcdf5-fede-4ec8-bce2-b0436fc8e25d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("06caffc2-3a64-44c3-b349-2c2898ce9f36"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09e95129-9798-4a44-984a-6a5316d3004b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0bac07e6-c041-4a0f-8b4b-cd8abab53f51"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("106ca2f9-a0e0-4244-a044-59954687f432"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11303d87-b0e1-44dd-ae7e-01840051fff4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("12d41424-c674-49c4-8c68-36917c3b59bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("137be492-e0bf-42b0-8687-40c25179c8b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13ac9bc7-8d04-4685-8f7e-753792e41066"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17e38c9f-0b26-4fb4-8e42-36effe463972"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1f69a1c4-364e-4edd-a816-8f480bd50f94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("21115a53-b043-4d51-a433-35c26997444d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24b74e71-0b7c-48cc-93d7-994eed80e539"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("29cfba7c-2aff-4093-adf4-04f6686c2e94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2c64b465-eeb5-4d05-b001-a1f6d17f4f8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e0175ea-66da-4dc1-be89-e5fb0e903359"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("352250c3-f7d7-4852-8d92-bb3a15b88ed2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("352dc896-17ff-4712-8e7d-2b179e072416"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("38effd1e-5571-4532-85b7-16a4c39f7d99"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("415d87a3-8f91-49ab-8d0f-64b11a2d3c47"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41fe6376-5766-436e-8e92-c228c4ea236f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42e3b639-4886-437e-9d05-1e16de8270c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44a66cb6-406e-4655-88c1-633bba56f79c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45a9392d-76eb-4e25-a724-3989fc7cd2d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4899a681-a70b-4605-a691-c49519494a63"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4a51fc21-823d-426b-90c2-39a0e2281996"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50e99ea0-52a7-45c6-9816-28aee11a437a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51ee6ad3-044e-471e-ac80-ac63d98abe8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51f5fde6-b52b-4405-833d-9915a073166d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("52b649b5-04f7-47ff-afab-fb349ebd1f42"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5336c8f9-90bb-4507-9eda-ae7e51603d26"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("574f7616-59f0-460e-9510-2516a2d25d8b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("57ad933b-2f05-49ba-8593-c8c84798f125"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a17ae64-8fb6-44b6-87f0-99108da2ae92"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d714a2e-58f0-4d98-9a7f-967a6b1ca34e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("608f0e25-1e9b-492a-942f-69a74110ca75"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("60f88585-47f2-4368-8673-509eac182c32"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6160d100-9b5a-4e9d-a0cf-0a364537b0ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("627ae19c-f525-42c2-b810-b3e9de091284"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("673ec6cb-c51c-42d8-bcfc-127ca84543df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68e82509-7915-438b-939b-b219e1364ec9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72328a99-e164-4a96-b4df-1ebf4aab0ac1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7237fd72-3f7b-4fb8-b63d-bc968f90633e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("77f592de-7ef1-4fb3-8331-bc01d24f3efa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7cba846a-a156-443c-8a81-7287ef626bd5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ceacf8b-a506-4cae-af70-484b062d7309"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7cfb8c9e-6a18-4aca-b39a-5e8346b42ece"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d1f4a0b-0824-4d3a-b4f5-d7a98f238b5d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7e393d7a-1564-4506-82c8-993e96c48254"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("80749e9e-1950-4694-b9a5-9ad0b52c0040"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8176a4db-86ef-4324-b6a0-b6976d8feb47"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82f04fae-f3b2-4d74-b33d-263b33eb3ec2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("85d8ee1c-4f73-46ec-bc1e-509c21fffc3c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a011ae7-8e34-40e4-a7ae-6c439aa44f9d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("912f2196-2f31-4b40-be02-a70031a047b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("949b6f51-4087-4934-a9c2-ca647df77246"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("94b99311-d66e-4fd3-83b9-e1203973871a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9630035d-4a10-4fa1-a260-c784a3f4099f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("98310dbf-0813-4d62-976f-c92198cf6276"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ccca6ac-df0d-4a05-88f8-2f53df22dd32"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ebaf55d-9697-401c-ae30-d6e362bdec84"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a2a86521-0aaf-4f18-9da4-7362ec46cec2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4f5e310-fc82-42ce-bae8-65b943b9d245"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6be7ae2-1553-49a5-84e0-7330d6305d8a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a7941979-c8dc-4eee-8926-d5586bde0b8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a8f10abc-3166-49bd-a2bf-ed97eccad6e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a97bf36a-12ea-471f-bde9-2e4b636c66ab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a99c3c11-25e9-4cb1-8502-0ca27a827aa1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a9d25eb2-71c6-475a-b93c-6f766f4e8d2b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0a3ea58-123c-42e4-89fc-627324942291"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b7fc812f-cb40-4cf2-b2f3-bb9c5831690d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b9d0ae23-78c3-4eb1-8da9-21fa06d31ac0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bebefbd3-22a6-4633-b58a-601a67075e2f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf299662-ef67-4d42-bd46-fecb0d298caa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf550f09-12c1-4814-b719-a86a4e7e66f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c09a320c-917f-4d52-a3f5-7073d1aea315"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c660a3cb-f0d2-40d4-a794-01b2b63757a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c991a890-1d25-4108-a63e-53c57b89271c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb214e4d-32eb-4e82-aea4-4dbe5d4cf91a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ce380213-6b1e-4465-936b-123f15c528d2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cf2d7de0-7009-4524-b3d5-c89ab136aa9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0f0faf0-e3a3-4d2d-a70a-252a93863ff9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d6db34f4-68c8-44f9-a828-97f8a8d018ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d9e556ec-3dcf-4768-8fb2-00d4e14a8877"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("da87538a-86a0-42a3-8d05-db8941c85c87"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("db39eb5e-f2fe-4fbf-811c-2895833637cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("db76cdb5-78ba-4805-91a8-691e55aa8a97"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc9b03cd-7676-4b15-b2b1-baa7e86a7585"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dfe9cb35-38ac-4d44-bebd-2eee0ad45a38"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e263c2be-2113-4f90-b88f-b6732d365cee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e52a1559-8e8f-458b-a5cb-2e25be8d8bf3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e608014b-0d4e-48ee-a379-0815bd2da346"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e75520ea-d6ab-4373-ab90-5565bc54f68d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eea14388-ae4a-4e2b-99aa-5c4fa73a8c6b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eff38645-e044-4e89-ba7e-8b81b14bb99d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f896e2e8-3202-43f9-aae6-1f6ec6837cdf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe8d24af-412a-4594-93b7-babef637542e"));

            migrationBuilder.AlterColumn<string>(
                name: "OrganizationName",
                table: "Mentors",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CurrentPosition",
                table: "Mentors",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "FirstName", "IsDeleted", "LastName", "Password", "Phone", "Role" },
                values: new object[,]
                {
                    { new Guid("00c3da93-57d5-4e0b-b774-b4bfb1160f2a"), "10", "Email57@gmail.com", "FirstName57", false, "LastName57", "123123", "123123", "Student" },
                    { new Guid("0136a24b-43ff-4f33-82e7-5ce70a819cbd"), "10", "Email69@gmail.com", "FirstName69", false, "LastName69", "123123", "123123", "Student" },
                    { new Guid("0b0699cc-b726-41bf-afef-f55554fcc6ad"), "10", "Email71@gmail.com", "FirstName71", false, "LastName71", "123123", "123123", "Student" },
                    { new Guid("100464ec-ede3-42b0-8a1c-24bd4084fc38"), "10", "Email70@gmail.com", "FirstName70", false, "LastName70", "123123", "123123", "Student" },
                    { new Guid("115eb520-d368-4b71-8e03-917a5ae23d7e"), "10", "Email22@gmail.com", "FirstName22", false, "LastName22", "123123", "123123", "Student" },
                    { new Guid("12810f96-a4b9-469c-8439-e8d8bb5b81c3"), "10", "Email77@gmail.com", "FirstName77", false, "LastName77", "123123", "123123", "Student" },
                    { new Guid("14ca906c-64d8-4342-a372-b0c640e6303f"), "10", "Email42@gmail.com", "FirstName42", false, "LastName42", "123123", "123123", "Student" },
                    { new Guid("181162ce-31b9-4d89-ac96-b6c34f50205c"), "10", "Email84@gmail.com", "FirstName84", false, "LastName84", "123123", "123123", "Student" },
                    { new Guid("1c9abaa1-b81f-48f4-894f-233201dd84a1"), "10", "Email90@gmail.com", "FirstName90", false, "LastName90", "123123", "123123", "Student" },
                    { new Guid("1cd237a7-2753-4055-beff-edbeb2131ca9"), "10", "Email76@gmail.com", "FirstName76", false, "LastName76", "123123", "123123", "Student" },
                    { new Guid("1cf3d78b-ac90-4cdc-ad6c-8a6f98d763d0"), "10", "Email62@gmail.com", "FirstName62", false, "LastName62", "123123", "123123", "Student" },
                    { new Guid("1d7c5dd5-106b-4f83-a798-9c9d70c89ee5"), "10", "Email31@gmail.com", "FirstName31", false, "LastName31", "123123", "123123", "Student" },
                    { new Guid("1e95f099-4e08-4d80-8e9f-409c106e5e0c"), "10", "Email26@gmail.com", "FirstName26", false, "LastName26", "123123", "123123", "Student" },
                    { new Guid("1fe2fbb1-b547-422a-9cae-7ce4c99ab301"), "10", "Email11@gmail.com", "FirstName11", false, "LastName11", "123123", "123123", "Student" },
                    { new Guid("20dfc7b6-1578-4d3c-b6b3-10e3685230ab"), "10", "Email96@gmail.com", "FirstName96", false, "LastName96", "123123", "123123", "Student" },
                    { new Guid("22114a16-85f4-4ddf-9d29-1ae90cef46c8"), "10", "Email49@gmail.com", "FirstName49", false, "LastName49", "123123", "123123", "Student" },
                    { new Guid("22e71c2c-2730-46f7-b4c6-eca061f554fc"), "10", "Email74@gmail.com", "FirstName74", false, "LastName74", "123123", "123123", "Student" },
                    { new Guid("2573022b-2526-4986-98fd-31fa0e018a2c"), "10", "Email78@gmail.com", "FirstName78", false, "LastName78", "123123", "123123", "Student" },
                    { new Guid("28b0c24e-e97d-4487-9285-1c056a8c44af"), "10", "Email14@gmail.com", "FirstName14", false, "LastName14", "123123", "123123", "Student" },
                    { new Guid("2dfe3836-86df-4e0b-a6be-1dfc98c1e245"), "10", "Email28@gmail.com", "FirstName28", false, "LastName28", "123123", "123123", "Student" },
                    { new Guid("307e22b8-c7cb-4629-a7dc-54f1bad5a115"), "10", "Email54@gmail.com", "FirstName54", false, "LastName54", "123123", "123123", "Student" },
                    { new Guid("355e0108-3166-4f91-9a96-eaffa08fb6ca"), "10", "Email53@gmail.com", "FirstName53", false, "LastName53", "123123", "123123", "Student" },
                    { new Guid("3f4973ae-fc7c-40a9-aaf7-9554862186bf"), "10", "Email99@gmail.com", "FirstName99", false, "LastName99", "123123", "123123", "Student" },
                    { new Guid("3fabf8ff-b653-4204-8e10-de0c013be95d"), "10", "Email13@gmail.com", "FirstName13", false, "LastName13", "123123", "123123", "Student" },
                    { new Guid("45008283-b464-47e3-86bb-b696a4baaf4e"), "10", "Email33@gmail.com", "FirstName33", false, "LastName33", "123123", "123123", "Student" },
                    { new Guid("48d0f8c9-ae04-4683-963e-5207183519bb"), "10", "Email29@gmail.com", "FirstName29", false, "LastName29", "123123", "123123", "Student" },
                    { new Guid("4bb53bde-7c6b-45c4-a072-4a3d4816472c"), "10", "Email1@gmail.com", "FirstName1", false, "LastName1", "123123", "123123", "Student" },
                    { new Guid("4bb5bcab-ab74-41e6-9349-98a2497d6284"), "10", "Email95@gmail.com", "FirstName95", false, "LastName95", "123123", "123123", "Student" },
                    { new Guid("4f916359-f8b2-417c-a249-e34ea6f8ae22"), "10", "Email86@gmail.com", "FirstName86", false, "LastName86", "123123", "123123", "Student" },
                    { new Guid("522b556a-8c9e-4435-adb4-26138c097da6"), "10", "Email27@gmail.com", "FirstName27", false, "LastName27", "123123", "123123", "Student" },
                    { new Guid("556e15b3-596a-42bc-ac40-c15bed1a3f7f"), "10", "Email56@gmail.com", "FirstName56", false, "LastName56", "123123", "123123", "Student" },
                    { new Guid("57bd49ce-a36d-4d87-937a-852aa246ec36"), "10", "Email91@gmail.com", "FirstName91", false, "LastName91", "123123", "123123", "Student" },
                    { new Guid("5bdc2356-1bb6-48a3-8a74-5775c532cfd9"), "10", "Email75@gmail.com", "FirstName75", false, "LastName75", "123123", "123123", "Student" },
                    { new Guid("5bf2b4d2-d692-4839-ab77-1659f7b7179c"), "10", "Email67@gmail.com", "FirstName67", false, "LastName67", "123123", "123123", "Student" },
                    { new Guid("5d35b81e-e1e2-4a87-ac28-54af371c5fbd"), "10", "Email30@gmail.com", "FirstName30", false, "LastName30", "123123", "123123", "Student" },
                    { new Guid("5ee183ac-97bd-473f-9e24-afb2dacb4ffe"), "10", "Email35@gmail.com", "FirstName35", false, "LastName35", "123123", "123123", "Student" },
                    { new Guid("6426d2c2-04c4-42ef-ad0f-b9583e0a6246"), "10", "Email65@gmail.com", "FirstName65", false, "LastName65", "123123", "123123", "Student" },
                    { new Guid("68c7995a-dd78-4691-91a6-c99a19fa0336"), "10", "Email92@gmail.com", "FirstName92", false, "LastName92", "123123", "123123", "Student" },
                    { new Guid("6f86cf32-0b1a-44c4-92de-5aeffdc64695"), "10", "Email32@gmail.com", "FirstName32", false, "LastName32", "123123", "123123", "Student" },
                    { new Guid("71b398d7-a5e2-4ade-80b0-6b8e6e67308b"), "10", "Email94@gmail.com", "FirstName94", false, "LastName94", "123123", "123123", "Student" },
                    { new Guid("74062231-04e7-4628-973c-230fdf16819b"), "10", "Email40@gmail.com", "FirstName40", false, "LastName40", "123123", "123123", "Student" },
                    { new Guid("7510be2e-c751-485c-b64c-4ad8496a3f8c"), "10", "Email17@gmail.com", "FirstName17", false, "LastName17", "123123", "123123", "Student" },
                    { new Guid("762deec3-5323-488f-be42-57841bd186b3"), "10", "Email68@gmail.com", "FirstName68", false, "LastName68", "123123", "123123", "Student" },
                    { new Guid("7667d5a6-1bc6-448c-80b5-218d7ba6ed48"), "10", "Email93@gmail.com", "FirstName93", false, "LastName93", "123123", "123123", "Student" },
                    { new Guid("7748be6f-2b36-4df8-be91-2391cbc1d98c"), "10", "Email37@gmail.com", "FirstName37", false, "LastName37", "123123", "123123", "Student" },
                    { new Guid("7b32e7ef-04c7-4ca2-a128-e1be30a7ab9a"), "10", "Email4@gmail.com", "FirstName4", false, "LastName4", "123123", "123123", "Student" },
                    { new Guid("819dcad3-d5d7-4a6d-b97a-049e59b190c1"), "10", "Email73@gmail.com", "FirstName73", false, "LastName73", "123123", "123123", "Student" },
                    { new Guid("86507b3d-ddbc-49a7-87bd-47b7502bdb56"), "10", "Email8@gmail.com", "FirstName8", false, "LastName8", "123123", "123123", "Student" },
                    { new Guid("8f4d8940-a05d-4c11-8673-56b4ab6d3a73"), "10", "Email7@gmail.com", "FirstName7", false, "LastName7", "123123", "123123", "Student" },
                    { new Guid("8f59f6b7-d846-4b17-84c0-a9c9da6d5a36"), "10", "Email2@gmail.com", "FirstName2", false, "LastName2", "123123", "123123", "Student" },
                    { new Guid("934bf105-9ff1-4944-bec8-9823e59938b8"), "10", "Email83@gmail.com", "FirstName83", false, "LastName83", "123123", "123123", "Student" },
                    { new Guid("967e28ad-b990-4441-ab17-e6b306f62e52"), "10", "Email72@gmail.com", "FirstName72", false, "LastName72", "123123", "123123", "Student" },
                    { new Guid("96fac293-d0c9-4a78-ac24-4bafc408cc03"), "10", "Email88@gmail.com", "FirstName88", false, "LastName88", "123123", "123123", "Student" },
                    { new Guid("982b560d-387e-45a0-a40c-c0fe3178c357"), "10", "Email16@gmail.com", "FirstName16", false, "LastName16", "123123", "123123", "Student" },
                    { new Guid("9acab135-437e-47c8-8a2b-302eeb2f2111"), "10", "Email66@gmail.com", "FirstName66", false, "LastName66", "123123", "123123", "Student" },
                    { new Guid("9c14ba75-e53e-4df8-85f2-d54ab0400100"), "10", "Email23@gmail.com", "FirstName23", false, "LastName23", "123123", "123123", "Student" },
                    { new Guid("9eab64d8-ab11-4fa0-b101-43abaa3445e4"), "10", "Email6@gmail.com", "FirstName6", false, "LastName6", "123123", "123123", "Student" },
                    { new Guid("9f78ab67-f71a-42d4-aef4-da2526bf30f3"), "10", "Email58@gmail.com", "FirstName58", false, "LastName58", "123123", "123123", "Student" },
                    { new Guid("a02508b8-ef4a-430a-a528-13acadb531fa"), "10", "Email45@gmail.com", "FirstName45", false, "LastName45", "123123", "123123", "Student" },
                    { new Guid("a0c52f2f-5739-47e6-9130-b3d6c94ff54a"), "10", "Email60@gmail.com", "FirstName60", false, "LastName60", "123123", "123123", "Student" },
                    { new Guid("a25a291c-6868-4868-a726-2e7595030053"), "10", "Email10@gmail.com", "FirstName10", false, "LastName10", "123123", "123123", "Student" },
                    { new Guid("a3953c93-46d5-486e-bb3f-c2677a0fb7be"), "10", "Email87@gmail.com", "FirstName87", false, "LastName87", "123123", "123123", "Student" },
                    { new Guid("a49e7606-2379-47e3-be13-48b60053578a"), "10", "Email12@gmail.com", "FirstName12", false, "LastName12", "123123", "123123", "Student" },
                    { new Guid("a80b76e0-b601-412a-9563-26f9ba4bb9ac"), "10", "Email82@gmail.com", "FirstName82", false, "LastName82", "123123", "123123", "Student" },
                    { new Guid("a833be8a-1a99-4129-a84d-716786cd463d"), "10", "Email36@gmail.com", "FirstName36", false, "LastName36", "123123", "123123", "Student" },
                    { new Guid("aacd5d84-3100-402b-8e93-8cfd6f95bd28"), "10", "Email44@gmail.com", "FirstName44", false, "LastName44", "123123", "123123", "Student" },
                    { new Guid("af459baa-37bf-4bac-a04d-26419307aac7"), "10", "Email85@gmail.com", "FirstName85", false, "LastName85", "123123", "123123", "Student" },
                    { new Guid("af5d5a00-c8df-4552-92eb-2208161b3668"), "10", "Email63@gmail.com", "FirstName63", false, "LastName63", "123123", "123123", "Student" },
                    { new Guid("b13a537d-29e6-4d6b-ba4b-0c7648b2936c"), "10", "Email5@gmail.com", "FirstName5", false, "LastName5", "123123", "123123", "Student" },
                    { new Guid("b2cec74a-6395-48ee-8107-48494327367e"), "10", "Email79@gmail.com", "FirstName79", false, "LastName79", "123123", "123123", "Student" },
                    { new Guid("b3013911-08ea-4292-af26-b21980d094e2"), "10", "Email34@gmail.com", "FirstName34", false, "LastName34", "123123", "123123", "Student" },
                    { new Guid("b85c2145-2cee-4ddc-b84b-4093e476f8af"), "10", "Email98@gmail.com", "FirstName98", false, "LastName98", "123123", "123123", "Student" },
                    { new Guid("b8a10942-5a49-4932-94b4-605d8de1bee9"), "10", "Email47@gmail.com", "FirstName47", false, "LastName47", "123123", "123123", "Student" },
                    { new Guid("bb639511-44fd-40d0-94a8-7f60a187cc93"), "10", "Email48@gmail.com", "FirstName48", false, "LastName48", "123123", "123123", "Student" },
                    { new Guid("bc9fd52c-cdf8-458f-83a8-de7a4f33fa6f"), "10", "Email59@gmail.com", "FirstName59", false, "LastName59", "123123", "123123", "Student" },
                    { new Guid("be406f0a-f52d-4206-9c75-13a154bbea33"), "10", "Email43@gmail.com", "FirstName43", false, "LastName43", "123123", "123123", "Student" },
                    { new Guid("c1bad89f-b587-49c9-a8b0-01f05dccad94"), "10", "Email89@gmail.com", "FirstName89", false, "LastName89", "123123", "123123", "Student" },
                    { new Guid("c2b9abec-343b-447f-853d-c22960d6095e"), "10", "Email20@gmail.com", "FirstName20", false, "LastName20", "123123", "123123", "Student" },
                    { new Guid("c3390945-ec83-468f-a4a2-32e3dd82ee0e"), "10", "Email38@gmail.com", "FirstName38", false, "LastName38", "123123", "123123", "Student" },
                    { new Guid("c3ae786a-e593-430b-9264-a7b71c1c87e4"), "10", "Email46@gmail.com", "FirstName46", false, "LastName46", "123123", "123123", "Student" },
                    { new Guid("c6a92001-dff7-4ac7-af26-0b1f4525d10e"), "10", "Email64@gmail.com", "FirstName64", false, "LastName64", "123123", "123123", "Student" },
                    { new Guid("d056d758-cbfc-4041-a5de-4e95a39f36be"), "10", "Email61@gmail.com", "FirstName61", false, "LastName61", "123123", "123123", "Student" },
                    { new Guid("d502bc46-b8e7-46c6-b5ba-944cdd987aa7"), "10", "Email39@gmail.com", "FirstName39", false, "LastName39", "123123", "123123", "Student" },
                    { new Guid("d5d36b57-af2f-4b01-996f-851e4512bc78"), "10", "Email25@gmail.com", "FirstName25", false, "LastName25", "123123", "123123", "Student" },
                    { new Guid("d82dec76-1164-4773-92ca-143d65dde3e9"), "10", "Email19@gmail.com", "FirstName19", false, "LastName19", "123123", "123123", "Student" },
                    { new Guid("db14a0f4-1987-4a26-b470-d88e66ece3ab"), "10", "Email3@gmail.com", "FirstName3", false, "LastName3", "123123", "123123", "Student" },
                    { new Guid("dd640eb8-74f1-4ae1-897b-6785d1f3f900"), "10", "Email55@gmail.com", "FirstName55", false, "LastName55", "123123", "123123", "Student" },
                    { new Guid("e169e1f4-2c42-47da-a5c0-b60cb02dc085"), "10", "Email41@gmail.com", "FirstName41", false, "LastName41", "123123", "123123", "Student" },
                    { new Guid("e3b1087d-6e3a-49d0-adcd-67459e2f84ed"), "10", "Email50@gmail.com", "FirstName50", false, "LastName50", "123123", "123123", "Student" },
                    { new Guid("e87a8bdd-299f-4619-b917-67b76eee3c99"), "10", "Email51@gmail.com", "FirstName51", false, "LastName51", "123123", "123123", "Student" },
                    { new Guid("e9d1742d-997e-48b0-8441-1a4fefe10b3e"), "10", "Email97@gmail.com", "FirstName97", false, "LastName97", "123123", "123123", "Student" },
                    { new Guid("ec42b80d-7dc5-4edb-8e9c-366733feb245"), "10", "Email9@gmail.com", "FirstName9", false, "LastName9", "123123", "123123", "Student" },
                    { new Guid("edb5297f-61ae-41f0-9a36-9350614b759f"), "10", "Email0@gmail.com", "FirstName0", false, "LastName0", "123123", "123123", "Student" },
                    { new Guid("f12c912f-1dd3-48ab-be75-ba7956a2e515"), "10", "Email52@gmail.com", "FirstName52", false, "LastName52", "123123", "123123", "Student" },
                    { new Guid("f1b81755-ec14-4d02-b8c9-e3d5fa283c31"), "10", "Email81@gmail.com", "FirstName81", false, "LastName81", "123123", "123123", "Student" },
                    { new Guid("f1d06f83-4344-4758-83a5-ea6f010520ce"), "10", "Email24@gmail.com", "FirstName24", false, "LastName24", "123123", "123123", "Student" },
                    { new Guid("f364e560-1dfa-4d64-99c0-bcf93ae4acab"), "10", "Email15@gmail.com", "FirstName15", false, "LastName15", "123123", "123123", "Student" },
                    { new Guid("f6047979-de63-4ef9-bfc6-ffe998546539"), "10", "Email21@gmail.com", "FirstName21", false, "LastName21", "123123", "123123", "Student" },
                    { new Guid("fdd5f1d6-d6b2-4232-9ade-8a7eaffb9d11"), "10", "Email80@gmail.com", "FirstName80", false, "LastName80", "123123", "123123", "Student" },
                    { new Guid("fe070dba-2fa2-4d9a-97f7-d9953789814a"), "10", "Email18@gmail.com", "FirstName18", false, "LastName18", "123123", "123123", "Student" }
                });
        }
    }
}
