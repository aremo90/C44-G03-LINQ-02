using ConsoleApp1.Data;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Aggregate Operators

            #region 1. Get the total units in stock for each product category.

            //var result = ListGenerator.ProductList.GroupBy(p => p.Category)
            //.Select(g => new
            //{
            //Category = g.Key,
            //TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
            //});
            //foreach (var item in result)
            //{
            //Console.WriteLine($"{item.Category}: {item.TotalUnitsInStock}");
            //}

            #endregion

            #region  2.Get the cheapest price among each category's products

            //var result = ListGenerator.ProductList.GroupBy(p => p.Category)
            //    .Select(g => new
            //{
            //    Category = g.Key,
            //    CheapestPrice = g.Min(p => p.UnitPrice)
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category}: {item.CheapestPrice}");
            //}


            #endregion

            #region 3. Get the products with the cheapest price in each category (Use Let)

            //var result =
            //    from p in ListGenerator.ProductList
            //    group p by p.Category into g
            //    let minPrice = g.Min(x => x.UnitPrice)
            //    select new
            //    {
            //        Category = g.Key,
            //        CheapestPrice = minPrice,
            //        Products = g.Where(p => p.UnitPrice == minPrice)
            //    };
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category}: {item.CheapestPrice}");
            //    foreach (var product in item.Products)
            //    {
            //        Console.WriteLine($"\t{product.ProductName} - {product.UnitPrice}");
            //    }
            //}


            #endregion

            #region 4. Get the most expensive price among each category's products.

            //var result4 = ListGenerator.ProductList
            //.GroupBy(p => p.Category)
            //.Select(g => new
            //    {
            //    Category = g.Key,
            //    MostExpensivePrice = g.Max(p => p.UnitPrice)
            //    });

            //foreach (var item in result4)
            //    {
            //    Console.WriteLine($"{item.Category}: {item.MostExpensivePrice}");
            //}

            #endregion

            #region 5. Get the products with the most expensive price in each category.

            //var result5 = ListGenerator.ProductList
            //.GroupBy(p => p.Category)
            //.Select(g =>
            //{
            //    var maxPrice = g.Max(x => x.UnitPrice);
            //    return new
            //    {
            //        Category = g.Key,
            //        MostExpensivePrice = maxPrice,
            //        Products = g.Where(p => p.UnitPrice == maxPrice)
            //    };
            //});

            //foreach (var item in result5)
            //{
            //    Console.WriteLine($"{item.Category}: {item.MostExpensivePrice}");
            //    foreach (var product in item.Products)
            //    {
            //        Console.WriteLine($"\t{product.ProductName} - {product.UnitPrice}");
            //    }
            //}


            #endregion

            #region 6. Get the average price of each category's products.

            //var result6 = ListGenerator.ProductList
            //.GroupBy(p => p.Category)
            //.Select(g => new
            //{
            //    Category = g.Key,
            //    AveragePrice = g.Average(p => p.UnitPrice)
            //});

            //foreach (var item in result6)
            //{
            //    Console.WriteLine($"{item.Category}: {item.AveragePrice}");
            //}


            #endregion

            #endregion
        }
    }
}
