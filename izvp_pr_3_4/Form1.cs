using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace izvp_pr_3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Book> books = new List<Book>();

        private void Form1_Load(object sender, EventArgs e)
        {
            books.Add(new Book("book1","Дмитро","a"));
            books.Add(new Book("abrakadabra", "Сігов", "b"));
            books.Add(new Book("padada", "Sihov", "c"));
            books.Add(new Book("dsczv", "Dmytro", "d"));
            books.Add(new Book("poweif", "YA", "e"));
            books.Add(new Book("книга", "DBasda", "f"));
            books.Add(new Book("книгуля", "author2", "g"));
            books.Add(new Book("вфыв", "Дмитрик", "h"));
            foreach (Book book in books)
            {
                dataGridView1.Rows.Add(book.Title, book.Author, book.Publisher);
            }

        }
        delegate List<Book> sortedBooks(List<Book> books);
        private static List<Book> sortByTitle(List<Book> books)
        {
            books.Sort((x,y) => x.Title.CompareTo(y.Title));
            return books;
        }
        private static List<Book> sortByAuthor(List<Book> books)
        {
            books.Sort((x, y) => x.Author.CompareTo(y.Author));
            return books;
        }
        private static List<Book> sortByPublisher(List<Book> books)
        {
            books.Sort((x, y) => x.Publisher.CompareTo(y.Publisher));
            return books;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            sortedBooks sb = null;
            if(radioButton1.Checked)
            {
                Console.WriteLine("by title");
                sb = new sortedBooks(sortByTitle);
            }
            else if (radioButton2.Checked)
            {
                sb = new sortedBooks(sortByPublisher);
                Console.WriteLine("by publisher");
            }
            else if (radioButton3.Checked)
            {
                sb = new sortedBooks(sortByAuthor);
                Console.WriteLine("by author");
            }
            books = sb(books);
            foreach(Book book in books)
            {
                dataGridView1.Rows.Add(book.Title,book.Author,book.Publisher);
            }
        }
    }
}
