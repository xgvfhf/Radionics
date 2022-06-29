
namespace Radionics
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.resistor = new System.Windows.Forms.Button();
            this.condenser = new System.Windows.Forms.Button();
            this.fuse = new System.Windows.Forms.Button();
            this.inductance = new System.Windows.Forms.Button();
            this.tightness = new System.Windows.Forms.Button();
            this.smd = new System.Windows.Forms.RadioButton();
            this.normal = new System.Windows.Forms.RadioButton();
            this.ceramic = new System.Windows.Forms.RadioButton();
            this.tape = new System.Windows.Forms.RadioButton();
            this.small_diam = new System.Windows.Forms.RadioButton();
            this.big_diam = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resistor
            // 
            this.resistor.Location = new System.Drawing.Point(61, 83);
            this.resistor.Name = "resistor";
            this.resistor.Size = new System.Drawing.Size(111, 42);
            this.resistor.TabIndex = 0;
            this.resistor.Text = "Резистор";
            this.resistor.UseVisualStyleBackColor = true;
            this.resistor.Click += new System.EventHandler(this.resistor_Click);
            // 
            // condenser
            // 
            this.condenser.Location = new System.Drawing.Point(61, 135);
            this.condenser.Name = "condenser";
            this.condenser.Size = new System.Drawing.Size(111, 42);
            this.condenser.TabIndex = 1;
            this.condenser.Text = "Конденсатор";
            this.condenser.UseVisualStyleBackColor = true;
            this.condenser.Click += new System.EventHandler(this.condenser_Click);
            // 
            // fuse
            // 
            this.fuse.Location = new System.Drawing.Point(61, 188);
            this.fuse.Name = "fuse";
            this.fuse.Size = new System.Drawing.Size(111, 42);
            this.fuse.TabIndex = 2;
            this.fuse.Text = "Запобіжник";
            this.fuse.UseVisualStyleBackColor = true;
            this.fuse.Click += new System.EventHandler(this.fuse_Click);
            // 
            // inductance
            // 
            this.inductance.Location = new System.Drawing.Point(61, 249);
            this.inductance.Name = "inductance";
            this.inductance.Size = new System.Drawing.Size(111, 42);
            this.inductance.TabIndex = 3;
            this.inductance.Text = "Індуктивність";
            this.inductance.UseVisualStyleBackColor = true;
            this.inductance.Click += new System.EventHandler(this.inductance_Click);
            // 
            // tightness
            // 
            this.tightness.Location = new System.Drawing.Point(61, 307);
            this.tightness.Name = "tightness";
            this.tightness.Size = new System.Drawing.Size(117, 42);
            this.tightness.TabIndex = 4;
            this.tightness.Text = "Герметичність (IP)";
            this.tightness.UseVisualStyleBackColor = true;
            this.tightness.Click += new System.EventHandler(this.tightness_Click);
            // 
            // smd
            // 
            this.smd.AutoSize = true;
            this.smd.Location = new System.Drawing.Point(212, 95);
            this.smd.Name = "smd";
            this.smd.Size = new System.Drawing.Size(55, 21);
            this.smd.TabIndex = 5;
            this.smd.TabStop = true;
            this.smd.Text = "smd";
            this.smd.UseVisualStyleBackColor = true;
            // 
            // normal
            // 
            this.normal.AutoSize = true;
            this.normal.Location = new System.Drawing.Point(366, 94);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(99, 21);
            this.normal.TabIndex = 6;
            this.normal.TabStop = true;
            this.normal.Text = "звичайний";
            this.normal.UseVisualStyleBackColor = true;
            // 
            // ceramic
            // 
            this.ceramic.AutoSize = true;
            this.ceramic.Location = new System.Drawing.Point(212, 146);
            this.ceramic.Name = "ceramic";
            this.ceramic.Size = new System.Drawing.Size(104, 21);
            this.ceramic.TabIndex = 7;
            this.ceramic.TabStop = true;
            this.ceramic.Text = "керамічний";
            this.ceramic.UseVisualStyleBackColor = true;
            // 
            // tape
            // 
            this.tape.AutoSize = true;
            this.tape.Location = new System.Drawing.Point(366, 146);
            this.tape.Name = "tape";
            this.tape.Size = new System.Drawing.Size(109, 21);
            this.tape.TabIndex = 8;
            this.tape.TabStop = true;
            this.tape.Text = "плівчастний";
            this.tape.UseVisualStyleBackColor = true;
            // 
            // small_diam
            // 
            this.small_diam.AutoSize = true;
            this.small_diam.Location = new System.Drawing.Point(212, 199);
            this.small_diam.Name = "small_diam";
            this.small_diam.Size = new System.Drawing.Size(112, 21);
            this.small_diam.TabIndex = 9;
            this.small_diam.TabStop = true;
            this.small_diam.Text = "0.02 - 0.2 мм";
            this.small_diam.UseVisualStyleBackColor = true;
            // 
            // big_diam
            // 
            this.big_diam.AutoSize = true;
            this.big_diam.Location = new System.Drawing.Point(366, 199);
            this.big_diam.Name = "big_diam";
            this.big_diam.Size = new System.Drawing.Size(83, 21);
            this.big_diam.TabIndex = 10;
            this.big_diam.TabStop = true;
            this.big_diam.Text = "> 0.2 мм";
            this.big_diam.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(186, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "d:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(184, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Радіокомпоненти";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 399);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.big_diam);
            this.Controls.Add(this.small_diam);
            this.Controls.Add(this.tape);
            this.Controls.Add(this.ceramic);
            this.Controls.Add(this.normal);
            this.Controls.Add(this.smd);
            this.Controls.Add(this.tightness);
            this.Controls.Add(this.inductance);
            this.Controls.Add(this.fuse);
            this.Controls.Add(this.condenser);
            this.Controls.Add(this.resistor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resistor;
        private System.Windows.Forms.Button condenser;
        private System.Windows.Forms.Button fuse;
        private System.Windows.Forms.Button inductance;
        private System.Windows.Forms.Button tightness;
        private System.Windows.Forms.RadioButton smd;
        private System.Windows.Forms.RadioButton normal;
        private System.Windows.Forms.RadioButton ceramic;
        private System.Windows.Forms.RadioButton tape;
        private System.Windows.Forms.RadioButton small_diam;
        private System.Windows.Forms.RadioButton big_diam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

