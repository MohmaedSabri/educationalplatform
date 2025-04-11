using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AddArabicDataSeedingWithLongTitles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("140bcb5c-f798-4742-bea8-baf339efed54"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("de010548-23e7-4a65-ad58-e6d5a9fd41a3"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2751d8aa-1766-4e26-9215-eea8822cea54"), new Guid("78ab8f66-e864-4e65-bacb-8263595dff66") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2751d8aa-1766-4e26-9215-eea8822cea54"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("78ab8f66-e864-4e65-bacb-8263595dff66"));

            migrationBuilder.AddColumn<DateTime>(
                name: "EnrollmentDate",
                table: "StudentCourses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "StudentCourses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Lessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 4, 10, 11, 52, 27, 731, DateTimeKind.Local).AddTicks(9512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 16, 23, 11, 36, 914, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Exams",
                type: "nvarchar(250)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("13860db6-9768-4bc2-8e6f-4e3bbc2f6fda"), null, "Assistant", "ASSISTANT" },
                    { new Guid("65a67234-cdab-433d-bcf1-60a0e88907cd"), null, "Teacher", "TEACHER" },
                    { new Guid("fdc6ff15-70f6-4771-9ebb-67f945306de3"), null, "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("182b54eb-d431-4016-9545-04bb5ee205f9"), 0, "92467712-efa5-42c6-88e6-dff8c72a1111", "AppUser", "Admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAEINP4/Tp27HM12j+3Otp1OuEpqQE0gpqSm6i6XOBd7GwMrrPkYHqgJo+3wROGuZHyg==", null, false, null, null, "", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "ParentPhone", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SName", "SecurityStamp", "TName", "TwoFactorEnabled", "UserName", "year" },
                values: new object[,]
                {
                    { new Guid("41906696-d1a6-4bf6-8f35-8fe9e3ddb7d2"), 0, "6111a6c9-afb5-4013-8836-9cc44d58d480", "Student", "student4@example.com", true, "علي", false, null, "STUDENT4@EXAMPLE.COM", "STUDENT4", "01001679915", "AQAAAAIAAYagAAAAEMITv9aisLCcBtEv7jJdDs330H4UI8smfIul/mghbf/apzB8adE+baRcjkIfH2hM2g==", null, false, null, null, "حسين", "", "حسن", false, "student4", 2024 },
                    { new Guid("441baea8-ba1a-40c6-bc9b-27ddcff7dd10"), 0, "894b27dc-dab3-40b7-8942-00a7a588f65d", "Student", "student5@example.com", true, "يوسف", false, null, "STUDENT5@EXAMPLE.COM", "STUDENT5", "01007044546", "AQAAAAIAAYagAAAAEOvro/2RsOFk6ERie3qfsafIs7oonR04JiRSC5aD4rdGej/q3lr6/5GhNEPglUOwvw==", null, false, null, null, "مصطفى", "", "عبدالعزيز", false, "student5", 2024 },
                    { new Guid("6c010b6a-0d42-490a-b3af-3d1b19aec676"), 0, "4b1bbef6-7d0e-4993-8bd6-789359e1bc4f", "Student", "student10@example.com", true, "زياد", false, null, "STUDENT10@EXAMPLE.COM", "STUDENT10", "01002568613", "AQAAAAIAAYagAAAAEFS75yaBAtpBV+YJfiMDp2QO1YMyBqS73hxJ1G59cuJRN0cq8Pti0wR1okSJtf6ZfA==", null, false, null, null, "المصري", "", "محمود", false, "student10", 2024 },
                    { new Guid("6ea2a8fa-36b1-4c34-8eaf-832a19f44e19"), 0, "5a02771a-e3ec-41e7-9467-ed0fbb1412ec", "Student", "student8@example.com", true, "حسن", false, null, "STUDENT8@EXAMPLE.COM", "STUDENT8", "01004379256", "AQAAAAIAAYagAAAAEKHHc4dtWEB9WJAAyEkuhK2X1Dktm33ffxl1zcub2zln9iH/GrgLLxslf7yx1tRqfA==", null, false, null, null, "إسماعيل", "", "العربي", false, "student8", 2024 },
                    { new Guid("7edbe094-17b1-4741-9082-dc0a28902272"), 0, "3cb0d718-7f7e-4688-bdbc-c06267dc61df", "Student", "student7@example.com", true, "إبراهيم", false, null, "STUDENT7@EXAMPLE.COM", "STUDENT7", "01008296763", "AQAAAAIAAYagAAAAEBKPMexkM1k7E359RH8zRnajVq8/1xVLyn4FcGJ7No9fqzsfuvYVxjPlYEEx6Eb2vg==", null, false, null, null, "الشافعي", "", "إبراهيم", false, "student7", 2024 },
                    { new Guid("8482fac0-379d-41fb-b46c-d57b6790a31c"), 0, "16ff4ce7-b881-4bf2-88ea-3118d43ff3c3", "Student", "student3@example.com", true, "عمر", false, null, "STUDENT3@EXAMPLE.COM", "STUDENT3", "01002475497", "AQAAAAIAAYagAAAAEHE72rt0jX9coUo5h2t6es0se6sHpVN2OG6RN6LP1w/nswmBB2IqbFQzIesGcPBUGg==", null, false, null, null, "العربي", "", "علي", false, "student3", 2024 },
                    { new Guid("c89a74d7-ade4-4d53-9ad8-d3d7a3d778f1"), 0, "4493350a-03e3-4c53-bb93-a498a376c54e", "Student", "student6@example.com", true, "عبدالله", false, null, "STUDENT6@EXAMPLE.COM", "STUDENT6", "01003813684", "AQAAAAIAAYagAAAAEP4pKdH46os3xu6Yvio60tmsvE6+553QyOBg4G8mj2nbLPeIlaN/5cOgnZxu+1yYuw==", null, false, null, null, "عثمان", "", "السيد", false, "student6", 2024 },
                    { new Guid("c8c1ae89-0be2-44df-a2b6-d5dd4807de3c"), 0, "b5a536a6-6e37-4b3a-98cb-e5b1924baedd", "Student", "student9@example.com", true, "خالد", false, null, "STUDENT9@EXAMPLE.COM", "STUDENT9", "01008789522", "AQAAAAIAAYagAAAAEKuY6aS2DuRV1R1uCDyh6DWF00OvV0GKgwV3Nh7fV+u3108KPNhWDYHT+4XXz73XyQ==", null, false, null, null, "عبدالرحمن", "", "مصطفى", false, "student9", 2024 },
                    { new Guid("d43ae3f5-659a-458a-949f-f56fac95c00c"), 0, "9baac3e6-35bf-4b66-addb-05a2ece47954", "Student", "student2@example.com", true, "أحمد", false, null, "STUDENT2@EXAMPLE.COM", "STUDENT2", "01004704844", "AQAAAAIAAYagAAAAECEH0f/2Rb9OOxHPVgLaa62a41k0cc5Dn9Oe5uOyFzbfK9NGsar/RdeNUJVUw/Fu3A==", null, false, null, null, "السيد", "", "محمد", false, "student2", 2024 },
                    { new Guid("e1aa04ca-694f-4efc-b90c-3d9cf54fbe96"), 0, "81224bfe-3393-4ad6-bf1e-efd94640e3ad", "Student", "student1@example.com", true, "محمد", false, null, "STUDENT1@EXAMPLE.COM", "STUDENT1", "01002225329", "AQAAAAIAAYagAAAAEAh1T/rnRIy64tEKNxfyDI1rbkYLtZLhvn2Dz7GkCInTik+SgvG3hqQmfwkoU/ToEA==", null, false, null, null, "محمود", "", "أحمد", false, "student1", 2024 }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "EndDate", "ImageUrl", "Price", "StartDate", "Title", "Year" },
                values: new object[,]
                {
                    { new Guid("3353a971-11b2-4f78-a997-51afe0829cc4"), "دورة متكاملة في الكيمياء العضوية مع شرح التفاعلات والمركبات الكيميائية", new DateTime(2025, 8, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(4598), "course3.jpg", 1500m, new DateTime(2025, 4, 13, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(4595), "الكيمياء العضوية للثانوية العامة", 2024 },
                    { new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), "شرح مفصل للفيزياء مع التركيز على المسائل العملية والتجارب المعملية", new DateTime(2025, 7, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(4591), "course2.jpg", 1000m, new DateTime(2025, 4, 12, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(4588), "الفيزياء التطبيقية للصف الثالث الثانوي", 2024 },
                    { new Guid("b8a0f844-c625-4e57-9a36-94979e8e12cb"), "دورة مكثفة في اللغة الإنجليزية تشمل القواعد والمحادثة والكتابة", new DateTime(2025, 10, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(4612), "course5.jpg", 2500m, new DateTime(2025, 4, 15, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(4609), "اللغة الإنجليزية - المستوى المتقدم", 2024 },
                    { new Guid("e6522e87-dddf-45aa-a8bb-d2e53c5714c3"), "دورة متخصصة في قواعد اللغة العربية والأدب مع تحليل النصوص الأدبية", new DateTime(2025, 9, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(4605), "course4.jpg", 2000m, new DateTime(2025, 4, 14, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(4602), "اللغة العربية - النحو والأدب", 2024 },
                    { new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), "دورة شاملة في الرياضيات تغطي المنهج الكامل للثانوية العامة مع حل مسائل وتمارين إضافية", new DateTime(2025, 6, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(4542), "course1.jpg", 500m, new DateTime(2025, 4, 11, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(4464), "الرياضيات المتقدمة للثانوية العامة", 2024 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("65a67234-cdab-433d-bcf1-60a0e88907cd"), new Guid("182b54eb-d431-4016-9545-04bb5ee205f9") },
                    { new Guid("fdc6ff15-70f6-4771-9ebb-67f945306de3"), new Guid("41906696-d1a6-4bf6-8f35-8fe9e3ddb7d2") },
                    { new Guid("fdc6ff15-70f6-4771-9ebb-67f945306de3"), new Guid("441baea8-ba1a-40c6-bc9b-27ddcff7dd10") },
                    { new Guid("fdc6ff15-70f6-4771-9ebb-67f945306de3"), new Guid("6c010b6a-0d42-490a-b3af-3d1b19aec676") },
                    { new Guid("fdc6ff15-70f6-4771-9ebb-67f945306de3"), new Guid("6ea2a8fa-36b1-4c34-8eaf-832a19f44e19") },
                    { new Guid("fdc6ff15-70f6-4771-9ebb-67f945306de3"), new Guid("7edbe094-17b1-4741-9082-dc0a28902272") },
                    { new Guid("fdc6ff15-70f6-4771-9ebb-67f945306de3"), new Guid("8482fac0-379d-41fb-b46c-d57b6790a31c") },
                    { new Guid("fdc6ff15-70f6-4771-9ebb-67f945306de3"), new Guid("c89a74d7-ade4-4d53-9ad8-d3d7a3d778f1") },
                    { new Guid("fdc6ff15-70f6-4771-9ebb-67f945306de3"), new Guid("c8c1ae89-0be2-44df-a2b6-d5dd4807de3c") },
                    { new Guid("fdc6ff15-70f6-4771-9ebb-67f945306de3"), new Guid("d43ae3f5-659a-458a-949f-f56fac95c00c") },
                    { new Guid("fdc6ff15-70f6-4771-9ebb-67f945306de3"), new Guid("e1aa04ca-694f-4efc-b90c-3d9cf54fbe96") }
                });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "Id", "Code", "CourseId", "Discount", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("072e6a1a-5f36-476a-9308-8e2c12ba6467"), "خصم423fa", new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), 25, new DateTime(2025, 5, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6953), new DateTime(2025, 4, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6949) },
                    { new Guid("126e9ffd-a509-4ff6-b3f5-9cbace6c0661"), "خصمb8a0f", new Guid("b8a0f844-c625-4e57-9a36-94979e8e12cb"), 25, new DateTime(2025, 5, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6987), new DateTime(2025, 4, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6983) },
                    { new Guid("5d280b0b-163a-4e44-99a8-d8583f32fd3d"), "خصم3353a", new Guid("3353a971-11b2-4f78-a997-51afe0829cc4"), 25, new DateTime(2025, 5, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6965), new DateTime(2025, 4, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6962) },
                    { new Guid("7ea3912f-90c1-4237-92af-920d4773f835"), "خصمe6522", new Guid("e6522e87-dddf-45aa-a8bb-d2e53c5714c3"), 25, new DateTime(2025, 5, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6976), new DateTime(2025, 4, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6973) },
                    { new Guid("e8c84f91-e8a0-4c18-b367-8316159d374e"), "خصمf8572", new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), 25, new DateTime(2025, 5, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6938), new DateTime(2025, 4, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6934) }
                });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Id", "CourseId", "DurationInMinutes", "StartDate", "StudentId", "Title" },
                values: new object[,]
                {
                    { new Guid("040f9cf1-08ee-42e1-8dd4-9ed60a5c6f54"), new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), 90, new DateTime(2025, 7, 3, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(4591), null, "الاختبار النهائي - الفيزياء التطبيقية للصف الثالث الثانوي" },
                    { new Guid("07911df9-c351-4daf-8896-f5cda5f1d1b8"), new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), 90, new DateTime(2025, 6, 3, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(4542), null, "الاختبار النهائي - الرياضيات المتقدمة للثانوية العامة" },
                    { new Guid("09038571-6a06-40c5-a8f8-0eda1a1a0888"), new Guid("3353a971-11b2-4f78-a997-51afe0829cc4"), 90, new DateTime(2025, 8, 3, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(4598), null, "الاختبار النهائي - الكيمياء العضوية للثانوية العامة" },
                    { new Guid("2a1d020b-f452-49ae-a7db-8f513e7de73d"), new Guid("e6522e87-dddf-45aa-a8bb-d2e53c5714c3"), 90, new DateTime(2025, 9, 3, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(4605), null, "الاختبار النهائي - اللغة العربية - النحو والأدب" },
                    { new Guid("c939d2f1-3cf1-4fd2-836a-49a636dee20d"), new Guid("b8a0f844-c625-4e57-9a36-94979e8e12cb"), 90, new DateTime(2025, 10, 3, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(4612), null, "الاختبار النهائي - اللغة الإنجليزية - المستوى المتقدم" }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "CreatedAt", "Description", "IsFree", "PdfUrl", "Title", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("0c12f8b6-292b-4d31-8d73-c1924cb3352f"), new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new DateTime(2025, 4, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(5375), "شرح تفصيلي لالحركة والقوة في مادة الفيزياء التطبيقية للصف الثالث الثانوي", false, "lesson_الفيزياء التطبيقية للصف الثالث الثانوي_2.pdf", "الحركة والقوة", "video_الفيزياء التطبيقية للصف الثالث الثانوي_2.mp4" },
                    { new Guid("0eb8132e-c1de-4413-a9c6-d86023b24b3a"), new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new DateTime(2025, 4, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(5271), "شرح تفصيلي لالمفاهيم الأساسية في مادة الرياضيات المتقدمة للثانوية العامة", false, "lesson_الرياضيات المتقدمة للثانوية العامة_2.pdf", "المفاهيم الأساسية", "video_الرياضيات المتقدمة للثانوية العامة_2.mp4" },
                    { new Guid("13590ac6-c31f-4294-9e9b-f9fd5243a691"), new Guid("3353a971-11b2-4f78-a997-51afe0829cc4"), new DateTime(2025, 4, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(5416), "شرح تفصيلي لالتجارب المعملية في مادة الكيمياء العضوية للثانوية العامة", false, "lesson_الكيمياء العضوية للثانوية العامة_4.pdf", "التجارب المعملية", "video_الكيمياء العضوية للثانوية العامة_4.mp4" },
                    { new Guid("16b521db-2d96-4835-8ff5-a4603e8a15bd"), new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new DateTime(2025, 4, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(5339), "شرح تفصيلي لالمراجعة النهائية في مادة الرياضيات المتقدمة للثانوية العامة", false, "lesson_الرياضيات المتقدمة للثانوية العامة_4.pdf", "المراجعة النهائية", "video_الرياضيات المتقدمة للثانوية العامة_4.mp4" },
                    { new Guid("28617e47-cb6c-4859-ba25-e825e8e49b3d"), new Guid("b8a0f844-c625-4e57-9a36-94979e8e12cb"), new DateTime(2025, 4, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(5457), "شرح تفصيلي لمهارات المحادثة في مادة اللغة الإنجليزية - المستوى المتقدم", false, "lesson_اللغة الإنجليزية - المستوى المتقدم_2.pdf", "مهارات المحادثة", "video_اللغة الإنجليزية - المستوى المتقدم_2.mp4" },
                    { new Guid("3b5a097c-7110-4401-9c79-a4d2903ba499"), new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new DateTime(2025, 4, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(5386), "شرح تفصيلي لالتطبيقات العملية في مادة الفيزياء التطبيقية للصف الثالث الثانوي", false, "lesson_الفيزياء التطبيقية للصف الثالث الثانوي_4.pdf", "التطبيقات العملية", "video_الفيزياء التطبيقية للصف الثالث الثانوي_4.mp4" },
                    { new Guid("4d685898-e389-4fa8-8ffe-153d81787411"), new Guid("e6522e87-dddf-45aa-a8bb-d2e53c5714c3"), new DateTime(2025, 4, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(5444), "شرح تفصيلي لالتعبير الكتابي في مادة اللغة العربية - النحو والأدب", false, "lesson_اللغة العربية - النحو والأدب_4.pdf", "التعبير الكتابي", "video_اللغة العربية - النحو والأدب_4.mp4" },
                    { new Guid("5b547919-e79a-41eb-8ce1-f3eb0e493bf2"), new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new DateTime(2025, 4, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(5257), "شرح تفصيلي لمقدمة وأساسيات في مادة الرياضيات المتقدمة للثانوية العامة", true, "lesson_الرياضيات المتقدمة للثانوية العامة_1.pdf", "مقدمة وأساسيات", "video_الرياضيات المتقدمة للثانوية العامة_1.mp4" },
                    { new Guid("5b8249ec-669d-4cc7-9228-6485151149ad"), new Guid("3353a971-11b2-4f78-a997-51afe0829cc4"), new DateTime(2025, 4, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(5400), "شرح تفصيلي لالمركبات العضوية في مادة الكيمياء العضوية للثانوية العامة", true, "lesson_الكيمياء العضوية للثانوية العامة_1.pdf", "المركبات العضوية", "video_الكيمياء العضوية للثانوية العامة_1.mp4" },
                    { new Guid("6fbca84f-edbc-4946-b34a-d6acee79f5cd"), new Guid("e6522e87-dddf-45aa-a8bb-d2e53c5714c3"), new DateTime(2025, 4, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(5429), "شرح تفصيلي لالبلاغة في مادة اللغة العربية - النحو والأدب", false, "lesson_اللغة العربية - النحو والأدب_2.pdf", "البلاغة", "video_اللغة العربية - النحو والأدب_2.mp4" },
                    { new Guid("79fcfc34-1f40-433f-9a53-c54fbc0d35c6"), new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new DateTime(2025, 4, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(5381), "شرح تفصيلي لالطاقة والشغل في مادة الفيزياء التطبيقية للصف الثالث الثانوي", false, "lesson_الفيزياء التطبيقية للصف الثالث الثانوي_3.pdf", "الطاقة والشغل", "video_الفيزياء التطبيقية للصف الثالث الثانوي_3.mp4" },
                    { new Guid("95de1535-98a9-4d66-81d1-6a5b883e5702"), new Guid("e6522e87-dddf-45aa-a8bb-d2e53c5714c3"), new DateTime(2025, 4, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(5423), "شرح تفصيلي لقواعد النحو في مادة اللغة العربية - النحو والأدب", true, "lesson_اللغة العربية - النحو والأدب_1.pdf", "قواعد النحو", "video_اللغة العربية - النحو والأدب_1.mp4" },
                    { new Guid("997590f1-916f-4358-91d2-26fc7c7d5068"), new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new DateTime(2025, 4, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(5277), "شرح تفصيلي لتمارين وتطبيقات في مادة الرياضيات المتقدمة للثانوية العامة", false, "lesson_الرياضيات المتقدمة للثانوية العامة_3.pdf", "تمارين وتطبيقات", "video_الرياضيات المتقدمة للثانوية العامة_3.mp4" },
                    { new Guid("9c2abc9b-9dbf-4d1c-a4fc-0671202c28a9"), new Guid("b8a0f844-c625-4e57-9a36-94979e8e12cb"), new DateTime(2025, 4, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(5531), "شرح تفصيلي لفهم النصوص في مادة اللغة الإنجليزية - المستوى المتقدم", false, "lesson_اللغة الإنجليزية - المستوى المتقدم_3.pdf", "فهم النصوص", "video_اللغة الإنجليزية - المستوى المتقدم_3.mp4" },
                    { new Guid("a8c0b759-cf83-48f6-a4c2-ffcd06402451"), new Guid("e6522e87-dddf-45aa-a8bb-d2e53c5714c3"), new DateTime(2025, 4, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(5439), "شرح تفصيلي لتحليل النصوص في مادة اللغة العربية - النحو والأدب", false, "lesson_اللغة العربية - النحو والأدب_3.pdf", "تحليل النصوص", "video_اللغة العربية - النحو والأدب_3.mp4" },
                    { new Guid("b9e0938b-a352-4ca7-a167-9c94ea951c9e"), new Guid("b8a0f844-c625-4e57-9a36-94979e8e12cb"), new DateTime(2025, 4, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(5542), "شرح تفصيلي لالكتابة الإبداعية في مادة اللغة الإنجليزية - المستوى المتقدم", false, "lesson_اللغة الإنجليزية - المستوى المتقدم_4.pdf", "الكتابة الإبداعية", "video_اللغة الإنجليزية - المستوى المتقدم_4.mp4" },
                    { new Guid("d36c235e-89e8-40cf-aa93-541099b4ed78"), new Guid("b8a0f844-c625-4e57-9a36-94979e8e12cb"), new DateTime(2025, 4, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(5451), "شرح تفصيلي لالقواعد المتقدمة في مادة اللغة الإنجليزية - المستوى المتقدم", true, "lesson_اللغة الإنجليزية - المستوى المتقدم_1.pdf", "القواعد المتقدمة", "video_اللغة الإنجليزية - المستوى المتقدم_1.mp4" },
                    { new Guid("ee253947-401a-46b4-b9ac-e1382313060b"), new Guid("3353a971-11b2-4f78-a997-51afe0829cc4"), new DateTime(2025, 4, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(5407), "شرح تفصيلي لالتفاعلات الكيميائية في مادة الكيمياء العضوية للثانوية العامة", false, "lesson_الكيمياء العضوية للثانوية العامة_2.pdf", "التفاعلات الكيميائية", "video_الكيمياء العضوية للثانوية العامة_2.mp4" },
                    { new Guid("f2368062-0878-4681-95c0-babf0dee955c"), new Guid("3353a971-11b2-4f78-a997-51afe0829cc4"), new DateTime(2025, 4, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(5411), "شرح تفصيلي لالمجموعات الوظيفية في مادة الكيمياء العضوية للثانوية العامة", false, "lesson_الكيمياء العضوية للثانوية العامة_3.pdf", "المجموعات الوظيفية", "video_الكيمياء العضوية للثانوية العامة_3.mp4" },
                    { new Guid("f9fbae30-03f3-4c22-9e60-a29698b2b0e9"), new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new DateTime(2025, 4, 10, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(5348), "شرح تفصيلي لالقوانين الأساسية في مادة الفيزياء التطبيقية للصف الثالث الثانوي", true, "lesson_الفيزياء التطبيقية للصف الثالث الثانوي_1.pdf", "القوانين الأساسية", "video_الفيزياء التطبيقية للصف الثالث الثانوي_1.mp4" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "CourseId", "Date", "Status", "StudentId" },
                values: new object[,]
                {
                    { new Guid("116f54e0-163a-4c3d-95d2-03213ce1917f"), 500m, new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new DateTime(2025, 3, 17, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6771), "مكتمل", new Guid("441baea8-ba1a-40c6-bc9b-27ddcff7dd10") },
                    { new Guid("26633807-5ca5-4877-8ea0-c7cd6c29da79"), 500m, new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new DateTime(2025, 4, 8, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6698), "مكتمل", new Guid("d43ae3f5-659a-458a-949f-f56fac95c00c") },
                    { new Guid("29671848-c658-4952-ab84-e74a147b67a7"), 500m, new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new DateTime(2025, 4, 8, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6811), "مكتمل", new Guid("c8c1ae89-0be2-44df-a2b6-d5dd4807de3c") },
                    { new Guid("3434d8e0-6c28-428d-a89b-c8a8e5b3d1f8"), 1000m, new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new DateTime(2025, 3, 29, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6816), "مكتمل", new Guid("c8c1ae89-0be2-44df-a2b6-d5dd4807de3c") },
                    { new Guid("35cc07e5-f436-40c4-95a0-93a8e7dd53c8"), 500m, new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new DateTime(2025, 3, 14, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6782), "مكتمل", new Guid("c89a74d7-ade4-4d53-9ad8-d3d7a3d778f1") },
                    { new Guid("418f3325-cbac-48c1-a8a7-66522e45bcbb"), 1000m, new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new DateTime(2025, 4, 4, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6778), "مكتمل", new Guid("441baea8-ba1a-40c6-bc9b-27ddcff7dd10") },
                    { new Guid("4c1eff16-04d8-4fec-8768-e1afdc206675"), 1000m, new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new DateTime(2025, 3, 27, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6727), "مكتمل", new Guid("41906696-d1a6-4bf6-8f35-8fe9e3ddb7d2") },
                    { new Guid("5266f730-d81b-4555-95de-ed99f2347e84"), 500m, new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new DateTime(2025, 4, 5, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6722), "مكتمل", new Guid("41906696-d1a6-4bf6-8f35-8fe9e3ddb7d2") },
                    { new Guid("788c3d92-41dc-4439-a7e1-eaca8c9e0768"), 500m, new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new DateTime(2025, 4, 4, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6820), "مكتمل", new Guid("6c010b6a-0d42-490a-b3af-3d1b19aec676") },
                    { new Guid("7c534eb3-7f8c-49a0-9e1d-b56820c47a45"), 1000m, new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new DateTime(2025, 4, 1, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6681), "مكتمل", new Guid("e1aa04ca-694f-4efc-b90c-3d9cf54fbe96") },
                    { new Guid("87e5aa93-94a9-4243-aeb5-e058dbd5762e"), 1000m, new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new DateTime(2025, 3, 28, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6796), "مكتمل", new Guid("7edbe094-17b1-4741-9082-dc0a28902272") },
                    { new Guid("89cf4400-7946-4839-a0dd-e3abc4bfe65d"), 1000m, new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new DateTime(2025, 3, 15, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6807), "مكتمل", new Guid("6ea2a8fa-36b1-4c34-8eaf-832a19f44e19") },
                    { new Guid("8a447731-5fc2-417b-b1b0-abe47cdaefe9"), 1000m, new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new DateTime(2025, 4, 2, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6703), "مكتمل", new Guid("d43ae3f5-659a-458a-949f-f56fac95c00c") },
                    { new Guid("8a5b5aff-2ee9-4575-92ee-73de21b9c36b"), 1000m, new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new DateTime(2025, 4, 6, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6716), "مكتمل", new Guid("8482fac0-379d-41fb-b46c-d57b6790a31c") },
                    { new Guid("8b9891a5-7549-4e6e-b87a-928efd20ed57"), 1000m, new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new DateTime(2025, 3, 15, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6831), "مكتمل", new Guid("6c010b6a-0d42-490a-b3af-3d1b19aec676") },
                    { new Guid("93b8af27-dc1f-4aaa-9498-fd43c5646f9f"), 500m, new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new DateTime(2025, 3, 22, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6803), "مكتمل", new Guid("6ea2a8fa-36b1-4c34-8eaf-832a19f44e19") },
                    { new Guid("a19c2d08-3b21-4b25-889e-4de8ea9f2eb9"), 1000m, new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new DateTime(2025, 3, 21, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6787), "مكتمل", new Guid("c89a74d7-ade4-4d53-9ad8-d3d7a3d778f1") },
                    { new Guid("b96acfca-6b1c-4eeb-9e1a-d7d488abcef8"), 500m, new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new DateTime(2025, 3, 14, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6670), "مكتمل", new Guid("e1aa04ca-694f-4efc-b90c-3d9cf54fbe96") },
                    { new Guid("d6ce4396-e5c4-4df8-acd1-3eba25203f8c"), 500m, new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new DateTime(2025, 4, 9, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6792), "مكتمل", new Guid("7edbe094-17b1-4741-9082-dc0a28902272") },
                    { new Guid("f1ecd094-71ae-4007-b4d6-a902c7a3880f"), 500m, new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new DateTime(2025, 3, 18, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6707), "مكتمل", new Guid("8482fac0-379d-41fb-b46c-d57b6790a31c") }
                });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId", "EnrollmentDate", "Id" },
                values: new object[,]
                {
                    { new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new Guid("41906696-d1a6-4bf6-8f35-8fe9e3ddb7d2"), new DateTime(2025, 3, 17, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6398), new Guid("3544e873-8d6e-4e4b-814f-cc12ac77a4c6") },
                    { new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new Guid("41906696-d1a6-4bf6-8f35-8fe9e3ddb7d2"), new DateTime(2025, 4, 7, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6394), new Guid("e06c678b-fb43-4831-9f83-9285220ea0cb") },
                    { new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new Guid("441baea8-ba1a-40c6-bc9b-27ddcff7dd10"), new DateTime(2025, 3, 16, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6412), new Guid("460d9a9a-8041-4ef2-9adb-96dd5c70c6ca") },
                    { new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new Guid("441baea8-ba1a-40c6-bc9b-27ddcff7dd10"), new DateTime(2025, 4, 2, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6408), new Guid("17c8fdf5-3d87-491d-bd77-5c8f3feaea16") },
                    { new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new Guid("6c010b6a-0d42-490a-b3af-3d1b19aec676"), new DateTime(2025, 3, 14, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6456), new Guid("372cda51-8820-41ca-9ccf-7542eed2450d") },
                    { new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new Guid("6c010b6a-0d42-490a-b3af-3d1b19aec676"), new DateTime(2025, 3, 13, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6453), new Guid("35e9678a-5dab-459f-93dd-d99371799646") },
                    { new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new Guid("6ea2a8fa-36b1-4c34-8eaf-832a19f44e19"), new DateTime(2025, 3, 21, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6438), new Guid("e3bcb949-e7d7-4fcd-93a8-3c97854a05be") },
                    { new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new Guid("6ea2a8fa-36b1-4c34-8eaf-832a19f44e19"), new DateTime(2025, 3, 29, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6434), new Guid("d0cfcc9a-ce67-4879-844c-968c585c9242") },
                    { new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new Guid("7edbe094-17b1-4741-9082-dc0a28902272"), new DateTime(2025, 3, 17, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6430), new Guid("d3cc06cd-b586-4503-b3f4-d68e98fe0cfd") },
                    { new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new Guid("7edbe094-17b1-4741-9082-dc0a28902272"), new DateTime(2025, 3, 27, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6426), new Guid("d21f1426-1c42-4583-8f5b-bf641218832c") },
                    { new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new Guid("8482fac0-379d-41fb-b46c-d57b6790a31c"), new DateTime(2025, 3, 19, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6390), new Guid("afaa2624-c730-4e4b-b266-516bd52feb31") },
                    { new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new Guid("8482fac0-379d-41fb-b46c-d57b6790a31c"), new DateTime(2025, 3, 19, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6386), new Guid("b03ed3d8-96ee-4698-a09e-2fc262533a8c") },
                    { new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new Guid("c89a74d7-ade4-4d53-9ad8-d3d7a3d778f1"), new DateTime(2025, 3, 23, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6422), new Guid("030dcc02-3f68-4605-80e8-e9562538b006") },
                    { new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new Guid("c89a74d7-ade4-4d53-9ad8-d3d7a3d778f1"), new DateTime(2025, 3, 15, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6418), new Guid("72cc5203-4804-41fa-b209-f55d07aa2c7e") },
                    { new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new Guid("c8c1ae89-0be2-44df-a2b6-d5dd4807de3c"), new DateTime(2025, 4, 3, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6447), new Guid("2e416991-d25c-4445-9ea7-d4dfd89b4cff") },
                    { new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new Guid("c8c1ae89-0be2-44df-a2b6-d5dd4807de3c"), new DateTime(2025, 3, 26, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6443), new Guid("225d140d-a013-462e-981a-943362a76e5d") },
                    { new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new Guid("d43ae3f5-659a-458a-949f-f56fac95c00c"), new DateTime(2025, 3, 28, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6381), new Guid("f7ea9064-ce46-483e-ad96-149ddf0af758") },
                    { new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new Guid("d43ae3f5-659a-458a-949f-f56fac95c00c"), new DateTime(2025, 3, 22, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6377), new Guid("ba5e1c7b-3b77-45de-8846-e999cf7223a4") },
                    { new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new Guid("e1aa04ca-694f-4efc-b90c-3d9cf54fbe96"), new DateTime(2025, 3, 27, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6360), new Guid("a67e5175-9b9a-419e-beb6-15825aa2ac82") },
                    { new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new Guid("e1aa04ca-694f-4efc-b90c-3d9cf54fbe96"), new DateTime(2025, 3, 13, 11, 52, 28, 341, DateTimeKind.Local).AddTicks(6336), new Guid("5dda4ef0-055b-4d92-a1b3-2eb416b979d8") }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Answer", "ExamId", "QuestionDescription" },
                values: new object[,]
                {
                    { new Guid("0b804058-92af-490c-820f-60401b6d44ff"), "الإجابة الصحيحة 1", new Guid("2a1d020b-f452-49ae-a7db-8f513e7de73d"), "السؤال الأول في الاختبار النهائي - اللغة العربية - النحو والأدب" },
                    { new Guid("12f4c332-5e13-40be-ab80-9621443fe9d2"), "الإجابة الصحيحة 4", new Guid("07911df9-c351-4daf-8896-f5cda5f1d1b8"), "ما هو مجال الدالة الجذرية √(س-1)؟" },
                    { new Guid("136d2ee5-cc72-4814-9e12-3e7c32617fff"), "الإجابة الصحيحة 3", new Guid("09038571-6a06-40c5-a8f8-0eda1a1a0888"), "السؤال الثالث في الاختبار النهائي - الكيمياء العضوية للثانوية العامة" },
                    { new Guid("1a252041-ccc4-4897-9892-9cff00ba15bb"), "الإجابة الصحيحة 2", new Guid("040f9cf1-08ee-42e1-8dd4-9ed60a5c6f54"), "كيف تحسب الطاقة الحركية لجسم؟" },
                    { new Guid("20cd2b95-f246-458a-a909-6d2cceaefcb0"), "الإجابة الصحيحة 4", new Guid("040f9cf1-08ee-42e1-8dd4-9ed60a5c6f54"), "اشرح مبدأ حفظ الطاقة" },
                    { new Guid("2427299d-bcf5-483f-bd55-930908251b48"), "الإجابة الصحيحة 5", new Guid("c939d2f1-3cf1-4fd2-836a-49a636dee20d"), "السؤال الخامس في الاختبار النهائي - اللغة الإنجليزية - المستوى المتقدم" },
                    { new Guid("2ace33bc-84ad-4eea-9743-1c35a99e6d79"), "الإجابة الصحيحة 3", new Guid("040f9cf1-08ee-42e1-8dd4-9ed60a5c6f54"), "ما هي وحدة قياس القوة في النظام الدولي؟" },
                    { new Guid("40330b62-3d6a-427e-b87f-06cd8e2cdddd"), "الإجابة الصحيحة 1", new Guid("07911df9-c351-4daf-8896-f5cda5f1d1b8"), "ما هو حل المعادلة س²+ 4س + 4 = 0؟" },
                    { new Guid("4040c0b8-1822-444e-a6e3-cefefa3df0c7"), "الإجابة الصحيحة 2", new Guid("07911df9-c351-4daf-8896-f5cda5f1d1b8"), "ما هي قيمة النهاية عندما س تقترب من 2؟" },
                    { new Guid("4301af88-cacf-4bf9-9e8c-0b9a5a1baef3"), "الإجابة الصحيحة 3", new Guid("2a1d020b-f452-49ae-a7db-8f513e7de73d"), "السؤال الثالث في الاختبار النهائي - اللغة العربية - النحو والأدب" },
                    { new Guid("65a3b0cb-6c69-4c65-b895-d0083f3fc869"), "الإجابة الصحيحة 5", new Guid("09038571-6a06-40c5-a8f8-0eda1a1a0888"), "السؤال الخامس في الاختبار النهائي - الكيمياء العضوية للثانوية العامة" },
                    { new Guid("662d775e-c5f3-468a-a819-28e9a75a0d18"), "الإجابة الصحيحة 2", new Guid("c939d2f1-3cf1-4fd2-836a-49a636dee20d"), "السؤال الثاني في الاختبار النهائي - اللغة الإنجليزية - المستوى المتقدم" },
                    { new Guid("714d9e89-b3d5-419f-9201-ebf58e3ca1b9"), "الإجابة الصحيحة 4", new Guid("c939d2f1-3cf1-4fd2-836a-49a636dee20d"), "السؤال الرابع في الاختبار النهائي - اللغة الإنجليزية - المستوى المتقدم" },
                    { new Guid("844ed8cc-b48d-434c-887f-acae05dc9924"), "الإجابة الصحيحة 2", new Guid("2a1d020b-f452-49ae-a7db-8f513e7de73d"), "السؤال الثاني في الاختبار النهائي - اللغة العربية - النحو والأدب" },
                    { new Guid("98282142-f9c6-4a4d-8ee7-acbb9c94a744"), "الإجابة الصحيحة 4", new Guid("09038571-6a06-40c5-a8f8-0eda1a1a0888"), "السؤال الرابع في الاختبار النهائي - الكيمياء العضوية للثانوية العامة" },
                    { new Guid("a8024ded-9c15-4f12-b771-8c09f1ca95e2"), "الإجابة الصحيحة 5", new Guid("040f9cf1-08ee-42e1-8dd4-9ed60a5c6f54"), "ما هو قانون أوم؟" },
                    { new Guid("aa40ce8b-26ac-40db-8f59-c32e0a765265"), "الإجابة الصحيحة 5", new Guid("07911df9-c351-4daf-8896-f5cda5f1d1b8"), "احسب مساحة المثلث الذي أطواله 3، 4، 5" },
                    { new Guid("b0c48106-715f-48ba-87d0-aeb27ac5231d"), "الإجابة الصحيحة 2", new Guid("09038571-6a06-40c5-a8f8-0eda1a1a0888"), "السؤال الثاني في الاختبار النهائي - الكيمياء العضوية للثانوية العامة" },
                    { new Guid("b38edf74-351d-4e28-a2a0-9f5d85fd0301"), "الإجابة الصحيحة 3", new Guid("c939d2f1-3cf1-4fd2-836a-49a636dee20d"), "السؤال الثالث في الاختبار النهائي - اللغة الإنجليزية - المستوى المتقدم" },
                    { new Guid("be03d07d-4582-4bbc-9ab2-35ba6d5b3f79"), "الإجابة الصحيحة 5", new Guid("2a1d020b-f452-49ae-a7db-8f513e7de73d"), "السؤال الخامس في الاختبار النهائي - اللغة العربية - النحو والأدب" },
                    { new Guid("bfc108f4-c6ea-401f-bdd8-9f1fc1b0eebb"), "الإجابة الصحيحة 1", new Guid("040f9cf1-08ee-42e1-8dd4-9ed60a5c6f54"), "ما هو قانون نيوتن الثالث؟" },
                    { new Guid("d6ce13b8-251f-422e-b153-82accea0d750"), "الإجابة الصحيحة 1", new Guid("09038571-6a06-40c5-a8f8-0eda1a1a0888"), "السؤال الأول في الاختبار النهائي - الكيمياء العضوية للثانوية العامة" },
                    { new Guid("dd5da33a-017f-46f1-af86-85ff24902d70"), "الإجابة الصحيحة 3", new Guid("07911df9-c351-4daf-8896-f5cda5f1d1b8"), "ما هو التكامل غير المحدد للدالة 2س + 1؟" },
                    { new Guid("f2eeb56d-f800-46ee-8461-b13ea5f489a5"), "الإجابة الصحيحة 1", new Guid("c939d2f1-3cf1-4fd2-836a-49a636dee20d"), "السؤال الأول في الاختبار النهائي - اللغة الإنجليزية - المستوى المتقدم" },
                    { new Guid("fe8da9d8-0bf0-468e-8596-2e96e0dd97ce"), "الإجابة الصحيحة 4", new Guid("2a1d020b-f452-49ae-a7db-8f513e7de73d"), "السؤال الرابع في الاختبار النهائي - اللغة العربية - النحو والأدب" }
                });

            migrationBuilder.InsertData(
                table: "QuestionChoices",
                columns: new[] { "Id", "Choice", "QuestionId" },
                values: new object[,]
                {
                    { new Guid("03e4454f-dc86-4442-92a7-7a219c698eea"), "الاختيار 2", new Guid("1a252041-ccc4-4897-9892-9cff00ba15bb") },
                    { new Guid("0a84937c-d017-4bff-b57a-8e072576df8d"), "الاختيار 2", new Guid("65a3b0cb-6c69-4c65-b895-d0083f3fc869") },
                    { new Guid("0d54c4ae-6a2f-4e8b-9ed6-298d2bf314f9"), "الاختيار 2", new Guid("b38edf74-351d-4e28-a2a0-9f5d85fd0301") },
                    { new Guid("0f623d94-056e-4c0d-9186-3da46c200f16"), "الاختيار 1", new Guid("4301af88-cacf-4bf9-9e8c-0b9a5a1baef3") },
                    { new Guid("10ae4e59-487d-4aec-94fd-b5659c1db7cc"), "الاختيار 2", new Guid("a8024ded-9c15-4f12-b771-8c09f1ca95e2") },
                    { new Guid("121ce5b2-18df-4c0a-82a4-0a9709cba120"), "الاختيار 2", new Guid("f2eeb56d-f800-46ee-8461-b13ea5f489a5") },
                    { new Guid("1552fa26-c571-4c69-b255-0685fc731218"), "الاختيار 1", new Guid("98282142-f9c6-4a4d-8ee7-acbb9c94a744") },
                    { new Guid("15e00829-dc2d-47c7-878f-8bf099a405e9"), "الاختيار 3", new Guid("4040c0b8-1822-444e-a6e3-cefefa3df0c7") },
                    { new Guid("164b409d-0371-4a54-9ded-848df7378d76"), "الاختيار 4", new Guid("f2eeb56d-f800-46ee-8461-b13ea5f489a5") },
                    { new Guid("18caced7-9288-4a02-b4b9-49c72dad9ba8"), "الاختيار 2", new Guid("2ace33bc-84ad-4eea-9743-1c35a99e6d79") },
                    { new Guid("19c00c3f-62eb-4572-8526-1ab4de48fb7b"), "الاختيار 1", new Guid("bfc108f4-c6ea-401f-bdd8-9f1fc1b0eebb") },
                    { new Guid("1dde8a93-eaff-43e9-9ce6-a58e9ee38fd8"), "الاختيار 4", new Guid("98282142-f9c6-4a4d-8ee7-acbb9c94a744") },
                    { new Guid("2124ca55-c60a-4940-b429-71e6183be2cb"), "الاختيار 1", new Guid("136d2ee5-cc72-4814-9e12-3e7c32617fff") },
                    { new Guid("268a96d2-45d8-4846-a528-76897ee78e24"), "الاختيار 2", new Guid("b0c48106-715f-48ba-87d0-aeb27ac5231d") },
                    { new Guid("2b0495b3-3ecf-4af2-8caf-34b7075155b5"), "الاختيار 4", new Guid("2427299d-bcf5-483f-bd55-930908251b48") },
                    { new Guid("2e7cbe30-69e3-443d-a744-512e44ee8da5"), "الاختيار 2", new Guid("be03d07d-4582-4bbc-9ab2-35ba6d5b3f79") },
                    { new Guid("2fce610e-f9cd-4cd1-8d80-af2bffd796bb"), "الاختيار 2", new Guid("fe8da9d8-0bf0-468e-8596-2e96e0dd97ce") },
                    { new Guid("31cd965b-8f4e-440c-bbed-3a124c5f6d8b"), "الاختيار 2", new Guid("aa40ce8b-26ac-40db-8f59-c32e0a765265") },
                    { new Guid("31d427b0-3b2d-4390-a5ef-3980d7544fc1"), "الاختيار 3", new Guid("b38edf74-351d-4e28-a2a0-9f5d85fd0301") },
                    { new Guid("32259994-f725-48b1-9a53-0c152f0f2ad1"), "الاختيار 3", new Guid("b0c48106-715f-48ba-87d0-aeb27ac5231d") },
                    { new Guid("38a9aa7b-6d90-454d-a398-bbb1101b6f83"), "الاختيار 2", new Guid("0b804058-92af-490c-820f-60401b6d44ff") },
                    { new Guid("39657e51-ad6a-4cbd-afc6-7fff55587db8"), "الاختيار 4", new Guid("a8024ded-9c15-4f12-b771-8c09f1ca95e2") },
                    { new Guid("3fb361c8-8872-44ea-a934-0d1195373db4"), "الاختيار 4", new Guid("40330b62-3d6a-427e-b87f-06cd8e2cdddd") },
                    { new Guid("449cfe94-5476-4f2f-87dc-29e0b5c13122"), "الاختيار 2", new Guid("844ed8cc-b48d-434c-887f-acae05dc9924") },
                    { new Guid("45606629-82e9-4133-9646-03cafbdda061"), "الاختيار 3", new Guid("20cd2b95-f246-458a-a909-6d2cceaefcb0") },
                    { new Guid("4d2f55b0-2b2a-4948-a802-c6386c58c307"), "الاختيار 4", new Guid("b0c48106-715f-48ba-87d0-aeb27ac5231d") },
                    { new Guid("501640c9-8640-4f7d-855d-80412449775b"), "الاختيار 4", new Guid("662d775e-c5f3-468a-a819-28e9a75a0d18") },
                    { new Guid("50422e86-edf4-4aa4-8875-6532e86da0e0"), "الاختيار 4", new Guid("20cd2b95-f246-458a-a909-6d2cceaefcb0") },
                    { new Guid("5226bfbe-d6e9-4f93-b59a-fac0348bac26"), "الاختيار 1", new Guid("f2eeb56d-f800-46ee-8461-b13ea5f489a5") },
                    { new Guid("5267c32b-af74-4edd-9f23-a59c26a0cd29"), "الاختيار 3", new Guid("a8024ded-9c15-4f12-b771-8c09f1ca95e2") },
                    { new Guid("548c0916-dc1f-4af0-84b2-f61527ae05ff"), "الاختيار 2", new Guid("d6ce13b8-251f-422e-b153-82accea0d750") },
                    { new Guid("54e688c1-0ad9-464e-bd3d-d58162ba9172"), "الاختيار 1", new Guid("844ed8cc-b48d-434c-887f-acae05dc9924") },
                    { new Guid("54ee2fc4-719b-4a79-aaff-02f7e4e9c703"), "الاختيار 2", new Guid("12f4c332-5e13-40be-ab80-9621443fe9d2") },
                    { new Guid("554f595c-b24c-49ff-bc87-f0b05157c3e4"), "الاختيار 4", new Guid("0b804058-92af-490c-820f-60401b6d44ff") },
                    { new Guid("5804bbbc-613e-49cc-a441-30666dad0c56"), "الاختيار 4", new Guid("be03d07d-4582-4bbc-9ab2-35ba6d5b3f79") },
                    { new Guid("59b7eced-45b1-442b-bbdc-b403e03b9bd9"), "الاختيار 3", new Guid("662d775e-c5f3-468a-a819-28e9a75a0d18") },
                    { new Guid("5a34de42-dfd1-4b7a-befb-a2035285c824"), "الاختيار 1", new Guid("dd5da33a-017f-46f1-af86-85ff24902d70") },
                    { new Guid("5be0bae5-7e11-41e1-aa4b-8c16481a60a1"), "الاختيار 2", new Guid("40330b62-3d6a-427e-b87f-06cd8e2cdddd") },
                    { new Guid("61c4a5d8-ae6e-4e22-a0f7-3bc5ea48031c"), "الاختيار 1", new Guid("2427299d-bcf5-483f-bd55-930908251b48") },
                    { new Guid("69b59a43-e66e-41ad-8f84-127870f58b07"), "الاختيار 3", new Guid("65a3b0cb-6c69-4c65-b895-d0083f3fc869") },
                    { new Guid("6aa0382a-0d53-4ace-b1e2-d4140ab863a9"), "الاختيار 3", new Guid("1a252041-ccc4-4897-9892-9cff00ba15bb") },
                    { new Guid("6b17298d-3279-4262-9d8d-d5b92bb6b06e"), "الاختيار 2", new Guid("4040c0b8-1822-444e-a6e3-cefefa3df0c7") },
                    { new Guid("73058ae7-2c5d-4954-9790-51a0e0544737"), "الاختيار 2", new Guid("20cd2b95-f246-458a-a909-6d2cceaefcb0") },
                    { new Guid("7693f2d4-af27-4fa3-9f38-bb282190c1aa"), "الاختيار 4", new Guid("b38edf74-351d-4e28-a2a0-9f5d85fd0301") },
                    { new Guid("7af0ac90-5a57-4ca8-a0e9-3267fe67ef67"), "الاختيار 3", new Guid("be03d07d-4582-4bbc-9ab2-35ba6d5b3f79") },
                    { new Guid("7c6a90a3-9a6a-4736-b685-6e514bc63b95"), "الاختيار 4", new Guid("65a3b0cb-6c69-4c65-b895-d0083f3fc869") },
                    { new Guid("7fc5aad1-6dda-4f15-be10-42d711fa11d7"), "الاختيار 4", new Guid("714d9e89-b3d5-419f-9201-ebf58e3ca1b9") },
                    { new Guid("80deade1-a49b-4fde-8283-63acd6dbfee7"), "الاختيار 3", new Guid("fe8da9d8-0bf0-468e-8596-2e96e0dd97ce") },
                    { new Guid("86562fb7-b4fd-4c01-bc21-b54d17fa185b"), "الاختيار 1", new Guid("714d9e89-b3d5-419f-9201-ebf58e3ca1b9") },
                    { new Guid("87222698-36f7-4577-806a-b25df457e994"), "الاختيار 1", new Guid("4040c0b8-1822-444e-a6e3-cefefa3df0c7") },
                    { new Guid("87812dee-e2d4-4810-96c4-8cc99d3552cf"), "الاختيار 3", new Guid("d6ce13b8-251f-422e-b153-82accea0d750") },
                    { new Guid("886b6fe2-4dc3-4ebb-8324-4db996a0fd5c"), "الاختيار 1", new Guid("b38edf74-351d-4e28-a2a0-9f5d85fd0301") },
                    { new Guid("8e5ea502-7a95-48d2-9e3a-0f624679865a"), "الاختيار 3", new Guid("40330b62-3d6a-427e-b87f-06cd8e2cdddd") },
                    { new Guid("8f617c39-5fbe-4d93-9932-37fb352c545a"), "الاختيار 2", new Guid("136d2ee5-cc72-4814-9e12-3e7c32617fff") },
                    { new Guid("953f851d-9821-463b-ac69-1d72c827e00e"), "الاختيار 1", new Guid("d6ce13b8-251f-422e-b153-82accea0d750") },
                    { new Guid("95eff022-b4fb-4d36-9807-b266a5755092"), "الاختيار 4", new Guid("dd5da33a-017f-46f1-af86-85ff24902d70") },
                    { new Guid("9a961485-a5e6-479e-b097-588be50d7a13"), "الاختيار 4", new Guid("d6ce13b8-251f-422e-b153-82accea0d750") },
                    { new Guid("9bc8c293-b96e-4344-810e-b6d61ae4935d"), "الاختيار 4", new Guid("136d2ee5-cc72-4814-9e12-3e7c32617fff") },
                    { new Guid("9e974197-d840-43b0-b207-6121bf5e057a"), "الاختيار 1", new Guid("be03d07d-4582-4bbc-9ab2-35ba6d5b3f79") },
                    { new Guid("a36818c4-6845-44a7-b07b-77a3c29ca9cd"), "الاختيار 4", new Guid("4301af88-cacf-4bf9-9e8c-0b9a5a1baef3") },
                    { new Guid("a8f8bfed-aa33-478c-8971-808c5937f48c"), "الاختيار 4", new Guid("1a252041-ccc4-4897-9892-9cff00ba15bb") },
                    { new Guid("aac9fdb3-6b27-4f22-ae38-cedd7af9868c"), "الاختيار 1", new Guid("40330b62-3d6a-427e-b87f-06cd8e2cdddd") },
                    { new Guid("ade48901-a56e-4b5f-8efd-91dcd9adfe5c"), "الاختيار 3", new Guid("136d2ee5-cc72-4814-9e12-3e7c32617fff") },
                    { new Guid("b1f56e5f-5cea-4b55-8904-b64a8e548fec"), "الاختيار 3", new Guid("714d9e89-b3d5-419f-9201-ebf58e3ca1b9") },
                    { new Guid("b3452c68-38f6-458e-8516-ca0cf7cc6bf4"), "الاختيار 1", new Guid("a8024ded-9c15-4f12-b771-8c09f1ca95e2") },
                    { new Guid("b345fc5b-73e1-4a94-a5c5-a0aba00a3215"), "الاختيار 2", new Guid("98282142-f9c6-4a4d-8ee7-acbb9c94a744") },
                    { new Guid("b4c7b6c6-9f6b-448f-bcaa-5b898dda8293"), "الاختيار 1", new Guid("1a252041-ccc4-4897-9892-9cff00ba15bb") },
                    { new Guid("b52d20fb-6f17-4135-be05-6892cd8a5995"), "الاختيار 3", new Guid("aa40ce8b-26ac-40db-8f59-c32e0a765265") },
                    { new Guid("b5648543-bde8-453e-a3f7-077b9f322972"), "الاختيار 3", new Guid("dd5da33a-017f-46f1-af86-85ff24902d70") },
                    { new Guid("b896e8bb-8594-4cae-aa61-a440f16217d3"), "الاختيار 4", new Guid("12f4c332-5e13-40be-ab80-9621443fe9d2") },
                    { new Guid("b89df517-a86e-4f5e-8427-5ecc6c99e46a"), "الاختيار 2", new Guid("bfc108f4-c6ea-401f-bdd8-9f1fc1b0eebb") },
                    { new Guid("bceec596-3ade-4f8d-89fb-367769506305"), "الاختيار 4", new Guid("fe8da9d8-0bf0-468e-8596-2e96e0dd97ce") },
                    { new Guid("c04158b3-a966-434b-b03f-398ad17ca159"), "الاختيار 1", new Guid("0b804058-92af-490c-820f-60401b6d44ff") },
                    { new Guid("c0c30c87-9e1b-4f5f-934b-bb6033fd149a"), "الاختيار 3", new Guid("844ed8cc-b48d-434c-887f-acae05dc9924") },
                    { new Guid("c11130bf-7883-4db8-96d5-c924f7b23396"), "الاختيار 1", new Guid("aa40ce8b-26ac-40db-8f59-c32e0a765265") },
                    { new Guid("c3d7b776-f257-4e67-bc15-5f561e1e4242"), "الاختيار 2", new Guid("dd5da33a-017f-46f1-af86-85ff24902d70") },
                    { new Guid("d69d75dd-e4f3-45e1-b8c4-0d76fbb9652a"), "الاختيار 3", new Guid("98282142-f9c6-4a4d-8ee7-acbb9c94a744") },
                    { new Guid("d6fc4a6e-2bd9-4bac-9eea-376a7761df84"), "الاختيار 3", new Guid("0b804058-92af-490c-820f-60401b6d44ff") },
                    { new Guid("d7f63cbb-f175-40fe-8fba-4b56651e52fa"), "الاختيار 2", new Guid("4301af88-cacf-4bf9-9e8c-0b9a5a1baef3") },
                    { new Guid("dd84f2d5-74de-4e3d-b55d-accb9b0d1412"), "الاختيار 4", new Guid("bfc108f4-c6ea-401f-bdd8-9f1fc1b0eebb") },
                    { new Guid("ddd098fe-8074-4a9b-923c-efd1731b8908"), "الاختيار 1", new Guid("12f4c332-5e13-40be-ab80-9621443fe9d2") },
                    { new Guid("de8aa496-0d9f-47d0-95c2-fd68dc3265ef"), "الاختيار 3", new Guid("2427299d-bcf5-483f-bd55-930908251b48") },
                    { new Guid("df3ece7b-8613-44f5-ac3b-2d4f0f6f6d2f"), "الاختيار 3", new Guid("4301af88-cacf-4bf9-9e8c-0b9a5a1baef3") },
                    { new Guid("dfcf0971-5833-4ed5-9a7f-210b6e8d0d6d"), "الاختيار 3", new Guid("f2eeb56d-f800-46ee-8461-b13ea5f489a5") },
                    { new Guid("dfea7e5b-777c-409a-835b-c9390d3c5d0b"), "الاختيار 1", new Guid("fe8da9d8-0bf0-468e-8596-2e96e0dd97ce") },
                    { new Guid("e1741aa0-8807-4c13-8644-4a7a80953f78"), "الاختيار 4", new Guid("2ace33bc-84ad-4eea-9743-1c35a99e6d79") },
                    { new Guid("e19f8e5e-e248-4ce9-b8cc-fb9370c18153"), "الاختيار 1", new Guid("2ace33bc-84ad-4eea-9743-1c35a99e6d79") },
                    { new Guid("eb49ef04-acb5-480b-a996-76ef31caddd0"), "الاختيار 4", new Guid("4040c0b8-1822-444e-a6e3-cefefa3df0c7") },
                    { new Guid("eb83c4c2-114a-45f2-a5d1-44fb14c810e2"), "الاختيار 3", new Guid("2ace33bc-84ad-4eea-9743-1c35a99e6d79") },
                    { new Guid("ede0800e-ecd2-4fd7-ba5f-e00f92559992"), "الاختيار 4", new Guid("844ed8cc-b48d-434c-887f-acae05dc9924") },
                    { new Guid("ef9d4666-f9c4-4096-b133-6e87c51d5172"), "الاختيار 2", new Guid("714d9e89-b3d5-419f-9201-ebf58e3ca1b9") },
                    { new Guid("f17a824f-d333-4b4b-a655-7a1e3e8363c5"), "الاختيار 1", new Guid("662d775e-c5f3-468a-a819-28e9a75a0d18") },
                    { new Guid("f2324e77-ea26-483b-ac66-abb59ff8216b"), "الاختيار 1", new Guid("65a3b0cb-6c69-4c65-b895-d0083f3fc869") },
                    { new Guid("f3fdb965-2d15-4685-9169-f58c05cbd5cf"), "الاختيار 1", new Guid("b0c48106-715f-48ba-87d0-aeb27ac5231d") },
                    { new Guid("f454400a-c60d-4a01-9444-60fe54b6bfb8"), "الاختيار 1", new Guid("20cd2b95-f246-458a-a909-6d2cceaefcb0") },
                    { new Guid("fbc68e95-de59-44fe-b94e-46f873743f5d"), "الاختيار 3", new Guid("bfc108f4-c6ea-401f-bdd8-9f1fc1b0eebb") },
                    { new Guid("fc3a4ed0-4de7-433a-8da3-b2940cbf46af"), "الاختيار 2", new Guid("662d775e-c5f3-468a-a819-28e9a75a0d18") },
                    { new Guid("fc50488a-c26b-4a89-8564-b0afe3232a82"), "الاختيار 4", new Guid("aa40ce8b-26ac-40db-8f59-c32e0a765265") },
                    { new Guid("fdff5c7b-d9cf-4817-a2d0-d742feb70168"), "الاختيار 3", new Guid("12f4c332-5e13-40be-ab80-9621443fe9d2") },
                    { new Guid("feaf6b0b-a66c-4899-987e-9a260ebcfb08"), "الاختيار 2", new Guid("2427299d-bcf5-483f-bd55-930908251b48") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("13860db6-9768-4bc2-8e6f-4e3bbc2f6fda"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("65a67234-cdab-433d-bcf1-60a0e88907cd"), new Guid("182b54eb-d431-4016-9545-04bb5ee205f9") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("fdc6ff15-70f6-4771-9ebb-67f945306de3"), new Guid("41906696-d1a6-4bf6-8f35-8fe9e3ddb7d2") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("fdc6ff15-70f6-4771-9ebb-67f945306de3"), new Guid("441baea8-ba1a-40c6-bc9b-27ddcff7dd10") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("fdc6ff15-70f6-4771-9ebb-67f945306de3"), new Guid("6c010b6a-0d42-490a-b3af-3d1b19aec676") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("fdc6ff15-70f6-4771-9ebb-67f945306de3"), new Guid("6ea2a8fa-36b1-4c34-8eaf-832a19f44e19") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("fdc6ff15-70f6-4771-9ebb-67f945306de3"), new Guid("7edbe094-17b1-4741-9082-dc0a28902272") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("fdc6ff15-70f6-4771-9ebb-67f945306de3"), new Guid("8482fac0-379d-41fb-b46c-d57b6790a31c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("fdc6ff15-70f6-4771-9ebb-67f945306de3"), new Guid("c89a74d7-ade4-4d53-9ad8-d3d7a3d778f1") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("fdc6ff15-70f6-4771-9ebb-67f945306de3"), new Guid("c8c1ae89-0be2-44df-a2b6-d5dd4807de3c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("fdc6ff15-70f6-4771-9ebb-67f945306de3"), new Guid("d43ae3f5-659a-458a-949f-f56fac95c00c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("fdc6ff15-70f6-4771-9ebb-67f945306de3"), new Guid("e1aa04ca-694f-4efc-b90c-3d9cf54fbe96") });

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: new Guid("072e6a1a-5f36-476a-9308-8e2c12ba6467"));

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: new Guid("126e9ffd-a509-4ff6-b3f5-9cbace6c0661"));

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: new Guid("5d280b0b-163a-4e44-99a8-d8583f32fd3d"));

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: new Guid("7ea3912f-90c1-4237-92af-920d4773f835"));

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: new Guid("e8c84f91-e8a0-4c18-b367-8316159d374e"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("0c12f8b6-292b-4d31-8d73-c1924cb3352f"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("0eb8132e-c1de-4413-a9c6-d86023b24b3a"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("13590ac6-c31f-4294-9e9b-f9fd5243a691"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("16b521db-2d96-4835-8ff5-a4603e8a15bd"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("28617e47-cb6c-4859-ba25-e825e8e49b3d"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("3b5a097c-7110-4401-9c79-a4d2903ba499"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("4d685898-e389-4fa8-8ffe-153d81787411"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("5b547919-e79a-41eb-8ce1-f3eb0e493bf2"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("5b8249ec-669d-4cc7-9228-6485151149ad"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("6fbca84f-edbc-4946-b34a-d6acee79f5cd"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("79fcfc34-1f40-433f-9a53-c54fbc0d35c6"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("95de1535-98a9-4d66-81d1-6a5b883e5702"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("997590f1-916f-4358-91d2-26fc7c7d5068"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("9c2abc9b-9dbf-4d1c-a4fc-0671202c28a9"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("a8c0b759-cf83-48f6-a4c2-ffcd06402451"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("b9e0938b-a352-4ca7-a167-9c94ea951c9e"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("d36c235e-89e8-40cf-aa93-541099b4ed78"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("ee253947-401a-46b4-b9ac-e1382313060b"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("f2368062-0878-4681-95c0-babf0dee955c"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("f9fbae30-03f3-4c22-9e60-a29698b2b0e9"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("116f54e0-163a-4c3d-95d2-03213ce1917f"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("26633807-5ca5-4877-8ea0-c7cd6c29da79"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("29671848-c658-4952-ab84-e74a147b67a7"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("3434d8e0-6c28-428d-a89b-c8a8e5b3d1f8"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("35cc07e5-f436-40c4-95a0-93a8e7dd53c8"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("418f3325-cbac-48c1-a8a7-66522e45bcbb"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("4c1eff16-04d8-4fec-8768-e1afdc206675"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("5266f730-d81b-4555-95de-ed99f2347e84"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("788c3d92-41dc-4439-a7e1-eaca8c9e0768"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("7c534eb3-7f8c-49a0-9e1d-b56820c47a45"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("87e5aa93-94a9-4243-aeb5-e058dbd5762e"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("89cf4400-7946-4839-a0dd-e3abc4bfe65d"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("8a447731-5fc2-417b-b1b0-abe47cdaefe9"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("8a5b5aff-2ee9-4575-92ee-73de21b9c36b"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("8b9891a5-7549-4e6e-b87a-928efd20ed57"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("93b8af27-dc1f-4aaa-9498-fd43c5646f9f"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("a19c2d08-3b21-4b25-889e-4de8ea9f2eb9"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("b96acfca-6b1c-4eeb-9e1a-d7d488abcef8"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("d6ce4396-e5c4-4df8-acd1-3eba25203f8c"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: new Guid("f1ecd094-71ae-4007-b4d6-a902c7a3880f"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("03e4454f-dc86-4442-92a7-7a219c698eea"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("0a84937c-d017-4bff-b57a-8e072576df8d"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("0d54c4ae-6a2f-4e8b-9ed6-298d2bf314f9"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("0f623d94-056e-4c0d-9186-3da46c200f16"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("10ae4e59-487d-4aec-94fd-b5659c1db7cc"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("121ce5b2-18df-4c0a-82a4-0a9709cba120"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("1552fa26-c571-4c69-b255-0685fc731218"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("15e00829-dc2d-47c7-878f-8bf099a405e9"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("164b409d-0371-4a54-9ded-848df7378d76"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("18caced7-9288-4a02-b4b9-49c72dad9ba8"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("19c00c3f-62eb-4572-8526-1ab4de48fb7b"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("1dde8a93-eaff-43e9-9ce6-a58e9ee38fd8"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("2124ca55-c60a-4940-b429-71e6183be2cb"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("268a96d2-45d8-4846-a528-76897ee78e24"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("2b0495b3-3ecf-4af2-8caf-34b7075155b5"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("2e7cbe30-69e3-443d-a744-512e44ee8da5"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("2fce610e-f9cd-4cd1-8d80-af2bffd796bb"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("31cd965b-8f4e-440c-bbed-3a124c5f6d8b"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("31d427b0-3b2d-4390-a5ef-3980d7544fc1"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("32259994-f725-48b1-9a53-0c152f0f2ad1"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("38a9aa7b-6d90-454d-a398-bbb1101b6f83"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("39657e51-ad6a-4cbd-afc6-7fff55587db8"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("3fb361c8-8872-44ea-a934-0d1195373db4"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("449cfe94-5476-4f2f-87dc-29e0b5c13122"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("45606629-82e9-4133-9646-03cafbdda061"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("4d2f55b0-2b2a-4948-a802-c6386c58c307"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("501640c9-8640-4f7d-855d-80412449775b"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("50422e86-edf4-4aa4-8875-6532e86da0e0"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("5226bfbe-d6e9-4f93-b59a-fac0348bac26"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("5267c32b-af74-4edd-9f23-a59c26a0cd29"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("548c0916-dc1f-4af0-84b2-f61527ae05ff"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("54e688c1-0ad9-464e-bd3d-d58162ba9172"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("54ee2fc4-719b-4a79-aaff-02f7e4e9c703"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("554f595c-b24c-49ff-bc87-f0b05157c3e4"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("5804bbbc-613e-49cc-a441-30666dad0c56"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("59b7eced-45b1-442b-bbdc-b403e03b9bd9"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("5a34de42-dfd1-4b7a-befb-a2035285c824"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("5be0bae5-7e11-41e1-aa4b-8c16481a60a1"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("61c4a5d8-ae6e-4e22-a0f7-3bc5ea48031c"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("69b59a43-e66e-41ad-8f84-127870f58b07"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("6aa0382a-0d53-4ace-b1e2-d4140ab863a9"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("6b17298d-3279-4262-9d8d-d5b92bb6b06e"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("73058ae7-2c5d-4954-9790-51a0e0544737"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("7693f2d4-af27-4fa3-9f38-bb282190c1aa"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("7af0ac90-5a57-4ca8-a0e9-3267fe67ef67"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("7c6a90a3-9a6a-4736-b685-6e514bc63b95"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("7fc5aad1-6dda-4f15-be10-42d711fa11d7"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("80deade1-a49b-4fde-8283-63acd6dbfee7"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("86562fb7-b4fd-4c01-bc21-b54d17fa185b"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("87222698-36f7-4577-806a-b25df457e994"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("87812dee-e2d4-4810-96c4-8cc99d3552cf"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("886b6fe2-4dc3-4ebb-8324-4db996a0fd5c"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("8e5ea502-7a95-48d2-9e3a-0f624679865a"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("8f617c39-5fbe-4d93-9932-37fb352c545a"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("953f851d-9821-463b-ac69-1d72c827e00e"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("95eff022-b4fb-4d36-9807-b266a5755092"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("9a961485-a5e6-479e-b097-588be50d7a13"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("9bc8c293-b96e-4344-810e-b6d61ae4935d"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("9e974197-d840-43b0-b207-6121bf5e057a"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("a36818c4-6845-44a7-b07b-77a3c29ca9cd"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("a8f8bfed-aa33-478c-8971-808c5937f48c"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("aac9fdb3-6b27-4f22-ae38-cedd7af9868c"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("ade48901-a56e-4b5f-8efd-91dcd9adfe5c"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("b1f56e5f-5cea-4b55-8904-b64a8e548fec"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("b3452c68-38f6-458e-8516-ca0cf7cc6bf4"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("b345fc5b-73e1-4a94-a5c5-a0aba00a3215"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("b4c7b6c6-9f6b-448f-bcaa-5b898dda8293"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("b52d20fb-6f17-4135-be05-6892cd8a5995"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("b5648543-bde8-453e-a3f7-077b9f322972"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("b896e8bb-8594-4cae-aa61-a440f16217d3"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("b89df517-a86e-4f5e-8427-5ecc6c99e46a"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("bceec596-3ade-4f8d-89fb-367769506305"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("c04158b3-a966-434b-b03f-398ad17ca159"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("c0c30c87-9e1b-4f5f-934b-bb6033fd149a"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("c11130bf-7883-4db8-96d5-c924f7b23396"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("c3d7b776-f257-4e67-bc15-5f561e1e4242"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("d69d75dd-e4f3-45e1-b8c4-0d76fbb9652a"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("d6fc4a6e-2bd9-4bac-9eea-376a7761df84"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("d7f63cbb-f175-40fe-8fba-4b56651e52fa"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("dd84f2d5-74de-4e3d-b55d-accb9b0d1412"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("ddd098fe-8074-4a9b-923c-efd1731b8908"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("de8aa496-0d9f-47d0-95c2-fd68dc3265ef"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("df3ece7b-8613-44f5-ac3b-2d4f0f6f6d2f"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("dfcf0971-5833-4ed5-9a7f-210b6e8d0d6d"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("dfea7e5b-777c-409a-835b-c9390d3c5d0b"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("e1741aa0-8807-4c13-8644-4a7a80953f78"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("e19f8e5e-e248-4ce9-b8cc-fb9370c18153"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("eb49ef04-acb5-480b-a996-76ef31caddd0"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("eb83c4c2-114a-45f2-a5d1-44fb14c810e2"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("ede0800e-ecd2-4fd7-ba5f-e00f92559992"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("ef9d4666-f9c4-4096-b133-6e87c51d5172"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("f17a824f-d333-4b4b-a655-7a1e3e8363c5"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("f2324e77-ea26-483b-ac66-abb59ff8216b"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("f3fdb965-2d15-4685-9169-f58c05cbd5cf"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("f454400a-c60d-4a01-9444-60fe54b6bfb8"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("fbc68e95-de59-44fe-b94e-46f873743f5d"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("fc3a4ed0-4de7-433a-8da3-b2940cbf46af"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("fc50488a-c26b-4a89-8564-b0afe3232a82"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("fdff5c7b-d9cf-4817-a2d0-d742feb70168"));

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumn: "Id",
                keyValue: new Guid("feaf6b0b-a66c-4899-987e-9a260ebcfb08"));

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new Guid("41906696-d1a6-4bf6-8f35-8fe9e3ddb7d2") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new Guid("41906696-d1a6-4bf6-8f35-8fe9e3ddb7d2") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new Guid("441baea8-ba1a-40c6-bc9b-27ddcff7dd10") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new Guid("441baea8-ba1a-40c6-bc9b-27ddcff7dd10") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new Guid("6c010b6a-0d42-490a-b3af-3d1b19aec676") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new Guid("6c010b6a-0d42-490a-b3af-3d1b19aec676") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new Guid("6ea2a8fa-36b1-4c34-8eaf-832a19f44e19") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new Guid("6ea2a8fa-36b1-4c34-8eaf-832a19f44e19") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new Guid("7edbe094-17b1-4741-9082-dc0a28902272") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new Guid("7edbe094-17b1-4741-9082-dc0a28902272") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new Guid("8482fac0-379d-41fb-b46c-d57b6790a31c") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new Guid("8482fac0-379d-41fb-b46c-d57b6790a31c") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new Guid("c89a74d7-ade4-4d53-9ad8-d3d7a3d778f1") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new Guid("c89a74d7-ade4-4d53-9ad8-d3d7a3d778f1") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new Guid("c8c1ae89-0be2-44df-a2b6-d5dd4807de3c") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new Guid("c8c1ae89-0be2-44df-a2b6-d5dd4807de3c") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new Guid("d43ae3f5-659a-458a-949f-f56fac95c00c") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new Guid("d43ae3f5-659a-458a-949f-f56fac95c00c") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"), new Guid("e1aa04ca-694f-4efc-b90c-3d9cf54fbe96") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"), new Guid("e1aa04ca-694f-4efc-b90c-3d9cf54fbe96") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("65a67234-cdab-433d-bcf1-60a0e88907cd"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fdc6ff15-70f6-4771-9ebb-67f945306de3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("182b54eb-d431-4016-9545-04bb5ee205f9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("41906696-d1a6-4bf6-8f35-8fe9e3ddb7d2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("441baea8-ba1a-40c6-bc9b-27ddcff7dd10"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6c010b6a-0d42-490a-b3af-3d1b19aec676"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6ea2a8fa-36b1-4c34-8eaf-832a19f44e19"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7edbe094-17b1-4741-9082-dc0a28902272"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8482fac0-379d-41fb-b46c-d57b6790a31c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c89a74d7-ade4-4d53-9ad8-d3d7a3d778f1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8c1ae89-0be2-44df-a2b6-d5dd4807de3c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d43ae3f5-659a-458a-949f-f56fac95c00c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e1aa04ca-694f-4efc-b90c-3d9cf54fbe96"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0b804058-92af-490c-820f-60401b6d44ff"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("12f4c332-5e13-40be-ab80-9621443fe9d2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("136d2ee5-cc72-4814-9e12-3e7c32617fff"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1a252041-ccc4-4897-9892-9cff00ba15bb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("20cd2b95-f246-458a-a909-6d2cceaefcb0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2427299d-bcf5-483f-bd55-930908251b48"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2ace33bc-84ad-4eea-9743-1c35a99e6d79"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("40330b62-3d6a-427e-b87f-06cd8e2cdddd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4040c0b8-1822-444e-a6e3-cefefa3df0c7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4301af88-cacf-4bf9-9e8c-0b9a5a1baef3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("65a3b0cb-6c69-4c65-b895-d0083f3fc869"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("662d775e-c5f3-468a-a819-28e9a75a0d18"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("714d9e89-b3d5-419f-9201-ebf58e3ca1b9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("844ed8cc-b48d-434c-887f-acae05dc9924"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("98282142-f9c6-4a4d-8ee7-acbb9c94a744"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a8024ded-9c15-4f12-b771-8c09f1ca95e2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("aa40ce8b-26ac-40db-8f59-c32e0a765265"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b0c48106-715f-48ba-87d0-aeb27ac5231d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b38edf74-351d-4e28-a2a0-9f5d85fd0301"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("be03d07d-4582-4bbc-9ab2-35ba6d5b3f79"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bfc108f4-c6ea-401f-bdd8-9f1fc1b0eebb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d6ce13b8-251f-422e-b153-82accea0d750"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dd5da33a-017f-46f1-af86-85ff24902d70"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f2eeb56d-f800-46ee-8461-b13ea5f489a5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fe8da9d8-0bf0-468e-8596-2e96e0dd97ce"));

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: new Guid("040f9cf1-08ee-42e1-8dd4-9ed60a5c6f54"));

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: new Guid("07911df9-c351-4daf-8896-f5cda5f1d1b8"));

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: new Guid("09038571-6a06-40c5-a8f8-0eda1a1a0888"));

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: new Guid("2a1d020b-f452-49ae-a7db-8f513e7de73d"));

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: new Guid("c939d2f1-3cf1-4fd2-836a-49a636dee20d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3353a971-11b2-4f78-a997-51afe0829cc4"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("423fa4ed-cf9f-4ea9-92bd-b023475247c7"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b8a0f844-c625-4e57-9a36-94979e8e12cb"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e6522e87-dddf-45aa-a8bb-d2e53c5714c3"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f8572fca-5dd5-4995-bf08-a76eb7c0d040"));

            migrationBuilder.DropColumn(
                name: "EnrollmentDate",
                table: "StudentCourses");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "StudentCourses");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Lessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 16, 23, 11, 36, 914, DateTimeKind.Local).AddTicks(4599),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 4, 10, 11, 52, 27, 731, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Exams",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("140bcb5c-f798-4742-bea8-baf339efed54"), null, "Assistant", "ASSISTANT" },
                    { new Guid("2751d8aa-1766-4e26-9215-eea8822cea54"), null, "Teacher", "TEACHER" },
                    { new Guid("de010548-23e7-4a65-ad58-e6d5a9fd41a3"), null, "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("78ab8f66-e864-4e65-bacb-8263595dff66"), 0, "bd1ac2b3-ecef-4fed-89cd-4891ab23ef09", "AppUser", "Admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAEH6j95fBX5W3/3a+gHXrmNNNzTYJMdwkANKlNixSc9IUYTovZ274QCGUJqsWmatReQ==", null, false, null, null, "", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("2751d8aa-1766-4e26-9215-eea8822cea54"), new Guid("78ab8f66-e864-4e65-bacb-8263595dff66") });
        }
    }
}
