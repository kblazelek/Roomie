using Amazon.DynamoDBv2.DataModel;

namespace Roomie.Domain
{
    [DynamoDBTable("Bookings")]
    public class Booking
    {
        [DynamoDBHashKey("BuildingId")]
        public int BuildingId { get; set; }
        [DynamoDBRangeKey("RoomNumber")]
        public int RoomNumber { get; set; }
        [DynamoDBProperty("FirstName")]
        public string FirstName { get; set; }
        [DynamoDBProperty("LastName")]
        public string LastName { get; set; }
        [DynamoDBProperty("Email")]
        public string Email { get; set; }
        [DynamoDBProperty("DayChoice")]
        public string DayChoice { get; set; }
        [DynamoDBProperty("Token")]
        public string Token { get; set; }
    }
}
