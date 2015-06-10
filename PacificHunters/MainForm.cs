using System.Drawing;
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
        //This will be our sub eventually
        private GMarkerCross _subCross;

        public Main()
        {
            InitializeComponent();
            //Move all wiring to separate method. Going to be quite a bit here
            mainMapControl.MouseDoubleClick += OnMouseDoubleClick;
            KeyDown += new KeyEventHandler(MainForm_KeyDown);

            //Config class?
            mainMapControl.MapProvider = GMapProviders.GoogleTerrainMap;
            //show it over Hawaii as a start. ComSubPac base 
            //Use area to define the area we show on the map.
            mainMapControl.MapProvider.Area = new RectLatLng(new PointLatLng(52.067274, 131.395380),
                new SizeLatLng(new PointLatLng()));

            
            //mainMapControl.Position = new PointLatLng(19.559790, -155.566406);
            mainMapControl.MinZoom = 0;
            mainMapControl.MaxZoom = 24;
            mainMapControl.Zoom = 6;
            mainMapControl.Overlays.Add(_overlay);

            //A Simulated sub. Will be a proper sub in due time.
            _subCross = new GMarkerCross(new PointLatLng(19.559790, -155.566406));
            _overlay.Markers.Add(_subCross);
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

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                MessageBox.Show("Left!");
            }
            else if (e.KeyCode == Keys.D)
            {
                MessageBox.Show("Right!");
            }
            else if (e.KeyCode == Keys.W)
            {
                MessageBox.Show("Up!");
            }
            else if (e.KeyCode == Keys.S)
            {
                MessageBox.Show("Down!");
            }
        }

        private string GetCoordsForMarker(double longitude, double latitude)
        {
            return string.Format("Long: {0} Lat: {1}", longitude, latitude);
        }
    }
}
