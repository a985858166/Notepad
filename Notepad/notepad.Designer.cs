namespace Notepad
{
    partial class notepad
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notepad));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCompile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRevoke = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFind = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGoto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTypeface = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColour = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCheckHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslposition = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslChinese = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLetter = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslPunctuation = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiCompile,
            this.tsmiFormat,
            this.tsmiCheck,
            this.tsmiHelp});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(684, 25);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiOpen,
            this.tsmiSave,
            this.tsmiSaveAs,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(44, 21);
            this.tsmiFile.Text = "文件";
            // 
            // tsmiNew
            // 
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiNew.Size = new System.Drawing.Size(147, 22);
            this.tsmiNew.Text = "新建";
            this.tsmiNew.Click += new System.EventHandler(this.tsmiNew_Click);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOpen.Size = new System.Drawing.Size(147, 22);
            this.tsmiOpen.Text = "打开";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(147, 22);
            this.tsmiSave.Text = "保存";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.Size = new System.Drawing.Size(147, 22);
            this.tsmiSaveAs.Text = "另存为";
            this.tsmiSaveAs.Click += new System.EventHandler(this.tsmiSaveAs_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(147, 22);
            this.tsmiExit.Text = "退出";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiCompile
            // 
            this.tsmiCompile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRevoke,
            this.tsmiCancel,
            this.tsmiShear,
            this.tsmiCopy,
            this.tsmiPaste,
            this.tsmiDelete,
            this.tsmiFind,
            this.tsmiFindNext,
            this.tsmiReplace,
            this.tsmiGoto,
            this.tsmiSelectAll,
            this.tsmiTime});
            this.tsmiCompile.Name = "tsmiCompile";
            this.tsmiCompile.Size = new System.Drawing.Size(44, 21);
            this.tsmiCompile.Text = "编辑";
            // 
            // tsmiRevoke
            // 
            this.tsmiRevoke.Name = "tsmiRevoke";
            this.tsmiRevoke.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsmiRevoke.Size = new System.Drawing.Size(243, 22);
            this.tsmiRevoke.Text = "撤销";
            this.tsmiRevoke.Click += new System.EventHandler(this.tsmiRevoke_Click);
            // 
            // tsmiCancel
            // 
            this.tsmiCancel.Name = "tsmiCancel";
            this.tsmiCancel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.tsmiCancel.Size = new System.Drawing.Size(243, 22);
            this.tsmiCancel.Text = "取消撤销";
            this.tsmiCancel.Click += new System.EventHandler(this.tsmiCancel_Click);
            // 
            // tsmiShear
            // 
            this.tsmiShear.Enabled = false;
            this.tsmiShear.Name = "tsmiShear";
            this.tsmiShear.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiShear.Size = new System.Drawing.Size(243, 22);
            this.tsmiShear.Text = "剪切";
            this.tsmiShear.Click += new System.EventHandler(this.tsmiShear_Click);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Enabled = false;
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmiCopy.Size = new System.Drawing.Size(243, 22);
            this.tsmiCopy.Text = "复制";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmiPaste.Size = new System.Drawing.Size(243, 22);
            this.tsmiPaste.Text = "粘贴";
            this.tsmiPaste.Click += new System.EventHandler(this.tsmiPaste_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Enabled = false;
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(243, 22);
            this.tsmiDelete.Text = "删除                               Del";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // tsmiFind
            // 
            this.tsmiFind.Enabled = false;
            this.tsmiFind.Name = "tsmiFind";
            this.tsmiFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tsmiFind.Size = new System.Drawing.Size(243, 22);
            this.tsmiFind.Text = "查找";
            this.tsmiFind.Click += new System.EventHandler(this.tsmiFind_Click);
            // 
            // tsmiFindNext
            // 
            this.tsmiFindNext.Enabled = false;
            this.tsmiFindNext.Name = "tsmiFindNext";
            this.tsmiFindNext.Size = new System.Drawing.Size(243, 22);
            this.tsmiFindNext.Text = "查找下一个";
            this.tsmiFindNext.Click += new System.EventHandler(this.tsmiFindNext_Click);
            // 
            // tsmiReplace
            // 
            this.tsmiReplace.Enabled = false;
            this.tsmiReplace.Name = "tsmiReplace";
            this.tsmiReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.tsmiReplace.Size = new System.Drawing.Size(243, 22);
            this.tsmiReplace.Text = "替换";
            this.tsmiReplace.Click += new System.EventHandler(this.tsmiReplace_Click);
            // 
            // tsmiGoto
            // 
            this.tsmiGoto.Enabled = false;
            this.tsmiGoto.Name = "tsmiGoto";
            this.tsmiGoto.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.tsmiGoto.Size = new System.Drawing.Size(243, 22);
            this.tsmiGoto.Text = "转到";
            this.tsmiGoto.Click += new System.EventHandler(this.tsmiGoto_Click);
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmiSelectAll.Size = new System.Drawing.Size(243, 22);
            this.tsmiSelectAll.Text = "全选";
            this.tsmiSelectAll.Click += new System.EventHandler(this.tsmiSelectAll_Click);
            // 
            // tsmiTime
            // 
            this.tsmiTime.Name = "tsmiTime";
            this.tsmiTime.Size = new System.Drawing.Size(243, 22);
            this.tsmiTime.Text = "时间/日期";
            this.tsmiTime.Click += new System.EventHandler(this.tsmiTime_Click);
            // 
            // tsmiFormat
            // 
            this.tsmiFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiWordWrap,
            this.tsmiTypeface,
            this.tsmiColour});
            this.tsmiFormat.Name = "tsmiFormat";
            this.tsmiFormat.Size = new System.Drawing.Size(44, 21);
            this.tsmiFormat.Text = "格式";
            // 
            // tsmiWordWrap
            // 
            this.tsmiWordWrap.Name = "tsmiWordWrap";
            this.tsmiWordWrap.Size = new System.Drawing.Size(152, 22);
            this.tsmiWordWrap.Text = "自动换行";
            this.tsmiWordWrap.Click += new System.EventHandler(this.tsmiWordWrap_Click);
            // 
            // tsmiTypeface
            // 
            this.tsmiTypeface.Name = "tsmiTypeface";
            this.tsmiTypeface.Size = new System.Drawing.Size(152, 22);
            this.tsmiTypeface.Text = "字体";
            this.tsmiTypeface.Click += new System.EventHandler(this.tsmiTypeface_Click);
            // 
            // tsmiColour
            // 
            this.tsmiColour.Name = "tsmiColour";
            this.tsmiColour.Size = new System.Drawing.Size(152, 22);
            this.tsmiColour.Text = "颜色";
            this.tsmiColour.Click += new System.EventHandler(this.tsmiColour_Click);
            // 
            // tsmiCheck
            // 
            this.tsmiCheck.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStatusBar});
            this.tsmiCheck.Name = "tsmiCheck";
            this.tsmiCheck.Size = new System.Drawing.Size(44, 21);
            this.tsmiCheck.Text = "查看";
            // 
            // tsmiStatusBar
            // 
            this.tsmiStatusBar.Checked = true;
            this.tsmiStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiStatusBar.Name = "tsmiStatusBar";
            this.tsmiStatusBar.Size = new System.Drawing.Size(112, 22);
            this.tsmiStatusBar.Text = "状态栏";
            this.tsmiStatusBar.Click += new System.EventHandler(this.tsmiStatusBar_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCheckHelp,
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(44, 21);
            this.tsmiHelp.Text = "帮助";
            // 
            // tsmiCheckHelp
            // 
            this.tsmiCheckHelp.Name = "tsmiCheckHelp";
            this.tsmiCheckHelp.Size = new System.Drawing.Size(136, 22);
            this.tsmiCheckHelp.Text = "查看帮助";
            this.tsmiCheckHelp.Click += new System.EventHandler(this.tsmiCheckHelp_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(136, 22);
            this.tsmiAbout.Text = "关于记事本";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslposition,
            this.tsslNumber,
            this.tsslChinese,
            this.tsslLetter,
            this.tsslNum,
            this.tsslPunctuation});
            this.statusStrip1.Location = new System.Drawing.Point(0, 365);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(684, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslposition
            // 
            this.tsslposition.Name = "tsslposition";
            this.tsslposition.Size = new System.Drawing.Size(118, 17);
            this.tsslposition.Text = "第：1 行，第： 0 列";
            // 
            // tsslNumber
            // 
            this.tsslNumber.Name = "tsslNumber";
            this.tsslNumber.Size = new System.Drawing.Size(51, 17);
            this.tsslNumber.Text = "字数：0";
            // 
            // tsslChinese
            // 
            this.tsslChinese.Name = "tsslChinese";
            this.tsslChinese.Size = new System.Drawing.Size(51, 17);
            this.tsslChinese.Text = "汉字：0";
            // 
            // tsslLetter
            // 
            this.tsslLetter.Name = "tsslLetter";
            this.tsslLetter.Size = new System.Drawing.Size(51, 17);
            this.tsslLetter.Text = "字母：0";
            // 
            // tsslNum
            // 
            this.tsslNum.Name = "tsslNum";
            this.tsslNum.Size = new System.Drawing.Size(51, 17);
            this.tsslNum.Text = "数字：0";
            // 
            // tsslPunctuation
            // 
            this.tsslPunctuation.Name = "tsslPunctuation";
            this.tsslPunctuation.Size = new System.Drawing.Size(51, 17);
            this.tsslPunctuation.Text = "标点：0";
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new System.Drawing.Point(0, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(684, 340);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSelectAll,
            this.tsmShear,
            this.tsmCopy,
            this.tsmPaste});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 92);
            // 
            // tsmSelectAll
            // 
            this.tsmSelectAll.Name = "tsmSelectAll";
            this.tsmSelectAll.Size = new System.Drawing.Size(153, 22);
            this.tsmSelectAll.Text = "全选    Ctrl+A";
            this.tsmSelectAll.Click += new System.EventHandler(this.tsmSelectAll_Click);
            // 
            // tsmShear
            // 
            this.tsmShear.Enabled = false;
            this.tsmShear.Name = "tsmShear";
            this.tsmShear.Size = new System.Drawing.Size(153, 22);
            this.tsmShear.Text = "剪切    Ctrl+X";
            this.tsmShear.Click += new System.EventHandler(this.tsmShear_Click);
            // 
            // tsmCopy
            // 
            this.tsmCopy.Enabled = false;
            this.tsmCopy.Name = "tsmCopy";
            this.tsmCopy.Size = new System.Drawing.Size(153, 22);
            this.tsmCopy.Text = "复制    Ctrl+C";
            this.tsmCopy.Click += new System.EventHandler(this.tsmCopy_Click);
            // 
            // tsmPaste
            // 
            this.tsmPaste.Name = "tsmPaste";
            this.tsmPaste.Size = new System.Drawing.Size(153, 22);
            this.tsmPaste.Text = "粘贴    Ctrl+V";
            this.tsmPaste.Click += new System.EventHandler(this.tsmPaste_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.Filter = "txt文件(*.txt)|*.txt|所有文件|*.*";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "新建文本";
            this.saveFileDialog1.Filter = "txt文件(*.txt)|*.txt|所有文件|*.*";
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 387);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "notepad";
            this.Text = "记事本";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.notepad_FormClosing);
            this.Load += new System.EventHandler(this.notepad_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.notepad_KeyDown);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiCompile;
        private System.Windows.Forms.ToolStripMenuItem tsmiFormat;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheck;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiRevoke;
        private System.Windows.Forms.ToolStripMenuItem tsmiShear;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiFind;
        private System.Windows.Forms.ToolStripMenuItem tsmiFindNext;
        private System.Windows.Forms.ToolStripMenuItem tsmiReplace;
        private System.Windows.Forms.ToolStripMenuItem tsmiGoto;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiTime;
        private System.Windows.Forms.ToolStripMenuItem tsmiWordWrap;
        private System.Windows.Forms.ToolStripMenuItem tsmiTypeface;
        private System.Windows.Forms.ToolStripMenuItem tsmiStatusBar;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslposition;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem tsmiColour;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmSelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmShear;
        private System.Windows.Forms.ToolStripMenuItem tsmCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel tsslNumber;
        private System.Windows.Forms.ToolStripStatusLabel tsslChinese;
        private System.Windows.Forms.ToolStripStatusLabel tsslLetter;
        private System.Windows.Forms.ToolStripStatusLabel tsslNum;
        private System.Windows.Forms.ToolStripStatusLabel tsslPunctuation;
    }
}

