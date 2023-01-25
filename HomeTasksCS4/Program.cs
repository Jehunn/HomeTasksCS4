using System;

namespace HomeTasksCS4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Notebook info = new Notebook("Razer", "Blade 15")
            {
                Price = 4000
            };
            //Console.WriteLine(info.GroupInfo());




            Notebook[] nb = new Notebook[3];
            
            for(int i=0; i<nb.Length; i++)
            {
                Console.WriteLine("Mehsulun brand-ini daxil edin :");
                string brand=Console.ReadLine();
                
       
                Console.WriteLine("Mehsulun modelini daxil edin :");
                string model= Console.ReadLine();

                double price;
                Console.WriteLine("Mehsulun qiymetini daxil edin :");
                string priceStr = Console.ReadLine();
                price = Convert.ToDouble(priceStr);

                Notebook pr = new Notebook(brand, model,price);

                nb[i]=pr;
                

               
            }

            for (int i = 0; i < nb.Length; i++)
            {
                Console.WriteLine(nb[i].GroupInfo());
            }


            double sum = 0;
            for (int i = 0; i < nb.Length; i++)
            {
                sum += nb[i].Price;   
            }
            double average=sum/nb.Length;

            Console.WriteLine(average);
        }
    }
}
