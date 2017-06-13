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
            this.hangImage = new System.Windows.Forms.PictureBox();
            this.cmdA = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hangImage)).BeginInit();
            this.SuspendLayout();
            // 
            // hangImage
            // 
            this.hangImage.Image = global::HangMan.Properties.Resources.HangMan1;
            this.hangImage.Location = new System.Drawing.Point(95, 2);
            this.hangImage.Name = "hangImage";
            this.hangImage.Size = new System.Drawing.Size(231, 244);
            this.hangImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hangImage.TabIndex = 0;
            this.hangImage.TabStop = false;
            this.hangImage.Click += new System.EventHandler(this.hangImage_Click);
            // 
            // cmdA
            // 
            this.cmdA.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdA.Location = new System.Drawing.Point(53, 273);
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
            this.button1.Location = new System.Drawing.Point(95, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ą";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.guessClick);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(369, 18);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 358);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdA);
            this.Controls.Add(this.hangImage);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.hangImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hangImage;
        private System.Windows.Forms.Button cmdA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResult;
    }
}