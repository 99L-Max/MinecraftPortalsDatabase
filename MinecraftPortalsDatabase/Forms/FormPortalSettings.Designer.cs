namespace MinecraftPortalsDatabase
{
    partial class FormPortalSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPortalSettings));
            this._numOverworldX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._numOverworldY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this._numOverworldZ = new System.Windows.Forms.NumericUpDown();
            this._txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._cmbBiomeOverworld = new System.Windows.Forms.ComboBox();
            this._btnApply = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._cmbBiomeNether = new System.Windows.Forms.ComboBox();
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this._numNetherZ = new System.Windows.Forms.NumericUpDown();
            this._numNetherY = new System.Windows.Forms.NumericUpDown();
            this._numNetherX = new System.Windows.Forms.NumericUpDown();
            this._chbNether = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this._chbOverworld = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this._numOverworldX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numOverworldY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numOverworldZ)).BeginInit();
            this._tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numNetherZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numNetherY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numNetherX)).BeginInit();
            this.SuspendLayout();
            // 
            // _numOverworldX
            // 
            this._numOverworldX.BackColor = System.Drawing.Color.DimGray;
            this._numOverworldX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._numOverworldX.Dock = System.Windows.Forms.DockStyle.Fill;
            this._numOverworldX.ForeColor = System.Drawing.Color.White;
            this._numOverworldX.Location = new System.Drawing.Point(105, 77);
            this._numOverworldX.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this._numOverworldX.Name = "_numOverworldX";
            this._numOverworldX.Size = new System.Drawing.Size(274, 35);
            this._numOverworldX.TabIndex = 0;
            this._numOverworldX.ThousandsSeparator = true;
            this._numOverworldX.ValueChanged += new System.EventHandler(this.OnNumericUpDownValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "X:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 49);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _numOverworldY
            // 
            this._numOverworldY.BackColor = System.Drawing.Color.DimGray;
            this._numOverworldY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._numOverworldY.Dock = System.Windows.Forms.DockStyle.Fill;
            this._numOverworldY.ForeColor = System.Drawing.Color.White;
            this._numOverworldY.Location = new System.Drawing.Point(105, 126);
            this._numOverworldY.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this._numOverworldY.Name = "_numOverworldY";
            this._numOverworldY.Size = new System.Drawing.Size(274, 35);
            this._numOverworldY.TabIndex = 2;
            this._numOverworldY.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 49);
            this.label3.TabIndex = 5;
            this.label3.Text = "Z:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _numOverworldZ
            // 
            this._numOverworldZ.BackColor = System.Drawing.Color.DimGray;
            this._numOverworldZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._numOverworldZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this._numOverworldZ.ForeColor = System.Drawing.Color.White;
            this._numOverworldZ.Location = new System.Drawing.Point(105, 175);
            this._numOverworldZ.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this._numOverworldZ.Name = "_numOverworldZ";
            this._numOverworldZ.Size = new System.Drawing.Size(274, 35);
            this._numOverworldZ.TabIndex = 4;
            // 
            // _txtName
            // 
            this._txtName.BackColor = System.Drawing.Color.Black;
            this._txtName.ForeColor = System.Drawing.Color.White;
            this._txtName.Location = new System.Drawing.Point(107, 7);
            this._txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(587, 35);
            this._txtName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 217);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 51);
            this.label6.TabIndex = 11;
            this.label6.Text = "Biome:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _cmbBiomeOverworld
            // 
            this._cmbBiomeOverworld.BackColor = System.Drawing.Color.DimGray;
            this._cmbBiomeOverworld.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbBiomeOverworld.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._cmbBiomeOverworld.ForeColor = System.Drawing.Color.White;
            this._cmbBiomeOverworld.FormattingEnabled = true;
            this._cmbBiomeOverworld.Location = new System.Drawing.Point(101, 221);
            this._cmbBiomeOverworld.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._cmbBiomeOverworld.Name = "_cmbBiomeOverworld";
            this._cmbBiomeOverworld.Size = new System.Drawing.Size(280, 37);
            this._cmbBiomeOverworld.TabIndex = 10;
            // 
            // _btnApply
            // 
            this._btnApply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnApply.BackgroundImage")));
            this._btnApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnApply.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._btnApply.FlatAppearance.BorderSize = 10;
            this._btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnApply.ForeColor = System.Drawing.Color.White;
            this._btnApply.Location = new System.Drawing.Point(15, 325);
            this._btnApply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._btnApply.Name = "_btnApply";
            this._btnApply.Size = new System.Drawing.Size(331, 46);
            this._btnApply.TabIndex = 12;
            this._btnApply.Text = "Apply";
            this._btnApply.UseVisualStyleBackColor = true;
            this._btnApply.Click += new System.EventHandler(this.OnApplyClick);
            // 
            // _btnCancel
            // 
            this._btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnCancel.BackgroundImage")));
            this._btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnCancel.ForeColor = System.Drawing.Color.White;
            this._btnCancel.Location = new System.Drawing.Point(364, 325);
            this._btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(331, 46);
            this._btnCancel.TabIndex = 13;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            // 
            // _cmbBiomeNether
            // 
            this._cmbBiomeNether.BackColor = System.Drawing.Color.DimGray;
            this._cmbBiomeNether.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbBiomeNether.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._cmbBiomeNether.ForeColor = System.Drawing.Color.White;
            this._cmbBiomeNether.FormattingEnabled = true;
            this._cmbBiomeNether.Location = new System.Drawing.Point(391, 221);
            this._cmbBiomeNether.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._cmbBiomeNether.Name = "_cmbBiomeNether";
            this._cmbBiomeNether.Size = new System.Drawing.Size(280, 37);
            this._cmbBiomeNether.TabIndex = 14;
            // 
            // _tableLayoutPanel
            // 
            this._tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this._tableLayoutPanel.ColumnCount = 3;
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tableLayoutPanel.Controls.Add(this.label7, 1, 0);
            this._tableLayoutPanel.Controls.Add(this._cmbBiomeOverworld, 1, 5);
            this._tableLayoutPanel.Controls.Add(this._cmbBiomeNether, 2, 5);
            this._tableLayoutPanel.Controls.Add(this._numOverworldZ, 1, 4);
            this._tableLayoutPanel.Controls.Add(this.label6, 0, 5);
            this._tableLayoutPanel.Controls.Add(this._numNetherZ, 2, 4);
            this._tableLayoutPanel.Controls.Add(this._numNetherY, 2, 3);
            this._tableLayoutPanel.Controls.Add(this._numOverworldY, 1, 3);
            this._tableLayoutPanel.Controls.Add(this._numNetherX, 2, 2);
            this._tableLayoutPanel.Controls.Add(this._numOverworldX, 1, 2);
            this._tableLayoutPanel.Controls.Add(this.label3, 0, 4);
            this._tableLayoutPanel.Controls.Add(this.label2, 0, 3);
            this._tableLayoutPanel.Controls.Add(this._chbNether, 2, 1);
            this._tableLayoutPanel.Controls.Add(this.label5, 2, 0);
            this._tableLayoutPanel.Controls.Add(this._chbOverworld, 1, 1);
            this._tableLayoutPanel.Controls.Add(this.label1, 0, 2);
            this._tableLayoutPanel.Location = new System.Drawing.Point(15, 50);
            this._tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._tableLayoutPanel.Name = "_tableLayoutPanel";
            this._tableLayoutPanel.RowCount = 6;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this._tableLayoutPanel.Size = new System.Drawing.Size(680, 268);
            this._tableLayoutPanel.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(101, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(282, 29);
            this.label7.TabIndex = 21;
            this.label7.Text = "Overworld";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _numNetherZ
            // 
            this._numNetherZ.BackColor = System.Drawing.Color.DimGray;
            this._numNetherZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._numNetherZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this._numNetherZ.ForeColor = System.Drawing.Color.White;
            this._numNetherZ.Location = new System.Drawing.Point(395, 175);
            this._numNetherZ.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this._numNetherZ.Name = "_numNetherZ";
            this._numNetherZ.Size = new System.Drawing.Size(280, 35);
            this._numNetherZ.TabIndex = 17;
            // 
            // _numNetherY
            // 
            this._numNetherY.BackColor = System.Drawing.Color.DimGray;
            this._numNetherY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._numNetherY.Dock = System.Windows.Forms.DockStyle.Fill;
            this._numNetherY.ForeColor = System.Drawing.Color.White;
            this._numNetherY.Location = new System.Drawing.Point(395, 126);
            this._numNetherY.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this._numNetherY.Maximum = new decimal(new int[] {
            319,
            0,
            0,
            0});
            this._numNetherY.Name = "_numNetherY";
            this._numNetherY.Size = new System.Drawing.Size(280, 35);
            this._numNetherY.TabIndex = 17;
            this._numNetherY.Value = new decimal(new int[] {
            127,
            0,
            0,
            0});
            // 
            // _numNetherX
            // 
            this._numNetherX.BackColor = System.Drawing.Color.DimGray;
            this._numNetherX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._numNetherX.Dock = System.Windows.Forms.DockStyle.Fill;
            this._numNetherX.ForeColor = System.Drawing.Color.White;
            this._numNetherX.Location = new System.Drawing.Point(395, 77);
            this._numNetherX.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this._numNetherX.Name = "_numNetherX";
            this._numNetherX.Size = new System.Drawing.Size(280, 35);
            this._numNetherX.TabIndex = 17;
            // 
            // _chbNether
            // 
            this._chbNether.AutoSize = true;
            this._chbNether.Checked = true;
            this._chbNether.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chbNether.Dock = System.Windows.Forms.DockStyle.Fill;
            this._chbNether.ForeColor = System.Drawing.Color.White;
            this._chbNether.Location = new System.Drawing.Point(391, 33);
            this._chbNether.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._chbNether.Name = "_chbNether";
            this._chbNether.Size = new System.Drawing.Size(288, 33);
            this._chbNether.TabIndex = 19;
            this._chbNether.Text = "(automatic search)";
            this._chbNether.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._chbNether.UseVisualStyleBackColor = true;
            this._chbNether.CheckedChanged += new System.EventHandler(this.OnNetherCheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(391, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "The Nether";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _chbOverworld
            // 
            this._chbOverworld.AutoSize = true;
            this._chbOverworld.Dock = System.Windows.Forms.DockStyle.Fill;
            this._chbOverworld.ForeColor = System.Drawing.Color.White;
            this._chbOverworld.Location = new System.Drawing.Point(101, 33);
            this._chbOverworld.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._chbOverworld.Name = "_chbOverworld";
            this._chbOverworld.Size = new System.Drawing.Size(282, 33);
            this._chbOverworld.TabIndex = 18;
            this._chbOverworld.Text = "(automatic search)";
            this._chbOverworld.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._chbOverworld.UseVisualStyleBackColor = true;
            this._chbOverworld.CheckedChanged += new System.EventHandler(this.OnOverworldCheckedChanged);
            // 
            // FormPortalSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MinecraftPortalsDatabase.Properties.Resources.Obsidian;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(714, 383);
            this.Controls.Add(this._tableLayoutPanel);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnApply);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._txtName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPortalSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portal data";
            ((System.ComponentModel.ISupportInitialize)(this._numOverworldX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numOverworldY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numOverworldZ)).EndInit();
            this._tableLayoutPanel.ResumeLayout(false);
            this._tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numNetherZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numNetherY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numNetherX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown _numOverworldX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown _numOverworldY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown _numOverworldZ;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox _cmbBiomeOverworld;
        private System.Windows.Forms.Button _btnApply;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.ComboBox _cmbBiomeNether;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
        private System.Windows.Forms.NumericUpDown _numNetherZ;
        private System.Windows.Forms.NumericUpDown _numNetherY;
        private System.Windows.Forms.NumericUpDown _numNetherX;
        private System.Windows.Forms.CheckBox _chbOverworld;
        private System.Windows.Forms.CheckBox _chbNether;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}