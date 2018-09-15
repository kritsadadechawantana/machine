using System;

namespace machine
{
    public class Calculator
    {
        public Result Calculate(int price, int cash)
        {
            var total = cash - price;
            var remaining = total;
            var result = new Result();


            if (remaining >= 1000)
            {
                result.ThousandBath += remaining / 1000;
                remaining -= result.ThousandBath * 1000;
            }
            if (remaining >= 500)
            {
                result.FiveHundredBath += remaining / 500;
                remaining -= result.FiveHundredBath * 500;
            }
            if (remaining >= 100)
            {
                result.HundredBath += remaining / 100;
                remaining -= result.HundredBath * 100;
            }
            if (remaining >= 50)
            {
                result.FiftyBath += remaining / 50;
                remaining -= result.FiftyBath * 50;
            }
            if (remaining >=20)
            {
                result.TwentyBath += remaining / 20;
                remaining -= result.TwentyBath * 20;
            }
            if (remaining >= 10)
            {
                result.TenBath += remaining / 10;
                remaining -= result.TenBath * 10;
            }
            while (remaining >= 5)
            {
                result.FiveBath +=1;
                remaining -=5;
            }
            while (remaining >= 1)
            {
                result.OneBath +=1;
                remaining -=1;
            }
            
            return result;
        }
    }
}