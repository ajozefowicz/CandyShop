using Microsoft.EntityFrameworkCore.Migrations;

namespace CandyShop.Migrations
{
    public partial class SeedingDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CateogryId", "CategoryDescription", "CategoryName" },
                values: new object[] { 1, "Super hard candy", "Hard Candy" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CateogryId", "CategoryDescription", "CategoryName" },
                values: new object[] { 2, "very chocolate candy", "Chocolate Candy" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CateogryId", "CategoryDescription", "CategoryName" },
                values: new object[] { 3, "Sour fruit candy", "Fruit Candy" });

            migrationBuilder.InsertData(
                table: "Candies",
                columns: new[] { "CandyId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Lorem ipsum dolor sit amet enim. Etiam ullamcorper. Suspendisse a pellentesque dui, non felis", "https://cdn.pixabay.com/photo/2012/12/11/21/28/variation-69470__340.jpg", "https://cdn.pixabay.com/photo/2012/12/11/21/28/variation-69470__340.jpg", true, false, "Asorted Hard Candy", 2.22m },
                    { 2, 1, "Lorem ipsum dolor sit amet enim. Etiam ullamcorper. Suspendisse a pellentesque dui, non felis", "https://cdn.pixabay.com/photo/2016/10/09/18/06/candy-corn-1726481_960_720.jpg", "https://cdn.pixabay.com/photo/2016/10/09/18/06/candy-corn-1726481_960_720.jpg", true, true, "Super Hard Candy", 4.22m },
                    { 3, 2, "Lorem ipsum dolor sit amet enim. Etiam ullamcorper. Suspendisse a pellentesque dui, non felis", "https://cdn.pixabay.com/photo/2014/11/30/10/48/chocolate-551424__340.jpg", "https://cdn.pixabay.com/photo/2014/11/30/10/48/chocolate-551424__340.jpg", true, true, "Super Chocolate Candy", 3.33m },
                    { 4, 2, "Lorem ipsum dolor sit amet enim. Etiam ullamcorper. Suspendisse a pellentesque dui, non felis", "https://cdn.pixabay.com/photo/2017/04/12/16/56/chocolates-2224998__340.jpg", "https://cdn.pixabay.com/photo/2017/04/12/16/56/chocolates-2224998__340.jpg", true, true, "Dark Chocolate Candy", 5.55m },
                    { 5, 3, "Lorem ipsum dolor sit amet enim. Etiam ullamcorper. Suspendisse a pellentesque dui, non felis", "https://cdn.pixabay.com/photo/2018/06/19/23/30/sugar-3485447__340.jpg", "https://cdn.pixabay.com/photo/2018/06/19/23/30/sugar-3485447__340.jpg", true, true, "Mango Candy", 5.55m }
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
                table: "Categories",
                keyColumn: "CateogryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CateogryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CateogryId",
                keyValue: 3);
        }
    }
}
