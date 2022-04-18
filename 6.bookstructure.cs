using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.bookstructure
{
    internal class Program
    {
        struct Books
        {
            private int book_id;
            private string title;
            private int price;

            public void display()
            {
                Console.WriteLine("BookId:", book_id);
                Console.ReadLine();
                Console.WriteLine("Title:", title);
                Console.ReadLine();
                Console.WriteLine("Price:", price);
                Console.ReadLine();

            }
        }
        public class testStructure
        {
            enum bookType { Magazine, Novel, ReferenceBook, Miscellaneous };
            static void Main(string[] args)
            {

                Books b1 = new Books();
                Books b2 = new Books();

                b1.display();
                string Type1 = string.Format("Magazine");
                Console.WriteLine("Magazine", Type1);
                b2.display();
                string Type2 = string.Format("ReferenceBook");
                Console.WriteLine("ReferenceBook", Type2);
                Console.ReadKey();
            }
        }
    }

}
