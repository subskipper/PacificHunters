using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;

namespace PacificHunters
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            mainMapControl.MapProvider = GMapProviders.OpenStreetMap;//.OpenStreetMap;
            mainMapControl.Position = new PointLatLng(59.273960, 15.215193);
            mainMapControl.MinZoom = 0;
            mainMapControl.MaxZoom = 24;
            mainMapControl.Zoom = 9;

        }
    }
}
