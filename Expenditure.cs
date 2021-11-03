using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QueteRazor.Models
{
    public class Expenditure
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }

        public Expenditure (string name, DateTime date, double price)
        {
            Name = name;
            Date = date;
            Price = price; 
        }


    }
}