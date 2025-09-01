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

            #region LINQ - Set Operators

            #region 1. Find the unique Category names from Product List
            //var uniqueCategories = ListGenerator.ProductList
            //    .Select(p => p.Category)
            //    .Distinct();

            //foreach (var cat in uniqueCategories)
            //{
            //    Console.WriteLine($" - {cat}");
            //}
            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names
            //var uniqueFirstLetters = ListGenerator.ProductList
            //    .Select(p => p.ProductName[0])
            //    .Union(ListGenerator.CustomerList.Select(c => c.CustomerName[0]));

            //foreach (var letter in uniqueFirstLetters)
            //{
            //    Console.WriteLine($" - {letter}");
            //}

            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names
            //var commonFirstLetters = ListGenerator.ProductList
            //    .Select(p => p.ProductName[0])
            //    .Intersect(ListGenerator.CustomerList.Select(c => c.CustomerName[0]));

            //foreach (var letter in commonFirstLetters)
            //{
            //    Console.WriteLine($" - {letter}");
            //}
            #endregion

            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names
            //var productOnlyFirstLetters = ListGenerator.ProductList
            //    .Select(p => p.ProductName[0])
            //    .Except(ListGenerator.CustomerList.Select(c => c.CustomerName[0]));

            //foreach (var letter in productOnlyFirstLetters)
            //{
            //    Console.WriteLine($" - {letter}");
            //}
            #endregion

            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var lastThreeChars = ListGenerator.ProductList
            //    .Select(p => p.ProductName.Length >= 3
            //        ? p.ProductName.Substring(p.ProductName.Length - 3)
            //        : p.ProductName)
            //    .Concat(ListGenerator.CustomerList
            //        .Select(c => c.CustomerName.Length >= 3
            //            ? c.CustomerName.Substring(c.CustomerName.Length - 3)
            //            : c.CustomerName));

            //foreach (var chunk in lastThreeChars)
            //{
            //    Console.WriteLine($" - {chunk}");
            //}
            #endregion

            #endregion
        }
    }
}
