using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithGit
{
    class Book
    {
        
        public Book(string Name,string Author)
        {
            this._name = Name;
            this._author = Author;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
        public string Author
        {
            get
            {
                return _author;
            }
        }
        
        public int Sum(int a,int b)
        {
            return a + b;
        }

        private string _name;
        private string _author;
    }
}
