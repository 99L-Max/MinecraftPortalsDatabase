namespace MinecraftPortalsDatabase
{
    partial class Map
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

                if (disposing)
                    foreach (var p in _points)
                        p.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map));
            this._labelLocationCursor = new System.Windows.Forms.Label();
            this._btnZoomIn = new System.Windows.Forms.Button();
            this._btnZoomOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _labelLocationCursor
            // 
            this._labelLocationCursor.AutoSize = true;
            this._labelLocationCursor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._labelLocationCursor.ForeColor = System.Drawing.Color.White;
            this._labelLocationCursor.Location = new System.Drawing.Point(0, 476);
            this._labelLocationCursor.Name = "_labelLocationCursor";
            this._labelLocationCursor.Size = new System.Drawing.Size(200, 24);
            this._labelLocationCursor.TabIndex = 0;
            this._labelLocationCursor.Text = "xx xxx xxx; xx xxx xxx";
            // 
            // _btnZoomIn
            // 
            this._btnZoomIn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._btnZoomIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnZoomIn.BackgroundImage")));
            this._btnZoomIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnZoomIn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._btnZoomIn.FlatAppearance.BorderSize = 10;
            this._btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnZoomIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnZoomIn.ForeColor = System.Drawing.Color.White;
            this._btnZoomIn.Location = new System.Drawing.Point(450, 200);
            this._btnZoomIn.Margin = new System.Windows.Forms.Padding(4);
            this._btnZoomIn.Name = "_btnZoomIn";
            this._btnZoomIn.Size = new System.Drawing.Size(50, 50);
            this._btnZoomIn.TabIndex = 15;
            this._btnZoomIn.Text = "+";
            this._btnZoomIn.UseVisualStyleBackColor = true;
            this._btnZoomIn.Click += new System.EventHandler(this.OnZoomInClick);
            // 
            // _btnZoomOut
            // 
            this._btnZoomOut.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._btnZoomOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnZoomOut.BackgroundImage")));
            this._btnZoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnZoomOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._btnZoomOut.FlatAppearance.BorderSize = 10;
            this._btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnZoomOut.ForeColor = System.Drawing.Color.White;
            this._btnZoomOut.Location = new System.Drawing.Point(450, 250);
            this._btnZoomOut.Margin = new System.Windows.Forms.Padding(4);
            this._btnZoomOut.Name = "_btnZoomOut";
            this._btnZoomOut.Size = new System.Drawing.Size(50, 50);
            this._btnZoomOut.TabIndex = 16;
            this._btnZoomOut.Text = "-";
            this._btnZoomOut.UseVisualStyleBackColor = true;
            this._btnZoomOut.Click += new System.EventHandler(this.OnZoomOutClick);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this._btnZoomOut);
            this.Controls.Add(this._btnZoomIn);
            this.Controls.Add(this._labelLocationCursor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Map";
            this.Size = new System.Drawing.Size(500, 500);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.OnMouseWheel);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelLocationCursor;
        private System.Windows.Forms.Button _btnZoomIn;
        private System.Windows.Forms.Button _btnZoomOut;
    }
}
