namespace ExaminationSys
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tabs = new MetroSet_UI.Controls.MetroSetTabControl();
            this.Creat_Exam = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.lblCreationMethod = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblEndTime = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblExamType = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblStartTime = new MetroSet_UI.Controls.MetroSetLabel();
            this.panelRandomly = new MetroSet_UI.Controls.MetroSetPanel();
            this.txtDegMCQ = new MetroSet_UI.Controls.MetroSetRichTextBox();
            this.txtDegTxtQ = new MetroSet_UI.Controls.MetroSetRichTextBox();
            this.txtDegTFQ = new MetroSet_UI.Controls.MetroSetRichTextBox();
            this.txtNumTxtQ = new MetroSet_UI.Controls.MetroSetRichTextBox();
            this.txtNumTFQ = new MetroSet_UI.Controls.MetroSetRichTextBox();
            this.lblDegQst = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblNumQst = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblForTxtQ = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblForTFQ = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblForMCQ = new MetroSet_UI.Controls.MetroSetLabel();
            this.comboxAvailCrsforIns = new MetroSet_UI.Controls.MetroSetComboBox();
            this.txtNumMCQ = new MetroSet_UI.Controls.MetroSetRichTextBox();
            this.comboxExamType = new MetroSet_UI.Controls.MetroSetComboBox();
            this.datePckEndExam = new System.Windows.Forms.DateTimePicker();
            this.datePckFirstExam = new System.Windows.Forms.DateTimePicker();
            this.comboxCrtMethod = new MetroSet_UI.Controls.MetroSetComboBox();
            this.Branch = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.Student_for_Exam = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.Instructor = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.Student = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.Department = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.Intake = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.Track = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.Question_Pools = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.txtTxtAnswer = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblTxtAnswer = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblMCQAnswer = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtMSQAnswer = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btnUpdateQuestion = new MetroSet_UI.Controls.MetroSetTile();
            this.btnAddQuestion = new MetroSet_UI.Controls.MetroSetTile();
            this.dataGridQuestions = new MetroFramework.Controls.MetroGrid();
            this.metroSetPanel1 = new MetroSet_UI.Controls.MetroSetPanel();
            this.lblChoiceB = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblChoiceC = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtChoiceC = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtChoiceB = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtChoiceA = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblChoiceA = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtQuestionDegree = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtTFAnswer = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtQuestionContent = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtID = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblQuestionID = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblQuestionContent = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblTFAnswer = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblCourseID = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblQuestionFullDegree = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblOperation = new MetroSet_UI.Controls.MetroSetLabel();
            this.comboxOperation = new MetroSet_UI.Controls.MetroSetComboBox();
            this.lblQuestionType = new MetroSet_UI.Controls.MetroSetLabel();
            this.comboxQuestionType = new MetroSet_UI.Controls.MetroSetComboBox();
            this.Exams = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.btnLogOut = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.lblClose = new MetroSet_UI.Controls.MetroSetLabel();
            this.comboxCourseName = new MetroFramework.Controls.MetroComboBox();
            this.Tabs.SuspendLayout();
            this.Creat_Exam.SuspendLayout();
            this.panelRandomly.SuspendLayout();
            this.Question_Pools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuestions)).BeginInit();
            this.metroSetPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.Tabs.AnimateTime = 200;
            this.Tabs.BackgroundColor = System.Drawing.Color.White;
            this.Tabs.Controls.Add(this.Creat_Exam);
            this.Tabs.Controls.Add(this.Branch);
            this.Tabs.Controls.Add(this.Student_for_Exam);
            this.Tabs.Controls.Add(this.Instructor);
            this.Tabs.Controls.Add(this.Student);
            this.Tabs.Controls.Add(this.Department);
            this.Tabs.Controls.Add(this.Intake);
            this.Tabs.Controls.Add(this.Track);
            this.Tabs.Controls.Add(this.Question_Pools);
            this.Tabs.Controls.Add(this.Exams);
            this.Tabs.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tabs.IsDerivedStyle = true;
            this.Tabs.ItemSize = new System.Drawing.Size(100, 38);
            this.Tabs.Location = new System.Drawing.Point(15, 90);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 8;
            this.Tabs.SelectedTextColor = System.Drawing.Color.White;
            this.Tabs.Size = new System.Drawing.Size(997, 724);
            this.Tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Tabs.Speed = 100;
            this.Tabs.Style = MetroSet_UI.Enums.Style.Light;
            this.Tabs.StyleManager = null;
            this.Tabs.TabIndex = 1;
            this.Tabs.ThemeAuthor = "Narwin";
            this.Tabs.ThemeName = "MetroLite";
            this.Tabs.UnselectedTextColor = System.Drawing.Color.Gray;
            this.Tabs.UseAnimation = false;
            // 
            // Creat_Exam
            // 
            this.Creat_Exam.BaseColor = System.Drawing.Color.White;
            this.Creat_Exam.Controls.Add(this.lblCreationMethod);
            this.Creat_Exam.Controls.Add(this.lblEndTime);
            this.Creat_Exam.Controls.Add(this.lblExamType);
            this.Creat_Exam.Controls.Add(this.lblStartTime);
            this.Creat_Exam.Controls.Add(this.panelRandomly);
            this.Creat_Exam.Controls.Add(this.comboxExamType);
            this.Creat_Exam.Controls.Add(this.datePckEndExam);
            this.Creat_Exam.Controls.Add(this.datePckFirstExam);
            this.Creat_Exam.Controls.Add(this.comboxCrtMethod);
            this.Creat_Exam.Font = null;
            this.Creat_Exam.ImageIndex = 0;
            this.Creat_Exam.ImageKey = null;
            this.Creat_Exam.IsDerivedStyle = true;
            this.Creat_Exam.Location = new System.Drawing.Point(4, 42);
            this.Creat_Exam.Name = "Creat_Exam";
            this.Creat_Exam.Size = new System.Drawing.Size(989, 678);
            this.Creat_Exam.Style = MetroSet_UI.Enums.Style.Light;
            this.Creat_Exam.StyleManager = null;
            this.Creat_Exam.TabIndex = 6;
            this.Creat_Exam.Text = "Creat_Exam";
            this.Creat_Exam.ThemeAuthor = "Narwin";
            this.Creat_Exam.ThemeName = "MetroLite";
            this.Creat_Exam.ToolTipText = null;
            // 
            // lblCreationMethod
            // 
            this.lblCreationMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCreationMethod.IsDerivedStyle = true;
            this.lblCreationMethod.Location = new System.Drawing.Point(497, 109);
            this.lblCreationMethod.Name = "lblCreationMethod";
            this.lblCreationMethod.Size = new System.Drawing.Size(132, 23);
            this.lblCreationMethod.Style = MetroSet_UI.Enums.Style.Light;
            this.lblCreationMethod.StyleManager = null;
            this.lblCreationMethod.TabIndex = 8;
            this.lblCreationMethod.Text = "Creation Method";
            this.lblCreationMethod.ThemeAuthor = "Narwin";
            this.lblCreationMethod.ThemeName = "MetroLite";
            // 
            // lblEndTime
            // 
            this.lblEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEndTime.IsDerivedStyle = true;
            this.lblEndTime.Location = new System.Drawing.Point(157, 109);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(89, 23);
            this.lblEndTime.Style = MetroSet_UI.Enums.Style.Light;
            this.lblEndTime.StyleManager = null;
            this.lblEndTime.TabIndex = 7;
            this.lblEndTime.Text = "End Time";
            this.lblEndTime.ThemeAuthor = "Narwin";
            this.lblEndTime.ThemeName = "MetroLite";
            // 
            // lblExamType
            // 
            this.lblExamType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblExamType.IsDerivedStyle = true;
            this.lblExamType.Location = new System.Drawing.Point(497, 35);
            this.lblExamType.Name = "lblExamType";
            this.lblExamType.Size = new System.Drawing.Size(100, 23);
            this.lblExamType.Style = MetroSet_UI.Enums.Style.Light;
            this.lblExamType.StyleManager = null;
            this.lblExamType.TabIndex = 6;
            this.lblExamType.Text = "Exam Type";
            this.lblExamType.ThemeAuthor = "Narwin";
            this.lblExamType.ThemeName = "MetroLite";
            // 
            // lblStartTime
            // 
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStartTime.IsDerivedStyle = true;
            this.lblStartTime.Location = new System.Drawing.Point(157, 35);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(89, 23);
            this.lblStartTime.Style = MetroSet_UI.Enums.Style.Light;
            this.lblStartTime.StyleManager = null;
            this.lblStartTime.TabIndex = 5;
            this.lblStartTime.Text = "Start Time";
            this.lblStartTime.ThemeAuthor = "Narwin";
            this.lblStartTime.ThemeName = "MetroLite";
            // 
            // panelRandomly
            // 
            this.panelRandomly.BackgroundColor = System.Drawing.Color.White;
            this.panelRandomly.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.panelRandomly.BorderThickness = 1;
            this.panelRandomly.Controls.Add(this.txtDegMCQ);
            this.panelRandomly.Controls.Add(this.txtDegTxtQ);
            this.panelRandomly.Controls.Add(this.txtDegTFQ);
            this.panelRandomly.Controls.Add(this.txtNumTxtQ);
            this.panelRandomly.Controls.Add(this.txtNumTFQ);
            this.panelRandomly.Controls.Add(this.lblDegQst);
            this.panelRandomly.Controls.Add(this.lblNumQst);
            this.panelRandomly.Controls.Add(this.lblForTxtQ);
            this.panelRandomly.Controls.Add(this.lblForTFQ);
            this.panelRandomly.Controls.Add(this.lblForMCQ);
            this.panelRandomly.Controls.Add(this.comboxAvailCrsforIns);
            this.panelRandomly.Controls.Add(this.txtNumMCQ);
            this.panelRandomly.IsDerivedStyle = true;
            this.panelRandomly.Location = new System.Drawing.Point(157, 166);
            this.panelRandomly.Name = "panelRandomly";
            this.panelRandomly.Size = new System.Drawing.Size(660, 213);
            this.panelRandomly.Style = MetroSet_UI.Enums.Style.Light;
            this.panelRandomly.StyleManager = null;
            this.panelRandomly.TabIndex = 4;
            this.panelRandomly.ThemeAuthor = "Narwin";
            this.panelRandomly.ThemeName = "MetroLite";
            this.panelRandomly.Visible = false;
            // 
            // txtDegMCQ
            // 
            this.txtDegMCQ.AutoWordSelection = false;
            this.txtDegMCQ.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtDegMCQ.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtDegMCQ.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtDegMCQ.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtDegMCQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDegMCQ.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtDegMCQ.IsDerivedStyle = true;
            this.txtDegMCQ.Lines = null;
            this.txtDegMCQ.Location = new System.Drawing.Point(265, 100);
            this.txtDegMCQ.MaxLength = 32767;
            this.txtDegMCQ.Name = "txtDegMCQ";
            this.txtDegMCQ.ReadOnly = false;
            this.txtDegMCQ.Size = new System.Drawing.Size(75, 29);
            this.txtDegMCQ.Style = MetroSet_UI.Enums.Style.Light;
            this.txtDegMCQ.StyleManager = null;
            this.txtDegMCQ.TabIndex = 17;
            this.txtDegMCQ.ThemeAuthor = "Narwin";
            this.txtDegMCQ.ThemeName = "MetroLite";
            this.txtDegMCQ.WordWrap = true;
            // 
            // txtDegTxtQ
            // 
            this.txtDegTxtQ.AutoWordSelection = false;
            this.txtDegTxtQ.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtDegTxtQ.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtDegTxtQ.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtDegTxtQ.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtDegTxtQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDegTxtQ.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtDegTxtQ.IsDerivedStyle = true;
            this.txtDegTxtQ.Lines = null;
            this.txtDegTxtQ.Location = new System.Drawing.Point(541, 100);
            this.txtDegTxtQ.MaxLength = 32767;
            this.txtDegTxtQ.Name = "txtDegTxtQ";
            this.txtDegTxtQ.ReadOnly = false;
            this.txtDegTxtQ.Size = new System.Drawing.Size(75, 29);
            this.txtDegTxtQ.Style = MetroSet_UI.Enums.Style.Light;
            this.txtDegTxtQ.StyleManager = null;
            this.txtDegTxtQ.TabIndex = 16;
            this.txtDegTxtQ.ThemeAuthor = "Narwin";
            this.txtDegTxtQ.ThemeName = "MetroLite";
            this.txtDegTxtQ.WordWrap = true;
            // 
            // txtDegTFQ
            // 
            this.txtDegTFQ.AutoWordSelection = false;
            this.txtDegTFQ.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtDegTFQ.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtDegTFQ.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtDegTFQ.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtDegTFQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDegTFQ.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtDegTFQ.IsDerivedStyle = true;
            this.txtDegTFQ.Lines = null;
            this.txtDegTFQ.Location = new System.Drawing.Point(397, 100);
            this.txtDegTFQ.MaxLength = 32767;
            this.txtDegTFQ.Name = "txtDegTFQ";
            this.txtDegTFQ.ReadOnly = false;
            this.txtDegTFQ.Size = new System.Drawing.Size(75, 29);
            this.txtDegTFQ.Style = MetroSet_UI.Enums.Style.Light;
            this.txtDegTFQ.StyleManager = null;
            this.txtDegTFQ.TabIndex = 15;
            this.txtDegTFQ.ThemeAuthor = "Narwin";
            this.txtDegTFQ.ThemeName = "MetroLite";
            this.txtDegTFQ.WordWrap = true;
            // 
            // txtNumTxtQ
            // 
            this.txtNumTxtQ.AutoWordSelection = false;
            this.txtNumTxtQ.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtNumTxtQ.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNumTxtQ.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtNumTxtQ.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtNumTxtQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTxtQ.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtNumTxtQ.IsDerivedStyle = true;
            this.txtNumTxtQ.Lines = null;
            this.txtNumTxtQ.Location = new System.Drawing.Point(541, 40);
            this.txtNumTxtQ.MaxLength = 32767;
            this.txtNumTxtQ.Name = "txtNumTxtQ";
            this.txtNumTxtQ.ReadOnly = false;
            this.txtNumTxtQ.Size = new System.Drawing.Size(75, 23);
            this.txtNumTxtQ.Style = MetroSet_UI.Enums.Style.Light;
            this.txtNumTxtQ.StyleManager = null;
            this.txtNumTxtQ.TabIndex = 13;
            this.txtNumTxtQ.ThemeAuthor = "Narwin";
            this.txtNumTxtQ.ThemeName = "MetroLite";
            this.txtNumTxtQ.WordWrap = true;
            // 
            // txtNumTFQ
            // 
            this.txtNumTFQ.AutoWordSelection = false;
            this.txtNumTFQ.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtNumTFQ.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNumTFQ.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtNumTFQ.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtNumTFQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTFQ.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtNumTFQ.IsDerivedStyle = true;
            this.txtNumTFQ.Lines = null;
            this.txtNumTFQ.Location = new System.Drawing.Point(397, 40);
            this.txtNumTFQ.MaxLength = 32767;
            this.txtNumTFQ.Name = "txtNumTFQ";
            this.txtNumTFQ.ReadOnly = false;
            this.txtNumTFQ.Size = new System.Drawing.Size(75, 23);
            this.txtNumTFQ.Style = MetroSet_UI.Enums.Style.Light;
            this.txtNumTFQ.StyleManager = null;
            this.txtNumTFQ.TabIndex = 12;
            this.txtNumTFQ.ThemeAuthor = "Narwin";
            this.txtNumTFQ.ThemeName = "MetroLite";
            this.txtNumTFQ.WordWrap = true;
            // 
            // lblDegQst
            // 
            this.lblDegQst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDegQst.IsDerivedStyle = true;
            this.lblDegQst.Location = new System.Drawing.Point(19, 106);
            this.lblDegQst.Name = "lblDegQst";
            this.lblDegQst.Size = new System.Drawing.Size(197, 23);
            this.lblDegQst.Style = MetroSet_UI.Enums.Style.Light;
            this.lblDegQst.StyleManager = null;
            this.lblDegQst.TabIndex = 11;
            this.lblDegQst.Text = "Degree of each Question";
            this.lblDegQst.ThemeAuthor = "Narwin";
            this.lblDegQst.ThemeName = "MetroLite";
            // 
            // lblNumQst
            // 
            this.lblNumQst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNumQst.IsDerivedStyle = true;
            this.lblNumQst.Location = new System.Drawing.Point(19, 46);
            this.lblNumQst.Name = "lblNumQst";
            this.lblNumQst.Size = new System.Drawing.Size(197, 23);
            this.lblNumQst.Style = MetroSet_UI.Enums.Style.Light;
            this.lblNumQst.StyleManager = null;
            this.lblNumQst.TabIndex = 10;
            this.lblNumQst.Text = "Number of Questions";
            this.lblNumQst.ThemeAuthor = "Narwin";
            this.lblNumQst.ThemeName = "MetroLite";
            // 
            // lblForTxtQ
            // 
            this.lblForTxtQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblForTxtQ.IsDerivedStyle = true;
            this.lblForTxtQ.Location = new System.Drawing.Point(541, 11);
            this.lblForTxtQ.Name = "lblForTxtQ";
            this.lblForTxtQ.Size = new System.Drawing.Size(75, 23);
            this.lblForTxtQ.Style = MetroSet_UI.Enums.Style.Light;
            this.lblForTxtQ.StyleManager = null;
            this.lblForTxtQ.TabIndex = 9;
            this.lblForTxtQ.Text = "TxtQ";
            this.lblForTxtQ.ThemeAuthor = "Narwin";
            this.lblForTxtQ.ThemeName = "MetroLite";
            // 
            // lblForTFQ
            // 
            this.lblForTFQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblForTFQ.IsDerivedStyle = true;
            this.lblForTFQ.Location = new System.Drawing.Point(397, 11);
            this.lblForTFQ.Name = "lblForTFQ";
            this.lblForTFQ.Size = new System.Drawing.Size(75, 23);
            this.lblForTFQ.Style = MetroSet_UI.Enums.Style.Light;
            this.lblForTFQ.StyleManager = null;
            this.lblForTFQ.TabIndex = 8;
            this.lblForTFQ.Text = "for TFQ";
            this.lblForTFQ.ThemeAuthor = "Narwin";
            this.lblForTFQ.ThemeName = "MetroLite";
            // 
            // lblForMCQ
            // 
            this.lblForMCQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblForMCQ.IsDerivedStyle = true;
            this.lblForMCQ.Location = new System.Drawing.Point(265, 11);
            this.lblForMCQ.Name = "lblForMCQ";
            this.lblForMCQ.Size = new System.Drawing.Size(75, 23);
            this.lblForMCQ.Style = MetroSet_UI.Enums.Style.Light;
            this.lblForMCQ.StyleManager = null;
            this.lblForMCQ.TabIndex = 7;
            this.lblForMCQ.Text = "for MCQ";
            this.lblForMCQ.ThemeAuthor = "Narwin";
            this.lblForMCQ.ThemeName = "MetroLite";
            // 
            // comboxAvailCrsforIns
            // 
            this.comboxAvailCrsforIns.AllowDrop = true;
            this.comboxAvailCrsforIns.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboxAvailCrsforIns.BackColor = System.Drawing.Color.Transparent;
            this.comboxAvailCrsforIns.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.comboxAvailCrsforIns.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboxAvailCrsforIns.CausesValidation = false;
            this.comboxAvailCrsforIns.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.comboxAvailCrsforIns.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.comboxAvailCrsforIns.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.comboxAvailCrsforIns.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboxAvailCrsforIns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxAvailCrsforIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboxAvailCrsforIns.FormattingEnabled = true;
            this.comboxAvailCrsforIns.IsDerivedStyle = true;
            this.comboxAvailCrsforIns.ItemHeight = 20;
            this.comboxAvailCrsforIns.Location = new System.Drawing.Point(265, 153);
            this.comboxAvailCrsforIns.Name = "comboxAvailCrsforIns";
            this.comboxAvailCrsforIns.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.comboxAvailCrsforIns.SelectedItemForeColor = System.Drawing.Color.White;
            this.comboxAvailCrsforIns.Size = new System.Drawing.Size(121, 26);
            this.comboxAvailCrsforIns.Style = MetroSet_UI.Enums.Style.Light;
            this.comboxAvailCrsforIns.StyleManager = null;
            this.comboxAvailCrsforIns.TabIndex = 6;
            this.comboxAvailCrsforIns.ThemeAuthor = "Narwin";
            this.comboxAvailCrsforIns.ThemeName = "MetroLite";
            // 
            // txtNumMCQ
            // 
            this.txtNumMCQ.AutoWordSelection = false;
            this.txtNumMCQ.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtNumMCQ.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNumMCQ.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtNumMCQ.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtNumMCQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumMCQ.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtNumMCQ.IsDerivedStyle = true;
            this.txtNumMCQ.Lines = null;
            this.txtNumMCQ.Location = new System.Drawing.Point(265, 40);
            this.txtNumMCQ.MaxLength = 32767;
            this.txtNumMCQ.Name = "txtNumMCQ";
            this.txtNumMCQ.ReadOnly = false;
            this.txtNumMCQ.Size = new System.Drawing.Size(75, 29);
            this.txtNumMCQ.Style = MetroSet_UI.Enums.Style.Light;
            this.txtNumMCQ.StyleManager = null;
            this.txtNumMCQ.TabIndex = 0;
            this.txtNumMCQ.ThemeAuthor = "Narwin";
            this.txtNumMCQ.ThemeName = "MetroLite";
            this.txtNumMCQ.WordWrap = true;
            // 
            // comboxExamType
            // 
            this.comboxExamType.AllowDrop = true;
            this.comboxExamType.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboxExamType.BackColor = System.Drawing.Color.Transparent;
            this.comboxExamType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.comboxExamType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboxExamType.CausesValidation = false;
            this.comboxExamType.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.comboxExamType.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.comboxExamType.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.comboxExamType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboxExamType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxExamType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboxExamType.FormattingEnabled = true;
            this.comboxExamType.IsDerivedStyle = true;
            this.comboxExamType.ItemHeight = 20;
            this.comboxExamType.Items.AddRange(new object[] {
            "Normal",
            "Corrective"});
            this.comboxExamType.Location = new System.Drawing.Point(651, 32);
            this.comboxExamType.Name = "comboxExamType";
            this.comboxExamType.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.comboxExamType.SelectedItemForeColor = System.Drawing.Color.White;
            this.comboxExamType.Size = new System.Drawing.Size(166, 26);
            this.comboxExamType.Style = MetroSet_UI.Enums.Style.Light;
            this.comboxExamType.StyleManager = null;
            this.comboxExamType.TabIndex = 3;
            this.comboxExamType.ThemeAuthor = "Narwin";
            this.comboxExamType.ThemeName = "MetroLite";
            this.comboxExamType.Visible = false;
            // 
            // datePckEndExam
            // 
            this.datePckEndExam.Location = new System.Drawing.Point(263, 109);
            this.datePckEndExam.Name = "datePckEndExam";
            this.datePckEndExam.Size = new System.Drawing.Size(196, 26);
            this.datePckEndExam.TabIndex = 2;
            // 
            // datePckFirstExam
            // 
            this.datePckFirstExam.Location = new System.Drawing.Point(263, 35);
            this.datePckFirstExam.Name = "datePckFirstExam";
            this.datePckFirstExam.Size = new System.Drawing.Size(196, 26);
            this.datePckFirstExam.TabIndex = 1;
            // 
            // comboxCrtMethod
            // 
            this.comboxCrtMethod.AllowDrop = true;
            this.comboxCrtMethod.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboxCrtMethod.BackColor = System.Drawing.Color.Transparent;
            this.comboxCrtMethod.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.comboxCrtMethod.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboxCrtMethod.CausesValidation = false;
            this.comboxCrtMethod.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.comboxCrtMethod.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.comboxCrtMethod.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.comboxCrtMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboxCrtMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxCrtMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboxCrtMethod.FormattingEnabled = true;
            this.comboxCrtMethod.IsDerivedStyle = true;
            this.comboxCrtMethod.ItemHeight = 20;
            this.comboxCrtMethod.Items.AddRange(new object[] {
            "Randomly",
            "Manually"});
            this.comboxCrtMethod.Location = new System.Drawing.Point(651, 103);
            this.comboxCrtMethod.Name = "comboxCrtMethod";
            this.comboxCrtMethod.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.comboxCrtMethod.SelectedItemForeColor = System.Drawing.Color.White;
            this.comboxCrtMethod.Size = new System.Drawing.Size(166, 26);
            this.comboxCrtMethod.Style = MetroSet_UI.Enums.Style.Light;
            this.comboxCrtMethod.StyleManager = null;
            this.comboxCrtMethod.TabIndex = 0;
            this.comboxCrtMethod.ThemeAuthor = "Narwin";
            this.comboxCrtMethod.ThemeName = "MetroLite";
            // 
            // Branch
            // 
            this.Branch.BaseColor = System.Drawing.Color.White;
            this.Branch.Font = null;
            this.Branch.ImageIndex = 0;
            this.Branch.ImageKey = null;
            this.Branch.IsDerivedStyle = true;
            this.Branch.Location = new System.Drawing.Point(4, 42);
            this.Branch.Name = "Branch";
            this.Branch.Size = new System.Drawing.Size(989, 678);
            this.Branch.Style = MetroSet_UI.Enums.Style.Light;
            this.Branch.StyleManager = null;
            this.Branch.TabIndex = 5;
            this.Branch.Text = "Branch";
            this.Branch.ThemeAuthor = "Narwin";
            this.Branch.ThemeName = "MetroLite";
            this.Branch.ToolTipText = null;
            // 
            // Student_for_Exam
            // 
            this.Student_for_Exam.BaseColor = System.Drawing.Color.White;
            this.Student_for_Exam.Font = null;
            this.Student_for_Exam.ImageIndex = 0;
            this.Student_for_Exam.ImageKey = null;
            this.Student_for_Exam.IsDerivedStyle = true;
            this.Student_for_Exam.Location = new System.Drawing.Point(4, 42);
            this.Student_for_Exam.Name = "Student_for_Exam";
            this.Student_for_Exam.Size = new System.Drawing.Size(989, 678);
            this.Student_for_Exam.Style = MetroSet_UI.Enums.Style.Light;
            this.Student_for_Exam.StyleManager = null;
            this.Student_for_Exam.TabIndex = 7;
            this.Student_for_Exam.Text = "Student_for_Exam";
            this.Student_for_Exam.ThemeAuthor = "Narwin";
            this.Student_for_Exam.ThemeName = "MetroLite";
            this.Student_for_Exam.ToolTipText = null;
            // 
            // Instructor
            // 
            this.Instructor.BaseColor = System.Drawing.Color.White;
            this.Instructor.Font = null;
            this.Instructor.ImageIndex = 0;
            this.Instructor.ImageKey = null;
            this.Instructor.IsDerivedStyle = true;
            this.Instructor.Location = new System.Drawing.Point(4, 42);
            this.Instructor.Name = "Instructor";
            this.Instructor.Size = new System.Drawing.Size(989, 678);
            this.Instructor.Style = MetroSet_UI.Enums.Style.Light;
            this.Instructor.StyleManager = null;
            this.Instructor.TabIndex = 0;
            this.Instructor.Text = "Instructor";
            this.Instructor.ThemeAuthor = "Narwin";
            this.Instructor.ThemeName = "MetroLite";
            this.Instructor.ToolTipText = null;
            // 
            // Student
            // 
            this.Student.BaseColor = System.Drawing.Color.White;
            this.Student.Font = null;
            this.Student.ImageIndex = 0;
            this.Student.ImageKey = null;
            this.Student.IsDerivedStyle = true;
            this.Student.Location = new System.Drawing.Point(4, 42);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(989, 678);
            this.Student.Style = MetroSet_UI.Enums.Style.Light;
            this.Student.StyleManager = null;
            this.Student.TabIndex = 1;
            this.Student.Text = "Student";
            this.Student.ThemeAuthor = "Narwin";
            this.Student.ThemeName = "MetroLite";
            this.Student.ToolTipText = null;
            // 
            // Department
            // 
            this.Department.BaseColor = System.Drawing.Color.White;
            this.Department.Font = null;
            this.Department.ImageIndex = 0;
            this.Department.ImageKey = null;
            this.Department.IsDerivedStyle = true;
            this.Department.Location = new System.Drawing.Point(4, 42);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(989, 678);
            this.Department.Style = MetroSet_UI.Enums.Style.Light;
            this.Department.StyleManager = null;
            this.Department.TabIndex = 2;
            this.Department.Text = "Department";
            this.Department.ThemeAuthor = "Narwin";
            this.Department.ThemeName = "MetroLite";
            this.Department.ToolTipText = null;
            // 
            // Intake
            // 
            this.Intake.BaseColor = System.Drawing.Color.White;
            this.Intake.Font = null;
            this.Intake.ImageIndex = 0;
            this.Intake.ImageKey = null;
            this.Intake.IsDerivedStyle = true;
            this.Intake.Location = new System.Drawing.Point(4, 42);
            this.Intake.Name = "Intake";
            this.Intake.Size = new System.Drawing.Size(989, 678);
            this.Intake.Style = MetroSet_UI.Enums.Style.Light;
            this.Intake.StyleManager = null;
            this.Intake.TabIndex = 3;
            this.Intake.Text = "Intake";
            this.Intake.ThemeAuthor = "Narwin";
            this.Intake.ThemeName = "MetroLite";
            this.Intake.ToolTipText = null;
            // 
            // Track
            // 
            this.Track.BaseColor = System.Drawing.Color.White;
            this.Track.Font = null;
            this.Track.ImageIndex = 0;
            this.Track.ImageKey = null;
            this.Track.IsDerivedStyle = true;
            this.Track.Location = new System.Drawing.Point(4, 42);
            this.Track.Name = "Track";
            this.Track.Size = new System.Drawing.Size(989, 678);
            this.Track.Style = MetroSet_UI.Enums.Style.Light;
            this.Track.StyleManager = null;
            this.Track.TabIndex = 4;
            this.Track.Text = "Track";
            this.Track.ThemeAuthor = "Narwin";
            this.Track.ThemeName = "MetroLite";
            this.Track.ToolTipText = null;
            // 
            // Question_Pools
            // 
            this.Question_Pools.BaseColor = System.Drawing.Color.White;
            this.Question_Pools.Controls.Add(this.comboxCourseName);
            this.Question_Pools.Controls.Add(this.txtTxtAnswer);
            this.Question_Pools.Controls.Add(this.lblTxtAnswer);
            this.Question_Pools.Controls.Add(this.lblMCQAnswer);
            this.Question_Pools.Controls.Add(this.txtMSQAnswer);
            this.Question_Pools.Controls.Add(this.btnUpdateQuestion);
            this.Question_Pools.Controls.Add(this.btnAddQuestion);
            this.Question_Pools.Controls.Add(this.dataGridQuestions);
            this.Question_Pools.Controls.Add(this.metroSetPanel1);
            this.Question_Pools.Controls.Add(this.txtQuestionDegree);
            this.Question_Pools.Controls.Add(this.txtTFAnswer);
            this.Question_Pools.Controls.Add(this.txtQuestionContent);
            this.Question_Pools.Controls.Add(this.txtID);
            this.Question_Pools.Controls.Add(this.lblQuestionID);
            this.Question_Pools.Controls.Add(this.lblQuestionContent);
            this.Question_Pools.Controls.Add(this.lblTFAnswer);
            this.Question_Pools.Controls.Add(this.lblCourseID);
            this.Question_Pools.Controls.Add(this.lblQuestionFullDegree);
            this.Question_Pools.Controls.Add(this.lblOperation);
            this.Question_Pools.Controls.Add(this.comboxOperation);
            this.Question_Pools.Controls.Add(this.lblQuestionType);
            this.Question_Pools.Controls.Add(this.comboxQuestionType);
            this.Question_Pools.Font = null;
            this.Question_Pools.ImageIndex = 0;
            this.Question_Pools.ImageKey = null;
            this.Question_Pools.IsDerivedStyle = true;
            this.Question_Pools.Location = new System.Drawing.Point(4, 42);
            this.Question_Pools.Name = "Question_Pools";
            this.Question_Pools.Size = new System.Drawing.Size(989, 678);
            this.Question_Pools.Style = MetroSet_UI.Enums.Style.Light;
            this.Question_Pools.StyleManager = null;
            this.Question_Pools.TabIndex = 8;
            this.Question_Pools.Text = "Question_Pools";
            this.Question_Pools.ThemeAuthor = "Narwin";
            this.Question_Pools.ThemeName = "MetroLite";
            this.Question_Pools.ToolTipText = null;
            // 
            // txtTxtAnswer
            // 
            this.txtTxtAnswer.AutoCompleteCustomSource = null;
            this.txtTxtAnswer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTxtAnswer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTxtAnswer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTxtAnswer.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTxtAnswer.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTxtAnswer.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtTxtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTxtAnswer.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtTxtAnswer.Image = null;
            this.txtTxtAnswer.IsDerivedStyle = true;
            this.txtTxtAnswer.Lines = null;
            this.txtTxtAnswer.Location = new System.Drawing.Point(592, 266);
            this.txtTxtAnswer.MaxLength = 200;
            this.txtTxtAnswer.Multiline = true;
            this.txtTxtAnswer.Name = "txtTxtAnswer";
            this.txtTxtAnswer.ReadOnly = false;
            this.txtTxtAnswer.Size = new System.Drawing.Size(183, 76);
            this.txtTxtAnswer.Style = MetroSet_UI.Enums.Style.Light;
            this.txtTxtAnswer.StyleManager = null;
            this.txtTxtAnswer.TabIndex = 24;
            this.txtTxtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTxtAnswer.ThemeAuthor = "Narwin";
            this.txtTxtAnswer.ThemeName = "MetroLite";
            this.txtTxtAnswer.UseSystemPasswordChar = false;
            this.txtTxtAnswer.WatermarkText = "Best Answer";
            // 
            // lblTxtAnswer
            // 
            this.lblTxtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTxtAnswer.IsDerivedStyle = true;
            this.lblTxtAnswer.Location = new System.Drawing.Point(468, 292);
            this.lblTxtAnswer.Name = "lblTxtAnswer";
            this.lblTxtAnswer.Size = new System.Drawing.Size(118, 23);
            this.lblTxtAnswer.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTxtAnswer.StyleManager = null;
            this.lblTxtAnswer.TabIndex = 23;
            this.lblTxtAnswer.Text = "Text Answer";
            this.lblTxtAnswer.ThemeAuthor = "Narwin";
            this.lblTxtAnswer.ThemeName = "MetroLite";
            // 
            // lblMCQAnswer
            // 
            this.lblMCQAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMCQAnswer.IsDerivedStyle = true;
            this.lblMCQAnswer.Location = new System.Drawing.Point(457, 292);
            this.lblMCQAnswer.Name = "lblMCQAnswer";
            this.lblMCQAnswer.Size = new System.Drawing.Size(131, 23);
            this.lblMCQAnswer.Style = MetroSet_UI.Enums.Style.Light;
            this.lblMCQAnswer.StyleManager = null;
            this.lblMCQAnswer.TabIndex = 22;
            this.lblMCQAnswer.Text = "MCQ Answer";
            this.lblMCQAnswer.ThemeAuthor = "Narwin";
            this.lblMCQAnswer.ThemeName = "MetroLite";
            // 
            // txtMSQAnswer
            // 
            this.txtMSQAnswer.AutoCompleteCustomSource = null;
            this.txtMSQAnswer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMSQAnswer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMSQAnswer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtMSQAnswer.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtMSQAnswer.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtMSQAnswer.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtMSQAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMSQAnswer.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtMSQAnswer.Image = null;
            this.txtMSQAnswer.IsDerivedStyle = true;
            this.txtMSQAnswer.Lines = null;
            this.txtMSQAnswer.Location = new System.Drawing.Point(592, 266);
            this.txtMSQAnswer.MaxLength = 1;
            this.txtMSQAnswer.Multiline = true;
            this.txtMSQAnswer.Name = "txtMSQAnswer";
            this.txtMSQAnswer.ReadOnly = false;
            this.txtMSQAnswer.Size = new System.Drawing.Size(183, 76);
            this.txtMSQAnswer.Style = MetroSet_UI.Enums.Style.Light;
            this.txtMSQAnswer.StyleManager = null;
            this.txtMSQAnswer.TabIndex = 21;
            this.txtMSQAnswer.Text = "MC Question Correct Answer";
            this.txtMSQAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMSQAnswer.ThemeAuthor = "Narwin";
            this.txtMSQAnswer.ThemeName = "MetroLite";
            this.txtMSQAnswer.UseSystemPasswordChar = false;
            this.txtMSQAnswer.WatermarkText = "";
            // 
            // btnUpdateQuestion
            // 
            this.btnUpdateQuestion.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUpdateQuestion.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnUpdateQuestion.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnUpdateQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnUpdateQuestion.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnUpdateQuestion.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnUpdateQuestion.HoverTextColor = System.Drawing.Color.White;
            this.btnUpdateQuestion.IsDerivedStyle = true;
            this.btnUpdateQuestion.Location = new System.Drawing.Point(814, 403);
            this.btnUpdateQuestion.Name = "btnUpdateQuestion";
            this.btnUpdateQuestion.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnUpdateQuestion.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnUpdateQuestion.NormalTextColor = System.Drawing.Color.White;
            this.btnUpdateQuestion.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnUpdateQuestion.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnUpdateQuestion.PressTextColor = System.Drawing.Color.White;
            this.btnUpdateQuestion.Size = new System.Drawing.Size(122, 30);
            this.btnUpdateQuestion.Style = MetroSet_UI.Enums.Style.Light;
            this.btnUpdateQuestion.StyleManager = null;
            this.btnUpdateQuestion.TabIndex = 20;
            this.btnUpdateQuestion.Text = "Update Question";
            this.btnUpdateQuestion.ThemeAuthor = "Narwin";
            this.btnUpdateQuestion.ThemeName = "MetroLite";
            this.btnUpdateQuestion.TileAlign = MetroSet_UI.Enums.TileAlign.Topleft;
            this.btnUpdateQuestion.Click += new System.EventHandler(this.metroSetTile2_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddQuestion.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnAddQuestion.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnAddQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddQuestion.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAddQuestion.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddQuestion.HoverTextColor = System.Drawing.Color.White;
            this.btnAddQuestion.IsDerivedStyle = true;
            this.btnAddQuestion.Location = new System.Drawing.Point(814, 367);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddQuestion.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddQuestion.NormalTextColor = System.Drawing.Color.White;
            this.btnAddQuestion.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddQuestion.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddQuestion.PressTextColor = System.Drawing.Color.White;
            this.btnAddQuestion.Size = new System.Drawing.Size(122, 30);
            this.btnAddQuestion.Style = MetroSet_UI.Enums.Style.Light;
            this.btnAddQuestion.StyleManager = null;
            this.btnAddQuestion.TabIndex = 18;
            this.btnAddQuestion.Text = "Add Question";
            this.btnAddQuestion.ThemeAuthor = "Narwin";
            this.btnAddQuestion.ThemeName = "MetroLite";
            this.btnAddQuestion.TileAlign = MetroSet_UI.Enums.TileAlign.Topleft;
            this.btnAddQuestion.Click += new System.EventHandler(this.metroSetTile1_Click);
            // 
            // dataGridQuestions
            // 
            this.dataGridQuestions.AllowUserToDeleteRows = false;
            this.dataGridQuestions.AllowUserToResizeRows = false;
            this.dataGridQuestions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridQuestions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridQuestions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridQuestions.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridQuestions.EnableHeadersVisualStyles = false;
            this.dataGridQuestions.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridQuestions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridQuestions.Location = new System.Drawing.Point(-4, 191);
            this.dataGridQuestions.Name = "dataGridQuestions";
            this.dataGridQuestions.ReadOnly = true;
            this.dataGridQuestions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridQuestions.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridQuestions.RowHeadersWidth = 51;
            this.dataGridQuestions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridQuestions.RowTemplate.Height = 24;
            this.dataGridQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridQuestions.Size = new System.Drawing.Size(433, 266);
            this.dataGridQuestions.TabIndex = 17;
            this.dataGridQuestions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellDoubleClick);
            // 
            // metroSetPanel1
            // 
            this.metroSetPanel1.BackgroundColor = System.Drawing.Color.White;
            this.metroSetPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetPanel1.BorderThickness = 1;
            this.metroSetPanel1.Controls.Add(this.lblChoiceB);
            this.metroSetPanel1.Controls.Add(this.lblChoiceC);
            this.metroSetPanel1.Controls.Add(this.txtChoiceC);
            this.metroSetPanel1.Controls.Add(this.txtChoiceB);
            this.metroSetPanel1.Controls.Add(this.txtChoiceA);
            this.metroSetPanel1.Controls.Add(this.lblChoiceA);
            this.metroSetPanel1.IsDerivedStyle = true;
            this.metroSetPanel1.Location = new System.Drawing.Point(781, 172);
            this.metroSetPanel1.Name = "metroSetPanel1";
            this.metroSetPanel1.Size = new System.Drawing.Size(200, 170);
            this.metroSetPanel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetPanel1.StyleManager = null;
            this.metroSetPanel1.TabIndex = 16;
            this.metroSetPanel1.ThemeAuthor = "Narwin";
            this.metroSetPanel1.ThemeName = "MetroLite";
            // 
            // lblChoiceB
            // 
            this.lblChoiceB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblChoiceB.IsDerivedStyle = true;
            this.lblChoiceB.Location = new System.Drawing.Point(18, 73);
            this.lblChoiceB.Name = "lblChoiceB";
            this.lblChoiceB.Size = new System.Drawing.Size(31, 23);
            this.lblChoiceB.Style = MetroSet_UI.Enums.Style.Light;
            this.lblChoiceB.StyleManager = null;
            this.lblChoiceB.TabIndex = 20;
            this.lblChoiceB.Text = "B.";
            this.lblChoiceB.ThemeAuthor = "Narwin";
            this.lblChoiceB.ThemeName = "MetroLite";
            // 
            // lblChoiceC
            // 
            this.lblChoiceC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblChoiceC.IsDerivedStyle = true;
            this.lblChoiceC.Location = new System.Drawing.Point(18, 127);
            this.lblChoiceC.Name = "lblChoiceC";
            this.lblChoiceC.Size = new System.Drawing.Size(31, 23);
            this.lblChoiceC.Style = MetroSet_UI.Enums.Style.Light;
            this.lblChoiceC.StyleManager = null;
            this.lblChoiceC.TabIndex = 19;
            this.lblChoiceC.Text = "C.";
            this.lblChoiceC.ThemeAuthor = "Narwin";
            this.lblChoiceC.ThemeName = "MetroLite";
            // 
            // txtChoiceC
            // 
            this.txtChoiceC.AutoCompleteCustomSource = null;
            this.txtChoiceC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtChoiceC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtChoiceC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtChoiceC.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtChoiceC.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtChoiceC.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtChoiceC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtChoiceC.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtChoiceC.Image = null;
            this.txtChoiceC.IsDerivedStyle = true;
            this.txtChoiceC.Lines = null;
            this.txtChoiceC.Location = new System.Drawing.Point(55, 120);
            this.txtChoiceC.MaxLength = 150;
            this.txtChoiceC.Multiline = false;
            this.txtChoiceC.Name = "txtChoiceC";
            this.txtChoiceC.ReadOnly = false;
            this.txtChoiceC.Size = new System.Drawing.Size(135, 30);
            this.txtChoiceC.Style = MetroSet_UI.Enums.Style.Light;
            this.txtChoiceC.StyleManager = null;
            this.txtChoiceC.TabIndex = 2;
            this.txtChoiceC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtChoiceC.ThemeAuthor = "Narwin";
            this.txtChoiceC.ThemeName = "MetroLite";
            this.txtChoiceC.UseSystemPasswordChar = false;
            this.txtChoiceC.WatermarkText = "Answer C";
            // 
            // txtChoiceB
            // 
            this.txtChoiceB.AutoCompleteCustomSource = null;
            this.txtChoiceB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtChoiceB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtChoiceB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtChoiceB.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtChoiceB.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtChoiceB.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtChoiceB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtChoiceB.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtChoiceB.Image = null;
            this.txtChoiceB.IsDerivedStyle = true;
            this.txtChoiceB.Lines = null;
            this.txtChoiceB.Location = new System.Drawing.Point(55, 66);
            this.txtChoiceB.MaxLength = 150;
            this.txtChoiceB.Multiline = false;
            this.txtChoiceB.Name = "txtChoiceB";
            this.txtChoiceB.ReadOnly = false;
            this.txtChoiceB.Size = new System.Drawing.Size(135, 30);
            this.txtChoiceB.Style = MetroSet_UI.Enums.Style.Light;
            this.txtChoiceB.StyleManager = null;
            this.txtChoiceB.TabIndex = 1;
            this.txtChoiceB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtChoiceB.ThemeAuthor = "Narwin";
            this.txtChoiceB.ThemeName = "MetroLite";
            this.txtChoiceB.UseSystemPasswordChar = false;
            this.txtChoiceB.WatermarkText = "Answer B";
            // 
            // txtChoiceA
            // 
            this.txtChoiceA.AutoCompleteCustomSource = null;
            this.txtChoiceA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtChoiceA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtChoiceA.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtChoiceA.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtChoiceA.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtChoiceA.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtChoiceA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtChoiceA.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtChoiceA.Image = null;
            this.txtChoiceA.IsDerivedStyle = true;
            this.txtChoiceA.Lines = null;
            this.txtChoiceA.Location = new System.Drawing.Point(55, 12);
            this.txtChoiceA.MaxLength = 150;
            this.txtChoiceA.Multiline = false;
            this.txtChoiceA.Name = "txtChoiceA";
            this.txtChoiceA.ReadOnly = false;
            this.txtChoiceA.Size = new System.Drawing.Size(135, 30);
            this.txtChoiceA.Style = MetroSet_UI.Enums.Style.Light;
            this.txtChoiceA.StyleManager = null;
            this.txtChoiceA.TabIndex = 0;
            this.txtChoiceA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtChoiceA.ThemeAuthor = "Narwin";
            this.txtChoiceA.ThemeName = "MetroLite";
            this.txtChoiceA.UseSystemPasswordChar = false;
            this.txtChoiceA.WatermarkText = "Answer A";
            // 
            // lblChoiceA
            // 
            this.lblChoiceA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblChoiceA.IsDerivedStyle = true;
            this.lblChoiceA.Location = new System.Drawing.Point(18, 19);
            this.lblChoiceA.Name = "lblChoiceA";
            this.lblChoiceA.Size = new System.Drawing.Size(31, 23);
            this.lblChoiceA.Style = MetroSet_UI.Enums.Style.Light;
            this.lblChoiceA.StyleManager = null;
            this.lblChoiceA.TabIndex = 17;
            this.lblChoiceA.Text = "A.";
            this.lblChoiceA.ThemeAuthor = "Narwin";
            this.lblChoiceA.ThemeName = "MetroLite";
            // 
            // txtQuestionDegree
            // 
            this.txtQuestionDegree.AutoCompleteCustomSource = null;
            this.txtQuestionDegree.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtQuestionDegree.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtQuestionDegree.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtQuestionDegree.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtQuestionDegree.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtQuestionDegree.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtQuestionDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtQuestionDegree.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtQuestionDegree.Image = null;
            this.txtQuestionDegree.IsDerivedStyle = true;
            this.txtQuestionDegree.Lines = null;
            this.txtQuestionDegree.Location = new System.Drawing.Point(646, 360);
            this.txtQuestionDegree.MaxLength = 32767;
            this.txtQuestionDegree.Multiline = false;
            this.txtQuestionDegree.Name = "txtQuestionDegree";
            this.txtQuestionDegree.ReadOnly = false;
            this.txtQuestionDegree.Size = new System.Drawing.Size(66, 30);
            this.txtQuestionDegree.Style = MetroSet_UI.Enums.Style.Light;
            this.txtQuestionDegree.StyleManager = null;
            this.txtQuestionDegree.TabIndex = 14;
            this.txtQuestionDegree.Text = "Degree";
            this.txtQuestionDegree.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQuestionDegree.ThemeAuthor = "Narwin";
            this.txtQuestionDegree.ThemeName = "MetroLite";
            this.txtQuestionDegree.UseSystemPasswordChar = false;
            this.txtQuestionDegree.WatermarkText = "Degree";
            // 
            // txtTFAnswer
            // 
            this.txtTFAnswer.AutoCompleteCustomSource = null;
            this.txtTFAnswer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTFAnswer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTFAnswer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTFAnswer.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTFAnswer.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTFAnswer.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtTFAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTFAnswer.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtTFAnswer.Image = null;
            this.txtTFAnswer.IsDerivedStyle = true;
            this.txtTFAnswer.Lines = null;
            this.txtTFAnswer.Location = new System.Drawing.Point(592, 266);
            this.txtTFAnswer.MaxLength = 5;
            this.txtTFAnswer.Multiline = true;
            this.txtTFAnswer.Name = "txtTFAnswer";
            this.txtTFAnswer.ReadOnly = false;
            this.txtTFAnswer.Size = new System.Drawing.Size(183, 76);
            this.txtTFAnswer.Style = MetroSet_UI.Enums.Style.Light;
            this.txtTFAnswer.StyleManager = null;
            this.txtTFAnswer.TabIndex = 13;
            this.txtTFAnswer.Text = "Question T/F Answer";
            this.txtTFAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTFAnswer.ThemeAuthor = "Narwin";
            this.txtTFAnswer.ThemeName = "MetroLite";
            this.txtTFAnswer.UseSystemPasswordChar = false;
            this.txtTFAnswer.WatermarkText = "";
            // 
            // txtQuestionContent
            // 
            this.txtQuestionContent.AutoCompleteCustomSource = null;
            this.txtQuestionContent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtQuestionContent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtQuestionContent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtQuestionContent.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtQuestionContent.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtQuestionContent.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtQuestionContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtQuestionContent.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtQuestionContent.Image = null;
            this.txtQuestionContent.IsDerivedStyle = true;
            this.txtQuestionContent.Lines = null;
            this.txtQuestionContent.Location = new System.Drawing.Point(592, 172);
            this.txtQuestionContent.MaxLength = 32767;
            this.txtQuestionContent.Multiline = true;
            this.txtQuestionContent.Name = "txtQuestionContent";
            this.txtQuestionContent.ReadOnly = false;
            this.txtQuestionContent.Size = new System.Drawing.Size(183, 76);
            this.txtQuestionContent.Style = MetroSet_UI.Enums.Style.Light;
            this.txtQuestionContent.StyleManager = null;
            this.txtQuestionContent.TabIndex = 12;
            this.txtQuestionContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQuestionContent.ThemeAuthor = "Narwin";
            this.txtQuestionContent.ThemeName = "MetroLite";
            this.txtQuestionContent.UseSystemPasswordChar = false;
            this.txtQuestionContent.WatermarkText = "Question Content...";
            // 
            // txtID
            // 
            this.txtID.AutoCompleteCustomSource = null;
            this.txtID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtID.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtID.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtID.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtID.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtID.Image = null;
            this.txtID.IsDerivedStyle = true;
            this.txtID.Lines = null;
            this.txtID.Location = new System.Drawing.Point(674, 122);
            this.txtID.MaxLength = 32767;
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(38, 30);
            this.txtID.Style = MetroSet_UI.Enums.Style.Light;
            this.txtID.StyleManager = null;
            this.txtID.TabIndex = 11;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtID.ThemeAuthor = "Narwin";
            this.txtID.ThemeName = "MetroLite";
            this.txtID.UseSystemPasswordChar = false;
            this.txtID.WatermarkText = "ID";
            // 
            // lblQuestionID
            // 
            this.lblQuestionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblQuestionID.IsDerivedStyle = true;
            this.lblQuestionID.Location = new System.Drawing.Point(457, 129);
            this.lblQuestionID.Name = "lblQuestionID";
            this.lblQuestionID.Size = new System.Drawing.Size(166, 23);
            this.lblQuestionID.Style = MetroSet_UI.Enums.Style.Light;
            this.lblQuestionID.StyleManager = null;
            this.lblQuestionID.TabIndex = 10;
            this.lblQuestionID.Text = "Question ID";
            this.lblQuestionID.ThemeAuthor = "Narwin";
            this.lblQuestionID.ThemeName = "MetroLite";
            // 
            // lblQuestionContent
            // 
            this.lblQuestionContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblQuestionContent.IsDerivedStyle = true;
            this.lblQuestionContent.Location = new System.Drawing.Point(435, 200);
            this.lblQuestionContent.Name = "lblQuestionContent";
            this.lblQuestionContent.Size = new System.Drawing.Size(166, 23);
            this.lblQuestionContent.Style = MetroSet_UI.Enums.Style.Light;
            this.lblQuestionContent.StyleManager = null;
            this.lblQuestionContent.TabIndex = 9;
            this.lblQuestionContent.Text = "Question Content";
            this.lblQuestionContent.ThemeAuthor = "Narwin";
            this.lblQuestionContent.ThemeName = "MetroLite";
            // 
            // lblTFAnswer
            // 
            this.lblTFAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTFAnswer.IsDerivedStyle = true;
            this.lblTFAnswer.Location = new System.Drawing.Point(437, 292);
            this.lblTFAnswer.Name = "lblTFAnswer";
            this.lblTFAnswer.Size = new System.Drawing.Size(186, 23);
            this.lblTFAnswer.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTFAnswer.StyleManager = null;
            this.lblTFAnswer.TabIndex = 8;
            this.lblTFAnswer.Text = "True/False Answer";
            this.lblTFAnswer.ThemeAuthor = "Narwin";
            this.lblTFAnswer.ThemeName = "MetroLite";
            // 
            // lblCourseID
            // 
            this.lblCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCourseID.IsDerivedStyle = true;
            this.lblCourseID.Location = new System.Drawing.Point(457, 422);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(244, 27);
            this.lblCourseID.Style = MetroSet_UI.Enums.Style.Light;
            this.lblCourseID.StyleManager = null;
            this.lblCourseID.TabIndex = 7;
            this.lblCourseID.Text = "Course Name";
            this.lblCourseID.ThemeAuthor = "Narwin";
            this.lblCourseID.ThemeName = "MetroLite";
            // 
            // lblQuestionFullDegree
            // 
            this.lblQuestionFullDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblQuestionFullDegree.IsDerivedStyle = true;
            this.lblQuestionFullDegree.Location = new System.Drawing.Point(457, 367);
            this.lblQuestionFullDegree.Name = "lblQuestionFullDegree";
            this.lblQuestionFullDegree.Size = new System.Drawing.Size(166, 23);
            this.lblQuestionFullDegree.Style = MetroSet_UI.Enums.Style.Light;
            this.lblQuestionFullDegree.StyleManager = null;
            this.lblQuestionFullDegree.TabIndex = 6;
            this.lblQuestionFullDegree.Text = "Full Degree";
            this.lblQuestionFullDegree.ThemeAuthor = "Narwin";
            this.lblQuestionFullDegree.ThemeName = "MetroLite";
            // 
            // lblOperation
            // 
            this.lblOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOperation.IsDerivedStyle = true;
            this.lblOperation.Location = new System.Drawing.Point(630, 53);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(100, 23);
            this.lblOperation.Style = MetroSet_UI.Enums.Style.Light;
            this.lblOperation.StyleManager = null;
            this.lblOperation.TabIndex = 3;
            this.lblOperation.Text = "Operation";
            this.lblOperation.ThemeAuthor = "Narwin";
            this.lblOperation.ThemeName = "MetroLite";
            // 
            // comboxOperation
            // 
            this.comboxOperation.AllowDrop = true;
            this.comboxOperation.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboxOperation.BackColor = System.Drawing.Color.Transparent;
            this.comboxOperation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.comboxOperation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboxOperation.CausesValidation = false;
            this.comboxOperation.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.comboxOperation.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.comboxOperation.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.comboxOperation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboxOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboxOperation.FormattingEnabled = true;
            this.comboxOperation.IsDerivedStyle = true;
            this.comboxOperation.ItemHeight = 20;
            this.comboxOperation.Items.AddRange(new object[] {
            "Add Question",
            "Update Question"});
            this.comboxOperation.Location = new System.Drawing.Point(736, 50);
            this.comboxOperation.Name = "comboxOperation";
            this.comboxOperation.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.comboxOperation.SelectedItemForeColor = System.Drawing.Color.White;
            this.comboxOperation.Size = new System.Drawing.Size(169, 26);
            this.comboxOperation.Style = MetroSet_UI.Enums.Style.Light;
            this.comboxOperation.StyleManager = null;
            this.comboxOperation.TabIndex = 2;
            this.comboxOperation.ThemeAuthor = "Narwin";
            this.comboxOperation.ThemeName = "MetroLite";
            this.comboxOperation.Visible = false;
            this.comboxOperation.SelectedIndexChanged += new System.EventHandler(this.metroSetComboBox2_SelectedIndexChanged);
            // 
            // lblQuestionType
            // 
            this.lblQuestionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblQuestionType.IsDerivedStyle = true;
            this.lblQuestionType.Location = new System.Drawing.Point(84, 56);
            this.lblQuestionType.Name = "lblQuestionType";
            this.lblQuestionType.Size = new System.Drawing.Size(122, 23);
            this.lblQuestionType.Style = MetroSet_UI.Enums.Style.Light;
            this.lblQuestionType.StyleManager = null;
            this.lblQuestionType.TabIndex = 1;
            this.lblQuestionType.Text = "Question Type";
            this.lblQuestionType.ThemeAuthor = "Narwin";
            this.lblQuestionType.ThemeName = "MetroLite";
            // 
            // comboxQuestionType
            // 
            this.comboxQuestionType.AllowDrop = true;
            this.comboxQuestionType.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboxQuestionType.BackColor = System.Drawing.Color.Transparent;
            this.comboxQuestionType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.comboxQuestionType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboxQuestionType.CausesValidation = false;
            this.comboxQuestionType.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.comboxQuestionType.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.comboxQuestionType.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.comboxQuestionType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboxQuestionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxQuestionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboxQuestionType.FormattingEnabled = true;
            this.comboxQuestionType.IsDerivedStyle = true;
            this.comboxQuestionType.ItemHeight = 20;
            this.comboxQuestionType.Items.AddRange(new object[] {
            "MC Questions",
            "True/False Questions",
            "Text Questions"});
            this.comboxQuestionType.Location = new System.Drawing.Point(229, 53);
            this.comboxQuestionType.Name = "comboxQuestionType";
            this.comboxQuestionType.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.comboxQuestionType.SelectedItemForeColor = System.Drawing.Color.White;
            this.comboxQuestionType.Size = new System.Drawing.Size(169, 26);
            this.comboxQuestionType.Style = MetroSet_UI.Enums.Style.Light;
            this.comboxQuestionType.StyleManager = null;
            this.comboxQuestionType.TabIndex = 0;
            this.comboxQuestionType.ThemeAuthor = "Narwin";
            this.comboxQuestionType.ThemeName = "MetroLite";
            this.comboxQuestionType.SelectedIndexChanged += new System.EventHandler(this.comboxQuestionType_SelectedIndexChanged);
            // 
            // Exams
            // 
            this.Exams.BaseColor = System.Drawing.Color.White;
            this.Exams.Font = null;
            this.Exams.ImageIndex = 0;
            this.Exams.ImageKey = null;
            this.Exams.IsDerivedStyle = true;
            this.Exams.Location = new System.Drawing.Point(4, 42);
            this.Exams.Name = "Exams";
            this.Exams.Size = new System.Drawing.Size(989, 678);
            this.Exams.Style = MetroSet_UI.Enums.Style.Light;
            this.Exams.StyleManager = null;
            this.Exams.TabIndex = 9;
            this.Exams.Text = "Exams";
            this.Exams.ThemeAuthor = "Narwin";
            this.Exams.ThemeName = "MetroLite";
            this.Exams.ToolTipText = null;
            // 
            // btnLogOut
            // 
            this.btnLogOut.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogOut.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnLogOut.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLogOut.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnLogOut.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnLogOut.HoverTextColor = System.Drawing.Color.White;
            this.btnLogOut.IsDerivedStyle = true;
            this.btnLogOut.Location = new System.Drawing.Point(932, 49);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogOut.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnLogOut.NormalTextColor = System.Drawing.Color.Black;
            this.btnLogOut.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnLogOut.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnLogOut.PressTextColor = System.Drawing.Color.White;
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.Style = MetroSet_UI.Enums.Style.Light;
            this.btnLogOut.StyleManager = null;
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.ThemeAuthor = "Narwin";
            this.btnLogOut.ThemeName = "MetroLite";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblClose
            // 
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblClose.IsDerivedStyle = true;
            this.lblClose.Location = new System.Drawing.Point(987, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(25, 23);
            this.lblClose.Style = MetroSet_UI.Enums.Style.Light;
            this.lblClose.StyleManager = null;
            this.lblClose.TabIndex = 3;
            this.lblClose.Text = "X";
            this.lblClose.ThemeAuthor = "Narwin";
            this.lblClose.ThemeName = "MetroLite";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // comboxCourseName
            // 
            this.comboxCourseName.FormattingEnabled = true;
            this.comboxCourseName.ItemHeight = 24;
            this.comboxCourseName.Location = new System.Drawing.Point(630, 419);
            this.comboxCourseName.Name = "comboxCourseName";
            this.comboxCourseName.Size = new System.Drawing.Size(121, 30);
            this.comboxCourseName.TabIndex = 25;
            this.comboxCourseName.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 657);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.Tabs);
            this.Name = "Form1";
            this.Text = "Examination System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tabs.ResumeLayout(false);
            this.Creat_Exam.ResumeLayout(false);
            this.panelRandomly.ResumeLayout(false);
            this.Question_Pools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuestions)).EndInit();
            this.metroSetPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetTabControl Tabs;
        private MetroSet_UI.Child.MetroSetSetTabPage Instructor;
        private MetroSet_UI.Child.MetroSetSetTabPage Student;
        private MetroSet_UI.Child.MetroSetSetTabPage Department;
        private MetroSet_UI.Child.MetroSetSetTabPage Intake;
        private MetroSet_UI.Child.MetroSetSetTabPage Track;
        private MetroSet_UI.Child.MetroSetSetTabPage Branch;
        private MetroSet_UI.Child.MetroSetSetTabPage Creat_Exam;
        private MetroSet_UI.Child.MetroSetSetTabPage Student_for_Exam;
        private MetroSet_UI.Child.MetroSetSetTabPage Question_Pools;
        private MetroSet_UI.Child.MetroSetSetTabPage Exams;
        private MetroSet_UI.Controls.MetroSetDefaultButton btnLogOut;
        private MetroSet_UI.Controls.MetroSetLabel lblClose;
        private System.Windows.Forms.DateTimePicker datePckFirstExam;
        private MetroSet_UI.Controls.MetroSetComboBox comboxCrtMethod;
        private MetroSet_UI.Controls.MetroSetPanel panelRandomly;
        private MetroSet_UI.Controls.MetroSetRichTextBox txtNumMCQ;
        private MetroSet_UI.Controls.MetroSetComboBox comboxExamType;
        private System.Windows.Forms.DateTimePicker datePckEndExam;
        private MetroSet_UI.Controls.MetroSetComboBox comboxAvailCrsforIns;
        private MetroSet_UI.Controls.MetroSetLabel lblForTxtQ;
        private MetroSet_UI.Controls.MetroSetLabel lblForTFQ;
        private MetroSet_UI.Controls.MetroSetLabel lblForMCQ;
        private MetroSet_UI.Controls.MetroSetLabel lblDegQst;
        private MetroSet_UI.Controls.MetroSetLabel lblNumQst;
        private MetroSet_UI.Controls.MetroSetRichTextBox txtNumTxtQ;
        private MetroSet_UI.Controls.MetroSetRichTextBox txtNumTFQ;
        private MetroSet_UI.Controls.MetroSetRichTextBox txtDegTxtQ;
        private MetroSet_UI.Controls.MetroSetRichTextBox txtDegTFQ;
        private MetroSet_UI.Controls.MetroSetRichTextBox txtDegMCQ;
        private MetroSet_UI.Controls.MetroSetLabel lblCreationMethod;
        private MetroSet_UI.Controls.MetroSetLabel lblEndTime;
        private MetroSet_UI.Controls.MetroSetLabel lblExamType;
        private MetroSet_UI.Controls.MetroSetLabel lblStartTime;
        private MetroSet_UI.Controls.MetroSetComboBox comboxQuestionType;
        private MetroSet_UI.Controls.MetroSetLabel lblOperation;
        private MetroSet_UI.Controls.MetroSetComboBox comboxOperation;
        private MetroSet_UI.Controls.MetroSetLabel lblQuestionType;
        private MetroSet_UI.Controls.MetroSetTextBox txtQuestionContent;
        private MetroSet_UI.Controls.MetroSetTextBox txtID;
        private MetroSet_UI.Controls.MetroSetLabel lblQuestionID;
        private MetroSet_UI.Controls.MetroSetLabel lblQuestionContent;
        private MetroSet_UI.Controls.MetroSetLabel lblTFAnswer;
        private MetroSet_UI.Controls.MetroSetLabel lblCourseID;
        private MetroSet_UI.Controls.MetroSetLabel lblQuestionFullDegree;
        private MetroSet_UI.Controls.MetroSetTextBox txtTFAnswer;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel1;
        private MetroSet_UI.Controls.MetroSetTextBox txtQuestionDegree;
        private MetroSet_UI.Controls.MetroSetLabel lblChoiceA;
        private MetroSet_UI.Controls.MetroSetTextBox txtChoiceC;
        private MetroSet_UI.Controls.MetroSetTextBox txtChoiceB;
        private MetroSet_UI.Controls.MetroSetTextBox txtChoiceA;
        private MetroSet_UI.Controls.MetroSetLabel lblChoiceB;
        private MetroSet_UI.Controls.MetroSetLabel lblChoiceC;
        private MetroFramework.Controls.MetroGrid dataGridQuestions;
        private MetroSet_UI.Controls.MetroSetTile btnAddQuestion;
        private MetroSet_UI.Controls.MetroSetTile btnUpdateQuestion;
        private MetroSet_UI.Controls.MetroSetLabel lblMCQAnswer;
        private MetroSet_UI.Controls.MetroSetTextBox txtMSQAnswer;
        private MetroSet_UI.Controls.MetroSetLabel lblTxtAnswer;
        private MetroSet_UI.Controls.MetroSetTextBox txtTxtAnswer;
        private MetroFramework.Controls.MetroComboBox comboxCourseName;
    }
}

