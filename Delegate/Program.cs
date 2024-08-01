using Delegate;
using static Delegate.Building;

Building[] buildings = new Building[3];
buildings[0] = new Building { BuildingName = "Sky Tower", Height = 150, Floors = 50, TotalArea = 2000, Location = "City Center" };
buildings[1] = new Building { BuildingName = "Ocean View", Height = 80, Floors = 25, TotalArea = 1500, Location = "Coastal Area" };
buildings[2] = new Building { BuildingName = "Mountain Lodge", Height = 30, Floors = 10, TotalArea = 500, Location = "Mountain Region" };

CalculateBuildingVolumes(buildings, b => b.CalculateVolume());


    static void CalculateBuildingVolumes(Building[] buildings, VolumeCalculator calc)
{
    foreach (var building in buildings)
    {
        Console.WriteLine($"Volume of {building.BuildingName}: {calc(building)} m³");
    }
}