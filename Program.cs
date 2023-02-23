namespace InventoryManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = "C:\\Users\\USER\\source\\repos\\InventoryManagement\\InventoryManagement\\Inventory.json";
            Fetchinventory fetchInventory = new Fetchinventory();

            InventoryDetails data = fetchInventory.Read(path);

            Console.WriteLine("Type of Rice");
            Console.WriteLine("*********************************************");

            for (int i = 0; i < data.typeofRice.Count; i++)
            {
                Console.WriteLine(data.typeofRice[i].name);
                Console.WriteLine(data.typeofRice[i].weight);
                Console.WriteLine(data.typeofRice[i].price);
                int price = data.typeofRice[i].weight * data.typeofRice[i].price;
                Console.WriteLine("The prize of {0} for {1}kg is {2}",
                data.typeofRice[i].name, data.typeofRice[i].weight, price);

                Console.WriteLine("************************************************");

            }


            Console.WriteLine("Type of Pulses");
            Console.WriteLine("*********************************************");

            for (int i = 0; i < data.typeofPulses.Count; i++)
            {
                Console.WriteLine(data.typeofPulses[i].name);
                Console.WriteLine(data.typeofPulses[i].weight);
                Console.WriteLine(data.typeofPulses[i].price);
                int price = data.typeofPulses[i].weight * data.typeofPulses[i].price;
                Console.WriteLine("The prize of {0} for {1}kg is {2}",
                data.typeofPulses[i].name, data.typeofPulses[i].weight, price);


                Console.WriteLine("************************************************");

            }

            Console.WriteLine("Type of Wheat");
            Console.WriteLine("*********************************************");

            for (int i = 0; i < data.typeofWheat.Count; i++)
            {
                Console.WriteLine(data.typeofWheat[i].name);
                Console.WriteLine(data.typeofWheat[i].weight);
                Console.WriteLine(data.typeofWheat[i].price);
                int price = data.typeofWheat[i].weight * data.typeofWheat[i].price;
                Console.WriteLine("The prize of {0} for {1}kg is {2}",
                data.typeofWheat[i].name, data.typeofWheat[i].weight, price);

                Console.WriteLine("************************************************");

            }
        }
    }
}