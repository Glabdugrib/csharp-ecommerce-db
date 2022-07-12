using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharp_ecommerce_db.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "product",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "product",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "product",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "product",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "orders_products",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "orders_products",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "order",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "order",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "order",
                newName: "amount");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "order",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "customer",
                newName: "surname");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "customer",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "customer",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "customer",
                newName: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "price",
                table: "product",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "product",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "product",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "product",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "orders_products",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "orders_products",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "order",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "order",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "amount",
                table: "order",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "order",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "surname",
                table: "customer",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "customer",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "customer",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "customer",
                newName: "Id");
        }
    }
}
