using SamplesWithHTTPFiles.Models;

namespace SamplesWithHTTPFiles.Service
{
    public class CustomerService
    {
        public static List<Customer> GetCustomers()
        {
            var customers = new List<Customer>
            {
                new() {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@example.com",
                    PhoneNumber = "123-456-7890",
                    Address = "123 Main St, Anytown, USA",
                    DateOfBirth = new DateTime(1990, 1, 1),
                    Orders =
                    [
                        new Order
                        {
                            OrderId = 1001,
                            OrderDate = DateTime.Now.AddDays(-10),
                            ShippingAddress = "123 Main St, Anytown, USA",
                            TotalAmount = 299.99m,
                            Items =
                            [
                                new OrderItem { ProductId = 1, ProductName = "Laptop", Quantity = 1, UnitPrice = 999.99m },
                                new OrderItem { ProductId = 2, ProductName = "Mouse", Quantity = 2, UnitPrice = 49.99m }
                            ]
                        },
                        new Order
                        {
                            OrderId = 1002,
                            OrderDate = DateTime.Now.AddDays(-5),
                            ShippingAddress = "123 Main St, Anytown, USA",
                            TotalAmount = 49.99m,
                            Items =
                            [
                                new OrderItem { ProductId = 2, ProductName = "Mouse", Quantity = 1, UnitPrice = 49.99m }
                            ]
                        }
                    ]
                },
                new() {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane.smith@example.com",
                    PhoneNumber = "987-654-3210",
                    Address = "456 Oak St, Anytown, USA",
                    DateOfBirth = new DateTime(1985, 5, 15),
                    Orders =
                    [
                        new Order
                        {
                            OrderId = 1003,
                            OrderDate = DateTime.Now.AddDays(-20),
                            ShippingAddress = "456 Oak St, Anytown, USA",
                            TotalAmount = 199.99m,
                            Items =
                            [
                                new OrderItem { ProductId = 3, ProductName = "Tablet", Quantity = 1, UnitPrice = 199.99m }
                            ]
                        }
                    ]
                },
                new() {
                    Id = 3,
                    FirstName = "Alice",
                    LastName = "Johnson",
                    Email = "alice.johnson@example.com",
                    PhoneNumber = "555-123-4567",
                    Address = "789 Maple St, Anytown, USA",
                    DateOfBirth = new DateTime(1988, 7, 22),
                    Orders =
                    [
                        new Order
                        {
                            OrderId = 1004,
                            OrderDate = DateTime.Now.AddDays(-15),
                            ShippingAddress = "789 Maple St, Anytown, USA",
                            TotalAmount = 150.00m,
                            Items =
                            [
                                new OrderItem { ProductId = 4, ProductName = "Smartphone", Quantity = 1, UnitPrice = 150.00m }
                            ]
                        }
                    ]
                },
                new() {
                    Id = 4,
                    FirstName = "Bob",
                    LastName = "Brown",
                    Email = "bob.brown@example.com",
                    PhoneNumber = "555-987-6543",
                    Address = "123 Elm St, Anytown, USA",
                    DateOfBirth = new DateTime(1992, 3, 3),
                    Orders =
                    [
                        new Order
                        {
                            OrderId = 1005,
                            OrderDate = DateTime.Now.AddDays(-30),
                            ShippingAddress = "123 Elm St, Anytown, USA",
                            TotalAmount = 120.00m,
                            Items =
                            [
                                new OrderItem { ProductId = 5, ProductName = "Headphones", Quantity = 2, UnitPrice = 60.00m }
                            ]
                        }
                    ]
                },
                new() {
                    Id = 5,
                    FirstName = "Charlie",
                    LastName = "Davis",
                    Email = "charlie.davis@example.com",
                    PhoneNumber = "444-555-6666",
                    Address = "456 Pine St, Anytown, USA",
                    DateOfBirth = new DateTime(1982, 11, 19),
                    Orders =
                    [
                        new Order
                        {
                            OrderId = 1006,
                            OrderDate = DateTime.Now.AddDays(-45),
                            ShippingAddress = "456 Pine St, Anytown, USA",
                            TotalAmount = 79.99m,
                            Items =
                            [
                                new OrderItem { ProductId = 6, ProductName = "Keyboard", Quantity = 1, UnitPrice = 79.99m }
                            ]
                        }
                    ]
                },
                new() {
                    Id = 6,
                    FirstName = "David",
                    LastName = "Evans",
                    Email = "david.evans@example.com",
                    PhoneNumber = "333-777-8888",
                    Address = "789 Birch St, Anytown, USA",
                    DateOfBirth = new DateTime(1995, 6, 7),
                    Orders =
                    [
                        new Order
                        {
                            OrderId = 1007,
                            OrderDate = DateTime.Now.AddDays(-60),
                            ShippingAddress = "789 Birch St, Anytown, USA",
                            TotalAmount = 59.99m,
                            Items =
                            [
                                new OrderItem { ProductId = 7, ProductName = "Webcam", Quantity = 1, UnitPrice = 59.99m }
                            ]
                        }
                    ]
                },
                new() {
                    Id = 7,
                    FirstName = "Emma",
                    LastName = "Green",
                    Email = "emma.green@example.com",
                    PhoneNumber = "222-333-4444",
                    Address = "123 Willow St, Anytown, USA",
                    DateOfBirth = new DateTime(1998, 12, 25),
                    Orders =
                    [
                        new Order
                        {
                            OrderId = 1008,
                            OrderDate = DateTime.Now.AddDays(-5),
                            ShippingAddress = "123 Willow St, Anytown, USA",
                            TotalAmount = 149.99m,
                            Items =
                            [
                                new OrderItem { ProductId = 8, ProductName = "Smartwatch", Quantity = 1, UnitPrice = 149.99m }
                            ]
                        }
                    ]
                },
                new() {
                    Id = 8,
                    FirstName = "Frank",
                    LastName = "Harris",
                    Email = "frank.harris@example.com",
                    PhoneNumber = "111-222-3333",
                    Address = "456 Cedar St, Anytown, USA",
                    DateOfBirth = new DateTime(1980, 4, 10),
                    Orders =
                    [
                        new Order
                        {
                            OrderId = 1009,
                            OrderDate = DateTime.Now.AddDays(-90),
                            ShippingAddress = "456 Cedar St, Anytown, USA",
                            TotalAmount = 29.99m,
                            Items =
                            [
                                new OrderItem { ProductId = 9, ProductName = "Mousepad", Quantity = 1, UnitPrice = 29.99m }
                            ]
                        }
                    ]
                },
                new() {
                    Id = 9,
                    FirstName = "Grace",
                    LastName = "Irvine",
                    Email = "grace.irvine@example.com",
                    PhoneNumber = "888-999-0000",
                    Address = "789 Fir St, Anytown, USA",
                    DateOfBirth = new DateTime(1991, 2, 14),
                    Orders =
                    [
                        new Order
                        {
                            OrderId = 1010,
                            OrderDate = DateTime.Now.AddDays(-7),
                            ShippingAddress = "789 Fir St, Anytown, USA",
                            TotalAmount = 349.99m,
                            Items =
                            [
                                new OrderItem { ProductId = 10, ProductName = "Gaming Chair", Quantity = 1, UnitPrice = 349.99m }
                            ]
                        }
                    ]
                },
                new() {
                    Id = 10,
                    FirstName = "Henry",
                    LastName = "Jones",
                    Email = "henry.jones@example.com",
                    PhoneNumber = "777-888-9999",
                    Address = "123 Poplar St, Anytown, USA",
                    DateOfBirth = new DateTime(1987, 9, 30),
                    Orders =
                    [
                        new Order
                        {
                            OrderId = 1011,
                            OrderDate = DateTime.Now.AddDays(-1),
                            ShippingAddress = "123 Poplar St, Anytown, USA",
                            TotalAmount = 599.99m,
                            Items =
                            [
                                new OrderItem { ProductId = 11, ProductName = "Monitor", Quantity = 1, UnitPrice = 599.99m }
                            ]
                        }
                    ]
                }
            };

            return customers;
        }
    }
}
