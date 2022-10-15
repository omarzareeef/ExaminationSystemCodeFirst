using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MetroSet_UI.Controls;
using MetroSet_UI.Forms;
using Microsoft.Win32;

namespace ExaminationSys
{
    public partial class Form1 : MetroSetForm
    {
       // FormAddStudent form = new FormAddStudent();

        Context con = new Context();

        public Form1()
        {

            InitializeComponent();
            #region What for Who

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\OurSettings");
            string role = "";
            //if it does exist, retrieve the stored values  
            if (key != null)
            {
                role = (string)key.GetValue("UserType");
                key.Close();
            }
            /*
            role = "InsTMan";
            role = "Ins";
            role = "Std";
            */
            if (role == "InsTMan")
            {
                Tabs.TabPages.Remove(Exams);
            }
            else if (role == "Ins")
            {
                Tabs.TabPages.Remove(Instructor);
                Tabs.TabPages.Remove(Student);
                Tabs.TabPages.Remove(Department);
                Tabs.TabPages.Remove(Branch);
                Tabs.TabPages.Remove(Intake);
                Tabs.TabPages.Remove(Track);
                Tabs.TabPages.Remove(Exams);
            }
            else if (role == "Std")
            {
                Tabs.TabPages.Remove(Instructor);
                Tabs.TabPages.Remove(Student);
                Tabs.TabPages.Remove(Department);
                Tabs.TabPages.Remove(Branch);
                Tabs.TabPages.Remove(Intake);
                Tabs.TabPages.Remove(Track);
                Tabs.TabPages.Remove(Creat_Exam);
                Tabs.TabPages.Remove(Student_for_Exam);
                Tabs.TabPages.Remove(Question_Pools);
            }
            else
            {
                Tabs.Visible = false;
            }
            #endregion


        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        //-----------------------Instructors------------------------------------

        #region For Instructor Only!

        #region Insert Button Instructor
        private void BtnNewInst_Click(object sender, EventArgs e)
        {
            FormInstructor form = new FormInstructor();
            form.ShowDialog();
        }
        #endregion


        #region Show Button 


        private void BtnShowInst_Click(object sender, EventArgs e)
        {
            using (SqlConnection sql = new SqlConnection(@"data source =.; initial catalog = ExaminationSystemCF; integrated security = True"))
            {
                sql.Open();
                Context con = new Context();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Instructors", sql);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                dataGridViewInst.DataSource = datatable;
                sql.Close();

            };
        }
        #endregion


        #region Update Button Instructor
        private void BtnUpdateIns_Click(object sender, EventArgs e)
        {
            try
            {
                var Name = txtName.Text;
                var UserName = txtUserNameIns.Text;
                var Password = txtPasswordIns.Text;
                var SuperID = txtSuperId.Text;
                // var User_ClassId = int.Parse(txtUserClassId.Text);
                var labId = int.Parse(lblUpdate.Text);
                Instructor instructor = con.Instructors.Where(i => i.InsId == labId).FirstOrDefault();
                instructor.InsName = Name;
                instructor.InsUserName = UserName;
                instructor.InsPassword = Password;
                instructor.SuperID = int.Parse(SuperID);
                // instructor.User_ClassId = User_ClassId;
                con.SaveChanges();
                using (SqlConnection sql = new SqlConnection(@"data source =.; initial catalog = ExaminationSystemCF; integrated security = True"))
                {
                    sql.Open();
                    Context con = new Context();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Instructors", sql);
                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);
                    dataGridViewInst.DataSource = datatable;
                    sql.Close();

                };
            }
            catch
            {
                MessageBox.Show("Can't Update!...");
            }
        }
        #endregion


