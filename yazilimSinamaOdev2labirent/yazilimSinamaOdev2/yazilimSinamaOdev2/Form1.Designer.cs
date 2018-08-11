namespace yazilimSinamaOdev2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.baslaBtn = new System.Windows.Forms.Button();
            this.duvarPct = new System.Windows.Forms.PictureBox();
            this.farePct = new System.Windows.Forms.PictureBox();
            this.peynirPct = new System.Windows.Forms.PictureBox();
            this.kaldirPct = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bilsinChk = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.duvarPct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farePct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peynirPct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaldirPct)).BeginInit();
            this.SuspendLayout();
            // 
            // baslaBtn
            // 
            this.baslaBtn.Location = new System.Drawing.Point(610, 500);
            this.baslaBtn.Name = "baslaBtn";
            this.baslaBtn.Size = new System.Drawing.Size(60, 40);
            this.baslaBtn.TabIndex = 5;
            this.baslaBtn.Text = "BAŞLA";
            this.baslaBtn.UseVisualStyleBackColor = true;
            this.baslaBtn.Click += new System.EventHandler(this.baslaBtn_Click);
            // 
            // duvarPct
            // 
            this.duvarPct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("duvarPct.BackgroundImage")));
            this.duvarPct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.duvarPct.Location = new System.Drawing.Point(40, 500);
            this.duvarPct.Name = "duvarPct";
            this.duvarPct.Size = new System.Drawing.Size(40, 40);
            this.duvarPct.TabIndex = 9;
            this.duvarPct.TabStop = false;
            this.duvarPct.Click += new System.EventHandler(this.duvarPct_Click);
            // 
            // farePct
            // 
            this.farePct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("farePct.BackgroundImage")));
            this.farePct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.farePct.Location = new System.Drawing.Point(120, 500);
            this.farePct.Name = "farePct";
            this.farePct.Size = new System.Drawing.Size(40, 40);
            this.farePct.TabIndex = 10;
            this.farePct.TabStop = false;
            this.farePct.Click += new System.EventHandler(this.farePct_Click);
            // 
            // peynirPct
            // 
            this.peynirPct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("peynirPct.BackgroundImage")));
            this.peynirPct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.peynirPct.Location = new System.Drawing.Point(200, 500);
            this.peynirPct.Name = "peynirPct";
            this.peynirPct.Size = new System.Drawing.Size(40, 40);
            this.peynirPct.TabIndex = 11;
            this.peynirPct.TabStop = false;
            this.peynirPct.Click += new System.EventHandler(this.peynirPct_Click);
            // 
            // kaldirPct
            // 
            this.kaldirPct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kaldirPct.BackgroundImage")));
            this.kaldirPct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kaldirPct.Location = new System.Drawing.Point(280, 500);
            this.kaldirPct.Name = "kaldirPct";
            this.kaldirPct.Size = new System.Drawing.Size(40, 40);
            this.kaldirPct.TabIndex = 12;
            this.kaldirPct.TabStop = false;
            this.kaldirPct.Click += new System.EventHandler(this.kaldirPct_Click);
            // 
            // timer
            // 
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fare, peynirin kendine olan kuş uçuşu";
            // 
            // bilsinChk
            // 
            this.bilsinChk.AutoSize = true;
            this.bilsinChk.Location = new System.Drawing.Point(533, 522);
            this.bilsinChk.Name = "bilsinChk";
            this.bilsinChk.Size = new System.Drawing.Size(47, 17);
            this.bilsinChk.TabIndex = 16;
            this.bilsinChk.Text = "evet";
            this.bilsinChk.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "yatay ve düşey uzaklığını bilsin mi?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 545);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bilsinChk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kaldirPct);
            this.Controls.Add(this.peynirPct);
            this.Controls.Add(this.farePct);
            this.Controls.Add(this.duvarPct);
            this.Controls.Add(this.baslaBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.duvarPct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farePct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peynirPct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaldirPct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button baslaBtn;
        private System.Windows.Forms.PictureBox duvarPct;
        private System.Windows.Forms.PictureBox farePct;
        private System.Windows.Forms.PictureBox peynirPct;
        private System.Windows.Forms.PictureBox kaldirPct;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox bilsinChk;
        private System.Windows.Forms.Label label2;
    }
}

