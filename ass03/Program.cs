using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ass03
{
    internal class Program
    {
        //static void PrintWelcomeMessage() 
        //{
        //    Console.WriteLine("Welcome to the Library!");
        //}

        //static void PrintBookTitle(string title) 
        //{ 
        //  if(title!=null)
        //        Console.WriteLine("Book title: " + title);
        //}

        //static int AddBonusPages(int pages) 
        //{
        //    pages += 50;
        //    return pages;

        //}

        //static void ApplyDiscount(double[] prices) 
        //{
        //    prices[0] -= 5;
        //}

        static int AddBonusPagesref(ref int pages)
        {
            pages += 50;
            return pages;
        }
        static void Main(string[] args)
        {
            #region question 1
            //Create a one  dimensional array double[] 
            //prices with the values 25.5, 40.0, 33.75.Print the second price(index 1)
            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]); 
            #endregion

            #region question 2
            //Create a 2x2 multidimensional array int[,] shelfCopies 
            //where shelf 0 has 3, 5 copies and shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            //int[,] shelfCopies = { {3,5 }, {1,4 } };
            //Console.WriteLine(shelfCopies[1,0]);
            #endregion

            #region question 3
            //Write a method called PrintWelcomeMessage that takes no parameters
            // and prints "Welcome to the Library!".Call it from Main.
            //PrintWelcomeMessage();
            #endregion

            #region question 4
            //Write a method PrintBookTitle(string title) that prints "Book title: " + title.Call it with "Clean Code".
            //string title = "clean code";
            //PrintBookTitle(title);
            #endregion

            #region question 5
            //Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable int pages = 400; and
            //print pages afterward. What do you expect to see, and why?
            //int pages = 400;
            //Console.WriteLine(pages);
            //AddBonusPages(pages);
            //Console.WriteLine(pages);
            // pages still 400 because we call it value type parameters
            #endregion

            #region question 6
            //Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0].Call it with double[] prices = { 25.5, 40.0 }; 
            //and print prices[0] afterward.What do you expect to see, and why? 
            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine($"prices[0] afterward: {prices[0]}");
            // prices[0] will change because tha reference type parameters
            #endregion

            #region question 7
            //Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref. Call it and print pages afterward.
            //    How is the result different from question 5 ?
            int pages = 400;
            Console.WriteLine(pages);
            AddBonusPagesref(ref pages);
            Console.WriteLine($" pages afterward :{pages}");
            // pages will change beacause we passing parameter by reference 
            #endregion

        }
    }
}
