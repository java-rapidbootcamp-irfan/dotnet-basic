namespace LinqTutorial.Model;

public class Product
{
    public string Name { get; set; }
    public int Price { get; set; }

    public Product(String name, int price)
    {
        this.Name = name;
        this.Price = price;
    }

    // toString
    public override string ToString()
    {
        return "Product { Name: "+ this.Name +", Price: Rp. "+ this.Price +"}";
    }

    public static List<Product> GetData()
    {
        List<Product> products = new List<Product>()
        {
            new Product("Mie Goreng", 20000),
            new Product("Mie Ayam", 25000),
            new Product("Donat Madu", 30000),
            new Product("Juz Alpukat", 15000),
            new Product("Juz Mangga", 15000),
        };

        return products;
    }

    public static void SampleFilterProduct()
    {
        // 1. create data source
        List<Product> products = GetData();

        // 2. create query
        IEnumerable<Product> productFilter = from item in products
                                             where item.Price >= 30000
                                             select item;

        // 3. execute query
        foreach (var product in productFilter)
        {
            Console.WriteLine(product);
        }
    }

    public static void SampleFilterByName()
    {
        List<Product> products = GetData();

        IEnumerable<Product> productFilter = from product in products
                                             where product.Name.ToLower().Contains("juz")
                                             select product;
        foreach (var product in productFilter)
        {
            Console.WriteLine(product);
        }
    }
}
