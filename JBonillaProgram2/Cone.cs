/*
 * Project: Assignment Set 1 - Program 2
 * Date:    September 2022
 * Developed By:    Julissa Bonilla
 * Class Name:  Cone
 * Description: Business Logic static class calculate the area and volume of a cone.
 * Last modified: 9/9/2022
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace JBonillaProgram2
{
    static class Cone
    {
        //Calculate the returns of the surface area of a cone
        public static double CalculateArea(int radius, int height)
        {
            return Math.PI * radius * (radius + Math.Sqrt(Math.Pow(radius, 2)+Math.Pow(height,2)));
        }
        //Calculate the returns of the volume of a cone
        public static double CalculateVolume(int radius, int height)
        {
            return Math.PI * Math.Pow(radius, 2) * height / 3;
        }
    }
}
