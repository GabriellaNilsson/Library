using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book
    {
        public string _Title;
        public string _Author;
        public string _Summary;

        public Book (string title, string author, string summary)
        {
            _Title = title;
            _Author = author;
            _Summary = summary;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Title of book: " + _Title);
            Console.WriteLine("Author of book: " + _Author);
            Console.WriteLine("Summary of book: "+ _Summary);
        }


    }
}
