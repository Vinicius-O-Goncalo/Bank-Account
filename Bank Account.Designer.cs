namespace Bank_Account
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbCred = new Label();
            lbDeb = new Label();
            txbCredito = new TextBox();
            txbDebito = new TextBox();
            lbName = new Label();
            txbName = new TextBox();
            lbDate = new Label();
            BtnSave = new Button();
            btnAbrir = new Button();
            gpBankAccount = new GroupBox();
            btnClose = new Button();
            lbDesc = new Label();
            txbDesc = new TextBox();
            txbDate = new DateTimePicker();
            lbStatus = new Label();
            gpBankAccount.SuspendLayout();
            SuspendLayout();
            // 
            // lbCred
            // 
            lbCred.AutoSize = true;
            lbCred.Location = new Point(472, 43);
            lbCred.Name = "lbCred";
            lbCred.Size = new Size(45, 16);
            lbCred.TabIndex = 0;
            lbCred.Text = "Crédito";
            // 
            // lbDeb
            // 
            lbDeb.AutoSize = true;
            lbDeb.Location = new Point(470, 139);
            lbDeb.Name = "lbDeb";
            lbDeb.Size = new Size(42, 16);
            lbDeb.TabIndex = 1;
            lbDeb.Text = "Débito";
            // 
            // txbCredito
            // 
            txbCredito.Location = new Point(444, 77);
            txbCredito.Name = "txbCredito";
            txbCredito.Size = new Size(100, 23);
            txbCredito.TabIndex = 2;
            // 
            // txbDebito
            // 
            txbDebito.Location = new Point(444, 171);
            txbDebito.Name = "txbDebito";
            txbDebito.Size = new Size(100, 23);
            txbDebito.TabIndex = 3;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(162, 51);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 16);
            lbName.TabIndex = 7;
            lbName.Text = "Nome";
            // 
            // txbName
            // 
            txbName.Location = new Point(135, 80);
            txbName.Name = "txbName";
            txbName.Size = new Size(100, 23);
            txbName.TabIndex = 8;
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Location = new Point(162, 143);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(31, 16);
            lbDate.TabIndex = 10;
            lbDate.Text = "Data";
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(312, 374);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 23);
            BtnSave.TabIndex = 11;
            BtnSave.Text = "Salvar";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(169, 374);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(75, 23);
            btnAbrir.TabIndex = 12;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += BtnAbrir_Click;
            // 
            // gpBankAccount
            // 
            gpBankAccount.Controls.Add(btnClose);
            gpBankAccount.Controls.Add(lbDesc);
            gpBankAccount.Controls.Add(txbDesc);
            gpBankAccount.Controls.Add(txbDate);
            gpBankAccount.Controls.Add(lbStatus);
            gpBankAccount.Controls.Add(btnAbrir);
            gpBankAccount.Controls.Add(lbName);
            gpBankAccount.Controls.Add(BtnSave);
            gpBankAccount.Controls.Add(txbName);
            gpBankAccount.Controls.Add(lbDate);
            gpBankAccount.Controls.Add(txbDebito);
            gpBankAccount.Controls.Add(txbCredito);
            gpBankAccount.Controls.Add(lbDeb);
            gpBankAccount.Controls.Add(lbCred);
            gpBankAccount.Location = new Point(45, 12);
            gpBankAccount.Name = "gpBankAccount";
            gpBankAccount.Size = new Size(717, 426);
            gpBankAccount.TabIndex = 14;
            gpBankAccount.TabStop = false;
            gpBankAccount.Text = "Bank Account";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(455, 374);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 18;
            btnClose.Text = "Fechar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lbDesc
            // 
            lbDesc.AutoSize = true;
            lbDesc.Location = new Point(152, 219);
            lbDesc.Name = "lbDesc";
            lbDesc.Size = new Size(58, 16);
            lbDesc.TabIndex = 17;
            lbDesc.Text = "Descrição";
            // 
            // txbDesc
            // 
            txbDesc.Location = new Point(118, 247);
            txbDesc.Multiline = true;
            txbDesc.Name = "txbDesc";
            txbDesc.Size = new Size(131, 82);
            txbDesc.TabIndex = 16;
            // 
            // txbDate
            // 
            txbDate.Location = new Point(92, 171);
            txbDate.Name = "txbDate";
            txbDate.Size = new Size(200, 23);
            txbDate.TabIndex = 15;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(470, 269);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(39, 16);
            lbStatus.TabIndex = 14;
            lbStatus.Text = "Status";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gpBankAccount);
            Name = "Form1";
            gpBankAccount.ResumeLayout(false);
            gpBankAccount.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbCred;
        private Label lbDeb;
        private TextBox txbCredito;
        private TextBox txbDebito;
        private Label lbName;
        private TextBox txbName;
        private Label lbDate;
        private Button BtnSave;
        private Button btnAbrir;
        private GroupBox gpBankAccount;
        private Label lbStatus;
        private DateTimePicker txbDate;
        private Label lbDesc;
        private TextBox txbDesc;
        private Button btnClose;
    }
}
