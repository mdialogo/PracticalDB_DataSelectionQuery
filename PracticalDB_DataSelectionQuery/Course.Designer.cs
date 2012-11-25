﻿namespace PracticalDB_DataSelectionQuery
{
    partial class CourseForm
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
            this.components = new System.ComponentModel.Container();
            this.cmdInsert = new System.Windows.Forms.Button();
            this.CourseList = new System.Windows.Forms.ListBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSE_DEPTDataSet = new PracticalDB_DataSelectionQuery.CSE_DEPTDataSet();
            this.EnrollLabel = new System.Windows.Forms.Label();
            this.FacultyNameLabel = new System.Windows.Forms.Label();
            this.cmdBack = new System.Windows.Forms.Button();
            this.CreditsLabel = new System.Windows.Forms.Label();
            this.cmdSelect = new System.Windows.Forms.Button();
            this.CourseBox = new System.Windows.Forms.GroupBox();
            this.ClassRoomLabel = new System.Windows.Forms.Label();
            this.ScheduleLabel = new System.Windows.Forms.Label();
            this.ComboName = new System.Windows.Forms.ComboBox();
            this.CourseTitleLabel = new System.Windows.Forms.Label();
            this.txtEnroll = new System.Windows.Forms.TextBox();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.GroupBox();
            this.ComboMethod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CourseInfoBox = new System.Windows.Forms.GroupBox();
            this.txtClassRoom = new System.Windows.Forms.TextBox();
            this.txtSchedule = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.courseTableAdapter = new PracticalDB_DataSelectionQuery.CSE_DEPTDataSetTableAdapters.CourseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSE_DEPTDataSet)).BeginInit();
            this.CourseBox.SuspendLayout();
            this.NameBox.SuspendLayout();
            this.CourseInfoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdInsert
            // 
            this.cmdInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdInsert.Location = new System.Drawing.Point(356, 40);
            this.cmdInsert.Name = "cmdInsert";
            this.cmdInsert.Size = new System.Drawing.Size(76, 23);
            this.cmdInsert.TabIndex = 4;
            this.cmdInsert.Text = "Insert";
            // 
            // CourseList
            // 
            this.CourseList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CourseList.DataSource = this.courseBindingSource;
            this.CourseList.DisplayMember = "course_id";
            this.CourseList.Location = new System.Drawing.Point(6, 19);
            this.CourseList.Name = "CourseList";
            this.CourseList.Size = new System.Drawing.Size(134, 158);
            this.CourseList.TabIndex = 0;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.cSE_DEPTDataSet;
            // 
            // cSE_DEPTDataSet
            // 
            this.cSE_DEPTDataSet.DataSetName = "CSE_DEPTDataSet";
            this.cSE_DEPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EnrollLabel
            // 
            this.EnrollLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrollLabel.Location = new System.Drawing.Point(6, 141);
            this.EnrollLabel.Name = "EnrollLabel";
            this.EnrollLabel.Size = new System.Drawing.Size(75, 27);
            this.EnrollLabel.TabIndex = 8;
            this.EnrollLabel.Text = "Enrollment";
            this.EnrollLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FacultyNameLabel
            // 
            this.FacultyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyNameLabel.Location = new System.Drawing.Point(6, 23);
            this.FacultyNameLabel.Name = "FacultyNameLabel";
            this.FacultyNameLabel.Size = new System.Drawing.Size(100, 23);
            this.FacultyNameLabel.TabIndex = 0;
            this.FacultyNameLabel.Text = "Faculty Name";
            this.FacultyNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdBack
            // 
            this.cmdBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBack.Location = new System.Drawing.Point(356, 68);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(76, 23);
            this.cmdBack.TabIndex = 5;
            this.cmdBack.Text = "Back";
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // CreditsLabel
            // 
            this.CreditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditsLabel.Location = new System.Drawing.Point(6, 113);
            this.CreditsLabel.Name = "CreditsLabel";
            this.CreditsLabel.Size = new System.Drawing.Size(75, 27);
            this.CreditsLabel.TabIndex = 6;
            this.CreditsLabel.Text = "Credits";
            this.CreditsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdSelect
            // 
            this.cmdSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSelect.Location = new System.Drawing.Point(356, 12);
            this.cmdSelect.Name = "cmdSelect";
            this.cmdSelect.Size = new System.Drawing.Size(76, 23);
            this.cmdSelect.TabIndex = 3;
            this.cmdSelect.Text = "Select";
            this.cmdSelect.Click += new System.EventHandler(this.cmdSelect_Click);
            // 
            // CourseBox
            // 
            this.CourseBox.Controls.Add(this.CourseList);
            this.CourseBox.Location = new System.Drawing.Point(12, 108);
            this.CourseBox.Name = "CourseBox";
            this.CourseBox.Size = new System.Drawing.Size(153, 196);
            this.CourseBox.TabIndex = 1;
            this.CourseBox.TabStop = false;
            this.CourseBox.Text = "Course List";
            // 
            // ClassRoomLabel
            // 
            this.ClassRoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassRoomLabel.Location = new System.Drawing.Point(6, 85);
            this.ClassRoomLabel.Name = "ClassRoomLabel";
            this.ClassRoomLabel.Size = new System.Drawing.Size(75, 27);
            this.ClassRoomLabel.TabIndex = 4;
            this.ClassRoomLabel.Text = "Classroom";
            this.ClassRoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ScheduleLabel
            // 
            this.ScheduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleLabel.Location = new System.Drawing.Point(6, 55);
            this.ScheduleLabel.Name = "ScheduleLabel";
            this.ScheduleLabel.Size = new System.Drawing.Size(75, 27);
            this.ScheduleLabel.TabIndex = 2;
            this.ScheduleLabel.Text = "Schedule";
            this.ScheduleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboName
            // 
            this.ComboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboName.FormattingEnabled = true;
            this.ComboName.Location = new System.Drawing.Point(103, 20);
            this.ComboName.Name = "ComboName";
            this.ComboName.Size = new System.Drawing.Size(152, 21);
            this.ComboName.TabIndex = 1;
            // 
            // CourseTitleLabel
            // 
            this.CourseTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseTitleLabel.Location = new System.Drawing.Point(6, 32);
            this.CourseTitleLabel.Name = "CourseTitleLabel";
            this.CourseTitleLabel.Size = new System.Drawing.Size(75, 20);
            this.CourseTitleLabel.TabIndex = 0;
            this.CourseTitleLabel.Text = "Course";
            this.CourseTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEnroll
            // 
            this.txtEnroll.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "enrollment", true));
            this.txtEnroll.Location = new System.Drawing.Point(87, 145);
            this.txtEnroll.Name = "txtEnroll";
            this.txtEnroll.Size = new System.Drawing.Size(189, 20);
            this.txtEnroll.TabIndex = 9;
            // 
            // txtCredits
            // 
            this.txtCredits.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "credit", true));
            this.txtCredits.Location = new System.Drawing.Point(87, 117);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(189, 20);
            this.txtCredits.TabIndex = 7;
            // 
            // NameBox
            // 
            this.NameBox.Controls.Add(this.ComboMethod);
            this.NameBox.Controls.Add(this.label1);
            this.NameBox.Controls.Add(this.ComboName);
            this.NameBox.Controls.Add(this.FacultyNameLabel);
            this.NameBox.Location = new System.Drawing.Point(12, 12);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(297, 80);
            this.NameBox.TabIndex = 0;
            this.NameBox.TabStop = false;
            this.NameBox.Text = "Faculty Name";
            // 
            // ComboMethod
            // 
            this.ComboMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMethod.FormattingEnabled = true;
            this.ComboMethod.Location = new System.Drawing.Point(103, 47);
            this.ComboMethod.Name = "ComboMethod";
            this.ComboMethod.Size = new System.Drawing.Size(152, 21);
            this.ComboMethod.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Query Method";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CourseInfoBox
            // 
            this.CourseInfoBox.Controls.Add(this.EnrollLabel);
            this.CourseInfoBox.Controls.Add(this.CreditsLabel);
            this.CourseInfoBox.Controls.Add(this.ClassRoomLabel);
            this.CourseInfoBox.Controls.Add(this.ScheduleLabel);
            this.CourseInfoBox.Controls.Add(this.CourseTitleLabel);
            this.CourseInfoBox.Controls.Add(this.txtEnroll);
            this.CourseInfoBox.Controls.Add(this.txtCredits);
            this.CourseInfoBox.Controls.Add(this.txtClassRoom);
            this.CourseInfoBox.Controls.Add(this.txtSchedule);
            this.CourseInfoBox.Controls.Add(this.txtName);
            this.CourseInfoBox.Location = new System.Drawing.Point(182, 108);
            this.CourseInfoBox.Name = "CourseInfoBox";
            this.CourseInfoBox.Size = new System.Drawing.Size(294, 196);
            this.CourseInfoBox.TabIndex = 2;
            this.CourseInfoBox.TabStop = false;
            this.CourseInfoBox.Text = "Course Information";
            // 
            // txtClassRoom
            // 
            this.txtClassRoom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "classroom", true));
            this.txtClassRoom.Location = new System.Drawing.Point(87, 89);
            this.txtClassRoom.Name = "txtClassRoom";
            this.txtClassRoom.Size = new System.Drawing.Size(189, 20);
            this.txtClassRoom.TabIndex = 5;
            // 
            // txtSchedule
            // 
            this.txtSchedule.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "schedule", true));
            this.txtSchedule.Location = new System.Drawing.Point(87, 61);
            this.txtSchedule.Name = "txtSchedule";
            this.txtSchedule.Size = new System.Drawing.Size(189, 20);
            this.txtSchedule.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "course", true));
            this.txtName.Location = new System.Drawing.Point(87, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(189, 20);
            this.txtName.TabIndex = 1;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // CourseForm
            // 
            this.AcceptButton = this.cmdSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 319);
            this.Controls.Add(this.cmdInsert);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.cmdSelect);
            this.Controls.Add(this.CourseBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.CourseInfoBox);
            this.Name = "CourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSE DEPT Course Form";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSE_DEPTDataSet)).EndInit();
            this.CourseBox.ResumeLayout(false);
            this.NameBox.ResumeLayout(false);
            this.CourseInfoBox.ResumeLayout(false);
            this.CourseInfoBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button cmdInsert;
        internal System.Windows.Forms.ListBox CourseList;
        internal System.Windows.Forms.Label EnrollLabel;
        internal System.Windows.Forms.Label FacultyNameLabel;
        internal System.Windows.Forms.Button cmdBack;
        internal System.Windows.Forms.Label CreditsLabel;
        internal System.Windows.Forms.Button cmdSelect;
        internal System.Windows.Forms.GroupBox CourseBox;
        internal System.Windows.Forms.Label ClassRoomLabel;
        internal System.Windows.Forms.Label ScheduleLabel;
        internal System.Windows.Forms.ComboBox ComboName;
        internal System.Windows.Forms.Label CourseTitleLabel;
        internal System.Windows.Forms.TextBox txtEnroll;
        internal System.Windows.Forms.TextBox txtCredits;
        internal System.Windows.Forms.GroupBox NameBox;
        internal System.Windows.Forms.GroupBox CourseInfoBox;
        internal System.Windows.Forms.TextBox txtClassRoom;
        internal System.Windows.Forms.TextBox txtSchedule;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.ComboBox ComboMethod;
        internal System.Windows.Forms.Label label1;
        private CSE_DEPTDataSet cSE_DEPTDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private PracticalDB_DataSelectionQuery.CSE_DEPTDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
    }
}