namespace MinecraftPortalsDatabase
{
    partial class FormDatabasePortals
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatabasePortals));
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._btnSelectAnotherWorld = new System.Windows.Forms.Button();
            this._btnAdd = new System.Windows.Forms.Button();
            this._btnRemove = new System.Windows.Forms.Button();
            this._btnEdit = new System.Windows.Forms.Button();
            this._btnNearestPortal = new System.Windows.Forms.Button();
            this._btnClearFilters = new System.Windows.Forms.Button();
            this._btnMap = new System.Windows.Forms.Button();
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
            this._dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dataGridView.BackgroundColor = System.Drawing.Color.Black;
            this._dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this._dataGridView.EnableHeadersVisualStyles = false;
            this._dataGridView.Location = new System.Drawing.Point(15, 14);
            this._dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this._dataGridView.Name = "_dataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this._dataGridView.RowHeadersVisible = false;
            this._dataGridView.RowTemplate.Height = 35;
            this._dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dataGridView.Size = new System.Drawing.Size(853, 404);
            this._dataGridView.TabIndex = 0;
            this._dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnDataGridViewCellClick);
            this._dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnEditClick);
            this._dataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OnDataGridViewColumnHeaderMouseClick);
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
            this._tableLayoutPanel.Controls.Add(this._btnRemove, 2, 0);
            this._tableLayoutPanel.Controls.Add(this._btnEdit, 1, 0);
            this._tableLayoutPanel.Controls.Add(this._btnNearestPortal, 0, 1);
            this._tableLayoutPanel.Controls.Add(this._btnMap, 1, 1);
            this._tableLayoutPanel.Controls.Add(this._btnSelectAnotherWorld, 3, 0);
            this._tableLayoutPanel.Controls.Add(this._btnClearFilters, 2, 1);
            this._tableLayoutPanel.Location = new System.Drawing.Point(15, 426);
            this._tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this._tableLayoutPanel.Name = "_tableLayoutPanel";
            this._tableLayoutPanel.RowCount = 2;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanel.Size = new System.Drawing.Size(853, 121);
            this._tableLayoutPanel.TabIndex = 5;
            // 
            // _btnSelectAnotherWorld
            // 
            this._btnSelectAnotherWorld.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnSelectAnotherWorld.BackgroundImage")));
            this._btnSelectAnotherWorld.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnSelectAnotherWorld.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnSelectAnotherWorld.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnSelectAnotherWorld.ForeColor = System.Drawing.Color.White;
            this._btnSelectAnotherWorld.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSelectAnotherWorld.Location = new System.Drawing.Point(643, 4);
            this._btnSelectAnotherWorld.Margin = new System.Windows.Forms.Padding(4);
            this._btnSelectAnotherWorld.Name = "_btnSelectAnotherWorld";
            this._btnSelectAnotherWorld.Size = new System.Drawing.Size(206, 52);
            this._btnSelectAnotherWorld.TabIndex = 6;
            this._btnSelectAnotherWorld.Text = "Select another world";
            this._btnSelectAnotherWorld.UseVisualStyleBackColor = true;
            this._btnSelectAnotherWorld.Click += new System.EventHandler(this.OnSelectAnotherWorldClick);
            // 
            // _btnAdd
            // 
            this._btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnAdd.BackgroundImage")));
            this._btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnAdd.ForeColor = System.Drawing.Color.White;
            this._btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnAdd.Location = new System.Drawing.Point(4, 4);
            this._btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(205, 52);
            this._btnAdd.TabIndex = 1;
            this._btnAdd.Text = "Add";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this.OnAddClick);
            // 
            // _btnRemove
            // 
            this._btnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnRemove.BackgroundImage")));
            this._btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnRemove.ForeColor = System.Drawing.Color.White;
            this._btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnRemove.Location = new System.Drawing.Point(430, 4);
            this._btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this._btnRemove.Name = "_btnRemove";
            this._btnRemove.Size = new System.Drawing.Size(205, 52);
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
            this._btnEdit.Location = new System.Drawing.Point(217, 4);
            this._btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this._btnEdit.Name = "_btnEdit";
            this._btnEdit.Size = new System.Drawing.Size(205, 52);
            this._btnEdit.TabIndex = 4;
            this._btnEdit.Text = "Edit";
            this._btnEdit.UseVisualStyleBackColor = true;
            this._btnEdit.Click += new System.EventHandler(this.OnEditClick);
            // 
            // _btnNearestPortal
            // 
            this._btnNearestPortal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnNearestPortal.BackgroundImage")));
            this._btnNearestPortal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnNearestPortal.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnNearestPortal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnNearestPortal.ForeColor = System.Drawing.Color.White;
            this._btnNearestPortal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnNearestPortal.Location = new System.Drawing.Point(4, 64);
            this._btnNearestPortal.Margin = new System.Windows.Forms.Padding(4);
            this._btnNearestPortal.Name = "_btnNearestPortal";
            this._btnNearestPortal.Size = new System.Drawing.Size(205, 53);
            this._btnNearestPortal.TabIndex = 2;
            this._btnNearestPortal.Text = "The nearest portal";
            this._btnNearestPortal.UseVisualStyleBackColor = true;
            this._btnNearestPortal.Click += new System.EventHandler(this.OnNearestPortalClick);
            // 
            // _btnClearFilters
            // 
            this._btnClearFilters.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnClearFilters.BackgroundImage")));
            this._btnClearFilters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnClearFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnClearFilters.Enabled = false;
            this._btnClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnClearFilters.ForeColor = System.Drawing.Color.Red;
            this._btnClearFilters.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnClearFilters.Location = new System.Drawing.Point(430, 64);
            this._btnClearFilters.Margin = new System.Windows.Forms.Padding(4);
            this._btnClearFilters.Name = "_btnClearFilters";
            this._btnClearFilters.Size = new System.Drawing.Size(205, 53);
            this._btnClearFilters.TabIndex = 5;
            this._btnClearFilters.Text = "Clear the filters";
            this._btnClearFilters.UseVisualStyleBackColor = true;
            this._btnClearFilters.Click += new System.EventHandler(this.OnClearFiltersClick);
            // 
            // _btnMap
            // 
            this._btnMap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnMap.BackgroundImage")));
            this._btnMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnMap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnMap.ForeColor = System.Drawing.Color.White;
            this._btnMap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnMap.Location = new System.Drawing.Point(217, 64);
            this._btnMap.Margin = new System.Windows.Forms.Padding(4);
            this._btnMap.Name = "_btnMap";
            this._btnMap.Size = new System.Drawing.Size(205, 53);
            this._btnMap.TabIndex = 7;
            this._btnMap.Text = "Map";
            this._btnMap.UseVisualStyleBackColor = true;
            this._btnMap.Click += new System.EventHandler(this.OnMapClick);
            // 
            // FormDatabasePortals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this._tableLayoutPanel);
            this.Controls.Add(this._dataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FormDatabasePortals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Location of Portals";
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
        private System.Windows.Forms.Button _btnClearFilters;
        private System.Windows.Forms.Button _btnSelectAnotherWorld;
        private System.Windows.Forms.Button _btnMap;
    }
}

