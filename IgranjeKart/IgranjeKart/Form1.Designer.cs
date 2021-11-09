
namespace IgranjeKart
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pon1 = new System.Windows.Forms.Button();
            this.pon2 = new System.Windows.Forms.Button();
            this.mes1 = new System.Windows.Forms.Button();
            this.mes2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(40, 96);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(155, 238);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(301, 88);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(155, 238);
            this.listBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kup 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kup 2 (52 kart)";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(211, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = ">>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(211, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "<<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pon1
            // 
            this.pon1.Location = new System.Drawing.Point(40, 353);
            this.pon1.Name = "pon1";
            this.pon1.Size = new System.Drawing.Size(155, 23);
            this.pon1.TabIndex = 8;
            this.pon1.Text = "Ponastavi kup 1";
            this.pon1.UseVisualStyleBackColor = true;
            this.pon1.Click += new System.EventHandler(this.pon1_Click);
            // 
            // pon2
            // 
            this.pon2.Location = new System.Drawing.Point(301, 353);
            this.pon2.Name = "pon2";
            this.pon2.Size = new System.Drawing.Size(155, 23);
            this.pon2.TabIndex = 9;
            this.pon2.Text = "Ponastavi kup 2";
            this.pon2.UseVisualStyleBackColor = true;
            this.pon2.Click += new System.EventHandler(this.pon2_Click);
            // 
            // mes1
            // 
            this.mes1.Location = new System.Drawing.Point(40, 391);
            this.mes1.Name = "mes1";
            this.mes1.Size = new System.Drawing.Size(155, 23);
            this.mes1.TabIndex = 10;
            this.mes1.Text = "Mešaj kup 1";
            this.mes1.UseVisualStyleBackColor = true;
            this.mes1.Click += new System.EventHandler(this.mes1_Click);
            // 
            // mes2
            // 
            this.mes2.Location = new System.Drawing.Point(301, 391);
            this.mes2.Name = "mes2";
            this.mes2.Size = new System.Drawing.Size(155, 23);
            this.mes2.TabIndex = 11;
            this.mes2.Text = "Mešaj kup 2";
            this.mes2.UseVisualStyleBackColor = true;
            this.mes2.Click += new System.EventHandler(this.mes2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 450);
            this.Controls.Add(this.mes2);
            this.Controls.Add(this.mes1);
            this.Controls.Add(this.pon2);
            this.Controls.Add(this.pon1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button pon1;
        private System.Windows.Forms.Button pon2;
        private System.Windows.Forms.Button mes1;
        private System.Windows.Forms.Button mes2;
    }
}

