namespace MinecraftPortalsDatabase
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._btnAdd = new System.Windows.Forms.Button();
            this._btnNearestPortal = new System.Windows.Forms.Button();
            this._btnRemove = new System.Windows.Forms.Button();
            this._btnEdit = new System.Windows.Forms.Button();
            this.PortalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Biome_Overworld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Biome_Nether = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationOverworld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationNether = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this._tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _dataGridView
            // 
            this._dataGridView.AllowUserToAddRows = false;
            this._dataGridView.AllowUserToDeleteRows = false;
            this._dataGridView.AllowUserToResizeColumns = false;
            this._dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this._dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dataGridView.BackgroundColor = System.Drawing.Color.Gray;
            this._dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PortalName,
            this.Biome_Overworld,
            this.Biome_Nether,
            this.LocationOverworld,
            this.LocationNether});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this._dataGridView.EnableHeadersVisualStyles = false;
            this._dataGridView.Location = new System.Drawing.Point(12, 12);
            this._dataGridView.Name = "_dataGridView";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this._dataGridView.RowHeadersVisible = false;
            this._dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dataGridView.Size = new System.Drawing.Size(910, 54);
            this._dataGridView.TabIndex = 0;
            this._dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnDataGridViewCellClick);
            this._dataGridView.SelectionChanged += new System.EventHandler(this.OnDataGridViewSelectionChanged);
            // 
            // _tableLayoutPanel
            // 
            this._tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this._tableLayoutPanel.ColumnCount = 4;
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._tableLayoutPanel.Controls.Add(this._btnAdd, 0, 0);
            this._tableLayoutPanel.Controls.Add(this._btnNearestPortal, 3, 0);
            this._tableLayoutPanel.Controls.Add(this._btnRemove, 2, 0);
            this._tableLayoutPanel.Controls.Add(this._btnEdit, 1, 0);
            this._tableLayoutPanel.Location = new System.Drawing.Point(12, 402);
            this._tableLayoutPanel.Name = "_tableLayoutPanel";
            this._tableLayoutPanel.RowCount = 1;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel.Size = new System.Drawing.Size(910, 47);
            this._tableLayoutPanel.TabIndex = 5;
            // 
            // _btnAdd
            // 
            this._btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnAdd.BackgroundImage")));
            this._btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnAdd.ForeColor = System.Drawing.Color.White;
            this._btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnAdd.Location = new System.Drawing.Point(3, 3);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(221, 41);
            this._btnAdd.TabIndex = 1;
            this._btnAdd.Text = "Add";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this.OnAddClick);
            // 
            // _btnNearestPortal
            // 
            this._btnNearestPortal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnNearestPortal.BackgroundImage")));
            this._btnNearestPortal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnNearestPortal.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnNearestPortal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnNearestPortal.ForeColor = System.Drawing.Color.White;
            this._btnNearestPortal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnNearestPortal.Location = new System.Drawing.Point(684, 3);
            this._btnNearestPortal.Name = "_btnNearestPortal";
            this._btnNearestPortal.Size = new System.Drawing.Size(223, 41);
            this._btnNearestPortal.TabIndex = 2;
            this._btnNearestPortal.Text = "The nearest portal";
            this._btnNearestPortal.UseVisualStyleBackColor = true;
            this._btnNearestPortal.Click += new System.EventHandler(this.OnNearestPortalClick);
            // 
            // _btnRemove
            // 
            this._btnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnRemove.BackgroundImage")));
            this._btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnRemove.ForeColor = System.Drawing.Color.White;
            this._btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnRemove.Location = new System.Drawing.Point(457, 3);
            this._btnRemove.Name = "_btnRemove";
            this._btnRemove.Size = new System.Drawing.Size(221, 41);
            this._btnRemove.TabIndex = 3;
            this._btnRemove.Text = "Remove";
            this._btnRemove.UseVisualStyleBackColor = true;
            this._btnRemove.Click += new System.EventHandler(this.OnRemoveClick);
            // 
            // _btnEdit
            // 
            this._btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnEdit.BackgroundImage")));
            this._btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnEdit.ForeColor = System.Drawing.Color.White;
            this._btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnEdit.Location = new System.Drawing.Point(230, 3);
            this._btnEdit.Name = "_btnEdit";
            this._btnEdit.Size = new System.Drawing.Size(221, 41);
            this._btnEdit.TabIndex = 4;
            this._btnEdit.Text = "Edit";
            this._btnEdit.UseVisualStyleBackColor = true;
            this._btnEdit.Click += new System.EventHandler(this.OnEditClick);
            // 
            // PortalName
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PortalName.DefaultCellStyle = dataGridViewCellStyle3;
            this.PortalName.HeaderText = "Name";
            this.PortalName.Name = "PortalName";
            this.PortalName.ReadOnly = true;
            // 
            // Biome_Overworld
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Biome_Overworld.DefaultCellStyle = dataGridViewCellStyle4;
            this.Biome_Overworld.HeaderText = "Overworld Biome";
            this.Biome_Overworld.Name = "Biome_Overworld";
            this.Biome_Overworld.ReadOnly = true;
            this.Biome_Overworld.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Biome_Nether
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Biome_Nether.DefaultCellStyle = dataGridViewCellStyle5;
            this.Biome_Nether.HeaderText = "The Nether Biome";
            this.Biome_Nether.Name = "Biome_Nether";
            this.Biome_Nether.ReadOnly = true;
            this.Biome_Nether.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // LocationOverworld
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LocationOverworld.DefaultCellStyle = dataGridViewCellStyle6;
            this.LocationOverworld.HeaderText = "Overworld XYZ";
            this.LocationOverworld.Name = "LocationOverworld";
            this.LocationOverworld.ReadOnly = true;
            this.LocationOverworld.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // LocationNether
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LocationNether.DefaultCellStyle = dataGridViewCellStyle7;
            this.LocationNether.HeaderText = "The Nether XYZ";
            this.LocationNether.Name = "LocationNether";
            this.LocationNether.ReadOnly = true;
            this.LocationNether.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MinecraftPortalsDatabase.Properties.Resources.End_Portal;
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this._tableLayoutPanel);
            this.Controls.Add(this._dataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Location of Portals";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.SizeChanged += new System.EventHandler(this.OnFormSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this._tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.Button _btnNearestPortal;
        private System.Windows.Forms.Button _btnRemove;
        private System.Windows.Forms.Button _btnEdit;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PortalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Biome_Overworld;
        private System.Windows.Forms.DataGridViewTextBoxColumn Biome_Nether;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationOverworld;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationNether;
    }
}

