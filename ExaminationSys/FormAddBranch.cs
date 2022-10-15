using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ExaminationSys
{
    public partial class FormAddBranch : Form
    {
        public FormAddBranch()
        {
            InitializeComponent();
        }
        #region  Insert Branch
        private void BtnInsertBranch_Click(object sender, EventArgs e)
        {
            try
            {
                Context con = new Context();
                Branch branch = new Branch() { BranchName = txtNameBranch.Text };
                var brn = con.Branches.Where(i => i.BranchName == txtNameBranch.Text).FirstOrDefault();
                if (brn == null)
                {
                    con.Branches.Add(branch);
                    con.SaveChanges();
                    MessageBox.Show("Data Saved Successfully!...");
                    txtNameBranch.ResetText();
                }
              
            }
            catch
            {
                MessageBox.Show("Can't Insert!...");
            }
        }
        #endregion
    }
}
