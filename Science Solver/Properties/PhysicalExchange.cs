using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Science_Solver.AppModel
{
    public static class PhysicalExchange
    {
        public static List<string> ListChoiceExchange = new List<string> { "inch - cetimeter",
"cetimeter - inch",
"ft - meter",
"meter - ft",
"yard - meter",
"meter - yard",
"mile - km",        
"km - mile",
"n mile - meter",
"meter - n mile",
"arce - m^2",
"m^2 - arce",
"gallon(US) - liter",
"liter - gallon(US)",
"gallon(UK) - liter",
"liter - gallon(UK)",
"pc - km",
"km - pc",
"km/h - m/s",
"m/s - km/s",
"oz - gram",
"gram - oz",
"lb - kg",
"kg - lb",
"atm - Pascan",
"Pascan - atm",
"mmHg - Pascan",
"Pascan - mmHg",
"hp - KW",
"KW - hp",
"kgF/cm^2 - Pascan",
"Pascan - kgF/cm^2",
"kgF/m - Jun",
"Jun - kgF/m",
"lbf/inch^2 - kPa",
"kPa - lbf/inch^2",
"Kelvin - Celcius",
"Celcius - Kelvin",
"Celcius - Fahrenhit",
"Fahrenhit - Celcius",
"Fahrenhit - Kelvin",
"Kelvin - Fahrenhit",
"Jun - Calo",
"Calo - Jun",
"Radian - C",
"C - Radian",
"tons - kg",
"kg - tons",
"neutral miles - meter",
"meter - neutral miles",
"seconds - timeofcasesium",
"timeofcasesium - seconds",
"Ae - kilometer",
"kilometer - Ae",
"meter - Amstrong",
"Amstrong - meter",
"YearLight - km",
"kg - Slug",
"Slug - kg",
"Curie - GBq",
"GBq - Curie"};
        public static double Curie_to_GBq(double x)
        {
            if (x <= 0) return 0;
            else return 37 * x;
        }
        public static double GBq_to_Curie(double x)
        {
            if (x <= 0) return 0;
            else return x / 37;
        }

        public static double tons_to_kg(double x)
        {
            if (x <= 0) return 0;
            else return x / 1000;
        }
        public static double kg_to_tons(double x)
        {
            if (x <= 0) return 0;
            else return x * 1000;
        }
        public static double seconds_to_timeOfCasesium(long x)
        {
            if (x <= 0) return 0;
            else return x * 9192631770;
        }
        public static double timeOfCasesium_to_second(long x)
        {
            if (x <= 0) return 0;
            else return x / 9192631770;
        }
        public static double neutralmiles_to_meter(double x)
        {
            if (x <= 0) return 0;
            else return x * 1850;
        }
        public static double meter_to_neutralmiles(double x)
        {
            if (x <= 0) return 0;
            else return x / 1850;
        }
        public static double Amstrong_to_meter(double x)
        {
            if (x <= 0) return 0;
            else return x * (Math.Pow(10, 10));
        }
        public static double meter_to_Amstrong(double x)
        {
            if (x <= 0) return 0;
            else return x / (Math.Pow(10, 10));
        }
        public static long yearLight_to_km(double x)
        {
            if (x <= 0) return 0;
            else return (long)(x * 9.461 * Math.Pow(10, 12));
        }
        public static double Ae_to_kilometer(double x)
        {
            if (x <= 0) return 0;
            else return (x * 1.49 * Math.Pow(10, 3));
        }
        public static double kilometer_to_Ae(double x)
        {
            if (x <= 0) return 0;
            else return (x * 1.49 * Math.Pow(10, 3));
        }
        public static double Slug_to_kg(double x)
        {
            if (x <= 0) return 0;
            else return 14.59 * x;
        }
        public static double Kg_to_Slug(double x)
        {
            if (x <= 0) return 0;
            else return x / 14.59;
        }
        public static double Radian_to_C(double x)
        {
            return 180 * x;
        }
        public static double C_to_Radian(double x)
        {
            return x / 180;
        }
        public static double inch_exchange_cm(double x)
        {
            if (x <= 0) return 0; return ((127 * x) / 50);
        }
        public static double cm_exchange_inch(double x)
        {
            if (x <= 0) return 0; return ((50 * x) / 127);
        }
        public static double ft_exchange_meter(double x)
        {
            if (x <= 0) return 0; return ((381 * x) / 1250);
        }
        public static double meter_exchange_ft(double x)
        {
            if (x <= 0) return 0; return ((1250 * x) / 381);
        }
        public static double yard_exchange_meter(double x)
        {
            if (x <= 0) return 0; return ((1143 * x) / 1250);
        }
        public static double meter_exchange_yard(double x)
        {
            if (x <= 0) return 0; return ((1250 * x) / 1143);
        }
        public static double mile_exchange_km(double x)
        {
            if (x <= 0) return 0; return (1.609344 * x);
        }
        public static double km_exchange_mile(double x)
        {
            if (x <= 0) return 0; return (x / 1.609344);
        }
        public static double n_mile_exchange_meter(double x)
        {
            if (x <= 0) return 0; return 1852 * x;
        }
        public static double meter_exchange_n_mile(double x)
        {
            if (x <= 0) return 0; return x / 1852;
        }
        public static double acre_exchange_square_meter(double x)
        {
            if (x <= 0) return 0; return 4046.856 * x;
        }
        public static double square_meter_exchange_acre(double x)
        { if (x <= 0) return 0; return ((125 * x) / 505857); }
        public static double gallon_US_exchange_liter(double x)
        { if (x <= 0) return 0; return (3.785412 * x); }
        public static double liter_exchange_gallon_US(double x)
        {
            if (x <= 0) return 0; return (x / 3.785412);
        }
        public static double gallon_UK_exchange_liter(double x)
        {
            if (x <= 0) return 0; return (x * 4.54609);
        }
        public static double liter_exchange_gallon_UK(double x)
        {
            if (x <= 0) return 0; return (x / 4.54609);
        }
        public static double pc_exchange_km(double x)
        {
            if (x <= 0) return 0; return (x * 3.085678 * Math.Pow(10, 13));
        }
        public static double km_exchange_pc(double x)
        {
            if (x <= 0) return 0; return (x * 3.24077885 * Math.Pow(10, 14));
        }
        public static double kmhour_exchange_metersecond(double x)
        { if (x <= 0) return 0; return ((x * 5) / 18); }
        public static double metersecond_exchange_kmhour(double x)
        {
            if (x <= 0) return 0; return ((x * 18) / 5);
        }
        public static double oz_exchange_gram(double x)
        { if (x <= 0) return 0; return x * 28.34952; }
        public static double gram_exchange_oz(double x)
        { if (x <= 0) return 0; return x / 28.34952; }
        public static double lb_exchange_kilogram(double x)
        {
            if (x <= 0) return 0; return x * 0.4535924;
        }
        public static double kilogram_exchange_lb(double x)
        { if (x <= 0) return 0; return x / 0.4535924; }
        public static double atmosphere_exchange_Pascan(double x)
        { if (x <= 0) return 0; return x * 101325; }
        public static double Pascan_exchange_atmosphere(double x)
        { if (x <= 0) return 0; return x / 101325; }
        public static double Millimetre_of_mercury_exchange_Pascan(double x)
        { if (x <= 0) return 0; return x * 133.3224; }
        public static double Pascan_exchange_Millimetre_of_mercury(double x)
        { if (x <= 0) return 0; return x / 133.3224; }
        public static double hp_exchange_KW(double x)
        { if (x <= 0) return 0; return x * 0.7457; }
        public static double KW_exchange_hp(double x)
        {
            if (x <= 0) return 0; return x / 0.7457;
        }
        public static double kilogramF_CetimeterSquare_exchange_Pascan(double x)
        { if (x <= 0) return 0; return (x * 196133) / 2; }
        public static double Pascan_exchange_kilogramF_CetimeterSquare(double x)
        { if (x <= 0) return 0; return (x * 2) / 196133; }
        public static double KilogramF_Meter_exchange_Jun(double x)
        { if (x <= 0) return 0; return x * 9.80665; }
        public static double Jun_exchange_KilogramF_Meter(double x)
        { if (x <= 0) return 0; return x / 9.80665; }
        public static double lbf_inch_square_exchange_kPa(double x)
        {
            if (x <= 0) return 0;
            return x * 6.894757;
        }
        public static double kPa_exchange_square_lbf_inch_square(double x)
        {
            if (x <= 0) return 0;
            return x / 6.894757;
        }
        public static double Kelvin_exchange_Celsius(double x)
        {
            if (x <= 0) return -273.15;
            return (x + (-273.15));
        }
        public static double Celsius_exchange_Kelvin(double x)
        {
            if (x <= -273.155) return 0;
            return (x + 273.15);
        }
        public static double Celsius_exchange_fahrenheit(double x)
        {
            if (x <= -273.155) return -459.67;
            return ((x * 9 / 5) + 32);
        }
        public static double fahrenheit_exchange_Celsius(double x)
        {
            if (x <= -459.67) return -273.15;
            return ((x - 32) * 5.00 / 9.00);
        }
        public static double fahrenheit_exchange_Kelvin(double x)
        {
            if (x <= -459.67) return 0;
            return (273.15 + ((x - 32) * 5.00 / 9.00));
        }
        public static double Kelvin_exchange_fahrenheit(double x)
        {
            if (x <= 0) return -459.67;
            return (((x - 273.15) * 9.00 / 5.00) + 32);
        }
        public static double Jun_exchange_Calo(double x)
        {
            if (x <= 0) return 0;
            return ((x * 5000) / 20929);
        }
        public static double Calo_exchange_Jun(double x)
        {
            if (x <= 0) return 0;
            return ((x * 20929) / 5000);
        }
    }
}
