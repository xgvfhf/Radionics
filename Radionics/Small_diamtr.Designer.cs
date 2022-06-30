
namespace Radionics
{
    partial class Small_diamtr
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.material1 = new System.Windows.Forms.ComboBox();
            this.material2 = new System.Windows.Forms.ComboBox();
            this.diam = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.amperage = new System.Windows.Forms.Label();
            this.diametr = new System.Windows.Forms.Label();
            this.Count_amper = new System.Windows.Forms.Button();
            this.Count_diam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Виберіть матеріал:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Діаметр (в мм):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(132, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Розрахунок діаметра";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(123, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Розрахунок сили струму";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Виберіть матеріал:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Сила струму (А):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Діаметр (в мм):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Сила струму (А):";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(24, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(411, 2);
            this.label9.TabIndex = 8;
            // 
            // material1
            // 
            this.material1.FormattingEnabled = true;
            this.material1.Location = new System.Drawing.Point(191, 60);
            this.material1.Name = "material1";
            this.material1.Size = new System.Drawing.Size(121, 24);
            this.material1.TabIndex = 9;
            // 
            // material2
            // 
            this.material2.FormattingEnabled = true;
            this.material2.Location = new System.Drawing.Point(191, 251);
            this.material2.Name = "material2";
            this.material2.Size = new System.Drawing.Size(121, 24);
            this.material2.TabIndex = 10;
            // 
            // diam
            // 
            this.diam.Location = new System.Drawing.Point(156, 100);
            this.diam.Name = "diam";
            this.diam.Size = new System.Drawing.Size(121, 22);
            this.diam.TabIndex = 11;
            this.diam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.diam_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(174, 299);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 12;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.diam_KeyPress);
            // 
            // amperage
            // 
            this.amperage.AutoSize = true;
            this.amperage.Location = new System.Drawing.Point(153, 148);
            this.amperage.Name = "amperage";
            this.amperage.Size = new System.Drawing.Size(0, 17);
            this.amperage.TabIndex = 13;
            // 
            // diametr
            // 
            this.diametr.AutoSize = true;
            this.diametr.Location = new System.Drawing.Point(176, 349);
            this.diametr.Name = "diametr";
            this.diametr.Size = new System.Drawing.Size(0, 17);
            this.diametr.TabIndex = 14;
            // 
            // Count_amper
            // 
            this.Count_amper.Location = new System.Drawing.Point(299, 145);
            this.Count_amper.Name = "Count_amper";
            this.Count_amper.Size = new System.Drawing.Size(109, 38);
            this.Count_amper.TabIndex = 15;
            this.Count_amper.Text = "Розрахувати";
            this.Count_amper.UseVisualStyleBackColor = true;
            this.Count_amper.Click += new System.EventHandler(this.Count_amper_Click);
            // 
            // Count_diam
            // 
            this.Count_diam.Location = new System.Drawing.Point(287, 341);
            this.Count_diam.Name = "Count_diam";
            this.Count_diam.Size = new System.Drawing.Size(110, 32);
            this.Count_diam.TabIndex = 16;
            this.Count_diam.Text = "Розрахувати";
            this.Count_diam.UseVisualStyleBackColor = true;
            this.Count_diam.Click += new System.EventHandler(this.Count_diam_Click);
            // 
            // Small_diamtr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 423);
            this.Controls.Add(this.Count_diam);
            this.Controls.Add(this.Count_amper);
            this.Controls.Add(this.diametr);
            this.Controls.Add(this.amperage);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.diam);
            this.Controls.Add(this.material2);
            this.Controls.Add(this.material1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Small_diamtr";
            this.Text = "Small_diamtr";
            this.Load += new System.EventHandler(this.Small_diamtr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox material1;
        private System.Windows.Forms.ComboBox material2;
        private System.Windows.Forms.TextBox diam;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label amperage;
        private System.Windows.Forms.Label diametr;
        private System.Windows.Forms.Button Count_amper;
        private System.Windows.Forms.Button Count_diam;
    }
}