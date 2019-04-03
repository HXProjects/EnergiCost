using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCost
{
    class Program
    {
       
        
        static void Main(string[] args)
        {
            const int ARRAY_SIZE = 12;            
            Client[] clientsData = new Client[ARRAY_SIZE];//create an array of objects of clients

            CreateClient(clientsData);
            PrintData(clientsData);
            SortByEnergi(clientsData);
            
            PrintData(clientsData);
            SortByPlan(clientsData);
            PrintData(clientsData);


            Console.Read();
        }
        public static void CreateClient(Client [] arr)
        {   int clientNumber = 0;
            Common client1 = new Common();
            client1.Name = "Andersson";
            client1.EnergiAmount = 78;
            arr[clientNumber] = client1;
            clientNumber++;


            Common client2 = new Common();
            client2.Name = "Karlsson";
            client2.EnergiAmount = 90;
            arr[clientNumber] = client2;
            clientNumber++;

            Common client3 = new Common();
            client3.Name = "Nilsson";
            client3.EnergiAmount = 300;
            arr[clientNumber] = client3;
            clientNumber++;

            Limited client4 = new Limited();
            client4.Name = "Johansson";
            client4.EnergiAmount = 249;
            arr[clientNumber] = client4;
            clientNumber++;

            Limited client5 = new Limited();
            client5.Name = "Ekholm";
            client5.EnergiAmount = 270;
            arr[clientNumber] = client5;
            clientNumber++;

            Limited client6 = new Limited();
            client6.Name = "Hedin";
            client6.EnergiAmount = 290;
            arr[clientNumber] = client6;
            clientNumber++;

            Priviliged client7 = new Priviliged();
            client7.Name = "Gustafsson";
            client7.EnergiAmount = 150;
            arr[clientNumber] = client7;
            clientNumber++;

            Priviliged client8 = new Priviliged();
            client8.Name = "Holm";
            client8.EnergiAmount = 160;
            arr[clientNumber] = client8;
            clientNumber++;

            Priviliged client9 = new Priviliged();
            client9.Name = "Ulfsson";
            client9.EnergiAmount = 75;
            arr[clientNumber] = client9;
            clientNumber++;

            HeatingPurposed client10 = new HeatingPurposed();
            client10.Name = "Ulfsson";
            client10.EnergiAmount = 75;
            arr[clientNumber] = client10;
            clientNumber++;

            HeatingPurposed client11 = new HeatingPurposed();
            client11.Name = "Stenberg";
            client11.EnergiAmount = 90;
            arr[clientNumber] = client11;
            clientNumber++;

            HeatingPurposed client12 = new HeatingPurposed();
            client12.Name = "Jansson";
            client12.EnergiAmount = 250;
            arr[clientNumber] = client12;
            clientNumber++;
        }
        public static void PrintData(Client[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                
                Console.Write(i + 1);
                Console.WriteLine(arr[i].ToString());

            }
        }
            
        public static void SortByEnergi(Client[] arr)
        {
            Console.WriteLine("Sorted by Energi");
            Array.Sort(arr);
            Array.Reverse(arr);
        }

    public static  void SortByPlan(Client[] arr)
        {
            Console.WriteLine("Sorted by Plan");
            Array.Sort(arr, new ClientComparer());
        }

    }
}
