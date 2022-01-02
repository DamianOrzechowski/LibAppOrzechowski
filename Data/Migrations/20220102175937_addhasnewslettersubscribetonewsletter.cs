using Microsoft.EntityFrameworkCore.Migrations;

namespace LibAppOrzechowski.Data.Migrations
{
    public partial class addhasnewslettersubscribetonewsletter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasNewsletterSubscribed",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasNewsletterSubscribed",
                table: "Customers");
        }
    }
}
