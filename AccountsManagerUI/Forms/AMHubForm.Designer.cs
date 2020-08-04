namespace AccountsManagerUI.Forms
{
    partial class AMHubForm
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
            this.AMHubLabel = new System.Windows.Forms.Label();
            this.AMHubAccountsManagerLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UserFirstNameLabel = new System.Windows.Forms.Label();
            this.UserLastNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AMHubLabel
            // 
            this.AMHubLabel.AutoSize = true;
            this.AMHubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AMHubLabel.Location = new System.Drawing.Point(12, 48);
            this.AMHubLabel.Name = "AMHubLabel";
            this.AMHubLabel.Size = new System.Drawing.Size(80, 39);
            this.AMHubLabel.TabIndex = 0;
            this.AMHubLabel.Text = "Hub";
            // 
            // AMHubAccountsManagerLabel
            // 
            this.AMHubAccountsManagerLabel.AutoSize = true;
            this.AMHubAccountsManagerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AMHubAccountsManagerLabel.Location = new System.Drawing.Point(12, 9);
            this.AMHubAccountsManagerLabel.Name = "AMHubAccountsManagerLabel";
            this.AMHubAccountsManagerLabel.Size = new System.Drawing.Size(300, 39);
            this.AMHubAccountsManagerLabel.TabIndex = 0;
            this.AMHubAccountsManagerLabel.Text = "Accounts Manager";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 106);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(728, 343);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // UserFirstNameLabel
            // 
            this.UserFirstNameLabel.AutoSize = true;
            this.UserFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserFirstNameLabel.Location = new System.Drawing.Point(517, 20);
            this.UserFirstNameLabel.Name = "UserFirstNameLabel";
            this.UserFirstNameLabel.Size = new System.Drawing.Size(90, 25);
            this.UserFirstNameLabel.TabIndex = 2;
            this.UserFirstNameLabel.Text = "TestText";
            // 
            // UserLastNameLabel
            // 
            this.UserLastNameLabel.AutoSize = true;
            this.UserLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLastNameLabel.Location = new System.Drawing.Point(613, 20);
            this.UserLastNameLabel.Name = "UserLastNameLabel";
            this.UserLastNameLabel.Size = new System.Drawing.Size(90, 25);
            this.UserLastNameLabel.TabIndex = 2;
            this.UserLastNameLabel.Text = "TestText";
            // 
            // AMHubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 461);
            this.Controls.Add(this.UserLastNameLabel);
            this.Controls.Add(this.UserFirstNameLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.AMHubAccountsManagerLabel);
            this.Controls.Add(this.AMHubLabel);
            this.Name = "AMHubForm";
            this.Text = "Accounts Manager - Hub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AMHubLabel;
        private System.Windows.Forms.Label AMHubAccountsManagerLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label UserFirstNameLabel;
        private System.Windows.Forms.Label UserLastNameLabel;
    }
}