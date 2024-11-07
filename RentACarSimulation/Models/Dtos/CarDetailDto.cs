

namespace RentACarSimulation.Models.Dtos
{
    public class CarDetailDto
    {
        public CarDetailDto(int id, string? fuelName, string? transmissionName, string? colorName, string? carState, int? kiloMeter, short? modelYear, string? plate, string? brandName, string? modelName, double? dailyPrice)
        {
            Id = id;
            FuelName = fuelName;
            TransmissionName = transmissionName;
            ColorName = colorName;
            CarState = carState;
            KiloMeter = kiloMeter;
            ModelYear = modelYear;
            Plate = plate;
            BrandName = brandName;
            ModelName = modelName;
            DailyPrice = dailyPrice;
        }

        public int Id { get; set; }
        public string? FuelName { get; set; }
        public string? TransmissionName { get; set; }
        public string? ColorName { get; set; }
        public string? CarState { get; set; }
        public int? KiloMeter { get; set; }

        public short? ModelYear { get; set; }
        public string? Plate { get; set; }
        public string? BrandName { get; set; }
        public string? ModelName { get; set; }
        public double? DailyPrice { get; set; }


    
        public override string ToString()
            {
                return $"ID: {Id}, Brand: {BrandName}, Model: {ModelName}, Color: {ColorName}, Fuel: {FuelName}, Transmission: {TransmissionName}, Daily Price: {DailyPrice}";
            }
        
    }
}
