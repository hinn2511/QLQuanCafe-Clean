using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Entities.BillAggregate;
using Domain.Entities.CustomerAggregate;

namespace Infrastructure.Persistence
{
    public class SeedData
    {
        public static void Initialize(QLQuanCafeContext qlQuanCafeContext)
        {
            qlQuanCafeContext.Database.EnsureCreated();
            if (qlQuanCafeContext.Ingredients.Any()) return;

            qlQuanCafeContext.Ingredients.AddRange(new List<Ingredient>{
                new Ingredient {
                    IngredientName = "Coffee Powder",
                    IngredientSupplier = "Trung Nguyen Co",
                    IngredientPrice = 50000,
                    IngredientQuantity = 5,
                    IngredientUnit = "KG",
                    IngredientType = "Coffee"
                    
                },
                new Ingredient {
                    IngredientName = "Milk",
                    IngredientSupplier = "Vinamilk Co",
                    IngredientPrice = 120000,
                    IngredientQuantity = 5,
                    IngredientUnit = "L",
                    IngredientType = "Milk"
                },
                new Ingredient {
                    IngredientName = "Condensed milk",
                    IngredientSupplier = "Vinamilk Co",
                    IngredientPrice = 150000,
                    IngredientQuantity = 10,
                    IngredientUnit = "L",
                    IngredientType = "Milk"
                },
                new Ingredient {
                    IngredientName = "Oolong tea",
                    IngredientSupplier = "Phuc Long Co",
                    IngredientPrice = 80000,
                    IngredientQuantity = 4,
                    IngredientUnit = "KG",
                    IngredientType = "Tea"
                },
                new Ingredient {
                    IngredientName = "Oranges",
                    IngredientSupplier = "Viet Fruit Co",
                    IngredientPrice = 18000,
                    IngredientQuantity = 10,
                    IngredientUnit = "KG",
                    IngredientType = "Fruit"
                },
                new Ingredient {
                    IngredientName = "Strawberry",
                    IngredientSupplier = "Viet Fruit Co",
                    IngredientPrice = 60000,
                    IngredientQuantity = 15,
                    IngredientUnit = "KG",
                    IngredientType = "Fruit"
                }
            });
            
            if (qlQuanCafeContext.Products.Any()) return;
            qlQuanCafeContext.Products.AddRange(new List<Product>{
                new Product {
                    ProductName = "Black Coffee",
                    ProductPrice = 10000,
                    ProductAddingDate = DateTime.Parse("2020-12-14"),
                    ProductType = "Coffee",
                    ProductAvailable = "Yes"
                },
                new Product {
                    ProductName = "Milk Coffee",
                    ProductPrice = 10000,
                    ProductAddingDate = DateTime.Parse("2020-12-14"),
                    ProductType = "Coffee",
                    ProductAvailable = "Yes"
                },
                new Product {
                    ProductName = "Milk Tea",
                    ProductPrice = 10000,
                    ProductAddingDate = DateTime.Parse("2020-12-14"),
                    ProductType = "Tea",
                    ProductAvailable = "Yes"
                }
            });
            if (qlQuanCafeContext.Customers.Any()) return;
            qlQuanCafeContext.Customers.AddRange(new List<Customer>{
                new Customer {
                    CustomerName = "Max",
                    CustomerPhoneNumber = "091111",
                    CustomerAddress = "1 An Duong Vuong",
                    CustomerEmail = "max01@gmail.com"
                },
                new Customer {
                    CustomerName = "Lee",
                    CustomerPhoneNumber = "092222",
                    CustomerAddress = "2 Luy Ban Bich",
                    CustomerEmail = "lee02@gmail.com"
                },
                new Customer {
                    CustomerName = "Bill",
                    CustomerPhoneNumber = "09333",
                    CustomerAddress = "3 Nguyen Trai",
                    CustomerEmail = "bill03@gmail.com"
                }
            });
            if (qlQuanCafeContext.Bills.Any()) return;
            qlQuanCafeContext.Bills.AddRange(new List<Bill>{
                new Bill {
                    BillDate = DateTime.Parse("2020-12-14"),
                    BillNumber = "BN001",
                    CustomerId = 2,
                    Total = 0
                },
                new Bill {
                    BillDate = DateTime.Parse("2020-12-14"),
                    BillNumber = "BN002",
                    CustomerId = 3,
                    Total = 0
                },
                new Bill {
                    BillDate = DateTime.Parse("2020-12-14"),
                    BillNumber = "BN003",
                    CustomerId = 1,
                    Total = 0
                }
            });
            if (qlQuanCafeContext.BillDetails.Any()) return;
            qlQuanCafeContext.BillDetails.AddRange(new List<BillDetail>{
                new BillDetail {
                    BillId = 1,
                    ProductId = 1,
                    Quantity = 3,
                    BillDetailTotal = 60000
                },
                new BillDetail {
                    BillId = 1,
                    ProductId = 2,
                    Quantity = 1,
                    BillDetailTotal = 30000
                },
                new BillDetail {
                    BillId = 2,
                    ProductId = 1,
                    Quantity = 2,
                    BillDetailTotal = 20000
                }
            });
            



            
            

            qlQuanCafeContext.SaveChanges();
        }
    

        
    }
}
