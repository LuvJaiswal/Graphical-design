namespace Graphical_Designs
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.canvas = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.angle = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.Label();
            this.increment = new System.Windows.Forms.Label();
            this.Go = new System.Windows.Forms.Button();
            this.line1 = new System.Windows.Forms.TextBox();
            this.angle1 = new System.Windows.Forms.TextBox();
            this.length1 = new System.Windows.Forms.TextBox();
            this.increment1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.increment1);
            this.panel1.Controls.Add(this.length1);
            this.panel1.Controls.Add(this.angle1);
            this.panel1.Controls.Add(this.line1);
            this.panel1.Controls.Add(this.Go);
            this.panel1.Controls.Add(this.increment);
            this.panel1.Controls.Add(this.length);
            this.panel1.Controls.Add(this.angle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 100);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.Info;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 100);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1125, 495);
            this.canvas.TabIndex = 2;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "#Lines";
            // 
            // angle
            // 
            this.angle.AutoSize = true;
            this.angle.Location = new System.Drawing.Point(245, 30);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(86, 32);
            this.angle.TabIndex = 1;
            this.angle.Text = "angle";
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.Location = new System.Drawing.Point(448, 30);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(94, 32);
            this.length.TabIndex = 2;
            this.length.Text = "length";
            // 
            // increment
            // 
            this.increment.AutoSize = true;
            this.increment.Location = new System.Drawing.Point(659, 30);
            this.increment.Name = "increment";
            this.increment.Size = new System.Drawing.Size(140, 32);
            this.increment.TabIndex = 3;
            this.increment.Text = "increment";
            this.increment.Click += new System.EventHandler(this.increment_Click);
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(959, 14);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(104, 63);
            this.Go.TabIndex = 4;
            this.Go.Text = "GO";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.button1_Click);
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(124, 24);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(100, 38);
            this.line1.TabIndex = 5;
            // 
            // angle1
            // 
            this.angle1.Location = new System.Drawing.Point(337, 24);
            this.angle1.Name = "angle1";
            this.angle1.Size = new System.Drawing.Size(100, 38);
            this.angle1.TabIndex = 6;
            // 
            // length1
            // 
            this.length1.Location = new System.Drawing.Point(548, 24);
            this.length1.Name = "length1";
            this.length1.Size = new System.Drawing.Size(100, 38);
            this.length1.TabIndex = 7;
            // 
            // increment1
            // 
            this.increment1.Location = new System.Drawing.Point(805, 27);
            this.increment1.Name = "increment1";
            this.increment1.Size = new System.Drawing.Size(100, 38);
            this.increment1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 595);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.Label increment;
        private System.Windows.Forms.Label length;
        private System.Windows.Forms.Label angle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox increment1;
        private System.Windows.Forms.TextBox length1;
        private System.Windows.Forms.TextBox angle1;
        private System.Windows.Forms.TextBox line1;
    }
}

