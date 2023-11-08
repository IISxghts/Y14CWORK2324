namespace _9320RyanMillerDatabase
{
    partial class DatabaseMenu
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
            this.DBMenuBtn1 = new System.Windows.Forms.Button();
            this.DBMenuBtn2 = new System.Windows.Forms.Button();
            this.MainMenuLbl = new System.Windows.Forms.Label();
            this.MMExitBtn = new System.Windows.Forms.Button();
            this.DBMenuBtn3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DBMenuBtn1
            // 
            this.DBMenuBtn1.Location = new System.Drawing.Point(75, 141);
            this.DBMenuBtn1.Name = "DBMenuBtn1";
            this.DBMenuBtn1.Size = new System.Drawing.Size(123, 54);
            this.DBMenuBtn1.TabIndex = 0;
            this.DBMenuBtn1.Text = "Add Customer";
            this.DBMenuBtn1.UseVisualStyleBackColor = true;
            this.DBMenuBtn1.Click += new System.EventHandler(this.DBMenuBtn1_Click);
            // 
            // DBMenuBtn2
            // 
            this.DBMenuBtn2.Location = new System.Drawing.Point(75, 201);
            this.DBMenuBtn2.Name = "DBMenuBtn2";
            this.DBMenuBtn2.Size = new System.Drawing.Size(123, 54);
            this.DBMenuBtn2.TabIndex = 1;
            this.DBMenuBtn2.Text = "Edit Customer";
            this.DBMenuBtn2.UseVisualStyleBackColor = true;
            this.DBMenuBtn2.Click += new System.EventHandler(this.DBMenuBtn2_Click);
            // 
            // MainMenuLbl
            // 
            this.MainMenuLbl.AutoSize = true;
            this.MainMenuLbl.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuLbl.Location = new System.Drawing.Point(34, 53);
            this.MainMenuLbl.Name = "MainMenuLbl";
            this.MainMenuLbl.Size = new System.Drawing.Size(719, 31);
            this.MainMenuLbl.TabIndex = 2;
            this.MainMenuLbl.Text = "VERY COOL ADVANCED LEVEL MAIN MENU!!!";
            // 
            // MMExitBtn
            // 
            this.MMExitBtn.Location = new System.Drawing.Point(40, 384);
            this.MMExitBtn.Name = "MMExitBtn";
            this.MMExitBtn.Size = new System.Drawing.Size(123, 54);
            this.MMExitBtn.TabIndex = 3;
            this.MMExitBtn.Text = "Close Database";
            this.MMExitBtn.UseVisualStyleBackColor = true;
            this.MMExitBtn.Click += new System.EventHandler(this.MMExitBtn_Click);
            // 
            // DBMenuBtn3
            // 
            this.DBMenuBtn3.Location = new System.Drawing.Point(75, 261);
            this.DBMenuBtn3.Name = "DBMenuBtn3";
            this.DBMenuBtn3.Size = new System.Drawing.Size(123, 54);
            this.DBMenuBtn3.TabIndex = 4;
            this.DBMenuBtn3.Text = "Delete Customer";
            this.DBMenuBtn3.UseVisualStyleBackColor = true;
            this.DBMenuBtn3.Click += new System.EventHandler(this.DBMenuBtn3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "CUSTOMER!!!";
            // 
            // DatabaseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DBMenuBtn3);
            this.Controls.Add(this.MMExitBtn);
            this.Controls.Add(this.MainMenuLbl);
            this.Controls.Add(this.DBMenuBtn2);
            this.Controls.Add(this.DBMenuBtn1);
            this.Name = "DatabaseMenu";
            this.Text = "DatabaseMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DBMenuBtn1;
        private System.Windows.Forms.Button DBMenuBtn2;
        private System.Windows.Forms.Label MainMenuLbl;
        private System.Windows.Forms.Button MMExitBtn;
        private System.Windows.Forms.Button DBMenuBtn3;
        private System.Windows.Forms.Label label1;
    }
}