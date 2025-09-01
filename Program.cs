using ConsoleApp1.Data;
using System.Collections;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Casting Operators

            // Immediate Execution

            #region Get proudcut out of stock

            //List<Product> Result = ListGenerator.ProductList.Where(p => p.UnitsInStock == 0).ToList();

            //Product[] Result = ListGenerator.ProductList.Where(p => p.UnitsInStock == 0).ToArray();

            //Dictionary<long , Product> Result = ListGenerator.ProductList.Where(p => p.UnitsInStock == 0).ToDictionary(p => p.ProductID);

            //Dictionary<long , string> Result = ListGenerator.ProductList.Where(p => p.UnitsInStock == 0).ToDictionary(p => p.ProductID , p => p.ProductName);

            //HashSet<Product> Result = ListGenerator.ProductList.Where(p => p.UnitsInStock == 0).ToHashSet();

            //ArrayList obj = new ArrayList
            //{
            //    "Ahmed",
            //    "Hamza",
            //    "Sayed",
            //    1,
            //    2,
            //    3
            //};

            //var Result = obj.OfType<string>();

            //foreach (var product in Result)
            //    Console.WriteLine(product);


            #endregion

            #endregion

            #region Generating Operators

            // Deferred Execution

            // vaild only with fluent syntax

            // call Generation operators from class Enumerable ONLY 

            //var Restult = Enumerable.Range(1, 10);

            //var Result = Enumerable.Repeat("Hello", 10);

            //var List = Enumerable.Empty<Product>();

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region Set Operators

            // Deferred Execution

            //var sequence1 = Enumerable.Range(10, 100);// % 10 - 109
            //var sequence2 = Enumerable.Range(60, 100);// % 60 - 159


            //var Result = sequence1.Union(sequence2);      => remove duplicates

            //var Result = sequence1.Concat(sequence2);     => retain duplicates

            //var Result = sequence1.Intersect(sequence2);  =>  retain only duplicates

            //var Result = sequence1.Except(sequence2);     => remove duplicates

            //var dis = Result.Distinct();                  => remove duplicates from single sequence

            //foreach (var item in Result)
            //    Console.WriteLine(item);
            #endregion

            #region Quantifier Operators

            // Deferred Execution

            //var Result = ListGenerator.ProductList.All(p => p.UnitsInStock > 0); // AND
            //var Result = ListGenerator.ProductList.Any(p => p.UnitsInStock > 0); // OR
            //var Result = ListGenerator.ProductList.SequenceEqual(ListGenerator.ProductList2); // Compare two sequences
            //var sequence1 = Enumerable.Range(10, 100);// % 10 - 109
            //var sequence2 = Enumerable.Range(60, 100);// % 60 - 159
            //var Result = sequence1.SequenceEqual(sequence2); // Compare two sequences

            //Console.WriteLine(Result);

            #endregion

            #region Zipping Operators

            // Deferred Execution

            //string[] Names = { "Ahmed", "Ali", "Sayed" , "Omar"};
            //int[]    Ages  = Enumerable.Range(1, 10).ToArray();
            //char[] Chars = { 'A', 'B', 'C', 'D'};

            //var Result = Names.Zip(Chars);

            //var Result = Names.Zip(Ages, Chars);


            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region Grouping Operators

            // Deferred Execution
            // GroupBy

            #region

            //var Result = ListGenerator.ProductList.GroupBy(p => p.Category);

            //foreach(var group in Result)
            //    {
            //        Console.WriteLine($"Category : {group.Key} - Count : {group.Count()}");
            //        foreach (var product in group)
            //            Console.WriteLine($"\t{product.ProductName}");
            //}


            #endregion

            #region Get Products That is Out of stock grouped by Category

            //var Result = ListGenerator.ProductList
            //                          .Where(p => p.UnitsInStock == 0)
            //                          .GroupBy(p => p.Category);



            #endregion


            #region get Product in stock grouped by Category that contain more than 10 products

            //var Result = ListGenerator.ProductList
            //                          .Where(p => p.UnitsInStock > 0)
            //                          .GroupBy(p => p.Category)
            //                          .Where(g => g.Count() > 10);

            #endregion

            #region 

            //var Result = ListGenerator.ProductList
            //                          .Where(p => p.UnitsInStock > 0)
            //                          .GroupBy(p => p.Category)
            //                          .Where(g => g.Count() > 10)
            //                          .Select(X => new 
            //                          {
            //                            CategoreyName = X.Key,
            //                            CountOfProuct = X.Count(),
            //                          });

            //foreach (var group in Result)
            //{
            //    Console.WriteLine($"Category : {group.CategoreyName} - Count : {group.CountOfProuct}");
            //}

            #endregion


            //foreach (var group in Result)
            //{
            //        Console.WriteLine($"Category : {group.Key} - Count : {group.Count()}");
            //        foreach (var product in group)
            //            Console.WriteLine($"\t{product.ProductName}");
            //}

            #endregion

            #region Partitioning Operators

            //var Result = ListGenerator.ProductList.Where(p => p.UnitsInStock == 0).Take(20);
            //var Result = ListGenerator.ProductList.Skip(20);
            //var Result = ListGenerator.ProductList.Skip(10).Take(10);

            //var Result = ListGenerator.ProductList.TakeLast(10);
            //var Result = ListGenerator.ProductList.SkipLast(10);

            //var page01 = ListGenerator.ProductList.Skip(0).Take(10);
            //var page02 = ListGenerator.ProductList.Skip(10).Take(10);
            //var page03 = ListGenerator.ProductList.Skip(20).Take(10);

            //Console.WriteLine("======================== Page01 =================");
            //foreach (var product in page01)
            //    Console.WriteLine(product.ProductName);

            //Console.WriteLine("======================== Page02 =================");
            //foreach (var product in page02)
            //    Console.WriteLine(product.ProductName);

            //Console.WriteLine("======================== Page03 =================");
            //foreach (var product in page02)
            //    Console.WriteLine(product.ProductName);

            //int[] Numbers = { 5,3,4,6,1,3,8,9 };

            //var Result = Numbers.TakeWhile((n, index) => n > index);
            //var Result = Numbers.SkipWhile((n, index) => n > index);
            //foreach (var number in Result)
            //    Console.WriteLine(number);



            #endregion

            #region Let & Into Keywords

            //List<string> Names = new List<string>
            //{
            //    "Ahmed",
            //    "Ali",
            //    "Sayed",
            //    "Omar",
            //    "Mahmoud",
            //    "Ayman",
            //    "Hossam"
            //};
            // remove vowel Chars

            //var Result = from n in Names
            //             select Regex.Replace(n, "[aeiouAEIOU]", string.Empty )
            //             into nameWithoutVowel
            //                where nameWithoutVowel.Length > 3
            //                select nameWithoutVowel;
            //var Result = from n in Names
            //             let nameWithoutVowel = Regex.Replace(n, "[aeiouAEIOU]", string.Empty )
            //             where nameWithoutVowel.Length > 3
            //             select nameWithoutVowel;

            //foreach (var name in Result)
            //    Console.WriteLine(name);

            #endregion

        }
    }
}
