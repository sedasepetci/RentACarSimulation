namespace RentACarSimulation.Models;

public class Car
{
    public Car(int id, int colorId, int fuelId, int transMissionId, string? carState, int? kiloMeter, short? modelYear, string? plate, string? brandName, string? modelName, double? dailyPrice)
    {
        Id = id;
        ColorId = colorId;
        FuelId = fuelId;
        TransMissionId = transMissionId;
        CarState = carState;
        KiloMeter = kiloMeter;
        ModelYear = modelYear;
        Plate = plate;
        BrandName = brandName;
        ModelName = modelName;
        DailyPrice = dailyPrice;
    }

    public int Id { get; set; }
    public int ColorId { get; set; }
    public int FuelId { get; set; }
    public int TransMissionId { get; set; }
    public string? CarState { get; set; }
    public int? KiloMeter { get; set; }
    public short? ModelYear { get; set; }
    public string? Plate { get; set; }
    public string? BrandName { get; set; }
    public string? ModelName { get; set; }
    public double? DailyPrice { get; set; }
}
