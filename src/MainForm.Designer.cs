namespace TTS
{
    partial class MainForm
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
            this.Logo = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.speakBtn = new System.Windows.Forms.Button();
            this.textInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.msJira = new System.Windows.Forms.RadioButton();
            this.msDavid = new System.Windows.Forms.RadioButton();
            this.credits = new System.Windows.Forms.LinkLabel();
            this.rateLabel = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.NumericUpDown();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ssmlInput = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rate)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logo.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.Location = new System.Drawing.Point(13, 15);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(159, 45);
            this.Logo.TabIndex = 0;
            this.Logo.Text = "TTSBoard";
            this.Logo.UseCompatibleTextRendering = true;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(21, 69);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(31, 13);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "Text:";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // speakBtn
            // 
            this.speakBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.speakBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.speakBtn.Location = new System.Drawing.Point(373, 347);
            this.speakBtn.Name = "speakBtn";
            this.speakBtn.Size = new System.Drawing.Size(75, 23);
            this.speakBtn.TabIndex = 2;
            this.speakBtn.Text = "Speak";
            this.speakBtn.UseVisualStyleBackColor = true;
            this.speakBtn.Click += new System.EventHandler(this.speakBtn_Click);
            // 
            // textInput
            // 
            this.textInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textInput.Location = new System.Drawing.Point(55, 68);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(391, 20);
            this.textInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select a voice:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // msJira
            // 
            this.msJira.AutoSize = true;
            this.msJira.Cursor = System.Windows.Forms.Cursors.Hand;
            this.msJira.Location = new System.Drawing.Point(39, 157);
            this.msJira.Name = "msJira";
            this.msJira.Size = new System.Drawing.Size(132, 17);
            this.msJira.TabIndex = 5;
            this.msJira.TabStop = true;
            this.msJira.Text = "Microsoft Zira Desktop";
            this.msJira.UseVisualStyleBackColor = true;
            this.msJira.CheckedChanged += new System.EventHandler(this.msJira_CheckedChanged);
            // 
            // msDavid
            // 
            this.msDavid.AutoSize = true;
            this.msDavid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.msDavid.Location = new System.Drawing.Point(39, 178);
            this.msDavid.Name = "msDavid";
            this.msDavid.Size = new System.Drawing.Size(142, 17);
            this.msDavid.TabIndex = 6;
            this.msDavid.TabStop = true;
            this.msDavid.Text = "Microsoft David Desktop";
            this.msDavid.UseVisualStyleBackColor = true;
            this.msDavid.CheckedChanged += new System.EventHandler(this.msDavid_CheckedChanged);
            // 
            // credits
            // 
            this.credits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.credits.AutoSize = true;
            this.credits.Location = new System.Drawing.Point(12, 356);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(166, 17);
            this.credits.TabIndex = 7;
            this.credits.TabStop = true;
            this.credits.Text = "Made by Yedox Studios (Yeppii)";
            this.credits.UseCompatibleTextRendering = true;
            this.credits.Click += new System.EventHandler(this.credits_Click);
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Location = new System.Drawing.Point(20, 99);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(33, 13);
            this.rateLabel.TabIndex = 9;
            this.rateLabel.Text = "Rate:";
            // 
            // rate
            // 
            this.rate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rate.Location = new System.Drawing.Point(55, 97);
            this.rate.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rate.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(391, 20);
            this.rate.TabIndex = 10;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Location = new System.Drawing.Point(292, 347);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "Save as...";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Paste SSML here:";
            // 
            // ssmlInput
            // 
            this.ssmlInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ssmlInput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssmlInput.Location = new System.Drawing.Point(24, 233);
            this.ssmlInput.Name = "ssmlInput";
            this.ssmlInput.Size = new System.Drawing.Size(422, 100);
            this.ssmlInput.TabIndex = 13;
            this.ssmlInput.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 382);
            this.Controls.Add(this.ssmlInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.msDavid);
            this.Controls.Add(this.msJira);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.speakBtn);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TTSBoard 1.1.0";
            ((System.ComponentModel.ISupportInitialize)(this.rate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Button speakBtn;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton msJira;
        private System.Windows.Forms.RadioButton msDavid;
        private System.Windows.Forms.LinkLabel credits;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.NumericUpDown rate;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox ssmlInput;
    }
}