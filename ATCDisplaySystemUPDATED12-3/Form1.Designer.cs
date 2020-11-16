namespace ATCDisplaySystem
{
    partial class Form1
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
            this.takeoffTimer = new System.Windows.Forms.Timer(this.components);
            this.collisionTimer = new System.Windows.Forms.Timer(this.components);
            this.optionsMenuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Landing = new System.Windows.Forms.Button();
            this.takeoffPlane = new System.Windows.Forms.Button();
            this.TCAS = new System.Windows.Forms.Button();
            this.planesColliding = new System.Windows.Forms.Button();
            this.planeTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.landingTimer = new System.Windows.Forms.Timer(this.components);
            this.TCASTimer = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.takeoffTimerNum = new System.Windows.Forms.Timer(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // takeoffTimer
            // 
            this.takeoffTimer.Tick += new System.EventHandler(this.TakeoffTimer_Tick);
            // 
            // collisionTimer
            // 
            this.collisionTimer.Interval = 250;
            this.collisionTimer.Tick += new System.EventHandler(this.CollisionTimer_Tick);
            // 
            // optionsMenuButton
            // 
            this.optionsMenuButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optionsMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsMenuButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.optionsMenuButton.Location = new System.Drawing.Point(587, 665);
            this.optionsMenuButton.Name = "optionsMenuButton";
            this.optionsMenuButton.Size = new System.Drawing.Size(89, 47);
            this.optionsMenuButton.TabIndex = 5;
            this.optionsMenuButton.Text = "Options Menu";
            this.optionsMenuButton.UseVisualStyleBackColor = false;
            this.optionsMenuButton.Click += new System.EventHandler(this.optionsMenuButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(535, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 6;
            // 
            // Landing
            // 
            this.Landing.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Landing.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Landing.Location = new System.Drawing.Point(713, 654);
            this.Landing.Name = "Landing";
            this.Landing.Size = new System.Drawing.Size(89, 26);
            this.Landing.TabIndex = 7;
            this.Landing.Text = "Land Plane";
            this.Landing.UseVisualStyleBackColor = false;
            this.Landing.Click += new System.EventHandler(this.Landing_Click);
            // 
            // takeoffPlane
            // 
            this.takeoffPlane.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.takeoffPlane.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.takeoffPlane.Location = new System.Drawing.Point(713, 686);
            this.takeoffPlane.Name = "takeoffPlane";
            this.takeoffPlane.Size = new System.Drawing.Size(89, 26);
            this.takeoffPlane.TabIndex = 8;
            this.takeoffPlane.Text = "Plane Take Off ";
            this.takeoffPlane.UseVisualStyleBackColor = false;
            this.takeoffPlane.Click += new System.EventHandler(this.TakeoffPlane_Click);
            // 
            // TCAS
            // 
            this.TCAS.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TCAS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TCAS.Location = new System.Drawing.Point(713, 622);
            this.TCAS.Name = "TCAS";
            this.TCAS.Size = new System.Drawing.Size(89, 26);
            this.TCAS.TabIndex = 9;
            this.TCAS.Text = "TCAS";
            this.TCAS.UseVisualStyleBackColor = false;
            this.TCAS.Click += new System.EventHandler(this.TCAS_Click);
            // 
            // planesColliding
            // 
            this.planesColliding.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.planesColliding.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.planesColliding.Location = new System.Drawing.Point(713, 590);
            this.planesColliding.Name = "planesColliding";
            this.planesColliding.Size = new System.Drawing.Size(89, 26);
            this.planesColliding.TabIndex = 10;
            this.planesColliding.Text = "Collision";
            this.planesColliding.UseVisualStyleBackColor = false;
            this.planesColliding.Click += new System.EventHandler(this.planesColliding_Click);
            // 
            // planeTimer
            // 
            this.planeTimer.Interval = 250;
            this.planeTimer.Tick += new System.EventHandler(this.PlaneTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(32, 610);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(32, 628);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 14;
            // 
            // landingTimer
            // 
            this.landingTimer.Interval = 250;
            this.landingTimer.Tick += new System.EventHandler(this.LandingTimer_Tick);
            // 
            // TCASTimer
            // 
            this.TCASTimer.Interval = 250;
            this.TCASTimer.Tick += new System.EventHandler(this.TCASTimer_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(32, 646);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(32, 665);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(30, 578);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Planes on Radar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(299, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 25);
            this.label8.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(78, 665);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 18);
            this.label9.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(124, 665);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 18);
            this.label10.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(78, 628);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 18);
            this.label11.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(124, 630);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 18);
            this.label12.TabIndex = 20;
            // 
            // takeoffTimerNum
            // 
            this.takeoffTimerNum.Tick += new System.EventHandler(this.TakeoffTimerNum_Tick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Orange;
            this.label14.Location = new System.Drawing.Point(299, 551);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 25);
            this.label14.TabIndex = 25;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(676, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(105, 536);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 536);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(35, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(746, 536);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox2_Paint);
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox2_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(814, 724);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.planesColliding);
            this.Controls.Add(this.TCAS);
            this.Controls.Add(this.takeoffPlane);
            this.Controls.Add(this.Landing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.optionsMenuButton);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer takeoffTimer;
        private System.Windows.Forms.Timer collisionTimer;
        private System.Windows.Forms.Button optionsMenuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Landing;
        private System.Windows.Forms.Button takeoffPlane;
        private System.Windows.Forms.Button TCAS;
        private System.Windows.Forms.Button planesColliding;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer planeTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer landingTimer;
        private System.Windows.Forms.Timer TCASTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer takeoffTimerNum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

