using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunnyNotepad
{
    public partial class Form1 : Form
    {
        string text = "I am fool. ";
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void rtbInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbInput_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void rtbInput_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            if (count == text.Length)
            {
                count = 0;
            }
            rtbInput.Text += text.Substring(count, 1);
            
            count++;
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {            
          DialogResult result=  MessageBox.Show("So you agree you are fool??","Fool",MessageBoxButtons.OKCancel);

          if (result.ToString() == "OK")
          {
              result = MessageBox.Show("Confirm you are fool", "Fool", MessageBoxButtons.OKCancel);
              if (result.ToString() == "OK")
              {
                  result = MessageBox.Show("Bye bye fool", "Fool", MessageBoxButtons.OK);
              }
              else
              {
                  e.Cancel = true;
              }
          }
          else {
              e.Cancel = true;
          }

        }
    }
}
