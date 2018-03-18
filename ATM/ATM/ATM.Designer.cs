namespace ATM
{
    partial class ATM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATM));
            this.enter = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.bottomLeft = new System.Windows.Forms.Button();
            this.topLeft = new System.Windows.Forms.Button();
            this.topRight = new System.Windows.Forms.Button();
            this.bottomRight = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.subLabel = new System.Windows.Forms.Label();
            this.lblEnter = new System.Windows.Forms.TextBox();
            this.topLeftLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bottomLeftLabel = new System.Windows.Forms.Label();
            this.topRightLabel = new System.Windows.Forms.Label();
            this.bottomRightLabel = new System.Windows.Forms.Label();
            this.incorrectPinTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.Location = new System.Drawing.Point(288, 211);
            this.enter.MaximumSize = new System.Drawing.Size(60, 60);
            this.enter.MinimumSize = new System.Drawing.Size(60, 60);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(60, 60);
            this.enter.TabIndex = 3;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Yellow;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(288, 277);
            this.clear.MaximumSize = new System.Drawing.Size(60, 60);
            this.clear.MinimumSize = new System.Drawing.Size(60, 60);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(60, 60);
            this.clear.TabIndex = 7;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Red;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(288, 343);
            this.cancel.MaximumSize = new System.Drawing.Size(60, 60);
            this.cancel.MinimumSize = new System.Drawing.Size(60, 60);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(60, 60);
            this.cancel.TabIndex = 11;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(81, 404);
            this.button0.MaximumSize = new System.Drawing.Size(215, 200);
            this.button0.MinimumSize = new System.Drawing.Size(60, 60);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(205, 70);
            this.button0.TabIndex = 12;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // bottomLeft
            // 
            this.bottomLeft.Location = new System.Drawing.Point(0, 128);
            this.bottomLeft.Name = "bottomLeft";
            this.bottomLeft.Size = new System.Drawing.Size(65, 65);
            this.bottomLeft.TabIndex = 15;
            this.bottomLeft.UseVisualStyleBackColor = true;
            this.bottomLeft.Click += new System.EventHandler(this.bottomLeft_Click);
            // 
            // topLeft
            // 
            this.topLeft.Location = new System.Drawing.Point(0, 10);
            this.topLeft.Name = "topLeft";
            this.topLeft.Size = new System.Drawing.Size(65, 65);
            this.topLeft.TabIndex = 16;
            this.topLeft.UseVisualStyleBackColor = true;
            this.topLeft.Click += new System.EventHandler(this.topLeft_Click);
            // 
            // topRight
            // 
            this.topRight.Location = new System.Drawing.Point(367, 10);
            this.topRight.Name = "topRight";
            this.topRight.Size = new System.Drawing.Size(65, 65);
            this.topRight.TabIndex = 17;
            this.topRight.UseVisualStyleBackColor = true;
            this.topRight.Click += new System.EventHandler(this.topRight_Click);
            // 
            // bottomRight
            // 
            this.bottomRight.Location = new System.Drawing.Point(367, 128);
            this.bottomRight.Name = "bottomRight";
            this.bottomRight.Size = new System.Drawing.Size(65, 65);
            this.bottomRight.TabIndex = 18;
            this.bottomRight.UseVisualStyleBackColor = true;
            this.bottomRight.Click += new System.EventHandler(this.bottomRight_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.MediumBlue;
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(164, 36);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(108, 13);
            this.titleLabel.TabIndex = 19;
            this.titleLabel.Text = "Welcome to the ATM";
            // 
            // subLabel
            // 
            this.subLabel.AutoSize = true;
            this.subLabel.BackColor = System.Drawing.Color.MediumBlue;
            this.subLabel.ForeColor = System.Drawing.Color.White;
            this.subLabel.Location = new System.Drawing.Point(137, 154);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(169, 13);
            this.subLabel.TabIndex = 20;
            this.subLabel.Text = "Please enter your account number";
            // 
            // lblEnter
            // 
            this.lblEnter.BackColor = System.Drawing.Color.MediumBlue;
            this.lblEnter.ForeColor = System.Drawing.Color.White;
            this.lblEnter.Location = new System.Drawing.Point(140, 89);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(166, 20);
            this.lblEnter.TabIndex = 21;
            // 
            // topLeftLabel
            // 
            this.topLeftLabel.AutoSize = true;
            this.topLeftLabel.BackColor = System.Drawing.Color.MediumBlue;
            this.topLeftLabel.ForeColor = System.Drawing.Color.White;
            this.topLeftLabel.Location = new System.Drawing.Point(69, 33);
            this.topLeftLabel.Name = "topLeftLabel";
            this.topLeftLabel.Size = new System.Drawing.Size(0, 13);
            this.topLeftLabel.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 23;
            // 
            // bottomLeftLabel
            // 
            this.bottomLeftLabel.AutoSize = true;
            this.bottomLeftLabel.BackColor = System.Drawing.Color.MediumBlue;
            this.bottomLeftLabel.ForeColor = System.Drawing.Color.White;
            this.bottomLeftLabel.Location = new System.Drawing.Point(70, 154);
            this.bottomLeftLabel.Name = "bottomLeftLabel";
            this.bottomLeftLabel.Size = new System.Drawing.Size(0, 13);
            this.bottomLeftLabel.TabIndex = 24;
            // 
            // topRightLabel
            // 
            this.topRightLabel.AutoSize = true;
            this.topRightLabel.BackColor = System.Drawing.Color.MediumBlue;
            this.topRightLabel.ForeColor = System.Drawing.Color.White;
            this.topRightLabel.Location = new System.Drawing.Point(330, 36);
            this.topRightLabel.Name = "topRightLabel";
            this.topRightLabel.Size = new System.Drawing.Size(0, 13);
            this.topRightLabel.TabIndex = 25;
            this.topRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bottomRightLabel
            // 
            this.bottomRightLabel.AutoSize = true;
            this.bottomRightLabel.BackColor = System.Drawing.Color.MediumBlue;
            this.bottomRightLabel.ForeColor = System.Drawing.Color.White;
            this.bottomRightLabel.Location = new System.Drawing.Point(330, 154);
            this.bottomRightLabel.Name = "bottomRightLabel";
            this.bottomRightLabel.Size = new System.Drawing.Size(0, 13);
            this.bottomRightLabel.TabIndex = 26;
            this.bottomRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // incorrectPinTimer
            // 
            this.incorrectPinTimer.Interval = 3000;
            this.incorrectPinTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(434, 486);
            this.Controls.Add(this.bottomRightLabel);
            this.Controls.Add(this.topRightLabel);
            this.Controls.Add(this.bottomLeftLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topLeftLabel);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.bottomRight);
            this.Controls.Add(this.topRight);
            this.Controls.Add(this.topLeft);
            this.Controls.Add(this.bottomLeft);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.enter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.Name = "ATM";
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.ATM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button bottomLeft;
        private System.Windows.Forms.Button topLeft;
        private System.Windows.Forms.Button topRight;
        private System.Windows.Forms.Button bottomRight;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.TextBox lblEnter;
        private System.Windows.Forms.Label topLeftLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bottomLeftLabel;
        private System.Windows.Forms.Label topRightLabel;
        private System.Windows.Forms.Label bottomRightLabel;
        private System.Windows.Forms.Timer incorrectPinTimer;
    }
}