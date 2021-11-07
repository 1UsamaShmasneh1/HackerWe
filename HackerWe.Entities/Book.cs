using Newtonsoft.Json;

namespace HackerWe.Entities
{
    public class Book
    {
        
        public int Id { get; set; }
        public Guid ISBN { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime DatePublished { get; set; }
        public int NumberOfPages { get; set; }
        public short NumberOfCopies { get; set; }
        public short NumberOfBorrowedOut { get; set; }

        public Book()
        {
            ISBN = Guid.NewGuid();
        }

        public string ToCSV()
        {
            string str;
            str = string.Format($"{Id},{ISBN},{Author},{Name},{DatePublished}");
            return str;
        }


        public bool IsNewBindingNeeded()
        {
            return DatePublished.Year < DateTime.Now.AddYears(20).Year;
        }
    }
}