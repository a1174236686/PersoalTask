﻿using PersonalTask.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalTask
{
    public partial class Form1 : Form  
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IQueryable<tTask> tTaskIQ = new PersonalTask.DB.PersonalTaskDB().tTask;
            var a = new PersonalTask.DB.PersonalTaskDB().tTask.ToList();
                
        }
    }
}
