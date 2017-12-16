namespace Battery
{
    partial class FormBattery
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBarBattery = new System.Windows.Forms.ProgressBar();
            this.numericUpDownBattery = new System.Windows.Forms.NumericUpDown();
            this.trackBarBattery = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.TextBox();
            this.Percentage = new System.Windows.Forms.TextBox();
            this.timeLeft = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelInMinutes = new System.Windows.Forms.Label();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBattery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBattery)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Remaining:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Percentage:";
            // 
            // progressBarBattery
            // 
            this.progressBarBattery.Location = new System.Drawing.Point(21, 89);
            this.progressBarBattery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBarBattery.Name = "progressBarBattery";
            this.progressBarBattery.Size = new System.Drawing.Size(433, 28);
            this.progressBarBattery.TabIndex = 9;
            // 
            // numericUpDownBattery
            // 
            this.numericUpDownBattery.Location = new System.Drawing.Point(128, 188);
            this.numericUpDownBattery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownBattery.Maximum = new decimal(new int[] {
            18000,
            0,
            0,
            0});
            this.numericUpDownBattery.Name = "numericUpDownBattery";
            this.numericUpDownBattery.Size = new System.Drawing.Size(133, 22);
            this.numericUpDownBattery.TabIndex = 8;
            this.numericUpDownBattery.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBattery.ValueChanged += new System.EventHandler(this.numericUpDownBattery_ValueChanged);
            // 
            // trackBarBattery
            // 
            this.trackBarBattery.LargeChange = 1;
            this.trackBarBattery.Location = new System.Drawing.Point(24, 245);
            this.trackBarBattery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarBattery.Maximum = 300;
            this.trackBarBattery.Name = "trackBarBattery";
            this.trackBarBattery.Size = new System.Drawing.Size(452, 56);
            this.trackBarBattery.TabIndex = 7;
            this.trackBarBattery.Value = 1;
            this.trackBarBattery.Scroll += new System.EventHandler(this.trackBarBattery_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status:";
            // 
            // State
            // 
            this.State.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.State.Location = new System.Drawing.Point(119, 9);
            this.State.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Size = new System.Drawing.Size(349, 22);
            this.State.TabIndex = 12;
            // 
            // Percentage
            // 
            this.Percentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Percentage.Location = new System.Drawing.Point(119, 52);
            this.Percentage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Percentage.Name = "Percentage";
            this.Percentage.ReadOnly = true;
            this.Percentage.Size = new System.Drawing.Size(348, 22);
            this.Percentage.TabIndex = 13;
            // 
            // timeLeft
            // 
            this.timeLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLeft.Location = new System.Drawing.Point(119, 138);
            this.timeLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeLeft.Name = "timeLeft";
            this.timeLeft.ReadOnly = true;
            this.timeLeft.Size = new System.Drawing.Size(348, 22);
            this.timeLeft.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Set in second:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Set in minutes:";
            // 
            // labelInMinutes
            // 
            this.labelInMinutes.AutoSize = true;
            this.labelInMinutes.Location = new System.Drawing.Point(124, 225);
            this.labelInMinutes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInMinutes.Name = "labelInMinutes";
            this.labelInMinutes.Size = new System.Drawing.Size(276, 17);
            this.labelInMinutes.TabIndex = 17;
            this.labelInMinutes.Text = "Screen timeout in minutes(only for battery)";
            // 
            // FormBattery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 315);
            this.Controls.Add(this.labelInMinutes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timeLeft);
            this.Controls.Add(this.Percentage);
            this.Controls.Add(this.State);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBarBattery);
            this.Controls.Add(this.numericUpDownBattery);
            this.Controls.Add(this.trackBarBattery);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormBattery";
            this.Text = "Battery";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBattery_FormClosing);
            this.Load += new System.EventHandler(this.FormBattery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBattery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBattery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBarBattery;
        private System.Windows.Forms.NumericUpDown numericUpDownBattery;
        private System.Windows.Forms.TrackBar trackBarBattery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox State;
        private System.Windows.Forms.TextBox Percentage;
        private System.Windows.Forms.TextBox timeLeft;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelInMinutes;
        private System.Windows.Forms.Timer UpdateTimer;
    }
}