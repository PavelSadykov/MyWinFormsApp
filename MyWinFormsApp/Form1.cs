using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StyleLibrary;

namespace MyWinFormsApp
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();

            StyleProcessor.ChangeButtonStyle(button1, Color.Red, Color.White, new Font("Arial", 12, FontStyle.Bold));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}


