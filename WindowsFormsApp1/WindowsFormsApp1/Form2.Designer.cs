namespace WindowsFormsApp1
{
    partial class ifform
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
            this.numA = new System.Windows.Forms.Label();
            this.numB = new System.Windows.Forms.Label();
            this.numC = new System.Windows.Forms.Label();
            this.inA = new System.Windows.Forms.TextBox();
            this.inB = new System.Windows.Forms.TextBox();
            this.inC = new System.Windows.Forms.TextBox();
            this.Task = new System.Windows.Forms.Label();
            this.start1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numA
            // 
            this.numA.AutoSize = true;
            this.numA.Location = new System.Drawing.Point(12, 26);
            this.numA.Name = "numA";
            this.numA.Size = new System.Drawing.Size(74, 20);
            this.numA.TabIndex = 0;
            this.numA.Text = "Число 1:";
            // 
            // numB
            // 
            this.numB.AutoSize = true;
            this.numB.Location = new System.Drawing.Point(12, 68);
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(74, 20);
            this.numB.TabIndex = 1;
            this.numB.Text = "Число 2:";
            // 
            // numC
            // 
            this.numC.AutoSize = true;
            this.numC.Location = new System.Drawing.Point(12, 106);
            this.numC.Name = "numC";
            this.numC.Size = new System.Drawing.Size(74, 20);
            this.numC.TabIndex = 2;
            this.numC.Text = "Число 3:";
            // 
            // inA
            // 
            this.inA.Location = new System.Drawing.Point(104, 26);
            this.inA.Name = "inA";
            this.inA.Size = new System.Drawing.Size(100, 26);
            this.inA.TabIndex = 3;
            // 
            // inB
            // 
            this.inB.Location = new System.Drawing.Point(104, 68);
            this.inB.Name = "inB";
            this.inB.Size = new System.Drawing.Size(100, 26);
            this.inB.TabIndex = 4;
            // 
            // inC
            // 
            this.inC.Location = new System.Drawing.Point(104, 106);
            this.inC.Name = "inC";
            this.inC.Size = new System.Drawing.Size(100, 26);
            this.inC.TabIndex = 5;
            // 
            // Task
            // 
            this.Task.AutoSize = true;
            this.Task.Location = new System.Drawing.Point(254, 68);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(436, 20);
            this.Task.TabIndex = 6;
            this.Task.Text = "Найти сумму двух минимальных чисел из трех заданных";
            // 
            // start1
            // 
            this.start1.Location = new System.Drawing.Point(258, 263);
            this.start1.Name = "start1";
            this.start1.Size = new System.Drawing.Size(174, 32);
            this.start1.TabIndex = 7;
            this.start1.Text = "Найти";
            this.start1.UseVisualStyleBackColor = true;
            this.start1.Click += new System.EventHandler(this.start1_Click);
            // 
            // ifform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 384);
            this.Controls.Add(this.start1);
            this.Controls.Add(this.Task);
            this.Controls.Add(this.inC);
            this.Controls.Add(this.inB);
            this.Controls.Add(this.inA);
            this.Controls.Add(this.numC);
            this.Controls.Add(this.numB);
            this.Controls.Add(this.numA);
            this.Name = "ifform";
            this.Text = "if";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numA;
        private System.Windows.Forms.Label numB;
        private System.Windows.Forms.Label numC;
        private System.Windows.Forms.TextBox inA;
        private System.Windows.Forms.TextBox inB;
        private System.Windows.Forms.TextBox inC;
        private System.Windows.Forms.Label Task;
        private System.Windows.Forms.Button start1;
    }
}