namespace FMCW_final
{
    partial class MainF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainF));
            this.a_box = new CCWin.SkinControl.SkinWaterTextBox();
            this.lab = new CCWin.SkinControl.SkinButton();
            this.b_box = new CCWin.SkinControl.SkinWaterTextBox();
            this.c_box = new CCWin.SkinControl.SkinWaterTextBox();
            this.d_box = new CCWin.SkinControl.SkinWaterTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.e_box = new CCWin.SkinControl.SkinWaterTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // a_box
            // 
            this.a_box.Location = new System.Drawing.Point(42, 76);
            this.a_box.Name = "a_box";
            this.a_box.Size = new System.Drawing.Size(108, 21);
            this.a_box.TabIndex = 0;
            this.a_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.a_box.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.a_box.WaterText = "起始角（i1）";
            this.a_box.TextChanged += new System.EventHandler(this.a_box_TextChanged);
            this.a_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.a_box_KeyPress);
            // 
            // lab
            // 
            this.lab.BackColor = System.Drawing.Color.Transparent;
            this.lab.BaseColor = System.Drawing.Color.Brown;
            this.lab.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.lab.DownBack = null;
            this.lab.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab.ForeColor = System.Drawing.Color.Aqua;
            this.lab.Location = new System.Drawing.Point(46, 332);
            this.lab.MouseBack = null;
            this.lab.Name = "lab";
            this.lab.NormlBack = null;
            this.lab.Size = new System.Drawing.Size(97, 35);
            this.lab.TabIndex = 1;
            this.lab.Text = "Start";
            this.lab.UseVisualStyleBackColor = false;
            this.lab.Click += new System.EventHandler(this.lab_Click);
            // 
            // b_box
            // 
            this.b_box.Location = new System.Drawing.Point(42, 120);
            this.b_box.Name = "b_box";
            this.b_box.Size = new System.Drawing.Size(108, 21);
            this.b_box.TabIndex = 2;
            this.b_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.b_box.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.b_box.WaterText = "起始角（i2）";
            this.b_box.TextChanged += new System.EventHandler(this.X_box_TextChanged);
            this.b_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X_box_KeyPress);
            // 
            // c_box
            // 
            this.c_box.Location = new System.Drawing.Point(42, 164);
            this.c_box.Name = "c_box";
            this.c_box.Size = new System.Drawing.Size(108, 21);
            this.c_box.TabIndex = 3;
            this.c_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c_box.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.c_box.WaterText = "成像累计角（r1）";
            this.c_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.n_box_KeyPress);
            // 
            // d_box
            // 
            this.d_box.Location = new System.Drawing.Point(42, 208);
            this.d_box.Name = "d_box";
            this.d_box.Size = new System.Drawing.Size(108, 21);
            this.d_box.TabIndex = 4;
            this.d_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.d_box.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.d_box.WaterText = "成像累计角（r2）";
            this.d_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dim_box_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(199, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(3, 400);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(273, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(568, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // e_box
            // 
            this.e_box.Location = new System.Drawing.Point(42, 254);
            this.e_box.Name = "e_box";
            this.e_box.Size = new System.Drawing.Size(108, 21);
            this.e_box.TabIndex = 20;
            this.e_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.e_box.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.e_box.WaterText = "阈值（thr）";
            // 
            // MainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CaptionBackColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.e_box);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.d_box);
            this.Controls.Add(this.c_box);
            this.Controls.Add(this.b_box);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.a_box);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.InnerBorderColor = System.Drawing.Color.Maroon;
            this.Name = "MainF";
            this.Text = "ISAR-2D";
            this.TitleCenter = false;
            this.Activated += new System.EventHandler(this.MainF_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinWaterTextBox a_box;
        private CCWin.SkinControl.SkinButton lab;
        private CCWin.SkinControl.SkinWaterTextBox b_box;
        private CCWin.SkinControl.SkinWaterTextBox c_box;
        private CCWin.SkinControl.SkinWaterTextBox d_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CCWin.SkinControl.SkinWaterTextBox e_box;

    }
}

