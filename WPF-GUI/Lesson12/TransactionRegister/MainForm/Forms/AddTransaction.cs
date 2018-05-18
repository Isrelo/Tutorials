using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TransactionRegister
{
    public partial class AddTransaction : Form
    {
        public AddTransaction()
        {
            InitializeComponent();
        }

        public Transaction TransToAdd
        {
            get 
            {
                Transaction transToAdd_l = new Transaction();
                // Transaction Amount
                if (!String.IsNullOrEmpty(TransactionAmount_txtb.Text))
                    transToAdd_l.transAmount_m = TransactionAmount_txtb.Text;
                else
                    transToAdd_l.transAmount_m = "";
                // Transaction Date
                if (TransDate_datp.Value != null)
                    transToAdd_l.transDate_m = TransDate_datp.Value;
                else
                    transToAdd_l.transDate_m = DateTime.Now;
                // Transaction Description
                if (!String.IsNullOrEmpty(Description_txtb.Text))
                    transToAdd_l.transDesc_m = Description_txtb.Text;
                else
                    transToAdd_l.transDesc_m = "";
                // Transaction Type (Debit if true else credit)
                transToAdd_l.debitOrCredit_m = Debit_radb.Checked;
                // Transaction Is a Check
                transToAdd_l.isACheck_m = Check_chkb.Checked;
                if (transToAdd_l.isACheck_m && !String.IsNullOrEmpty(CheckNumber_txtb.Text))
                    transToAdd_l.checkNum_m = CheckNumber_txtb.Text;
                else
                    transToAdd_l.checkNum_m = "";

                return transToAdd_l;
            }
        }

        private void Check_chkb_CheckedChanged(object sender, EventArgs e)
        {
            CheckNumber_txtb.Enabled = Check_chkb.Checked;
        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
