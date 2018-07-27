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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProjectNameSpace = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgAttributes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewLinkColumn2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgClass = new System.Windows.Forms.DataGridView();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddClass = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DeleteClass = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Attributes = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassObjectType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAttributes)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClass)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveProject
            // 
            this.btnSaveProject.BackColor = System.Drawing.Color.LightBlue;
            this.btnSaveProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProject.Location = new System.Drawing.Point(759, 12);
            this.btnSaveProject.Name = "btnSaveProject";
            this.btnSaveProject.Size = new System.Drawing.Size(58, 40);
            this.btnSaveProject.TabIndex = 1;
            this.btnSaveProject.Text = "Save";
            this.btnSaveProject.UseVisualStyleBackColor = false;
            this.btnSaveProject.Click += new System.EventHandler(this.btnSaveProject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NameSpace";
            // 
            // txtProjectNameSpace
            // 
            this.txtProjectNameSpace.Location = new System.Drawing.Point(20, 36);
            this.txtProjectNameSpace.Name = "txtProjectNameSpace";
            this.txtProjectNameSpace.Size = new System.Drawing.Size(763, 20);
            this.txtProjectNameSpace.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(708, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Type";
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
            this.cbxType.Location = new System.Drawing.Point(312, 28);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(189, 21);
            this.cbxType.TabIndex = 9;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(516, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Nullable";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(20, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(286, 20);
            this.textBox2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProjectNameSpace);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 68);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projeto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgAttributes);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbxType);
            this.groupBox2.Location = new System.Drawing.Point(13, 506);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 275);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atributos";
            // 
            // dtgAttributes
            // 
            this.dtgAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAttributes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewLinkColumn1,
            this.dataGridViewLinkColumn2,
            this.dataGridViewTextBoxColumn2});
            this.dtgAttributes.Location = new System.Drawing.Point(20, 55);
            this.dtgAttributes.MultiSelect = false;
            this.dtgAttributes.Name = "dtgAttributes";
            this.dtgAttributes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtgAttributes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgAttributes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAttributes.Size = new System.Drawing.Size(763, 214);
            this.dtgAttributes.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewLinkColumn1
            // 
            this.dataGridViewLinkColumn1.HeaderText = "";
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.Text = "Editar";
            this.dataGridViewLinkColumn1.UseColumnTextForLinkValue = true;
            // 
            // dataGridViewLinkColumn2
            // 
            this.dataGridViewLinkColumn2.HeaderText = "";
            this.dataGridViewLinkColumn2.Name = "dataGridViewLinkColumn2";
            this.dataGridViewLinkColumn2.Text = "Deletar";
            this.dataGridViewLinkColumn2.UseColumnTextForLinkValue = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ObjectType";
            this.dataGridViewTextBoxColumn2.HeaderText = "ObjectType";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgClass);
            this.groupBox3.Controls.Add(this.txtClass);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnAddClass);
            this.groupBox3.Location = new System.Drawing.Point(13, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(804, 354);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Classe";
            // 
            // dtgClass
            // 
            this.dtgClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassName,
            this.AddClass,
            this.DeleteClass,
            this.Attributes,
            this.Id,
            this.ClassObjectType});
            this.dtgClass.Location = new System.Drawing.Point(20, 62);
            this.dtgClass.MultiSelect = false;
            this.dtgClass.Name = "dtgClass";
            this.dtgClass.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtgClass.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgClass.Size = new System.Drawing.Size(763, 286);
            this.dtgClass.TabIndex = 8;
            this.dtgClass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClass_CellContentClick);
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "Name";
            this.ClassName.HeaderText = "Nome";
            this.ClassName.Name = "ClassName";
            this.ClassName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClassName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AddClass
            // 
            this.AddClass.HeaderText = "";
            this.AddClass.Name = "AddClass";
            this.AddClass.Text = "Editar";
            this.AddClass.UseColumnTextForLinkValue = true;
            // 
            // DeleteClass
            // 
            this.DeleteClass.HeaderText = "";
            this.DeleteClass.Name = "DeleteClass";
            this.DeleteClass.Text = "Deletar";
            this.DeleteClass.UseColumnTextForLinkValue = true;
            // 
            // Attributes
            // 
            this.Attributes.HeaderText = "";
            this.Attributes.Name = "Attributes";
            this.Attributes.Text = "Atributos";
            this.Attributes.UseColumnTextForLinkValue = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // ClassObjectType
            // 
            this.ClassObjectType.DataPropertyName = "ObjectType";
            this.ClassObjectType.HeaderText = "ObjectType";
            this.ClassObjectType.Name = "ClassObjectType";
            this.ClassObjectType.Visible = false;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(20, 36);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(432, 20);
            this.txtClass.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(458, 34);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(75, 23);
            this.btnAddClass.TabIndex = 9;
            this.btnAddClass.Text = "Add";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(694, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 40);
            this.button3.TabIndex = 16;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // FormProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 790);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSaveProject);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Criar Projeto";
            this.Shown += new System.EventHandler(this.FormProject_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAttributes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSaveProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProjectNameSpace;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgClass;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.DataGridView dtgAttributes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewLinkColumn AddClass;
        private System.Windows.Forms.DataGridViewLinkColumn DeleteClass;
        private System.Windows.Forms.DataGridViewLinkColumn Attributes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassObjectType;
    }
}