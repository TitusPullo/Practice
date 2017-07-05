namespace Calc1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addition = new System.Windows.Forms.Button();
            this.substraction = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.power = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "first argument";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.Location = new System.Drawing.Point(20, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 22);
            this.textBox1.TabIndex = 1;
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(55, 109);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(227, 23);
            this.addition.TabIndex = 2;
            this.addition.Text = "addition";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.buttonClickTwoArg);
            // 
            // substraction
            // 
            this.substraction.Location = new System.Drawing.Point(378, 109);
            this.substraction.Name = "substraction";
            this.substraction.Size = new System.Drawing.Size(227, 23);
            this.substraction.TabIndex = 3;
            this.substraction.Text = "substraction";
            this.substraction.UseVisualStyleBackColor = true;
            this.substraction.Click += new System.EventHandler(this.buttonClickTwoArg);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(55, 148);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(227, 23);
            this.multiplication.TabIndex = 4;
            this.multiplication.Text = "multiplication";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.buttonClickTwoArg);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(378, 148);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(227, 23);
            this.division.TabIndex = 5;
            this.division.Text = "division";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.buttonClickTwoArg);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "second argument";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox2.Location = new System.Drawing.Point(324, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(334, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox3.Location = new System.Drawing.Point(20, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(638, 22);
            this.textBox3.TabIndex = 8;
            // 
            // power
            // 
            this.power.Location = new System.Drawing.Point(55, 188);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(227, 23);
            this.power.TabIndex = 9;
            this.power.Text = "power";
            this.power.UseVisualStyleBackColor = true;
            this.power.Click += new System.EventHandler(this.buttonClickOneArg);
            // 
            // sqrt
            // 
            this.sqrt.Location = new System.Drawing.Point(378, 187);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(227, 23);
            this.sqrt.TabIndex = 10;
            this.sqrt.Text = "sqrt";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.buttonClickOneArg);
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(55, 231);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(227, 23);
            this.sin.TabIndex = 11;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.buttonClickOneArg);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(378, 230);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(227, 23);
            this.cos.TabIndex = 12;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.buttonClickOneArg);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(670, 333);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.power);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.substraction);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button substraction;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button power;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button cos;
    }
}

