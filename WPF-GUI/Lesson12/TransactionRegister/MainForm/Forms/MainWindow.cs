using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Net.Mail;

namespace TransactionRegister
{
    public partial class TransactionRegister_frm : Form
    {
        private bool transModified;
        private ListViewItemComparer ascendingSorter_l;
        private ListViewItemComparer descendingSorter_l;

        public TransactionRegister_frm()
        {
            InitializeComponent();

            transModified = false;
            ascendingSorter_l = new ListViewItemComparer(0, SortOrder.Ascending);
            descendingSorter_l = new ListViewItemComparer(0, SortOrder.Descending);            
        }

        private void AddTransactoin_btn_Click(object sender, EventArgs e)
        {
            AddTransaction transactionDialog = new AddTransaction();
            transactionDialog.ShowDialog();

            // Show the add transaction dialog.
            if (transactionDialog.DialogResult == DialogResult.OK)
            {
                transModified = true;
                Transaction trans_l = transactionDialog.TransToAdd;
                this.AddTransactionToListView(trans_l);
            }         
        }

        private void AddTransactionToListView(Transaction trans_p)
        {
            String[] transData_l = new String[5];
            
            // Add a transaction date.
            transData_l[0] = trans_p.transDate_m.ToString();
            // Add a transaction description.
            if (trans_p.isACheck_m)
                transData_l[1] = trans_p.transDesc_m + " #" + trans_p.checkNum_m;
            else
                transData_l[1] = trans_p.transDesc_m;
            if (trans_p.debitOrCredit_m)
            {
                if (String.IsNullOrEmpty(trans_p.transAmount_m))
                    trans_p.transAmount_m = "0.00";

                // Add a debit transaction.
                transData_l[2] = "$" + Math.Round(Convert.ToDouble(trans_p.transAmount_m), 2).ToString();
                transData_l[3] = "";

            }
            else
            {
                if (String.IsNullOrEmpty(trans_p.transAmount_m))
                    trans_p.transAmount_m = "0.00";
                // Add a credit transaction.
                transData_l[2] = "";
                transData_l[3] = "$" + Math.Round(Convert.ToDouble(trans_p.transAmount_m), 2).ToString();
            }

            // Add the transaction to the listview.
            ListViewItem trans_lvi = new ListViewItem(transData_l);
            trans_lvi.Tag = trans_p;
            Transactoins_listv.Items.Add(trans_lvi);

            // Change the background color of alternating rows.
            if (Transactoins_listv.Items.Count % 2 == 0)
                trans_lvi.BackColor = Color.LightGray;

            // Sort the transaction list by date ascending.
            Transactoins_listv.ListViewItemSorter = ascendingSorter_l;
            Transactoins_listv.Sort();

            AvailableBalance_txtb.Text = "$" + Math.Round(CalculateBalance(), 2).ToString();

            // Sort the transaction list by date descending.
            Transactoins_listv.ListViewItemSorter = descendingSorter_l;
            Transactoins_listv.Sort();
        }

        private Double CalculateBalance()
        {
            Double balance = 0.00f;

            foreach (ListViewItem transAction_lvi in Transactoins_listv.Items)
            {
                Transaction trans_l = (Transaction)transAction_lvi.Tag;
                Double transAmount = System.Convert.ToDouble(trans_l.transAmount_m);
                if (trans_l.debitOrCredit_m)
                    balance -= transAmount; // Debit
                else
                    balance += transAmount; // Credit
            }

            return balance;
        }

