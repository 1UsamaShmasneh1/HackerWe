﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using HackerWe.Entities;
using HackerWeLogic;

namespace HackerWeUi
{
    public partial class HackerWeLibraryForm : Form
    {
        public HackerWeLibraryForm()
        {
            InitializeComponent();
        }

        Timer timer = new Timer();
        private void HackerWeLibraryForm_Load(object sender, EventArgs e)
        {

            timer.Interval = 5000;
            timer.Tick += (object o, EventArgs argss) =>
            {
                MessageToolStripStatusLabel.Text = "";
                timer.Stop();
            };

            Library.ReadBooksFromJson();
            Library.ReadClientsFromJson();
        }

        private void BooksButton_Click(object sender, EventArgs e)
        {
            HackerWeLibraryPanel.Controls.Clear();
            BooksUserControle booksUserControle = new BooksUserControle();
            booksUserControle.BookSaved += (book) =>
            {                
                MessageToolStripStatusLabel.Text = "Book saved successfully " + book.Id;
                timer.Start();
            };
            booksUserControle.Parent = HackerWeLibraryPanel;
            booksUserControle.Show();            
        }

        private void BorowingButton_Click(object sender, EventArgs e)
        {
            HackerWeLibraryPanel.Controls.Clear();
            BorrowingUserControl borrowingUserControl = new BorrowingUserControl();
            borrowingUserControl.BorrowingSaved += (borrowing) =>
            {
                SendEmail("us.05.07.1991@gmail.com", "sent", "mail has been sent");
                MessageToolStripStatusLabel.Text = "Borowing saved successfully " + borrowing.Id;
                timer.Start();
            };
            borrowingUserControl.Parent = HackerWeLibraryPanel;

            borrowingUserControl.Show();
        }

        private void SendEmail(string recipientMail, string subject, string body)
        {
            MailMessage message = new MailMessage("us.05.07.91@gmail.com", recipientMail);
            message.Subject = subject;
            message.Body = body;
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("us.05.07.91@gmail.com", "u05071991"),
                EnableSsl = true,
            };
            smtpClient.UseDefaultCredentials = true;
            smtpClient.Send(message);
            //smtpClient.Send("us.05.07.91@gmail.com", recipientMail, subject, body);
        }

    }
}