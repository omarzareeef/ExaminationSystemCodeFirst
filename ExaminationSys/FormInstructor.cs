using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSys
{
    public partial class FormInstructor : Form
    {
        public FormInstructor()
        {
            InitializeComponent();
        }
        #region Insert Instructor
        
        private void btnInsertInstructor_Click(object sender, EventArgs e)
        {
            try
            {
                Context con = new Context();
                Instructor ins = new Instructor() { InsName = txtName.Text, InsUserName = txtUserName.Text, InsPassword = txtPassword.Text, SuperID = int.Parse(txtSuperId.Text) };
                var inst = con.Instructors.Where(i => i.InsUserName == txtUserName.Text).FirstOrDefault();
                if (inst == null)
                {
                    con.Instructors.Add(ins);
                    con.SaveChanges();
                    MessageBox.Show("Data Saved Successfully!...");
                    txtName.ResetText();
                    txtUserName.ResetText();
                    txtPassword.ResetText();
                    txtSuperId.ResetText();
                }
            }
            
            catch
            {
                MessageBox.Show("Can't Save Data!...");
            }

        }
 

        #endregion

    }
}
