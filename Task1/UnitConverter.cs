using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Task1
{
    public static class UnitConverter
    {

        public static double MilimeterToCentimetre(double milimeter) => milimeter * 0.1;
        public static double MilimeterToDecimeter(double milimeter) => milimeter * 0.01;
        public static double MilimeterToMetre(double milimeter) => milimeter * 0.001;
        public static double MilimeterToKilometer(double milimeter) => milimeter * 0.000001;

        public static double CentimetreToMilimeter(double centimetre) => centimetre * 10;
        public static double CentimetreToDecimeter(double centimetre) => centimetre * 0.1;
        public static double CentimetreToMetre(double centimetre) => centimetre * 0.01;
        public static double CentimetreToKilometer(double centimetre) => centimetre * 0.00001;

        public static double DecimeterToMilimeter(double decimeter) => decimeter * 100;
        public static double DecimeterToCentimetre(double decimeter) => decimeter * 10;
        public static double DecimeterToMetre(double decimeter) => decimeter * 0.1;
        public static double DecimeterToKilometer(double decimeter) => decimeter * 0.0001;

        public static double MetreToMilimeter(double decimeter) => decimeter * 1000;
        public static double MetreToCentimetre(double decimeter) => decimeter * 100;
        public static double MetreToDecimeter(double decimeter) => decimeter * 10;
        public static double MetreToKilometer(double decimeter) => decimeter * 0.001;

        public static double KilometerToMilimeter(double kilometer) => kilometer * 1000000;
        public static double KilometerToCentimeter(double kilometer) => kilometer * 100000;
        public static double KilometerToDecimeter(double kilometer) => kilometer * 10000;
        public static double KilometerToMetre(double kilometer) => kilometer * 1000;

        public static double MilligramsToGram(double milligrams) => milligrams * 0.001;
        public static double MilligramsToKilogram(double milligrams) => milligrams * 0.000001;

        public static double GramToMilligrams(double gram) => gram * 1000;
        public static double GramToKilogram(double gram) => gram * 0.001;

        public static double KilogramToMilligrams(double kilogram) => kilogram * 1000000;
        public static double KilogramToGram(double kilogram) => kilogram * 1000;

        public static double MilliliterToLiter(double milliliter) => milliliter * 0.001;
        public static double LiterToLiter(double liter) => liter * 1000;

    }
}
