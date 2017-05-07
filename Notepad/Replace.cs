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
    public partial class Replace : Form
    {
        RichTextBox richTextBox1;

        public Replace(RichTextBox richTextBox1)
        {
            InitializeComponent();
            this.richTextBox1 = richTextBox1;
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

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (!(richTextBox1.SelectedText == ""))
            {
                richTextBox1.SelectedText = tbReplace.Text;
            }
            else
            {
                MessageBox.Show("您未选中任何内容","提示");
            }
            
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked)
            {
                while (true)
                {
                    if (richTextBox1.Text.IndexOf(tbFind.Text, StringComparison.CurrentCultureIgnoreCase) == -1)
                    {
                        
                        return;
                    }
                    richTextBox1.SelectionStart = 0;
                    Down(StringComparison.CurrentCultureIgnoreCase);
                    richTextBox1.SelectedText = tbReplace.Text;
                }
            }
            else
            {
                while (true)
                {
                    if (richTextBox1.Text.IndexOf(tbFind.Text, StringComparison.CurrentCulture) == -1)
                    {

                        return;
                    }
                    richTextBox1.SelectionStart = 0;
                    Down(StringComparison.CurrentCulture);
                    richTextBox1.SelectedText = tbReplace.Text;
                }
            }
        }

       
    }
}