        private void LoadTransactionFile_Click(object sender, EventArgs e)
        {
            OpenTransactions_opef.ShowDialog();

            if (System.IO.File.Exists(OpenTransactions_opef.FileName))
            {
                // Reset the transaction register before loading the file.
                ResetTransactionRegister();

                System.IO.FileStream transFile_l = new System.IO.FileStream(OpenTransactions_opef.FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                XmlReader transactionsXML_l = XmlReader.Create(transFile_l);

                String tempString_l;

                while (transactionsXML_l.Read())
                {
                    if (transactionsXML_l.IsStartElement() && transactionsXML_l.Name == "Transaction")
                    {
                        Transaction trans_l = new Transaction();

                        transactionsXML_l.ReadToFollowing("Trans_Amount");
                        trans_l.transAmount_m = transactionsXML_l.ReadElementContentAsString();

                        transactionsXML_l.ReadToFollowing("Tans_Date");
                        tempString_l = transactionsXML_l.ReadElementContentAsString();
                        trans_l.transDate_m = Convert.ToDateTime(tempString_l);

                        transactionsXML_l.ReadToFollowing("Trans_Desc");
                        trans_l.transDesc_m = transactionsXML_l.ReadElementContentAsString();

                        transactionsXML_l.ReadToFollowing("Trans_Type");
                        tempString_l = transactionsXML_l.ReadElementContentAsString();
                        trans_l.debitOrCredit_m = Convert.ToBoolean(tempString_l);

                        transactionsXML_l.ReadToFollowing("Trans_IsACheck");
                        tempString_l = transactionsXML_l.ReadElementContentAsString();
                        trans_l.isACheck_m = Convert.ToBoolean(tempString_l);

                        transactionsXML_l.ReadToFollowing("Trans_CheckNumber");
                        trans_l.checkNum_m = transactionsXML_l.ReadElementContentAsString();

                        AddTransactionToListView(trans_l);
                    }
                }

                transFile_l.Close();

            }
        }

        private void SaveTransaction_Click(object sender, EventArgs e)
        {
            this.SaveTransactions();
        }

        private void SaveTransactions()
        {
            SaveTransactions_savf.ShowDialog();

            if (!String.IsNullOrEmpty(SaveTransactions_savf.FileName))
            {
                transModified = false;

                XmlWriter transactionXML_l = XmlWriter.Create(SaveTransactions_savf.FileName);

                transactionXML_l.WriteStartDocument();

                transactionXML_l.WriteWhitespace("\n");

                transactionXML_l.WriteStartElement("Transactions");

                foreach (ListViewItem transAction_lvi in Transactoins_listv.Items)
                {
                    Transaction trans_l = (Transaction)transAction_lvi.Tag;

                    transactionXML_l.WriteWhitespace("\n\t");

                    transactionXML_l.WriteStartElement("Transaction");

                    transactionXML_l.WriteWhitespace("\n\t\t");

                    transactionXML_l.WriteStartElement("Trans_Amount");
                    transactionXML_l.WriteString(trans_l.transAmount_m);
                    transactionXML_l.WriteEndElement();

                    transactionXML_l.WriteWhitespace("\n\t\t");

                    transactionXML_l.WriteStartElement("Tans_Date");
                    transactionXML_l.WriteString(trans_l.transDate_m.ToString());
                    transactionXML_l.WriteEndElement();

                    transactionXML_l.WriteWhitespace("\n\t\t");

                    transactionXML_l.WriteStartElement("Trans_Desc");
                    transactionXML_l.WriteString(trans_l.transDesc_m);
                    transactionXML_l.WriteEndElement();

                    transactionXML_l.WriteWhitespace("\n\t\t");

                    transactionXML_l.WriteStartElement("Trans_Type");
                    transactionXML_l.WriteString(trans_l.debitOrCredit_m.ToString());
                    transactionXML_l.WriteEndElement();

                    transactionXML_l.WriteWhitespace("\n\t\t");

                    transactionXML_l.WriteStartElement("Trans_IsACheck");
                    transactionXML_l.WriteString(trans_l.isACheck_m.ToString());
                    transactionXML_l.WriteEndElement();

                    transactionXML_l.WriteWhitespace("\n\t\t");

                    transactionXML_l.WriteStartElement("Trans_CheckNumber");
                    transactionXML_l.WriteString(trans_l.checkNum_m);
                    transactionXML_l.WriteEndElement();

                    transactionXML_l.WriteWhitespace("\n\t");

                    transactionXML_l.WriteEndElement();
                }

                transactionXML_l.WriteWhitespace("\n");

                transactionXML_l.WriteEndElement();

                transactionXML_l.WriteEndDocument();

                transactionXML_l.Close();
            }
        }

        private void ResetTransactionRegister()
        {
            Transactoins_listv.Items.Clear();
            AvailableBalance_txtb.Text = "$0.00";
        }

        private void resetRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Reset menu option clicked.
            ResetTransactionRegister();
        }

        private void EmailBalance_btn_Click(object sender, EventArgs e)
        {
            // Setup smtp e-mail server settings.
            SmtpClient emailServerSMTP_l = new SmtpClient("mail.blacklightcoders.com");
            emailServerSMTP_l.Port = 26;
            emailServerSMTP_l.Credentials = new System.Net.NetworkCredential("blcforms@blacklightcoders.com", "]dh3$F=3p02O");

            // Fill out e-mail information to be sent.
            MailMessage balanceEmail_l = new MailMessage();
            balanceEmail_l.From = new MailAddress("blcforms@blacklightcoders.com");
            balanceEmail_l.To.Add("andy.odle@blacklightcoders.com");
            balanceEmail_l.Subject = "Available Balance";
            balanceEmail_l.Body = "Current Blance: " + AvailableBalance_txtb.Text;

            emailServerSMTP_l.Send(balanceEmail_l);

            MessageBox.Show("E-mail has been sent!","Sent E-mail", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Exit Menu Clicked
        private void ExitTransactionRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Form Closing Event
        private void TransactionRegister_ClosingEvent(object sender, FormClosingEventArgs e)
        {
            this.CloseTransactionRegister();
        }

        // Exit Program Event
        private void CloseTransactionRegister()
        {
            if (transModified)
            {
                String warningMessageTitle_l = "Save Changes";
                String warningMessage_l = "Save changes before exiting?";
                DialogResult warningResult_l = MessageBox.Show(warningMessage_l, warningMessageTitle_l, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check to make sure the user wants to save before exiting.
                if(warningResult_l == DialogResult.Yes)
                    this.SaveTransactions();               
            }
        }
    }
}
