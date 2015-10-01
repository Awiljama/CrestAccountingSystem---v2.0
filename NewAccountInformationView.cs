using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrestAccountingSystem
{
    public partial class NewAccountInformationView : Form
    {
        public MainMenu MainMenu;
        public CAAccount Account;
        public NewAccountInformationView()
        {
            InitializeComponent();
        }

        private void NewAccountInformationView_Load(object sender, EventArgs e)
        {
            accountNamePlaceholder.Text = Account.ContactInformation.AccountName;
            accountNumberPlaceholder.Text = Account.AccountNumber.ToString();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            Close();
            MainMenu.Show();
        }

        private void workAccountButton_Click(object sender, EventArgs e)
        {
            AccountsReceivablePayable accountReceivable = new AccountsReceivable();
            accountReceivable.Account = Account;
            accountReceivable.MainMenu = MainMenu;
            accountReceivable.Show();
            Close();
        }
    }
}
