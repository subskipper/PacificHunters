using System;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace PacificHunters
{
    public partial class Main : Form
    {
        private GMapOverlay _overlay = new GMapOverlay();

        public Main()
        {
            InitializeComponent();
            //Move all wiring to separate method. Going to be quite a bit here
            mainMapControl.MouseDoubleClick += OnMouseDoubleClick;

            //Config class?
            mainMapControl.MapProvider = GMapProviders.OpenStreetMap;
            //show it over Hawaii as a start. ComSubPac base 
            mainMapControl.Position = new PointLatLng(19.559790, -155.566406);
            mainMapControl.MinZoom = 0;
            mainMapControl.MaxZoom = 24;
            mainMapControl.Zoom = 6;
            mainMapControl.Overlays.Add(_overlay);

        }

        private void OnMouseDoubleClick(object sender, MouseEventArgs mouseEventArgs)
        {
            //Do nothing if it's the right mouse button
            if (mouseEventArgs.Button == MouseButtons.Right)
                return;

            base.OnMouseClick(mouseEventArgs);



            double longitude = mainMapControl.FromLocalToLatLng(mouseEventArgs.X, mouseEventArgs.Y).Lng;
            double latitude = mainMapControl.FromLocalToLatLng(mouseEventArgs.X, mouseEventArgs.Y).Lat;

            var marker = new GMarkerGoogle(new PointLatLng(latitude, longitude), GMarkerGoogleType.lightblue_dot);
            marker.ToolTipText = GetCoordsForMarker(longitude, latitude);
            marker.ToolTipMode = MarkerTooltipMode.Always;

            _overlay.Markers.Add(marker);

        }

        private string GetCoordsForMarker(double longitude, double latitude)
        {
            return string.Format("Long: {0} Lat: {1}", longitude, latitude);
        }
    }
}
