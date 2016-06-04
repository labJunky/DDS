namespace DDSControl
{
    partial class LinearSweepControl
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
            this.label3 = new System.Windows.Forms.Label();
            this.startFreqTextBox = new System.Windows.Forms.TextBox();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stopFreqTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deltaFreqTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.deltaTimeTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "[Hz]";
            // 
            // startFreqTextBox
            // 
            this.startFreqTextBox.Location = new System.Drawing.Point(119, 3);
            this.startFreqTextBox.Name = "startFreqTextBox";
            this.startFreqTextBox.Size = new System.Drawing.Size(73, 20);
            this.startFreqTextBox.TabIndex = 20;
            this.startFreqTextBox.Text = "1e6";
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(1, 6);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(82, 13);
            this.frequencyLabel.TabIndex = 19;
            this.frequencyLabel.Text = "Start Frequency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "[Hz]";
            // 
            // stopFreqTextBox
            // 
            this.stopFreqTextBox.Location = new System.Drawing.Point(119, 29);
            this.stopFreqTextBox.Name = "stopFreqTextBox";
            this.stopFreqTextBox.Size = new System.Drawing.Size(73, 20);
            this.stopFreqTextBox.TabIndex = 25;
            this.stopFreqTextBox.Text = "10e6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Stop Frequency";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "[Hz]";
            // 
            // deltaFreqTextBox
            // 
            this.deltaFreqTextBox.Location = new System.Drawing.Point(119, 55);
            this.deltaFreqTextBox.Name = "deltaFreqTextBox";
            this.deltaFreqTextBox.Size = new System.Drawing.Size(73, 20);
            this.deltaFreqTextBox.TabIndex = 28;
            this.deltaFreqTextBox.Text = "1.6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Delta Frequency";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "[s]";
            // 
            // deltaTimeTextBox
            // 
            this.deltaTimeTextBox.Location = new System.Drawing.Point(119, 81);
            this.deltaTimeTextBox.Name = "deltaTimeTextBox";
            this.deltaTimeTextBox.Size = new System.Drawing.Size(73, 20);
            this.deltaTimeTextBox.TabIndex = 31;
            this.deltaTimeTextBox.Text = "160e-9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Delta Time";
            // 
            // LinearSweepControl
            // 
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deltaTimeTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deltaFreqTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stopFreqTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startFreqTextBox);
            this.Controls.Add(this.frequencyLabel);
            this.Name = "LinearSweepControl";
            this.Size = new System.Drawing.Size(271, 111);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox startFreqTextBox;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stopFreqTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox deltaFreqTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox deltaTimeTextBox;
        private System.Windows.Forms.Label label8;
    }
}
