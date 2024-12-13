namespace Roomie.Domain
{
    public record Building(int Id, string Name, List<Room> Rooms, List<string> Features);
}
