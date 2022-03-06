
namespace Lesson_04._03._22
{
    partial class Form2
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
            this.onBut = new System.Windows.Forms.RadioButton();
            this.offBut = new System.Windows.Forms.RadioButton();
            this.okBut = new System.Windows.Forms.Button();
            this.cancBut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // onBut
            // 
            this.onBut.AutoSize = true;
            this.onBut.Location = new System.Drawing.Point(64, 52);
            this.onBut.Name = "onBut";
            this.onBut.Size = new System.Drawing.Size(54, 24);
            this.onBut.TabIndex = 0;
            this.onBut.TabStop = true;
            this.onBut.Text = "Вкл";
            this.onBut.UseVisualStyleBackColor = true;
            // 
            // offBut
            // 
            this.offBut.AutoSize = true;
            this.offBut.Location = new System.Drawing.Point(64, 100);
            this.offBut.Name = "offBut";
            this.offBut.Size = new System.Drawing.Size(65, 24);
            this.offBut.TabIndex = 1;
            this.offBut.TabStop = true;
            this.offBut.Text = "Выкл";
            this.offBut.UseVisualStyleBackColor = true;
            this.offBut.CheckedChanged += new System.EventHandler(this.offBut_CheckedChanged);
            // 
            // okBut
            // 
            this.okBut.Location = new System.Drawing.Point(12, 190);
            this.okBut.Name = "okBut";
            this.okBut.Size = new System.Drawing.Size(81, 29);
            this.okBut.TabIndex = 2;
            this.okBut.Text = "Ok";
            this.okBut.UseVisualStyleBackColor = true;
            this.okBut.Click += new System.EventHandler(this.okBut_Click);
            // 
            // cancBut
            // 
            this.cancBut.Location = new System.Drawing.Point(123, 190);
            this.cancBut.Name = "cancBut";
            this.cancBut.Size = new System.Drawing.Size(82, 29);
            this.cancBut.TabIndex = 3;
            this.cancBut.Text = "Отмена";
            this.cancBut.UseVisualStyleBackColor = true;
            this.cancBut.Click += new System.EventHandler(this.cancBut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.onBut);
            this.groupBox1.Controls.Add(this.offBut);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 166);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сделайте выбор";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 252);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancBut);
            this.Controls.Add(this.okBut);
            this.Name = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton onBut;
        private System.Windows.Forms.RadioButton offBut;
        private System.Windows.Forms.Button okBut;
        private System.Windows.Forms.Button cancBut;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}