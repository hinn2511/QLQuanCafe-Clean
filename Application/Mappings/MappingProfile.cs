using System.Collections.Generic;
using Application.DTOs;
using Domain.Entities.CustomerAggregate;
using Domain.Entities.BillAggregate;
using Domain.Entities;


namespace Application.Mappings
{
    public static class MappingProfile
    {
        

        ///////////////////////////             Ingredient                ////////////////////////////////

        public static IngredientDto MappingDto(this Ingredient ingredient)
        {
            return new IngredientDto
            {
                Id = ingredient.Id,
                IngredientName = ingredient.IngredientName,
                IngredientSupplier = ingredient.IngredientSupplier,
                IngredientPrice = ingredient.IngredientPrice,
                IngredientQuantity = ingredient.IngredientQuantity,
                IngredientUnit = ingredient.IngredientUnit,
                IngredientType = ingredient.IngredientType
            };
        }

        public static Ingredient MappingIngredient(this IngredientDto ingredientDto)
        {
            return new Ingredient
            {
                Id = ingredientDto.Id,
                IngredientName = ingredientDto.IngredientName,
                IngredientSupplier = ingredientDto.IngredientSupplier,
                IngredientQuantity = ingredientDto.IngredientQuantity,
                IngredientPrice = ingredientDto.IngredientPrice,
                IngredientUnit = ingredientDto.IngredientUnit,
                IngredientType = ingredientDto.IngredientType
            };
        }
        public static void MappingIngredient(this IngredientDto ingredientDto, Ingredient ingredient)
        {
            ingredient.IngredientName = ingredientDto.IngredientName;
            ingredient.IngredientSupplier = ingredientDto.IngredientSupplier;
            ingredient.IngredientQuantity = ingredientDto.IngredientQuantity;
            ingredient.IngredientPrice = ingredientDto.IngredientPrice;
            ingredient.IngredientUnit = ingredientDto.IngredientUnit;
            ingredient.IngredientType = ingredientDto.IngredientType;
        }

        public static IEnumerable<IngredientDto> MappingDtos(this IEnumerable<Ingredient> ingredients)
        {
            foreach (var ingredient in ingredients)
            {
                yield return ingredient.MappingDto();
            }
        }

        ///////////////////////////////            Customer          ////////////////////////////////////
        public static CustomerDto MappingDto(this Customer customer)
        {
            return new CustomerDto
            {
                Id = customer.Id,
                CustomerName = customer.CustomerName,
                CustomerPhoneNumber = customer.CustomerPhoneNumber,
                CustomerAddress = customer.CustomerAddress,
                CustomerEmail = customer.CustomerEmail
            };
        }

        public static Customer MappingCustomer(this CustomerDto customerDto)
        {
            return new Customer
            {
                Id = customerDto.Id,
                CustomerName = customerDto.CustomerName,
                CustomerPhoneNumber = customerDto.CustomerPhoneNumber,
                CustomerAddress = customerDto.CustomerAddress,
                CustomerEmail = customerDto.CustomerEmail
            };
        }
        public static void MappingCustomer(this CustomerDto customerDto, Customer customer)
        {
            customer.CustomerName = customerDto.CustomerName;
            customer.CustomerPhoneNumber = customerDto.CustomerPhoneNumber;
            customer.CustomerAddress = customerDto.CustomerAddress;
            customer.CustomerEmail = customerDto.CustomerEmail;
        }

        public static IEnumerable<CustomerDto> MappingDtos(this IEnumerable<Customer> customers)
        {
            foreach (var customer in customers)
            {
                yield return customer.MappingDto();
            }
        }

        ///////////////////////////////////       Bill       ///////////////////////////////////////////
        public static BillDto MappingDto(this Bill bill)
        {
            return new BillDto
            {
                Id = bill.Id,
                BillNumber = bill.BillNumber,
                BillDate = bill.BillDate,
                CustomerId = bill.CustomerId,
                Total = bill.Total
            };
        }

        public static Bill MappingBill(this BillDto billDto)
        {
            
            return new Bill
            {
                Id = billDto.Id,
                BillNumber = billDto.BillNumber,
                BillDate = billDto.BillDate,
                CustomerId = billDto.CustomerId,
                Total = billDto.Total
            };
        }
        public static void MappingBill(this BillDto billDto, Bill bill)
        {
            bill.BillNumber = billDto.BillNumber;
            bill.BillDate = billDto.BillDate;
            bill.Total = billDto.Total;
            bill.CustomerId = billDto.CustomerId;
        }

        public static IEnumerable<BillDto> MappingDtos(this IEnumerable<Bill> bills)
        {
            foreach (var bill in bills)
            {
                yield return bill.MappingDto();
            }
        }

        ///////////////////////////////////      Bill Detail       ////////////////////////////////////////
        public static BillDetailDto MappingDto(this BillDetail billDetail)
        {
            return new BillDetailDto
            {         
                BillId = billDetail.BillId,
                ProductId = billDetail.ProductId,
                Quantity = billDetail.Quantity,
                BillDetailTotal = billDetail.BillDetailTotal
            };
        }

        public static BillDetail MappingBillDetail(this BillDetailDto billDetailDto)
        {
            return new BillDetail
            {
                BillId = billDetailDto.BillId,
                ProductId = billDetailDto.ProductId,
                Quantity = billDetailDto.Quantity,
                BillDetailTotal = billDetailDto.BillDetailTotal
            };
        }

        
        public static void MappingBillDetail(this BillDetailDto billDetailDto, BillDetail billDetail)
        {
            billDetail.BillId = billDetailDto.BillId;
            billDetail.ProductId = billDetail.ProductId;
            billDetail.ProductId = billDetail.ProductId;

            billDetail.Quantity = billDetailDto.Quantity;
            billDetail.BillDetailTotal = billDetailDto.BillDetailTotal;
        }

        public static IEnumerable<BillDetailDto> MappingDtos(this IEnumerable<BillDetail> billDetails)
        {
            foreach (var billDetail in billDetails)
            {
                yield return billDetail.MappingDto();
            }
        }

        ///////////////////////////////////////     Product      ///////////////////////////////////////////
        public static ProductDto MappingDto(this Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                ProductName = product.ProductName,
                ProductPrice = product.ProductPrice,               
                ProductAvailable = product.ProductAvailable,
                ProductAddingDate = product.ProductAddingDate,
                ProductType = product.ProductType
            };
        }

        public static Product MappingProduct(this ProductDto productDto)
        {
            return new Product
            {
                Id = productDto.Id,
                ProductName = productDto.ProductName,
                ProductPrice = productDto.ProductPrice,               
                ProductAvailable = productDto.ProductAvailable,
                ProductAddingDate = productDto.ProductAddingDate,
                ProductType = productDto.ProductType
            };
        }
        public static void MappingProduct(this ProductDto productDto, Product product)
        {

            product.ProductName = productDto.ProductName;
            product.ProductPrice = productDto.ProductPrice;              
            product.ProductAvailable = productDto.ProductAvailable;
            product.ProductAddingDate = productDto.ProductAddingDate;
            product.ProductType = productDto.ProductType;
        }

        public static IEnumerable<ProductDto> MappingDtos(this IEnumerable<Product> products)
        {
            foreach (var product in products)
            {
                yield return product.MappingDto();
            }
        }

        ///////////////////////////////////////     Product Ordered      ///////////////////////////////////////////
        
    }
}