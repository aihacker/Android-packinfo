namespace Android
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.req = new CCWin.SkinControl.SkinTextBox();
            this.skinTextBox3 = new CCWin.SkinControl.SkinTextBox();
            this.apkpath = new CCWin.SkinControl.SkinTextBox();
            this.SuspendLayout();
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(590, 12);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(59, 23);
            this.skinButton1.TabIndex = 5;
            this.skinButton1.Text = "导入";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // req
            // 
            this.req.BackColor = System.Drawing.Color.Transparent;
            this.req.DownBack = null;
            this.req.Icon = null;
            this.req.IconIsButton = false;
            this.req.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.req.IsPasswordChat = '\0';
            this.req.IsSystemPasswordChar = false;
            this.req.Lines = new string[0];
            this.req.Location = new System.Drawing.Point(9, 55);
            this.req.Margin = new System.Windows.Forms.Padding(0);
            this.req.MaxLength = 32767;
            this.req.MinimumSize = new System.Drawing.Size(28, 28);
            this.req.MouseBack = null;
            this.req.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.req.Multiline = true;
            this.req.Name = "req";
            this.req.NormlBack = null;
            this.req.Padding = new System.Windows.Forms.Padding(5);
            this.req.ReadOnly = false;
            this.req.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.req.Size = new System.Drawing.Size(580, 292);
            // 
            // 
            // 
            this.req.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.req.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.req.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.req.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.req.SkinTxt.Multiline = true;
            this.req.SkinTxt.Name = "BaseText";
            this.req.SkinTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.req.SkinTxt.Size = new System.Drawing.Size(570, 282);
            this.req.SkinTxt.TabIndex = 0;
            this.req.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.req.SkinTxt.WaterText = "";
            this.req.TabIndex = 2;
            this.req.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.req.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.req.WaterText = "";
            this.req.WordWrap = true;
            // 
            // skinTextBox3
            // 
            this.skinTextBox3.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox3.DownBack = null;
            this.skinTextBox3.Icon = null;
            this.skinTextBox3.IconIsButton = false;
            this.skinTextBox3.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox3.IsPasswordChat = '\0';
            this.skinTextBox3.IsSystemPasswordChar = false;
            this.skinTextBox3.Lines = new string[] {
        "Android-packinfo-1.1 [为了精准，下个版本会识别文件进制特征来判断]     遇到Bug请反馈"};
            this.skinTextBox3.Location = new System.Drawing.Point(9, 361);
            this.skinTextBox3.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox3.MaxLength = 32767;
            this.skinTextBox3.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox3.MouseBack = null;
            this.skinTextBox3.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox3.Multiline = false;
            this.skinTextBox3.Name = "skinTextBox3";
            this.skinTextBox3.NormlBack = null;
            this.skinTextBox3.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox3.ReadOnly = false;
            this.skinTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox3.Size = new System.Drawing.Size(640, 28);
            // 
            // 
            // 
            this.skinTextBox3.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox3.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox3.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox3.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox3.SkinTxt.Name = "BaseText";
            this.skinTextBox3.SkinTxt.Size = new System.Drawing.Size(630, 18);
            this.skinTextBox3.SkinTxt.TabIndex = 0;
            this.skinTextBox3.SkinTxt.Text = "Android-packinfo-1.1 [为了精准，下个版本会识别文件进制特征来判断]     遇到Bug请反馈";
            this.skinTextBox3.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox3.SkinTxt.WaterText = "";
            this.skinTextBox3.TabIndex = 3;
            this.skinTextBox3.Text = "Android-packinfo-1.1 [为了精准，下个版本会识别文件进制特征来判断]     遇到Bug请反馈";
            this.skinTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox3.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox3.WaterText = "";
            this.skinTextBox3.WordWrap = true;
            // 
            // apkpath
            // 
            this.apkpath.BackColor = System.Drawing.Color.Transparent;
            this.apkpath.DownBack = null;
            this.apkpath.Icon = null;
            this.apkpath.IconIsButton = false;
            this.apkpath.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.apkpath.IsPasswordChat = '\0';
            this.apkpath.IsSystemPasswordChar = false;
            this.apkpath.Lines = new string[] {
        "拖入或点击按钮选择APK路径"};
            this.apkpath.Location = new System.Drawing.Point(9, 9);
            this.apkpath.Margin = new System.Windows.Forms.Padding(0);
            this.apkpath.MaxLength = 32767;
            this.apkpath.MinimumSize = new System.Drawing.Size(28, 28);
            this.apkpath.MouseBack = null;
            this.apkpath.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.apkpath.Multiline = false;
            this.apkpath.Name = "apkpath";
            this.apkpath.NormlBack = null;
            this.apkpath.Padding = new System.Windows.Forms.Padding(5);
            this.apkpath.ReadOnly = false;
            this.apkpath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.apkpath.Size = new System.Drawing.Size(579, 28);
            // 
            // 
            // 
            this.apkpath.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.apkpath.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apkpath.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.apkpath.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.apkpath.SkinTxt.Name = "BaseText";
            this.apkpath.SkinTxt.Size = new System.Drawing.Size(569, 18);
            this.apkpath.SkinTxt.TabIndex = 0;
            this.apkpath.SkinTxt.Text = "拖入或点击按钮选择APK路径";
            this.apkpath.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.apkpath.SkinTxt.WaterText = "";
            this.apkpath.TabIndex = 6;
            this.apkpath.Text = "拖入或点击按钮选择APK路径";
            this.apkpath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.apkpath.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.apkpath.WaterText = "";
            this.apkpath.WordWrap = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 393);
            this.Controls.Add(this.apkpath);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.skinTextBox3);
            this.Controls.Add(this.req);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Android-packinfo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinTextBox req;
        private CCWin.SkinControl.SkinTextBox skinTextBox3;
        private CCWin.SkinControl.SkinTextBox apkpath;
    }
}

