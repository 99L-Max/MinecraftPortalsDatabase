namespace MinecraftPortalsDatabase
{
    partial class FormNearestPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNearestPortal));
            this.label3 = new System.Windows.Forms.Label();
            this._numZ = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this._numY = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this._numX = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this._cmbDimension = new System.Windows.Forms.ComboBox();
            this._txtResult = new System.Windows.Forms.TextBox();
            this._btnFind = new System.Windows.Forms.Button();
            this._btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._numZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numX)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(426, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Z:";
            // 
            // _numZ
            // 
            this._numZ.BackColor = System.Drawing.Color.DimGray;
            this._numZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._numZ.ForeColor = System.Drawing.Color.White;
            this._numZ.Location = new System.Drawing.Point(462, 64);
            this._numZ.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this._numZ.Name = "_numZ";
            this._numZ.Size = new System.Drawing.Size(153, 35);
            this._numZ.TabIndex = 10;
            this._numZ.ValueChanged += new System.EventHandler(this.OnLocationChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(218, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Y:";
            // 
            // _numY
            // 
            this._numY.BackColor = System.Drawing.Color.DimGray;
            this._numY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._numY.ForeColor = System.Drawing.Color.White;
            this._numY.Location = new System.Drawing.Point(262, 64);
            this._numY.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this._numY.Name = "_numY";
            this._numY.Size = new System.Drawing.Size(153, 35);
            this._numY.TabIndex = 8;
            this._numY.ValueChanged += new System.EventHandler(this.OnLocationChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "X:";
            // 
            // _numX
            // 
            this._numX.BackColor = System.Drawing.Color.DimGray;
            this._numX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._numX.ForeColor = System.Drawing.Color.White;
            this._numX.Location = new System.Drawing.Point(53, 64);
            this._numX.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this._numX.Maximum = new decimal(new int[] {
            30000000,
            0,
            0,
            0});
            this._numX.Minimum = new decimal(new int[] {
            30000000,
            0,
            0,
            -2147483648});
            this._numX.Name = "_numX";
            this._numX.Size = new System.Drawing.Size(153, 35);
            this._numX.TabIndex = 6;
            this._numX.ValueChanged += new System.EventHandler(this.OnLocationChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dimension:";
            // 
            // _cmbDimension
            // 
            this._cmbDimension.BackColor = System.Drawing.Color.DimGray;
            this._cmbDimension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbDimension.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._cmbDimension.ForeColor = System.Drawing.Color.White;
            this._cmbDimension.FormattingEnabled = true;
            this._cmbDimension.Location = new System.Drawing.Point(157, 14);
            this._cmbDimension.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._cmbDimension.Name = "_cmbDimension";
            this._cmbDimension.Size = new System.Drawing.Size(457, 37);
            this._cmbDimension.TabIndex = 12;
            this._cmbDimension.SelectedIndexChanged += new System.EventHandler(this.OnLocationChanged);
            // 
            // _txtResult
            // 
            this._txtResult.BackColor = System.Drawing.Color.Black;
            this._txtResult.ForeColor = System.Drawing.Color.White;
            this._txtResult.Location = new System.Drawing.Point(20, 110);
            this._txtResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._txtResult.Multiline = true;
            this._txtResult.Name = "_txtResult";
            this._txtResult.ReadOnly = true;
            this._txtResult.Size = new System.Drawing.Size(593, 120);
            this._txtResult.TabIndex = 14;
            // 
            // _btnFind
            // 
            this._btnFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnFind.BackgroundImage")));
            this._btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnFind.ForeColor = System.Drawing.Color.White;
            this._btnFind.Location = new System.Drawing.Point(20, 234);
            this._btnFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._btnFind.Name = "_btnFind";
            this._btnFind.Size = new System.Drawing.Size(293, 44);
            this._btnFind.TabIndex = 15;
            this._btnFind.Text = "Find";
            this._btnFind.UseVisualStyleBackColor = true;
            this._btnFind.Click += new System.EventHandler(this.OnFindClick);
            // 
            // _btnClose
            // 
            this._btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnClose.BackgroundImage")));
            this._btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnClose.ForeColor = System.Drawing.Color.White;
            this._btnClose.Location = new System.Drawing.Point(322, 234);
            this._btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(293, 44);
            this._btnClose.TabIndex = 16;
            this._btnClose.Text = "Close";
            this._btnClose.UseVisualStyleBackColor = true;
            // 
            // FormNearestPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MinecraftPortalsDatabase.Properties.Resources.End_Portal;
            this.CancelButton = this._btnClose;
            this.ClientSize = new System.Drawing.Size(630, 292);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(this._btnFind);
            this.Controls.Add(this._txtResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._cmbDimension);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._numZ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._numY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._numX);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNearestPortal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The nearest portal";
            ((System.ComponentModel.ISupportInitialize)(this._numZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown _numZ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown _numY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown _numX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox _cmbDimension;
        private System.Windows.Forms.TextBox _txtResult;
        private System.Windows.Forms.Button _btnFind;
        private System.Windows.Forms.Button _btnClose;
    }
}