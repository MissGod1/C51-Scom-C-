using System;

namespace C51_control
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.switchBtn = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Stopcbox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.JYcbox = new System.Windows.Forms.ComboBox();
            this.Datacbox = new System.Windows.Forms.ComboBox();
            this.BTcbox = new System.Windows.Forms.ComboBox();
            this.Scomcbox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.Light8 = new System.Windows.Forms.PictureBox();
            this.Light7 = new System.Windows.Forms.PictureBox();
            this.Light6 = new System.Windows.Forms.PictureBox();
            this.Light5 = new System.Windows.Forms.PictureBox();
            this.Light4 = new System.Windows.Forms.PictureBox();
            this.Light3 = new System.Windows.Forms.PictureBox();
            this.Light2 = new System.Windows.Forms.PictureBox();
            this.Light1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.NumView = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Jstat = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchBtn)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Light8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(490, 324);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.switchBtn);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.Stopcbox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.JYcbox);
            this.tabPage1.Controls.Add(this.Datacbox);
            this.tabPage1.Controls.Add(this.BTcbox);
            this.tabPage1.Controls.Add(this.Scomcbox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(482, 292);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "串口控制";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // switchBtn
            // 
            this.switchBtn.Image = global::C51_control.Properties.Resources._1131028;
            this.switchBtn.Location = new System.Drawing.Point(366, 127);
            this.switchBtn.Name = "switchBtn";
            this.switchBtn.Size = new System.Drawing.Size(64, 64);
            this.switchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.switchBtn.TabIndex = 22;
            this.switchBtn.TabStop = false;
            this.switchBtn.Click += new System.EventHandler(this.SwitchBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(100, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "欢迎使用本辣鸡程序";
            // 
            // Stopcbox
            // 
            this.Stopcbox.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Stopcbox.ForeColor = System.Drawing.Color.Red;
            this.Stopcbox.FormattingEnabled = true;
            this.Stopcbox.Location = new System.Drawing.Point(190, 227);
            this.Stopcbox.Name = "Stopcbox";
            this.Stopcbox.Size = new System.Drawing.Size(121, 27);
            this.Stopcbox.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(80, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "停止位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(59, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "奇偶校验";
            // 
            // JYcbox
            // 
            this.JYcbox.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.JYcbox.ForeColor = System.Drawing.Color.Red;
            this.JYcbox.FormattingEnabled = true;
            this.JYcbox.Location = new System.Drawing.Point(190, 194);
            this.JYcbox.Name = "JYcbox";
            this.JYcbox.Size = new System.Drawing.Size(121, 27);
            this.JYcbox.TabIndex = 17;
            // 
            // Datacbox
            // 
            this.Datacbox.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Datacbox.ForeColor = System.Drawing.Color.Red;
            this.Datacbox.FormattingEnabled = true;
            this.Datacbox.Location = new System.Drawing.Point(190, 161);
            this.Datacbox.Name = "Datacbox";
            this.Datacbox.Size = new System.Drawing.Size(121, 27);
            this.Datacbox.TabIndex = 16;
            // 
            // BTcbox
            // 
            this.BTcbox.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTcbox.ForeColor = System.Drawing.Color.Red;
            this.BTcbox.FormattingEnabled = true;
            this.BTcbox.Location = new System.Drawing.Point(190, 127);
            this.BTcbox.Name = "BTcbox";
            this.BTcbox.Size = new System.Drawing.Size(121, 27);
            this.BTcbox.TabIndex = 15;
            // 
            // Scomcbox
            // 
            this.Scomcbox.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Scomcbox.ForeColor = System.Drawing.Color.Red;
            this.Scomcbox.FormattingEnabled = true;
            this.Scomcbox.Location = new System.Drawing.Point(190, 93);
            this.Scomcbox.Name = "Scomcbox";
            this.Scomcbox.Size = new System.Drawing.Size(121, 27);
            this.Scomcbox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(80, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "数据位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(80, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(101, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "串口";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.Light8);
            this.tabPage2.Controls.Add(this.Light7);
            this.tabPage2.Controls.Add(this.Light6);
            this.tabPage2.Controls.Add(this.Light5);
            this.tabPage2.Controls.Add(this.Light4);
            this.tabPage2.Controls.Add(this.Light3);
            this.tabPage2.Controls.Add(this.Light2);
            this.tabPage2.Controls.Add(this.Light1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(482, 292);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LED灯";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("楷体", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(121, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 35);
            this.label7.TabIndex = 8;
            this.label7.Text = "灯泡是绿的？";
            // 
            // Light8
            // 
            this.Light8.Image = ((System.Drawing.Image)(resources.GetObject("Light8.Image")));
            this.Light8.Location = new System.Drawing.Point(434, 115);
            this.Light8.Name = "Light8";
            this.Light8.Size = new System.Drawing.Size(48, 48);
            this.Light8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Light8.TabIndex = 7;
            this.Light8.TabStop = false;
            this.Light8.Tag = "8";
            this.Light8.Click += new System.EventHandler(this.Light_Click);
            // 
            // Light7
            // 
            this.Light7.Image = ((System.Drawing.Image)(resources.GetObject("Light7.Image")));
            this.Light7.Location = new System.Drawing.Point(372, 115);
            this.Light7.Name = "Light7";
            this.Light7.Size = new System.Drawing.Size(48, 48);
            this.Light7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Light7.TabIndex = 6;
            this.Light7.TabStop = false;
            this.Light7.Tag = "7";
            this.Light7.Click += new System.EventHandler(this.Light_Click);
            // 
            // Light6
            // 
            this.Light6.Image = ((System.Drawing.Image)(resources.GetObject("Light6.Image")));
            this.Light6.Location = new System.Drawing.Point(310, 115);
            this.Light6.Name = "Light6";
            this.Light6.Size = new System.Drawing.Size(48, 48);
            this.Light6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Light6.TabIndex = 5;
            this.Light6.TabStop = false;
            this.Light6.Tag = "6";
            this.Light6.Click += new System.EventHandler(this.Light_Click);
            // 
            // Light5
            // 
            this.Light5.Image = ((System.Drawing.Image)(resources.GetObject("Light5.Image")));
            this.Light5.Location = new System.Drawing.Point(248, 115);
            this.Light5.Name = "Light5";
            this.Light5.Size = new System.Drawing.Size(48, 48);
            this.Light5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Light5.TabIndex = 4;
            this.Light5.TabStop = false;
            this.Light5.Tag = "5";
            this.Light5.Click += new System.EventHandler(this.Light_Click);
            // 
            // Light4
            // 
            this.Light4.Image = ((System.Drawing.Image)(resources.GetObject("Light4.Image")));
            this.Light4.Location = new System.Drawing.Point(186, 115);
            this.Light4.Name = "Light4";
            this.Light4.Size = new System.Drawing.Size(48, 48);
            this.Light4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Light4.TabIndex = 3;
            this.Light4.TabStop = false;
            this.Light4.Tag = "4";
            this.Light4.Click += new System.EventHandler(this.Light_Click);
            // 
            // Light3
            // 
            this.Light3.Image = ((System.Drawing.Image)(resources.GetObject("Light3.Image")));
            this.Light3.Location = new System.Drawing.Point(124, 115);
            this.Light3.Name = "Light3";
            this.Light3.Size = new System.Drawing.Size(48, 48);
            this.Light3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Light3.TabIndex = 2;
            this.Light3.TabStop = false;
            this.Light3.Tag = "3";
            this.Light3.Click += new System.EventHandler(this.Light_Click);
            // 
            // Light2
            // 
            this.Light2.Image = ((System.Drawing.Image)(resources.GetObject("Light2.Image")));
            this.Light2.Location = new System.Drawing.Point(62, 115);
            this.Light2.Name = "Light2";
            this.Light2.Size = new System.Drawing.Size(48, 48);
            this.Light2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Light2.TabIndex = 1;
            this.Light2.TabStop = false;
            this.Light2.Tag = "2";
            this.Light2.Click += new System.EventHandler(this.Light_Click);
            // 
            // Light1
            // 
            this.Light1.Image = ((System.Drawing.Image)(resources.GetObject("Light1.Image")));
            this.Light1.Location = new System.Drawing.Point(0, 115);
            this.Light1.Name = "Light1";
            this.Light1.Size = new System.Drawing.Size(48, 48);
            this.Light1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Light1.TabIndex = 0;
            this.Light1.TabStop = false;
            this.Light1.Tag = "1";
            this.Light1.Click += new System.EventHandler(this.Light_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.maskedTextBox1);
            this.tabPage3.Controls.Add(this.NumView);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(482, 292);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "数码管";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(191, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "显示";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maskedTextBox1.Location = new System.Drawing.Point(141, 123);
            this.maskedTextBox1.Mask = "000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(194, 29);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // NumView
            // 
            this.NumView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumView.Font = new System.Drawing.Font("楷体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NumView.ForeColor = System.Drawing.Color.Red;
            this.NumView.Location = new System.Drawing.Point(87, 32);
            this.NumView.Name = "NumView";
            this.NumView.Size = new System.Drawing.Size(309, 56);
            this.NumView.TabIndex = 0;
            this.NumView.Text = "数码管显示";
            this.NumView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Jstat);
            this.tabPage4.Controls.Add(this.pictureBox2);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.ForeColor = System.Drawing.Color.Red;
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(482, 292);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "继电器";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Jstat
            // 
            this.Jstat.AutoSize = true;
            this.Jstat.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jstat.Location = new System.Drawing.Point(81, 223);
            this.Jstat.Name = "Jstat";
            this.Jstat.Size = new System.Drawing.Size(44, 30);
            this.Jstat.TabIndex = 4;
            this.Jstat.Text = "off";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::C51_control.Properties.Resources._1158246;
            this.pictureBox2.Location = new System.Drawing.Point(47, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "继电器";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "蜂鸣器";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::C51_control.Properties.Resources._1200695;
            this.pictureBox1.Location = new System.Drawing.Point(317, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 339);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "串口控制器";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchBtn)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Light8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        
        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Stopcbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox JYcbox;
        private System.Windows.Forms.ComboBox Datacbox;
        private System.Windows.Forms.ComboBox BTcbox;
        private System.Windows.Forms.ComboBox Scomcbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox Light8;
        private System.Windows.Forms.PictureBox Light7;
        private System.Windows.Forms.PictureBox Light6;
        private System.Windows.Forms.PictureBox Light5;
        private System.Windows.Forms.PictureBox Light4;
        private System.Windows.Forms.PictureBox Light3;
        private System.Windows.Forms.PictureBox Light2;
        private System.Windows.Forms.PictureBox Light1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label NumView;
        private System.Windows.Forms.PictureBox switchBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Jstat;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}