        #region Delete Button Instructor
        private void BtnDeleteIns_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(@"data source =.; initial catalog = ExaminationSystemCF; integrated security = True"))
                {
                    sql.Open();
                    var username = lblDelete.Text;
                    var UserNameQuery = con.Instructors.Where(i => i.InsUserName == username).FirstOrDefault();
                    if (lblDelete.Text == username) //!=null
                    {
                        con.Instructors.Remove(UserNameQuery);
                        con.SaveChanges();
                        MessageBox.Show("Deleted Successfully!...");
                        SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM Instructors", sql);
                        DataTable dt = new DataTable();
                        ad.Fill(dt);
                        dataGridViewInst.DataSource = dt;
                        lblDelete.ResetText();
                    }
                    else
                    {
                        lblDelete.ResetText();
                       
                    }
                }
            }
            catch
            {
                MessageBox.Show("There is No Data!...");
            }
        }
        #endregion


        #region GridView Double Click
        private void dataGridViewInst_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewInst.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewInst.CurrentCell.Selected = true;
                lblDelete.Text = dataGridViewInst.Rows[e.RowIndex].Cells["InsUserName"].FormattedValue.ToString();
              
                txtName.Text = dataGridViewInst.Rows[e.RowIndex].Cells["InsName"].FormattedValue.ToString();
                txtUserNameIns.Text = dataGridViewInst.Rows[e.RowIndex].Cells["InsUserName"].FormattedValue.ToString();
                txtPasswordIns.Text = dataGridViewInst.Rows[e.RowIndex].Cells["InsPassword"].FormattedValue.ToString();
                txtSuperId.Text = dataGridViewInst.Rows[e.RowIndex].Cells["SuperID"].FormattedValue.ToString();
                //txtUserClassId.Text = dataGridViewInst.Rows[e.RowIndex].Cells["User_ClassId"].FormattedValue.ToString();

                lblUpdate.Text = dataGridViewInst.Rows[e.RowIndex].Cells["InsId"].FormattedValue.ToString();
            }
        }
        #endregion

        #endregion

        //-----------------------Students--------------------------------------

        #region  For Student Only!


        #region Insert Button Student


        private void BtnInsertStd_Click(object sender, EventArgs e)
        {
            FormAddStudent form = new FormAddStudent();
            form.ShowDialog();
        }


        #endregion

        #region Show Button   
        private void BtnShowStd_Click(object sender, EventArgs e)
        {
            using (SqlConnection sql = new SqlConnection(@"data source =.; initial catalog = ExaminationSystemCF; integrated security = True"))
            {
                sql.Open();
                Context con = new Context();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM Students", sql);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridViewStd.DataSource = dt;
                sql.Close();

            };
        }
        #endregion

        #region Update Button Student
        private void BtnUpdateStd_Click(object sender, EventArgs e)
        {
            try {
                var Name = txtStdName.Text;
                var Email = txtEmail.Text;
                var UserName = txtUserName.Text;
                var Password = txtPassword.Text;
                //  var User_ClassId = txtClassId.Text;
                var labelId = int.Parse(metroSetLabel5.Text);
                Student student = con.Students.Where(m => m.StdId == labelId).FirstOrDefault();
                student.StdName = Name;
                student.StdEmail = Email;
                student.StdUserName = UserName;
                student.StdPassword = Password;
                // student.User_ClassId = User_ClassId;
                con.SaveChanges();
                using (SqlConnection sql = new SqlConnection(@"data source =.; initial catalog = ExaminationSystemCF; integrated security = True"))
                {
                    sql.Open();
                    Context con = new Context();
                    SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM Students", sql);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    dataGridViewStd.DataSource = dt;
                    sql.Close();

                };
            }
            catch
            {
                MessageBox.Show("Can't Update!...");
            }
       }
        #endregion

        #region Delete Button Student
        private void BtnDeleteStd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(@"data source =.; initial catalog = ExaminationSystemCF; integrated security = True"))
                {
                    sql.Open();
                    var username = labeldelete.Text;
                    var UserNameQuery = con.Students.Where(s => s.StdUserName == username).FirstOrDefault();
                    if (labeldelete.Text == username) //!=null
                    {
                        con.Students.Remove(UserNameQuery);
                        con.SaveChanges();
                        MessageBox.Show("Deleted Successfully!...");
                        SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM Students", sql);
                        DataTable dt = new DataTable();
                        ad.Fill(dt);
                        dataGridViewStd.DataSource = dt;
                        labeldelete.ResetText();
                    }
                    else
                    {
                        labeldelete.ResetText();
                        
                    }
                }
            }
            catch
            {
                MessageBox.Show("There is No Data!... ");
            }
        }
        #endregion

        #region GridView Double Click
        private void dataGridViewStd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewStd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewStd.CurrentCell.Selected = true;
                labeldelete.Text = dataGridViewStd.Rows[e.RowIndex].Cells["StdUserName"].FormattedValue.ToString();
                
                txtStdName.Text = dataGridViewStd.Rows[e.RowIndex].Cells["StdName"].FormattedValue.ToString();
                txtEmail.Text = dataGridViewStd.Rows[e.RowIndex].Cells["StdEmail"].FormattedValue.ToString();
                txtUserName.Text = dataGridViewStd.Rows[e.RowIndex].Cells["StdUserName"].FormattedValue.ToString();
                txtPassword.Text = dataGridViewStd.Rows[e.RowIndex].Cells["StdPassword"].FormattedValue.ToString();
               // txtClassId.Text = dataGridViewStd.Rows[e.RowIndex].Cells["User_ClassId"].FormattedValue.ToString();

                metroSetLabel5.Text = dataGridViewStd.Rows[e.RowIndex].Cells["StdId"].FormattedValue.ToString();
            }
        }



        #endregion

        #endregion

        //---------------------------Branch-------------------------------------

        #region For Branch Only!


        #region Insert Button Branch
        private void BtnNewBranch_Click(object sender, EventArgs e)
        {
            FormAddBranch form = new FormAddBranch();
            form.ShowDialog();
        }

        #endregion

        #region Show Button   
        private void ShowBranch_Click(object sender, EventArgs e)
        {
            using (SqlConnection sql = new SqlConnection(@"data source =.; initial catalog = ExaminationSystemCF; integrated security = True"))
            {
                sql.Open();
                Context con = new Context();
                SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM Branches", sql);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                dataGridViewBran.DataSource = dt;        
                sql.Close();

            };
        }
        #endregion

        #region Update Button Student
        private void UpdateBranch_Click(object sender, EventArgs e)
        {
            try
            {
                var Name = txtNameBranche.Text;
                var labelId = int.Parse(LblUpdateBranch.Text);
                Branch branch = con.Branches.Where(m => m.BranchId == labelId).FirstOrDefault();
                branch.BranchName = Name;
                con.SaveChanges();
                using (SqlConnection sql = new SqlConnection(@"data source =.; initial catalog = ExaminationSystemCF; integrated security = True"))
                {
                    sql.Open();
                    Context con = new Context();
                    SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM Branches", sql);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    dataGridViewBran.DataSource = dt;
                    sql.Close();

                };
            }
            catch
            {
                MessageBox.Show("Can't Update!...");
            }
        }

        #endregion

        #region Delete Button Student
        private void DeleteBranch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(@"data source =.; initial catalog = ExaminationSystemCF; integrated security = True"))
                {
                    sql.Open();
                    var name = LblDeleteBranch.Text;
                    var NameQuery = con.Branches.Where(s => s.BranchName == name).FirstOrDefault();
                    if (LblDeleteBranch.Text == name) //!=null
                    {
                        con.Branches.Remove(NameQuery);
                        con.SaveChanges();
                        MessageBox.Show("Deleted Successfully!... ");
                        SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM Branches", sql);
                        DataTable dt = new DataTable();
                        ad.Fill(dt);
                        dataGridViewBran.DataSource = dt;
                        LblDeleteBranch.ResetText();
                    }
                };
            }
            catch
            {
                MessageBox.Show("There is No Data!...");
            }
        }
        #endregion

        #region GridView Double Click
        private void dataGridViewBran_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewBran.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewBran.CurrentCell.Selected = true;
                //delete
                LblDeleteBranch.Text = dataGridViewBran.Rows[e.RowIndex].Cells["BranchName"].FormattedValue.ToString();
                
                txtNameBranche.Text = dataGridViewBran.Rows[e.RowIndex].Cells["BranchName"].FormattedValue.ToString();
                //Update
                LblUpdateBranch.Text = dataGridViewBran.Rows[e.RowIndex].Cells["BranchId"].FormattedValue.ToString();
            }
        }















        #endregion

        #endregion

        

        
    }
}
