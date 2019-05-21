using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompaniesAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Tree Companytree = new Tree();
        Tree temptree = new Tree();
        Company selectedcompany = new Company();


        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }

        //load csv file and store data into avl tree
        private void LoadCompanyButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadAllCompanies = new OpenFileDialog();
            loadAllCompanies.Title = "Please Select a File";
          
            
            if (loadAllCompanies.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] headers = new string[6];
                    string[] AllLines = new string[500000];
                    AllLines = System.IO.File.ReadAllLines(loadAllCompanies.FileName);
                    foreach(string line in AllLines)
                    {
                        if(line.StartsWith("Company"))
                        {
                            headers = line.Split(',');
                        }
                        else
                        {
                            string[] columns = line.Split(',');
                            

                            Company temp = new Company
                            {
                                Name = columns[0].Replace('_', ' '),
                                Netincome = Convert.ToDouble(columns[1]),
                                Opincome = Convert.ToDouble(columns[2]),
                                Totalassests = Convert.ToDouble(columns[3]),
                                Employees = Convert.ToInt32(columns[4]),
                                Buyers = columns[5].Replace('_', ' '),

                            };
                            Companytree.InsertItem(temp);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("File is already in use", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            refresh();
        }

        //shows details of selected company
        private void CompanyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedcompany = (Company)CompanyList.SelectedItem;
            nameTxtbox.Text = selectedcompany.Name;
            netincomeTextbox.Text = selectedcompany.Netincome.ToString();
            opincomeTextbox.Text = selectedcompany.Opincome.ToString();
            assestTextbox.Text = selectedcompany.Totalassests.ToString();
            empolyeeTextbox.Text = selectedcompany.Employees.ToString();
            buyerTextbox.Text = selectedcompany.Buyers;

        }


        //shows all companies, no. of companies, tree height
        private void refresh()
        {
            CompanyList.DataSource = Companytree.GetallCompanies();
            CompanyList.DisplayMember = "name";
            treeHeight.Text = "Height:" + Companytree.Height();
            numberCompanies.Text = "Number of Companies:" + Companytree.Count();
            
        }

        private void clearSearchbox()
        {
            foreach (Company result in temptree.GetallCompanies())
            {
                temptree.RemoveItem(result);
            }
        }


        //search box
        private void Searchbox_TextChanged(object sender, EventArgs e)
        {
            String search = searchbox.Text;
            if(string.IsNullOrWhiteSpace(search))
            {
                refresh();
                clearSearchbox();
                
            }
            else
            {
                foreach (Company company in Companytree.GetallCompanies())
                {
                    if (company.Name.ToLower().StartsWith(search.ToLower().Trim()))
                    {
                        temptree.InsertItem(company);
                    }
                }
                foreach (Company result in temptree.GetallCompanies())
                {
                    if (!result.Name.ToLower().StartsWith(search.ToLower().Trim()))
                    {
                        temptree.RemoveItem(result);
                    }
                }
                CompanyList.DataSource = temptree.GetallCompanies();
                CompanyList.DisplayMember = "name";
            }

        }

        //insert edited company and refresh list
        private void update()
        {
            Company updated = new Company();
            EditCompany(ref updated);
            Companytree.RemoveItem(selectedcompany);
            Companytree.InsertItem(updated);
            refresh();
        }


        //edit company details to the inputs in textboxes 
        private void EditCompany(ref Company updated)
        {
            updated.Name = nameTxtbox.Text;
            updated.Netincome = Convert.ToDouble(netincomeTextbox.Text);
            updated.Opincome = Convert.ToDouble(opincomeTextbox.Text);
            updated.Totalassests = Convert.ToDouble(assestTextbox.Text);
            updated.Employees = Convert.ToInt32(empolyeeTextbox.Text);
            updated.Buyers = buyerTextbox.Text;
            
            

        }


        


        //Edit Company button
        private void Button1_Click(object sender, EventArgs e)
        {
            update();
        }

        //remove selected company and refresh
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Companytree.RemoveItem(selectedcompany);
            refresh();
        }




        //save excel file with updated data
        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveCompanyFile = new SaveFileDialog();
            if(saveCompanyFile.ShowDialog() == DialogResult.OK)
            {
                string headers = "Company,NET income,Operating income,Total Assets,Number Employees,Buyers";
                String format = "{0},{1},{2},{3},{4},{5}";
                StreamWriter file;
                try
                {
                    file = new StreamWriter(saveCompanyFile.FileName);
                    file.WriteLine(headers);
                    foreach(Company company in Companytree.GetallCompanies())
                    {
                        file.WriteLine(String.Format(format, company.Name.Replace(' ', '_'), company.Netincome, company.Opincome, company.Totalassests, company.Employees, company.Buyers));
                    }
                    if (file != null)
                    {
                        file.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Error", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
