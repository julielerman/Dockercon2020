using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Agilistas.Migrations
{
    public partial class newpropsandseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SecondaryFocusId",
                table: "Agilistas",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Agilistas",
                keyColumn: "Id",
                keyValue: new Guid("554be900-d1a4-4908-9d6a-5ef3ea05650e"),
                column: "SecondaryFocusId",
                value: new Guid("5f6d6f80-9f9a-469e-9036-07ecbb3971ea"));

            migrationBuilder.UpdateData(
                table: "Agilistas",
                keyColumn: "Id",
                keyValue: new Guid("5efdb55d-1205-419f-8a0b-9cc7a15f8565"),
                column: "SecondaryFocusId",
                value: new Guid("5f6d6f80-9f9a-469e-9036-07ecbb3971ea"));

            migrationBuilder.UpdateData(
                table: "Agilistas",
                keyColumn: "Id",
                keyValue: new Guid("83eda86f-c652-4666-ba17-db90b218a54b"),
                column: "SecondaryFocusId",
                value: new Guid("5f6d6f80-9f9a-469e-9036-07ecbb3971ea"));

            migrationBuilder.UpdateData(
                table: "Agilistas",
                keyColumn: "Id",
                keyValue: new Guid("f2e5fdba-daf9-43f0-8bde-9ed2562bd12a"),
                column: "SecondaryFocusId",
                value: new Guid("c5b6a0e8-e43f-4765-906f-e15e019a19d8"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("a372269c-0e3d-45f6-bda1-6631667e8e37"), "Agile Data" });

            migrationBuilder.InsertData(
                table: "Agilistas",
                columns: new[] { "Id", "Name", "PrimaryFocusId", "SecondaryFocusId", "TwitterHandle" },
                values: new object[] { new Guid("cb2a97da-1700-4f2b-a419-c539279e0d1f"), "Julie Lerman", new Guid("a372269c-0e3d-45f6-bda1-6631667e8e37"), new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.CreateIndex(
                name: "IX_Agilistas_SecondaryFocusId",
                table: "Agilistas",
                column: "SecondaryFocusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agilistas_Categories_SecondaryFocusId",
                table: "Agilistas",
                column: "SecondaryFocusId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agilistas_Categories_SecondaryFocusId",
                table: "Agilistas");

            migrationBuilder.DropIndex(
                name: "IX_Agilistas_SecondaryFocusId",
                table: "Agilistas");

            migrationBuilder.DeleteData(
                table: "Agilistas",
                keyColumn: "Id",
                keyValue: new Guid("cb2a97da-1700-4f2b-a419-c539279e0d1f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a372269c-0e3d-45f6-bda1-6631667e8e37"));

            migrationBuilder.DropColumn(
                name: "SecondaryFocusId",
                table: "Agilistas");
        }
    }
}
