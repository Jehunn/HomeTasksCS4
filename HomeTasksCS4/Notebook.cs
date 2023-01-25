using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HomeTasksCS4
{
    internal class Notebook
    {


        public Notebook(string brand,string model,double price=0)
        {
            this.Brand = brand;
            this.Model = model;
            this.Price= price;

        }

        public string GroupInfo()
        {
            return $"{Brand}-{Model}-{Price}";
        }



        public string Brand;
        public string Model;
        public double Price;

            







    }
    

    
}    



    

