using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerWe.Entities
{
    public class Borowing
    {
        public Guid Id {  get; set; }
        public DateTime BorowingDate {  get; set; }
        public DateTime DueReturningDate => BorowingDate.AddDays(14);
        public DateTime ReturinigDate {  get; set; }
        public int BookId {  get; set; }

        private Book book;
        public Book Book
        {
            get { return book; }
            set { book = value; }
        }

        public int ClientId {  get; set; }
        public Client Client { get; set; }

        public Borowing()
        {
            Id = Guid.NewGuid();
        }

        void ReadFromFixedLength(string line)
        {
            ClientId = int.Parse(line.Substring(0, 5));
        }

        string WriteFixedLength()
        {
            string str;
            str = string.Format("{0:5}{1:36}", ClientId, Id);
            return str;
        }
    }
}
