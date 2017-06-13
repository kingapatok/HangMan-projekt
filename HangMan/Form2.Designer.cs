namespace HangMan
{
    partial class Form2
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
            this.frmHangman = new System.Windows.Forms.PictureBox();
            this.cmdA = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.frmHangman)).BeginInit();
            this.SuspendLayout();
            // 
            // frmHangman
            // 
            this.frmHangman.Image = global::HangMan.Properties.Resources.HangMan1;
            this.frmHangman.Location = new System.Drawing.Point(12, 12);
            this.frmHangman.Name = "frmHangman";
            this.frmHangman.Size = new System.Drawing.Size(231, 244);
            this.frmHangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frmHangman.TabIndex = 0;
            this.frmHangman.TabStop = false;
            // 
            // cmdA
            // 
            this.cmdA.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdA.Location = new System.Drawing.Point(249, 44);
            this.cmdA.Name = "cmdA";
            this.cmdA.Size = new System.Drawing.Size(36, 32);
            this.cmdA.TabIndex = 1;
            this.cmdA.Text = "A";
            this.cmdA.UseVisualStyleBackColor = true;
            this.cmdA.Click += new System.EventHandler(this.guessClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(291, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ą";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.guessClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdA);
            this.Controls.Add(this.frmHangman);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.frmHangman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox frmHangman;
        private System.Windows.Forms.Button cmdA;
        private System.Windows.Forms.Button button1;
    }
}