using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsPresentation;
using System;
using GMap.NET.WindowsForms.Markers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusPark
{
    public partial class Marchroutes : Form
    {
        List<marker> Markers;
        private bool flag = false;
        public Marchroutes()
        {
            InitializeComponent();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
           // gMapControl1.lo
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache; //выбор подгрузки карты – онлайн или из ресурсов
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance; //какой провайдер карт используется (в нашем случае гугл) 
            gMapControl1.MinZoom = 3; //минимальный зум
            gMapControl1.MaxZoom = 16; //максимальный зум
            gMapControl1.CanDragMap = true; //можно дли двигать саму карту
            gMapControl1.DragButton = MouseButtons.Left; //кнопка перемещения карты
            gMapControl1.ShowCenter = false; //крестик в центре
            gMapControl1.ShowTileGridLines= false; //хз))
        }

        private void gMapControl1_OnMapZoomChanged()
        {
            if(!flag)
            {
                flag= true;
                gMapControl1.Position = new GMap.NET.PointLatLng(55.7522, 37.6156);
                gMapControl1.Zoom = 10;
            }
        }

        public void ChoosingNumOfMarchrouteComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            ChoosingNumOfMarchrouteComboBox.Items.Clear();
            DataTable table = DataBase.SelectRequestExecute("SELECT RouteNumber FROM BRoute;");
            foreach(DataRow i in table.Rows)
            {
                ChoosingNumOfMarchrouteComboBox.Items.Add(i["RouteNumber"].ToString());
            }
        }
        private void Sort(List<marker> markers)
        {
            for(int i =0;i<markers.Count;++i)
            {
                for(int j = 0;j<markers.Count-1;++j)
                {
                    if (markers[j].PointNumber > markers[j+1].PointNumber)
                    {
                        marker temp = markers[j];
                        markers[j] = markers[j+1];
                        markers[j+1] = temp;
                    }
                }
            }
        }
        private void ChoosingNumOfMarchrouteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             Markers = DataBase.ConvertToList<marker>
                (DataBase.SelectRequestExecute($"SELECT PointName,PointNumber,Lng,Lat FROM POINTS WHERE RouteNumber = {Convert.ToInt32(ChoosingNumOfMarchrouteComboBox.SelectedItem)}"));
            Sort(Markers);
            CreateOverlays();
            foreach(var overlay in gMapControl1.Overlays)
                overlay.IsVisibile = true;
        }
        private void CreateOverlays()
        {
            List<PointLatLng>points= new List<PointLatLng>();
            GMarkerGoogleType type = GMarkerGoogleType.red;
            GMapOverlay gMapOverlayRoute = new GMapOverlay("Route");
            GMapOverlay gMapOverlayMarkers = new GMapOverlay("Markers");
            foreach(marker marker in Markers)
            {
                PointLatLng Position = new PointLatLng(marker.Lng, marker.Lat);
                points.Add(Position);
                GMarkerGoogle m = new GMarkerGoogle(Position, type);
                gMapOverlayMarkers.Markers.Add(m);
            }
            GMap.NET.WindowsForms.GMapRoute route = new GMap.NET.WindowsForms.GMapRoute(points,"маршрут");
            route.Stroke=new Pen(Color.Red, 3);
            gMapOverlayRoute.Routes.Add(route);
            gMapControl1.Overlays.Add(gMapOverlayMarkers);
            gMapControl1.Overlays.Add(gMapOverlayRoute);
        }
    }

    public partial class marker //выбор маршрута, сделать sql запросы для функции SetLoc, где снаружи будет выюираться только номер маршрута автобуса, а внутри уде выстраиваться иерархия маркеров
    {
        public string PointName { get; set; }
        public int PointNumber { get; set; }
        public double Lng { get; set; }
        public double Lat { get; set; }

    }
}


           /* gMapControl1.MinZoom = 2; //минимальный зум
            gMapControl1.MaxZoom = 16; //максимальный зум
            gMapControl1.Zoom = 4; // какой используется зум при открытии
            gMapControl1.Position = new GMap.NET.PointLatLng(66.4169575018027, 94.25025752215694);// точка в центре карты при открытии (центр России)
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter; // как приближает (просто в центр карты или по положению мыши)
            gMapControl1.CanDragMap = true; // перетаскивание карты мышью
            gMapControl1.DragButton = MouseButtons.Left; // какой кнопкой осуществляется перетаскивание
            gMapControl1.ShowCenter = false; //показывать или скрывать красный крестик в центре
            gMapControl1.ShowTileGridLines = false; //показывать или скрывать тайлы*/
