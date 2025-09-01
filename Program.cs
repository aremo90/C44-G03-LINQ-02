using ConsoleApp1.Data;
using System.Collections;

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
        }
    }
}
