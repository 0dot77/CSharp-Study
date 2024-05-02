﻿namespace _07._6._3_AccessModifier
{
    class WaterHeater
    {
        protected int temperature;

        public void SetTemperature(int temperature)
        {
            if(temperature < -5 || temperature > 42)
            {
                throw new Exception("Out of temperature range"); // 예외를 발생시키는 코드 
            }
            this.temperature = temperature;
        }

        internal void TurnOnWater()
        {
            Console.WriteLine($"Turn on water : {temperature}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

            WaterHeater heater = new WaterHeater();
            heater.SetTemperature(20);
            heater.TurnOnWater();

            heater.SetTemperature(-2);
            heater.TurnOnWater();

            heater.SetTemperature(50);
            heater.TurnOnWater();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}