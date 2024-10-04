namespace Modul8;

public class Opgaver
{
    private List<Item> items;

    public Opgaver()
    {
        items = new();
        items.Add(new Item {Name="Macbook Air", Price = 8000, Stock = 4, Color = "Silver"});
        items.Add(new Item {Name="Macbook Pro", Price = 12000, Stock = 2, Color = "Dark Grey"});
        items.Add(new Item {Name="Lenovo, DX", Price = 8500, Stock = 0, Color = "Black"});
        items.Add(new Item {Name="Lenovo, CX4", Price = 10000, Stock = 3, Color = "Black"});
        items.Add(new Item {Name="Lenovo, DX", Price = 8500, Stock = 0, Color = "Black"});
        items.Add(new Item {Name="Ipad, 4gen", Price = 2500, Stock = 12, Color = "Rose"});
    }

    public void Opgave2()
    {
        var res = ItemsInStock(items);
        foreach (var item in res)
            Console.WriteLine($"{item.Name}, {item.Price}, {item.Stock}");
        
    }

    public List<Item> ItemsInStock(List<Item> items)
    {
        //return items.Where(item => item.Stock > 0).ToList(); 
        List<Item> result = new();
        foreach (var item in items)
            if (item.Stock > 0)
                result.Add(item);
        return result;

    }
    
    public void Opgave3()
    {
        var res = ItemsWithColor(items, 
                                    new string[]{"Silver", "Black"});
        foreach (var item in res)
            Console.WriteLine($"{item.Name}, {item.Price}, {item.Stock}, {item.Color}");
        
    }
    public List<Item> ItemsWithColor(List<Item> items, string[] colors)
    {
        List<Item> result = new();
        foreach (var item in items)
            if (colors.Contains(item.Color))
                result.Add(item);
        return result;
    }
}