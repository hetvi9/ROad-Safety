using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RodeSafetyTool.Models
{
    public class RoadAccident
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string Severity { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
       /* public string Start_Time { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string End_Time { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string Start_Lat { get; set; }
        [Column(TypeName = "nvarchar(1000)")]

        public string Start_Lng { get; set; }
        [Column(TypeName = "nvarchar(1000)")]

        public string End_Lat { get; set; }
        [Column(TypeName = "nvarchar(1000)")]

        public string End_Lng { get; set; }
        [Column(TypeName = "nvarchar(1000)")]

        public string Distance { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
*/
        public string Description { get; set; }
        [Column(TypeName = "nvarchar(1000)")]

       /* public string Number { get; set; }
        [Column(TypeName = "nvarchar(1000)")]*/

        public string Street { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string Side { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string City { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
       /* public string County { get; set; }
        [Column(TypeName = "nvarchar(1000)")]*/
        public string State { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string Zipcode { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string Country { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string Timezone { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
       /* public string Airport_Code { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string Weather_Timestamp { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string Temperature { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string Wind_Chill { get; set; }
        [Column(TypeName = "nvarchar(1000)")]

        public string Humidity { get; set; }
        [Column(TypeName = "nvarchar(1000)")]*/

       /* public string Pressure { get; set; }
        [Column(TypeName = "nvarchar(1000)")]

        public string Visibility { get; set; }
        [Column(TypeName = "nvarchar(1000)")]

        public string Wind_Direction { get; set; }
        [Column(TypeName = "nvarchar(1000)")]

        public string Wind_Speed { get; set; }
        [Column(TypeName = "nvarchar(1000)")]

        public string Precipitation { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string Weather_Condition { get; set; }
        [Column(TypeName = "nvarchar(1000)")]*/
       /* public string Amenity { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string Bump { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string Crossing { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string Give_Way { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string Junction { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string No_Exit { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string Railway { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string Roundabout { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string Station { get; set; }
        [Column(TypeName = "nvarchar(1000)")]

        public string Stop { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
*/
        public string Traffic_Calming { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string Traffic_Signal { get; set; }
        [Column(TypeName = "nvarchar(1000)")]

        public string Turning_Loop { get; set; }
       /* [Column(TypeName = "nvarchar(1000)")]*/

       /* public string Sunrise_Sunset { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string Civil_Twilight { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string Nautical_Twilight { get; set; }
        [Column(TypeName = "nvarchar(1000)")]*/
       /* public string Astronomical_Twilight { get; set; }*/
       

    } 
}
