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
            this.Instructor = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.Student = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.Department = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.Intake = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.Track = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.Branch = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.Student_for_Exam = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.Question_Pools = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.Exams = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.btnLogOut = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.lblClose = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnCrtRandExam = new MetroSet_UI.Controls.MetroSetButton();
            this.lblAllowanceOpts = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblCalc = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblOpenBook = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblInternet = new MetroSet_UI.Controls.MetroSetLabel();
            this.comboxCalc = new MetroSet_UI.Controls.MetroSetComboBox();
            this.comboxOpenBook = new MetroSet_UI.Controls.MetroSetComboBox();
            this.comboxInternet = new MetroSet_UI.Controls.MetroSetComboBox();
            this.panelManually = new MetroSet_UI.Controls.MetroSetPanel();
            this.lblMCQIds = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblTFQIds = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblTxtQIds = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtIdsManMCQ = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtIdsManTFQ = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtIdsManTxtQ = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtDegManMCQ = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblDegQsts = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtDegManTFQ = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtDegManTxtQ = new MetroSet_UI.Controls.MetroSetTextBox();
            this.comboxManAvailCrsforIns = new MetroSet_UI.Controls.MetroSetComboBox();
            this.btnCrtManExam = new MetroSet_UI.Controls.MetroSetButton();
            this.Tabs.SuspendLayout();
            this.Creat_Exam.SuspendLayout();
            this.panelRandomly.SuspendLayout();
            this.panelManually.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.Tabs.AnimateTime = 200;
            this.Tabs.BackgroundColor = System.Drawing.Color.White;
            this.Tabs.Controls.Add(this.Creat_Exam);
            this.Tabs.Controls.Add(this.Instructor);
            this.Tabs.Controls.Add(this.Student);
            this.Tabs.Controls.Add(this.Department);
            this.Tabs.Controls.Add(this.Intake);
            this.Tabs.Controls.Add(this.Track);
            this.Tabs.Controls.Add(this.Branch);
            this.Tabs.Controls.Add(this.Student_for_Exam);
            this.Tabs.Controls.Add(this.Question_Pools);
            this.Tabs.Controls.Add(this.Exams);
            this.Tabs.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tabs.IsDerivedStyle = true;
            this.Tabs.ItemSize = new System.Drawing.Size(100, 38);
            this.Tabs.Location = new System.Drawing.Point(15, 95);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.SelectedTextColor = System.Drawing.Color.White;
            this.Tabs.Size = new System.Drawing.Size(997, 584);
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
            this.Creat_Exam.Controls.Add(this.panelManually);
            this.Creat_Exam.Controls.Add(this.comboxInternet);
            this.Creat_Exam.Controls.Add(this.comboxOpenBook);
            this.Creat_Exam.Controls.Add(this.comboxCalc);
            this.Creat_Exam.Controls.Add(this.lblInternet);
            this.Creat_Exam.Controls.Add(this.lblOpenBook);
            this.Creat_Exam.Controls.Add(this.lblCalc);
            this.Creat_Exam.Controls.Add(this.lblAllowanceOpts);
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
            this.Creat_Exam.Size = new System.Drawing.Size(989, 538);
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
            this.panelRandomly.BorderColor = System.Drawing.Color.Transparent;
            this.panelRandomly.BorderThickness = 0;
            this.panelRandomly.Controls.Add(this.btnCrtRandExam);
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
            this.panelRandomly.Location = new System.Drawing.Point(157, 285);
            this.panelRandomly.Name = "panelRandomly";
            this.panelRandomly.Size = new System.Drawing.Size(660, 235);
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
            this.txtDegTxtQ.Location = new System.Drawing.Point(536, 100);
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
            this.txtNumTxtQ.Location = new System.Drawing.Point(536, 40);
            this.txtNumTxtQ.MaxLength = 32767;
            this.txtNumTxtQ.Name = "txtNumTxtQ";
            this.txtNumTxtQ.ReadOnly = false;
            this.txtNumTxtQ.Size = new System.Drawing.Size(75, 29);
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
            this.txtNumTFQ.Size = new System.Drawing.Size(75, 29);
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
            this.lblForTxtQ.Location = new System.Drawing.Point(536, 11);
            this.lblForTxtQ.Name = "lblForTxtQ";
            this.lblForTxtQ.Size = new System.Drawing.Size(75, 23);
            this.lblForTxtQ.Style = MetroSet_UI.Enums.Style.Light;
            this.lblForTxtQ.StyleManager = null;
            this.lblForTxtQ.TabIndex = 9;
            this.lblForTxtQ.Text = "for TxtQ";
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
            this.comboxAvailCrsforIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxAvailCrsforIns.FormattingEnabled = true;
            this.comboxAvailCrsforIns.IsDerivedStyle = true;
            this.comboxAvailCrsforIns.ItemHeight = 20;
            this.comboxAvailCrsforIns.Location = new System.Drawing.Point(265, 150);
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
            this.comboxCrtMethod.SelectedIndexChanged += new System.EventHandler(this.comboxCrtMethod_SelectedIndexChanged);
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
            // Question_Pools
            // 
            this.Question_Pools.BaseColor = System.Drawing.Color.White;
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
            // btnCrtRandExam
            // 
            this.btnCrtRandExam.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCrtRandExam.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCrtRandExam.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnCrtRandExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCrtRandExam.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnCrtRandExam.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnCrtRandExam.HoverTextColor = System.Drawing.Color.White;
            this.btnCrtRandExam.IsDerivedStyle = true;
            this.btnCrtRandExam.Location = new System.Drawing.Point(494, 199);
            this.btnCrtRandExam.Name = "btnCrtRandExam";
            this.btnCrtRandExam.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCrtRandExam.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCrtRandExam.NormalTextColor = System.Drawing.Color.White;
            this.btnCrtRandExam.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnCrtRandExam.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnCrtRandExam.PressTextColor = System.Drawing.Color.White;
            this.btnCrtRandExam.Size = new System.Drawing.Size(121, 23);
            this.btnCrtRandExam.Style = MetroSet_UI.Enums.Style.Light;
            this.btnCrtRandExam.StyleManager = null;
            this.btnCrtRandExam.TabIndex = 18;
            this.btnCrtRandExam.Text = "Create Exam";
            this.btnCrtRandExam.ThemeAuthor = "Narwin";
            this.btnCrtRandExam.ThemeName = "MetroLite";
            this.btnCrtRandExam.Click += new System.EventHandler(this.btnCrtExam_Click);
            // 
            // lblAllowanceOpts
            // 
            this.lblAllowanceOpts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAllowanceOpts.IsDerivedStyle = true;
            this.lblAllowanceOpts.Location = new System.Drawing.Point(157, 166);
            this.lblAllowanceOpts.Name = "lblAllowanceOpts";
            this.lblAllowanceOpts.Size = new System.Drawing.Size(162, 23);
            this.lblAllowanceOpts.Style = MetroSet_UI.Enums.Style.Light;
            this.lblAllowanceOpts.StyleManager = null;
            this.lblAllowanceOpts.TabIndex = 13;
            this.lblAllowanceOpts.Text = "Allowance Options";
            this.lblAllowanceOpts.ThemeAuthor = "Narwin";
            this.lblAllowanceOpts.ThemeName = "MetroLite";
            // 
            // lblCalc
            // 
            this.lblCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCalc.IsDerivedStyle = true;
            this.lblCalc.Location = new System.Drawing.Point(195, 203);
            this.lblCalc.Name = "lblCalc";
            this.lblCalc.Size = new System.Drawing.Size(100, 23);
            this.lblCalc.Style = MetroSet_UI.Enums.Style.Light;
            this.lblCalc.StyleManager = null;
            this.lblCalc.TabIndex = 17;
            this.lblCalc.Text = "Calculator";
            this.lblCalc.ThemeAuthor = "Narwin";
            this.lblCalc.ThemeName = "MetroLite";
            // 
            // lblOpenBook
            // 
            this.lblOpenBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOpenBook.IsDerivedStyle = true;
            this.lblOpenBook.Location = new System.Drawing.Point(432, 203);
            this.lblOpenBook.Name = "lblOpenBook";
            this.lblOpenBook.Size = new System.Drawing.Size(100, 23);
            this.lblOpenBook.Style = MetroSet_UI.Enums.Style.Light;
            this.lblOpenBook.StyleManager = null;
            this.lblOpenBook.TabIndex = 19;
            this.lblOpenBook.Text = "Open Book";
            this.lblOpenBook.ThemeAuthor = "Narwin";
            this.lblOpenBook.ThemeName = "MetroLite";
            // 
            // lblInternet
            // 
            this.lblInternet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInternet.IsDerivedStyle = true;
            this.lblInternet.Location = new System.Drawing.Point(673, 203);
            this.lblInternet.Name = "lblInternet";
            this.lblInternet.Size = new System.Drawing.Size(100, 23);
            this.lblInternet.Style = MetroSet_UI.Enums.Style.Light;
            this.lblInternet.StyleManager = null;
            this.lblInternet.TabIndex = 21;
            this.lblInternet.Text = "Internet";
            this.lblInternet.ThemeAuthor = "Narwin";
            this.lblInternet.ThemeName = "MetroLite";
            // 
            // comboxCalc
            // 
            this.comboxCalc.AllowDrop = true;
            this.comboxCalc.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboxCalc.BackColor = System.Drawing.Color.Transparent;
            this.comboxCalc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.comboxCalc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboxCalc.CausesValidation = false;
            this.comboxCalc.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.comboxCalc.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.comboxCalc.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.comboxCalc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboxCalc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboxCalc.FormattingEnabled = true;
            this.comboxCalc.IsDerivedStyle = true;
            this.comboxCalc.ItemHeight = 20;
            this.comboxCalc.Items.AddRange(new object[] {
            "Allowed",
            "Not Allowed"});
            this.comboxCalc.Location = new System.Drawing.Point(195, 244);
            this.comboxCalc.Name = "comboxCalc";
            this.comboxCalc.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.comboxCalc.SelectedItemForeColor = System.Drawing.Color.White;
            this.comboxCalc.Size = new System.Drawing.Size(130, 26);
            this.comboxCalc.Style = MetroSet_UI.Enums.Style.Light;
            this.comboxCalc.StyleManager = null;
            this.comboxCalc.TabIndex = 22;
            this.comboxCalc.ThemeAuthor = "Narwin";
            this.comboxCalc.ThemeName = "MetroLite";
            // 
            // comboxOpenBook
            // 
            this.comboxOpenBook.AllowDrop = true;
            this.comboxOpenBook.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboxOpenBook.BackColor = System.Drawing.Color.Transparent;
            this.comboxOpenBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.comboxOpenBook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboxOpenBook.CausesValidation = false;
            this.comboxOpenBook.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.comboxOpenBook.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.comboxOpenBook.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.comboxOpenBook.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboxOpenBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxOpenBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboxOpenBook.FormattingEnabled = true;
            this.comboxOpenBook.IsDerivedStyle = true;
            this.comboxOpenBook.ItemHeight = 20;
            this.comboxOpenBook.Items.AddRange(new object[] {
            "Allowed",
            "Not Allowed"});
            this.comboxOpenBook.Location = new System.Drawing.Point(432, 244);
            this.comboxOpenBook.Name = "comboxOpenBook";
            this.comboxOpenBook.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.comboxOpenBook.SelectedItemForeColor = System.Drawing.Color.White;
            this.comboxOpenBook.Size = new System.Drawing.Size(130, 26);
            this.comboxOpenBook.Style = MetroSet_UI.Enums.Style.Light;
            this.comboxOpenBook.StyleManager = null;
            this.comboxOpenBook.TabIndex = 23;
            this.comboxOpenBook.ThemeAuthor = "Narwin";
            this.comboxOpenBook.ThemeName = "MetroLite";
            // 
            // comboxInternet
            // 
            this.comboxInternet.AllowDrop = true;
            this.comboxInternet.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboxInternet.BackColor = System.Drawing.Color.Transparent;
            this.comboxInternet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.comboxInternet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboxInternet.CausesValidation = false;
            this.comboxInternet.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.comboxInternet.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.comboxInternet.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.comboxInternet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboxInternet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxInternet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboxInternet.FormattingEnabled = true;
            this.comboxInternet.IsDerivedStyle = true;
            this.comboxInternet.ItemHeight = 20;
            this.comboxInternet.Items.AddRange(new object[] {
            "Allowed",
            "Not Allowed"});
            this.comboxInternet.Location = new System.Drawing.Point(673, 244);
            this.comboxInternet.Name = "comboxInternet";
            this.comboxInternet.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.comboxInternet.SelectedItemForeColor = System.Drawing.Color.White;
            this.comboxInternet.Size = new System.Drawing.Size(130, 26);
            this.comboxInternet.Style = MetroSet_UI.Enums.Style.Light;
            this.comboxInternet.StyleManager = null;
            this.comboxInternet.TabIndex = 24;
            this.comboxInternet.ThemeAuthor = "Narwin";
            this.comboxInternet.ThemeName = "MetroLite";
            // 
            // panelManually
            // 
            this.panelManually.BackgroundColor = System.Drawing.Color.White;
            this.panelManually.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.panelManually.BorderThickness = 1;
            this.panelManually.Controls.Add(this.btnCrtManExam);
            this.panelManually.Controls.Add(this.comboxManAvailCrsforIns);
            this.panelManually.Controls.Add(this.txtDegManTxtQ);
            this.panelManually.Controls.Add(this.txtDegManTFQ);
            this.panelManually.Controls.Add(this.lblDegQsts);
            this.panelManually.Controls.Add(this.txtDegManMCQ);
            this.panelManually.Controls.Add(this.txtIdsManTxtQ);
            this.panelManually.Controls.Add(this.txtIdsManTFQ);
            this.panelManually.Controls.Add(this.txtIdsManMCQ);
            this.panelManually.Controls.Add(this.lblTxtQIds);
            this.panelManually.Controls.Add(this.lblTFQIds);
            this.panelManually.Controls.Add(this.lblMCQIds);
            this.panelManually.IsDerivedStyle = true;
            this.panelManually.Location = new System.Drawing.Point(157, 285);
            this.panelManually.Name = "panelManually";
            this.panelManually.Size = new System.Drawing.Size(660, 235);
            this.panelManually.Style = MetroSet_UI.Enums.Style.Light;
            this.panelManually.StyleManager = null;
            this.panelManually.TabIndex = 25;
            this.panelManually.ThemeAuthor = "Narwin";
            this.panelManually.ThemeName = "MetroLite";
            this.panelManually.Visible = false;
            // 
            // lblMCQIds
            // 
            this.lblMCQIds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMCQIds.IsDerivedStyle = true;
            this.lblMCQIds.Location = new System.Drawing.Point(38, 40);
            this.lblMCQIds.Name = "lblMCQIds";
            this.lblMCQIds.Size = new System.Drawing.Size(87, 29);
            this.lblMCQIds.Style = MetroSet_UI.Enums.Style.Light;
            this.lblMCQIds.StyleManager = null;
            this.lblMCQIds.TabIndex = 0;
            this.lblMCQIds.Text = "MCQ Ids";
            this.lblMCQIds.ThemeAuthor = "Narwin";
            this.lblMCQIds.ThemeName = "MetroLite";
            // 
            // lblTFQIds
            // 
            this.lblTFQIds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTFQIds.IsDerivedStyle = true;
            this.lblTFQIds.Location = new System.Drawing.Point(38, 77);
            this.lblTFQIds.Name = "lblTFQIds";
            this.lblTFQIds.Size = new System.Drawing.Size(87, 29);
            this.lblTFQIds.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTFQIds.StyleManager = null;
            this.lblTFQIds.TabIndex = 1;
            this.lblTFQIds.Text = "TFQ Ids";
            this.lblTFQIds.ThemeAuthor = "Narwin";
            this.lblTFQIds.ThemeName = "MetroLite";
            // 
            // lblTxtQIds
            // 
            this.lblTxtQIds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTxtQIds.IsDerivedStyle = true;
            this.lblTxtQIds.Location = new System.Drawing.Point(38, 116);
            this.lblTxtQIds.Name = "lblTxtQIds";
            this.lblTxtQIds.Size = new System.Drawing.Size(87, 29);
            this.lblTxtQIds.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTxtQIds.StyleManager = null;
            this.lblTxtQIds.TabIndex = 2;
            this.lblTxtQIds.Text = "TxtQ Ids";
            this.lblTxtQIds.ThemeAuthor = "Narwin";
            this.lblTxtQIds.ThemeName = "MetroLite";
            // 
            // txtIdsManMCQ
            // 
            this.txtIdsManMCQ.AutoCompleteCustomSource = null;
            this.txtIdsManMCQ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtIdsManMCQ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtIdsManMCQ.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtIdsManMCQ.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtIdsManMCQ.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtIdsManMCQ.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtIdsManMCQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIdsManMCQ.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtIdsManMCQ.Image = null;
            this.txtIdsManMCQ.IsDerivedStyle = true;
            this.txtIdsManMCQ.Lines = null;
            this.txtIdsManMCQ.Location = new System.Drawing.Point(166, 40);
            this.txtIdsManMCQ.MaxLength = 32767;
            this.txtIdsManMCQ.Multiline = false;
            this.txtIdsManMCQ.Name = "txtIdsManMCQ";
            this.txtIdsManMCQ.ReadOnly = false;
            this.txtIdsManMCQ.Size = new System.Drawing.Size(274, 29);
            this.txtIdsManMCQ.Style = MetroSet_UI.Enums.Style.Light;
            this.txtIdsManMCQ.StyleManager = null;
            this.txtIdsManMCQ.TabIndex = 3;
            this.txtIdsManMCQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdsManMCQ.ThemeAuthor = "Narwin";
            this.txtIdsManMCQ.ThemeName = "MetroLite";
            this.txtIdsManMCQ.UseSystemPasswordChar = false;
            this.txtIdsManMCQ.WatermarkText = "";
            // 
            // txtIdsManTFQ
            // 
            this.txtIdsManTFQ.AutoCompleteCustomSource = null;
            this.txtIdsManTFQ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtIdsManTFQ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtIdsManTFQ.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtIdsManTFQ.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtIdsManTFQ.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtIdsManTFQ.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtIdsManTFQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIdsManTFQ.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtIdsManTFQ.Image = null;
            this.txtIdsManTFQ.IsDerivedStyle = true;
            this.txtIdsManTFQ.Lines = null;
            this.txtIdsManTFQ.Location = new System.Drawing.Point(166, 77);
            this.txtIdsManTFQ.MaxLength = 32767;
            this.txtIdsManTFQ.Multiline = false;
            this.txtIdsManTFQ.Name = "txtIdsManTFQ";
            this.txtIdsManTFQ.ReadOnly = false;
            this.txtIdsManTFQ.Size = new System.Drawing.Size(274, 29);
            this.txtIdsManTFQ.Style = MetroSet_UI.Enums.Style.Light;
            this.txtIdsManTFQ.StyleManager = null;
            this.txtIdsManTFQ.TabIndex = 4;
            this.txtIdsManTFQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdsManTFQ.ThemeAuthor = "Narwin";
            this.txtIdsManTFQ.ThemeName = "MetroLite";
            this.txtIdsManTFQ.UseSystemPasswordChar = false;
            this.txtIdsManTFQ.WatermarkText = "";
            // 
            // txtIdsManTxtQ
            // 
            this.txtIdsManTxtQ.AutoCompleteCustomSource = null;
            this.txtIdsManTxtQ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtIdsManTxtQ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtIdsManTxtQ.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtIdsManTxtQ.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtIdsManTxtQ.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtIdsManTxtQ.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtIdsManTxtQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIdsManTxtQ.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtIdsManTxtQ.Image = null;
            this.txtIdsManTxtQ.IsDerivedStyle = true;
            this.txtIdsManTxtQ.Lines = null;
            this.txtIdsManTxtQ.Location = new System.Drawing.Point(166, 116);
            this.txtIdsManTxtQ.MaxLength = 32767;
            this.txtIdsManTxtQ.Multiline = false;
            this.txtIdsManTxtQ.Name = "txtIdsManTxtQ";
            this.txtIdsManTxtQ.ReadOnly = false;
            this.txtIdsManTxtQ.Size = new System.Drawing.Size(274, 29);
            this.txtIdsManTxtQ.Style = MetroSet_UI.Enums.Style.Light;
            this.txtIdsManTxtQ.StyleManager = null;
            this.txtIdsManTxtQ.TabIndex = 5;
            this.txtIdsManTxtQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdsManTxtQ.ThemeAuthor = "Narwin";
            this.txtIdsManTxtQ.ThemeName = "MetroLite";
            this.txtIdsManTxtQ.UseSystemPasswordChar = false;
            this.txtIdsManTxtQ.WatermarkText = "";
            // 
            // txtDegManMCQ
            // 
            this.txtDegManMCQ.AutoCompleteCustomSource = null;
            this.txtDegManMCQ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDegManMCQ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDegManMCQ.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtDegManMCQ.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtDegManMCQ.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtDegManMCQ.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtDegManMCQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDegManMCQ.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtDegManMCQ.Image = null;
            this.txtDegManMCQ.IsDerivedStyle = true;
            this.txtDegManMCQ.Lines = null;
            this.txtDegManMCQ.Location = new System.Drawing.Point(516, 40);
            this.txtDegManMCQ.MaxLength = 32767;
            this.txtDegManMCQ.Multiline = false;
            this.txtDegManMCQ.Name = "txtDegManMCQ";
            this.txtDegManMCQ.ReadOnly = false;
            this.txtDegManMCQ.Size = new System.Drawing.Size(66, 29);
            this.txtDegManMCQ.Style = MetroSet_UI.Enums.Style.Light;
            this.txtDegManMCQ.StyleManager = null;
            this.txtDegManMCQ.TabIndex = 6;
            this.txtDegManMCQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDegManMCQ.ThemeAuthor = "Narwin";
            this.txtDegManMCQ.ThemeName = "MetroLite";
            this.txtDegManMCQ.UseSystemPasswordChar = false;
            this.txtDegManMCQ.WatermarkText = "";
            // 
            // lblDegQsts
            // 
            this.lblDegQsts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDegQsts.IsDerivedStyle = true;
            this.lblDegQsts.Location = new System.Drawing.Point(516, 8);
            this.lblDegQsts.Name = "lblDegQsts";
            this.lblDegQsts.Size = new System.Drawing.Size(66, 29);
            this.lblDegQsts.Style = MetroSet_UI.Enums.Style.Light;
            this.lblDegQsts.StyleManager = null;
            this.lblDegQsts.TabIndex = 7;
            this.lblDegQsts.Text = "Degree";
            this.lblDegQsts.ThemeAuthor = "Narwin";
            this.lblDegQsts.ThemeName = "MetroLite";
            // 
            // txtDegManTFQ
            // 
            this.txtDegManTFQ.AutoCompleteCustomSource = null;
            this.txtDegManTFQ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDegManTFQ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDegManTFQ.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtDegManTFQ.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtDegManTFQ.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtDegManTFQ.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtDegManTFQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDegManTFQ.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtDegManTFQ.Image = null;
            this.txtDegManTFQ.IsDerivedStyle = true;
            this.txtDegManTFQ.Lines = null;
            this.txtDegManTFQ.Location = new System.Drawing.Point(516, 77);
            this.txtDegManTFQ.MaxLength = 32767;
            this.txtDegManTFQ.Multiline = false;
            this.txtDegManTFQ.Name = "txtDegManTFQ";
            this.txtDegManTFQ.ReadOnly = false;
            this.txtDegManTFQ.Size = new System.Drawing.Size(66, 29);
            this.txtDegManTFQ.Style = MetroSet_UI.Enums.Style.Light;
            this.txtDegManTFQ.StyleManager = null;
            this.txtDegManTFQ.TabIndex = 8;
            this.txtDegManTFQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDegManTFQ.ThemeAuthor = "Narwin";
            this.txtDegManTFQ.ThemeName = "MetroLite";
            this.txtDegManTFQ.UseSystemPasswordChar = false;
            this.txtDegManTFQ.WatermarkText = "";
            // 
            // txtDegManTxtQ
            // 
            this.txtDegManTxtQ.AutoCompleteCustomSource = null;
            this.txtDegManTxtQ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDegManTxtQ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDegManTxtQ.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtDegManTxtQ.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtDegManTxtQ.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtDegManTxtQ.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtDegManTxtQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDegManTxtQ.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtDegManTxtQ.Image = null;
            this.txtDegManTxtQ.IsDerivedStyle = true;
            this.txtDegManTxtQ.Lines = null;
            this.txtDegManTxtQ.Location = new System.Drawing.Point(516, 116);
            this.txtDegManTxtQ.MaxLength = 32767;
            this.txtDegManTxtQ.Multiline = false;
            this.txtDegManTxtQ.Name = "txtDegManTxtQ";
            this.txtDegManTxtQ.ReadOnly = false;
            this.txtDegManTxtQ.Size = new System.Drawing.Size(66, 29);
            this.txtDegManTxtQ.Style = MetroSet_UI.Enums.Style.Light;
            this.txtDegManTxtQ.StyleManager = null;
            this.txtDegManTxtQ.TabIndex = 9;
            this.txtDegManTxtQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDegManTxtQ.ThemeAuthor = "Narwin";
            this.txtDegManTxtQ.ThemeName = "MetroLite";
            this.txtDegManTxtQ.UseSystemPasswordChar = false;
            this.txtDegManTxtQ.WatermarkText = "";
            // 
            // comboxManAvailCrsforIns
            // 
            this.comboxManAvailCrsforIns.AllowDrop = true;
            this.comboxManAvailCrsforIns.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboxManAvailCrsforIns.BackColor = System.Drawing.Color.Transparent;
            this.comboxManAvailCrsforIns.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.comboxManAvailCrsforIns.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboxManAvailCrsforIns.CausesValidation = false;
            this.comboxManAvailCrsforIns.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.comboxManAvailCrsforIns.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.comboxManAvailCrsforIns.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.comboxManAvailCrsforIns.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboxManAvailCrsforIns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxManAvailCrsforIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboxManAvailCrsforIns.FormattingEnabled = true;
            this.comboxManAvailCrsforIns.IsDerivedStyle = true;
            this.comboxManAvailCrsforIns.ItemHeight = 20;
            this.comboxManAvailCrsforIns.Location = new System.Drawing.Point(166, 160);
            this.comboxManAvailCrsforIns.Name = "comboxManAvailCrsforIns";
            this.comboxManAvailCrsforIns.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.comboxManAvailCrsforIns.SelectedItemForeColor = System.Drawing.Color.White;
            this.comboxManAvailCrsforIns.Size = new System.Drawing.Size(121, 26);
            this.comboxManAvailCrsforIns.Style = MetroSet_UI.Enums.Style.Light;
            this.comboxManAvailCrsforIns.StyleManager = null;
            this.comboxManAvailCrsforIns.TabIndex = 10;
            this.comboxManAvailCrsforIns.ThemeAuthor = "Narwin";
            this.comboxManAvailCrsforIns.ThemeName = "MetroLite";
            // 
            // btnCrtManExam
            // 
            this.btnCrtManExam.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCrtManExam.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCrtManExam.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnCrtManExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCrtManExam.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnCrtManExam.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnCrtManExam.HoverTextColor = System.Drawing.Color.White;
            this.btnCrtManExam.IsDerivedStyle = true;
            this.btnCrtManExam.Location = new System.Drawing.Point(516, 189);
            this.btnCrtManExam.Name = "btnCrtManExam";
            this.btnCrtManExam.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCrtManExam.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCrtManExam.NormalTextColor = System.Drawing.Color.White;
            this.btnCrtManExam.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnCrtManExam.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnCrtManExam.PressTextColor = System.Drawing.Color.White;
            this.btnCrtManExam.Size = new System.Drawing.Size(115, 33);
            this.btnCrtManExam.Style = MetroSet_UI.Enums.Style.Light;
            this.btnCrtManExam.StyleManager = null;
            this.btnCrtManExam.TabIndex = 11;
            this.btnCrtManExam.Text = "Create Exam";
            this.btnCrtManExam.ThemeAuthor = "Narwin";
            this.btnCrtManExam.ThemeName = "MetroLite";
            this.btnCrtManExam.Click += new System.EventHandler(this.btnCrtManExam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 694);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.Tabs);
            this.Name = "Form1";
            this.Text = "Examination System";
            this.Tabs.ResumeLayout(false);
            this.Creat_Exam.ResumeLayout(false);
            this.panelRandomly.ResumeLayout(false);
            this.panelManually.ResumeLayout(false);
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
        private MetroSet_UI.Controls.MetroSetButton btnCrtRandExam;
        private MetroSet_UI.Controls.MetroSetLabel lblCalc;
        private MetroSet_UI.Controls.MetroSetLabel lblAllowanceOpts;
        private MetroSet_UI.Controls.MetroSetLabel lblInternet;
        private MetroSet_UI.Controls.MetroSetLabel lblOpenBook;
        private MetroSet_UI.Controls.MetroSetComboBox comboxInternet;
        private MetroSet_UI.Controls.MetroSetComboBox comboxOpenBook;
        private MetroSet_UI.Controls.MetroSetComboBox comboxCalc;
        private MetroSet_UI.Controls.MetroSetPanel panelManually;
        private MetroSet_UI.Controls.MetroSetLabel lblMCQIds;
        private MetroSet_UI.Controls.MetroSetLabel lblTxtQIds;
        private MetroSet_UI.Controls.MetroSetLabel lblTFQIds;
        private MetroSet_UI.Controls.MetroSetLabel lblDegQsts;
        private MetroSet_UI.Controls.MetroSetTextBox txtDegManMCQ;
        private MetroSet_UI.Controls.MetroSetTextBox txtIdsManTxtQ;
        private MetroSet_UI.Controls.MetroSetTextBox txtIdsManTFQ;
        private MetroSet_UI.Controls.MetroSetTextBox txtIdsManMCQ;
        private MetroSet_UI.Controls.MetroSetTextBox txtDegManTxtQ;
        private MetroSet_UI.Controls.MetroSetTextBox txtDegManTFQ;
        private MetroSet_UI.Controls.MetroSetButton btnCrtManExam;
        private MetroSet_UI.Controls.MetroSetComboBox comboxManAvailCrsforIns;
    }
}

