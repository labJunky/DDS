namespace DDSControl
{
    partial class SweepUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stopFreqTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startFreqTextBox = new System.Windows.Forms.TextBox();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ampTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sweepChannelComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "[Hz/s]";
            // 
            // rateTextBox
            // 
            this.rateTextBox.Location = new System.Drawing.Point(130, 115);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(73, 20);
            this.rateTextBox.TabIndex = 40;
            this.rateTextBox.Text = "1e6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Sweep Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "[Hz]";
            // 
            // stopFreqTextBox
            // 
            this.stopFreqTextBox.Location = new System.Drawing.Point(130, 89);
            this.stopFreqTextBox.Name = "stopFreqTextBox";
            this.stopFreqTextBox.Size = new System.Drawing.Size(73, 20);
            this.stopFreqTextBox.TabIndex = 37;
            this.stopFreqTextBox.Text = "10e6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Stop Frequency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "[Hz]";
            // 
            // startFreqTextBox
            // 
            this.startFreqTextBox.Location = new System.Drawing.Point(130, 63);
            this.startFreqTextBox.Name = "startFreqTextBox";
            this.startFreqTextBox.Size = new System.Drawing.Size(73, 20);
            this.startFreqTextBox.TabIndex = 34;
            this.startFreqTextBox.Text = "1e6";
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(12, 66);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(82, 13);
            this.frequencyLabel.TabIndex = 33;
            this.frequencyLabel.Text = "Start Frequency";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "[0-1023]";
            // 
            // ampTextBox
            // 
            this.ampTextBox.Location = new System.Drawing.Point(130, 37);
            this.ampTextBox.Name = "ampTextBox";
            this.ampTextBox.Size = new System.Drawing.Size(73, 20);
            this.ampTextBox.TabIndex = 46;
            this.ampTextBox.Text = "1023";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Amplitude";
            // 
            // sweepChannelComboBox
            // 
            this.sweepChannelComboBox.FormattingEnabled = true;
            this.sweepChannelComboBox.Items.AddRange(new object[] {
            "0",
            "1"});
            this.sweepChannelComboBox.Location = new System.Drawing.Point(131, 9);
            this.sweepChannelComboBox.Name = "sweepChannelComboBox";
            this.sweepChannelComboBox.Size = new System.Drawing.Size(72, 21);
            this.sweepChannelComboBox.TabIndex = 49;
            this.sweepChannelComboBox.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Channel";
            // 
            // SweepUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sweepChannelComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ampTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rateTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stopFreqTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startFreqTextBox);
            this.Controls.Add(this.frequencyLabel);
            this.Name = "SweepUserControl";
            this.Size = new System.Drawing.Size(260, 139);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stopFreqTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox startFreqTextBox;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ampTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox sweepChannelComboBox;
        private System.Windows.Forms.Label label7;

    }
}
