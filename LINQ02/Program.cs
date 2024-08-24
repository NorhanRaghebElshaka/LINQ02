

internal class Program
{
    static void Main(string[] args)
    {

        //     //   linq - Restriction

        //      //  1
        //        var Result = ProductsList.Where(x => x.UnitsInStock == 0);

        //        foreach (var product in Result)
        //        {
        //            Console.WriteLine(product.ProductName);
        //        }

        //      //  2
        //        var Result = ProductsList.Where(x => x.UnitPrice > 3.00M);

        //        foreach (var product in Result)
        //        {
        //            Console.WriteLine(product.ProductName);
        //        }

        //      //  3
        //        String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        //        var result = Arr
        //         .Select((name, index) => new { Name = name, Index = index })
        //         .Where(x => x.Name.Length < x.Index)
        //         .Select(x => x.Index);

        //        foreach (var p in result)
        //        {
        //            Console.WriteLine(p);
        //        }

        //       // --------------------------------------------------

        //       // LINQ - Element Operators
        //      //  1
        //         ProductsList.FirstOrDefault(new Productslist() { ProductID = 1, ProductName = "Default Product" });

        //       // 2
        //         ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);

        //      //  3
        //        int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //        Array.Sort(Arr);

        //        var Number = Arr
        //        .Where(x => x > 5).FirstOrDefault();

        //        Console.WriteLine(Number);

        //       // --------------------------------------------------
        //       // LINQ - Aggregate Operators
        ////
        //       // 1
        //        int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //        var count = Arr.Count(a => a % 2 != 0);
        //        Console.WriteLine(count);

        //       // 2
        //        var customersOrderCount = CustomersList
        //           .Select(c => new
        //           {
        //               c.CustomerName,
        //               OrdersCount = c.Orders.Count()
        //           })
        //           .ToList();

        //        foreach (var customer in customersOrderCount)
        //        {
        //            Console.WriteLine($"Customer: {customer.CustomerName}, Orders Count: {customer.OrdersCount}");
        //        }

        //      //  3
        //        var categoriesProductCount = ProductsList
        //          .GroupBy(p => p.Category)
        //          .Select(g => new
        //          {
        //              Category = g.Key,
        //              ProductsCount = g.Count()
        //          })
        //          .ToList();

        //        foreach (var category in categoriesProductCount)
        //        {
        //            Console.WriteLine($"Category: {category.Category}, Products Count: {category.ProductsCount}");
        //        }

        //      //  4
        //        int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //        var result = Arr.Sum();
        //        Console.WriteLine(result);

        //// 5
        //  string[] words = File.ReadAllLines("dictionary_english.txt");
        // var result = words.Sum(word => word.Length);
        // Console.WriteLine(result);

        //     //   6
        //        string[] words = File.ReadAllLines("dictionary_english.txt");
        //        var result = words.Min(word => word.Length);
        //        Console.WriteLine(result);

        //      //  7
        //        string[] words = File.ReadAllLines("dictionary_english.txt");
        //        var result = words.Max(word => word.Length);
        //        Console.WriteLine(result);

        //      //  8
        //        string[] words = File.ReadAllLines("dictionary_english.txt");
        //        var result = words.Average(word => word.Length);
        //        Console.WriteLine(result);

        //     //   9
        //        var result = ProductsList
        //           .GroupBy(p => p.Category)
        //           .Select(g => new
        //           {
        //               Category = g.Key,
        //               TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
        //           });

        //        foreach (var category in result)
        //        {
        //            Console.WriteLine($"Category: {category.Category}, Total Units in Stock: {category.TotalUnitsInStock}");
        //        }

        //      //  10
        //        var result = ProductsList
        //           .GroupBy(p => p.Category)
        //           .Select(g => new
        //           {
        //               Category = g.Key,
        //               TotalUnitsInStock = g.Min(p => p.UnitsInStock)
        //           });

        //        foreach (var category in result)
        //        {
        //            Console.WriteLine($"Category: {category.Category}, Cheap Units in Stock: {category.TotalUnitsInStock}");
        //        }

        //      //  11
        //        var result = ProductsList
        //            .GroupBy(p => p.Category)
        //            .Select(g => new
        //            {
        //                Category = g.Key,
        //                CheapestPrice = g.Min(p => p.UnitPrice),
        //                Products = g.Where(p => p.UnitPrice == g.Min(p2 => p2.UnitPrice))
        //            });

        //        foreach (var category in result)
        //        {
        //            Console.WriteLine($"Category: {category.Category}");
        //            foreach (var product in category.Products)
        //            {
        //                Console.WriteLine($"  Product: {product.ProductName}, Price: {product.UnitPrice}");
        //            }
        //        }

        //       // 12
        //var result = ListGenerator.ProductsList
        //    .GroupBy(p => p.Category)
        //    .Select(g => new
        //    {
        //        Category = g.Key,
        //        MostExpensivePrice = g.Max(p => p.UnitPrice)
        //    });


        //        foreach (var category in result)
        //        {
        //            Console.WriteLine($"Category: {category.Category}, Most Expensive Price: {category.MostExpensivePrice}");
        //        }

        //      //  13
        //var result = ListGenerator.ProductsList
        //    .GroupBy(p => p.Category)
        //    .Select(g => new
        //    {
        //        Category = g.Key,
        //        MostExpensivePrice = g.Max(p => p.UnitPrice),
        //        Products = g.Where(p => p.UnitPrice == g.Max(p2 => p2.UnitPrice)).ToList()
        //    });


        //        foreach (var category in result)
        //        {
        //            Console.WriteLine($"Category: {category.Category}");
        //            foreach (var product in category.Products)
        //            {
        //                Console.WriteLine($"  Product: {product.ProductName}, Price: {product.UnitPrice}");
        //            }
        //        }

        //       // 14
        //        var result = ListGenerator.ProductsList
        //            .GroupBy(p => p.Category)
        //            .Select(g => new
        //            {
        //                Category = g.Key,
        //                AveragePrice = g.Average(p => p.UnitPrice)
        //            });


        //        foreach (var category in result)
        //        {
        //            Console.WriteLine($"Category: {category.Category}, Average Price: {category.AveragePrice}");
        //        }

        //     //   ------------------------------
        //       //  LINQ - Ordering Operators

        //      //  1
        //         var result = ProductsList.OrderBy(p => p.ProductName);

        //     //   2
        //        var arr = new string[] { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        //        var result = arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);
        //        foreach (var item in result)
        //        {
        //            Console.WriteLine(item);
        //        }

        //     //   3
        //         var result = ProductsList.OrderByDescending(p => p.UnitsInStock);

        //     //   4
        //        var arr = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        //        var result = arr.OrderBy(word => word.Length).ThenBy(word => word);

        //       // 5
        //        var arr = new string[] { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        //        var resultresult = arr.OrderBy(word => word.Length).ThenBy(word => word, StringComparer.OrdinalIgnoreCase);
        ////
        //        //6
        //         var result = ProductsList
        //        .OrderBy(p => p.Category)
        //        .ThenByDescending(p => p.UnitPrice);

        //       // 7
        //        var arr = new string[] { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        //        var RESULT = arr
        //            .OrderBy(word => word.Length)
        //            .ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase);


        //      //  8
        //        var arr = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        //        var result = arr
        //            .Where(word => word.Length > 1 && word[1] == 'i')
        //            .Reverse();


        //      //  ------------------------------------------
        //       // LINQ – Transformation Operators

        //       // 1
        //         var productNames = ProductsList.Select(p => p.ProductName);

        //       // 2
        //        var words = new string[] { "aPPLE", "BlUeBeRrY", "cHeRry" };
        //        var RESULT = words.Select(word => new
        //        {
        //            Original = word,
        //            Uppercase = word.ToUpper(),
        //            Lowercase = word.ToLower()
        //        });

        //       // 3
        //        var Result = ProductsList.Select(p => new
        //        {
        //            p.ProductName,
        //            p.Category,
        //            Price = p.UnitPrice
        //        });

        //      //  4
        //        var arr = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //        var result = arr.Select((value, index) => new { Value = value, Index = index })
        //                        .Any(x => x.Value == x.Index);

        //      //  5
        //        int[] numA = { 0, 2, 4, 5, 6, 8, 9 };
        //        int[] numB = { 1, 3, 5, 7, 8 };
        //        var result = numA.SelectMany(a => numB.Where(b => a < b), (a, b) => new { A = a, B = b });


        //       // 6
        //        var result = CustomersList
        //            .SelectMany(c => c.Orders)
        //            .Where(o => o.Total < 500.00M);

        //        foreach (var order in result)
        //        {
        //            Console.WriteLine(order);
        //        }

        //       // 7
        //        var result = CustomersList
        //          .SelectMany(c => c.Orders)
        //           .Where(o => o.OrderDate.Year >= 1998);

        //        foreach (var order in result)
        //        {
        //            Console.WriteLine(order);
        //        }

        //       // -------------------------------
        //        //LINQ - Set Operators

        //      //  1
        //         var result = ProductsList.Select(p => p.Category).Distinct();


        //        //2
        //        var productFirstLetters = ProductsList.Select(p => p.ProductName[0]);
        //        var customerFirstLetters = CustomersList.Select(c => c.CustomerName[0]);
        //        var result = productFirstLetters.Union(customerFirstLetters);


        //       // 3
        //         var result = productFirstLetters.Intersect(customerFirstLetters);


        //       // 4
        //         var result = productFirstLetters.Except(customerFirstLetters);
        ////
        //        //5
        //        var productLastThree = ProductsList.Select(p => p.ProductName.Substring(Math.Max(0, p.ProductName.Length - 3)));
        //        var customerLastThree = CustomersList.Select(c => c.CustomerName.Substring(Math.Max(0, c.CustomerName.Length - 3)));
        //        var result = productLastThree.Concat(customerLastThree);


        //      //  ----------------------------------
        //      //   LINQ - Partitioning Operators

        //       // 1
        //        var result = CustomersList
        //        .Where(o => o.CustomerName == "WA")
        //        .Take(3);

        //       // 2
        //        var result = CustomersList
        //        .Where(o => o.CustomerName == "WA")
        //        .Skip(2);

        //     //   3
        //        var numbers = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //        var result = numbers.TakeWhile((value, index) => value >= index);

        //       // 4
        //          var result = numbers.SkipWhile(value => value % 3 != 0);

        //        //5
        //         var result = numbers.SkipWhile((value, index) => value >= index);

        //     //   --------------------------------

        //       //  LINQ - Quantifiers

        //       // 1
        //        var words = File.ReadAllLines("dictionary_english.txt");
        //        bool result = words.Any(word => word.Contains("ei"));


        //      //  2
        //        var outOfStockCategories = ProductsList
        //          .Where(p => p.UnitsInStock == 0)
        //          .GroupBy(p => p.Category);


        //       // 3
        //         var groupedProductsInStock = ProductsList
        //        .GroupBy(p => p.Category)
        //        .Where(g => g.All(p => p.UnitsInStock > 0));


        //        foreach (var group in groupedProductsInStock)
        //        {
        //            Console.WriteLine($"Category: {group.Key}");
        //            foreach (var product in group)
        //            {
        //                Console.WriteLine(product.ProductName);
        //            }
        //        }

        //      //  ---------------------------------

        //     //   LINQ – Grouping Operators

        //       // 1
        //        List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        //        var result = numbers
        //            .GroupBy(n => n % 5);
        //        int count = 0;
        //        foreach (var group in result)
        //        {
        //            Console.WriteLine($"Number With Aremainder of{count++}  When divided by 5 : \n {group.Key} : {string.Join(", ", group)} \n ");
        //        }


        //      //  2
        //        var words = File.ReadAllLines("dictionary_english.txt");

        //        var result = words.GroupBy(w => w[0]);

        //        foreach (var group in result)
        //        {
        //            Console.WriteLine($"First letter '{group.Key}': {string.Join(", ", group)}");
        //        }

        //       // 3
        //        string[] arr = { "from", "salt", "earn", "last", "near", "form" };

        //        var result = arr.GroupBy(w => w, new CustomComparer());

        //        foreach (var group in result)
        //        {
        //            Console.WriteLine($"{string.Join(", ", group)} \n");
        //        }

    }
}