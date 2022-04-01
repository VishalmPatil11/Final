using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Mini_Project.Controller
{
    class IphoneController
    {
        public static void FetchIphoneData(MyDbContext myDbContext, User user)
        {

            Console.WriteLine(user.UserName + "        " + user.Category);
            MyDbContext myDbContext1 = new MyDbContext();
            Iphone iphone = new Iphone();
            Console.WriteLine("IphoneId | IphoneName | Quantity | Price");
            foreach (var item in myDbContext1.iphones)
            {
                Console.WriteLine(item.IphoneId + "   "+item.IphoneName + "   " + item.Quantity + "      " + item.Price);
            }
        }

        //Iphone data added by User
        public static void AddIphoneData(MyDbContext myDbContext, User user)
        {
            Iphone iphone = new Iphone();

            Console.Write("Please Enter the IphoneName: ");
            iphone.IphoneName = Console.ReadLine();

            Console.Write("Please Enter the Quantity: ");
            //Console.ForegroundColor = ConsoleColor.Black;
            iphone.Quantity = Convert.ToInt32(Console.ReadLine());
            //Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Please Enter Price: ");
            iphone.Price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("please enter the userId: ");
            iphone.UserId = Convert.ToInt32(Console.ReadLine());

            myDbContext.iphones.Add(iphone);
            myDbContext.SaveChanges();

            Console.WriteLine("Product added sucessfully");
        }

        public static void UpdateIphoneData(MyDbContext myDbContext, User user)
        {
            Console.WriteLine("Enter IphoneId: ");
            var id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Updated Price: ");
            var priceUpdated = Convert.ToDecimal(Console.ReadLine());

            Iphone iphone = myDbContext.iphones.Find(id);
            iphone.Price = priceUpdated;
            myDbContext.iphones.Update(iphone);

            Console.WriteLine(myDbContext.SaveChanges());

            Console.WriteLine("Product updated sucessfully");
        }

        public static void RemoveIphoneData(MyDbContext myDbContext, User user)
        {
            Iphone iphone = new Iphone();

            Console.Write("Enter IphoneId: ");
            iphone.IphoneId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter the UserId: ");
            iphone.UserId = Convert.ToInt32(Console.ReadLine());


            var removeProductData = myDbContext.iphones.First(x => x.IphoneId == iphone.IphoneId);

            myDbContext.iphones.Remove(removeProductData);

            //Console.ForegroundColor = ConsoleColor.White;


            myDbContext.SaveChanges();

            Console.WriteLine("product removed sucessfully");

        }
        //public static void AddProduct()
        //{
        //    MyDbContext myDbContext = new MyDbContext();
        //    Iphone iphone = new Iphone();

        //    Console.Write("Please Enter the productName: ");
        //    iphone.ProductName = Console.ReadLine();

        //    Console.Write("Please Enter the Quantity: ");
        //    //Console.ForegroundColor = ConsoleColor.Black;
        //    iphone.Quantity = Convert.ToInt32(Console.ReadLine());
        //    //Console.ForegroundColor = ConsoleColor.White;

        //    Console.Write("Please Enter Price: ");
        //    iphone.Price = Convert.ToDecimal(Console.ReadLine());

        //    Console.Write("Please Enter the UserId: ");
        //    iphone.UserId = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("Please Enter the category: ");
        //    iphone.Category = Console.ReadLine();

        //    myDbContext.iphones.Add(iphone);
        //    myDbContext.SaveChanges();

        //    Console.WriteLine("Product added sucessfully");
        //}

        //public static void FetchProductData()
        //{
        //    MyDbContext myDbContext = new MyDbContext();
        //    //Iphone iphone = new Iphone();
        //    Console.WriteLine("ProductName | Quantity | Price");
        //    foreach (var item in myDbContext.iphones)
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

        //    Iphone iphone = myDbContext.iphones.Find(id);
        //    iphone.Price = priceUpdated;
        //    myDbContext.iphones.Update(iphone);

        //    Console.WriteLine(myDbContext.SaveChanges());

        //    Console.WriteLine("Product updated sucessfully");
        //}

        //public static void RemoveProduct()
        //{
        //    MyDbContext myDbContext = new MyDbContext();
        //    Iphone iphone = new Iphone();
        //    Console.Write("Enter ProductName: ");
        //    iphone.ProductName = Console.ReadLine();

        //    Console.Write("Please Enter the UserId: ");
        //    iphone.UserId = Convert.ToInt32(Console.ReadLine());


        //    var removeProductData = myDbContext.iphones.First(x => x.ProductName == iphone.ProductName);

        //    myDbContext.iphones.Remove(removeProductData);

        //    //Console.ForegroundColor = ConsoleColor.White;

        //    myDbContext.iphones.Remove(removeProductData);
        //    myDbContext.SaveChanges();

        //    Console.WriteLine("product removed sucessfully");

        //}
    }
}
