namespace Exam
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
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.txtb3 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(155, 92);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(83, 19);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "First name";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(155, 153);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(81, 19);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "Last name";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(105, 215);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(133, 19);
            this.lb3.TabIndex = 2;
            this.lb3.Text = "Telephon number";
            // 
            // txtb1
            // 
            this.txtb1.Location = new System.Drawing.Point(269, 92);
            this.txtb1.Multiline = true;
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(224, 45);
            this.txtb1.TabIndex = 3;
            this.txtb1.TextChanged += new System.EventHandler(this.txtb1_TextChanged);
            // 
            // txtb2
            // 
            this.txtb2.Location = new System.Drawing.Point(269, 151);
            this.txtb2.Multiline = true;
            this.txtb2.Name = "txtb2";
            this.txtb2.Size = new System.Drawing.Size(224, 45);
            this.txtb2.TabIndex = 4;
            this.txtb2.TextChanged += new System.EventHandler(this.txtb2_TextChanged);
            // 
            // txtb3
            // 
            this.txtb3.Location = new System.Drawing.Point(269, 215);
            this.txtb3.Multiline = true;
            this.txtb3.Name = "txtb3";
            this.txtb3.Size = new System.Drawing.Size(224, 45);
            this.txtb3.TabIndex = 5;
            this.txtb3.TextChanged += new System.EventHandler(this.txtb3_TextChanged);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(225, 290);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(124, 42);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "Clear Form";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(411, 290);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(124, 42);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "Register";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(225, 351);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(124, 42);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "Count of users";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(411, 351);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(124, 42);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "Delete users";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtb3);
            this.Controls.Add(this.txtb2);
            this.Controls.Add(this.txtb1);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.TextBox txtb3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
    }
}

