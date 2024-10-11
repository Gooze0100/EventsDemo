namespace WinFormUI
{
    partial class Dashboard
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            customerText = new Label();
            checkingBalanceValue = new Label();
            savingsBalanceValue = new Label();
            recordTransactionsButton = new Button();
            errorMessage = new Label();
            label6 = new Label();
            label7 = new Label();
            checkingTransactions = new ListBox();
            savingsTransactions = new ListBox();
            denyOverdraft = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F);
            label1.Location = new Point(42, 34);
            label1.Name = "label1";
            label1.Size = new Size(269, 51);
            label1.TabIndex = 0;
            label1.Text = "Banking Demo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(42, 128);
            label2.Name = "label2";
            label2.Size = new Size(124, 32);
            label2.TabIndex = 1;
            label2.Text = "Customer";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(42, 187);
            label3.Name = "label3";
            label3.Size = new Size(213, 32);
            label3.TabIndex = 2;
            label3.Text = "Checking Balance";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.Location = new Point(42, 241);
            label4.Name = "label4";
            label4.Size = new Size(196, 32);
            label4.TabIndex = 3;
            label4.Text = "Savings Balance";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // customerText
            // 
            customerText.AutoSize = true;
            customerText.Font = new Font("Segoe UI", 16F);
            customerText.Location = new Point(296, 130);
            customerText.Name = "customerText";
            customerText.Size = new Size(92, 30);
            customerText.TabIndex = 4;
            customerText.Text = "<none>";
            // 
            // checkingBalanceValue
            // 
            checkingBalanceValue.AutoSize = true;
            checkingBalanceValue.Font = new Font("Segoe UI", 16F);
            checkingBalanceValue.Location = new Point(296, 189);
            checkingBalanceValue.Name = "checkingBalanceValue";
            checkingBalanceValue.Size = new Size(66, 30);
            checkingBalanceValue.TabIndex = 5;
            checkingBalanceValue.Text = "$0.00";
            // 
            // savingsBalanceValue
            // 
            savingsBalanceValue.AutoSize = true;
            savingsBalanceValue.Font = new Font("Segoe UI", 16F);
            savingsBalanceValue.Location = new Point(296, 243);
            savingsBalanceValue.Name = "savingsBalanceValue";
            savingsBalanceValue.Size = new Size(66, 30);
            savingsBalanceValue.TabIndex = 6;
            savingsBalanceValue.Text = "$0.00";
            // 
            // recordTransactionsButton
            // 
            recordTransactionsButton.Font = new Font("Segoe UI", 18F);
            recordTransactionsButton.Location = new Point(42, 296);
            recordTransactionsButton.Name = "recordTransactionsButton";
            recordTransactionsButton.Size = new Size(150, 80);
            recordTransactionsButton.TabIndex = 7;
            recordTransactionsButton.Text = "Record Transactions";
            recordTransactionsButton.UseVisualStyleBackColor = true;
            recordTransactionsButton.Click += recordTransactionsButton_Click;
            // 
            // errorMessage
            // 
            errorMessage.AutoSize = true;
            errorMessage.Font = new Font("Segoe UI", 18F);
            errorMessage.ForeColor = Color.Red;
            errorMessage.Location = new Point(537, 70);
            errorMessage.Name = "errorMessage";
            errorMessage.Size = new Size(527, 32);
            errorMessage.TabIndex = 8;
            errorMessage.Text = "You had an overraft protection transder of $0.00";
            errorMessage.Visible = false;
            errorMessage.Click += errorMessage_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label6.Location = new Point(537, 128);
            label6.Name = "label6";
            label6.Size = new Size(243, 30);
            label6.TabIndex = 9;
            label6.Text = "Checking Transactions";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label7.Location = new Point(857, 128);
            label7.Name = "label7";
            label7.Size = new Size(227, 30);
            label7.TabIndex = 10;
            label7.Text = "Savings Transactions";
            // 
            // checkingTransactions
            // 
            checkingTransactions.FormattingEnabled = true;
            checkingTransactions.ItemHeight = 15;
            checkingTransactions.Location = new Point(537, 161);
            checkingTransactions.Name = "checkingTransactions";
            checkingTransactions.Size = new Size(282, 259);
            checkingTransactions.TabIndex = 11;
            // 
            // savingsTransactions
            // 
            savingsTransactions.FormattingEnabled = true;
            savingsTransactions.ItemHeight = 15;
            savingsTransactions.Location = new Point(857, 161);
            savingsTransactions.Name = "savingsTransactions";
            savingsTransactions.Size = new Size(282, 259);
            savingsTransactions.TabIndex = 12;
            // 
            // denyOverdraft
            // 
            denyOverdraft.AutoSize = true;
            denyOverdraft.Font = new Font("Segoe UI", 12F);
            denyOverdraft.Location = new Point(259, 315);
            denyOverdraft.Name = "denyOverdraft";
            denyOverdraft.Size = new Size(138, 25);
            denyOverdraft.TabIndex = 13;
            denyOverdraft.Text = "Stop Overdrafts";
            denyOverdraft.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 450);
            Controls.Add(denyOverdraft);
            Controls.Add(savingsTransactions);
            Controls.Add(checkingTransactions);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(errorMessage);
            Controls.Add(recordTransactionsButton);
            Controls.Add(savingsBalanceValue);
            Controls.Add(checkingBalanceValue);
            Controls.Add(customerText);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Dashboard";
            Text = "Banking Dashborad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label customerText;
        private Label checkingBalanceValue;
        private Label savingsBalanceValue;
        private Button recordTransactionsButton;
        private Label errorMessage;
        private Label label6;
        private Label label7;
        private ListBox checkingTransactions;
        private ListBox savingsTransactions;
        private CheckBox denyOverdraft;
    }
}