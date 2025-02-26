using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DealAPI.Migrations
{
    /// <inheritdoc />
    public partial class ChangesMade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deals_Hotels_HotelId",
                table: "Deals");

            migrationBuilder.DropIndex(
                name: "IX_Deals_HotelId",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "HotelId",
                table: "Deals");

            migrationBuilder.AddColumn<Guid>(
                name: "DealId",
                table: "Hotels",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_DealId",
                table: "Hotels",
                column: "DealId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Deals_DealId",
                table: "Hotels",
                column: "DealId",
                principalTable: "Deals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Deals_DealId",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_DealId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "DealId",
                table: "Hotels");

            migrationBuilder.AddColumn<Guid>(
                name: "HotelId",
                table: "Deals",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Deals_HotelId",
                table: "Deals",
                column: "HotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deals_Hotels_HotelId",
                table: "Deals",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "HotelId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
