﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cw8_listBox.Models;

namespace cw8_listBox
{
    public partial class AddProductForm : Form {
        private Form1 _form;
        public AddProductForm(Form1 form)
        {
            _form = form;
            InitializeComponent();
        }
    }
}