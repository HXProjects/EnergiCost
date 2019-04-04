using System;

namespace EnergyCost
{
    class Program
    {      
        
        static void Main(string[] args)
        {
           //create array for clients data
            const int ARRAY_SIZE = 12;            
            Client[] clientsData = new Client[ARRAY_SIZE];//create an array of objects of clients

            Console.WriteLine("Clients Data:");
            CreateClient(clientsData);            
            PrintData(clientsData);
            Console.WriteLine();

            SortByEnergi(clientsData);            
            PrintData(clientsData);
            Console.WriteLine();

            SortByCost(clientsData);
            PrintData(clientsData);
            Console.WriteLine();

            SortByPlan(clientsData);
            PrintData(clientsData);
            Console.WriteLine();

            Console.WriteLine("Paid (total): {0}", String.Format("{0:0.0000}",calculateSum(clientsData)));
            Console.WriteLine("Rebate size: {0}", String.Format("{0:0.0000}", GetLimitSizeSum(clientsData)));

            Console.Read();
        }
        /// <summary>
        /// method to fill data of clients in array "clientsData"
        /// </summary>
        /// <param name="arr"></param>
        private static void CreateClient(Client [] arr)
        {
            int clientNumber = 0;
            Common client1 = new Common();
            client1.Name = "Andersson";
            client1.EnergiAmount = 78;
            client1.ManualCostOfEnergy = GetManualCost(client1, client1.EnergiAmount);
            client1.CostOfEnergy = GetTheCost(client1, client1.EnergiAmount);
            arr[clientNumber] = client1;
            clientNumber++;

            Common client2 = new Common();
            client2.Name = "Karlsson";
            client2.EnergiAmount = 90;
            client2.ManualCostOfEnergy = GetManualCost(client2, client2.EnergiAmount);
            client2.CostOfEnergy = GetTheCost(client2, client2.EnergiAmount);
            arr[clientNumber] = client2;
            clientNumber++;

            Common client3 = new Common();
            client3.Name = "Nilsson";
            client3.EnergiAmount = 300;
            client3.ManualCostOfEnergy = GetManualCost(client3, client3.EnergiAmount);
            client3.CostOfEnergy = GetTheCost(client3, client3.EnergiAmount);
            arr[clientNumber] = client3;
            clientNumber++;

            Limited client4 = new Limited();
            client4.Name = "Johansson";
            client4.EnergiAmount = 249;
            client4.ManualCostOfEnergy = GetManualCost(client4, client4.EnergiAmount);
            client4.CostOfEnergy = GetTheCost(client4, client4.EnergiAmount);
            arr[clientNumber] = client4;
            clientNumber++;

            Limited client5 = new Limited();
            client5.Name = "Ekholm";
            client5.EnergiAmount = 270;
            client5.ManualCostOfEnergy = GetManualCost(client5, client5.EnergiAmount);
            client5.CostOfEnergy = GetTheCost(client5, client5.EnergiAmount);
            arr[clientNumber] = client5;
            clientNumber++;

            Limited client6 = new Limited();
            client6.Name = "Hedin";
            client6.EnergiAmount = 290;
            client6.ManualCostOfEnergy = GetManualCost(client6, client6.EnergiAmount);
            client6.CostOfEnergy = GetTheCost(client6, client6.EnergiAmount);            
            arr[clientNumber] = client6;
            clientNumber++;

            Priviliged client7 = new Priviliged();
            client7.Name = "Gustafsson";
            client7.EnergiAmount = 150;
            client7.ManualCostOfEnergy = GetManualCost(client7, client7.EnergiAmount);
            client7.CostOfEnergy = GetTheCost(client7, client7.EnergiAmount);
            arr[clientNumber] = client7;
            clientNumber++;

            Priviliged client8 = new Priviliged();
            client8.Name = "Holm";
            client8.EnergiAmount = 160;
            client8.ManualCostOfEnergy = GetManualCost(client8, client8.EnergiAmount);
            client8.CostOfEnergy = GetTheCost(client8, client8.EnergiAmount);
            arr[clientNumber] = client8;
            clientNumber++;

            Priviliged client9 = new Priviliged();
            client9.Name = "Ulfsson";
            client9.EnergiAmount = 75;
            client9.ManualCostOfEnergy = GetManualCost(client9, client9.EnergiAmount);
            client9.CostOfEnergy = GetTheCost(client9, client9.EnergiAmount);
            arr[clientNumber] = client9;
            clientNumber++;

            HeatingPurposed client10 = new HeatingPurposed();
            client10.Name = "Martinsson";
            client10.EnergiAmount = 1200;
            client10.ManualCostOfEnergy = GetManualCost(client10, client10.EnergiAmount);
            client10.CostOfEnergy = GetTheCost(client10, client10.EnergiAmount);
            arr[clientNumber] = client10;
            clientNumber++;

            HeatingPurposed client11 = new HeatingPurposed();
            client11.Name = "Stenberg";
            client11.EnergiAmount = 90;
            client11.ManualCostOfEnergy = GetManualCost(client11, client11.EnergiAmount);
            client11.CostOfEnergy = GetTheCost(client11, client11.EnergiAmount);
            arr[clientNumber] = client11;
            clientNumber++;

            HeatingPurposed client12 = new HeatingPurposed();
            client12.Name = "Jansson";
            client12.EnergiAmount = 250;
            client12.ManualCostOfEnergy = GetManualCost(client12, client12.EnergiAmount);
            client12.CostOfEnergy = GetTheCost(client12, client12.EnergiAmount);
            arr[clientNumber] = client12;
            clientNumber++;
        }
        private static decimal GetManualCost(Client client, int energiAmount)
        {
            decimal manualCost = energiAmount * PriseCalculation.CommonCoefficent * PriseCalculation.CostPlan;
            return manualCost;
        }
        /// <summary>
        /// calculate sum of rebate
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static decimal GetLimitSizeSum(Client[] arr)
        {
            decimal sumManualCost = 0;
            decimal limitSum;
            for (int i = 0; i < arr.Length; i++)
            {
                sumManualCost += arr[i].ManualCostOfEnergy;
            }
            limitSum = sumManualCost - calculateSum(arr);
            return limitSum;
        }
        /// <summary>
        /// print clients information that located in array
        /// </summary>
        /// <param name="arr"></param>
        private static void PrintData(Client[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {                
                Console.Write("#{0} ",i + 1);
                Console.WriteLine(arr[i].ToString());
            }
        }
        /// <summary>
        /// sorts array by used energy( in descending order)
        /// </summary>
        /// <param name="arr"></param>
        private static void SortByEnergi(Client[] arr)
        {
            Console.WriteLine("Sorted data by used 'ENERGY'(by descending order)");
            Array.Sort(arr);
            Array.Reverse(arr);
        }
        /// <summary>
        /// sorts the array by 'PLAN' of client: Common => Limited => Priviliged=>For Heating Purpose.
        /// </summary>
        /// <param name="arr"></param>
        private static  void SortByPlan(Client [] arr)
        {
            Console.WriteLine("Sorted by 'PLAN' type");
            Array.Sort(arr, new ClientComparerByEnergy());
        }
        /// <summary>
        /// Sorts by paid cost
        /// </summary>
        /// <param name="arr"></param>
        private static void SortByCost(Client [] arr)
        {
            Console.WriteLine("Sorted by paid 'COST'");
            Array.Sort(arr, new ClientComparerByCost());
        }
        /// <summary>
        /// calculates the sum of paid cost
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static decimal calculateSum(Client [] arr)
        {
            decimal sumCost = 0;
            for(int i=0; i < arr.Length; i++)
            {
                sumCost += arr[i].CostOfEnergy;
            }
            return sumCost;
        } 
        private static decimal GetTheCost(object obj, int energiAmount)
        {
            decimal cost = 0;
            if (obj is Common)
            {
                cost = energiAmount * PriseCalculation.CommonCoefficent * PriseCalculation.CostPlan;
            }
            if (obj is Priviliged)
            {
                cost = energiAmount * PriseCalculation.PriviligedCoefficent * PriseCalculation.CostPlan;
            }
            if (obj is HeatingPurposed)
            {
                cost = energiAmount * PriseCalculation.HeatingPurposedCoefficent * PriseCalculation.CostPlan;
            }
            if (obj is Limited)
            {
                if (energiAmount > PriseCalculation.LimitedLevel)
                {
                   decimal ordinaryCost =  PriseCalculation.LimitedLevel* PriseCalculation.CommonCoefficent * PriseCalculation.CostPlan;
                   int overLimitLevel = energiAmount - PriseCalculation.LimitedLevel;                   
                   cost = ordinaryCost + (overLimitLevel * PriseCalculation.LimitedCoefficent);
                }
                else
                {                    
                    cost = energiAmount* PriseCalculation.CommonCoefficent * PriseCalculation.CostPlan;
                }
            }           
            return cost;
        }    
    }
}
