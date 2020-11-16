namespace ATCDisplaySystem
{
    partial class optionsMenu
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.reportButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.systemButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.alertComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Location = new System.Drawing.Point(708, 578);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(95, 42);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alerts";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(298, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 57);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reports";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(615, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 57);
            this.label3.TabIndex = 3;
            this.label3.Text = "Options";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Today",
            "Yesterday",
            "This Month",
            "Last Six Months",
            "Up to One Year",
            "All Time"});
            this.comboBox1.Location = new System.Drawing.Point(372, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(254, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Time Period:";
            // 
            // reportButton
            // 
            this.reportButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reportButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reportButton.Location = new System.Drawing.Point(324, 134);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(99, 33);
            this.reportButton.TabIndex = 6;
            this.reportButton.Text = "View Reports";
            this.reportButton.UseVisualStyleBackColor = false;
            // 
            // displayButton
            // 
            this.displayButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.displayButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayButton.ForeColor = System.Drawing.SystemColors.Control;
            this.displayButton.Location = new System.Drawing.Point(636, 87);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(130, 60);
            this.displayButton.TabIndex = 7;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = false;
            // 
            // systemButton
            // 
            this.systemButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.systemButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemButton.ForeColor = System.Drawing.SystemColors.Control;
            this.systemButton.Location = new System.Drawing.Point(636, 182);
            this.systemButton.Name = "systemButton";
            this.systemButton.Size = new System.Drawing.Size(130, 60);
            this.systemButton.TabIndex = 8;
            this.systemButton.Text = "System";
            this.systemButton.UseVisualStyleBackColor = false;
            // 
            // userButton
            // 
            this.userButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userButton.ForeColor = System.Drawing.SystemColors.Control;
            this.userButton.Location = new System.Drawing.Point(636, 276);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(130, 60);
            this.userButton.TabIndex = 9;
            this.userButton.Text = "User";
            this.userButton.UseVisualStyleBackColor = false;
            // 
            // alertComboBox
            // 
            this.alertComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alertComboBox.FormattingEnabled = true;
            this.alertComboBox.Items.AddRange(new object[] {
            "TCAS",
            "Weather",
            "Other"});
            this.alertComboBox.Location = new System.Drawing.Point(12, 109);
            this.alertComboBox.Name = "alertComboBox";
            this.alertComboBox.Size = new System.Drawing.Size(121, 21);
            this.alertComboBox.TabIndex = 10;
            // 
            // optionsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(814, 631);
            this.Controls.Add(this.alertComboBox);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.systemButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Name = "optionsMenu";
            this.Text = "Options Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button systemButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.ComboBox alertComboBox;
    }
}