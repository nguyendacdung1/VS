using System;
using System.Collections.Generic;
abstract class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public Product(int Id, string Name, double Price)
    {
        this.Id = Id;
        this.Name = Name;
        this.Price = Price;
    }
    public abstract double computeTax();
}


class Book : Product
{
    public Book(int id, string name, double price) : base(id, name, price)
    {

    }
    public override double computeTax()
    {
        return this.Price * 5 / 100;
    }
}

class Phone : Product
{
    public Phone(int id, string name, double price) : base(id, name, price)
    {

    }
    public override double computeTax()
    {
        return this.Price * 10 / 100;
    }
}



// Class test
class Program
{
    static void Main(string[] args)
    {
        // Array Product (3 book, 2 phone)
        Product[] product = new Product[5];
        product[0] = new Book(1, "giai tich", 30000);
        product[1] = new Book(2, "giai thich tieng anh", 45000);
        product[2] = new Book(3, "harry poter", 500000);
        product[3] = new Phone(4, "Iphone 11 pro", 130000000);
        product[4] = new Phone(5, "Iphone 11", 1000000000);

        // Total Tax
        double totalTax = 0;
        foreach (var p in product)
        {
            totalTax += p.computeTax();
        }
        // Print total tax
        Console.WriteLine(totalTax);
    }
}