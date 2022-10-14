using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using Microsoft.Win32;

namespace ExaminationSys
{
    public partial class Form1 : MetroSetForm
    {
        Context db = new Context();
        RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\OurSettings");
        int id = 0;
        string role = "";
        public Form1()
        {
            InitializeComponent();
            id = (int)key.GetValue("ID");

            fillControls();

            #region Creating Exam

            #region Randomly

            #endregion

            #region Manually

            #endregion

            #endregion


            #region What for Who

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

        private void fillControls()
        {
            var crs = db.Courses.Where(i => i.InsId == id).Select(i => i.CrsTitle).ToList();
            comboxAvailCrsforIns.Items.AddRange(crs.ToArray());
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

        private void comboxCrtMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboxCrtMethod.SelectedItem.ToString() == "Randomly")
            {
                panelManually.Visible = false;
                panelRandomly.Visible = true;
            }
            else if (comboxCrtMethod.SelectedItem.ToString() == "Manually")
            {
                panelRandomly.Visible = false;
                panelManually.Visible = true;
            }
        }

        private void btnCrtExam_Click(object sender, EventArgs e)
        {
            if (checkIfNull(new ArrayList { datePckEndExam, datePckEndExam, comboxExamType,
                comboxCalc, comboxOpenBook, comboxInternet,
                txtNumMCQ, txtNumTFQ, txtNumTxtQ, txtDegMCQ, txtDegTFQ, txtDegTxtQ, comboxAvailCrsforIns}))
            {
                Exam exam = new Exam
                {
                    StartTime = datePckFirstExam.Value.Date,
                    EndTime = datePckEndExam.Value.Date,
                    IsCorrective = comboxExamType.SelectedItem == "Normal" ? false : true,
                };
                db.Exams.Add(exam);
                db.SaveChanges();

                int examId = db.Exams.Select(i => i.ExamId).Reverse().FirstOrDefault();
                Allowance allowance = new Allowance
                {
                    ExamId = examId,
                    Calculator = comboxCalc.SelectedItem == "Allowed" ? true : false,
                    OpenBook = comboxOpenBook.SelectedItem == "Allowed" ? true : false,
                    UseInternet = comboxInternet.SelectedItem == "Allowed" ? true : false,
                };
                db.Allowances.Add(allowance);

                var MCQst = db.MCQuestions.OrderBy(r => Guid.NewGuid()).Take(int.Parse(txtNumMCQ.Text)).ToList();
                var TFQst = db.TFQuestions.OrderBy(r => Guid.NewGuid()).Take(int.Parse(txtNumTFQ.Text)).ToList();
                var TxtQst = db.TxtQuestions.OrderBy(r => Guid.NewGuid()).Take(int.Parse(txtNumTxtQ.Text)).ToList();

                foreach (var item in MCQst)
                {
                    ExamQuestion examQuestion = new ExamQuestion
                    {
                        QstDegree = int.Parse(txtDegMCQ.Text),
                        QstType = "MCQ",
                        ExamId = examId,
                        MCQId = item.McqId,
                        CrsId = (int)item.CrsId
                    };
                    db.ExamQuestions.Add(examQuestion);
                }

                foreach (var item in TFQst)
                {
                    ExamQuestion examQuestion = new ExamQuestion
                    {
                        QstDegree = int.Parse(txtDegTFQ.Text),
                        QstType = "TFQ",
                        ExamId = examId,
                        TFQId = item.TfqId,
                        CrsId = (int)item.CrsId
                    };
                    db.ExamQuestions.Add(examQuestion);
                }

                foreach (var item in TxtQst)
                {
                    ExamQuestion examQuestion = new ExamQuestion
                    {
                        QstDegree = int.Parse(txtDegTxtQ.Text),
                        QstType = "TXQ",
                        ExamId = examId,
                        TxtQId = item.TxtQId,
                        CrsId = (int)item.CrsId
                    };
                    db.ExamQuestions.Add(examQuestion);
                }
                db.SaveChanges();
            }
            else
            {
                MetroSetMessageBox.Show(this, "Please fill all fields");
            }
        }

