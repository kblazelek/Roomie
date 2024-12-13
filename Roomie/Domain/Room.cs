namespace Roomie.Domain
{
    public record Room(int Number, int Floor, List<string> Features, decimal PricePerNight, int MaxPeople);
}