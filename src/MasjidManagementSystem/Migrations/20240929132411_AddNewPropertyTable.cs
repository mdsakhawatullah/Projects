using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MasjidManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddNewPropertyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Volunteers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Volunteers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Volunteers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsSubscribed",
                table: "Volunteers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "Volunteers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "PreferTime",
                table: "Volunteers",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<string>(
                name: "SelectedCountry",
                table: "Volunteers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Prayers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Prayers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Prayers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsSubscribed",
                table: "Prayers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "Prayers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "PreferTime",
                table: "Prayers",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<string>(
                name: "SelectedCountry",
                table: "Prayers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Imams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Imams",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Imams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsSubscribed",
                table: "Imams",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "Imams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "PreferTime",
                table: "Imams",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<string>(
                name: "SelectedCountry",
                table: "Imams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsSubscribed",
                table: "Events",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "PreferTime",
                table: "Events",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<string>(
                name: "SelectedCountry",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Donations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Donations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Donations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsSubscribed",
                table: "Donations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "Donations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "PreferTime",
                table: "Donations",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<string>(
                name: "SelectedCountry",
                table: "Donations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Volunteers");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Volunteers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Volunteers");

            migrationBuilder.DropColumn(
                name: "IsSubscribed",
                table: "Volunteers");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Volunteers");

            migrationBuilder.DropColumn(
                name: "PreferTime",
                table: "Volunteers");

            migrationBuilder.DropColumn(
                name: "SelectedCountry",
                table: "Volunteers");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Prayers");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Prayers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Prayers");

            migrationBuilder.DropColumn(
                name: "IsSubscribed",
                table: "Prayers");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Prayers");

            migrationBuilder.DropColumn(
                name: "PreferTime",
                table: "Prayers");

            migrationBuilder.DropColumn(
                name: "SelectedCountry",
                table: "Prayers");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Imams");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Imams");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Imams");

            migrationBuilder.DropColumn(
                name: "IsSubscribed",
                table: "Imams");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Imams");

            migrationBuilder.DropColumn(
                name: "PreferTime",
                table: "Imams");

            migrationBuilder.DropColumn(
                name: "SelectedCountry",
                table: "Imams");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "IsSubscribed",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "PreferTime",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "SelectedCountry",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "IsSubscribed",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "PreferTime",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "SelectedCountry",
                table: "Donations");
        }
    }
}
