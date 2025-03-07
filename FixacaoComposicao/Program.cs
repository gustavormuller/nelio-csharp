﻿using System;
using FixacaoComposicao.Entities;

namespace FixacaoComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine()!;
            Console.Write("Email: ");
            string email = Console.ReadLine()!;
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine()!);

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine()!);

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine()!;
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine()!);

                Product product = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                int qty = int.Parse(Console.ReadLine()!);

                OrderItem orderItem = new OrderItem(qty, productPrice, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("Order summary:");
            Console.WriteLine(order);  
        }
    }
}