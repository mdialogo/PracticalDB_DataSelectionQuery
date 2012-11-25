﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PracticalDB_DataSelectionQuery
{
    public partial class LogInForm : Form
    {
        SelectionForm selForm = new SelectionForm();
        CSE_DEPTDataSet ds = new CSE_DEPTDataSet();

        public LogInForm()
        {
            InitializeComponent();
        }
        private void cmdLogIn_Click(object sender, EventArgs e)
        {
            CSE_DEPTDataSetTableAdapters.LogInTableAdapter LogInTableApt = new CSE_DEPTDataSetTableAdapters.LogInTableAdapter();
            LogInTableApt.ClearBeforeFill = true;
            LogInTableApt.FillByUsernamePassword(ds.LogIn, txtUserName.Text, txtPassWord.Text);
            if (ds.LogIn.Count == 0)
            {
                MessageBox.Show("No matched username/password found!",this.Text,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtUserName.Clear();
                txtUserName.Focus();
                txtPassWord.Clear();
            }
            else
            {
                selForm.Show();
                this.Hide();
            }
        }
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public LogInForm getLogInForm()
        {
            return this;
        }
    }
}
