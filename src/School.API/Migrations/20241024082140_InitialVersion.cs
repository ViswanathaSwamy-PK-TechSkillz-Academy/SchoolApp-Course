using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace School.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialVersion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseId", "CreatedBy", "CreatedDate", "Description", "Duration", "ModifiedBy", "ModifiedDate", "Name", "PictureUrl" },
                values: new object[,]
                {
                    { new Guid("014765b7-503c-4aae-96e4-495f752d2930"), new Guid("5b675f12-3e38-4ec7-b230-d791109cf4b5"), "Admin", new DateTimeOffset(new DateTime(2024, 10, 24, 8, 21, 38, 932, DateTimeKind.Unspecified).AddTicks(7240), new TimeSpan(0, 0, 0, 0, 0)), "Minimal API in .NET 7 for Beginners", 3, "Admin", new DateTimeOffset(new DateTime(2024, 10, 24, 8, 21, 38, 932, DateTimeKind.Unspecified).AddTicks(7241), new TimeSpan(0, 0, 0, 0, 0)), "Minimal API in .NET 7", "https://stforeshop.blob.core.windows.net/coursesimages/MinimalAPIin_NET7.PNG" },
                    { new Guid("17704f58-1c49-403e-8d1f-59cb6721d991"), new Guid("39763c01-3295-445d-bd89-7f26306416d2"), "Admin", new DateTimeOffset(new DateTime(2024, 10, 24, 8, 21, 38, 932, DateTimeKind.Unspecified).AddTicks(7262), new TimeSpan(0, 0, 0, 0, 0)), "Blazor WASM in .NET 7 for Beginners", 5, "Admin", new DateTimeOffset(new DateTime(2024, 10, 24, 8, 21, 38, 932, DateTimeKind.Unspecified).AddTicks(7262), new TimeSpan(0, 0, 0, 0, 0)), "Blazor WASM in .NET 7", "https://stforeshop.blob.core.windows.net/coursesimages/BlazorWASMin_NET7.PNG" },
                    { new Guid("1f6ff906-602c-43f1-8785-f13bf104c562"), new Guid("4ac8f6a2-306e-4493-90e5-17c75ac8aa71"), "Admin", new DateTimeOffset(new DateTime(2024, 10, 24, 8, 21, 38, 932, DateTimeKind.Unspecified).AddTicks(7266), new TimeSpan(0, 0, 0, 0, 0)), "App Services in Azure for Beginners", 9, "Admin", new DateTimeOffset(new DateTime(2024, 10, 24, 8, 21, 38, 932, DateTimeKind.Unspecified).AddTicks(7267), new TimeSpan(0, 0, 0, 0, 0)), "App Services in Azure", "https://stforeshop.blob.core.windows.net/coursesimages/AppServicesinAzure.PNG" },
                    { new Guid("264c8389-29ba-4193-b0e5-eb8ffb39c074"), new Guid("395c8760-c586-469e-b4fa-09a791b9aa34"), "Admin", new DateTimeOffset(new DateTime(2024, 10, 24, 8, 21, 38, 932, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Web API in .NET 7 for Beginners", 3, "Admin", new DateTimeOffset(new DateTime(2024, 10, 24, 8, 21, 38, 932, DateTimeKind.Unspecified).AddTicks(7235), new TimeSpan(0, 0, 0, 0, 0)), "Web API in .NET 7", "https://stforeshop.blob.core.windows.net/coursesimages/WebAPIin_NET7.PNG" },
                    { new Guid("ac865643-51a7-4943-ba69-84fb1eb6cacf"), new Guid("d5ed2000-5937-4717-a32f-6d755ddfb61b"), "Admin", new DateTimeOffset(new DateTime(2024, 10, 24, 8, 21, 38, 932, DateTimeKind.Unspecified).AddTicks(7264), new TimeSpan(0, 0, 0, 0, 0)), "gRPC in .NET 7 for Beginners", 5, "Admin", new DateTimeOffset(new DateTime(2024, 10, 24, 8, 21, 38, 932, DateTimeKind.Unspecified).AddTicks(7265), new TimeSpan(0, 0, 0, 0, 0)), "gRPC in .NET 7", "https://stforeshop.blob.core.windows.net/coursesimages/gRPCin_NET7.PNG" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
