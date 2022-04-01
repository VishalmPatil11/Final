using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Dot_Net_Mini_Project;

namespace Dot_Net_Mini_Project.Controller
{
    class LoginController
    {
        private const string SecurityKey = "ComplexKeyHere_12121";
        public static void UserLogin()
        {
            //MyDbContext myDbContext = new MyDbContext();
            //Console.Write("Enter userName: ");
            //var userName = Console.ReadLine().ToLower();


            //Console.Write("Enter password: ");
            //var password = Console.ReadLine().ToLower();

            //Console.Write("Enter Role: ");
            //var role = Console.ReadLine();

            //bool isFound = false;
            //User user1 = null;
            ////User user1 = new User();

            //foreach (User user in myDbContext.users)
            //{
            //    if (user.UserName == userName && user.Password == password && user.Role == role)
            //    {
            //        user1 = user;
            //        isFound = true;
            //        Console.WriteLine("Login successful");
            //    }

            //}

            //if (isFound == false)
            //{
            //    Console.WriteLine("Invalid credentials");
            //}
            //if (user1 != null)
            //{

            //    if (user1.Role == "User")
            //    {
            //        AirpodController.FetchAirpodData(myDbContext, user1);
            //    }

            //}
            MyDbContext myDbContext = new MyDbContext();
            //User user2 = new User();
            //validateUserName();
            //void validateUserName()
            //{

                Console.Write("\nEnter userName: ");
                var userName = Console.ReadLine().ToLower();

            //    if (string.IsNullOrWhiteSpace(user1.UserName) || user1.UserName.All(char.IsDigit))
            //    {
            //        Console.WriteLine("Please enter valid name");
            //        validateUserName();
            //    }
            //}



            Console.Write("Enter password: ");
            var password = Console.ReadLine().ToLower();

            Console.Write("Enter category: ");
            var category = Console.ReadLine();

            Console.Write("Enter Role: ");
            var role = Console.ReadLine();
            // var users = myDbContext.users.ToList();

            bool isfound = false;
            User user1 = null;
            foreach (User user in myDbContext.users)
            {
                //  if (user.Username == username && user.Password == password && user.Role == role)
                if (user.UserName == userName && AdminController.DecryptCipherTextToPlainText(user.Password) == password && user.Category == category)
                {
                    //Console.WriteLine(user.UserName + " " + user.Role + " " + user.Password + " " + user.Category);
                    isfound = true;
                    user1 = user;
                    Console.WriteLine("login succesfully");
                    Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------------");
                    //Console.WriteLine("Hello 1");
                    //Console.WriteLine(user1.UserName + " " + user1.Role + " " + user1.Password + " " + user.Category);
                    break;
                }

            }
            if (isfound == false)
            {
                Console.WriteLine("Incorrect Credentials....");
            }
           // Console.WriteLine("Hello 2");
            if (user1 != null)
            {
                //Console.WriteLine("Hello 3");
                //Console.WriteLine(user1.UserName + " " + user1.Role + " " + user1.Password + " " + user1.Category);
                if (user1.Role == "User")
                {
                    //Console.WriteLine("Hello 4");
                   // Console.WriteLine(user1.UserName + " " + user1.Role + " " + user1.Password + " " + user1.Category);

                    //if(user1.Category == "Airpod")
                    //{
                    //    AirpodController.FetchAirpodData(myDbContext, user1);
                    //}else if(user1.Category == "Iphone")

                    //AirpodController.FetchAirpodData(myDbContext, user1);
                    bool flag2 = true;
                    while (flag2)
                    {

                        Console.WriteLine("\n1:Fetch Product        2:Add Product       3:Update Product        4:Remove Product\n5:Exit");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

                        Console.Write("Enter your choice : ");
                        var choice2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                        switch (choice2)
                        {
                            case 1:

                                if (user1.Category == "Airpod")
                                {
                                    AirpodController.FetchAirpodData(myDbContext, user1);
                                }
                                else if (user1.Category == "Mobile")
                                {
                                    IphoneController.FetchIphoneData(myDbContext, user1);
                                }
                                else if (user1.Category == "Tablet")
                                {
                                    IpadController.FetchIpadData(myDbContext, user1);
                                }
                                else if (user1.Category == "Watch")
                                {
                                    IwatchController.FetchIwatchData(myDbContext, user1);
                                }
                                else
                                {
                                    Console.WriteLine("Please enter valid category!");
                                }

                                break;
                            case 2:

                                if (user1.Category == "Airpod")
                                {
                                    AirpodController.AddAirpodData(myDbContext, user1);
                                }
                                else if (user1.Category == "Mobile")
                                {
                                    IphoneController.AddIphoneData(myDbContext, user1);
                                }
                                else if (user1.Category == "Tablet")
                                {
                                    IpadController.AddIpadData(myDbContext, user1);
                                }
                                else if (user1.Category == "Watch")
                                {
                                    IwatchController.AddIwatchData(myDbContext, user1);
                                }
                                else
                                {
                                    Console.WriteLine("Please enter valid category!");
                                }
                                break;
                            case 3:
                                if (user1.Category == "Airpod")
                                {
                                    AirpodController.FetchAirpodData(myDbContext, user1);
                                    AirpodController.UpdateAirpodData(myDbContext, user1);
                                }
                                else if (user1.Category == "Mobile")
                                {
                                    IphoneController.FetchIphoneData(myDbContext, user1);
                                    IphoneController.UpdateIphoneData(myDbContext, user1);
                                }
                                else if (user1.Category == "Tablet")
                                {
                                    IpadController.FetchIpadData(myDbContext, user1);
                                    IpadController.UpdateIpadData(myDbContext, user1);
                                }
                                else if (user1.Category == "Watch")
                                {
                                    IwatchController.FetchIwatchData(myDbContext, user1);
                                    IwatchController.UpdateIwatchData(myDbContext, user1);
                                }
                                else
                                {
                                    Console.WriteLine("Please enter valid category!");
                                }
                                break;
                            case 4:
                                if (user1.Category == "Airpod")
                                {
                                    AirpodController.FetchAirpodData(myDbContext, user1);
                                    AirpodController.RemoveAirpodData(myDbContext, user1);
                                }
                                else if (user1.Category == "Mobile")
                                {
                                    IphoneController.FetchIphoneData(myDbContext, user1);
                                    IphoneController.RemoveIphoneData(myDbContext, user1);
                                }
                                else if (user1.Category == "Tablet")
                                {
                                    IpadController.FetchIpadData(myDbContext, user1);
                                    IpadController.RemoveIpadData(myDbContext, user1);
                                }
                                else if (user1.Category == "Watch")
                                {
                                    IwatchController.FetchIwatchData(myDbContext, user1);
                                    IwatchController.RemoveIwatchData(myDbContext, user1);
                                }
                                else
                                {
                                    Console.WriteLine("Please enter valid category!");
                                }
                                break;
                            case 5:
                                flag2 = false;
                                Console.WriteLine("Exited Successfully...");
                                break;
                            default:
                                flag2 = false;
                                break;
                        }
                    } //while (flag2);


                }
            } //while (flag);
            //Console.WriteLine("Hello 5");
        }
       
