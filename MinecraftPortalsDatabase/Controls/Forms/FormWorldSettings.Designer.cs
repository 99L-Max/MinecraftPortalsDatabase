namespace MinecraftPortalsDatabase
{
    partial class FormWorldSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorldSettings));
            this._txtName = new System.Windows.Forms.TextBox();
            this._btnApply = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._pbIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // _txtName
            // 
            this._txtName.BackColor = System.Drawing.Color.Black;
            this._txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._txtName.ForeColor = System.Drawing.Color.White;
            this._txtName.Location = new System.Drawing.Point(119, 28);
            this._txtName.Margin = new System.Windows.Forms.Padding(4);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(582, 62);
            this._txtName.TabIndex = 6;
            // 
            // _btnApply
            // 
            this._btnApply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnApply.BackgroundImage")));
            this._btnApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnApply.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._btnApply.FlatAppearance.BorderSize = 10;
            this._btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnApply.ForeColor = System.Drawing.Color.White;
            this._btnApply.Location = new System.Drawing.Point(12, 119);
            this._btnApply.Margin = new System.Windows.Forms.Padding(4);
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
            this._btnCancel.Location = new System.Drawing.Point(370, 119);
            this._btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(331, 46);
            this._btnCancel.TabIndex = 13;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            // 
            // _pbIcon
            // 
            this._pbIcon.BackColor = System.Drawing.Color.Transparent;
            this._pbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._pbIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._pbIcon.Image = global::MinecraftPortalsDatabase.Properties.Resources.Default_World_Icon;
            this._pbIcon.Location = new System.Drawing.Point(12, 12);
            this._pbIcon.Name = "_pbIcon";
            this._pbIcon.Size = new System.Drawing.Size(100, 100);
            this._pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._pbIcon.TabIndex = 14;
            this._pbIcon.TabStop = false;
            this._pbIcon.Click += new System.EventHandler(this.OnSelectIcon);
            this._pbIcon.Paint += new System.Windows.Forms.PaintEventHandler(this.OnIconPaint);
            this._pbIcon.MouseEnter += new System.EventHandler(this.OnIconMouseEnter);
            this._pbIcon.MouseLeave += new System.EventHandler(this.OnIconMouseLeave);
            // 
            // FormWorldSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MinecraftPortalsDatabase.Properties.Resources.Obsidian;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(714, 184);
            this.Controls.Add(this._pbIcon);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnApply);
            this.Controls.Add(this._txtName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWorldSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "World data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            ((System.ComponentModel.ISupportInitialize)(this._pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.Button _btnApply;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.PictureBox _pbIcon;
    }
}