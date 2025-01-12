namespace Roomie.Utils
{
    public static class RoomUtilities
    {
        public static string GetFloorName(int floor)
        {
            return floor switch
            {
                0 => "ground floor",
                1 => "first floor",
                _ => $"{floor} floor"
            };
        }
    }
}
