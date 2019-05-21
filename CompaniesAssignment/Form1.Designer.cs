namespace CompaniesAssignment
{
    partial class Form1
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
            this.loadCompanyButton = new System.Windows.Forms.Button();
            this.CompanyList = new System.Windows.Forms.ListBox();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.nameTxtbox = new System.Windows.Forms.TextBox();
            this.netincomeTextbox = new System.Windows.Forms.TextBox();
            this.opincomeTextbox = new System.Windows.Forms.TextBox();
            this.assestTextbox = new System.Windows.Forms.TextBox();
            this.empolyeeTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.treeHeight = new System.Windows.Forms.Label();
            this.numberCompanies = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.buyerTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadCompanyButton
            // 
            this.loadCompanyButton.Location = new System.Drawing.Point(13, 1);
            this.loadCompanyButton.Name = "loadCompanyButton";
            this.loadCompanyButton.Size = new System.Drawing.Size(134, 23);
            this.loadCompanyButton.TabIndex = 0;
            this.loadCompanyButton.Text = "Load Companies File";
            this.loadCompanyButton.UseVisualStyleBackColor = true;
            this.loadCompanyButton.Click += new System.EventHandler(this.LoadCompanyButton_Click);
            // 
            // CompanyList
            // 
            this.CompanyList.FormattingEnabled = true;
            this.CompanyList.Location = new System.Drawing.Point(445, 51);
            this.CompanyList.Name = "CompanyList";
            this.CompanyList.Size = new System.Drawing.Size(120, 212);
            this.CompanyList.TabIndex = 1;
            this.CompanyList.SelectedIndexChanged += new System.EventHandler(this.CompanyList_SelectedIndexChanged);
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(12, 102);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(134, 20);
            this.searchbox.TabIndex = 2;
            this.searchbox.TextChanged += new System.EventHandler(this.Searchbox_TextChanged);
            // 
            // nameTxtbox
            // 
            this.nameTxtbox.Location = new System.Drawing.Point(13, 339);
            this.nameTxtbox.Name = "nameTxtbox";
            this.nameTxtbox.Size = new System.Drawing.Size(100, 20);
            this.nameTxtbox.TabIndex = 3;
            // 
            // netincomeTextbox
            // 
            this.netincomeTextbox.Location = new System.Drawing.Point(119, 339);
            this.netincomeTextbox.Name = "netincomeTextbox";
            this.netincomeTextbox.Size = new System.Drawing.Size(100, 20);
            this.netincomeTextbox.TabIndex = 4;
            // 
            // opincomeTextbox
            // 
            this.opincomeTextbox.Location = new System.Drawing.Point(225, 339);
            this.opincomeTextbox.Name = "opincomeTextbox";
            this.opincomeTextbox.Size = new System.Drawing.Size(100, 20);
            this.opincomeTextbox.TabIndex = 5;
            // 
            // assestTextbox
            // 
            this.assestTextbox.Location = new System.Drawing.Point(331, 339);
            this.assestTextbox.Name = "assestTextbox";
            this.assestTextbox.Size = new System.Drawing.Size(100, 20);
            this.assestTextbox.TabIndex = 6;
            // 
            // empolyeeTextbox
            // 
            this.empolyeeTextbox.Location = new System.Drawing.Point(437, 339);
            this.empolyeeTextbox.Name = "empolyeeTextbox";
            this.empolyeeTextbox.Size = new System.Drawing.Size(100, 20);
            this.empolyeeTextbox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search for Company:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Net Income:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Op Income:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Assests:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "No. of Employees:";
            // 
            // treeHeight
            // 
            this.treeHeight.AutoSize = true;
            this.treeHeight.Location = new System.Drawing.Point(183, 51);
            this.treeHeight.Name = "treeHeight";
            this.treeHeight.Size = new System.Drawing.Size(35, 13);
            this.treeHeight.TabIndex = 14;
            this.treeHeight.Text = "label7";
            // 
            // numberCompanies
            // 
            this.numberCompanies.AutoSize = true;
            this.numberCompanies.Location = new System.Drawing.Point(254, 51);
            this.numberCompanies.Name = "numberCompanies";
            this.numberCompanies.Size = new System.Drawing.Size(35, 13);
            this.numberCompanies.TabIndex = 15;
            this.numberCompanies.Text = "label7";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(508, 375);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(150, 23);
            this.updateButton.TabIndex = 16;
            this.updateButton.Text = "Update Edited Company";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(12, 137);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(135, 23);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Delete Company";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // buyerTextbox
            // 
            this.buyerTextbox.Location = new System.Drawing.Point(543, 339);
            this.buyerTextbox.Name = "buyerTextbox";
            this.buyerTextbox.Size = new System.Drawing.Size(100, 20);
            this.buyerTextbox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(543, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Buyers";
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(13, 30);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(134, 23);
            this.saveFileButton.TabIndex = 20;
            this.saveFileButton.Text = "Save Companies File";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buyerTextbox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.numberCompanies);
            this.Controls.Add(this.treeHeight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empolyeeTextbox);
            this.Controls.Add(this.assestTextbox);
            this.Controls.Add(this.opincomeTextbox);
            this.Controls.Add(this.netincomeTextbox);
            this.Controls.Add(this.nameTxtbox);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.CompanyList);
            this.Controls.Add(this.loadCompanyButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadCompanyButton;
        private System.Windows.Forms.ListBox CompanyList;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.TextBox nameTxtbox;
        private System.Windows.Forms.TextBox netincomeTextbox;
        private System.Windows.Forms.TextBox opincomeTextbox;
        private System.Windows.Forms.TextBox assestTextbox;
        private System.Windows.Forms.TextBox empolyeeTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label treeHeight;
        private System.Windows.Forms.Label numberCompanies;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox buyerTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button saveFileButton;
    }
}

