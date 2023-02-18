using System;
using System.Collections.Generic;
using System.Text;

namespace SmsApp
{
    class Ind
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public object this[int index]
        {
            set
            {
                if (index == 0)
                    Id = Convert.ToInt32(value);

                else if (index == 1)
                    Name = Convert.ToString(value);
                else if (index == 2)
                    Price = Convert.ToDecimal(value);
                else
                    throw new Exception("Invalid Indexs");
            }

            get
            {
                if (index == 0)
                    return Id;
                else if (index == 1)
                    return Name;
                else if (index == 2)
                    return Price;
                else
                    throw new Exception("Invalid Indexes");
            }
        }
        public object this[string key]
            {
            set
            {
                if (key.ToLower() == "id")
                    Id = Convert.ToInt32(value);
                else if (key.ToLower() == "name")
                    Name = Convert.ToString(value);
                else if (key.ToLower() == "price")
                    Price = Convert.ToDecimal(value);
                else
                    throw new Exception("Index Invalid");
            }
            get
            {
                if (key.ToLower() == "id")
                    return Id;
                else if (key.ToLower() == "name")
                    return Name;

                else if (key.ToLower() == "price")
                    return Price;

                else
                    throw new Exception("Index Invalid");
            }
            }

        public static void Main(string[] args)
        {
            Ind n = new Ind();
            Console.WriteLine("Value using the Integer Value");
            Console.WriteLine("------------------------------------------");
            n[0] = 2001;
            n[1] = "Aman";
            n[2] = 12000.00;
            Console.WriteLine(n[0]);
            Console.WriteLine(n[1]);
            Console.WriteLine(n[2]);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Value using the String Value");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Index Overloaded");
            n["id"] = 123;
            n["name"] = "Darshit Chaudhary";
            n["Price"]=21000.00;
            Console.WriteLine(n["id"]);
            Console.WriteLine(n["name"]);
            Console.WriteLine(n["price"]);

            
        }
    }
     
        
}
