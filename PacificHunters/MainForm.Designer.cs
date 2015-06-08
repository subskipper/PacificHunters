namespace PacificHunters
{
    partial class Main
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
            this.mainMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // mainMapControl
            // 
            this.mainMapControl.AutoSize = true;
            this.mainMapControl.Bearing = 0F;
            this.mainMapControl.CanDragMap = true;
            this.mainMapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.mainMapControl.GrayScaleMode = false;
            this.mainMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mainMapControl.LevelsKeepInMemmory = 5;
            this.mainMapControl.Location = new System.Drawing.Point(0, 0);
            this.mainMapControl.MarkersEnabled = true;
            this.mainMapControl.MaxZoom = 2;
            this.mainMapControl.MinZoom = 2;
            this.mainMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mainMapControl.Name = "mainMapControl";
            this.mainMapControl.NegativeMode = false;
            this.mainMapControl.PolygonsEnabled = true;
            this.mainMapControl.RetryLoadTile = 0;
            this.mainMapControl.RoutesEnabled = true;
            this.mainMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mainMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mainMapControl.ShowTileGridLines = false;
            this.mainMapControl.Size = new System.Drawing.Size(1594, 810);
            this.mainMapControl.TabIndex = 0;
            this.mainMapControl.Zoom = 0D;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1594, 810);
            this.Controls.Add(this.mainMapControl);
            this.Name = "Main";
            this.Text = "Pacific Hunters";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl mainMapControl;
    }
}

