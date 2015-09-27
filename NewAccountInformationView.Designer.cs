namespace CrestAccountingSystem
{
    partial class NewAccountInformationView
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
            this.accountNameLabel = new System.Windows.Forms.Label();
            this.accountNamePlaceholder = new System.Windows.Forms.Label();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.accountNumberPlaceholder = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.workAccountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountNameLabel
            // 
            this.accountNameLabel.AutoSize = true;
            this.accountNameLabel.Location = new System.Drawing.Point(12, 101);
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Size = new System.Drawing.Size(81, 13);
            this.accountNameLabel.TabIndex = 0;
            this.accountNameLabel.Text = "Account Name:";
            // 
            // accountNamePlaceholder
            // 
            this.accountNamePlaceholder.AutoSize = true;
            this.accountNamePlaceholder.Location = new System.Drawing.Point(99, 101);
            this.accountNamePlaceholder.Name = "accountNamePlaceholder";
            this.accountNamePlaceholder.Size = new System.Drawing.Size(166, 13);
            this.accountNamePlaceholder.TabIndex = 1;
            this.accountNamePlaceholder.Text = "Account Name Placeholder Label";
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Location = new System.Drawing.Point(325, 101);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(90, 13);
            this.accountNumberLabel.TabIndex = 2;
            this.accountNumberLabel.Text = "Account Number:";
            // 
            // accountNumberPlaceholder
            // 
            this.accountNumberPlaceholder.AutoSize = true;
            this.accountNumberPlaceholder.Location = new System.Drawing.Point(421, 101);
            this.accountNumberPlaceholder.Name = "accountNumberPlaceholder";
            this.accountNumberPlaceholder.Size = new System.Drawing.Size(142, 13);
            this.accountNumberPlaceholder.TabIndex = 3;
            this.accountNumberPlaceholder.Text = "account number placeholder";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Location = new System.Drawing.Point(204, 41);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(177, 13);
            this.headerLabel.TabIndex = 4;
            this.headerLabel.Text = "A new account has ben created for:";
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Location = new System.Drawing.Point(161, 298);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(75, 23);
            this.mainMenuButton.TabIndex = 5;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // workAccountButton
            // 
            this.workAccountButton.Location = new System.Drawing.Point(328, 298);
            this.workAccountButton.Name = "workAccountButton";
            this.workAccountButton.Size = new System.Drawing.Size(123, 23);
            this.workAccountButton.TabIndex = 6;
            this.workAccountButton.Text = "Work New Account";
            this.workAccountButton.UseVisualStyleBackColor = true;
            this.workAccountButton.Click += new System.EventHandler(this.workAccountButton_Click);
            // 
            // NewAccountInformationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 447);
            this.Controls.Add(this.workAccountButton);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.accountNumberPlaceholder);
            this.Controls.Add(this.accountNumberLabel);
            this.Controls.Add(this.accountNamePlaceholder);
            this.Controls.Add(this.accountNameLabel);
            this.Name = "NewAccountInformationView";
            this.Text = "Account Added";
            this.Load += new System.EventHandler(this.NewAccountInformationView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accountNameLabel;
        private System.Windows.Forms.Label accountNamePlaceholder;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.Label accountNumberPlaceholder;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Button workAccountButton;
    }
}