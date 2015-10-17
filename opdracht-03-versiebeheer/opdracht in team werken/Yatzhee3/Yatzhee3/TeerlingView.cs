﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yatzhee3
{
    public partial class TeerlingView : UserControl
    {
        private TeerlingController controller;
        public TeerlingView(TeerlingController c)
        {
            InitializeComponent();
            controller = c;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!controller.model.ColorIsRed)
            { 
            controller.Werp();
            controller.UpdateUI();
            
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            if (controller.model.ColorIsRed)
            {
                TeerlingLabel.BackColor = Color.White;
                controller.Fixated();
            }
            else
            {
                TeerlingLabel.BackColor = Color.Red;
                controller.Fixated();
            }
        }

        private void TeerlingView_Load(object sender, EventArgs e)
        {
            TeerlingLabel.BackColor = Color.White;

        }

        public void UpdateUI() {
            TeerlingLabel.Text = controller.model.TeerlingLabelText;
            
        }
    }
}
