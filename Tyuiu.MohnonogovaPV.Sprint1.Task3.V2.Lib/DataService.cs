﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MohnonogovaPV.Sprint1.Task3.V2.Lib
{
    public class DataService : ISprint1Task3V2
    {
        public double PurchaseAmount(double priceNotebook, int amountNotebook, double pricePencil, int amountPencil)
        {
            var res = Math.Round((priceNotebook * amountNotebook + pricePencil * amountPencil), 3);
            return res;
        }
    }
}
