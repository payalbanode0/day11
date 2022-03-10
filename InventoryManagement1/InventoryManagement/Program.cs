using System;
using System.IO;
using Newtonsoft.Json;

namespace InventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            InventoryManager manager = new InventoryManager();
            string file = @"C:\Users\ASUS\Desktop\day11\InventoryManagement1\InventoryManagement\json.json";
            InventoryUtility utility = JsonConvert.DeserializeObject<InventoryUtility>(File.ReadAllText(file));
            Console.WriteLine("Display inventory Press 1-Rice Inventory 2-Wheat Inventory 3-Pulse Inventory ");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    //Rice Inventory operations
                    var fs = utility.RiceList;
                    Console.WriteLine("Enter which operation to perform\n 1-Add to Inventory\n 2-Remove from inventory\n3-Display Inventory");
                    int num = Convert.ToInt32(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                            manager.AddInventory(fs);
                            File.WriteAllText(file, JsonConvert.SerializeObject(utility));
                            manager.DisplayInventory(fs);
                            break;
                        case 2:
                            manager.DeleteInventory(fs);
                            File.WriteAllText(file, JsonConvert.SerializeObject(utility));
                            manager.DisplayInventory(fs);
                            break;
                        case 3:
                            manager.DisplayInventory(fs);
                            break;
                    }

                    break;
                case 2:
                    //Wheat Inventory operations
                    var fs1 = utility.WheatList;
                    Console.WriteLine("Enter which operation to perform\n 1-Add to Inventory\n 2-Remove from inventory\n 3-Display Inventory");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    switch (num1)
                    {
                        case 1:
                            manager.AddInventory(fs1);
                            File.WriteAllText(file, JsonConvert.SerializeObject(utility));
                            manager.DisplayInventory(fs1);
                            break;
                        case 2:
                            manager.DeleteInventory(fs1);
                            File.WriteAllText(file, JsonConvert.SerializeObject(utility));
                            manager.DisplayInventory(fs1);
                            break;
                        case 3:
                            manager.DisplayInventory(fs1);
                            break;
                    }
                    break;
                case 3:
                    //Pulse Inventory operations
                    var fs2 = utility.PulseList;
                    Console.WriteLine("Enter which operation to perform\n 1-Add to Inventory\n 2-Remove from inventory\n 3-Display Inventory");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    switch (num2)
                    {
                        case 1:
                            manager.AddInventory(fs2);
                            File.WriteAllText(file, JsonConvert.SerializeObject(utility));
                            manager.DisplayInventory(fs2);
                            break;
                        case 2:
                            manager.DeleteInventory(fs2);
                            File.WriteAllText(file, JsonConvert.SerializeObject(utility));
                            manager.DisplayInventory(fs2);
                            break;
                        case 3:
                            manager.DisplayInventory(fs2);
                            break;
                    }
                    break;
            }
        }
    }

}