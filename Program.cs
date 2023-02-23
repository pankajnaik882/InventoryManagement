namespace InventoryManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = "C:\\Users\\USER\\source\\repos\\InventoryManagement\\InventoryManagement\\Inventory.json";
            Fetchinventory fetchInventory = new Fetchinventory();

            InventoryDetails data = fetchInventory.Read(path);

            Console.WriteLine(data.typesofstock.stockname);
            Console.WriteLine(data.typesofstock.shareprice);
            Console.WriteLine(data.typesofstock.numberofshare);
        }
    }
}