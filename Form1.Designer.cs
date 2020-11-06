namespace ETS2_Trainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProcOpenLabel = new System.Windows.Forms.Label();
            this.SetMoney = new System.Windows.Forms.Button();
            this.MoneyAmount = new System.Windows.Forms.TextBox();
            this.SetEXP = new System.Windows.Forms.Button();
            this.EXPAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Made By Saniee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Game Open?:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 33);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ProcOpenLabel
            // 
            this.ProcOpenLabel.AutoSize = true;
            this.ProcOpenLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProcOpenLabel.Location = new System.Drawing.Point(121, 67);
            this.ProcOpenLabel.Name = "ProcOpenLabel";
            this.ProcOpenLabel.Size = new System.Drawing.Size(27, 13);
            this.ProcOpenLabel.TabIndex = 3;
            this.ProcOpenLabel.Text = "N/A";
            // 
            // SetMoney
            // 
            this.SetMoney.BackColor = System.Drawing.Color.Gray;
            this.SetMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetMoney.Location = new System.Drawing.Point(274, 38);
            this.SetMoney.Name = "SetMoney";
            this.SetMoney.Size = new System.Drawing.Size(75, 23);
            this.SetMoney.TabIndex = 4;
            this.SetMoney.Text = "Set Money";
            this.SetMoney.UseVisualStyleBackColor = false;
            this.SetMoney.Click += new System.EventHandler(this.SetMoney_Click);
            // 
            // MoneyAmount
            // 
            this.MoneyAmount.BackColor = System.Drawing.Color.Silver;
            this.MoneyAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MoneyAmount.Location = new System.Drawing.Point(12, 40);
            this.MoneyAmount.Name = "MoneyAmount";
            this.MoneyAmount.Size = new System.Drawing.Size(245, 20);
            this.MoneyAmount.TabIndex = 5;
            this.MoneyAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MoneyAmount_KeyPress);
            // 
            // SetEXP
            // 
            this.SetEXP.BackColor = System.Drawing.Color.Gray;
            this.SetEXP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetEXP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetEXP.Location = new System.Drawing.Point(274, 87);
            this.SetEXP.Name = "SetEXP";
            this.SetEXP.Size = new System.Drawing.Size(75, 23);
            this.SetEXP.TabIndex = 6;
            this.SetEXP.Text = "Set EXP";
            this.SetEXP.UseVisualStyleBackColor = false;
            this.SetEXP.Click += new System.EventHandler(this.SetEXP_Click);
            // 
            // EXPAmount
            // 
            this.EXPAmount.BackColor = System.Drawing.Color.Silver;
            this.EXPAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EXPAmount.Location = new System.Drawing.Point(12, 87);
            this.EXPAmount.Name = "EXPAmount";
            this.EXPAmount.Size = new System.Drawing.Size(245, 20);
            this.EXPAmount.TabIndex = 7;
            this.EXPAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EXPAmount_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(144, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Open and Close Map to see the changes!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(322, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ETS2 Trainer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(362, 166);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EXPAmount);
            this.Controls.Add(this.SetEXP);
            this.Controls.Add(this.MoneyAmount);
            this.Controls.Add(this.SetMoney);
            this.Controls.Add(this.ProcOpenLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ETS2 Trainer";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ProcOpenLabel;
        private System.Windows.Forms.Button SetMoney;
        private System.Windows.Forms.TextBox MoneyAmount;
        private System.Windows.Forms.Button SetEXP;
        private System.Windows.Forms.TextBox EXPAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}

