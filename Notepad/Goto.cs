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
        /// <summary>
        /// 转跳按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Convert.ToInt32(numericUpDown1.Value) <= richTextBox1.Lines.Count())//判断转跳行数是否小于最大行数
            {
                richTextBox1.SelectionStart = richTextBox1.GetFirstCharIndexFromLine(Convert.ToInt32(numericUpDown1.Value) - 1);
                richTextBox1.SelectionLength = 0;//先把光标转到自己选定的行数，然后将滚动条滑倒当前位置实现转跳。
                richTextBox1.Focus();
            }
            
        }
        /// <summary>
        /// 确定可以输入的最大值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Goto_Load(object sender, EventArgs e)
        {

            numericUpDown1.Value = Convert.ToDecimal(richTextBox1.Lines.Count()); 
            numericUpDown1.Maximum = Convert.ToDecimal(richTextBox1.Lines.Count());
        }
    }
}
