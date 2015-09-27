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
    partial class AccountsReceivablePayable : Form
    {
        protected static CTADataClassesDataContext dataContext;
        public MainMenu MainMenu { get; set; }
        protected AccountsReceivablePayable()
        {
            InitializeComponent();
        }

        private void AccountsReceivablePayable_Load(object sender, EventArgs e)
        {
            dataContext = new CTADataClassesDataContext();
        }

        private void SaveChanges()
        {
            dataContext.SubmitChanges();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            var saveChangesOnExit = MessageBox.Show("Save Changes Before Exiting?", "Save Changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch (saveChangesOnExit)
            {
                case DialogResult.Yes:
                    SaveChanges();
                    MainMenu.Show();
                    Close();
                    break;
                case DialogResult.No:
                    MainMenu.Show();
                    Close();
                    break;
                case DialogResult.Cancel:
                    return;
            }
        }

        
    }
}
