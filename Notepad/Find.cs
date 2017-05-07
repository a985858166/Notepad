using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Find : Form
    {
        RichTextBox richTextBox1;

        public Find(RichTextBox richTextBox1)
        {
            InitializeComponent();
            this.richTextBox1 = richTextBox1;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (radDown.Checked)
                {
                    Down(StringComparison.CurrentCulture);


                }
                else
                {
                    Up(StringComparison.CurrentCulture);
                }
            }
            else
            {
                if (radDown.Checked)
                {
                    Down(StringComparison.CurrentCultureIgnoreCase);


                }
                else
                {
                    Up(StringComparison.CurrentCultureIgnoreCase);
                }
                
            }
        }
        private void Up(StringComparison StringComparison)
        {

            if (richTextBox1.Text.IndexOf(tbFind.Text, StringComparison) == -1)
            {
                MessageBox.Show("找不到：\"" + tbFind.Text + "\"");
                return;
            }
            int i;
            int k;
            i = richTextBox1.SelectionStart;
            i--;
            if (i <= 0)
            {
                MessageBox.Show("已达最后一个");
                return;
            }
            k = richTextBox1.Text.LastIndexOf(tbFind.Text, i, StringComparison);
            if (k == -1)
            {
                MessageBox.Show("已达最后一个");
                return;
            }
            richTextBox1.Select(k, tbFind.Text.Length);

        }

        private void Down(StringComparison StringComparison)
        {

            int i;
            int k;
            if (richTextBox1.SelectedText == tbFind.Text)
            {
                i = richTextBox1.SelectionStart + tbFind.Text.Length;
            }
            else
            {
                i = richTextBox1.SelectionStart;
            }
            if (richTextBox1.Text.IndexOf(tbFind.Text, StringComparison) == -1)
            {
                MessageBox.Show("找不到：\"" + tbFind.Text + "\"");
                return;
            }

            k = richTextBox1.Text.IndexOf(tbFind.Text, i, StringComparison);
            if (k == -1)
            {
                MessageBox.Show("已达最后一个");
                return;
            }
            richTextBox1.Select(k, tbFind.Text.Length);
        }

        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            if (tbFind.Text == "")
            {
                btnFind.Enabled = false;
            }
            else
            {
                btnFind.Enabled = true;
            }
        }

        
    }
}
