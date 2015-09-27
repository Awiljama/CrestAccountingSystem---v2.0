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
    public partial class GeneralJournal : Form
    {
        private static CTADataClassesDataContext dataContext;
        public MainMenu MainMenu { get; set; }
        public GeneralJournal()
        {
            InitializeComponent();
        }

        private void GeneralJournal_Load(object sender, EventArgs e)
        {
            dataContext = new CTADataClassesDataContext();
            dataGridView1.DataSource = from info in dataContext.Accounts
                                       select info;
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
