using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using DocumentFormat.OpenXml.Office2010.Excel;
using MetroFramework;


//Copy

namespace ExaminationSys
{
    public partial class Form1 : MetroSetForm
    {
        
        int id = 0;
        public Form1()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\OurSettings");
            
            InitializeComponent();

            id = (int)key.GetValue("ID");

            var crs = context.Courses.Where(i => i.InsId == id).Select(i => i.CrsTitle).ToList();
            comboxCourseName.Items.AddRange(crs.ToArray());

            #region What for Who

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

        #region Question View
        Context context = new Context();
        private void comboxQuestionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Context context = new Context();
            if (comboxQuestionType.SelectedIndex == 0)
            {
                txtTxtAnswer.Visible = false;
                txtTFAnswer.Visible = false;
                txtMSQAnswer.Visible = true;

                lblTxtAnswer.Visible = false;
                lblTFAnswer.Visible = false;
                lblMCQAnswer.Visible = true;

                comboxOperation.Visible = true;
                metroSetPanel1.Visible = true;

                txtID.ResetText();
                txtQuestionContent.ResetText();
                txtTFAnswer.ResetText();
                txtQuestionDegree.ResetText();
                txtChoiceA.ResetText();
                txtChoiceB.ResetText();
                txtChoiceC.ResetText();
                txtMSQAnswer.ResetText();
                txtTFAnswer.ResetText();
                txtTxtAnswer.ResetText();

                var MCQType = context.MCQuestions.Select(m => m).ToList();
                dataGridQuestions.DataSource = MCQType;
            }
            else if (comboxQuestionType.SelectedIndex == 1)
            {
                txtTxtAnswer.Visible = false;
                txtMSQAnswer.Visible = false;
                txtTFAnswer.Visible = true;

                lblTxtAnswer.Visible = false;
                lblMCQAnswer.Visible = false;
                lblTFAnswer.Visible = true;

                comboxOperation.Visible = true;
                metroSetPanel1.Visible = false;
                txtID.ResetText();
                txtQuestionContent.ResetText();
                txtTFAnswer.ResetText();
                txtQuestionDegree.ResetText();
                txtChoiceA.ResetText();
                txtChoiceB.ResetText();
                txtChoiceC.ResetText();
                txtMSQAnswer.ResetText();
                txtTFAnswer.ResetText();
                txtTxtAnswer.ResetText();
                var TFType = context.TFQuestions.Select(t => t).ToList();
                dataGridQuestions.DataSource = TFType;
            }
            else if (comboxQuestionType.SelectedIndex == 2)
            {
                txtTFAnswer.Visible = false;
                txtMSQAnswer.Visible = false;
                txtTxtAnswer.Visible = true;

                lblTFAnswer.Visible = false;
                lblMCQAnswer.Visible = false;
                lblTxtAnswer.Visible = true;

                comboxOperation.Visible = true;
                metroSetPanel1.Visible = false;
                txtID.ResetText();
                txtQuestionContent.ResetText();
                txtTFAnswer.ResetText();
                txtQuestionDegree.ResetText();
                txtChoiceA.ResetText();
                txtChoiceB.ResetText();
                txtChoiceC.ResetText();
                txtMSQAnswer.ResetText();
                txtTFAnswer.ResetText();
                txtTxtAnswer.ResetText();
                var TxtType = context.TxtQuestions.Select(x => x).ToList();
                dataGridQuestions.DataSource = TxtType;
            }

            else
            {
                metroSetPanel1.Visible = false;
                dataGridQuestions.DataSource = "No Data to Be Views";
            }
        }
        
        #endregion

