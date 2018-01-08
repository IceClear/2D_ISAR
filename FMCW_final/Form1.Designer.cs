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
            this.X_box = new CCWin.SkinControl.SkinWaterTextBox();
            this.n_box = new CCWin.SkinControl.SkinWaterTextBox();
            this.dim_box = new CCWin.SkinControl.SkinWaterTextBox();
            this.wav = new CCWin.SkinControl.SkinButton();
            this.label1 = new System.Windows.Forms.Label();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // a_box
            // 
            this.a_box.Location = new System.Drawing.Point(42, 76);
            this.a_box.Name = "a_box";
            this.a_box.Size = new System.Drawing.Size(100, 21);
            this.a_box.TabIndex = 0;
            this.a_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.a_box.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.a_box.WaterText = "文件路径";
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
            this.lab.Location = new System.Drawing.Point(500, 397);
            this.lab.MouseBack = null;
            this.lab.Name = "lab";
            this.lab.NormlBack = null;
            this.lab.Size = new System.Drawing.Size(97, 35);
            this.lab.TabIndex = 1;
            this.lab.Text = "Start";
            this.lab.UseVisualStyleBackColor = false;
            this.lab.Click += new System.EventHandler(this.lab_Click);
            // 
            // X_box
            // 
            this.X_box.Location = new System.Drawing.Point(42, 138);
            this.X_box.Name = "X_box";
            this.X_box.Size = new System.Drawing.Size(100, 21);
            this.X_box.TabIndex = 2;
            this.X_box.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.X_box.WaterText = "数据长度（X）";
            this.X_box.TextChanged += new System.EventHandler(this.X_box_TextChanged);
            this.X_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X_box_KeyPress);
            // 
            // n_box
            // 
            this.n_box.Location = new System.Drawing.Point(42, 198);
            this.n_box.Name = "n_box";
            this.n_box.Size = new System.Drawing.Size(100, 21);
            this.n_box.TabIndex = 3;
            this.n_box.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.n_box.WaterText = "变化点数（n）";
            this.n_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.n_box_KeyPress);
            // 
            // dim_box
            // 
            this.dim_box.Location = new System.Drawing.Point(42, 265);
            this.dim_box.Name = "dim_box";
            this.dim_box.Size = new System.Drawing.Size(100, 21);
            this.dim_box.TabIndex = 4;
            this.dim_box.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.dim_box.WaterText = "维度（dim）";
            this.dim_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dim_box_KeyPress);
            // 
            // wav
            // 
            this.wav.BackColor = System.Drawing.Color.Transparent;
            this.wav.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.wav.DownBack = null;
            this.wav.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.wav.Location = new System.Drawing.Point(42, 357);
            this.wav.MouseBack = null;
            this.wav.Name = "wav";
            this.wav.NormlBack = null;
            this.wav.Size = new System.Drawing.Size(100, 25);
            this.wav.TabIndex = 9;
            this.wav.Text = "Stop";
            this.wav.UseVisualStyleBackColor = false;
            this.wav.Click += new System.EventHandler(this.wav_Click);
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
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.skinButton1.Location = new System.Drawing.Point(42, 306);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(100, 25);
            this.skinButton1.TabIndex = 18;
            this.skinButton1.Text = "Start";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(273, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(568, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
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
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wav);
            this.Controls.Add(this.dim_box);
            this.Controls.Add(this.n_box);
            this.Controls.Add(this.X_box);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.a_box);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.InnerBorderColor = System.Drawing.Color.Maroon;
            this.Name = "MainF";
            this.Text = "ISAR-2D";
            this.Activated += new System.EventHandler(this.MainF_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinWaterTextBox a_box;
        private CCWin.SkinControl.SkinButton lab;
        private CCWin.SkinControl.SkinWaterTextBox X_box;
        private CCWin.SkinControl.SkinWaterTextBox n_box;
        private CCWin.SkinControl.SkinWaterTextBox dim_box;
        private CCWin.SkinControl.SkinButton wav;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinButton skinButton1;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

