using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Goto : Form
    {
        RichTextBox richTextBox1;
        public Goto(RichTextBox richTextBox1)
        {
            InitializeComponent();
            this.richTextBox1 = richTextBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Convert.ToInt32(maskedTextBox1.Text) > richTextBox1.Lines.Count() || Convert.ToInt32(maskedTextBox1.Text) == 0)
            {
                MessageBox.Show("行数超过总行数","记事本-跳行");
            }
            else
            {
                richTextBox1.SelectionStart = richTextBox1.GetFirstCharIndexFromLine(Convert.ToInt32(maskedTextBox1.Text) - 1);
                richTextBox1.SelectionLength = 0;
                richTextBox1.Focus();
            }
        }

        private void Goto_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = Convert.ToString(richTextBox1.Lines.Count());
        }
    }
}
