using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izvp_pr_3_4
{
    public class Book
    {
        private string title;
        private string author;
        private string publisher;

        public Book(string title, string author, string publisher)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
        }

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
    }
}
