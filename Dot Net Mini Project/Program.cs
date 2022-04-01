using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;
using System.Linq;
using Dot_Net_Mini_Project.Controller;


namespace Dot_Net_Mini_Project
{
    class Program
    {

        static void Main(string[] args)
        {
            MyDbContext myDbContext = new MyDbContext();
            bool flag = true;
            //User user = new User();
            //Iphone iphone = new Iphone();
            //Ipad ipad = new Ipad();
            //Iwatch iwatch = new Iwatch();


            //do
            while (flag)
            {


                Console.Title = "IMS";
                //Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Cyan;
                string title = @"

  ___                 _                  __  __                                       _     ___         _             
 |_ _|_ ___ _____ _ _| |_ ___ _ _ _  _  |  \/  |__ _ _ _  __ _ __ _ ___ _ __  ___ _ _| |_  / __|_  _ __| |_ ___ _ __  
  | || ' \ V / -_) ' \  _/ _ \ '_| || | | |\/| / _` | ' \/ _` / _` / -_) '  \/ -_) ' \  _| \__ \ || (_-<  _/ -_) '  \ 
 |___|_||_\_/\___|_||_\__\___/_|  \_, | |_|  |_\__,_|_||_\__,_\__, \___|_|_|_\___|_||_\__| |___/\_, /__/\__\___|_|_|_|
                                  |__/                        |___/                             |__/                  

";


                Console.WriteLine(title , Console.BackgroundColor);

                Console.ResetColor();




                //Console.WriteLine("Welcome To Inventory Management System");

                var ctx = new MyDbContext();
                //Controller myController = new Controller();
                //User user = new User() { UserName = "vishal", Email = "vishalmil@cyb.com", Password = "1234", Category = "Products", Role = "Admin" };
                //ctx.users.Add(user);
                //Console.WriteLine(ctx.SaveChanges());

                Console.WriteLine("Enter Choice: ");
                Console.WriteLine("\n     1:Admin      2:User      3:Exit");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

                Console.Write("Enter your choice : ");
                var choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");


                switch (choice)
                {
                    case 1:

                        if (choice == 1)
                        {
                            LoginController.AdminLogin();

                            bool flag1 = true;
                            //do
                            while (flag1)
                            {
                                Console.WriteLine("\n1:Fetch User     2:Add User      3:Remove User\n\n4:Fetch Product Data         5:Add Product       6:Update Product Data       7: Remove Product \n\n8:Exit");
                                //Console.WriteLine("--------------------------------------------------------------------------");
                                //Console.WriteLine("Enter your Choice from 1 to 8");
                                //Console.WriteLine("--------------------------------------------------------------------------");
                                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                                Console.Write("Enter your choice : ");
                                var choices = Convert.ToInt32(Console.ReadLine());
                              
                                switch (choices)
                                {
                                    case 1:
                                        Console.WriteLine();
                                        Console.WriteLine("Result-");
                                        AdminController.FetchUsers();
                                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                                        break;
                                    case 2:
                                        Console.WriteLine();
                                        AdminController.AddUser();
                                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                                        break;
                                    case 3:
                                        Console.WriteLine();
                                        AdminController.RemoveUser();
                                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                                        break;
                                    case 4:
                                        bool flag3 = true;
                                        while (flag3)
                                        {
                                            Console.WriteLine("Fetch By Category\n1:Mobile\n2Tablet\n3Airpod\n4Iwatch\n5Exit");

                                            var choices3 = Convert.ToInt32(Console.ReadLine());

                                            switch (choices3)
                                            {
                                                case 1:
                                                    //AdminController.FetchIphoneData();
                                                    break;

                                                case 2:
                                                    //AdminController.FetchIpadData();
                                                    break;
                                                case 3:
                                                    //AdminController.FetchAirpodData();
                                                    break;
                                                case 4:
                                                    //AdminController.FetchIwatchData();
                                                    break;
                                                case 5:
                                                    flag3 = false;
                                                    Console.WriteLine("Exited Sucessfully!");
                                                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                                                    break;
                                                   
                                            }
                                        }
                                        break;
                                    case 5:
                                        bool flag4 = true;

                                        while (flag4)
                                        {
                                            Console.WriteLine("Add By Category\n1:Mobile\n2Tablet\n3Airpod\n4Iwatch\n5Exit");
                                            var choice4 = Convert.ToInt32(Console.ReadLine());

                                            switch (choice4)
                                            {
                                                case 1:
                                                    //AdminController.AddProduct
                                                    break;
                                                case 2:
                                                    //AdminController.;
                                                    break;
                                                case 3:
                                                    //AdminController.;
                                                    break;
                                                case 4:
                                                    //AdminController.;
                                                    break;
                                                case 5:
                                                    flag4 = false;
                                                    Console.WriteLine("Exited Sucessfully!");
                                                    break;
                                                default:
                                                    break;
                                            }
                                        }
                                        break;
                                    case 6:
                                        bool flag5 = true;

                                        while (flag5)
                                        {
                                            Console.WriteLine("Update By Category\n1:Mobile\n2Tablet\n3Airpod\n4Iwatch\n5Exit");
                                            var choice5 = Convert.ToInt32(Console.ReadLine());

                                            switch (choice5)
                                            {
                                                case 1:
                                                    //AdminController.UpdateProduct();
                                                    break;
                                                case 2:
                                                    //AdminController.;
                                                    break;
                                                case 3:
                                                    //AdminController.;
                                                    break;
                                                case 4:
                                                    //AdminController.;
                                                    break;
                                                case 5:
                                                    flag4 = false;
                                                    Console.WriteLine("Exited Sucessfully!");
                                                    break;
                                                default:
                                                    break;
                                            }
                                        }
                                        break;
                                    case 7:
                                        bool flag6 = true;

                                        while (flag6)
                                        {
                                            Console.WriteLine("Remove By Category\n1:Mobile\n2Tablet\n3Airpod\n4Iwatch\n5Exit");
                                            var choice6 = Convert.ToInt32(Console.ReadLine());

                                            switch (choice6)
                                            {
                                                case 1:
                                                    //AdminController.RemoveProduct();
                                                    break;
                                                case 2:
                                                    //AdminController.;
                                                    break;
                                                case 3:
                                                    //AdminController.;
                                                    break;
                                                case 4:
                                                    //AdminController.;
                                                    break;
                                                case 5:
                                                    flag4 = false;
                                                    Console.WriteLine("Exited Sucessfully!");
                                                    break;
                                                default:
                                                    break;
                                            }
                                        }

                                        break;
                                    case 8:
                                        flag1 = false;
                                        Console.WriteLine("Exited Sucessfully!");
                                        break;
                                    default:

                                        break;
                                }
                            } //while (flag1);

                        }


                        else Console.WriteLine("Please give right options");


                        break;
                    case 2:
                        if (choice == 2)

                            LoginController.UserLogin();

                    //do
                    //            bool flag2 = true;
                    //            while (flag2)
                    //            {

                    //                Console.WriteLine("1:Fetch Product\n2:Add Product\n3:Update Product\n4:Remove Product\n5:Exit");
                    //                var choice2 = Convert.ToInt32(Console.ReadLine());


                    //                switch (choice2)
                    //                {
                    //                    case 1:
                    //                        //MyDbContext myDbContext1 = new MyDbContext();

                    //                        //Console.WriteLine("Enter your id: ");
                    //                        //var uId = Convert.ToInt32(Console.ReadLine());

                    //                        //Console.WriteLine("Enter your category: ");
                    //                        //var uCategory = Console.ReadLine();
                    //                        //myDbContext.users(uid)
                    //                        //if (user.UserId.Equals(uId) && iphone.Category.Equals(uCategory))
                    //                        // {
                    //                        //     IphoneController.FetchProductData();
                    //                        //}else if(user.UserId.Equals(uId) && ipad.Category.Equals(uCategory))
                    //                        //{
                    //                        //  IpadController.FetchProductData();
                    //                        //}
                    //                        //else
                    //                        //{
                    //                        //   Console.WriteLine("Invalid");
                    //                        //}


                    //                        break;
                    //                    case 2:
                    //                        AirpodController.AddProduct();
                    //                        break;
                    //                    case 3:
                    //                        //AdminController.UpdateProduct();
                    //                        break;
                    //                    case 4:
                    //                        //IphoneController.RemoveProduct();
                    //                        break;
                    //                    case 5:
                    //                        flag2 = false;
                    //                        Console.WriteLine("Exited Successfully...");
                    //                        break;
                    //                    default:
                    //                        flag2 = false;
                    //                        break;
                    //                }
                    //            } //while (flag2);
                               break;
                    case 3:
                        flag = false;
                        Console.WriteLine("Exited Successfully...");
                        break;
                    default:
                        flag = false;
                        break;
                }
            } //while (flag);
        }
    }
}