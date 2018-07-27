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
            this.label4 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.chkNullable = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAttrName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpAttr = new System.Windows.Forms.GroupBox();
            this.btnAddAttr = new System.Windows.Forms.Button();
            this.dtgAttributes = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgClass = new System.Windows.Forms.DataGridView();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtPrecision = new System.Windows.Forms.TextBox();
            this.lblPrecision = new System.Windows.Forms.Label();
            this.lblScale = new System.Windows.Forms.Label();
            this.txtScale = new System.Windows.Forms.TextBox();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteClass = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Attributes = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassObjectType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nullable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnumDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteAttr = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecisionScale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.grpAttr.SuspendLayout();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tipo";
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "String",
            "Int",
            "Decimal",
            "Double",
            "DateTime"});
            this.cbxType.Location = new System.Drawing.Point(312, 44);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(189, 21);
            this.cbxType.TabIndex = 9;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // chkNullable
            // 
            this.chkNullable.AutoSize = true;
            this.chkNullable.Location = new System.Drawing.Point(516, 46);
            this.chkNullable.Name = "chkNullable";
            this.chkNullable.Size = new System.Drawing.Size(64, 17);
            this.chkNullable.TabIndex = 8;
            this.chkNullable.Text = "Nullable";
            this.chkNullable.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome";
            // 
            // txtAttrName
            // 
            this.txtAttrName.Location = new System.Drawing.Point(20, 44);
            this.txtAttrName.Name = "txtAttrName";
            this.txtAttrName.Size = new System.Drawing.Size(286, 20);
            this.txtAttrName.TabIndex = 4;
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
            // grpAttr
            // 
            this.grpAttr.Controls.Add(this.lblScale);
            this.grpAttr.Controls.Add(this.txtScale);
            this.grpAttr.Controls.Add(this.lblPrecision);
            this.grpAttr.Controls.Add(this.txtPrecision);
            this.grpAttr.Controls.Add(this.btnAddAttr);
            this.grpAttr.Controls.Add(this.dtgAttributes);
            this.grpAttr.Controls.Add(this.txtAttrName);
            this.grpAttr.Controls.Add(this.label3);
            this.grpAttr.Controls.Add(this.chkNullable);
            this.grpAttr.Controls.Add(this.label4);
            this.grpAttr.Controls.Add(this.cbxType);
            this.grpAttr.Location = new System.Drawing.Point(13, 506);
            this.grpAttr.Name = "grpAttr";
            this.grpAttr.Size = new System.Drawing.Size(804, 292);
            this.grpAttr.TabIndex = 14;
            this.grpAttr.TabStop = false;
            this.grpAttr.Text = "Atributos";
            // 
            // btnAddAttr
            // 
            this.btnAddAttr.Image = global::EasyCode.Properties.Resources.if_list_add_22x22;
            this.btnAddAttr.Location = new System.Drawing.Point(740, 29);
            this.btnAddAttr.Name = "btnAddAttr";
            this.btnAddAttr.Size = new System.Drawing.Size(43, 37);
            this.btnAddAttr.TabIndex = 10;
            this.btnAddAttr.UseVisualStyleBackColor = true;
            this.btnAddAttr.Click += new System.EventHandler(this.btnAddAttr_Click);
            // 
            // dtgAttributes
            // 
            this.dtgAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAttributes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Type,
            this.Nullable,
            this.EnumDescription,
            this.DeleteAttr,
            this.dataGridViewTextBoxColumn2,
            this.PrecisionScale,
            this._id});
            this.dtgAttributes.Location = new System.Drawing.Point(20, 71);
            this.dtgAttributes.MultiSelect = false;
            this.dtgAttributes.Name = "dtgAttributes";
            this.dtgAttributes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtgAttributes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgAttributes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAttributes.Size = new System.Drawing.Size(763, 214);
            this.dtgAttributes.TabIndex = 10;
            this.dtgAttributes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAttributes_CellContentClick);
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
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(20, 36);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(511, 20);
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
            this.btnAddClass.Image = global::EasyCode.Properties.Resources.if_list_add_22x22;
            this.btnAddClass.Location = new System.Drawing.Point(740, 22);
            this.btnAddClass.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(43, 37);
            this.btnAddClass.TabIndex = 9;
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
            // txtPrecision
            // 
            this.txtPrecision.Location = new System.Drawing.Point(586, 44);
            this.txtPrecision.Name = "txtPrecision";
            this.txtPrecision.Size = new System.Drawing.Size(43, 20);
            this.txtPrecision.TabIndex = 11;
            this.txtPrecision.Visible = false;
            // 
            // lblPrecision
            // 
            this.lblPrecision.AutoSize = true;
            this.lblPrecision.Location = new System.Drawing.Point(583, 28);
            this.lblPrecision.Name = "lblPrecision";
            this.lblPrecision.Size = new System.Drawing.Size(50, 13);
            this.lblPrecision.TabIndex = 12;
            this.lblPrecision.Text = "Precision";
            this.lblPrecision.Visible = false;
            // 
            // lblScale
            // 
            this.lblScale.AutoSize = true;
            this.lblScale.Location = new System.Drawing.Point(632, 28);
            this.lblScale.Name = "lblScale";
            this.lblScale.Size = new System.Drawing.Size(34, 13);
            this.lblScale.TabIndex = 14;
            this.lblScale.Text = "Scale";
            this.lblScale.Visible = false;
            // 
            // txtScale
            // 
            this.txtScale.Location = new System.Drawing.Point(635, 44);
            this.txtScale.Name = "txtScale";
            this.txtScale.Size = new System.Drawing.Size(44, 20);
            this.txtScale.TabIndex = 13;
            this.txtScale.Visible = false;
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "Name";
            this.ClassName.HeaderText = "Nome";
            this.ClassName.Name = "ClassName";
            this.ClassName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClassName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.Attributes.Text = "Add Atributos";
            this.Attributes.UseColumnTextForLinkValue = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "_id";
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Tipo";
            this.Type.Name = "Type";
            // 
            // Nullable
            // 
            this.Nullable.DataPropertyName = "Nullable";
            this.Nullable.HeaderText = "Nulo";
            this.Nullable.Name = "Nullable";
            // 
            // EnumDescription
            // 
            this.EnumDescription.DataPropertyName = "EnumDescription";
            this.EnumDescription.HeaderText = "Descrição Enum";
            this.EnumDescription.Name = "EnumDescription";
            // 
            // DeleteAttr
            // 
            this.DeleteAttr.HeaderText = "";
            this.DeleteAttr.Name = "DeleteAttr";
            this.DeleteAttr.Text = "Deletar";
            this.DeleteAttr.UseColumnTextForLinkValue = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ObjectType";
            this.dataGridViewTextBoxColumn2.HeaderText = "ObjectType";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // PrecisionScale
            // 
            this.PrecisionScale.DataPropertyName = "PrecisionScale";
            this.PrecisionScale.HeaderText = "PrecisionScale";
            this.PrecisionScale.Name = "PrecisionScale";
            this.PrecisionScale.Visible = false;
            // 
            // _id
            // 
            this._id.DataPropertyName = "_id";
            this._id.HeaderText = "ID";
            this._id.Name = "_id";
            this._id.Visible = false;
            // 
            // FormProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 803);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSaveProject);
            this.Controls.Add(this.grpAttr);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Criar Projeto";
            this.Load += new System.EventHandler(this.FormProject_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpAttr.ResumeLayout(false);
            this.grpAttr.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.CheckBox chkNullable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAttrName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpAttr;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgClass;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.DataGridView dtgAttributes;
        private System.Windows.Forms.Button btnAddAttr;
        private System.Windows.Forms.Label lblScale;
        private System.Windows.Forms.TextBox txtScale;
        private System.Windows.Forms.Label lblPrecision;
        private System.Windows.Forms.TextBox txtPrecision;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nullable;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnumDescription;
        private System.Windows.Forms.DataGridViewLinkColumn DeleteAttr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecisionScale;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewLinkColumn DeleteClass;
        private System.Windows.Forms.DataGridViewLinkColumn Attributes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassObjectType;
    }
}