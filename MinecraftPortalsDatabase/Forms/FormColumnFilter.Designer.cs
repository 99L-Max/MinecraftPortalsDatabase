namespace MinecraftPortalsDatabase.Forms
{
    partial class FormColumnFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormColumnFilter));
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnCancel
            // 
            this._btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnCancel.BackgroundImage")));
            this._btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnCancel.ForeColor = System.Drawing.Color.White;
            this._btnCancel.Location = new System.Drawing.Point(184, 257);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(162, 38);
            this._btnCancel.TabIndex = 15;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            // 
            // _btnApply
            // 
            this._btnApply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnApply.BackgroundImage")));
            this._btnApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnApply.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._btnApply.FlatAppearance.BorderSize = 10;
            this._btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnApply.ForeColor = System.Drawing.Color.White;
            this._btnApply.Location = new System.Drawing.Point(12, 257);
            this._btnApply.Name = "_btnApply";
            this._btnApply.Size = new System.Drawing.Size(162, 38);
            this._btnApply.TabIndex = 14;
            this._btnApply.Text = "Apply";
            this._btnApply.UseVisualStyleBackColor = true;
            // 
            // FormColumnFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 307);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnApply);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormColumnFilter";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter by value";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnApply;
    }
}