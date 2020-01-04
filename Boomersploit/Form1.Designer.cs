namespace Boomersploit
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.injectBTN = new System.Windows.Forms.Button();
            this.execBTN = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 3);
            this.textBox1.MaxLength = 999999999;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(652, 380);
            this.textBox1.TabIndex = 0;
            // 
            // injectBTN
            // 
            this.injectBTN.Location = new System.Drawing.Point(0, 384);
            this.injectBTN.Name = "injectBTN";
            this.injectBTN.Size = new System.Drawing.Size(139, 56);
            this.injectBTN.TabIndex = 1;
            this.injectBTN.Text = "Inject";
            this.injectBTN.UseVisualStyleBackColor = true;
            this.injectBTN.Click += new System.EventHandler(this.injectBTN_Click);
            // 
            // execBTN
            // 
            this.execBTN.Location = new System.Drawing.Point(524, 384);
            this.execBTN.Name = "execBTN";
            this.execBTN.Size = new System.Drawing.Size(139, 56);
            this.execBTN.TabIndex = 1;
            this.execBTN.Text = "Execute";
            this.execBTN.UseVisualStyleBackColor = true;
            this.execBTN.Click += new System.EventHandler(this.execBTN_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 435);
            this.Controls.Add(this.execBTN);
            this.Controls.Add(this.injectBTN);
            this.Controls.Add(this.textBox1);
            this.MaximumSize = new System.Drawing.Size(675, 482);
            this.MinimumSize = new System.Drawing.Size(675, 482);
            this.Name = "Form1";
            this.Text = "BoomerSploit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button injectBTN;
        private System.Windows.Forms.Button execBTN;
        private System.Windows.Forms.Timer timer1;
    }
}

