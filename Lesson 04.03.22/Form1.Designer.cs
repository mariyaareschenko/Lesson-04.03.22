
namespace Lesson_04._03._22
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.link = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.Button();
            this.saveBut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.loading = new System.Windows.Forms.Button();
            this.studentTable = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.link);
            this.tabPage1.Controls.Add(this.settings);
            this.tabPage1.Controls.Add(this.saveBut);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Вкладка 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(92, 374);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(331, 20);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://www.youtube.com/watch?v=_E6RbwNtIEI";
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(14, 374);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(59, 20);
            this.link.TabIndex = 5;
            this.link.Text = "Ссылка";
            // 
            // settings
            // 
            this.settings.Location = new System.Drawing.Point(656, 365);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(94, 29);
            this.settings.TabIndex = 3;
            this.settings.Text = "Настройки";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // saveBut
            // 
            this.saveBut.Location = new System.Drawing.Point(415, 292);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(94, 29);
            this.saveBut.TabIndex = 2;
            this.saveBut.Text = "Сохранить";
            this.saveBut.UseVisualStyleBackColor = true;
            this.saveBut.Click += new System.EventHandler(this.saveBut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDescription);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.tbSurname);
            this.groupBox1.Controls.Add(this.description);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.surname);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 269);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(110, 93);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(258, 27);
            this.tbDescription.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(110, 60);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(258, 27);
            this.tbName.TabIndex = 4;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(110, 23);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(258, 27);
            this.tbSurname.TabIndex = 3;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(8, 92);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(79, 20);
            this.description.TabIndex = 2;
            this.description.Text = "Описание";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(8, 60);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(39, 20);
            this.name.TabIndex = 1;
            this.name.Text = "Имя";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(8, 23);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(73, 20);
            this.surname.TabIndex = 0;
            this.surname.Text = "Фамилия";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.loading);
            this.tabPage2.Controls.Add(this.studentTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Вкладка 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // loading
            // 
            this.loading.Location = new System.Drawing.Point(6, 288);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(94, 29);
            this.loading.TabIndex = 1;
            this.loading.Text = "Загрузить";
            this.loading.UseVisualStyleBackColor = true;
            // 
            // studentTable
            // 
            this.studentTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentTable.Location = new System.Drawing.Point(0, 0);
            this.studentTable.Name = "studentTable";
            this.studentTable.RowHeadersWidth = 51;
            this.studentTable.RowTemplate.Height = 29;
            this.studentTable.Size = new System.Drawing.Size(498, 245);
            this.studentTable.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 417);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "+";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label link;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button saveBut;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox tbDescription;
        public System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Button loading;
        private System.Windows.Forms.DataGridView studentTable;
    }
}

