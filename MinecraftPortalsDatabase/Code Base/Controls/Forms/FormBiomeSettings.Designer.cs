namespace MinecraftPortalsDatabase
{
    partial class FormBiomeSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBiomeSettings));
            this.label5 = new System.Windows.Forms.Label();
            this._cmbDimension = new System.Windows.Forms.ComboBox();
            this._txtInput = new System.Windows.Forms.TextBox();
            this._btnApply = new System.Windows.Forms.Button();
            this._btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._cmbBiome = new System.Windows.Forms.ComboBox();
            this._cmbAction = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 78);
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
            this._cmbDimension.Location = new System.Drawing.Point(160, 75);
            this._cmbDimension.Margin = new System.Windows.Forms.Padding(4);
            this._cmbDimension.Name = "_cmbDimension";
            this._cmbDimension.Size = new System.Drawing.Size(457, 37);
            this._cmbDimension.TabIndex = 12;
            this._cmbDimension.SelectedIndexChanged += new System.EventHandler(this.OnDimensionSelectedIndexChanged);
            // 
            // _txtInput
            // 
            this._txtInput.BackColor = System.Drawing.Color.Black;
            this._txtInput.ForeColor = System.Drawing.Color.White;
            this._txtInput.Location = new System.Drawing.Point(160, 139);
            this._txtInput.Margin = new System.Windows.Forms.Padding(4);
            this._txtInput.Multiline = true;
            this._txtInput.Name = "_txtInput";
            this._txtInput.Size = new System.Drawing.Size(458, 38);
            this._txtInput.TabIndex = 14;
            // 
            // _btnApply
            // 
            this._btnApply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnApply.BackgroundImage")));
            this._btnApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnApply.ForeColor = System.Drawing.Color.White;
            this._btnApply.Location = new System.Drawing.Point(16, 202);
            this._btnApply.Margin = new System.Windows.Forms.Padding(4);
            this._btnApply.Name = "_btnApply";
            this._btnApply.Size = new System.Drawing.Size(293, 44);
            this._btnApply.TabIndex = 15;
            this._btnApply.Text = "Apply";
            this._btnApply.UseVisualStyleBackColor = true;
            this._btnApply.Click += new System.EventHandler(this.OnApplyClick);
            // 
            // _btnClose
            // 
            this._btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnClose.BackgroundImage")));
            this._btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnClose.ForeColor = System.Drawing.Color.White;
            this._btnClose.Location = new System.Drawing.Point(325, 202);
            this._btnClose.Margin = new System.Windows.Forms.Padding(4);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(293, 44);
            this._btnClose.TabIndex = 16;
            this._btnClose.Text = "Close";
            this._btnClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Biome:";
            // 
            // _cmbBiome
            // 
            this._cmbBiome.BackColor = System.Drawing.Color.DimGray;
            this._cmbBiome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbBiome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._cmbBiome.ForeColor = System.Drawing.Color.White;
            this._cmbBiome.FormattingEnabled = true;
            this._cmbBiome.IntegralHeight = false;
            this._cmbBiome.Location = new System.Drawing.Point(161, 139);
            this._cmbBiome.Margin = new System.Windows.Forms.Padding(4);
            this._cmbBiome.Name = "_cmbBiome";
            this._cmbBiome.Size = new System.Drawing.Size(457, 37);
            this._cmbBiome.TabIndex = 18;
            // 
            // _cmbAction
            // 
            this._cmbAction.BackColor = System.Drawing.Color.DimGray;
            this._cmbAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbAction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._cmbAction.ForeColor = System.Drawing.Color.White;
            this._cmbAction.FormattingEnabled = true;
            this._cmbAction.Location = new System.Drawing.Point(160, 13);
            this._cmbAction.Margin = new System.Windows.Forms.Padding(4);
            this._cmbAction.Name = "_cmbAction";
            this._cmbAction.Size = new System.Drawing.Size(457, 37);
            this._cmbAction.TabIndex = 19;
            this._cmbAction.SelectedIndexChanged += new System.EventHandler(this.OnActionSelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Action:";
            // 
            // FormBiomeSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MinecraftPortalsDatabase.Properties.Resources.End_Portal;
            this.CancelButton = this._btnClose;
            this.ClientSize = new System.Drawing.Size(630, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._cmbAction);
            this.Controls.Add(this._cmbBiome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(this._btnApply);
            this.Controls.Add(this._txtInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._cmbDimension);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBiomeSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biome Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox _cmbDimension;
        private System.Windows.Forms.TextBox _txtInput;
        private System.Windows.Forms.Button _btnApply;
        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _cmbBiome;
        private System.Windows.Forms.ComboBox _cmbAction;
        private System.Windows.Forms.Label label2;
    }
}