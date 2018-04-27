namespace Trpg_Tool
{
    partial class MainForm
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
            System.Windows.Forms.Button BattleButton;
            this.MemberListButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            BattleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BattleButton
            // 
            BattleButton.Location = new System.Drawing.Point(42, 70);
            BattleButton.Name = "BattleButton";
            BattleButton.Size = new System.Drawing.Size(75, 23);
            BattleButton.TabIndex = 1;
            BattleButton.Text = "战斗";
            BattleButton.UseVisualStyleBackColor = true;
            BattleButton.Click += new System.EventHandler(this.BattleButton_Click);
            // 
            // MemberListButton
            // 
            this.MemberListButton.Location = new System.Drawing.Point(42, 27);
            this.MemberListButton.Name = "MemberListButton";
            this.MemberListButton.Size = new System.Drawing.Size(75, 23);
            this.MemberListButton.TabIndex = 0;
            this.MemberListButton.Text = "成员列表";
            this.MemberListButton.UseVisualStyleBackColor = true;
            this.MemberListButton.Click += new System.EventHandler(this.MemberListButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(42, 111);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SettingsButton.TabIndex = 2;
            this.SettingsButton.Text = "设置";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 188);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(BattleButton);
            this.Controls.Add(this.MemberListButton);
            this.Name = "MainForm";
            this.Text = "工具";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MemberListButton;
        private System.Windows.Forms.Button SettingsButton;
    }
}

