using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Invoicing
{
    using System;
    using System.Runtime.InteropServices;

    public class Invoice
    {
        private string _partNumber;
        private string _partDescription;
        private int _quantity;
        private double _price;

        public string PartNumber { get { return _partNumber; } set { _partNumber = value; } }
        public string PartDescription { get { return _partDescription; } set { _partDescription = value; } }
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value > 0)
                {
                    _quantity = value;
                }
                else
                {
                    _quantity = 0;
                }
            }
        }
        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    _price = 0;
                }
            }
        }
        public Invoice(string Angka, string Desc, int Jml, double Hrg)
        {
            PartNumber = Angka; PartDescription = Desc; Price = Hrg; Quantity = Jml;
      
        }

        public double GetInvoiceAmount()
        {
            return (double)Quantity * (double)Price;
        }

    }
    //public class Program
    //{
    //    static void Main()
    //    {
    //        Invoice test = new Invoice("Test", "Test", 5, 8000);
    //        Invoice test1 = new Invoice("Test1", "Test1", -10, 8000);
    //        Invoice test2 = new Invoice("Test2", "Test2", 0, -10);
    //        Console.WriteLine(test.GetInvoiceAmount());
    //        Console.WriteLine(test1.Price);
    //        Console.WriteLine(test2.Quantity);
    //    }
    //}


}

