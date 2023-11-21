namespace SuperMarket
{
    partial class Splashcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splashcs));
            this.label1 = new System.Windows.Forms.Label();
            this.Myprogress = new Bunifu.UI.Winforms.BunifuProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 21.75F);
            this.label1.Location = new System.Drawing.Point(183, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "SuperMarket Management System";
            // 
            // Myprogress
            // 
            this.Myprogress.Animation = 0;
            this.Myprogress.AnimationStep = 10;
            this.Myprogress.BackColor = System.Drawing.Color.DarkOrange;
            this.Myprogress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Myprogress.BackgroundImage")));
            this.Myprogress.BorderColor = System.Drawing.Color.DarkOrange;
            this.Myprogress.BorderRadius = 5;
            this.Myprogress.BorderThickness = 2;
            this.Myprogress.Location = new System.Drawing.Point(-1, 420);
            this.Myprogress.MaximumValue = 100;
            this.Myprogress.MinimumValue = 0;
            this.Myprogress.Name = "Myprogress";
            this.Myprogress.ProgressBackColor = System.Drawing.Color.DarkOrange;
            this.Myprogress.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Myprogress.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Myprogress.Size = new System.Drawing.Size(813, 31);
            this.Myprogress.TabIndex = 5;
            this.Myprogress.Value = 0;
            // 
            // Splashcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.Myprogress);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splashcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splashcs";
            this.Load += new System.EventHandler(this.Splashcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.UI.Winforms.BunifuProgressBar Myprogress;
        private System.Windows.Forms.Timer timer1;
    }
}