using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Sofruner_ng
{
    public partial class MainWidget : Form
    {
        public MainWidget()
        {
            InitializeComponent();
        }

        #region MainWidget_Action

        /// <summary>
        /// load main widget function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWidget_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// load notify icon when closing, minimizing main window
        /// thread won't be shut down this time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWidget_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel= true;
            this.WindowState= FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.notifyIcon.ShowBalloonTip(2000);
        }

        /// <summary>
        /// data save function after main window closed, before thread shut down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWidget_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        #endregion MainWidget_Action

        #region MainWidget_Component_Action

        /// <summary>
        /// open folder button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OpenGameFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "请选择游戏目录";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "Sofruner-ng 错误");
                    return;
                }
                this.textBox_GameFolderPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        /// <summary>
        /// run game exe button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_RunGameEXE_Click(object sender, EventArgs e)
        {
            string EXE_Path = this.textBox_GameFolderPath.Text + "\\" + this.textBox_GameEXEName.Text;
            if (!System.IO.File.Exists(EXE_Path)) // EXE file not exist
            {
                MessageBox.Show(this, "可执行文件\"" + EXE_Path + "\"不存在或无法访问\n请检查启动目录与文件", "Sofruner-ng 错误");
                return;
            }
            System.Diagnostics.Process.Start(EXE_Path);
        }

        #endregion MainWidget_Component_Action

        #region notifyIcon_Action

        /// <summary>
        /// restore main window when notify icon being double clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.WindowState = FormWindowState.Normal; // restore main window
                    this.ShowInTaskbar= true;                  // show icon in task bar
                }
                this.Activate();
            }
        }

        /// <summary>
        /// restore main window when balloontip is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState= FormWindowState.Normal; // restore main window
                this.ShowInTaskbar= true;                 // show icon in task bar
            }
            this.Activate();
        }

        /// <summary>
        /// restore main window when this button being pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 显示主面板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal; // restore main window
                this.ShowInTaskbar = true;                 // show icon in task bar
            }
            this.Activate();
        }

        /// <summary>
        /// close main window and call showdown thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            // only use close function will trigger MainWidget_FormClosing
            // therefore: need to dispose first, then try to close main window
            this.Close();
        }

        #endregion notifyIcon_Action

        #region MainWidget_ToolStrip_Action

        /// <summary>
        /// close main window and call showdown thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            // only use close function will trigger MainWidget_FormClosing
            // therefore: need to dispose first, then try to close main window
            this.Close();
        }

        #endregion MainWidget_ToolStrip_Action
    }
}