        public static void AdminLogin()
        {
            MyDbContext myDbContext = new MyDbContext();
            Console.Write("Enter userName: ");
            var userName = Console.ReadLine().ToLower();


            Console.Write("Enter password: ");
            var password = Console.ReadLine().ToLower();

            bool isFound = false;

            foreach (User user in myDbContext.users)
            {
                if (user.UserName == userName && user.Password == password)
                {
                    isFound = true;
                    Console.WriteLine("Login successful");
                }

            }

            if (isFound == false)
            {
                Console.WriteLine("Invalid credentials");
            }
        }

        public static string EncryptPlainTextToCipherText(string PlainText)
        {
            // Getting the bytes of Input String.
            byte[] toEncryptedArray = UTF8Encoding.UTF8.GetBytes(PlainText);

            MD5CryptoServiceProvider objMD5CryptoService = new MD5CryptoServiceProvider();
            //Gettting the bytes from the Security Key and Passing it to compute the Corresponding Hash Value.
            byte[] securityKeyArray = objMD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(SecurityKey));
            //De-allocatinng the memory after doing the Job.
            objMD5CryptoService.Clear();

            var objTripleDESCryptoService = new TripleDESCryptoServiceProvider();
            //Assigning the Security key to the TripleDES Service Provider.
            objTripleDESCryptoService.Key = securityKeyArray;
            //Mode of the Crypto service is Electronic Code Book.
            objTripleDESCryptoService.Mode = CipherMode.ECB;
            //Padding Mode is PKCS7 if there is any extra byte is added.
            objTripleDESCryptoService.Padding = PaddingMode.PKCS7;


            var objCrytpoTransform = objTripleDESCryptoService.CreateEncryptor();
            //Transform the bytes array to resultArray
            byte[] resultArray = objCrytpoTransform.TransformFinalBlock(toEncryptedArray, 0, toEncryptedArray.Length);
            objTripleDESCryptoService.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

    }
}
