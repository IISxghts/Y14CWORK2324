namespace _9320RyanMillerDatabase
{
    partial class ProgressBarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressBarForm));
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ProgBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2TaskBarProgress1 = new Guna.UI2.WinForms.Guna2TaskBarProgress(this.components);
            this.ProgBarLbl = new System.Windows.Forms.Label();
            this.ThreeSecondWait = new System.Windows.Forms.Timer(this.components);
            this.FullyLoadedSmile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullyLoadedSmile)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, -2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(800, 427);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // ProgBar
            // 
            this.ProgBar.AutoRoundedCorners = true;
            this.ProgBar.BorderRadius = 14;
            this.ProgBar.BorderThickness = 1;
            this.ProgBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgBar.Location = new System.Drawing.Point(0, 420);
            this.ProgBar.Name = "ProgBar";
            this.ProgBar.ProgressColor = System.Drawing.Color.Navy;
            this.ProgBar.ProgressColor2 = System.Drawing.Color.Cyan;
            this.ProgBar.Size = new System.Drawing.Size(800, 30);
            this.ProgBar.TabIndex = 3;
            this.ProgBar.Text = "TEST";
            this.ProgBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2TaskBarProgress1
            // 
            this.guna2TaskBarProgress1.TargetForm = null;
            // 
            // ProgBarLbl
            // 
            this.ProgBarLbl.AutoSize = true;
            this.ProgBarLbl.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgBarLbl.ForeColor = System.Drawing.Color.White;
            this.ProgBarLbl.Location = new System.Drawing.Point(301, 361);
            this.ProgBarLbl.Name = "ProgBarLbl";
            this.ProgBarLbl.Size = new System.Drawing.Size(216, 34);
            this.ProgBarLbl.TabIndex = 4;
            this.ProgBarLbl.Text = "LOADING - X%";
            // 
            // ThreeSecondWait
            // 
            this.ThreeSecondWait.Tick += new System.EventHandler(this.ThreeSecondWait_Tick);
            // 
            // FullyLoadedSmile
            // 
            this.FullyLoadedSmile.Image = ((System.Drawing.Image)(resources.GetObject("FullyLoadedSmile.Image")));
            this.FullyLoadedSmile.ImageRotate = 0F;
            this.FullyLoadedSmile.Location = new System.Drawing.Point(453, 350);
            this.FullyLoadedSmile.Name = "FullyLoadedSmile";
            this.FullyLoadedSmile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.FullyLoadedSmile.Size = new System.Drawing.Size(64, 64);
            this.FullyLoadedSmile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FullyLoadedSmile.TabIndex = 5;
            this.FullyLoadedSmile.TabStop = false;
            // 
            // ProgressBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(215)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FullyLoadedSmile);
            this.Controls.Add(this.ProgBarLbl);
            this.Controls.Add(this.ProgBar);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgressBarForm";
            this.Text = "ProgressBarForm";
            this.Load += new System.EventHandler(this.ProgressBarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullyLoadedSmile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ProgressBar ProgBar;
        private Guna.UI2.WinForms.Guna2TaskBarProgress guna2TaskBarProgress1;
        private System.Windows.Forms.Label ProgBarLbl;
        private System.Windows.Forms.Timer ThreeSecondWait;
        private Guna.UI2.WinForms.Guna2CirclePictureBox FullyLoadedSmile;
    }
}