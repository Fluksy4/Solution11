
namespace WindowsFormsApp1
{
    partial class Display
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
            this.price = new System.Windows.Forms.TextBox();
            this.dayOrNight = new System.Windows.Forms.TextBox();
            this.n = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(67, 233);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 22);
            this.price.TabIndex = 6;
            // 
            // dayOrNight
            // 
            this.dayOrNight.Location = new System.Drawing.Point(67, 54);
            this.dayOrNight.Name = "dayOrNight";
            this.dayOrNight.Size = new System.Drawing.Size(100, 22);
            this.dayOrNight.TabIndex = 5;
            this.dayOrNight.Text = "day";
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(67, 21);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(100, 22);
            this.n.TabIndex = 4;
            this.n.Text = "5";
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 363);
            this.Controls.Add(this.price);
            this.Controls.Add(this.dayOrNight);
            this.Controls.Add(this.n);
            this.Name = "Display";
            this.Text = "Display";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox dayOrNight;
        public System.Windows.Forms.TextBox n;
        public System.Windows.Forms.TextBox price;
    }
}