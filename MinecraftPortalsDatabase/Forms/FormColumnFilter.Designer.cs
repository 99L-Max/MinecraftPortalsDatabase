namespace MinecraftPortalsDatabase
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
            this._btnClose = new System.Windows.Forms.Button();
            this._btnFilter = new System.Windows.Forms.Button();
            this._checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // _btnClose
            // 
            this._btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnClose.BackgroundImage")));
            this._btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnClose.ForeColor = System.Drawing.Color.White;
            this._btnClose.Location = new System.Drawing.Point(184, 238);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(162, 38);
            this._btnClose.TabIndex = 15;
            this._btnClose.Text = "Close";
            this._btnClose.UseVisualStyleBackColor = true;
            // 
            // _btnFilter
            // 
            this._btnFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnFilter.BackgroundImage")));
            this._btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._btnFilter.FlatAppearance.BorderSize = 10;
            this._btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnFilter.ForeColor = System.Drawing.Color.White;
            this._btnFilter.Location = new System.Drawing.Point(12, 238);
            this._btnFilter.Name = "_btnFilter";
            this._btnFilter.Size = new System.Drawing.Size(162, 38);
            this._btnFilter.TabIndex = 14;
            this._btnFilter.Text = "Filter";
            this._btnFilter.UseVisualStyleBackColor = true;
            this._btnFilter.Click += new System.EventHandler(this.OnFilterClick);
            // 
            // _checkedListBox
            // 
            this._checkedListBox.BackColor = System.Drawing.Color.Black;
            this._checkedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._checkedListBox.ForeColor = System.Drawing.Color.White;
            this._checkedListBox.FormattingEnabled = true;
            this._checkedListBox.Items.AddRange(new object[] {
            "All"});
            this._checkedListBox.Location = new System.Drawing.Point(12, 12);
            this._checkedListBox.Name = "_checkedListBox";
            this._checkedListBox.Size = new System.Drawing.Size(334, 216);
            this._checkedListBox.TabIndex = 16;
            this._checkedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.OnCheckedListBoxItemCheck);
            // 
            // FormColumnFilter
            // 
            this.AcceptButton = this._btnFilter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this._btnClose;
            this.ClientSize = new System.Drawing.Size(358, 284);
            this.Controls.Add(this._checkedListBox);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(this._btnFilter);
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
        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.Button _btnFilter;
        private System.Windows.Forms.CheckedListBox _checkedListBox;
    }
}