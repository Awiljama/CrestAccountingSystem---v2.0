using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CrestAccountingSystem
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {}

        private void loginButton_Click(object sender, EventArgs e)
        {

            employeeTableAdapter.Fill(crestAccountingDatabaseDataSet.Employee);
            var employees = from c in crestAccountingDatabaseDataSet.Employee 
                            where UserNametextBox.Text == c.UserName &&
                            passwordtextbox.Text == c.Password
                            select c;

            if (employees.Count() == 1)
            {
                MainMenu mainPage = new MainMenu();
                mainPage.loginPage = this;
                mainPage.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("User name or password is incorrect.");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please call the IT department at 614-355-0001");
        }

        private void debugLogin_Click(object sender, EventArgs e)
        {
            MainMenu mainPage = new MainMenu();
            mainPage.loginPage = this;
            mainPage.Show();
            Hide();
        }
        /*
        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            employeeBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(crestAccountingDatabaseDataSet);
        }*/
    }
    
}
