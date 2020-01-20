namespace TaxCalculator
{
    public class DefaultTaxCalculator
    {
        public int CalculateTax(Vehicle vehicle, bool secondYearTaxFeatureEnabled = false, bool expensiveTaxFeatureEnabled = false)
        {
            int tax;
            if (vehicle.DateOfFirstRegistration.Year == 2019)
            {
                tax = GetFirstYearTax(vehicle);
            }
            else if (vehicle.ListPrice >= 40000)
            {
                tax = SecondTaxExpensivePayments(vehicle, expensiveTaxFeatureEnabled);
            }
            else
            {
                tax = SecondTaxPayments(vehicle, secondYearTaxFeatureEnabled);
            }

            return tax;
        }

        private static int GetFirstYearTax(Vehicle vehicle)
        {
            int firstYearTax = 0;
            switch (vehicle.FuelType)
            {
                case FuelType.Petrol:
                    firstYearTax = FirstYearPetrolTax(vehicle);
                    break;
                case FuelType.Diesel:
                    firstYearTax = FirstYearDieselTax(vehicle);
                    break;
                case FuelType.Electric:
                    break;
                case FuelType.AlternativeFuel:
                    firstYearTax = FirstYearAlternativeFuelTax(vehicle);
                    break;
                default:
                    break;
            }

            return firstYearTax;
        }

        private static int FirstYearPetrolTax(Vehicle vehicle)
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

        private static int FirstYearDieselTax(Vehicle vehicle)
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

        private static int FirstYearAlternativeFuelTax(Vehicle vehicle)
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
                    tax = 0;
                }
                else if (vehicle.Co2Emissions >= 51 && vehicle.Co2Emissions <= 75)
                {
                    tax = 15;
                }
                else if (vehicle.Co2Emissions >= 76 && vehicle.Co2Emissions <= 90)
                {
                    tax = 95;
                }
                else if (vehicle.Co2Emissions >= 91 && vehicle.Co2Emissions <= 100)
                {
                    tax = 115;
                }
                else if (vehicle.Co2Emissions >= 101 && vehicle.Co2Emissions <= 110)
                {
                    tax = 135;
                }
                else if (vehicle.Co2Emissions >= 111 && vehicle.Co2Emissions <= 130)
                {
                    tax = 155;
                }
                else if (vehicle.Co2Emissions >= 131 && vehicle.Co2Emissions <= 150)
                {
                    tax = 195;
                }
                else if (vehicle.Co2Emissions >= 151 && vehicle.Co2Emissions <= 170)
                {
                    tax = 505;
                }
                else if (vehicle.Co2Emissions >= 171 && vehicle.Co2Emissions <= 190)
                {
                    tax = 820;
                }
                else if (vehicle.Co2Emissions >= 191 && vehicle.Co2Emissions <= 225)
                {
                    tax = 1230;
                }
                else if (vehicle.Co2Emissions >= 226 && vehicle.Co2Emissions <= 255)
                {
                    tax = 1750;
                }
                else if (vehicle.Co2Emissions > 255)
                {
                    tax = 2060;
                }
            }

            return tax;
        }

        private static int SecondTaxPayments(Vehicle vehicle, bool secondTaxFeatureEnabled = false)
        {
            int tax = 0;
            if (secondTaxFeatureEnabled)
            {
                switch (vehicle.FuelType)
                {
                    case FuelType.Petrol:
                    case FuelType.Diesel:
                        tax = 140;
                        break;
                    case FuelType.Electric:
                        tax = 0;
                        break;
                    case FuelType.AlternativeFuel:
                        tax = 130;
                        break;
                    default:
                        break;
                }
            }
            return tax;
        }
        private static int SecondTaxExpensivePayments(Vehicle vehicle, bool expensiveTaxFeatureEnabled = false)
        {
            int tax = 0;
            if (expensiveTaxFeatureEnabled)
            {
                switch (vehicle.FuelType)
                {
                    case FuelType.Petrol:
                    case FuelType.Diesel:
                        tax = 450;
                        break;
                    case FuelType.Electric:
                        tax = 310;
                        break;
                    case FuelType.AlternativeFuel:
                        tax = 440;
                        break;
                    default:
                        break;
                }
            }
            return tax;
        }
    }
}