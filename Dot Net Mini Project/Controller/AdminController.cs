using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dot_Net_Mini_Project.Controller
{
    class AdminController
    {
        private const string SecurityKey = "ComplexKeyHere_12121";

        public static void FetchUsers()
        {

            MyDbContext myDbContext = new MyDbContext();
            User user = new User();
            Console.WriteLine("UserId  |     UserName   | Email | Password | Category | Role");
            //Console.WriteLine("|{0,5}|{1,5}|{2,5}|{3,5}|", "UserId", "UserName", "Email", "Password", "Category", "Role");
            foreach (var item in myDbContext.users)
            {
                Console.WriteLine(item.UserId + "|     " + item.UserName + "|" + item.Email + "|" + item.Password + "|" + item.Category + "|" + item.Role);
            }
        }

        public static void AddUser()
        {
            MyDbContext myDbContext = new MyDbContext();
            User user = new User();

            validateName();
            void validateName()
            {
                Console.WriteLine("Please Enter the FirstName");
                user.UserName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(user.UserName) || user.UserName.All(char.IsDigit))
                {
                    Console.WriteLine("Please enter valid name");
                    validateName();
                }
            }

            //    Console.Write("Please Enter the userName: ");
            //user.UserName = Console.ReadLine();
            


            //Console.Write("Please Enter the email: ");
            //user.Email = Console.ReadLine();
            validateEmail();
            void validateEmail()
            {
                Console.WriteLine("Please Enter the Email Id");
                user.Email = Console.ReadLine();

                string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

                if (!Regex.IsMatch(user.Email, pattern))
                {
                    Console.WriteLine("Please enter a valid Email Id.");
                    validateEmail();
                }
            }

            validatePassword();
            void validatePassword()
            {
                string password = "";
                Console.WriteLine("Please Enter the Password");
                Console.ForegroundColor = ConsoleColor.Black;
                user.Password = EncryptPlainTextToCipherText(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;

                if (string.IsNullOrWhiteSpace(user.Password) || user.Password.Length < 8)
                {
                    Console.WriteLine("\n Please enter password with length.");
                    validatePassword();
                }
            }





            //    Console.Write("Please Enter the Password: ");
            ////Console.ForegroundColor = ConsoleColor.Black;
            //user.Password = EncryptPlainTextToCipherText(Console.ReadLine());
            //Console.ForegroundColor = ConsoleColor.White;

            validateCategory();
            void validateCategory()
            {
                Console.WriteLine("Please Enter the Category");
                user.Category = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(user.Category) || user.Category.All(char.IsDigit))
                {
                    Console.WriteLine("Please enter valid Category Name");
                    validateCategory();
                }
            }

            //Console.Write("Please Enter the category: ");
            //user.Category = Console.ReadLine();

            validateRole();
            void validateRole()
            {
                Console.WriteLine("Please Enter the Role");
                user.Role = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(user.Role) || user.Role.All(char.IsDigit))
                {
                    Console.WriteLine("Please enter valid Role Name");
                    validateRole();
                }
            }
            //Console.Write("Please Enter Role: ");
            //user.Role = Console.ReadLine();

            myDbContext.users.Add(user);
            myDbContext.SaveChanges();

            Console.WriteLine("User added sucessfully");

        }

        public static void RemoveUser()
        {
            MyDbContext myDbContext = new MyDbContext();
            User user = new User();

            Console.Write("Enter userId: ");
            user.UserId = Convert.ToInt32(Console.ReadLine());

            var removeUserData = myDbContext.users.First(x => x.UserId == user.UserId);

            myDbContext.users.Remove(removeUserData);

            //Console.ForegroundColor = ConsoleColor.White;

            myDbContext.users.Remove(user);
            myDbContext.SaveChanges();

            Console.WriteLine("User removed sucessfully");

        }

        public static void AddProduct()
        {
            MyDbContext myDbContext = new MyDbContext();
            Airpod airpod = new Airpod();

            Console.Write("Please Enter the productName: ");
            airpod.AirpodName = Console.ReadLine();

            Console.Write("Please Enter the Quantity: ");
            //Console.ForegroundColor = ConsoleColor.Black;
            airpod.Quantity = Convert.ToInt32(Console.ReadLine());
            //Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Please Enter Price: ");
            airpod.Price = Convert.ToDecimal(Console.ReadLine());

            //Console.Write("Please Enter the UserId: ");
            //iphone.UserId = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Please Enter the category: ");
            //airpod.Category = Console.ReadLine();

            myDbContext.airpods.Add(airpod);
            myDbContext.SaveChanges();

            Console.WriteLine("Product added sucessfully");
        }

        public static void FetchIphoneData()
        {
            MyDbContext myDbContext = new MyDbContext();
            Console.WriteLine("ProductName | Quantity | Price");
            foreach (var item in myDbContext.iphones)
            {
                Console.WriteLine(item.IphoneName + "   " + item.Quantity + "      " + item.Price);
            }
        }

        public static void FetchIpadData()
        {
            MyDbContext myDbContext = new MyDbContext();
            Console.WriteLine("ProductName | Quantity | Price");
            foreach (var item in myDbContext.ipads)
            {
                Console.WriteLine(item.IpadName + "   " + item.Quantity + "      " + item.Price);
            }
        }

        public static void FetchAirpodData()
        {
            MyDbContext myDbContext = new MyDbContext();
            Console.WriteLine("ProductName | Quantity | Price");
            foreach (var item in myDbContext.airpods)
            {
                Console.WriteLine(item.AirpodName + "   " + item.Quantity + "      " + item.Price);
            }
        }

        public static void FetchIwatchData()
        {
            MyDbContext myDbContext = new MyDbContext();
            Console.WriteLine("ProductName | Quantity | Price");
            foreach (var item in myDbContext.iwatches)
            {
                Console.WriteLine(item.IwatchName + "   " + item.Quantity + "      " + item.Price);
            }
        }

        public static void UpdateProduct()
        {
            Console.WriteLine("Enter Product ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Updated Price: ");
            int priceUpdated = Convert.ToInt32(Console.ReadLine());

            MyDbContext myDbContext = new MyDbContext();

            Iphone iphone = myDbContext.iphones.Find(id);
            iphone.Price = priceUpdated;
            myDbContext.iphones.Update(iphone);

            Console.WriteLine(myDbContext.SaveChanges());

            Console.WriteLine("Product updated sucessfully");
        }

        public static void RemoveProduct()
        {
            MyDbContext myDbContext = new MyDbContext();
            Iphone iphone = new Iphone();
            Console.Write("Enter ProductName: ");
            iphone.IphoneName = Console.ReadLine();

            //Console.Write("Please Enter the UserId: ");
            //iphone.UserId = Convert.ToInt32(Console.ReadLine());


            var removeProductData = myDbContext.iphones.First(x => x.IphoneName == iphone.IphoneName);

            myDbContext.iphones.Remove(removeProductData);

            //Console.ForegroundColor = ConsoleColor.White;

            myDbContext.iphones.Remove(removeProductData);
            myDbContext.SaveChanges();

            Console.WriteLine("product removed sucessfully");

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

        //This method is used to convert the Encrypted/Un-Readable Text back to readable  format.
        public static string DecryptCipherTextToPlainText(string CipherText)
        {
            byte[] toEncryptArray = Convert.FromBase64String(CipherText);
            MD5CryptoServiceProvider objMD5CryptoService = new MD5CryptoServiceProvider();

            //Gettting the bytes from the Security Key and Passing it to compute the Corresponding Hash Value.
            byte[] securityKeyArray = objMD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(SecurityKey));
            objMD5CryptoService.Clear();

            var objTripleDESCryptoService = new TripleDESCryptoServiceProvider();
            //Assigning the Security key to the TripleDES Service Provider.
            objTripleDESCryptoService.Key = securityKeyArray;
            //Mode of the Crypto service is Electronic Code Book.
            objTripleDESCryptoService.Mode = CipherMode.ECB;
            //Padding Mode is PKCS7 if there is any extra byte is added.
            objTripleDESCryptoService.Padding = PaddingMode.PKCS7;

            var objCrytpoTransform = objTripleDESCryptoService.CreateDecryptor();
            //Transform the bytes array to resultArray
            byte[] resultArray = objCrytpoTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            objTripleDESCryptoService.Clear();

            //Convert and return the decrypted data/byte into string format.
            return UTF8Encoding.UTF8.GetString(resultArray);
        }
        //internal static string DecryptCipherTextToPlainText(string password)
        //{
        //    throw new NotImplementedException();
        //}


    }

    
}
