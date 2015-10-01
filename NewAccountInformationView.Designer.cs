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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAccountInformationView));
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
            this.accountNameLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNameLabel.Location = new System.Drawing.Point(12, 101);
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Size = new System.Drawing.Size(90, 15);
            this.accountNameLabel.TabIndex = 0;
            this.accountNameLabel.Text = "Account Name:";
            // 
            // accountNamePlaceholder
            // 
            this.accountNamePlaceholder.AutoSize = true;
            this.accountNamePlaceholder.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNamePlaceholder.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.accountNamePlaceholder.Location = new System.Drawing.Point(108, 101);
            this.accountNamePlaceholder.Name = "accountNamePlaceholder";
            this.accountNamePlaceholder.Size = new System.Drawing.Size(190, 15);
            this.accountNamePlaceholder.TabIndex = 1;
            this.accountNamePlaceholder.Text = "Account Name Placeholder Label";
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumberLabel.Location = new System.Drawing.Point(410, 101);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(101, 15);
            this.accountNumberLabel.TabIndex = 2;
            this.accountNumberLabel.Text = "Account Number:";
            // 
            // accountNumberPlaceholder
            // 
            this.accountNumberPlaceholder.AutoSize = true;
            this.accountNumberPlaceholder.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumberPlaceholder.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.accountNumberPlaceholder.Location = new System.Drawing.Point(517, 101);
            this.accountNumberPlaceholder.Name = "accountNumberPlaceholder";
            this.accountNumberPlaceholder.Size = new System.Drawing.Size(164, 15);
            this.accountNumberPlaceholder.TabIndex = 3;
            this.accountNumberPlaceholder.Text = "account number placeholder";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(221, 41);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(250, 18);
            this.headerLabel.TabIndex = 4;
            this.headerLabel.Text = "A new account has ben created for:";
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuButton.Location = new System.Drawing.Point(159, 195);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(147, 23);
            this.mainMenuButton.TabIndex = 5;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // workAccountButton
            // 
            this.workAccountButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workAccountButton.Location = new System.Drawing.Point(386, 195);
            this.workAccountButton.Name = "workAccountButton";
            this.workAccountButton.Size = new System.Drawing.Size(147, 23);
            this.workAccountButton.TabIndex = 6;
            this.workAccountButton.Text = "Work New Account";
            this.workAccountButton.UseVisualStyleBackColor = true;
            this.workAccountButton.Click += new System.EventHandler(this.workAccountButton_Click);
            // 
            // NewAccountInformationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 274);
            this.Controls.Add(this.workAccountButton);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.accountNumberPlaceholder);
            this.Controls.Add(this.accountNumberLabel);
            this.Controls.Add(this.accountNamePlaceholder);
            this.Controls.Add(this.accountNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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