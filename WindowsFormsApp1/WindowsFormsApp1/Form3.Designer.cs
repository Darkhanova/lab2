namespace WindowsFormsApp1
{
    partial class forform
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
            this.fortask = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.manual = new System.Windows.Forms.Label();
            this.Rand = new System.Windows.Forms.Label();
            this.butmanual = new System.Windows.Forms.Button();
            this.butrand = new System.Windows.Forms.Button();
            this.resule = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.restaskfor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fortask
            // 
            this.fortask.AutoSize = true;
            this.fortask.Location = new System.Drawing.Point(12, 9);
            this.fortask.Name = "fortask";
            this.fortask.Size = new System.Drawing.Size(785, 20);
            this.fortask.TabIndex = 0;
            this.fortask.Text = "Дана последовательность различных чисел. Найти два наибольших и два наименьших ее" +
    " элемента.";
            this.fortask.Click += new System.EventHandler(this.label1_Click);
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(36, 59);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(100, 26);
            this.length.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Длина последовательности";
            // 
            // manual
            // 
            this.manual.AutoSize = true;
            this.manual.Location = new System.Drawing.Point(36, 105);
            this.manual.Name = "manual";
            this.manual.Size = new System.Drawing.Size(156, 20);
            this.manual.TabIndex = 3;
            this.manual.Text = "Ручное заполнение";
            // 
            // Rand
            // 
            this.Rand.AutoSize = true;
            this.Rand.Location = new System.Drawing.Point(36, 146);
            this.Rand.Name = "Rand";
            this.Rand.Size = new System.Drawing.Size(189, 20);
            this.Rand.TabIndex = 4;
            this.Rand.Text = "Рандомное заполнение";
            // 
            // butmanual
            // 
            this.butmanual.Location = new System.Drawing.Point(261, 99);
            this.butmanual.Name = "butmanual";
            this.butmanual.Size = new System.Drawing.Size(93, 29);
            this.butmanual.TabIndex = 5;
            this.butmanual.Text = "Задать";
            this.butmanual.UseVisualStyleBackColor = true;
            this.butmanual.Click += new System.EventHandler(this.butmanual_Click);
            // 
            // butrand
            // 
            this.butrand.Location = new System.Drawing.Point(261, 141);
            this.butrand.Name = "butrand";
            this.butrand.Size = new System.Drawing.Size(93, 31);
            this.butrand.TabIndex = 6;
            this.butrand.Text = "Задать";
            this.butrand.UseVisualStyleBackColor = true;
            this.butrand.Click += new System.EventHandler(this.butrand_Click);
            // 
            // resule
            // 
            this.resule.Location = new System.Drawing.Point(385, 105);
            this.resule.Multiline = true;
            this.resule.Name = "resule";
            this.resule.Size = new System.Drawing.Size(390, 266);
            this.resule.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // restaskfor
            // 
            this.restaskfor.Location = new System.Drawing.Point(133, 245);
            this.restaskfor.Name = "restaskfor";
            this.restaskfor.Size = new System.Drawing.Size(92, 32);
            this.restaskfor.TabIndex = 9;
            this.restaskfor.Text = "Решить";
            this.restaskfor.UseVisualStyleBackColor = true;
            this.restaskfor.Click += new System.EventHandler(this.restaskfor_Click);
            // 
            // forform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.restaskfor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resule);
            this.Controls.Add(this.butrand);
            this.Controls.Add(this.butmanual);
            this.Controls.Add(this.Rand);
            this.Controls.Add(this.manual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.length);
            this.Controls.Add(this.fortask);
            this.Name = "forform";
            this.Text = "for";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fortask;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label manual;
        private System.Windows.Forms.Label Rand;
        private System.Windows.Forms.Button butmanual;
        private System.Windows.Forms.Button butrand;
        private System.Windows.Forms.TextBox resule;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button restaskfor;
    }
}