using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Dany!");
            Book book = new Book("Deat Dusha", "Tolstoy");
            Console.WriteLine(book.Author + " " + book.Name);

            int result = book.Sum(10, 10);
            Console.Write("\n\n sum = " + result);
        }
    }
}
