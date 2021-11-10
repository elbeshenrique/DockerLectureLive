using Microsoft.EntityFrameworkCore.Migrations;

namespace Docker.Lecture.Live.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Name", "Year" },
                values: new object[,]
                {
                    { 1, "Small Concrete Pants", 2004 },
                    { 73, "Fantastic Steel Shoes", 1732 },
                    { 72, "Rustic Frozen Shirt", 1847 },
                    { 71, "Refined Rubber Mouse", 1974 },
                    { 70, "Rustic Steel Ball", 1678 },
                    { 69, "Tasty Steel Cheese", 1515 },
                    { 68, "Intelligent Concrete Fish", 1924 },
                    { 67, "Handcrafted Soft Soap", 1895 },
                    { 66, "Tasty Concrete Bacon", 1520 },
                    { 65, "Practical Metal Pizza", 1671 },
                    { 64, "Ergonomic Granite Tuna", 1752 },
                    { 63, "Incredible Plastic Table", 1603 },
                    { 62, "Generic Wooden Salad", 1966 },
                    { 61, "Ergonomic Granite Chair", 1578 },
                    { 60, "Ergonomic Soft Chips", 1704 },
                    { 59, "Rustic Steel Shoes", 1981 },
                    { 58, "Gorgeous Rubber Mouse", 1729 },
                    { 57, "Practical Metal Hat", 1765 },
                    { 56, "Awesome Concrete Mouse", 1974 },
                    { 55, "Awesome Frozen Table", 1956 },
                    { 54, "Licensed Metal Mouse", 1935 },
                    { 53, "Generic Fresh Bike", 1897 },
                    { 74, "Unbranded Metal Table", 1968 },
                    { 52, "Small Granite Fish", 1523 },
                    { 75, "Handmade Frozen Shoes", 1943 },
                    { 77, "Generic Rubber Ball", 1500 },
                    { 98, "Tasty Plastic Chips", 1697 },
                    { 97, "Tasty Cotton Computer", 1866 },
                    { 96, "Intelligent Granite Computer", 1743 },
                    { 95, "Tasty Metal Shoes", 1903 },
                    { 94, "Awesome Cotton Sausages", 1510 },
                    { 93, "Handcrafted Soft Shirt", 1950 },
                    { 92, "Incredible Wooden Salad", 1987 },
                    { 91, "Handcrafted Frozen Shirt", 1941 },
                    { 90, "Handmade Granite Ball", 1656 },
                    { 89, "Ergonomic Fresh Table", 1781 },
                    { 88, "Rustic Wooden Salad", 1943 },
                    { 87, "Handcrafted Steel Car", 1702 },
                    { 86, "Handmade Cotton Sausages", 1881 },
                    { 85, "Unbranded Wooden Gloves", 1769 },
                    { 84, "Awesome Cotton Pizza", 1871 },
                    { 83, "Generic Fresh Ball", 1590 }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Name", "Year" },
                values: new object[,]
                {
                    { 82, "Licensed Plastic Salad", 1646 },
                    { 81, "Fantastic Frozen Shirt", 1590 },
                    { 80, "Small Fresh Salad", 1847 },
                    { 79, "Fantastic Granite Shoes", 1660 },
                    { 78, "Handmade Rubber Gloves", 1727 },
                    { 76, "Sleek Wooden Fish", 1526 },
                    { 51, "Handcrafted Metal Towels", 1658 },
                    { 50, "Rustic Granite Pants", 1623 },
                    { 49, "Awesome Granite Mouse", 2018 },
                    { 22, "Ergonomic Frozen Towels", 1789 },
                    { 21, "Tasty Granite Bacon", 1671 },
                    { 20, "Awesome Wooden Fish", 2001 },
                    { 19, "Handmade Wooden Table", 1749 },
                    { 18, "Gorgeous Metal Shoes", 1522 },
                    { 17, "Ergonomic Frozen Gloves", 1953 },
                    { 16, "Generic Plastic Towels", 1587 },
                    { 15, "Handcrafted Steel Fish", 1705 },
                    { 14, "Awesome Wooden Fish", 1906 },
                    { 13, "Rustic Rubber Shoes", 1524 },
                    { 12, "Awesome Plastic Chicken", 2016 },
                    { 11, "Incredible Granite Chicken", 1710 },
                    { 10, "Rustic Soft Shoes", 1598 },
                    { 9, "Handmade Steel Shirt", 1886 },
                    { 8, "Unbranded Rubber Chips", 1575 },
                    { 7, "Gorgeous Rubber Table", 1999 },
                    { 6, "Tasty Concrete Hat", 1661 },
                    { 5, "Refined Concrete Ball", 1888 },
                    { 4, "Unbranded Metal Table", 1846 },
                    { 3, "Handmade Steel Keyboard", 1527 },
                    { 2, "Small Steel Bike", 1745 },
                    { 23, "Incredible Rubber Car", 1564 },
                    { 24, "Ergonomic Steel Soap", 1510 },
                    { 25, "Unbranded Granite Gloves", 1802 },
                    { 26, "Tasty Soft Fish", 1733 },
                    { 48, "Tasty Fresh Pizza", 1852 },
                    { 47, "Refined Fresh Soap", 1825 },
                    { 46, "Awesome Metal Car", 1522 },
                    { 45, "Tasty Granite Ball", 1580 },
                    { 44, "Tasty Cotton Towels", 1665 },
                    { 43, "Handmade Plastic Shirt", 1545 },
                    { 42, "Handcrafted Wooden Bacon", 1587 },
                    { 41, "Sleek Rubber Chips", 1663 }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Name", "Year" },
                values: new object[,]
                {
                    { 40, "Gorgeous Steel Bacon", 1885 },
                    { 39, "Practical Wooden Keyboard", 1588 },
                    { 99, "Unbranded Steel Bacon", 1894 },
                    { 38, "Generic Granite Towels", 1873 },
                    { 36, "Generic Wooden Bacon", 1530 },
                    { 35, "Handmade Cotton Bike", 1841 },
                    { 34, "Licensed Wooden Chair", 1567 },
                    { 33, "Sleek Cotton Towels", 1524 },
                    { 32, "Generic Cotton Chips", 1853 },
                    { 31, "Practical Soft Towels", 1846 },
                    { 30, "Practical Concrete Car", 1588 },
                    { 29, "Incredible Soft Table", 1571 },
                    { 28, "Handmade Concrete Mouse", 1804 },
                    { 27, "Ergonomic Cotton Gloves", 1747 },
                    { 37, "Fantastic Granite Bacon", 1662 },
                    { 100, "Tasty Wooden Shirt", 1777 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
