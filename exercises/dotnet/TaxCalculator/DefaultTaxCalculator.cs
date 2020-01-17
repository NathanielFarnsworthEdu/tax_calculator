namespace TaxCalculator
{
    public class DefaultTaxCalculator
    {
        public int CalculateTax(Vehicle vehicle)
        {
            int tax = 0;
            switch (vehicle.FuelType)
            {
                case FuelType.Petrol:
                    tax = PetrolTax(vehicle);
                    break;
                case FuelType.Diesel:
                    tax = DieselTax(vehicle);
                    break;
                case FuelType.Electric:
                    break;
                case FuelType.AlternativeFuel:
                    break;
                default:
                    break;
            }
            return tax;
        }

        private static int PetrolTax(Vehicle vehicle)
        {
            int tax = 0;
            if (vehicle != null)
            {
                if (vehicle.Co2Emissions == 0)
                {
                    tax = 0;
                }
                else if (vehicle.Co2Emissions >= 1 && vehicle.Co2Emissions <= 50)
                {
                    tax = 10;
                }
                else if (vehicle.Co2Emissions >= 51 && vehicle.Co2Emissions <= 75)
                {
                    tax = 25;
                }
                else if (vehicle.Co2Emissions >= 76 && vehicle.Co2Emissions <= 90)
                {
                    tax = 105;
                }
                else if (vehicle.Co2Emissions >= 91 && vehicle.Co2Emissions <= 100)
                {
                    tax = 125;
                }
                else if (vehicle.Co2Emissions >= 101 && vehicle.Co2Emissions <= 110)
                {
                    tax = 145;
                }
                else if (vehicle.Co2Emissions >= 111 && vehicle.Co2Emissions <= 130)
                {
                    tax = 165;
                }
                else if (vehicle.Co2Emissions >= 131 && vehicle.Co2Emissions <= 150)
                {
                    tax = 205;
                }
                else if (vehicle.Co2Emissions >= 151 && vehicle.Co2Emissions <= 170)
                {
                    tax = 515;
                }
                else if (vehicle.Co2Emissions >= 171 && vehicle.Co2Emissions <= 190)
                {
                    tax = 830;
                }
                else if (vehicle.Co2Emissions >= 191 && vehicle.Co2Emissions <= 225)
                {
                    tax = 1240;
                }
                else if (vehicle.Co2Emissions >= 226 && vehicle.Co2Emissions <= 255)
                {
                    tax = 1760;
                }
                else if (vehicle.Co2Emissions > 255)
                {
                    tax = 2070;
                }
            }
            return tax;
        }

        private static int DieselTax(Vehicle vehicle)
        {
            int tax = 0;
            if (vehicle != null)
            {
                if (vehicle.Co2Emissions == 0)
                {
                    tax = 0;
                }
                else if (vehicle.Co2Emissions >= 1 && vehicle.Co2Emissions <= 50)
                {
                    tax = 25;
                }
                else if (vehicle.Co2Emissions >= 51 && vehicle.Co2Emissions <= 75)
                {
                    tax = 105;
                }
                else if (vehicle.Co2Emissions >= 76 && vehicle.Co2Emissions <= 90)
                {
                    tax = 125;
                }
                else if (vehicle.Co2Emissions >= 91 && vehicle.Co2Emissions <= 100)
                {
                    tax = 145;
                }
                else if (vehicle.Co2Emissions >= 101 && vehicle.Co2Emissions <= 110)
                {
                    tax = 165;
                }
                else if (vehicle.Co2Emissions >= 111 && vehicle.Co2Emissions <= 130)
                {
                    tax = 205;
                }
                else if (vehicle.Co2Emissions >= 131 && vehicle.Co2Emissions <= 150)
                {
                    tax = 515;
                }
                else if (vehicle.Co2Emissions >= 151 && vehicle.Co2Emissions <= 170)
                {
                    tax = 830;
                }
                else if (vehicle.Co2Emissions >= 171 && vehicle.Co2Emissions <= 190)
                {
                    tax = 1240;
                }
                else if (vehicle.Co2Emissions >= 191 && vehicle.Co2Emissions <= 225)
                {
                    tax = 1760;
                }
                else if (vehicle.Co2Emissions >= 226 && vehicle.Co2Emissions <= 255)
                {
                    tax = 2070;
                }
                else if (vehicle.Co2Emissions > 255)
                {
                    tax = 2070;
                }
            }
            return tax;
        }
    }
}
