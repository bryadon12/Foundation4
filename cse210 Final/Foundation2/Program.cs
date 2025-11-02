
class Program
{
    static void Main(string[] args)
    {

        Product apples = new Product("apple", 01, 0.20, 8);
        Product oranges = new Product("orange", 02, .25, 10);
        Product bananas = new Product("banana", 03, 0.40, 5);
        Product milk = new Product("milk", 04, 4.50, 1);
        Product butter = new Product("butter", 05, 1.00, 4);

        Customer customer1 = new Customer();
        customer1.setName("John");
        customer1.setAddress(new Address("123 Main st.", "Rexburg", "ID", "USA"));

        Order order1 = new Order();
        order1.setCustomer(customer1);
        order1.AddProduct(apples);
        order1.AddProduct(oranges);
        order1.AddProduct(bananas);

        Customer customer2 = new Customer();
        customer1.setName("Juan");
        customer1.setAddress(new Address("321 Las Floras", "Tacuba", "Ciudad de Mexico", "Mexico"));

        Order order2 = new Order();
        order2.setCustomer(customer2);
        order2.AddProduct(milk);
        order2.AddProduct(butter);

        Console.WriteLine(order1.PackingLable());
        Console.WriteLine(order1.ShippingLable());
        Console.WriteLine($"{order1.CalculateCost()}$");

        Console.WriteLine(order2.PackingLable());
        Console.WriteLine(order2.ShippingLable());
        Console.WriteLine($"{order2.CalculateCost()}$");

    }
}