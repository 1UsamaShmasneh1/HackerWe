using HackerWe.Entities;
using System.Text.Json;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace HackerWeLogic
{
    public static class Library
    {
        #region Properties
        public static List<Book> Books { get; set; } = new List<Book>();
        public static List<Client> Clients { get; set; } = new List<Client>();
        public static List<Borowing> Borowings { get; set; } = new List<Borowing>();
        #endregion

        #region Constractor
        static Library()
        {           

        }
        #endregion

        public static List<Book> RelevantBooks => Books.Where(x => x.NumberOfBorrowedOut < x.NumberOfCopies).ToList();

        #region File Managament
        #region Save Methods
        public static void SaveBooks()
        {
            var s = "";
            foreach(var book in Library.Books)
            {
                s += book.ToCSV() + Environment.NewLine;
            }
            File.WriteAllText(@"BooksCSV.scv", s);
        }

        public static void SaveBooksJSON()
        {
            var jsonSTR = JsonConvert.SerializeObject(Library.Books);
            File.WriteAllText(@"BooksJSON.json", jsonSTR);
        }

        public static void SaveBorrowings()
        {
            var jsonSTR = JsonConvert.SerializeObject(Books);
            File.WriteAllText(@"BorrowingJSON.json", jsonSTR);
        }

        public static void SaveClientsJSON()
        {
            var jsonSTR = JsonConvert.SerializeObject(Clients);
            File.WriteAllText(@"ClientsJSON.json", jsonSTR);
        }
        #endregion

        public static void ReadBooksFromJson()
        {
            var jsonSTR = File.ReadAllText(@"BooksJSON.json");
            Library.Books = JsonSerializer.Deserialize<List<Book>>(jsonSTR);
        }

        public static void ReadClientsFromJson()
        {
            var jsonSTR = File.ReadAllText(@"ClientsJSON.json");
            Library.Clients = JsonSerializer.Deserialize<List<Client>>(jsonSTR);
        }
        #endregion
    }
}