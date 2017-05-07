﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;

namespace Notepad
{
    public partial class notepad : Form
    {

        public notepad(string[] args)
        {
            if (args.Length >= 1)
            {
                path = args[0];

            }
            InitializeComponent();
            //---
            this.richTextBox1.DragEnter += RichTextBox1_DragEnter; //添加一个拖入边界时的事件
            this.richTextBox1.DragDrop += RichTextBox1_DragDrop; //添加一个拖入后放开鼠标左键的事件

        }

        private void RichTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] rs = (string[])e.Data.GetData(DataFormats.FileDrop);
                path = rs[0];
                if (richTextBox1.Text == "" && path == "") //如果路径和内容同时为空，直接打开即可。
                {
                    open1(path);
                    return;
                }
                if (isChange)//判断文件是否修改过
                {
                    DialogResult re = MessageBox.Show("文本的文字已经更改是否保存文本？", "记事本", MessageBoxButtons.YesNoCancel);//提示用户是否保存
                    if (re == System.Windows.Forms.DialogResult.Yes)//选择是的话调用保存这个方法 
                    {
                        if (SaveAs())
                        {
                            isChange = false;
                        }
                        
                    }
                    else
                    {
                        if (re == System.Windows.Forms.DialogResult.No)//选择否的话直接调用退出即可。
                        {
                            open1(path);
                        }

                    }

                }
                else
                {
                    open1(path);
                }
                
            }
        }

        private void RichTextBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        List<string> lately = new List<string>();//用来储存撤销的文本
        List<int> latelyCursor = new List<int>();//用来储存撤销的光标
        int latelyIndexes;//用来储存撤销到第几个的位置
        bool latelyWhether = true;//用来判断是由撤销引起的文本变化还是用户的输入与删除。
        int number = 10;//储存最多撤销的次数。可用于扩展到用户自定
        bool b = true;//这个bool类型只使用一次就是让取消撤销可以同步
        bool isChange = false;//判断文本字符是否改变
        string path = "";


        private bool SaveAs()
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) //判断是否保存成功
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.Default);//new保存用的类
                sw.Write(richTextBox1.Text);//保存文本内容
                sw.Close();//关闭该类，回收资源
                return true; //用来返回文件保存成功！
            }
            else
            {
                return false;//用来返回文件保存失败！
            }

        }
        /// <summary>
        /// 自动换行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiWordWrap_Click(object sender, EventArgs e)
        {
            if (richTextBox1.WordWrap)
            {
                richTextBox1.WordWrap = false;
                tsmiWordWrap.Checked = true;
                tsmiGoto.Enabled = false;
            }
            else
            {
                richTextBox1.WordWrap = true;
                tsmiWordWrap.Checked = false;
                tsmiGoto.Enabled = true;
            }
        }

        /// <summary>
        /// 设置字体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiTypeface_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }
        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSelectAll_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
        /// <summary>
        /// 打开帮助
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiCheckHelp_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
            help.Top = this.Top + 100;
            help.Left = this.Left + 100;
        }
        /// <summary>
        /// 打开关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
            about.Top = this.Top + 100;
            about.Left = this.Left + 100;
        }
        /// <summary>
        /// 状态栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiStatusBar_Click(object sender, EventArgs e)
        {
            if (statusStrip1.Visible)
            {
                statusStrip1.Visible = false;
                tsmiStatusBar.Checked = false;
            }
            else
            {
                statusStrip1.Visible = true;
                tsmiStatusBar.Checked = true;
            }
        }

        private void tsmiSaveAs_Click(object sender, EventArgs e)//调用另存为的方法。
        {
            SaveAs();
        }
        /// <summary>
        /// 颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiColour_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
        }
        /// <summary>
        /// 右键全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmSelectAll_Click(object sender, EventArgs e)
        {
            this.tsmiSelectAll_Click(sender, e);
        }
        /// <summary>
        /// 复制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
        /// <summary>
        /// 粘贴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiPaste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void tsmiRevoke_Click(object sender, EventArgs e)
        {
            if (latelyIndexes == 0)
            {

                return;
            }
            latelyWhether = false;
            richTextBox1.Text = lately.ElementAt(latelyIndexes - 1);
            richTextBox1.Select(latelyCursor.ElementAt(latelyIndexes - 1), 0);
            richTextBox1.ScrollToCaret();
            latelyIndexes--;
        }
        /// <summary>
        /// 剪切
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiShear_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
            richTextBox1.SelectedText = "";
        }
        /// <summary>
        /// 右键剪切
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmShear_Click(object sender, EventArgs e)
        {
            this.tsmiShear_Click(sender, e);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (latelyWhether)
            {
                latelyIndexes = lately.Count;
                lately.Add(richTextBox1.Text);
                latelyCursor.Add(richTextBox1.SelectionStart);
                if (latelyIndexes > number)
                {
                    latelyIndexes--;
                    lately.RemoveAt(0);
                    latelyCursor.RemoveAt(0);
                }
            }
            latelyWhether = true;
            isChange = true;

        }

        private void notepad_Load(object sender, EventArgs e)
        {
            richTextBox1.AllowDrop = true;//允许拖入文件到文本框
            if (path != "")
            {

                this.Text = Path.GetFileNameWithoutExtension(path) + "-记事本";
                StreamReader sr = new StreamReader(path, Encoding.Default);

                while (!sr.EndOfStream)
                {
                    richTextBox1.AppendText(sr.ReadLine() + "\n");
                }
                sr.Close();
                isChange = false;
            }
            //----------
            lately.Add("");
            latelyCursor.Add(0);

        }

        private void tsmiCancel_Click(object sender, EventArgs e)
        {
            if (latelyIndexes == lately.Count)
            {

                return;
            }
            if (b)
            {
                latelyIndexes++;
                b = false;
            }
            latelyWhether = false;
            richTextBox1.Text = lately.ElementAt(latelyIndexes);
            richTextBox1.Select(latelyCursor.ElementAt(latelyIndexes), 0);
            richTextBox1.ScrollToCaret();
            latelyIndexes++;
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void notepad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Delete)
            {
                tsmiDelete_Click(sender, e);
            }

        }

        private void tsmiTime_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = DateTime.Now.ToString();
        }

        private void tsmiCompile_Click(object sender, EventArgs e)
        {
            //if (richTextBox1.SelectedText.Length > 0)
            //{
            //    tsmiShear.Enabled = true;
            //    tsmiCopy.Enabled = true;
            //    tsmiDelete.Enabled = true;
            //    //
            //    //tsmShear.Enabled = true;
            //    //tsmCopy.Enabled = true;
            //}
            //else
            //{
            //    tsmiShear.Enabled = false;
            //    tsmiCopy.Enabled = false;
            //    tsmiDelete.Enabled = false;
            //    //
            //    //tsmShear.Enabled = false;
            //    //tsmCopy.Enabled = false;
            //}
        }

        private void tsmiGoto_Click(object sender, EventArgs e)
        {
            Goto newGoto = new Goto(richTextBox1);
            newGoto.Show();
        }
        /// <summary>
        /// 打开文件的方法
        /// </summary>
        private bool open()
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)//判断是否选中文件并确定。
            {
                path = openFileDialog1.FileName; //获取选中文件的路径
                this.Text = Path.GetFileNameWithoutExtension(path) + "-记事本";//获取文件的名字并打印在标题上。
                using (FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    byte[] Buffer = new byte[1024 * 1024 * 5];
                    string str = "";
                    richTextBox1.Text = "";
                    while (true)
                    {
                        int r = fsRead.Read(Buffer, 0, Buffer.Length);
                        if (r == 0)
                        {
                            break;
                        }
                        str = Encoding.Default.GetString(Buffer, 0, r);
                        richTextBox1.AppendText(str);

                    }

                }
                isChange = false; //既然是打开文件，就不算文本发生改变。不然刚打开什么都没动马上关闭就提示文本发生改变是否保存就尴尬了。
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 这个打开的方法不需要选择路径
        /// </summary>
        /// <returns></returns>
        private void open1(string newpath)
        {

            path = newpath; //获取选中文件的路径
            this.Text = Path.GetFileNameWithoutExtension(path) + "-记事本";//获取文件的名字并打印在标题上。
            using (FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] Buffer = new byte[1024 * 1024 * 5];
                string str = "";
                richTextBox1.Text = "";
                while (true)
                {
                    int r = fsRead.Read(Buffer, 0, Buffer.Length);
                    if (r == 0)
                    {
                        break;
                    }
                    str = Encoding.Default.GetString(Buffer, 0, r);
                    richTextBox1.AppendText(str);

                }

            }
            isChange = false; //既然是打开文件，就不算文本发生改变。不然刚打开什么都没动马上关闭就提示文本发生改变是否保存就尴尬了。
                
            
            
        }
        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "" && path == "") //如果路径和内容同时为空，直接打开即可。
            {
                open();
                return;
            }
            if (isChange)//判断文件是否修改过
            {
                DialogResult re = MessageBox.Show("文本的文字已经更改是否保存文本？", "记事本", MessageBoxButtons.YesNoCancel);//提示用户是否保存
                if (re == System.Windows.Forms.DialogResult.Yes)//选择是的话调用保存这个方法 然后退出即可。
                {
                    if (SaveAs())
                    {
                        isChange = false;
                    }
                }
                else
                {
                    if (re == System.Windows.Forms.DialogResult.No)//选择否的话直接调用退出即可。
                    {
                        open();
                    }

                }

            }
            else
            {
                open();
            }

        }

        private void tsmiNew_Click(object sender, EventArgs e)
        {
            New();//调用新建的方法
        }
        private bool New() //为什要返回值？ 为拖入打开文本打开文本做准备
        {
            if (richTextBox1.Text == "" && path == "")//如果路径和内容同时为空，直接结束该方法。（这和新建后没什么区别吧!）
            {
                return false;
            }
            if (isChange)//判断文本的内容是否改变，如果已改变跳出提示窗口。
            {

                DialogResult re = MessageBox.Show("文本的文字已经更改是否保存文本？", "记事本", MessageBoxButtons.YesNoCancel);
                if (re == System.Windows.Forms.DialogResult.Yes)//判断你的选择
                {

                    if (SaveAs())//判断是否保存成功，如果成功执行清空文本内容，并改变isChange说明这次改变的内容已经保存，下次如果内容无改变侧无需跳出提示窗口，直接新建或关闭
                    {
                        isChange = false;
                        richTextBox1.Text = "";
                    }

                }
                else
                {
                    if (re == System.Windows.Forms.DialogResult.No)//选择否的话直接清空文本内容，并改变isChange说明这次改变的内容已经彻底放弃。下次如果内容无改变侧无需跳出提示窗口，直接新建或关闭
                    {
                        richTextBox1.Text = "";
                        isChange = false;
                    }
                    else//既不是选是也不是选否那肯定是取消了，无需做任何该改变
                    {

                        return false;//直接退出该方法，避免执行了清空路径。
                    }
                }
            }
            path = "";//既然是新建，那必须清空路径。
            return true;

        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            if (path == "") //判断路径是否为空，如果为空直接调用另存为，如果不为空说明这个文件是打开或保存过的。知道路径直接保存就好。
            {
                if (SaveAs())//调用另存为的方法，成功了会返回true
                {
                    path = saveFileDialog1.FileName; //既然保存成功，那肯定有路径了，不然和另存有什么区别。
                    this.Text = Path.GetFileNameWithoutExtension(path) + "-记事本";//标题很重要
                }
            }
            else
            {
                StreamWriter sw = new StreamWriter(path, false, Encoding.Default);//new 保存文件的类
                sw.Write(richTextBox1.Text); //把文件写入
                sw.Close();//关闭该类
                isChange = false;//既然保存了，如果没有继续动它肯定可以马上关闭而不出现提示是否保存。
            }
        }
        private bool Exit()
        {
            if (richTextBox1.Text == "" && path == "") //如果路径和内容同时为空，直接退出即可。
            {
                this.Dispose();//调用退出
                return false;
            }
            if (isChange)//判断文件是否修改过
            {
                DialogResult re = MessageBox.Show("文本的文字已经更改是否保存文本？", "记事本", MessageBoxButtons.YesNoCancel);//提示用户是否保存
                if (re == System.Windows.Forms.DialogResult.Yes)//选择是的话调用保存这个方法 然后退出即可。
                {

                    if (SaveAs())
                    {
                        this.Dispose();
                        return false;
                    }
                    return true;

                }
                else
                {
                    if (re == System.Windows.Forms.DialogResult.No)//选择否的话直接调用退出即可。
                    {
                        this.Dispose();
                        return false;
                    }
                    else//既然选择取消，那既不退出也不保存。而且要把isChange改为true，不然再次点击退出的时候就有可能直接退出了。
                    {
                        isChange = true;
                        return true;

                    }
                }

            }
            return false;
        }
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void notepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Exit())//调用退出方法
            {
                e.Cancel = true;
            }

        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            string str;
            str = "第：" + (richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart) + 1).ToString() + "行，";
            str += "第：" + (richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexOfCurrentLine()) + "列";
            tsslposition.Text = str;
            tsslNumber.Text = "字数：" + richTextBox1.Text.Length;
            //--------------
            int inum = 0;
            int ichar = 0;
            int ipunctuation = 0;
            int ichi = 0;

            string strTemp;
            string strrichTextBox1 = richTextBox1.Text;

            for (int i = 0; i < strrichTextBox1.Length; i++)
            {
                strTemp = strrichTextBox1.Substring(i, 1);
                if ("0123456789".IndexOf(strTemp) != -1)
                {
                    inum++;
                }
                else if ("qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM·~@#%&*-=+{}|/^`!@#$%^&*()_+-={}[]\\|;':\",.<>/? \n\r".IndexOf(strTemp) != -1)
                {
                    ichar++;
                }
                else if ("!$…（）—【】、；‘：“，。《》？".IndexOf(strTemp) != -1)
                {
                    ipunctuation++;
                }
                else
                {
                    ichi++;
                }
            }
            tsslChinese.Text = "汉字：" + ichi;
            tsslLetter.Text = "字母：" + ichar;
            tsslPunctuation.Text = "标点：" + ipunctuation;
            tsslNum.Text = "数字：" + inum;

            //-----------------
            if (richTextBox1.SelectedText.Length > 0)
            {
                tsmiShear.Enabled = true;
                tsmiCopy.Enabled = true;
                tsmiDelete.Enabled = true;
                //
                tsmShear.Enabled = true;
                tsmCopy.Enabled = true;
            }
            else
            {
                tsmiShear.Enabled = false;
                tsmiCopy.Enabled = false;
                tsmiDelete.Enabled = false;
                //
                tsmShear.Enabled = false;
                tsmCopy.Enabled = false;
            }
        }

        private void tsmiFind_Click(object sender, EventArgs e)
        {
            Find newFind = new Find(richTextBox1);
            newFind.Show();
        }

        private void tsmiReplace_Click(object sender, EventArgs e)
        {
            Replace newReplace = new Replace(richTextBox1);
            newReplace.Show();
        }

        private void tsmPaste_Click(object sender, EventArgs e)
        {
            this.tsmiPaste_Click(sender, e);
        }

        private void tsmCopy_Click(object sender, EventArgs e)
        {
            this.tsmiCopy_Click(sender, e);
        }
    }
}
