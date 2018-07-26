namespace EasyCode.Views
{
    partial class FormProject
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
            this.btnSaveProject = new System.Windows.Forms.Button();
            this.tabControlProject = new System.Windows.Forms.TabControl();
            this.tabPageProject = new System.Windows.Forms.TabPage();
            this.tabPageClass = new System.Windows.Forms.TabPage();
            this.tabPageAttr = new System.Windows.Forms.TabPage();
            this.txtProjectNameSpace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControlProject.SuspendLayout();
            this.tabPageProject.SuspendLayout();
            this.tabPageClass.SuspendLayout();
            this.tabPageAttr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveProject
            // 
            this.btnSaveProject.Location = new System.Drawing.Point(638, 458);
            this.btnSaveProject.Name = "btnSaveProject";
            this.btnSaveProject.Size = new System.Drawing.Size(75, 42);
            this.btnSaveProject.TabIndex = 1;
            this.btnSaveProject.Text = "Save";
            this.btnSaveProject.UseVisualStyleBackColor = true;
            this.btnSaveProject.Click += new System.EventHandler(this.btnSaveProject_Click);
            // 
            // tabControlProject
            // 
            this.tabControlProject.Controls.Add(this.tabPageProject);
            this.tabControlProject.Controls.Add(this.tabPageClass);
            this.tabControlProject.Controls.Add(this.tabPageAttr);
            this.tabControlProject.Location = new System.Drawing.Point(13, 13);
            this.tabControlProject.Name = "tabControlProject";
            this.tabControlProject.SelectedIndex = 0;
            this.tabControlProject.Size = new System.Drawing.Size(700, 443);
            this.tabControlProject.TabIndex = 2;
            // 
            // tabPageProject
            // 
            this.tabPageProject.Controls.Add(this.label1);
            this.tabPageProject.Controls.Add(this.txtProjectNameSpace);
            this.tabPageProject.Location = new System.Drawing.Point(4, 22);
            this.tabPageProject.Name = "tabPageProject";
            this.tabPageProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProject.Size = new System.Drawing.Size(692, 417);
            this.tabPageProject.TabIndex = 0;
            this.tabPageProject.Text = "Project";
            this.tabPageProject.UseVisualStyleBackColor = true;
            // 
            // tabPageClass
            // 
            this.tabPageClass.Controls.Add(this.label5);
            this.tabPageClass.Controls.Add(this.comboBox1);
            this.tabPageClass.Controls.Add(this.button3);
            this.tabPageClass.Controls.Add(this.dataGridView3);
            this.tabPageClass.Controls.Add(this.button1);
            this.tabPageClass.Controls.Add(this.dataGridView1);
            this.tabPageClass.Controls.Add(this.label2);
            this.tabPageClass.Controls.Add(this.textBox1);
            this.tabPageClass.Location = new System.Drawing.Point(4, 22);
            this.tabPageClass.Name = "tabPageClass";
            this.tabPageClass.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClass.Size = new System.Drawing.Size(692, 417);
            this.tabPageClass.TabIndex = 1;
            this.tabPageClass.Text = "Classes";
            this.tabPageClass.UseVisualStyleBackColor = true;
            // 
            // tabPageAttr
            // 
            this.tabPageAttr.Controls.Add(this.button2);
            this.tabPageAttr.Controls.Add(this.dataGridView2);
            this.tabPageAttr.Controls.Add(this.label4);
            this.tabPageAttr.Controls.Add(this.cbxType);
            this.tabPageAttr.Controls.Add(this.checkBox1);
            this.tabPageAttr.Controls.Add(this.label3);
            this.tabPageAttr.Controls.Add(this.textBox2);
            this.tabPageAttr.Location = new System.Drawing.Point(4, 22);
            this.tabPageAttr.Name = "tabPageAttr";
            this.tabPageAttr.Size = new System.Drawing.Size(692, 417);
            this.tabPageAttr.TabIndex = 2;
            this.tabPageAttr.Text = "Attributes";
            this.tabPageAttr.UseVisualStyleBackColor = true;
            // 
            // txtProjectNameSpace
            // 
            this.txtProjectNameSpace.Location = new System.Drawing.Point(9, 49);
            this.txtProjectNameSpace.Name = "txtProjectNameSpace";
            this.txtProjectNameSpace.Size = new System.Drawing.Size(420, 20);
            this.txtProjectNameSpace.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NameSpace";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(542, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(286, 20);
            this.textBox2.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(519, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Nullable";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "string",
            "Int",
            "decimal",
            "double",
            "DateTime"});
            this.cbxType.Location = new System.Drawing.Point(315, 33);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(189, 21);
            this.cbxType.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Type";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 215);
            this.dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(23, 59);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(652, 229);
            this.dataGridView2.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(600, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(21, 321);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(652, 81);
            this.dataGridView3.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(534, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Add Association";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0 .. *",
            "0 .. 1",
            "1 .. 0",
            "1 .. 1",
            "1 .. *",
            "* .. 0",
            "* .. 1"});
            this.comboBox1.Location = new System.Drawing.Point(397, 296);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Multiplicity:";
            // 
            // FormProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 510);
            this.Controls.Add(this.btnSaveProject);
            this.Controls.Add(this.tabControlProject);
            this.Name = "FormProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProject";
            this.Shown += new System.EventHandler(this.FormProject_Shown);
            this.tabControlProject.ResumeLayout(false);
            this.tabPageProject.ResumeLayout(false);
            this.tabPageProject.PerformLayout();
            this.tabPageClass.ResumeLayout(false);
            this.tabPageClass.PerformLayout();
            this.tabPageAttr.ResumeLayout(false);
            this.tabPageAttr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSaveProject;
        private System.Windows.Forms.TabControl tabControlProject;
        private System.Windows.Forms.TabPage tabPageProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProjectNameSpace;
        private System.Windows.Forms.TabPage tabPageClass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPageAttr;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}