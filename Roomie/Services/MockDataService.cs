using Roomie.Domain;

namespace Roomie.Services
{
    public class MockDataService
    {
        public List<Building> Buildings { get; set; } = new();

        public MockDataService()
        {
            // Chateau
            var chateauRooms = new List<Room>()
            {
                new Room(12, 0, new List<string> { "1 double bed (160 cm)", "shower" }, 77, 2),
                new Room(14, 0, new List<string> { "Suite with lounge (sofa bed)", "shower" }, 95, 3),
                new Room(15, 0, new List<string> { "Small suite with lounge", "bath" }, 85, 2),
                new Room(16, 0, new List<string> { "1 double bed (140 cm)", "shower" }, 77, 2),
                new Room(17, 0, new List<string> { "Small suite with lounge", "shower" }, 85, 2),
                new Room(21, 0, new List<string> { "1 double bed (140 cm)", "shower" }, 77, 2),
                new Room(22, 0, new List<string> { "1 double bed (160 cm)", "shower" }, 77, 2),
                new Room(24, 0, new List<string> { "Suite with lounge (sofa bed)", "shower" }, 95, 3),
                new Room(25, 0, new List<string> { "Small suite with lounge", "bath" }, 85, 2),
                new Room(26, 0, new List<string> { "1 double bed (140 cm)", "shower" }, 77, 2),
                new Room(27, 0, new List<string> { "Large suite with lounge and dining area", "bath" }, 120, 2)
            };
            var chateauFeatures = new List<string>()
            {
                "Maximum capacity: 15 people (children included).",
                "Kitchenettes in each room: Every room and suite has a kitchenette, private bathroom, and WC.",
                "Family-friendly rooms: Rooms 14, 24, and 27 have sofa beds, making them ideal for families with children.",
                "Room 27: Often used by the bride for wedding preparations due to its spacious layout."
            };
            var chateau = new Building(1, "Château", chateauRooms, chateauFeatures);
            Buildings.Add(chateau);

            // Internat
            var internatRooms = new List<Room>()
            {
                new Room(1, 0, new List<string> { "King-size bed", "shower", "wheelchair accessible" }, 90, 2),
                new Room(2, 0, new List<string> { "King-size bed", "shower" }, 85, 2),
                new Room(3, 0, new List<string> { "King-size bed", "shower" }, 85, 2),
                new Room(4, 0, new List<string> { "King-size bed", "shower" }, 85, 2),
                new Room(5, 0, new List<string> { "King-size bed", "shower" }, 85, 2),
                new Room(6, 0, new List<string> { "King-size bed", "shower", "wheelchair accessible" }, 90, 2),
                new Room(20, 1, new List<string> { "King-size bed", "bath" }, 90, 2),
                new Room(21, 1, new List<string> { "King-size bed", "shower" }, 85, 2),
                new Room(22, 1, new List<string> { "King-size bed", "shower" }, 85, 2),
                new Room(23, 1, new List<string> { "King-size bed", "shower" }, 85, 2),
                new Room(25, 1, new List<string> { "King-size bed", "bath" }, 90, 2),
                new Room(26, 1, new List<string> { "King-size bed", "shower" }, 85, 2),
                new Room(27, 1, new List<string> { "King-size bed", "shower" }, 85, 2),
                new Room(28, 1, new List<string> { "King-size bed", "shower" }, 85, 2),
                new Room(29, 1, new List<string> { "King-size bed", "shower" }, 85, 2),
                new Room(30, 1, new List<string> { "King-size bed", "shower" }, 85, 2),
                new Room(31, 1, new List<string> { "King-size bed", "shower" }, 85, 2),
                new Room(32, 1, new List<string> { "King-size bed", "shower" }, 85, 2),
                new Room(33, 1, new List<string> { "King-size bed", "shower" }, 85, 2),
                new Room(34, 1, new List<string> { "Family room with sofa bed", "bath" }, 120, 3),
                new Room(35, 1, new List<string> { "Family room with sofa bed", "bath" }, 120, 3)
            };

            var internatFeatures = new List<string>()
            {
                "Air-conditioned: All rooms are air-conditioned.",
                "Private bathrooms: Each room includes a private bathroom and WC.",
                "Ground floor accessibility: Rooms 1 and 6 are wheelchair accessible.",
                "Family rooms: Rooms 34 and 35 feature sofa beds for additional guests, ideal for families with children.",
                "Reservation requirement: A minimum of 12 rooms must be reserved on the wedding night to open the building.",
                "Lobby and Tisanerie: Common areas with coffee makers (Filter, Nespresso, Dolce Gusto), microwave, and refrigerator are available for guest use."
            };

            var internat = new Building(2, "Internat", internatRooms, internatFeatures);
            Buildings.Add(internat);
        }
    }
}
