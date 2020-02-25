using Microsoft.EntityFrameworkCore.Migrations;

namespace CandyShop.Persistence.Migrations
{
    public partial class SeededDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, null, "Chocolate Candy" },
                    { 2, null, "Fruit Candy" },
                    { 3, null, "Gummy Candy" },
                    { 4, null, "Halloween Candy" },
                    { 5, null, "Hard Candy" }
                });

            migrationBuilder.InsertData(
                table: "Candies",
                columns: new[] { "CandyId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla sit amet nibh eget erat scelerisque rhoncus sed quis nisi.", "\\images\\thumbnails\\chocolateCandy-small.jpg", "\\images\\chocolateCandy.jpg", true, false, "Assorted Chocolate Candy", 4.95m },
                    { 2, 1, "Sed rutrum libero velit, a imperdiet purus posuere ultricies. Quisque ultrices nulla nec tortor luctus blandit.", "\\images\\thumbnails\\chocolateCandy2-small.jpg", "\\images\\chocolateCandy2.jpg", true, true, "Another Assorted Chocolate Candy", 3.95m },
                    { 3, 1, "Phasellus dolor augue, blandit a tincidunt eget, egestas sed lacus. Etiam varius leo nec tortor faucibus luctus.", "\\images\\thumbnails\\chocolateCandy3-small.jpg", "\\images\\chocolateCandy3.jpg", true, false, "Assorted Chocolate Candy", 5.75m },
                    { 4, 2, "Donec tempus, diam quis dictum tincidunt, ex neque rutrum ligula, eget congue nunc lorem eu magna.", "\\images\\thumbnails\\fruitCandy-small.jpg", "\\images\\fruitCandy.jpg", true, false, "Assorted Fruit Candy", 3.95m },
                    { 5, 2, "Sed at ex placerat, ultrices urna elementum, laoreet ligula. Nullam vitae odio sit amet magna faucibus euismod varius vel tortor.", "\\images\\thumbnails\\fruitCandy2-small.jpg", "\\images\\fruiteCandy2.jpg", true, true, "Fruit Candy", 7.00m },
                    { 6, 2, "Nulla placerat ante ut eros eleifend sagittis. Nulla facilisi. Praesent maximus libero nec justo lobortis tempus.", "\\images\\thumbnails\\fruitCandy3-small.jpg", "\\images\\fruitCandy3.jpg", true, true, "Assorted Assorted Fruit Candy", 11.25m },
                    { 7, 3, "Cras in magna eget velit mollis fringilla sed sed est. In felis massa, volutpat sed iaculis sit amet, eleifend aliquam nisi.", "\\images\\thumbnails\\gummyCandy-small.jpg", "\\images\\gummyCandy.jpg", true, true, "Assorted Gummy Candy", 3.95m },
                    { 8, 3, "In fermentum ex vitae semper facilisis. Aenean fringilla sagittis arcu, vel posuere justo bibendum eu.", "\\images\\thumbnails\\gummyCandy2-small.jpg", "\\images\\gummyCandy2.jpg", true, false, "Assorted Assorted Gummy Candy", 1.95m },
                    { 9, 3, "Vestibulum venenatis porttitor ipsum. Vestibulum ac tincidunt ex. Sed convallis turpis quis enim varius, id dignissim dui eleifend.", "\\images\\thumbnails\\gummyCandy3-small.jpg", "\\images\\gummyCandy3.jpg", true, false, "Gummy Candy", 13.95m },
                    { 10, 4, "Morbi eu justo sed nulla suscipit consectetur ut a ligula. Fusce eu lorem quis lorem vulputate porta.", "\\images\\thumbnails\\halloweenCandy-small.jpg", "\\images\\halloweenCandy.jpg", true, true, "Halloween Candy", 1.95m },
                    { 11, 4, "Aenean eu enim tincidunt, porttitor magna quis, lacinia neque. Vestibulum erat enim, porttitor eget arcu et, fringilla lacinia lectus.", "\\images\\thumbnails\\halloweenCandy2-small.jpg", "\\images\\halloweenCandy2.jpg", true, true, "Assorted Halloween Candy", 12.95m },
                    { 12, 4, "Phasellus quis quam lorem. Nulla et eros malesuada, blandit lorem ac, pellentesque magna.", "\\images\\thumbnails\\halloweenCandy3-small.jpg", "\\images\\halloweenCandy3.jpg", true, true, "Another Halloween Candy", 21.95m },
                    { 13, 5, "Sed metus libero, maximus placerat maximus in, elementum non velit. In vel nibh massa. Ut ultricies ut mauris eget venenatis.", "\\images\\thumbnails\\hardCandy-small.jpg", "\\images\\hardCandy.jpg", true, false, "Hard Candy", 6.95m },
                    { 14, 5, "Proin consequat dapibus nunc non tempus. Cras maximus, mauris ac ullamcorper dignissim, est tellus accumsan mauris, id semper augue erat eu ex.", "\\images\\thumbnails\\hardCandy2-small.jpg", "\\images\\hardCandy2.jpg", true, true, "Another Hard Candy", 2.95m },
                    { 15, 5, "Nulla luctus euismod nunc eget pretium. Suspendisse mollis ultrices erat, imperdiet accumsan mi blandit et. Integer laoreet eget sem a suscipit.", "\\images\\thumbnails\\hardCandy3-small.jpg", "\\images\\hardeCandy3.jpg", true, false, "Best Hard Candy", 16.95m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);
        }
    }
}
