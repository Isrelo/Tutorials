namespace TransactionRegister
{
    partial class TransactionRegister_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionRegister_frm));
            this.TransactionWrapper_splc = new System.Windows.Forms.SplitContainer();
            this.EmailBalance_btn = new System.Windows.Forms.Button();
            this.AddTransactoin_btn = new System.Windows.Forms.Button();
            this.ChecksNotCashedCount_txtb = new System.Windows.Forms.TextBox();
            this.AvailableBalance_txtb = new System.Windows.Forms.TextBox();
            this.ChecksNotCashedCount_lbl = new System.Windows.Forms.Label();
            this.AvailableBalance_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Transactoins_listv = new System.Windows.Forms.ListView();
            this.Date_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descriptoin_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DebitAmount_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreditAmount_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SatusMessage_stas = new System.Windows.Forms.StatusStrip();
            this.StatusMessage_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTransactions_savf = new System.Windows.Forms.SaveFileDialog();
            this.OpenTransactions_opef = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionWrapper_splc)).BeginInit();
            this.TransactionWrapper_splc.Panel1.SuspendLayout();
            this.TransactionWrapper_splc.Panel2.SuspendLayout();
            this.TransactionWrapper_splc.SuspendLayout();
            this.SatusMessage_stas.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TransactionWrapper_splc
            // 
            this.TransactionWrapper_splc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransactionWrapper_splc.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.TransactionWrapper_splc.IsSplitterFixed = true;
            this.TransactionWrapper_splc.Location = new System.Drawing.Point(0, 24);
            this.TransactionWrapper_splc.Name = "TransactionWrapper_splc";
            this.TransactionWrapper_splc.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // TransactionWrapper_splc.Panel1
            // 
            this.TransactionWrapper_splc.Panel1.Controls.Add(this.EmailBalance_btn);
            this.TransactionWrapper_splc.Panel1.Controls.Add(this.AddTransactoin_btn);
            this.TransactionWrapper_splc.Panel1.Controls.Add(this.ChecksNotCashedCount_txtb);
            this.TransactionWrapper_splc.Panel1.Controls.Add(this.AvailableBalance_txtb);
            this.TransactionWrapper_splc.Panel1.Controls.Add(this.ChecksNotCashedCount_lbl);
            this.TransactionWrapper_splc.Panel1.Controls.Add(this.AvailableBalance_lbl);
            // 
            // TransactionWrapper_splc.Panel2
            // 
            this.TransactionWrapper_splc.Panel2.Controls.Add(this.button1);
            this.TransactionWrapper_splc.Panel2.Controls.Add(this.Transactoins_listv);
            this.TransactionWrapper_splc.Size = new System.Drawing.Size(792, 520);
            this.TransactionWrapper_splc.SplitterDistance = 29;
            this.TransactionWrapper_splc.TabIndex = 0;
            // 
            // EmailBalance_btn
            // 
            this.EmailBalance_btn.Location = new System.Drawing.Point(464, 4);
            this.EmailBalance_btn.Name = "EmailBalance_btn";
            this.EmailBalance_btn.Size = new System.Drawing.Size(82, 21);
            this.EmailBalance_btn.TabIndex = 3;
            this.EmailBalance_btn.Text = "Email Balance";
            this.EmailBalance_btn.UseVisualStyleBackColor = true;
            this.EmailBalance_btn.Click += new System.EventHandler(this.EmailBalance_btn_Click);
            // 
            // AddTransactoin_btn
            // 
            this.AddTransactoin_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTransactoin_btn.Location = new System.Drawing.Point(686, 3);
            this.AddTransactoin_btn.Name = "AddTransactoin_btn";
            this.AddTransactoin_btn.Size = new System.Drawing.Size(94, 22);
            this.AddTransactoin_btn.TabIndex = 4;
            this.AddTransactoin_btn.Text = "Add Transaction";
            this.AddTransactoin_btn.UseVisualStyleBackColor = true;
            this.AddTransactoin_btn.Click += new System.EventHandler(this.AddTransactoin_btn_Click);
            // 
            // ChecksNotCashedCount_txtb
            // 
            this.ChecksNotCashedCount_txtb.BackColor = System.Drawing.SystemColors.Window;
            this.ChecksNotCashedCount_txtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ChecksNotCashedCount_txtb.Location = new System.Drawing.Point(401, 5);
            this.ChecksNotCashedCount_txtb.Name = "ChecksNotCashedCount_txtb";
            this.ChecksNotCashedCount_txtb.ReadOnly = true;
            this.ChecksNotCashedCount_txtb.Size = new System.Drawing.Size(57, 20);
            this.ChecksNotCashedCount_txtb.TabIndex = 3;
            // 
            // AvailableBalance_txtb
            // 
            this.AvailableBalance_txtb.BackColor = System.Drawing.SystemColors.Window;
            this.AvailableBalance_txtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AvailableBalance_txtb.Location = new System.Drawing.Point(113, 3);
            this.AvailableBalance_txtb.Name = "AvailableBalance_txtb";
            this.AvailableBalance_txtb.ReadOnly = true;
            this.AvailableBalance_txtb.Size = new System.Drawing.Size(172, 20);
            this.AvailableBalance_txtb.TabIndex = 2;
            this.AvailableBalance_txtb.Text = "$0.00";
            // 
            // ChecksNotCashedCount_lbl
            // 
            this.ChecksNotCashedCount_lbl.AutoSize = true;
            this.ChecksNotCashedCount_lbl.Location = new System.Drawing.Point(290, 8);
            this.ChecksNotCashedCount_lbl.Name = "ChecksNotCashedCount_lbl";
            this.ChecksNotCashedCount_lbl.Size = new System.Drawing.Size(105, 13);
            this.ChecksNotCashedCount_lbl.TabIndex = 1;
            this.ChecksNotCashedCount_lbl.Text = "Checks Not Cashed:";
            // 
            // AvailableBalance_lbl
            // 
            this.AvailableBalance_lbl.AutoSize = true;
            this.AvailableBalance_lbl.Location = new System.Drawing.Point(12, 8);
            this.AvailableBalance_lbl.Name = "AvailableBalance_lbl";
            this.AvailableBalance_lbl.Size = new System.Drawing.Size(95, 13);
            this.AvailableBalance_lbl.TabIndex = 0;
            this.AvailableBalance_lbl.Text = "Available Balance:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, -26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 20);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Transactoins_listv
            // 
            this.Transactoins_listv.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Transactoins_listv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date_col,
            this.Descriptoin_col,
            this.DebitAmount_col,
            this.CreditAmount_col});
            this.Transactoins_listv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Transactoins_listv.Location = new System.Drawing.Point(0, 0);
            this.Transactoins_listv.MultiSelect = false;
            this.Transactoins_listv.Name = "Transactoins_listv";
            this.Transactoins_listv.Size = new System.Drawing.Size(792, 487);
            this.Transactoins_listv.TabIndex = 0;
            this.Transactoins_listv.UseCompatibleStateImageBehavior = false;
            this.Transactoins_listv.View = System.Windows.Forms.View.Details;
            // 
            // Date_col
            // 
            this.Date_col.Text = "Date";
            this.Date_col.Width = 134;
            // 
            // Descriptoin_col
            // 
            this.Descriptoin_col.Text = "Description";
            this.Descriptoin_col.Width = 444;
            // 
            // DebitAmount_col
            // 
            this.DebitAmount_col.Text = "Debit Amount";
            this.DebitAmount_col.Width = 91;
            // 
            // CreditAmount_col
            // 
            this.CreditAmount_col.Text = "Credit Amount";
            this.CreditAmount_col.Width = 100;
            // 
            // SatusMessage_stas
            // 
            this.SatusMessage_stas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusMessage_lbl});
            this.SatusMessage_stas.Location = new System.Drawing.Point(0, 544);
            this.SatusMessage_stas.Name = "SatusMessage_stas";
            this.SatusMessage_stas.Size = new System.Drawing.Size(792, 22);
            this.SatusMessage_stas.TabIndex = 1;
            this.SatusMessage_stas.Text = "statusStrip1";
            // 
            // StatusMessage_lbl
            // 
            this.StatusMessage_lbl.Name = "StatusMessage_lbl";
            this.StatusMessage_lbl.Size = new System.Drawing.Size(39, 17);
            this.StatusMessage_lbl.Text = "Ready";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetRegisterToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // resetRegisterToolStripMenuItem
            // 
            this.resetRegisterToolStripMenuItem.Name = "resetRegisterToolStripMenuItem";
            this.resetRegisterToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.resetRegisterToolStripMenuItem.Text = "&Reset Register";
            this.resetRegisterToolStripMenuItem.Click += new System.EventHandler(this.resetRegisterToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(144, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveTransaction_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.loadToolStripMenuItem.Text = "&Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadTransactionFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitTransactionRegister_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // OpenTransactions_opef
            // 
            this.OpenTransactions_opef.FileName = "Transactions";
            // 
            // TransactionRegister_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.TransactionWrapper_splc);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.SatusMessage_stas);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "TransactionRegister_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TransactionRegister_ClosingEvent);
            this.TransactionWrapper_splc.Panel1.ResumeLayout(false);
            this.TransactionWrapper_splc.Panel1.PerformLayout();
            this.TransactionWrapper_splc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionWrapper_splc)).EndInit();
            this.TransactionWrapper_splc.ResumeLayout(false);
            this.SatusMessage_stas.ResumeLayout(false);
            this.SatusMessage_stas.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer TransactionWrapper_splc;
        private System.Windows.Forms.ListView Transactoins_listv;
        private System.Windows.Forms.TextBox ChecksNotCashedCount_txtb;
        private System.Windows.Forms.TextBox AvailableBalance_txtb;
        private System.Windows.Forms.Label ChecksNotCashedCount_lbl;
        private System.Windows.Forms.Label AvailableBalance_lbl;
        private System.Windows.Forms.StatusStrip SatusMessage_stas;
        private System.Windows.Forms.ToolStripStatusLabel StatusMessage_lbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Date_col;
        private System.Windows.Forms.ColumnHeader Descriptoin_col;
        private System.Windows.Forms.ColumnHeader DebitAmount_col;
        private System.Windows.Forms.ColumnHeader CreditAmount_col;
        private System.Windows.Forms.Button AddTransactoin_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog SaveTransactions_savf;
        private System.Windows.Forms.OpenFileDialog OpenTransactions_opef;
        private System.Windows.Forms.ToolStripMenuItem resetRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button EmailBalance_btn;
    }
}

