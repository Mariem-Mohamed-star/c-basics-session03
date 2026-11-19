using System.Text;
using static System.Net.WebRequestMethods;

namespace Basics_Session03;
class program
{
    static void Main()
    {
        //#region part 1
        //string title = "clean code";
        //string upperTitle=title.ToUpper();
        //Console.WriteLine($"title: {title} , upperTitle: {upperTitle}");
        //#endregion

        //#region part 2
        //string st1 = "Clean Code", st2= "Clean Code";
        //if(ReferenceEquals(st1, st2)) { Console.WriteLine("Yes"); }
        //else { Console.WriteLine("No"); }
        //#endregion

        //#region part 3
        //StringBuilder sb= new StringBuilder() ;
        //sb.Append("Book List");
        //sb.Append(" - Updated");
        //Console.WriteLine(sb);
        //#endregion

        //#region part 4
        //StringBuilder sb = new StringBuilder();
        //sb.Append("Book List");
        //sb.Append(" - Updated");
        //sb.Replace("Book List", "Library");
        //Console.WriteLine(sb);
        //#endregion

        //#region part 5
        //string title = "Clean Code"; int pages = 464;
        //string result = "Book:" + title + ',' + "Pages:" + pages;
        //Console.WriteLine(result);
        //#endregion

        //#region part 6
        //string title = "Clean Code"; int pages = 464;
        //string result = $"Book:{title},Pages:{pages}";
        //Console.WriteLine(result);
        //#endregion

        //#region part 7
        //string title = "Clean Code"; int pages = 464;
        //string result = string.Format($"Book:{title},Pages:{pages:D6}");
        //Console.WriteLine(result);
        //#endregion

        //#region part 8
        //int pages = 464;
        //if (pages > 300) Console.WriteLine("Long Book");
        //else Console.WriteLine("Short Book");
        //#endregion

        //#region part 9
        //int pages = 464; bool isAvailable = true;
        //if (pages > 300 && isAvailable == true) Console.WriteLine("You can borrow this book");
        ////#endregion

        //#region part 10
        //string title = "Refactoring";

        //switch (title)
        //{
        //    case "Clean Code":
        //        Console.WriteLine("Great choice!");
        //        break;
        //    case "Refactoring":
        //        Console.WriteLine("Nice pick!");
        //        break;
        //    default:
        //        Console.WriteLine("Never heard of it");
        //        break;
        //}
        //#endregion

        //#region part 11
        //int pages = 464;
        //string result = pages > 300 ? "Long Book" : "Short Book";
        //Console.WriteLine(result);
        //#endregion

        //#region part 12
        //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        //for(int i = 0; i < books.Length; i++)
        //{
        //    Console.WriteLine($"Index: {i}, Book: {books[i]}");
        //}
        //#endregion

        //#region part 13
        //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        //int i = 0;
        //while ( i < books.Length)
        //{
        //    Console.WriteLine($"Book: {books[i++]}");
        //}
        //#endregion

        //#region part 14
        //int i = 0;
        //do
        //{
        //    Console.WriteLine("Checking book...");
        //    i++;
        //} while (i < 3);
        //#endregion

        //#region part 15
        //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        //foreach (var i in books)
        //{
        //    Console.WriteLine($"Book: {i}");
        //}
        //#endregion

        //#region part 16
        //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        //foreach (var i in books)
        //{
        //    if (i == "Refactoring") break; //no need "Refactoring" is already at the end of the array
        //    Console.WriteLine($"Book: {i}");
        //}
        //#endregion

        //#region part 17
        //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        //foreach (var i in books)
        //{
        //    if (i == "The Pragmatic Programmer") continue;
        //    Console.WriteLine($"Book: {i}");
        //}
        //#endregion

        #region part 18
        string[] books1 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        string[] books2 = {};
        PrintFirstBook(books2);
        #endregion
    }
    static void PrintFirstBook(string[] books)
    {
        if (books.Length == 0) return;
        Console.WriteLine(books[0]);
    }
}
