
namespace Radionics
{
    partial class Smd_res
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resistance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.enterResistance = new System.Windows.Forms.TextBox();
            this.Count = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Radionics.Properties.Resources.smd_res;
            this.pictureBox1.Location = new System.Drawing.Point(85, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // code
            // 
            this.code.BackColor = System.Drawing.Color.DimGray;
            this.code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.code.ForeColor = System.Drawing.Color.White;
            this.code.Location = new System.Drawing.Point(187, 117);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(63, 15);
            this.code.TabIndex = 1;
            this.code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.code_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Результат:";
            // 
            // resistance
            // 
            this.resistance.AutoSize = true;
            this.resistance.Location = new System.Drawing.Point(123, 230);
            this.resistance.Name = "resistance";
            this.resistance.Size = new System.Drawing.Size(0, 17);
            this.resistance.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "код → Ω";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(27, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(375, 2);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Введіть опір(в Ом):";
            // 
            // enterResistance
            // 
            this.enterResistance.Location = new System.Drawing.Point(139, 321);
            this.enterResistance.Name = "enterResistance";
            this.enterResistance.Size = new System.Drawing.Size(167, 22);
            this.enterResistance.TabIndex = 7;
            this.enterResistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterResistance_KeyPress);
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(256, 224);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(105, 29);
            this.Count.TabIndex = 8;
            this.Count.Text = "Підрахувати";
            this.Count.UseVisualStyleBackColor = true;
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(312, 318);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(105, 25);
            this.submit.TabIndex = 9;
            this.submit.Text = "Підтвердити";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ω → код";
            // 
            // Smd_res
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 375);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.enterResistance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resistance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.code);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Smd_res";
            this.Text = "Smd_res";
            this.Load += new System.EventHandler(this.Smd_res_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resistance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox enterResistance;
        private System.Windows.Forms.Button Count;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label6;
    }
}