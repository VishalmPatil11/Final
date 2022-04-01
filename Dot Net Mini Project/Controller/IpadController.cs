using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Mini_Project.Controller
{
    class IpadController
    {
        public static void FetchIpadData(MyDbContext myDbContext, User user)
        {

            Console.WriteLine(user.UserName + "        " + user.Category);
            MyDbContext myDbContext1 = new MyDbContext();
            Ipad ipad = new Ipad();
            Console.WriteLine("IpadId | IpadName | Quantity | Price");
            foreach (var item in myDbContext1.ipads)
            {
                Console.WriteLine(item.IpadId +"   "+item.IpadName + "   " + item.Quantity + "      " + item.Price);
            }
        }
        //Ipad data added by User
        public static void AddIpadData(MyDbContext myDbContext, User user)
        {
            Ipad ipad = new Ipad();

            Console.Write("Please Enter the IpadName: ");
            ipad.IpadName = Console.ReadLine();

            Console.Write("Please Enter the Quantity: ");
            //Console.ForegroundColor = ConsoleColor.Black;
            ipad.Quantity = Convert.ToInt32(Console.ReadLine());
            //Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Please Enter Price: ");
            ipad.Price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("please enter the userId: ");
            ipad.UserId = Convert.ToInt32(Console.ReadLine());

            myDbContext.ipads.Add(ipad);
            myDbContext.SaveChanges();

            Console.WriteLine("Product added sucessfully");
        }

        public static void UpdateIpadData(MyDbContext myDbContext, User user)
        {
            Console.WriteLine("Enter IpadId: ");
            var id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Updated Price: ");
            var priceUpdated = Convert.ToDecimal(Console.ReadLine());

            Ipad ipad = myDbContext.ipads.Find(id);
            ipad.Price = priceUpdated;
            myDbContext.ipads.Update(ipad);

            Console.WriteLine(myDbContext.SaveChanges());

            Console.WriteLine("Product updated sucessfully");
        }

        public static void RemoveIpadData(MyDbContext myDbContext, User user)
        {
            Ipad ipad = new Ipad();

            Console.Write("Enter IpadId: ");
            ipad.IpadId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter the UserId: ");
            ipad.UserId = Convert.ToInt32(Console.ReadLine());


            var removeProductData = myDbContext.ipads.First(x => x.IpadId == ipad.IpadId);

            myDbContext.ipads.Remove(removeProductData);

            //Console.ForegroundColor = ConsoleColor.White;


            myDbContext.SaveChanges();

            Console.WriteLine("product removed sucessfully");

        }
        //public static void AddProduct()
        //{
        //    MyDbContext myDbContext = new MyDbContext();
        //    Ipad ipad = new Ipad();

        //    Console.Write("Please Enter the productName: ");
        //    ipad.ProductName = Console.ReadLine();

        //    Console.Write("Please Enter the Quantity: ");
        //    //Console.ForegroundColor = ConsoleColor.Black;
        //    ipad.Quantity = Convert.ToInt32(Console.ReadLine());
        //    //Console.ForegroundColor = ConsoleColor.White;

        //    Console.Write("Please Enter Price: ");
        //    ipad.Price = Convert.ToDecimal(Console.ReadLine());

        //    Console.Write("Please Enter the UserId: ");
        //    ipad.UserId = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("Please Enter the category: ");
        //    ipad.Category = Console.ReadLine();

        //    myDbContext.ipads.Add(ipad);
        //    myDbContext.SaveChanges();

        //    Console.WriteLine("Product added sucessfully");
        //}

        //public static void FetchProductData()
        //{
        //    MyDbContext myDbContext = new MyDbContext();
        //    Ipad ipad = new Ipad();
        //    Console.WriteLine("ProductName | Quantity | Price");
        //    foreach (var item in myDbContext.ipads)
        //    {
        //        Console.WriteLine(item.ProductName + "   " + item.Quantity + "      " + item.Price);
        //    }
        //}

        //public static void UpdateProduct()
        //{
        //    Console.WriteLine("Enter Product ID: ");
        //    int id = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Updated Price: ");
        //    int priceUpdated = Convert.ToInt32(Console.ReadLine());

        //    MyDbContext myDbContext = new MyDbContext();

        //    Ipad ipad = myDbContext.ipads.Find(id);
        //    ipad.Price = priceUpdated;
        //    myDbContext.ipads.Update(ipad);

        //    Console.WriteLine(myDbContext.SaveChanges());

        //    Console.WriteLine("Product updated sucessfully");
        //}

        //public static void RemoveProduct()
        //{
        //    MyDbContext myDbContext = new MyDbContext();
        //    Ipad ipad = new Ipad();
        //    Console.Write("Enter ProductName: ");
        //    ipad.ProductName = Console.ReadLine();

        //    Console.Write("Please Enter the UserId: ");
        //    ipad.UserId = Convert.ToInt32(Console.ReadLine());


        //    var removeProductData = myDbContext.ipads.First(x => x.ProductName == ipad.ProductName);

        //    myDbContext.ipads.Remove(removeProductData);

        //    //Console.ForegroundColor = ConsoleColor.White;

        //    myDbContext.ipads.Remove(removeProductData);
        //    myDbContext.SaveChanges();

        //    Console.WriteLine("product removed sucessfully");

        //}
    }
}
