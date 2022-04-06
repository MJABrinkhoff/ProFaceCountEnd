namespace ProFaceCountEnd
{
    partial class LocationCreateForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LbNameLocation = new System.Windows.Forms.Label();
            this.TbNameLocation = new System.Windows.Forms.TextBox();
            this.LbMaxPersonsLocation = new System.Windows.Forms.Label();
            this.TbMaxPersonsLocation = new System.Windows.Forms.TextBox();
            this.BtnCreateLocation = new System.Windows.Forms.Button();
            this.DGLocation = new System.Windows.Forms.DataGridView();
            this.LbHeaderLocation = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxPersons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGLocation)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbNameLocation
            // 
            this.LbNameLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbNameLocation.AutoSize = true;
            this.LbNameLocation.Location = new System.Drawing.Point(10, 17);
            this.LbNameLocation.Name = "LbNameLocation";
            this.LbNameLocation.Size = new System.Drawing.Size(84, 28);
            this.LbNameLocation.TabIndex = 0;
            this.LbNameLocation.Text = "Name";
            // 
            // TbNameLocation
            // 
            this.TbNameLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbNameLocation.Location = new System.Drawing.Point(74, 14);
            this.TbNameLocation.Name = "TbNameLocation";
            this.TbNameLocation.Size = new System.Drawing.Size(100, 37);
            this.TbNameLocation.TabIndex = 1;
            this.TbNameLocation.TextChanged += new System.EventHandler(this.TbNameLocation_TextChanged);
            // 
            // LbMaxPersonsLocation
            // 
            this.LbMaxPersonsLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbMaxPersonsLocation.AutoSize = true;
            this.LbMaxPersonsLocation.Location = new System.Drawing.Point(197, 17);
            this.LbMaxPersonsLocation.Name = "LbMaxPersonsLocation";
            this.LbMaxPersonsLocation.Size = new System.Drawing.Size(160, 28);
            this.LbMaxPersonsLocation.TabIndex = 2;
            this.LbMaxPersonsLocation.Text = "Max persons";
            // 
            // TbMaxPersonsLocation
            // 
            this.TbMaxPersonsLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbMaxPersonsLocation.Location = new System.Drawing.Point(308, 14);
            this.TbMaxPersonsLocation.Name = "TbMaxPersonsLocation";
            this.TbMaxPersonsLocation.Size = new System.Drawing.Size(100, 37);
            this.TbMaxPersonsLocation.TabIndex = 3;
            // 
            // BtnCreateLocation
            // 
            this.BtnCreateLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCreateLocation.Location = new System.Drawing.Point(446, 6);
            this.BtnCreateLocation.Name = "BtnCreateLocation";
            this.BtnCreateLocation.Size = new System.Drawing.Size(100, 40);
            this.BtnCreateLocation.TabIndex = 4;
            this.BtnCreateLocation.Text = "Add";
            this.BtnCreateLocation.UseVisualStyleBackColor = true;
            this.BtnCreateLocation.Click += new System.EventHandler(this.BtnCreateLocation_Click);
            // 
            // DGLocation
            // 
            this.DGLocation.AllowUserToResizeColumns = false;
            this.DGLocation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGLocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.name,
            this.MaxPersons,
            this.Edit,
            this.Delete});
            this.DGLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGLocation.Location = new System.Drawing.Point(0, 0);
            this.DGLocation.Name = "DGLocation";
            this.DGLocation.RowHeadersVisible = false;
            this.DGLocation.RowHeadersWidth = 62;
            this.DGLocation.Size = new System.Drawing.Size(730, 382);
            this.DGLocation.TabIndex = 5;
            this.DGLocation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGLocation_CellContentClick);
            // 
            // LbHeaderLocation
            // 
            this.LbHeaderLocation.AutoSize = true;
            this.LbHeaderLocation.Location = new System.Drawing.Point(22, 19);
            this.LbHeaderLocation.Name = "LbHeaderLocation";
            this.LbHeaderLocation.Size = new System.Drawing.Size(118, 28);
            this.LbHeaderLocation.TabIndex = 6;
            this.LbHeaderLocation.Text = "Location ";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            // 
            // MaxPersons
            // 
            this.MaxPersons.DataPropertyName = "MaxPersons";
            this.MaxPersons.HeaderText = "Max persons";
            this.MaxPersons.MinimumWidth = 8;
            this.MaxPersons.Name = "MaxPersons";
            // 
            // Edit
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Edit.DefaultCellStyle = dataGridViewCellStyle1;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.HeaderText = "";
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LbHeaderLocation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 70);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DGLocation);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(730, 382);
            this.panel3.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.LbNameLocation);
            this.panel1.Controls.Add(this.TbNameLocation);
            this.panel1.Controls.Add(this.BtnCreateLocation);
            this.panel1.Controls.Add(this.LbMaxPersonsLocation);
            this.panel1.Controls.Add(this.TbMaxPersonsLocation);
            this.panel1.Location = new System.Drawing.Point(0, 458);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 60);
            this.panel1.TabIndex = 7;
            // 
            // LocationCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 530);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LocationCreateForm";
            this.Text = "LocationCreateForm";
            this.Load += new System.EventHandler(this.LocationCreateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGLocation)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LbNameLocation;
        private System.Windows.Forms.TextBox TbNameLocation;
        private System.Windows.Forms.Label LbMaxPersonsLocation;
        private System.Windows.Forms.TextBox TbMaxPersonsLocation;
        private System.Windows.Forms.Button BtnCreateLocation;
        private System.Windows.Forms.DataGridView DGLocation;
        private System.Windows.Forms.Label LbHeaderLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxPersons;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
    }
}