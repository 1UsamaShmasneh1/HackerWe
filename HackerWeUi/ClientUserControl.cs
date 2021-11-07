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
    public partial class ClientUserControl : UserControl
    {
        Client client;
        public event Action<Client> ClientSaved;
        public ClientUserControl()
        {
            InitializeComponent();
        }

        private void ClientUserControl_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            //reset fields
            client = new Client();
            ClientIdTextBox.Text = String.Empty;
            FirstNameTextBox.Text = String.Empty;
            LastNameTextBox.Text = String.Empty;
            PhoneNumberTextBox.Text = String.Empty;
            EmailTextBox.Text = String.Empty;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            client.IdentityNumber = ClientIdTextBox.Text;
            client.FirstName = FirstNameTextBox.Text;
            client.LastName = LastNameTextBox.Text;
            client.PhoneNumber = PhoneNumberTextBox.Text;
            client.Email = EmailTextBox.Text;
            Library.Clients.Add(client);
            Library.SaveClientsJSON();

            Reset();

            ClientSaved(client);
        }

    }
}
