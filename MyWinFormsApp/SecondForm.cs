using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MyWinFormsApp
{
    public partial class SecondForm : Form
    {
        private Button myButton;

        public SecondForm()
        {
            InitializeComponent();
            ModifyButtonStyle();
        }

        private void ModifyButtonStyle()
        {
            Form1 firstForm = new Form1();

            // Ищем кнопку по имени из формы FirstForm
            if (firstForm.Controls.ContainsKey("myButton"))
            {
                myButton = firstForm.Controls["myButton"] as Button;

                if (myButton != null)
                {
                    myButton.BackColor = Color.Red;
                    myButton.ForeColor = Color.White;
                    myButton.Font = new Font("Arial", 12, FontStyle.Bold);
                }
            }
        }
    }
}
