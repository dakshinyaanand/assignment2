using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PizzaOrder> po = new List<PizzaOrder>
            {
                new PizzaOrder {OrderId=12,OrderDate=DateTime.Now,PizzaType="Veg",PizzaSize='S',Topping="SweetCorn",Qty=2,price=525 },
                new PizzaOrder {OrderId=11,OrderDate=DateTime.Now,PizzaType="NonVeg",PizzaSize='M',Topping="Egg",Qty=5,price=725 },
                new PizzaOrder {OrderId=14,OrderDate=DateTime.Now,PizzaType="Veg",PizzaSize='L',Topping="Onion",Qty=4,price=448 },
                new PizzaOrder {OrderId=13,OrderDate=DateTime.Now,PizzaType="NonVeg",PizzaSize='S',Topping="Chicken",Qty=3,price=978 },
                new PizzaOrder {OrderId=16,OrderDate=DateTime.Now,PizzaType="Veg",PizzaSize='M',Topping="Capsicum",Qty=6,price=525 },
                new PizzaOrder {OrderId=20,OrderDate=DateTime.Now,PizzaType="Veg",PizzaSize='S',Topping="Tomato",Qty=1,price=325 }
            };

            foreach(var r in po)
            {
                Console.WriteLine(r.OrderId + " " + r.OrderDate + " " + r.PizzaType + " " + r.PizzaSize + " " + r.Topping + " " + r.Qty + " " + r.price);
            }
            Console.WriteLine("********************");
            var data1 = po.Select(x => new { PType=x.PizzaType,PSize=x.PizzaSize });

            foreach (var h in data1)
                Console.WriteLine(h.PType+ " " + h.PSize);
            Console.WriteLine("****************************");

            var data2 = po.GroupBy(x => x.PizzaType).Select(x => new { pType = x.Key, SumQTY = x.Sum(y => y.Qty),SumAmt=x.Sum(z=>z.price) });

            foreach (var h in data2)
                Console.WriteLine(h.pType + " " + h.SumQTY + " " + h.SumAmt);
            Console.WriteLine("****************************");

            var data3 = po.GroupBy(x => x.PizzaSize).Select(x => new { pSize = x.Key, SumQTY = x.Sum(y => y.Qty), SumAmt = x.Sum(z => z.price) });

            foreach (var h in data3)
                Console.WriteLine(h.pSize + " " + h.SumQTY + " " + h.SumAmt);
            Console.WriteLine("****************************");

            var data4 = po.Where(x => x.PizzaSize == 'M'||x.PizzaSize=='m').Select(x=> new {Ptype=x.PizzaType,top=x.Topping });
            foreach (var h in data4)
                Console.WriteLine(h.Ptype + " " + h.top);
            Console.WriteLine("****************************");

            var maxprice = po.Where(x => x.price == po.Max(y => y.price));
            foreach (var r in maxprice)
                Console.WriteLine(r.OrderId + " " + r.OrderDate + " " + r.PizzaType + " " + r.PizzaSize + " " + r.Topping + " " + r.Qty + " " + r.price);
            Console.WriteLine("****************************");
            var minprice = po.Where(x => x.price == po.Min(y => y.price));
            foreach (var r in minprice)
                Console.WriteLine(r.OrderId + " " + r.OrderDate + " " + r.PizzaType + " " + r.PizzaSize + " " + r.Topping + " " + r.Qty + " " + r.price);
        }
    }
}
