using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedFaq : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "No, GymPro is designed for all fitness levels. Our trainers guide beginners with proper techniques and structured workout plans to help them start safely and confidently.", "Q1. Do I need prior gym experience to join CoreFitness?" },
                    { 2, "Our membership gives you full access to state-of-the-art gym equipment, free weights, cardio machines, and functional training areas. You can also enjoy group fitness classes, locker rooms, and relaxation areas designed to support your overall fitness experience.", "Q2. What facilities are included with the membership?" },
                    { 3, "Yes, we offer trial sessions so you can explore our facilities and experience our training environment before committing. This allows you to meet our trainers, test the equipment, and see if CoreFitness is the right fit for you.", "Q3. Can I try the gym before taking a membership?" },
                    { 4, "Absolutely! We offer a variety of group workout programs, including strength training, cardio sessions, yoga, and high-intensity interval training. These classes are led by experienced instructors and are suitable for all fitness levels.", "Q4. Are there group workout programs available?" },
                    { 5, "Yes, many of our programs include basic nutrition guidance to help you reach your fitness goals. Our trainers can provide recommendations and tips to support a balanced diet alongside your workout routine.", "Q5. Is nutrition guidance included in the plans?" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
