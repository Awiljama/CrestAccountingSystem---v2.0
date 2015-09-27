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
    public partial class AccountsPayable : AccountsReceivablePayable
    {
        public AccountsReceivable AccountsReceivable;
        public AccountsPayable() : base()
        {
            InitializeComponent();
        }

        override public void switchViewButton_Click(object sender, EventArgs e)
        {
            if (AccountsReceivable == null)
            {
                AccountsReceivable = new AccountsReceivable();
                AccountsReceivable.Account = Account;
                AccountsReceivable.AccountsPayable = this;
            }

            AccountsReceivable.Show();
            Hide();
        }

        private void AccountsPayable_Load(object sender, EventArgs e)
        {
            
        }
    }
}
