namespace MinecraftPortalsDatabase
{
    partial class FormDatabaseWorlds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatabaseWorlds));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._btnOpen = new System.Windows.Forms.Button();
            this._btnRemove = new System.Windows.Forms.Button();
            this._btnEdit = new System.Windows.Forms.Button();
            this._btnAdd = new System.Windows.Forms.Button();
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this.Worlds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _tableLayoutPanel
            // 
            this._tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this._tableLayoutPanel.ColumnCount = 4;
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._tableLayoutPanel.Controls.Add(this._btnOpen, 0, 0);
            this._tableLayoutPanel.Controls.Add(this._btnRemove, 3, 0);
            this._tableLayoutPanel.Controls.Add(this._btnEdit, 2, 0);
            this._tableLayoutPanel.Controls.Add(this._btnAdd, 1, 0);
            this._tableLayoutPanel.Location = new System.Drawing.Point(15, 244);
            this._tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this._tableLayoutPanel.Name = "_tableLayoutPanel";
            this._tableLayoutPanel.RowCount = 1;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel.Size = new System.Drawing.Size(585, 57);
            this._tableLayoutPanel.TabIndex = 6;
            // 
            // _btnOpen
            // 
            this._btnOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnOpen.BackgroundImage")));
            this._btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnOpen.ForeColor = System.Drawing.Color.White;
            this._btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnOpen.Location = new System.Drawing.Point(4, 4);
            this._btnOpen.Margin = new System.Windows.Forms.Padding(4);
            this._btnOpen.Name = "_btnOpen";
            this._btnOpen.Size = new System.Drawing.Size(138, 49);
            this._btnOpen.TabIndex = 5;
            this._btnOpen.Text = "Open";
            this._btnOpen.UseVisualStyleBackColor = true;
            this._btnOpen.Click += new System.EventHandler(this.OnOpenClick);
            // 
            // _btnRemove
            // 
            this._btnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnRemove.BackgroundImage")));
            this._btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnRemove.ForeColor = System.Drawing.Color.White;
            this._btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnRemove.Location = new System.Drawing.Point(442, 4);
            this._btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this._btnRemove.Name = "_btnRemove";
            this._btnRemove.Size = new System.Drawing.Size(139, 49);
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
            this._btnEdit.Location = new System.Drawing.Point(296, 4);
            this._btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this._btnEdit.Name = "_btnEdit";
            this._btnEdit.Size = new System.Drawing.Size(138, 49);
            this._btnEdit.TabIndex = 4;
            this._btnEdit.Text = "Edit";
            this._btnEdit.UseVisualStyleBackColor = true;
            this._btnEdit.Click += new System.EventHandler(this.OnEditClick);
            // 
            // _btnAdd
            // 
            this._btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnAdd.BackgroundImage")));
            this._btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnAdd.ForeColor = System.Drawing.Color.White;
            this._btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnAdd.Location = new System.Drawing.Point(150, 4);
            this._btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(138, 49);
            this._btnAdd.TabIndex = 1;
            this._btnAdd.Text = "Add";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this.OnAddClick);
            // 
            // _dataGridView
            // 
            this._dataGridView.AllowUserToAddRows = false;
            this._dataGridView.AllowUserToDeleteRows = false;
            this._dataGridView.AllowUserToResizeColumns = false;
            this._dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this._dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this._dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dataGridView.BackgroundColor = System.Drawing.Color.Gray;
            this._dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Worlds});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this._dataGridView.EnableHeadersVisualStyles = false;
            this._dataGridView.Location = new System.Drawing.Point(15, 14);
            this._dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this._dataGridView.MultiSelect = false;
            this._dataGridView.Name = "_dataGridView";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this._dataGridView.RowHeadersVisible = false;
            this._dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dataGridView.Size = new System.Drawing.Size(585, 222);
            this._dataGridView.TabIndex = 7;
            this._dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnDataGridViewCellClick);
            this._dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnOpenClick);
            this._dataGridView.SelectionChanged += new System.EventHandler(this.OnDataGridViewSelectionChanged);
            // 
            // Worlds
            // 
            this.Worlds.HeaderText = "Worlds";
            this.Worlds.Name = "Worlds";
            this.Worlds.ReadOnly = true;
            // 
            // FormDatabaseWorlds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MinecraftPortalsDatabase.Properties.Resources.Obsidian;
            this.ClientSize = new System.Drawing.Size(616, 315);
            this.Controls.Add(this._dataGridView);
            this.Controls.Add(this._tableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MinimumSize = new System.Drawing.Size(632, 354);
            this.Name = "FormDatabaseWorlds";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choosing the world";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this._tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.Button _btnRemove;
        private System.Windows.Forms.Button _btnEdit;
        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.Button _btnOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Worlds;
    }
}