using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.infrastricture.Migrations
{
    public partial class fluentApi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Passengers_Flights_FK",
                table: "FlightPassenger");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Passengers");

            migrationBuilder.RenameTable(
                name: "Passengers",
                newName: "My_Passenger");

            migrationBuilder.AlterColumn<string>(
                name: "Departure",
                table: "Flights",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "rayen",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_My_Passenger",
                table: "My_Passenger",
                column: "PassportNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_My_Passenger_Flights_FK",
                table: "FlightPassenger",
                column: "Flights_FK",
                principalTable: "My_Passenger",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_My_Passenger_Flights_FK",
                table: "FlightPassenger");

            migrationBuilder.DropPrimaryKey(
                name: "PK_My_Passenger",
                table: "My_Passenger");

            migrationBuilder.RenameTable(
                name: "My_Passenger",
                newName: "Passengers");

            migrationBuilder.AlterColumn<string>(
                name: "Departure",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldDefaultValue: "rayen");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers",
                column: "PassportNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Passengers_Flights_FK",
                table: "FlightPassenger",
                column: "Flights_FK",
                principalTable: "Passengers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
