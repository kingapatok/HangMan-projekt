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
            this.lblShowWord = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hangImage)).BeginInit();
            this.SuspendLayout();
            // 
            // hangImage
            // 
            this.hangImage.Image = global::HangMan.Properties.Resources.HangMan1;
            this.hangImage.Location = new System.Drawing.Point(26, -1);
            this.hangImage.Name = "hangImage";
            this.hangImage.Size = new System.Drawing.Size(416, 172);
            this.hangImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hangImage.TabIndex = 0;
            this.hangImage.TabStop = false;
            this.hangImage.Click += new System.EventHandler(this.hangImage_Click);
            // 
            // cmdA
            // 
            this.cmdA.BackColor = System.Drawing.Color.Red;
            this.cmdA.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdA.Location = new System.Drawing.Point(48, 231);
            this.cmdA.Name = "cmdA";
            this.cmdA.Size = new System.Drawing.Size(36, 32);
            this.cmdA.TabIndex = 1;
            this.cmdA.Text = "A";
            this.cmdA.UseVisualStyleBackColor = false;
            this.cmdA.Click += new System.EventHandler(this.guessClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(90, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ą";
            this.button1.UseVisualStyleBackColor = false;
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
            // lblShowWord
            // 
            this.lblShowWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblShowWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShowWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblShowWord.Location = new System.Drawing.Point(48, 174);
            this.lblShowWord.Name = "lblShowWord";
            this.lblShowWord.Size = new System.Drawing.Size(330, 46);
            this.lblShowWord.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(132, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "B";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.guessClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(258, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.guessClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(216, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 32);
            this.button4.TabIndex = 7;
            this.button4.Text = "Ć";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.guessClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(174, 231);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 32);
            this.button5.TabIndex = 6;
            this.button5.Text = "D";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.guessClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(258, 269);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 32);
            this.button6.TabIndex = 14;
            this.button6.Text = "E";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.guessClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Red;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.Location = new System.Drawing.Point(216, 269);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(36, 32);
            this.button7.TabIndex = 13;
            this.button7.Text = "Ę";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.guessClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Red;
            this.button8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.Location = new System.Drawing.Point(174, 269);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(36, 32);
            this.button8.TabIndex = 12;
            this.button8.Text = "F";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.guessClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Red;
            this.button9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.Location = new System.Drawing.Point(132, 269);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(36, 32);
            this.button9.TabIndex = 11;
            this.button9.Text = "G";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.guessClick);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Red;
            this.button10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button10.Location = new System.Drawing.Point(90, 269);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(36, 32);
            this.button10.TabIndex = 10;
            this.button10.Text = "H";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.guessClick);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Red;
            this.button11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button11.Location = new System.Drawing.Point(48, 269);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(36, 32);
            this.button11.TabIndex = 9;
            this.button11.Text = "I";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.guessClick);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Red;
            this.button12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button12.Location = new System.Drawing.Point(258, 307);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(36, 32);
            this.button12.TabIndex = 20;
            this.button12.Text = "J";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.guessClick);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Red;
            this.button13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button13.Location = new System.Drawing.Point(216, 307);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(36, 32);
            this.button13.TabIndex = 19;
            this.button13.Text = "K";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.guessClick);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Red;
            this.button14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button14.Location = new System.Drawing.Point(174, 307);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(36, 32);
            this.button14.TabIndex = 18;
            this.button14.Text = "L";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.guessClick);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Red;
            this.button15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button15.Location = new System.Drawing.Point(132, 307);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(36, 32);
            this.button15.TabIndex = 17;
            this.button15.Text = "Ł";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.guessClick);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Red;
            this.button16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button16.Location = new System.Drawing.Point(90, 307);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(36, 32);
            this.button16.TabIndex = 16;
            this.button16.Text = "M";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.guessClick);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Red;
            this.button17.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button17.Location = new System.Drawing.Point(48, 307);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(36, 32);
            this.button17.TabIndex = 15;
            this.button17.Text = "N";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.guessClick);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Red;
            this.button18.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button18.Location = new System.Drawing.Point(258, 344);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(36, 32);
            this.button18.TabIndex = 26;
            this.button18.Text = "Ń";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.guessClick);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Red;
            this.button19.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button19.Location = new System.Drawing.Point(216, 344);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(36, 32);
            this.button19.TabIndex = 25;
            this.button19.Text = "O";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.guessClick);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Red;
            this.button20.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button20.Location = new System.Drawing.Point(174, 344);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(36, 32);
            this.button20.TabIndex = 24;
            this.button20.Text = "Ó";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.guessClick);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Red;
            this.button21.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button21.Location = new System.Drawing.Point(132, 344);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(36, 32);
            this.button21.TabIndex = 23;
            this.button21.Text = "P";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.guessClick);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Red;
            this.button22.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button22.Location = new System.Drawing.Point(90, 344);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(36, 32);
            this.button22.TabIndex = 22;
            this.button22.Text = "Q";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.guessClick);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Red;
            this.button23.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button23.Location = new System.Drawing.Point(48, 344);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(36, 32);
            this.button23.TabIndex = 21;
            this.button23.Text = "R";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.guessClick);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Red;
            this.button24.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button24.Location = new System.Drawing.Point(342, 344);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(36, 32);
            this.button24.TabIndex = 34;
            this.button24.Text = "S";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.guessClick);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.Red;
            this.button25.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button25.Location = new System.Drawing.Point(300, 344);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(36, 32);
            this.button25.TabIndex = 33;
            this.button25.Text = "Ś";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.guessClick);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.Red;
            this.button26.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button26.Location = new System.Drawing.Point(342, 307);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(36, 32);
            this.button26.TabIndex = 32;
            this.button26.Text = "T";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.guessClick);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.Red;
            this.button27.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button27.Location = new System.Drawing.Point(300, 307);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(36, 32);
            this.button27.TabIndex = 31;
            this.button27.Text = "U";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.guessClick);
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.Red;
            this.button28.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button28.Location = new System.Drawing.Point(342, 269);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(36, 32);
            this.button28.TabIndex = 30;
            this.button28.Text = "V";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.guessClick);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.Red;
            this.button29.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button29.Location = new System.Drawing.Point(300, 269);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(36, 32);
            this.button29.TabIndex = 29;
            this.button29.Text = "W";
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.guessClick);
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.Red;
            this.button30.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button30.Location = new System.Drawing.Point(342, 231);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(36, 32);
            this.button30.TabIndex = 28;
            this.button30.Text = "X";
            this.button30.UseVisualStyleBackColor = false;
            this.button30.Click += new System.EventHandler(this.guessClick);
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.Red;
            this.button31.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button31.Location = new System.Drawing.Point(300, 231);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(36, 32);
            this.button31.TabIndex = 27;
            this.button31.Text = "Y";
            this.button31.UseVisualStyleBackColor = false;
            this.button31.Click += new System.EventHandler(this.guessClick);
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.Red;
            this.button32.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button32.Location = new System.Drawing.Point(147, 382);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(36, 32);
            this.button32.TabIndex = 37;
            this.button32.Text = "Z";
            this.button32.UseVisualStyleBackColor = false;
            this.button32.Click += new System.EventHandler(this.guessClick);
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.Red;
            this.button33.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button33.Location = new System.Drawing.Point(189, 382);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(36, 32);
            this.button33.TabIndex = 36;
            this.button33.Text = "Ź";
            this.button33.UseVisualStyleBackColor = false;
            this.button33.Click += new System.EventHandler(this.guessClick);
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.Red;
            this.button34.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button34.Location = new System.Drawing.Point(231, 382);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(36, 32);
            this.button34.TabIndex = 35;
            this.button34.Text = "Ż";
            this.button34.UseVisualStyleBackColor = false;
            this.button34.Click += new System.EventHandler(this.guessClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(454, 419);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblShowWord);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdA);
            this.Controls.Add(this.hangImage);
            this.Name = "Form2";
            this.Text = "Wisielec";
            this.Click += new System.EventHandler(this.guessClick);
            ((System.ComponentModel.ISupportInitialize)(this.hangImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hangImage;
        private System.Windows.Forms.Button cmdA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblShowWord;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button32;
    }
}