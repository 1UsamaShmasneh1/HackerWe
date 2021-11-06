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
    public partial class BorrowingUserControl : UserControl
    {
        Borowing borowing;

        public event Action<Borowing> BorrowingSaved;

        public BorrowingUserControl()
        {
            InitializeComponent();
        }


        private void BorrowingUserControl_Load(object sender, EventArgs e)
        {
            Reset();
            BorrowingDateTimePicker.MaxDate = DateTime.Now.AddDays(2);

            BookComboBox.DataSource = Library.RelevantBooks;
            BookComboBox.DisplayMember = "Name";

            ClientComboBox.DataSource = Library.Clients;
            ClientComboBox.DisplayMember = "FullName";
            Library.ReadBooksFromJson();
        }

        private void BorrowingDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            borowing.BorowingDate = BorrowingDateTimePicker.Value;
            DueReturningDateLabel.Text = borowing.DueReturningDate.ToString("dd/MM/yyyy");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(ClientComboBox.SelectedItem == null)
            {
                MessageLabel.Text = "Tis is must";
                return;
            }
            borowing.Client = (Client)ClientComboBox.SelectedItem;
            borowing.Book = BookComboBox.SelectedItem as Book;

            Library.Borowings.Add(borowing);
            Library.SaveBorrowings();

            Reset();

            BorrowingSaved(borowing);
        }

        private void Reset()
        {
            //reset fields
            borowing = new Borowing();

            MessageLabel.Text = string.Empty;

            BorrowingDateTimePicker.MinDate = DateTime.Now;
            BorrowingDateTimePicker.Value = DateTime.Now;
        }

        private void ClientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClientComboBox.SelectedItem != null)
                MessageLabel.Text = "";
        }


    }
}