        private bool checkIfNull(ArrayList controls)
        {
            foreach (Control c in controls)
            {
                if (c is MetroSet_UI.Controls.MetroSetRichTextBox)
                {
                    if (c.Text == null)
                    {
                        return false;
                    }
                }
                else if (c is MetroSet_UI.Controls.MetroSetComboBox)
                {
                    if ((c as MetroSet_UI.Controls.MetroSetComboBox).SelectedItem == null)
                    {
                        return false;
                    }
                }
                else if (c is System.Windows.Forms.DateTimePicker)
                {
                    if ((c as System.Windows.Forms.DateTimePicker).Value == null)
                    {
                        return false;
                    }
                }

            }
            return true;
        }

        private void btnCrtManExam_Click(object sender, EventArgs e)
        {
            if (checkIfNull(new ArrayList { datePckEndExam, datePckEndExam, comboxExamType,
                comboxCalc, comboxOpenBook, comboxInternet,
                txtIdsManMCQ, txtIdsManTFQ, txtIdsManTxtQ, txtDegManMCQ, txtDegManTFQ, txtDegManTxtQ, comboxManAvailCrsforIns}))
            {
                Exam exam = new Exam
                {
                    StartTime = datePckFirstExam.Value.Date,
                    EndTime = datePckEndExam.Value.Date,
                    IsCorrective = comboxExamType.SelectedItem == "Normal" ? false : true,
                };
                db.Exams.Add(exam);
                db.SaveChanges();

                int examId = db.Exams.Select(i => i.ExamId).Reverse().FirstOrDefault();
                Allowance allowance = new Allowance
                {
                    ExamId = examId,
                    Calculator = comboxCalc.SelectedItem == "Allowed" ? true : false,
                    OpenBook = comboxOpenBook.SelectedItem == "Allowed" ? true : false,
                    UseInternet = comboxInternet.SelectedItem == "Allowed" ? true : false,
                };
                db.Allowances.Add(allowance);

                //var MCQst = db.MCQuestions.OrderBy(r => Guid.NewGuid()).Take(int.Parse(txtNumMCQ.Text)).ToList();
                //var TFQst = db.TFQuestions.OrderBy(r => Guid.NewGuid()).Take(int.Parse(txtNumTFQ.Text)).ToList();
                //var TxtQst = db.TxtQuestions.OrderBy(r => Guid.NewGuid()).Take(int.Parse(txtNumTxtQ.Text)).ToList();

                //foreach (var item in MCQst)
                //{
                //    ExamQuestion examQuestion = new ExamQuestion
                //    {
                //        QstDegree = int.Parse(txtDegMCQ.Text),
                //        QstType = "MCQ",
                //        ExamId = examId,
                //        MCQId = item.McqId,
                //        CrsId = (int)item.CrsId
                //    };
                //    db.ExamQuestions.Add(examQuestion);
                //}

                //foreach (var item in TFQst)
                //{
                //    ExamQuestion examQuestion = new ExamQuestion
                //    {
                //        QstDegree = int.Parse(txtDegTFQ.Text),
                //        QstType = "TFQ",
                //        ExamId = examId,
                //        TFQId = item.TfqId,
                //        CrsId = (int)item.CrsId
                //    };
                //    db.ExamQuestions.Add(examQuestion);
                //}

                //foreach (var item in TxtQst)
                //{
                //    ExamQuestion examQuestion = new ExamQuestion
                //    {
                //        QstDegree = int.Parse(txtDegTxtQ.Text),
                //        QstType = "TXQ",
                //        ExamId = examId,
                //        TxtQId = item.TxtQId,
                //        CrsId = (int)item.CrsId
                //    };
                //    db.ExamQuestions.Add(examQuestion);
                //}
                db.SaveChanges();
            }
            else
            {
                MetroSetMessageBox.Show(this, "Please fill all fields");
            }
        }
    }
}
