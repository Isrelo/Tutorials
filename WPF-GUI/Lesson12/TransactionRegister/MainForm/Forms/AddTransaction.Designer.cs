namespace TransactionRegister
{
    partial class AddTransaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TransDate_datp = new System.Windows.Forms.DateTimePicker();
            this.TransDate_lbl = new System.Windows.Forms.Label();
            this.Description_lbl = new System.Windows.Forms.Label();
            this.Description_txtb = new System.Windows.Forms.TextBox();
            this.Credit_radb = new System.Windows.Forms.RadioButton();
            this.Debit_radb = new System.Windows.Forms.RadioButton();
            this.TransactionType_grob = new System.Windows.Forms.GroupBox();
            this.Check_chkb = new System.Windows.Forms.CheckBox();
            this.CheckNumber_lbl = new System.Windows.Forms.Label();
            this.CheckNumber_txtb = new System.Windows.Forms.TextBox();
            this.ACheck_grob = new System.Windows.Forms.GroupBox();
            this.Ok_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.TransactionAmount_lbl = new System.Windows.Forms.Label();
            this.TransactionAmount_txtb = new System.Windows.Forms.TextBox();
            this.TransactionType_grob.SuspendLayout();
            this.ACheck_grob.SuspendLayout();
            this.SuspendLayout();
            // 
            // TransDate_datp
            // 
            this.TransDate_datp.Location = new System.Drawing.Point(12, 45);
            this.TransDate_datp.Name = "TransDate_datp";
            this.TransDate_datp.Size = new System.Drawing.Size(186, 20);
            this.TransDate_datp.TabIndex = 0;
            // 
            // TransDate_lbl
            // 
            this.TransDate_lbl.AutoSize = true;
            this.TransDate_lbl.Location = new System.Drawing.Point(9, 29);
            this.TransDate_lbl.Name = "TransDate_lbl";
            this.TransDate_lbl.Size = new System.Drawing.Size(33, 13);
            this.TransDate_lbl.TabIndex = 1;
            this.TransDate_lbl.Text = "Date:";
            // 
            // Description_lbl
            // 
            this.Description_lbl.AutoSize = true;
            this.Description_lbl.Location = new System.Drawing.Point(9, 68);
            this.Description_lbl.Name = "Description_lbl";
            this.Description_lbl.Size = new System.Drawing.Size(63, 13);
            this.Description_lbl.TabIndex = 2;
            this.Description_lbl.Text = "Description:";
            // 
            // Description_txtb
            // 
            this.Description_txtb.Location = new System.Drawing.Point(12, 84);
            this.Description_txtb.Multiline = true;
            this.Description_txtb.Name = "Description_txtb";
            this.Description_txtb.Size = new System.Drawing.Size(186, 29);
            this.Description_txtb.TabIndex = 3;
            // 
            // Credit_radb
            // 
            this.Credit_radb.AutoSize = true;
            this.Credit_radb.Location = new System.Drawing.Point(62, 19);
            this.Credit_radb.Name = "Credit_radb";
            this.Credit_radb.Size = new System.Drawing.Size(52, 17);
            this.Credit_radb.TabIndex = 4;
            this.Credit_radb.Text = "Credit";
            this.Credit_radb.UseVisualStyleBackColor = true;
            // 
            // Debit_radb
            // 
            this.Debit_radb.AutoSize = true;
            this.Debit_radb.Checked = true;
            this.Debit_radb.Location = new System.Drawing.Point(6, 19);
            this.Debit_radb.Name = "Debit_radb";
            this.Debit_radb.Size = new System.Drawing.Size(50, 17);
            this.Debit_radb.TabIndex = 5;
            this.Debit_radb.TabStop = true;
            this.Debit_radb.Text = "Debit";
            this.Debit_radb.UseVisualStyleBackColor = true;
            // 
            // TransactionType_grob
            // 
            this.TransactionType_grob.Controls.Add(this.Credit_radb);
            this.TransactionType_grob.Controls.Add(this.Debit_radb);
            this.TransactionType_grob.Location = new System.Drawing.Point(12, 119);
            this.TransactionType_grob.Name = "TransactionType_grob";
            this.TransactionType_grob.Size = new System.Drawing.Size(186, 51);
            this.TransactionType_grob.TabIndex = 6;
            this.TransactionType_grob.TabStop = false;
            this.TransactionType_grob.Text = "Transaction Type";
            // 
            // Check_chkb
            // 
            this.Check_chkb.AutoSize = true;
            this.Check_chkb.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Check_chkb.Location = new System.Drawing.Point(6, 19);
            this.Check_chkb.Name = "Check_chkb";
            this.Check_chkb.Size = new System.Drawing.Size(77, 17);
            this.Check_chkb.TabIndex = 7;
            this.Check_chkb.Text = "Is a Check";
            this.Check_chkb.UseVisualStyleBackColor = true;
            this.Check_chkb.CheckedChanged += new System.EventHandler(this.Check_chkb_CheckedChanged);
            // 
            // CheckNumber_lbl
            // 
            this.CheckNumber_lbl.AutoSize = true;
            this.CheckNumber_lbl.Location = new System.Drawing.Point(3, 45);
            this.CheckNumber_lbl.Name = "CheckNumber_lbl";
            this.CheckNumber_lbl.Size = new System.Drawing.Size(51, 13);
            this.CheckNumber_lbl.TabIndex = 8;
            this.CheckNumber_lbl.Text = "Check #:";
            // 
            // CheckNumber_txtb
            // 
            this.CheckNumber_txtb.Enabled = false;
            this.CheckNumber_txtb.Location = new System.Drawing.Point(60, 42);
            this.CheckNumber_txtb.Name = "CheckNumber_txtb";
            this.CheckNumber_txtb.Size = new System.Drawing.Size(54, 20);
            this.CheckNumber_txtb.TabIndex = 9;
            // 
            // ACheck_grob
            // 
            this.ACheck_grob.Controls.Add(this.Check_chkb);
            this.ACheck_grob.Controls.Add(this.CheckNumber_txtb);
            this.ACheck_grob.Controls.Add(this.CheckNumber_lbl);
            this.ACheck_grob.Location = new System.Drawing.Point(12, 176);
            this.ACheck_grob.Name = "ACheck_grob";
            this.ACheck_grob.Size = new System.Drawing.Size(186, 74);
            this.ACheck_grob.TabIndex = 10;
            this.ACheck_grob.TabStop = false;
            this.ACheck_grob.Text = "Check Info";
            // 
            // Ok_btn
            // 
            this.Ok_btn.Location = new System.Drawing.Point(42, 256);
            this.Ok_btn.Name = "Ok_btn";
            this.Ok_btn.Size = new System.Drawing.Size(75, 23);
            this.Ok_btn.TabIndex = 11;
            this.Ok_btn.Text = "Ok";
            this.Ok_btn.UseVisualStyleBackColor = true;
            this.Ok_btn.Click += new System.EventHandler(this.Ok_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_btn.Location = new System.Drawing.Point(123, 256);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_btn.TabIndex = 12;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // TransactionAmount_lbl
            // 
            this.TransactionAmount_lbl.AutoSize = true;
            this.TransactionAmount_lbl.Location = new System.Drawing.Point(9, 9);
            this.TransactionAmount_lbl.Name = "TransactionAmount_lbl";
            this.TransactionAmount_lbl.Size = new System.Drawing.Size(105, 13);
            this.TransactionAmount_lbl.TabIndex = 13;
            this.TransactionAmount_lbl.Text = "Transaction Amount:";
            // 
            // TransactionAmount_txtb
            // 
            this.TransactionAmount_txtb.Location = new System.Drawing.Point(120, 6);
            this.TransactionAmount_txtb.Name = "TransactionAmount_txtb";
            this.TransactionAmount_txtb.Size = new System.Drawing.Size(78, 20);
            this.TransactionAmount_txtb.TabIndex = 14;
            // 
            // AddTransaction
            // 
            this.AcceptButton = this.Ok_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_btn;
            this.ClientSize = new System.Drawing.Size(210, 289);
            this.Controls.Add(this.TransactionAmount_txtb);
            this.Controls.Add(this.TransactionAmount_lbl);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Ok_btn);
            this.Controls.Add(this.ACheck_grob);
            this.Controls.Add(this.TransactionType_grob);
            this.Controls.Add(this.Description_txtb);
            this.Controls.Add(this.Description_lbl);
            this.Controls.Add(this.TransDate_lbl);
            this.Controls.Add(this.TransDate_datp);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTransaction";
            this.TransactionType_grob.ResumeLayout(false);
            this.TransactionType_grob.PerformLayout();
            this.ACheck_grob.ResumeLayout(false);
            this.ACheck_grob.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker TransDate_datp;
        private System.Windows.Forms.Label TransDate_lbl;
        private System.Windows.Forms.Label Description_lbl;
        private System.Windows.Forms.TextBox Description_txtb;
        private System.Windows.Forms.RadioButton Credit_radb;
        private System.Windows.Forms.RadioButton Debit_radb;
        private System.Windows.Forms.GroupBox TransactionType_grob;
        private System.Windows.Forms.CheckBox Check_chkb;
        private System.Windows.Forms.Label CheckNumber_lbl;
        private System.Windows.Forms.TextBox CheckNumber_txtb;
        private System.Windows.Forms.GroupBox ACheck_grob;
        private System.Windows.Forms.Button Ok_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Label TransactionAmount_lbl;
        private System.Windows.Forms.TextBox TransactionAmount_txtb;
    }
}