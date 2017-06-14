using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Metro_Navigation
{
    [Serializable]
    public class Station
    {
        public string Id { get; set; }
        public Color BrunchColor { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Name { get; set; }
        public List<string> NeighborStationId { get; set; }
        public bool IsVisited { get; set; }
    }
}
