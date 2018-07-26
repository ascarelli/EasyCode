namespace EasyCode
{
    partial class formProject
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.treeViewProjects = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dtgOperations = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOperations)).BeginInit();
            this.SuspendLayout();
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
            this.treeViewProjects.TabIndex = 4;
            this.treeViewProjects.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewProjects_AfterSelect);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 20);
            this.textBox1.TabIndex = 5;
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.White;
            this.menuStripMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(946, 24);
            this.menuStripMain.TabIndex = 6;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(311, 37);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Create Code";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(11, 78);
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
            this.splitContainer1.TabIndex = 5;
            // 
            // dtgOperations
            // 
            this.dtgOperations.AllowUserToAddRows = false;
            this.dtgOperations.AllowUserToDeleteRows = false;
            this.dtgOperations.AllowUserToOrderColumns = true;
            this.dtgOperations.BackgroundColor = System.Drawing.Color.DimGray;
            this.dtgOperations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgOperations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dtgOperations.TabIndex = 1;
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
            // btnNewProject
            // 
            this.btnNewProject.BackColor = System.Drawing.Color.Lime;
            this.btnNewProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewProject.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnNewProject.FlatAppearance.BorderSize = 0;
            this.btnNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProject.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProject.Location = new System.Drawing.Point(603, 37);
            this.btnNewProject.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(105, 35);
            this.btnNewProject.TabIndex = 7;
            this.btnNewProject.Text = "+ New Project";
            this.btnNewProject.UseVisualStyleBackColor = true;
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(718, 37);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "+ New Class";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(832, 37);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 35);
            this.button3.TabIndex = 9;
            this.button3.Text = "+ New Attribute";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // formProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(946, 550);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNewProject);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "formProject";
            this.Text = "Easy Code";
            this.Load += new System.EventHandler(this.formProject_Load);
            this.Shown += new System.EventHandler(this.formProject_Shown);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOperations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeViewProjects;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        public System.Windows.Forms.DataGridView dtgOperations;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

