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
using MetroSet_UI.Controls;
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

                CreateMCQStructure("Omar", "1", "2", "3");
                
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

            var ExamCrs = (from EQ in db.ExamQuestions
                           join C in db.Courses on EQ.CrsId equals C.CrsId
                           where C.InsId == id
                           select C.CrsTitle).ToList();
            comboxAssignCourseNametoExam.Items.AddRange(ExamCrs.ToArray());

            var ExamStd = (from EQ in db.ExamQuestions
                           join BD in db.BranchDetails on EQ.CrsId equals BD.CrsId
                           select BD.Student.StdName).ToList();
            comboxAssignStdNametoExam.Items.AddRange(ExamStd.ToArray());
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

                int examId = db.Exams.Select(i => i.ExamId).Max();
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
                        TFXQId = item.TfqId,
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
                        TXQId = item.TxtId,
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

        void CreateMCQStructure(string QstContent, string Choice1, string Choice2, string Choice3)
        {
            MetroSetPanel panelMCQStructure = new MetroSetPanel();
            MetroSetLabel lblMCQContent = new MetroSetLabel();
            MetroSetRadioButton rdBtnMCQChoice1 = new MetroSetRadioButton();
            MetroSetRadioButton rdBtnMCQChoice2 = new MetroSetRadioButton();
            MetroSetRadioButton rdBtnMCQChoice3 = new MetroSetRadioButton();
            // 
            // lblMCQContent
            // 
            lblMCQContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            lblMCQContent.IsDerivedStyle = true;
            lblMCQContent.Location = new System.Drawing.Point(15, 19);
            lblMCQContent.Name = "lblMCQContent";
            lblMCQContent.Size = new System.Drawing.Size(916, 70);
            lblMCQContent.Style = MetroSet_UI.Enums.Style.Light;
            lblMCQContent.StyleManager = null;
            lblMCQContent.TabIndex = 0;
            lblMCQContent.Text = QstContent;
            lblMCQContent.ThemeAuthor = "Narwin";
            lblMCQContent.ThemeName = "MetroLite";
            // 
            // rdBtnMCQChoice1
            // 
            rdBtnMCQChoice1.BackgroundColor = System.Drawing.Color.White;
            rdBtnMCQChoice1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            rdBtnMCQChoice1.Checked = false;
            rdBtnMCQChoice1.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            rdBtnMCQChoice1.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            rdBtnMCQChoice1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            rdBtnMCQChoice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            rdBtnMCQChoice1.Group = 0;
            rdBtnMCQChoice1.IsDerivedStyle = true;
            rdBtnMCQChoice1.Location = new System.Drawing.Point(15, 105);
            rdBtnMCQChoice1.Name = "rdBtnMCQChoice1";
            rdBtnMCQChoice1.Size = new System.Drawing.Size(92, 17);
            rdBtnMCQChoice1.Style = MetroSet_UI.Enums.Style.Light;
            rdBtnMCQChoice1.StyleManager = null;
            rdBtnMCQChoice1.TabIndex = 1;
            rdBtnMCQChoice1.Text = Choice1;
            rdBtnMCQChoice1.ThemeAuthor = "Narwin";
            rdBtnMCQChoice1.ThemeName = "MetroLite";
            // 
            // rdBtnMCQChoice2
            // 
            rdBtnMCQChoice2.BackgroundColor = System.Drawing.Color.White;
            rdBtnMCQChoice2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            rdBtnMCQChoice2.Checked = false;
            rdBtnMCQChoice2.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            rdBtnMCQChoice2.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            rdBtnMCQChoice2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            rdBtnMCQChoice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            rdBtnMCQChoice2.Group = 0;
            rdBtnMCQChoice2.IsDerivedStyle = true;
            rdBtnMCQChoice2.Location = new System.Drawing.Point(232, 105);
            rdBtnMCQChoice2.Name = "rdBtnMCQChoice2";
            rdBtnMCQChoice2.Size = new System.Drawing.Size(92, 17);
            rdBtnMCQChoice2.Style = MetroSet_UI.Enums.Style.Light;
            rdBtnMCQChoice2.StyleManager = null;
            rdBtnMCQChoice2.TabIndex = 2;
            rdBtnMCQChoice2.Text = Choice2;
            rdBtnMCQChoice2.ThemeAuthor = "Narwin";
            rdBtnMCQChoice2.ThemeName = "MetroLite";
            // 
            // rdBtnMCQChoice3
            // 
            rdBtnMCQChoice3.BackgroundColor = System.Drawing.Color.White;
            rdBtnMCQChoice3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            rdBtnMCQChoice3.Checked = false;
            rdBtnMCQChoice3.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            rdBtnMCQChoice3.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            rdBtnMCQChoice3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            rdBtnMCQChoice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            rdBtnMCQChoice3.Group = 0;
            rdBtnMCQChoice3.IsDerivedStyle = true;
            rdBtnMCQChoice3.Location = new System.Drawing.Point(472, 105);
            rdBtnMCQChoice3.Name = "rdBtnMCQChoice3";
            rdBtnMCQChoice3.Size = new System.Drawing.Size(92, 17);
            rdBtnMCQChoice3.Style = MetroSet_UI.Enums.Style.Light;
            rdBtnMCQChoice3.StyleManager = null;
            rdBtnMCQChoice3.TabIndex = 3;
            rdBtnMCQChoice3.Text = Choice3;                             
            rdBtnMCQChoice3.ThemeAuthor = "Narwin";                     
            rdBtnMCQChoice3.ThemeName = "MetroLite";


            this.Exams.Controls.Add(panelMCQStructure);
            panelMCQStructure.SuspendLayout();                          
            panelMCQStructure.ResumeLayout(false);
        }
        void CreateTFQStructure(string QstContent)
        {
            MetroSetPanel panelTFQStructure = new MetroSetPanel();
            MetroSetLabel lblTFQContent = new MetroSetLabel();
            MetroSetRadioButton rdBtnTFQChoice1 = new MetroSetRadioButton();
            MetroSetRadioButton rdBtnTFQChoice2 = new MetroSetRadioButton();
            // 
            // lblTFQContent
            // 
            lblTFQContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            lblTFQContent.IsDerivedStyle = true;
            lblTFQContent.Location = new System.Drawing.Point(15, 19);
            lblTFQContent.Name = "lblMCQContent";
            lblTFQContent.Size = new System.Drawing.Size(916, 70);
            lblTFQContent.Style = MetroSet_UI.Enums.Style.Light;
            lblTFQContent.StyleManager = null;
            lblTFQContent.TabIndex = 0;
            lblTFQContent.Text = QstContent;
            lblTFQContent.ThemeAuthor = "Narwin";
            lblTFQContent.ThemeName = "MetroLite";
            // 
            // rdBtnMCQChoice1
            // 
            rdBtnTFQChoice1.BackgroundColor = System.Drawing.Color.White;
            rdBtnTFQChoice1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            rdBtnTFQChoice1.Checked = false;
            rdBtnTFQChoice1.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            rdBtnTFQChoice1.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            rdBtnTFQChoice1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            rdBtnTFQChoice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            rdBtnTFQChoice1.Group = 0;
            rdBtnTFQChoice1.IsDerivedStyle = true;
            rdBtnTFQChoice1.Location = new System.Drawing.Point(15, 105);
            rdBtnTFQChoice1.Name = "rdBtnMCQChoice1";
            rdBtnTFQChoice1.Size = new System.Drawing.Size(92, 17);
            rdBtnTFQChoice1.Style = MetroSet_UI.Enums.Style.Light;
            rdBtnTFQChoice1.StyleManager = null;
            rdBtnTFQChoice1.TabIndex = 1;
            rdBtnTFQChoice1.Text = "True";
            rdBtnTFQChoice1.ThemeAuthor = "Narwin";
            rdBtnTFQChoice1.ThemeName = "MetroLite";
            // 
            // rdBtnMCQChoice2
            // 
            rdBtnTFQChoice2.BackgroundColor = System.Drawing.Color.White;
            rdBtnTFQChoice2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            rdBtnTFQChoice2.Checked = false;
            rdBtnTFQChoice2.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            rdBtnTFQChoice2.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            rdBtnTFQChoice2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            rdBtnTFQChoice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            rdBtnTFQChoice2.Group = 0;
            rdBtnTFQChoice2.IsDerivedStyle = true;
            rdBtnTFQChoice2.Location = new System.Drawing.Point(232, 105);
            rdBtnTFQChoice2.Name = "rdBtnMCQChoice2";
            rdBtnTFQChoice2.Size = new System.Drawing.Size(92, 17);
            rdBtnTFQChoice2.Style = MetroSet_UI.Enums.Style.Light;
            rdBtnTFQChoice2.StyleManager = null;
            rdBtnTFQChoice2.TabIndex = 2;
            rdBtnTFQChoice2.Text = "False";
            rdBtnTFQChoice2.ThemeAuthor = "Narwin";
            rdBtnTFQChoice2.ThemeName = "MetroLite";


            this.Exams.Controls.Add(panelTFQStructure);
            panelTFQStructure.SuspendLayout();
            panelTFQStructure.ResumeLayout(false);
        }
        void CreateTxtQStructure(string QstContent)
        {
            MetroSetPanel panelTxtQStructure = new MetroSetPanel();
            MetroSetLabel lblTxtQContent = new MetroSetLabel();
            MetroSetTextBox txtTxtQAnswer = new MetroSetTextBox();
            // 
            // lblTxtQContent
            // 
            lblTxtQContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            lblTxtQContent.IsDerivedStyle = true;
            lblTxtQContent.Location = new System.Drawing.Point(15, 19);
            lblTxtQContent.Name = "lblMCQContent";
            lblTxtQContent.Size = new System.Drawing.Size(916, 70);
            lblTxtQContent.Style = MetroSet_UI.Enums.Style.Light;
            lblTxtQContent.StyleManager = null;
            lblTxtQContent.TabIndex = 0;
            lblTxtQContent.Text = QstContent;
            lblTxtQContent.ThemeAuthor = "Narwin";
            lblTxtQContent.ThemeName = "MetroLite";
            // 
            // txtTxtQAnswer
            // 
            this.txtTxtQAnswer.AutoCompleteCustomSource = null;
            this.txtTxtQAnswer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTxtQAnswer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTxtQAnswer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTxtQAnswer.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTxtQAnswer.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTxtQAnswer.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtTxtQAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTxtQAnswer.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtTxtQAnswer.Image = null;
            this.txtTxtQAnswer.IsDerivedStyle = true;
            this.txtTxtQAnswer.Lines = null;
            this.txtTxtQAnswer.Location = new System.Drawing.Point(15, 93);
            this.txtTxtQAnswer.MaxLength = 32767;
            this.txtTxtQAnswer.Multiline = false;
            this.txtTxtQAnswer.Name = "txtTxtQAnswer";
            this.txtTxtQAnswer.ReadOnly = false;
            this.txtTxtQAnswer.Size = new System.Drawing.Size(885, 27);
            this.txtTxtQAnswer.Style = MetroSet_UI.Enums.Style.Light;
            this.txtTxtQAnswer.StyleManager = null;
            this.txtTxtQAnswer.TabIndex = 1;
            this.txtTxtQAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTxtQAnswer.ThemeAuthor = "Narwin";
            this.txtTxtQAnswer.ThemeName = "MetroLite";
            this.txtTxtQAnswer.UseSystemPasswordChar = false;
            this.txtTxtQAnswer.WatermarkText = "";


            this.Exams.Controls.Add(panelTxtQStructure);
            panelTxtQStructure.SuspendLayout();
            panelTxtQStructure.ResumeLayout(false);
        }

        private void btnAssignStdtoExam_Click(object sender, EventArgs e)
        {

        }
    }
}
