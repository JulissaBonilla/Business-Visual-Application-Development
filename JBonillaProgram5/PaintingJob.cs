/*
 * Project: Assignment Set 2 - Program 5
 * Date:    September 2022
 * Developed By:    Julissa Bonilla
 * Class Name:  PaintingJob
 * Description: This program calculates the estimated cost of a paint job given 
 * the size of the project and the cost of paint.
 * Last modified: 9/21/2022
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace JBonillaProgram5
{
    class PaintingJob
    {
        public double EstimateCost(double sqrFt,double gllnPaintCost)
        {
            double paintCost = (sqrFt / 385) * gllnPaintCost;
            double laborCost = sqrFt * 3.40;
            return paintCost + laborCost;
        }
    }
}
