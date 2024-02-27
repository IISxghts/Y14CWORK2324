namespace _9320RyanMillerDatabase
{
    partial class ViewBookingsForm
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
            this.BookingViewDGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookingViewDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // BookingViewDGV
            // 
            this.BookingViewDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookingViewDGV.Location = new System.Drawing.Point(12, 78);
            this.BookingViewDGV.Name = "BookingViewDGV";
            this.BookingViewDGV.RowHeadersWidth = 51;
            this.BookingViewDGV.RowTemplate.Height = 24;
            this.BookingViewDGV.Size = new System.Drawing.Size(776, 360);
            this.BookingViewDGV.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ViewBookingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BookingViewDGV);
            this.Name = "ViewBookingsForm";
            this.Text = "ViewBookingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.BookingViewDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BookingViewDGV;
        private System.Windows.Forms.Button button1;
    }
}