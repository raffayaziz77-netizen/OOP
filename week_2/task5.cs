using System;

public class Product
{
    public int ID;
    public string Name;
    public int price;
    public string Category;
    public string BrandName;
    public string Country;

    // Parameterized Constructor
    public Product(int id, string name, int p, string category,
                   string brand, string country)
    {
        ID = id;
        Name = name;
        price = p;
        Category = category;
        BrandName = brand;
        Country = country;
    }

    // Behavior 1: Show Product
    public void showProduct()
    {
        Console.WriteLine("ID: " + ID);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Category: " + Category);
        Console.WriteLine("Brand: " + BrandName);
        Console.WriteLine("Country: " + Country);
        Console.WriteLine();
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Product[] products = new Product[100];
        int count = 0;
        int choice;

        do
        {
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Show Products");
            Console.WriteLine("3. Total Store Worth");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            // 1. Add Product
            if (choice == 1)
            {
                Console.Write("Enter ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Price: ");
                int price = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Category: ");
                string category = Console.ReadLine();

                Console.Write("Enter Brand Name: ");
                string brand = Console.ReadLine();

                Console.Write("Enter Country: ");
                string country = Console.ReadLine();

                products[count] = new Product(
                    id, name, price, category, brand, country
                );

                count++;

                Console.WriteLine("Product Added Successfully!");
                Console.WriteLine();
            }

            // 2. Show Products
            else if (choice == 2)
            {
                if (count == 0)
                {
                    Console.WriteLine("No products available.");
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        products[i].showProduct();
                    }
                }
            }

            // 3. Total Store Worth
            else if (choice == 3)
            {
                int total = 0;

                for (int i = 0; i < count; i++)
                {
                    total = total + products[i].price;
                }

                Console.WriteLine("Total Store Worth: " + total);
            }

            // 4. Exit
            else if (choice == 4)
            {
                Console.WriteLine("Program Ended.");
            }

            else
            {
                Console.WriteLine("Invalid Choice.");
            }

        } while (choice != 4);
    }
}