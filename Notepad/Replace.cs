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
            this.richTextBox1 = richTextBox1; //把主窗口的richTexBox1的地址付给当前richTexBox1控件
        }
        /// <summary>
        /// 向上查找的方法
        /// </summary>
        /// <param name="StringComparison">确定是否区分大小写</param>
        private void Up(StringComparison StringComparison)
        {

            if (richTextBox1.Text.IndexOf(tbFind.Text, StringComparison) == -1)
            {
                MessageBox.Show("找不到：\"" + tbFind.Text + "\""); //最初判断是否存在需要查找的内容，如果没有直接提示并退出该方法
                return;
            }
            int i;//用来记录当前光标所在的位置从而确定从哪开始查找
            int k;//用来记录查找后光标的所在位置从而实现查找功能
            i = richTextBox1.SelectionStart;//确定光标位置
            i--;//确保不会查找到同一个目标
            if (i < 0)//判断是否达到最后一个。 小于0是因为这是向上查找。
            {
                MessageBox.Show("已达最后一个");
                return;
            }
            k = richTextBox1.Text.LastIndexOf(tbFind.Text, i, StringComparison);//找到就确定光标所在位置
            if (k == -1)
            {
                MessageBox.Show("已达最后一个");
                return;
            }
            richTextBox1.Select(k, tbFind.Text.Length);//最后选中找到的内容

        }
        /// <summary>
        /// 向下查找的方法
        /// </summary>
        /// <param name="StringComparison"></param>
        private bool Down(StringComparison StringComparison,string str,string str1)
        {

            int i;//用来记录当前光标所在的位置从而确定从哪开始查找
            int k;//用来记录查找后光标的所在位置从而实现查找功能
            if (richTextBox1.SelectedText == tbFind.Text)//判断是否选中了查找内容。
            {
                i = richTextBox1.SelectionStart + tbFind.Text.Length; //选中的话需要调整光标位置
            }
            else
            {
                i = richTextBox1.SelectionStart;//未选中的话就不需要
            }
            if (richTextBox1.Text.IndexOf(tbFind.Text, StringComparison) == -1)//最初判断是否存在需要查找的内容，如果没有直接提示并退出该方法
            {
                //MessageBox.Show("找不到：\"" + tbFind.Text + "\"");
                MessageBox.Show(str);
                return false;
            }

            k = richTextBox1.Text.IndexOf(tbFind.Text, i, StringComparison);//判断是否达到最后一个
            if (k == -1)
            {
                //MessageBox.Show("已达最后一个");
                MessageBox.Show(str1);
                return false;
            }
            richTextBox1.Select(k, tbFind.Text.Length);//最后选中找到的内容
            return true;
        }
        /// <summary>
        /// 用来判断查找替换和全部替换的控件是否启用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///
        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            if (tbFind.Text == "")
            {
                btnFind.Enabled = false;
                btnReplace.Enabled = false;
                btnReplaceAll.Enabled = false;
            }
            else
            {
                btnFind.Enabled = true;
                btnReplace.Enabled = true;
                btnReplaceAll.Enabled = true;
            }
        }
        /// <summary>
        /// 查找的实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnFind_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) //先判断是否区分大小写
            {
                if (radDown.Checked)//然后判断是向上查找还是向下查找
                {
                    Down(StringComparison.CurrentCulture, "找不到：\"" + tbFind.Text + "\"", "已达最后一个");


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
                    Down(StringComparison.CurrentCultureIgnoreCase, "找不到：\"" + tbFind.Text + "\"", "已达最后一个");


                }
                else
                {
                    Up(StringComparison.CurrentCultureIgnoreCase);
                }

            }
        }
        /// <summary>
        /// 替换功能的实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (!(richTextBox1.SelectedText == ""))//判断是否有选中内容
            {
                richTextBox1.SelectedText = tbReplace.Text;//有就替换
            }
            else
            {
                MessageBox.Show("您未选中任何内容","提示");//没有就提示
            }
            
        }
        /// <summary>
        /// 全部替换功能的实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked)//先判断是否区分大小写
            {
                richTextBox1.SelectionStart = 0;//把光标位置设为0
                while (true)//通过循环向下查找来实现全部替换
                {

                    if (!Down(StringComparison.CurrentCulture, "全部替换完成", "全部替换完成"))
                    {
                        return;
                    }
                    richTextBox1.SelectedText = tbReplace.Text;

                }
            }
            else
            {
                richTextBox1.SelectionStart = 0;
                while (true)
                {
                    if (!Down(StringComparison.CurrentCultureIgnoreCase, "全部替换完成", "全部替换完成"))
                    {
                        return;
                    }
                    richTextBox1.SelectedText = tbReplace.Text;
                    
                }
            }
        }
        /// <summary>
        /// 实现点击右上角的关闭不是真关闭而是隐藏此窗体。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Replace_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

       
    }
}
