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

            #region LINQ - Partitioning Operators

            #region 1. Get the first 3 orders from customers in Washington
            //var result = ListGenerator.CustomerList
            //    .Where(c => c.City == "Washington" || c.Region == "WA" || c.Country == "USA")
            //    .SelectMany(c => c.Orders)
            //    .Take(3);

            //foreach (var order in result)
            //{
            //    Console.WriteLine($" - OrderID: {order.OrderID}, Date: {order.OrderDate}");
            //}

            #endregion
            #region 2. Get all but the first 2 orders from customers in Washington
            //var allButFirst2Orders = ListGenerator.CustomerList
            //    .Where(c => c.City == "Washington" || c.Region == "WA" || c.Country == "USA")
            //    .SelectMany(c => c.Orders)
            //    .Skip(2);

            //foreach (var order in allButFirst2Orders)
            //{
            //    Console.WriteLine($" - OrderID: {order.OrderID}, Date: {order.OrderDate}");
            //}
            #endregion
            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result3 = numbers
            //    .TakeWhile((num, index) => num >= index);

            //foreach (var n in result3)
            //{
            //    Console.WriteLine($" - {n}");
            //}
            #endregion
            #region 4. Get the elements of the array starting from the first element divisible by 3
            //int[] numbers4 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result4 = numbers4
            //    .SkipWhile(n => n % 3 != 0);

            //foreach (var n in result4)
            //{
            //    Console.WriteLine($" - {n}");
            //}

            #endregion
            #region 5. Get the elements of the array starting from the first element less than its position
            //int[] numbers5 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result5 = numbers5
            //    .SkipWhile((num, index) => num >= index);

            //foreach (var n in result5)
            //{
            //    Console.WriteLine($" - {n}");
            //}
            #endregion

            #endregion

            #region LINQ - Quantifiers

            #region 1. Determine if any of the words in dictionary_english.txt contain the substring "ei"
            #endregion


            #region 2. Return a grouped list of products only for categories that have at least one product that is out of stock
            //var Result = ListGenerator.ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.Any(p => p.UnitsInStock == 0))   
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        Products = g.ToList()
            //    });

            //foreach (var group in Result)
            //{
            //    Console.WriteLine($"Category: {group.Category}");
            //    foreach (var p in group.Products)
            //    {
            //        Console.WriteLine($"   - {p.ProductName} (Stock: {p.UnitsInStock})");
            //    }
            //}
            #endregion


            #region 3. Return a grouped list of products only for categories that have all of their products in stock
            //var categoriesAllInStock = ListGenerator.ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.All(p => p.UnitsInStock > 0))   // all products in stock
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        Products = g.ToList()
            //    });

            //Console.WriteLine("\nCategories with all products in stock:");
            //foreach (var group in categoriesAllInStock)
            //{
            //    Console.WriteLine($"Category: {group.Category}");
            //    foreach (var p in group.Products)
            //    {
            //        Console.WriteLine($"   - {p.ProductName} (Stock: {p.UnitsInStock})");
            //    }
            //}
            #endregion


            #endregion

            #region LINQ – Grouping Operators

            #region 1. Group numbers by remainder when divided by 5
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var groups = numbers.GroupBy(n => n % 5);

            //foreach (var g in groups)
            //{
            //    Console.WriteLine($"Numbers with a remainder of {g.Key} when divided by 5:");
            //    foreach (var n in g)
            //    {
            //        Console.WriteLine($" {n}");
            //    }
            //}
            #endregion

            #region 2. Group dictionary words by first letter
            #endregion

            #region 3. Group words that consist of the same characters
            //string[] arr = { "from", "salt", "earn", "last", "near", "form" };

            //var anagramGroups = arr.GroupBy(w => String.Concat(w.OrderBy(c => c)));

            //foreach (var g in anagramGroups)
            //{
            //    Console.WriteLine($".....");
            //    foreach (var w in g)
            //    {
            //        Console.WriteLine($" {w}");
            //    }
            //}
            #endregion



            #endregion
        }
    }
}