        #region Question Select
        public void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (comboxQuestionType.SelectedIndex == 0)
                {
                    

                    if (dataGridQuestions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        dataGridQuestions.CurrentCell.Selected = true; ;
                        txtID.Text = dataGridQuestions.Rows[e.RowIndex].Cells["McqID"].FormattedValue.ToString();
                        txtQuestionContent.Text = dataGridQuestions.Rows[e.RowIndex].Cells["McqContent"].FormattedValue.ToString();
                        txtMSQAnswer.Text = dataGridQuestions.Rows[e.RowIndex].Cells["McqCorrectChoice"].FormattedValue.ToString();
                        txtChoiceA.Text = dataGridQuestions.Rows[e.RowIndex].Cells["Choice1"].FormattedValue.ToString();
                        txtChoiceB.Text = dataGridQuestions.Rows[e.RowIndex].Cells["Choice2"].FormattedValue.ToString();
                        txtChoiceC.Text = dataGridQuestions.Rows[e.RowIndex].Cells["Choice3"].FormattedValue.ToString();
                        txtQuestionDegree.Text = dataGridQuestions.Rows[e.RowIndex].Cells["McqFullDegree"].FormattedValue.ToString();
                        
                    }
                }
                else if (comboxQuestionType.SelectedIndex == 1)
                {
                    

                    if (dataGridQuestions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        dataGridQuestions.CurrentCell.Selected = true;
                        txtID.Text = dataGridQuestions.Rows[e.RowIndex].Cells["TfqId"].FormattedValue.ToString();
                        txtQuestionContent.Text = dataGridQuestions.Rows[e.RowIndex].Cells["TfqContent"].FormattedValue.ToString();
                        txtTFAnswer.Text = dataGridQuestions.Rows[e.RowIndex].Cells["TfqCorrectAnswer"].FormattedValue.ToString();
                        txtQuestionDegree.Text = dataGridQuestions.Rows[e.RowIndex].Cells["TfqFullDegree"].FormattedValue.ToString();
                        
                    }
                }
                else
                {
                    ;

                    if (dataGridQuestions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        dataGridQuestions.CurrentCell.Selected = true;
                        txtID.Text = dataGridQuestions.Rows[e.RowIndex].Cells["TxtId"].FormattedValue.ToString();
                        txtQuestionContent.Text = dataGridQuestions.Rows[e.RowIndex].Cells["TxtContent"].FormattedValue.ToString();
                        txtTxtAnswer.Text = dataGridQuestions.Rows[e.RowIndex].Cells["TxtBestAnswer"].FormattedValue.ToString();
                        txtQuestionDegree.Text = dataGridQuestions.Rows[e.RowIndex].Cells["TxtFullDegree"].FormattedValue.ToString();
                        
                    }
                }
            }
            catch
            {
                
            }
            

        }
        #endregion

        #region Operation Selection
        private void metroSetComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboxOperation.SelectedIndex == 0)
            {
                btnUpdateQuestion.Visible = false;
                btnAddQuestion.Visible = true;
            }
            else if(comboxOperation.SelectedIndex == 1)
            {
                btnUpdateQuestion.Visible = true;
                btnAddQuestion.Visible = false;
            }
            else
            {
                btnUpdateQuestion.Visible = false;
                btnAddQuestion.Visible = false;
            }
        }

        #endregion

        #region Submit Button

        #region ADD Operation
        private void metroSetTile1_Click(object sender, EventArgs e)
        {
            try
            {
                var QuestionContent = txtQuestionContent.Text;
                var TFAnswer = txtTFAnswer.Text;
                var TxtAnswer = txtTxtAnswer.Text;
                var FullDegree = int.Parse(txtQuestionDegree.Text);
                var ChoiceA = txtChoiceA.Text;
                var ChoiceB = txtChoiceB.Text;
                var ChoiceC = txtChoiceC.Text;
                var CorrectChoice = char.Parse(txtMSQAnswer.Text);
                var CourseTitle = comboxCourseName.Text.ToString();
                var CrsID = context.Courses.Where(c => c.InsId == id && c.CrsTitle == CourseTitle).Select(i => i.CrsId).FirstOrDefault();

                if (comboxOperation.SelectedIndex == 0 && comboxQuestionType.SelectedIndex == 0)
                {
                    

                    var MCQuestionQuery = new MCQuestion()
                    {
                        McqContent = QuestionContent,
                        McqCorrectChoice = CorrectChoice,
                        McqFullDegree = FullDegree,
                        Choice1 = ChoiceA,
                        Choice2 = ChoiceB,
                        Choice3 = ChoiceC,
                        CrsId = CrsID
                    };
                    context.MCQuestions.Add(MCQuestionQuery);
                    context.SaveChanges();
                    var MCQType = context.MCQuestions.Select(m => m).ToList();
                    dataGridQuestions.DataSource = MCQType;
                    MetroMessageBox.Show(this, "Done");
                }
                else if (comboxOperation.SelectedIndex == 0 && comboxQuestionType.SelectedIndex == 1)
                {
                    
                    var TFQuestionQuery = new TFQuestion()
                    {
                        TfqContent = QuestionContent,
                        TfqCorrectAnswer = TFAnswer,
                        TfqFullDegree = FullDegree
                    };
                    context.TFQuestions.Add(TFQuestionQuery);
                    context.SaveChanges();
                    var TFType = context.TFQuestions.Select(t => t).ToList();
                    dataGridQuestions.DataSource = TFType;
                }
                else if (comboxOperation.SelectedIndex == 0 && comboxQuestionType.SelectedIndex == 2)
                {
                    

                    var TextQuestionQuery = new TxtQuestion()
                    {
                        TxtContent = QuestionContent,
                        TxtBestAnswer = TxtAnswer,
                        TxtFullDegree = FullDegree
                    };
                    context.TxtQuestions.Add(TextQuestionQuery);
                    context.SaveChanges();
                    var TxtType = context.TxtQuestions.Select(x => x).ToList();
                    dataGridQuestions.DataSource = TxtType;
                }
            }
            //}
            catch
            {
                MetroMessageBox.Show(this, "No Data To Be Added or Missing Data or Wrong Data Type");
            }


        }


        #endregion

        #region UPDATE Operation

        private void metroSetTile2_Click(object sender, EventArgs e)
        {
            try
            {
                var QuestionID = int.Parse(txtID.Text);
                var QuestionContent = txtQuestionContent.Text;
                var TFAnswer = txtTFAnswer.Text;
                var TxtAnswer = txtTxtAnswer.Text;
                var FullDegree = int.Parse(txtQuestionDegree.Text);
                var ChoiceA = txtChoiceA.Text;
                var ChoiceB = txtChoiceB.Text;
                var ChoiceC = txtChoiceC.Text;
                var CorrectChoice = char.Parse(txtMSQAnswer.Text);
                var CourseTitle = comboxCourseName.Text.ToString();
                var CrsID = context.Courses.Where(c => c.InsId == id && c.CrsTitle == CourseTitle).Select(i => i.CrsId).FirstOrDefault();


                if (comboxOperation.SelectedIndex == 1 && comboxQuestionType.SelectedIndex == 0)
                {
                    MCQuestion mCQuestion = context.MCQuestions.Where(m => m.McqId == QuestionID).FirstOrDefault();

                    mCQuestion.McqContent = QuestionContent;
                    mCQuestion.McqCorrectChoice = CorrectChoice;
                    mCQuestion.McqFullDegree = FullDegree;
                    mCQuestion.Choice1 = ChoiceA;
                    mCQuestion.Choice2 = ChoiceB;
                    mCQuestion.Choice3 = ChoiceC;
                    mCQuestion.CrsId = CrsID;

                    context.SaveChanges();
                    var MCQType = context.MCQuestions.Select(m => m).ToList();
                    dataGridQuestions.DataSource = MCQType;
                }

                else if (comboxOperation.SelectedIndex == 1 && comboxQuestionType.SelectedIndex == 1)
                {
                    TFQuestion tFQuestion = context.TFQuestions.Where(t => t.TfqId == QuestionID).FirstOrDefault();

                    tFQuestion.TfqContent = QuestionContent;
                    tFQuestion.TfqCorrectAnswer = TFAnswer;
                    tFQuestion.TfqFullDegree = FullDegree;
                    tFQuestion.CrsId = CrsID;

                    context.SaveChanges();
                    var TFType = context.MCQuestions.Select(m => m).ToList();
                    dataGridQuestions.DataSource = TFType;
                }
                else if (comboxOperation.SelectedIndex == 1 && comboxQuestionType.SelectedIndex == 2)
                {
                    TxtQuestion textQuestion = context.TxtQuestions.Where(x => x.TxtId == QuestionID).FirstOrDefault();

                    textQuestion.TxtContent = QuestionContent;
                    textQuestion.TxtBestAnswer = TxtAnswer;
                    textQuestion.TxtFullDegree = FullDegree;
                    textQuestion.CrsId = CrsID;

                    context.SaveChanges();
                    var TxtType = context.MCQuestions.Select(x => x).ToList();
                    dataGridQuestions.DataSource = TxtType;

                }
            }
            catch
            {
                MetroMessageBox.Show(this, "No Data To Be Updated or Missing Data or Wrong Data Type");
                
            };
        }
        #endregion

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAddQuestion.Visible = false;
            btnUpdateQuestion.Visible = false;

            txtTxtAnswer.Visible = false;
            txtTFAnswer.Visible =  false;
            txtMSQAnswer.Visible = false;
                                   
            lblTxtAnswer.Visible = false;
            lblTFAnswer.Visible =  false;
            lblMCQAnswer.Visible = false;
        }

        
    }
}


