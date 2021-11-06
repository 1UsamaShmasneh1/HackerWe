using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HackerWe.Entities;
using HackerWeLogic;

namespace HackerWeUi
{
    public partial class BooksUserControle : UserControl
    {
        Book book;
        public event Action<Book> BookSaved;
        public BooksUserControle()
        {
            InitializeComponent();
        }

        private void BooksUserControle_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            //reset fields
            book = new Book();
            BookIdMessageLabel.Text = "";
            BookIdTextBox.Text = String.Empty;
            BookNameTextBox.Text = String.Empty;
            AuthorNameTextBox.Text = String.Empty;
            DatePublishedDateTimePicker.Value = DateTime.Now;
            NumberOfPagesTextBox.Text = String.Empty;
            NumberOfCopiesTextBox.Text = String.Empty;
        }

        private void SaveBookButton_Click(object sender, EventArgs e)
        {
            if (BookIdTextBox.Text == String.Empty)
            {
                BookIdMessageLabel.Text = "Tis is must";
                return;
            }
            
            book.Id = int.Parse(BookIdTextBox.Text);
            book.Name = BookNameTextBox.Text;
            book.Author = AuthorNameTextBox.Text;
            book.DatePublished = DatePublishedDateTimePicker.Value;
            book.NumberOfPages = short.Parse(NumberOfPagesTextBox.Text);
            book.NumberOfCopies = short.Parse(NumberOfCopiesTextBox.Text);
            Library.Books.Add(book);
            Library.SaveBooksJSON();

            Reset();

            BookSaved(book);
        }
    }
}
