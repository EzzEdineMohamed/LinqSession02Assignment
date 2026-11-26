namespace Linq_S2
{
    using static LINQ.DataSources.Source;

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Get top 3 most expensive products

            //var result = ProductList
            //    .OrderByDescending(p => p.UnitPrice)
            //    .Take(3);

            //foreach (var p in result)
            //{
            //    Console.WriteLine($"{p.ProductID} - {p.ProductName} - {p.UnitPrice:C}");
            //}

            #endregion

            #region 2. Show page 2 of products, page size = 5

            //var result = ProductList
            //    .Skip(5)
            //    .Take(5);

            //foreach (var p in result)
            //{
            //    Console.WriteLine($"{p.ProductID} - {p.ProductName} - {p.UnitPrice:C}");
            //}

            #endregion

            #region 3. Take products while UnitPrice is less than $25

            //var result = ProductList
            //    .OrderBy(p => p.UnitPrice)
            //    .TakeWhile(p => p.UnitPrice < 25);

            //foreach (var p in result)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice:C}");
            //}

            #endregion

            #region 4. Check if ALL Seafood products are in stock

            //var result = ProductList
            //    .Where(p => p.Category == "Seafood")
            //    .All(p => p.UnitsInStock > 0);

            //Console.WriteLine($"All Seafood products in stock: {result}");

            #endregion

            #region 5. Check if IDs contain 9

             //var result = ProductList.Select(p => p.ProductID).Contains(9);

             //Console.WriteLine($"IDs contain 9: {result}");

            #endregion

            #region 6. Group products by Category and print count

            //var result = ProductList
            //    .GroupBy(p => p.Category);

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"{group.Key}: {group.Count()}");
            //}

            #endregion

            #region 7. Group products by Category and select product names

            //var result = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        Products = g.Select(p => p.ProductName)
            //    });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category}: {string.Join(", ", item.Products)}");
            //}

            #endregion

            #region 8. Find categories that have more than 3 products

            //var result = ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.Count() > 3);

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"{group.Key}: {group.Count()} products");
            //}

            #endregion

            #region 9. Group customers by Country using Query Syntax

            //var result =
            //    from c in CustomerList
            //    group c by c.Country into g
            //    select new
            //    {
            //        Country = g.Key,
            //        Count = g.Count(),
            //        TotalOrderValue = g
            //            .SelectMany(c => c.Orders)
            //            .SelectMany(o => o.OrderDetails)
            //            .Sum(od => od.UnitPrice * od.Quantity * (1 - od.Discount))
            //    };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Country} - Customers: {item.Count} - Total: {item.TotalOrderValue:C}");
            //}

            #endregion

            #region 10. Calculate total units in stock

            //var result = ProductList
            //    .Sum(p => p.UnitsInStock);

            //Console.WriteLine($"Total units in stock: {result}");

            #endregion

            #region 11. Find cheapest and most expensive prices

            //var result = new
            //{
            //    Cheapest = ProductList.Min(p => p.UnitPrice),
            //    MostExpensive = ProductList.Max(p => p.UnitPrice)
            //};

            //Console.WriteLine($"Cheapest: {result.Cheapest:C}");
            //Console.WriteLine($"Most expensive: {result.MostExpensive:C}");

            #endregion

            #region 12. Get distinct product categories

            //var result = ProductList
            //    .Select(p => p.Category)
            //    .Distinct();

            //foreach (var category in result)
            //{
            //    Console.WriteLine(category);
            //}

            #endregion

            #region 13. Find IDs in setA but NOT in setB

            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result = setA.Except(setB);

            //Console.WriteLine(string.Join(", ", result));

            #endregion

            #region 14. Find countries in list1 but NOT in list2 (case-insensitive)

            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

            //Console.WriteLine(string.Join(", ", result));

            #endregion

            #region 15. Build Dictionary keyed by ProductID and get product ID = 18

            //var result = ProductList
            //    .ToDictionary(p => p.ProductID);

            //if (result.TryGetValue(18, out var product))
            //{
            //    Console.WriteLine($"{product.ProductID} - {product.ProductName} - {product.UnitPrice:C}");
            //}
            //else
            //{
            //    Console.WriteLine("Product 18 not found");
            //}

            #endregion

            #region 16. Get first product with price greater than $50

            //var result = ProductList
            //    .First(p => p.UnitPrice > 50);

            //Console.WriteLine($"{result.ProductName} - {result.UnitPrice:C}");

            #endregion

            #region 17. Get first product with price greater than $500 or null

            //var result = ProductList
            //    .FirstOrDefault(p => p.UnitPrice > 500);

            //Console.WriteLine(result?.ProductName ?? "No product found");

            #endregion

            #region 18. Generate multiplication table row for 7

            //var result = Enumerable.Range(1, 10)
            //    .Select(n => $"7 x {n} = {7 * n}");

            //foreach (var line in result)
            //{
            //    Console.WriteLine(line);
            //}

            #endregion

            #region 19. Generate even numbers between 1 and 30

            //var result = Enumerable.Range(1, 30)
            //    .Where(n => n % 2 == 0);

            //Console.WriteLine(string.Join(", ", result));

            #endregion

            #region 20. Concatenate first 3 product names with first 3 customer company names

            //var result = ProductList
            //    .Take(3)
            //    .Select(p => p.ProductName)
            //    .Concat(
            //        CustomerList
            //            .Take(3)
            //            .Select(c => c.CompanyName)
            //    );

            //foreach (var name in result)
            //{
            //    Console.WriteLine(name);
            //}

            #endregion

            #region 21. Pair each product with a customer by position

            //var result = ProductList
            //    .Zip(CustomerList, (p, c) => $"{p.ProductName} sold to {c.CompanyName}");

            //foreach (var line in result)
            //{
            //    Console.WriteLine(line);
            //}

            #endregion
        }
    }
}
