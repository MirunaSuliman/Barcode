
namespace Barcode
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            p = new PictureBox();
            valoare = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            splitter1 = new Splitter();
            val_fin = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)p).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // p
            // 
            p.BackColor = Color.White;
            p.BorderStyle = BorderStyle.Fixed3D;
            p.Location = new Point(147, 17);
            p.Name = "p";
            p.Size = new Size(349, 116);
            p.TabIndex = 0;
            p.TabStop = false;
            // 
            // valoare
            // 
            valoare.Location = new Point(127, 127);
            valoare.Name = "valoare";
            valoare.Size = new Size(208, 27);
            valoare.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(18, 21);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(149, 24);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "deseneaza chenar";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(18, 80);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(178, 24);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "negativ (alb pe negru)";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(18, 50);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(183, 24);
            checkBox3.TabIndex = 4;
            checkBox3.Text = "deseneaza valoare text";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 429);
            splitter1.TabIndex = 5;
            splitter1.TabStop = false;
            // 
            // val_fin
            // 
            val_fin.BorderStyle = BorderStyle.None;
            val_fin.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            val_fin.Location = new Point(160, 111);
            val_fin.Name = "val_fin";
            val_fin.Size = new Size(324, 23);
            val_fin.TabIndex = 6;
            val_fin.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(228, 319);
            button1.Name = "button1";
            button1.Size = new Size(167, 44);
            button1.TabIndex = 7;
            button1.Text = "Genereaza";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(valoare);
            panel1.Location = new Point(172, 152);
            panel1.Name = "panel1";
            panel1.Size = new Size(349, 174);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.IBeam;
            label1.Font = new Font("SimSun", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 123);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 5;
            label1.Text = "Valoare";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Pink;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(val_fin);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(p);
            panel2.Location = new Point(23, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(669, 394);
            panel2.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(711, 429);
            Controls.Add(panel1);
            Controls.Add(splitter1);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)p).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox p;
        private System.Windows.Forms.TextBox valoare;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox val_fin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}

