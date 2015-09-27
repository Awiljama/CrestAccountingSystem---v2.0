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
    public partial class AccountsReceivable : AccountsReceivablePayable
    {
        public AccountsPayable AccountsPayable;
        public AccountsReceivable() : base()
        {
            InitializeComponent();
        }

        override public void switchViewButton_Click(object sender, EventArgs e)
        {
            if (AccountsPayable == null)
            {
                AccountsPayable = new AccountsPayable();
                AccountsPayable.Account = Account;
                AccountsPayable.AccountsReceivable = this;
            }

            AccountsPayable.Show();
            Hide();
        }
    }
}
