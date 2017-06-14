using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Maps.MapControl.WPF;
using System.Reflection;
using System.Xml.Serialization;
using System.IO;

namespace Metro_Navigation
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Station> metroStations = new List<Station>();
        MapPolyline routePolyline = new MapPolyline();

        public MainWindow()
        {
            InitializeComponent();
            metroStations = GetDeserializeStations();
            DrawMap(metroStations);
        }

        private List<Station> GetDeserializeStations()
        {
            List<Station> stations = new List<Station>();
            try
            {
                using (FileStream fs = new FileStream(@"..\..\Stations.xml", FileMode.Open))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Station>));
                    stations = (List<Station>)ser.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {

            }

            return stations;
        }

        public void DrawLine(Station firstStation, Station secondStation)
        {
            // code finded in https://msdn.microsoft.com/ru-ru/library/hh868034.aspx
            MapPolyline polyline = new MapPolyline();
            polyline.StrokeThickness = 3;
            polyline.Opacity = 0.7;
            polyline.Locations = new LocationCollection() {
                    new Location(firstStation.Longitude, firstStation.Latitude), 
                    new Location(secondStation.Longitude, secondStation.Latitude)
                };

            if (firstStation.BrunchColor == secondStation.BrunchColor)
            {
                polyline.Stroke = new SolidColorBrush(firstStation.BrunchColor);
            }
            else
            {
                polyline.Stroke = new SolidColorBrush(Colors.Gray);
            }

            myMap.Children.Add(polyline);
        }

        public void DrawMarker(Station station)
        {
            // code finded in https://msdn.microsoft.com/ru-ru/library/hh868034.aspx
            // The pushpin to add to the map.
            Pushpin pin = new Pushpin();
            pin.Opacity = 0.8;
            pin.Location = new Location(station.Longitude, station.Latitude);
            pin.ToolTip = station.Name;
            

            if (station.BrunchColor == Colors.Blue)
            {
                pin.Template = Application.Current.Resources["PushPinBlueTemplate"] as ControlTemplate;
            }
            if (station.BrunchColor == Colors.Red)
            {
                pin.Template = Application.Current.Resources["PushPinRedTemplate"] as ControlTemplate;
            }
            if (station.BrunchColor == Colors.Green)
            {
                pin.Template = Application.Current.Resources["PushPinGreenTemplate"] as ControlTemplate;
            }

            // Adds the pushpin to the map.
            myMap.Children.Add(pin);
        }

        public void DrawMap(List<Station> metroStations)
        {
            List<Station> stations = GetCopyListStations(metroStations);
            Station neighborStation;

            foreach (var station in stations)
            {
                DrawMarker(station);

                if (station.NeighborStationId != null)
                {
                    foreach (var neighborStationId in station.NeighborStationId)
                    {
                        neighborStation = stations.Where(s => s.Id == neighborStationId).First();
                        DrawLine(station, neighborStation);

                        //delete drowing line
                        neighborStation.NeighborStationId.Remove(station.Id);
                    }
                }
            }
        }

        public List<Station> GetShortestRoute(List<Station> stationsList, Station startStation, Station finishStation)
        {
            // totalRoute - shortest route from station to station
            // B - node predecessor in the shortest path
            // A[v] - the shortest distance from startStation to v
            // X - visited nodes
            // currentStation - current node
            // neighborStation,newLenght, minValue - support variables
            List<Station> totalRoute = new List<Station>();
            Dictionary<string, Station> B = new Dictionary<string, Station>();
            Dictionary<string, double> A = new Dictionary<string, double>();
            List<Station> X = new List<Station>();
            Station neighborStation = new Station();
            double newLenght;
            double minValue;

            // set data first station
            Station currentStation = startStation;
            currentStation.IsVisited = true;
            A[currentStation.Id] = 0;
            X.Add(startStation);

            while (X.Count != stationsList.Count)  // While X does not have all the vertices
            {
                foreach (var nieghborStationId in currentStation.NeighborStationId) // All edges of the current station
                {
                    neighborStation = stationsList.Where(s => s.Id == nieghborStationId).First();
                    newLenght = A[currentStation.Id] + GetLenghtBetweenStations(currentStation, neighborStation);

                    if (!A.ContainsKey(nieghborStationId))
                    {
                        A.Add(nieghborStationId, newLenght);
                        B.Add(nieghborStationId, currentStation);
                    }
                    else if (A[nieghborStationId] > newLenght)
                    {
                        A[nieghborStationId] = newLenght;
                        B[nieghborStationId] = currentStation;
                    }
                }

                minValue = 0;
                foreach (var stationId in A.Keys)  // find shortest edge
                {
                    neighborStation = stationsList.Where(s => s.Id == stationId).First();
                    if (!neighborStation.IsVisited)
                    {
                        if (minValue > A[stationId] || minValue == 0)
                        {
                            currentStation = neighborStation;
                            minValue = A[stationId];
                        }
                    }
                }
                currentStation.IsVisited = true;
                X.Add(currentStation);

                if (currentStation.Id == finishStation.Id)
                {
                    break;
                }
            }

            // Building data route
            totalRoute.Add(finishStation);
            while (totalRoute[totalRoute.Count - 1].Id != startStation.Id)
            {
                totalRoute.Add(B[totalRoute[totalRoute.Count - 1].Id]);
            }

            // Set list node in not visited state
            ResetState(stationsList);

            return totalRoute;
        }

        public string FindStationName(List<Station> stations, string stationName)
        {
            string name = null;

            foreach (var station in stations)
            {
                if (station.Name.Contains(stationName))
                {
                    name = station.Name;
                    break;
                }
            }

            return name;
        }

        public void BuildRoute(List<Station> route, MapPolyline routePolyline = null)
        {
            routePolyline.Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Yellow);
            routePolyline.StrokeThickness = 11;
            routePolyline.Opacity = 0.5;
            LocationCollection locations = new LocationCollection();

            foreach (var station in route)
            {
                locations.Add(new Location(station.Longitude, station.Latitude));
            }
            routePolyline.Locations = locations;

            myMap.Children.Add(routePolyline);
        }

        public double GetLenghtBetweenStations(Station startStation, Station finishStation)
        {
            double lenght = Math.Sqrt(Math.Pow((startStation.Longitude - finishStation.Longitude), 2)
                                      + Math.Pow((startStation.Latitude - finishStation.Latitude), 2));

            return lenght;
        }

        public List<Station> GetCopyListStations(List<Station> originalList)
        {
            List<Station> copyList = new List<Station>();
            Station station;

            foreach (var s in originalList)
            {
                station = new Station();
                station.Id = s.Id;
                station.BrunchColor = s.BrunchColor;
                station.Longitude = s.Longitude;
                station.Latitude = s.Latitude;
                station.Name = s.Name;
                station.IsVisited = s.IsVisited;
                station.NeighborStationId = new List<string>();

                foreach (var value in s.NeighborStationId)
                {
                    station.NeighborStationId.Add(value);
                }

                copyList.Add(station);
            }

            return copyList;
        }

        public void ResetState(List<Station> stations)
        {
            foreach (var station in stations)
            {
                station.IsVisited = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nameFirstStation = FindStationName(metroStations, startStation.Text);
            string nameSecondStation = FindStationName(metroStations, finishStation.Text);

            if (nameFirstStation == null)
            {
                MessageBox.Show("Станція " + startStation.Text + " " + "не знайдена");
            }
            else if (nameSecondStation == null)
            {
                MessageBox.Show("Станція " + finishStation.Text + " " + "не знайдена");
            }
            else
            {
                startStation.Text = nameFirstStation;
                finishStation.Text = nameSecondStation;
                myMap.Children.Remove(routePolyline);  // clean previous route
                Station firstStation = metroStations.Where(s => s.Name == startStation.Text).First();
                Station secondStation = metroStations.Where(s => s.Name == finishStation.Text).First();
                BuildRoute(GetShortestRoute(metroStations, firstStation, secondStation), routePolyline);
            }


        }
    }
}
