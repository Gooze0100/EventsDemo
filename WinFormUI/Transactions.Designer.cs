namespace WinFormUI
{
    partial class Transactions
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
            makePurchaseButton = new Button();
            customerText = new Label();
            amountValue = new NumericUpDown();
            errorMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)amountValue).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F);
            label1.Location = new Point(49, 48);
            label1.Name = "label1";
            label1.Size = new Size(365, 51);
            label1.TabIndex = 0;
            label1.Text = "Credit Card Machine";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(63, 139);
            label2.Name = "label2";
            label2.Size = new Size(124, 32);
            label2.TabIndex = 1;
            label2.Text = "Customer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(63, 206);
            label3.Name = "label3";
            label3.Size = new Size(107, 32);
            label3.TabIndex = 2;
            label3.Text = "Amount";
            // 
            // makePurchaseButton
            // 
            makePurchaseButton.Font = new Font("Segoe UI", 18F);
            makePurchaseButton.Location = new Point(143, 289);
            makePurchaseButton.Name = "makePurchaseButton";
            makePurchaseButton.Size = new Size(200, 60);
            makePurchaseButton.TabIndex = 3;
            makePurchaseButton.Text = "Make Purchase";
            makePurchaseButton.UseVisualStyleBackColor = true;
            makePurchaseButton.Click += makePurchaseButton_Click;
            // 
            // customerText
            // 
            customerText.AutoSize = true;
            customerText.Font = new Font("Segoe UI", 16F);
            customerText.Location = new Point(222, 141);
            customerText.Name = "customerText";
            customerText.Size = new Size(92, 30);
            customerText.TabIndex = 4;
            customerText.Text = "<none>";
            // 
            // amountValue
            // 
            amountValue.Font = new Font("Segoe UI", 16F);
            amountValue.Location = new Point(222, 206);
            amountValue.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            amountValue.Name = "amountValue";
            amountValue.Size = new Size(180, 36);
            amountValue.TabIndex = 5;
            // 
            // errorMessage
            // 
            errorMessage.AutoSize = true;
            errorMessage.Font = new Font("Segoe UI", 18F);
            errorMessage.ForeColor = Color.Red;
            errorMessage.Location = new Point(126, 376);
            errorMessage.Name = "errorMessage";
            errorMessage.Size = new Size(238, 32);
            errorMessage.TabIndex = 9;
            errorMessage.Text = "You are overdrafting!";
            errorMessage.Visible = false;
            errorMessage.Click += errorMessage_Click;
            // 
            // Transactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 450);
            Controls.Add(errorMessage);
            Controls.Add(amountValue);
            Controls.Add(customerText);
            Controls.Add(makePurchaseButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Transactions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transactions";
            ((System.ComponentModel.ISupportInitialize)amountValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button makePurchaseButton;
        private Label customerText;
        private NumericUpDown amountValue;
        private Label errorMessage;
    }
}