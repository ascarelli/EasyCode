namespace EasyCode.Views
{
    partial class FormSolution
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgOperations = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.treeViewProjects = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOperations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgOperations
            // 
            this.dtgOperations.AllowUserToAddRows = false;
            this.dtgOperations.AllowUserToDeleteRows = false;
            this.dtgOperations.AllowUserToOrderColumns = true;
            this.dtgOperations.BackgroundColor = System.Drawing.Color.DimGray;
            this.dtgOperations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgOperations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgOperations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOperations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.dtgOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgOperations.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgOperations.Location = new System.Drawing.Point(0, 0);
            this.dtgOperations.Margin = new System.Windows.Forms.Padding(0);
            this.dtgOperations.Name = "dtgOperations";
            this.dtgOperations.ReadOnly = true;
            this.dtgOperations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtgOperations.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dtgOperations.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgOperations.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgOperations.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PaleGoldenrod;
            this.dtgOperations.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgOperations.Size = new System.Drawing.Size(630, 465);
            this.dtgOperations.TabIndex = 2;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // treeViewProjects
            // 
            this.treeViewProjects.BackColor = System.Drawing.Color.Black;
            this.treeViewProjects.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewProjects.ForeColor = System.Drawing.Color.Lime;
            this.treeViewProjects.LineColor = System.Drawing.Color.Lime;
            this.treeViewProjects.Location = new System.Drawing.Point(0, 0);
            this.treeViewProjects.Margin = new System.Windows.Forms.Padding(0);
            this.treeViewProjects.Name = "treeViewProjects";
            this.treeViewProjects.Size = new System.Drawing.Size(293, 465);
            this.treeViewProjects.TabIndex = 5;
            this.treeViewProjects.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewProjects_AfterSelect);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 20);
            this.textBox1.TabIndex = 6;
            // 
            // btnNewProject
            // 
            this.btnNewProject.BackColor = System.Drawing.Color.Lime;
            this.btnNewProject.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnNewProject.FlatAppearance.BorderSize = 0;
            this.btnNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProject.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProject.Location = new System.Drawing.Point(837, 17);
            this.btnNewProject.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(105, 35);
            this.btnNewProject.TabIndex = 7;
            this.btnNewProject.Text = "Novo Projeto";
            this.btnNewProject.UseVisualStyleBackColor = false;
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 55);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewProjects);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtgOperations);
            this.splitContainer1.Size = new System.Drawing.Size(930, 465);
            this.splitContainer1.SplitterDistance = 296;
            this.splitContainer1.TabIndex = 8;
            // 
            // FormSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(957, 528);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnNewProject);
            this.Controls.Add(this.textBox1);
            this.Name = "FormSolution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSolution";
            this.Load += new System.EventHandler(this.FormSolution_Load);
            this.Shown += new System.EventHandler(this.FormSolution_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOperations)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dtgOperations;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.TreeView treeViewProjects;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}