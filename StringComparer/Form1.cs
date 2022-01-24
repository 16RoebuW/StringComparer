using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringComparer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ValidateString(tbxStringX.Text) && ValidateString(tbxStringY.Text))
            { }
            else
            {
                MessageBox.Show("Please enter a valid string under 1025 characters in length", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ValidateString(string input)
        {
            if (input.Length >= 1024)
                return false;
            if (input == "")
                return false;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 127)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
