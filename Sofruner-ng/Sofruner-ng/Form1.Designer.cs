namespace Sofruner_ng
{
    partial class MainWidget
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWidget));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存该配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加载保存的配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_GameFolderPath = new System.Windows.Forms.Label();
            this.textBox_GameFolderPath = new System.Windows.Forms.TextBox();
            this.label_GameEXEName = new System.Windows.Forms.Label();
            this.textBox_GameEXEName = new System.Windows.Forms.TextBox();
            this.checkBox_RestoreOption = new System.Windows.Forms.CheckBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示主面板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_OpenGameFolder = new System.Windows.Forms.Button();
            this.button_RunGameEXE = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.notifyIcon_ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选项ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(578, 32);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 选项ToolStripMenuItem
            // 
            this.选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存该配置ToolStripMenuItem,
            this.加载保存的配置ToolStripMenuItem});
            this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            this.选项ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.选项ToolStripMenuItem.Text = "选项";
            // 
            // 保存该配置ToolStripMenuItem
            // 
            this.保存该配置ToolStripMenuItem.Name = "保存该配置ToolStripMenuItem";
            this.保存该配置ToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.保存该配置ToolStripMenuItem.Text = "保存该配置";
            // 
            // 加载保存的配置ToolStripMenuItem
            // 
            this.加载保存的配置ToolStripMenuItem.Name = "加载保存的配置ToolStripMenuItem";
            this.加载保存的配置ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.加载保存的配置ToolStripMenuItem.Text = "管理保存的配置";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // label_GameFolderPath
            // 
            this.label_GameFolderPath.AutoSize = true;
            this.label_GameFolderPath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_GameFolderPath.Location = new System.Drawing.Point(20, 55);
            this.label_GameFolderPath.Name = "label_GameFolderPath";
            this.label_GameFolderPath.Size = new System.Drawing.Size(106, 24);
            this.label_GameFolderPath.TabIndex = 1;
            this.label_GameFolderPath.Text = "游戏目录";
            // 
            // textBox_GameFolderPath
            // 
            this.textBox_GameFolderPath.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_GameFolderPath.Location = new System.Drawing.Point(132, 52);
            this.textBox_GameFolderPath.Name = "textBox_GameFolderPath";
            this.textBox_GameFolderPath.ReadOnly = true;
            this.textBox_GameFolderPath.Size = new System.Drawing.Size(418, 30);
            this.textBox_GameFolderPath.TabIndex = 2;
            // 
            // label_GameEXEName
            // 
            this.label_GameEXEName.AutoSize = true;
            this.label_GameEXEName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_GameEXEName.Location = new System.Drawing.Point(20, 110);
            this.label_GameEXEName.Name = "label_GameEXEName";
            this.label_GameEXEName.Size = new System.Drawing.Size(106, 24);
            this.label_GameEXEName.TabIndex = 3;
            this.label_GameEXEName.Text = "游戏目录";
            // 
            // textBox_GameEXEName
            // 
            this.textBox_GameEXEName.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_GameEXEName.Location = new System.Drawing.Point(132, 107);
            this.textBox_GameEXEName.Name = "textBox_GameEXEName";
            this.textBox_GameEXEName.Size = new System.Drawing.Size(418, 30);
            this.textBox_GameEXEName.TabIndex = 4;
            // 
            // checkBox_RestoreOption
            // 
            this.checkBox_RestoreOption.AutoSize = true;
            this.checkBox_RestoreOption.Checked = true;
            this.checkBox_RestoreOption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_RestoreOption.Location = new System.Drawing.Point(40, 160);
            this.checkBox_RestoreOption.Name = "checkBox_RestoreOption";
            this.checkBox_RestoreOption.Size = new System.Drawing.Size(178, 22);
            this.checkBox_RestoreOption.TabIndex = 5;
            this.checkBox_RestoreOption.Text = "在下次启动时恢复";
            this.checkBox_RestoreOption.UseVisualStyleBackColor = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Sofruner-ng已最小化至托盘\r\n双击托盘图标打开主面板";
            this.notifyIcon.BalloonTipTitle = "最小化至托盘";
            this.notifyIcon.ContextMenuStrip = this.notifyIcon_ContextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Sofruner-ng";
            this.notifyIcon.Visible = true;
            this.notifyIcon.BalloonTipClicked += new System.EventHandler(this.notifyIcon_BalloonTipClicked);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // notifyIcon_ContextMenuStrip
            // 
            this.notifyIcon_ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.notifyIcon_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示主面板ToolStripMenuItem,
            this.退出程序ToolStripMenuItem});
            this.notifyIcon_ContextMenuStrip.Name = "notifyIcon_ContextMenuStrip";
            this.notifyIcon_ContextMenuStrip.Size = new System.Drawing.Size(171, 64);
            // 
            // 显示主面板ToolStripMenuItem
            // 
            this.显示主面板ToolStripMenuItem.Name = "显示主面板ToolStripMenuItem";
            this.显示主面板ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.显示主面板ToolStripMenuItem.Text = "显示主面板";
            this.显示主面板ToolStripMenuItem.Click += new System.EventHandler(this.显示主面板ToolStripMenuItem_Click);
            // 
            // 退出程序ToolStripMenuItem
            // 
            this.退出程序ToolStripMenuItem.Name = "退出程序ToolStripMenuItem";
            this.退出程序ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.退出程序ToolStripMenuItem.Text = "退出程序";
            this.退出程序ToolStripMenuItem.Click += new System.EventHandler(this.退出程序ToolStripMenuItem_Click);
            // 
            // button_OpenGameFolder
            // 
            this.button_OpenGameFolder.Location = new System.Drawing.Point(360, 155);
            this.button_OpenGameFolder.Name = "button_OpenGameFolder";
            this.button_OpenGameFolder.Size = new System.Drawing.Size(90, 30);
            this.button_OpenGameFolder.TabIndex = 6;
            this.button_OpenGameFolder.Text = "选择路径";
            this.button_OpenGameFolder.UseVisualStyleBackColor = true;
            this.button_OpenGameFolder.Click += new System.EventHandler(this.button_OpenGameFolder_Click);
            // 
            // button_RunGameEXE
            // 
            this.button_RunGameEXE.Location = new System.Drawing.Point(460, 155);
            this.button_RunGameEXE.Name = "button_RunGameEXE";
            this.button_RunGameEXE.Size = new System.Drawing.Size(90, 30);
            this.button_RunGameEXE.TabIndex = 7;
            this.button_RunGameEXE.Text = "启动游戏";
            this.button_RunGameEXE.UseVisualStyleBackColor = true;
            this.button_RunGameEXE.Click += new System.EventHandler(this.button_RunGameEXE_Click);
            // 
            // MainWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 204);
            this.Controls.Add(this.button_RunGameEXE);
            this.Controls.Add(this.button_OpenGameFolder);
            this.Controls.Add(this.checkBox_RestoreOption);
            this.Controls.Add(this.textBox_GameEXEName);
            this.Controls.Add(this.label_GameEXEName);
            this.Controls.Add(this.textBox_GameFolderPath);
            this.Controls.Add(this.label_GameFolderPath);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainWidget";
            this.Text = "Sofruner-ng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWidget_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWidget_FormClosed);
            this.Load += new System.EventHandler(this.MainWidget_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.notifyIcon_ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存该配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加载保存的配置ToolStripMenuItem;
        private System.Windows.Forms.Label label_GameFolderPath;
        private System.Windows.Forms.TextBox textBox_GameFolderPath;
        private System.Windows.Forms.Label label_GameEXEName;
        private System.Windows.Forms.TextBox textBox_GameEXEName;
        private System.Windows.Forms.CheckBox checkBox_RestoreOption;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyIcon_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 显示主面板ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Button button_OpenGameFolder;
        private System.Windows.Forms.Button button_RunGameEXE;
    }
}

