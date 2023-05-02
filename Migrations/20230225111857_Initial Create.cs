using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RodeSafetyTool.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RoadAccidents",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Severity = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Start_Time = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    End_Time = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Start_Lat = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Start_Lng = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    End_Lat = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    End_Lng = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Distance = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Side = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    County = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Zipcode = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Timezone = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Airport_Code = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Weather_Timestamp = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Temperature = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Wind_Chill = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Humidity = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Pressure = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Visibility = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Wind_Direction = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Wind_Speed = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Precipitation = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Weather_Condition = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Amenity = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Bump = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Crossing = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Give_Way = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Junction = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    No_Exit = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Railway = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Roundabout = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Station = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Stop = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Traffic_Calming = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Traffic_Signal = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Turning_Loop = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Sunrise_Sunset = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Civil_Twilight = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Nautical_Twilight = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    Astronomical_Twilight = table.Column<string>(type: "nvarchar(1000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoadAccidents", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoadAccidents");
        }
    }
}
