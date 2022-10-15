using MetroSet_UI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExaminationSys
{
    public partial class FormAddStudent : Form
    {


        public FormAddStudent()
        {
            InitializeComponent();
        }

        #region  Insert
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Context con = new Context();
                Student std = new Student() { StdName = txtName.Text, StdEmail = txtEmail.Text, StdUserName = txtUserName.Text, StdPassword = txtPassword.Text };// , User_ClassId = txtUserClassId.Text };
                var st = con.Students.Where(i => i.StdUserName == txtUserName.Text).FirstOrDefault();
                if (st == null)
                {
                    con.Students.Add(std);
                    con.SaveChanges();
                    MessageBox.Show("Data Saved Successfully!...");
                    txtName.ResetText();
                    txtEmail.ResetText();
                    txtUserName.ResetText();
                    txtPassword.ResetText();

                }
               
            }
            catch
            {
                MessageBox.Show("Can't Insert Data!...");
            }
        }


        #endregion

       
    }
}

