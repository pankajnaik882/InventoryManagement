namespace InventoryManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = "C:\\Users\\USER\\source\\repos\\InventoryManagement\\InventoryManagement\\Inventory.json";
            Fetchinventory fetchInventory = new Fetchinventory();

            InventoryDetails data = fetchInventory.Read(path);


            for(int i = 0; i < data.typesofstock.Count; i++)
            {
                Console.WriteLine(data.typesofstock[i].stockname);
                Console.WriteLine(data.typesofstock[i].shareprice);
                Console.WriteLine(data.typesofstock[i].numberofshare);
                int total = data.typesofstock[i].numberofshare * data.typesofstock[i].shareprice;
                Console.WriteLine("Total Stock Price : "+total);
                Console.WriteLine("********************************************");
            }
        }
    }
}