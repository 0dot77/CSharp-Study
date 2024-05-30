﻿namespace _09._020_PropertiesInAbstractClass
{
    abstract class Product
    {
        private static int serial = 0;
        public string SerialID
        {
            get { return String.Format("{0:d5}", serial++); }
        }

        abstract public DateTime ProductDate
        {
            get;
            set;
        }
    }

    class MyProduct : Product
    {
        public override DateTime ProductDate { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product_1 = new MyProduct()
            {
                ProductDate = new DateTime(2024, 5, 17)
            };

            Console.WriteLine("Product:{0}, Product Date : {1}",
                               product_1.SerialID,
                                              product_1.ProductDate);
        }
    }
}