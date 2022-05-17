using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingRegister = new Dictionary<string, string>();//създаване на речник където ще си пазим данните

            int n = int.Parse(Console.ReadLine());//брой команди които ще получаваме

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split().ToArray();

                string cmdType = cmdArgs[0];//на нулева позиция стоия типът на командата
                string username = cmdArgs[1];//на първа позиция стои user

                if (cmdType == "register")
                {
                    string licensePlateNumber = cmdArgs[2];//ако типът на командата е "регистрация", на втора позиция ще стои лицензният номер на user
                    RegisterUser(parkingRegister, username, licensePlateNumber);
                }
                else if (cmdType=="unregister")
                {
                    UnRegisterUser(parkingRegister, username);
                }
            }
            foreach (var item in parkingRegister)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
        static void RegisterUser(Dictionary<string, string> parkingRegister, string username, string lincensePlateNumber)//създаваме медот в който ще рагистрираме даден user
        {
            if (parkingRegister.ContainsKey(username))//проверяваме дали usera вече съществува
            {
                string lincenseRegisterNumber = parkingRegister[username];//взема стойноста на User когато вече съществува и печатим че user съществува
                Console.WriteLine($"ERROR: already registered with plate number {lincenseRegisterNumber}");
            }
            else//проверяваме ако не се съдържа трябва да го регистрираме
            {
                parkingRegister.Add(username, lincensePlateNumber);
                Console.WriteLine($"{ username} registered { lincensePlateNumber} successfully");
            }
        }
        static void UnRegisterUser(Dictionary<string, string> parkingRegister, string username)//създаваме медот за премахване на регистрацив на даден Use
        {
            if (!parkingRegister.ContainsKey(username))//ако не го съдържа, тогава казваме че такъв user не е намерен 
            {
                Console.WriteLine($"ERROR: user {username} not found");
            }
            else
            {
                parkingRegister.Remove(username);//ако се съдържа в речника, го премахваме от там и го дерекистрираме
                Console.WriteLine($"{username} unregistered successfully");
            }
        
        }
    }
}
