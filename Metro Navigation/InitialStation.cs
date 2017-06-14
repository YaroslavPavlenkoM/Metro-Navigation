using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Xml.Serialization;
using System.IO;

namespace Metro_Navigation
{
    public class InitialStation
    {
        public void Intit()
        {
            List<Station> stations = new List<Station>() {
                new Station()
                {
                    Id = "01RedLine",
                    Longitude = 50.465032,
                    Latitude = 30.354894,
                    Name = "Академмістечко",
                    BrunchColor = Colors.Red,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "02RedLine",
                    Longitude = 50.455970,
                    Latitude = 30.364670,
                    Name = "Житомирська",
                    BrunchColor = Colors.Red,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "03RedLine",
                    Longitude = 50.458223,
                    Latitude = 30.387436,
                    Name = "Святошин",
                    BrunchColor = Colors.Red,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "04RedLine",
                    Longitude = 50.458278,
                    Latitude = 30.403230,
                    Name = "Нивки",
                    BrunchColor = Colors.Red,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "05RedLine",
                    Longitude = 50.458943,
                    Latitude = 30.421469,
                    Name = "Берестейська",
                    BrunchColor = Colors.Red,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "06RedLine",
                    Longitude = 50.454766,
                    Latitude = 30.445125,
                    Name = "Шулявська",
                    BrunchColor = Colors.Red,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "07RedLine",
                    Longitude = 50.451065,
                    Latitude = 30.466566,
                    Name = "Політехнічний Інститут",
                    BrunchColor = Colors.Red,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "08RedLine",
                    Longitude = 50.441657,
                    Latitude = 30.488496,
                    Name = "Вокзальна",
                    BrunchColor = Colors.Red,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "09RedLine",
                    Longitude = 50.444519,
                    Latitude = 30.505998,
                    Name = "Університет",
                    BrunchColor = Colors.Red,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "10RedLine",
                    Longitude = 50.445337,
                    Latitude = 30.517685,
                    Name = "Театральна",
                    BrunchColor = Colors.Red,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "11RedLine",
                    Longitude = 50.447121,
                    Latitude = 30.526781,
                    Name = "Хрещатик",
                    BrunchColor = Colors.Red,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "12RedLine",
                    Longitude = 50.443776,
                    Latitude = 30.545263,
                    Name = "Арсенальна",
                    BrunchColor = Colors.Red,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "13RedLine",
                    Longitude = 50.441122,
                    Latitude = 30.558917,
                    Name = "Дніпро",
                    BrunchColor = Colors.Red,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "14RedLine",
                    Longitude = 50.445363,
                    Latitude = 30.576104,
                    Name = "Гідропарк",
                    BrunchColor = Colors.Red,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "15RedLine",
                    Longitude = 50.452207,
                    Latitude = 30.599112,
                    Name = "Лівобережна",
                    BrunchColor = Colors.Red,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "16RedLine",
                    Longitude = 50.455908,
                    Latitude = 30.613609,
                    Name = "Дарниця",
                    BrunchColor = Colors.Red,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "17RedLine",
                    Longitude = 50.459969,
                    Latitude = 30.632128,
                    Name = "Чернігіаська",
                    BrunchColor = Colors.Red,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "18RedLine",
                    Longitude = 50.463915,
                    Latitude = 30.644737,
                    Name = "Лісова",
                    BrunchColor = Colors.Red,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },

                // Синя вітка
                new Station()
                {
                    Id = "01BlueLine",
                    Longitude = 50.522550,
                    Latitude = 30.499485,
                    Name = "Героїв Дніпра",
                    BrunchColor = Colors.Blue,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "02BlueLine",
                    Longitude = 50.511476,
                    Latitude = 30.499013,
                    Name = "Мінська",
                    BrunchColor = Colors.Blue,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "03BlueLine",
                    Longitude = 50.502467,
                    Latitude = 30.497779,
                    Name = "Оболонь",
                    BrunchColor = Colors.Blue,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "04BlueLine",
                    Longitude = 50.486717,
                    Latitude = 30.498147,
                    Name = "Петрівка",
                    BrunchColor = Colors.Blue,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "05BlueLine",
                    Longitude = 50.473818,
                    Latitude = 30.504235,
                    Name = "Тараса Шевченка",
                    BrunchColor = Colors.Blue,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "06BlueLine",
                    Longitude = 50.465125,
                    Latitude = 30.516460,
                    Name = "Контрактова площа",
                    BrunchColor = Colors.Blue,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "07BlueLine",
                    Longitude = 50.459088,
                    Latitude = 30.524732,
                    Name = "Поштова площа",
                    BrunchColor = Colors.Blue,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "08BlueLine",
                    Longitude = 50.449943,
                    Latitude = 30.524027,
                    Name = "Майдан Незалежності",
                    BrunchColor = Colors.Blue,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "09BlueLine",
                    Longitude = 50.439478,
                    Latitude = 30.517028,
                    Name = "Площа Льва Толстого",
                    BrunchColor = Colors.Blue,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "10BlueLine",
                    Longitude = 50.432350,
                    Latitude = 30.516543,
                    Name = "Олімпійська",
                    BrunchColor = Colors.Blue,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "11BlueLine",
                    Longitude = 50.421008,
                    Latitude = 30.520537,
                    Name = "Палац Україна",
                    BrunchColor = Colors.Blue,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "12BlueLine",
                    Longitude = 50.412965,
                    Latitude = 30.525037,
                    Name = "Либідська",
                    BrunchColor = Colors.Blue,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "13BlueLine",
                    Longitude = 50.405007,
                    Latitude = 30.516829,
                    Name = "Деміївська",
                    BrunchColor = Colors.Blue,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "14BlueLine",
                    Longitude = 50.398033,
                    Latitude = 30.509941,
                    Name = "Голосіївська",
                    BrunchColor = Colors.Blue,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "15BlueLine",
                    Longitude = 50.393460,
                    Latitude = 30.489005,
                    Name = "Василькіаська",
                    BrunchColor = Colors.Blue,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "16BlueLine",
                    Longitude = 50.381606,
                    Latitude = 30.477488,
                    Name = "Виставковий центр",
                    BrunchColor = Colors.Blue,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "17BlueLine",
                    Longitude = 50.376186,
                    Latitude = 30.467379,
                    Name = "Іподром",
                    BrunchColor = Colors.Blue,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "18BlueLine",
                    Longitude = 50.366496,
                    Latitude = 30.453543,
                    Name = "Теремки",
                    BrunchColor = Colors.Blue,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },

                // Зелена вітка
                new Station()
                {
                    Id = "01GreenLine",
                    Longitude = 50.476764,
                    Latitude = 30.430166,
                    Name = "Сирець",
                    BrunchColor = Colors.Green,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "02GreenLine",
                    Longitude = 50.473911,
                    Latitude = 30.448368,
                    Name = "Дорогожичі",
                    BrunchColor = Colors.Green,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "03GreenLine",
                    Longitude = 50.462363,
                    Latitude = 30.482245,
                    Name = "Лук'янівська",
                    BrunchColor = Colors.Green,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "04GreenLine",
                    Longitude = 50.447945,
                    Latitude = 30.514165,
                    Name = "Золоті Ворота",
                    BrunchColor = Colors.Green,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "05GreenLine",
                    Longitude = 50.438169,
                    Latitude = 30.520945,
                    Name = "Палац спорту",
                    BrunchColor = Colors.Green,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "06GreenLine",
                    Longitude = 50.437024,
                    Latitude = 30.531331,
                    Name = "Кловська",
                    BrunchColor = Colors.Green,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "07GreenLine",
                    Longitude = 50.427611,
                    Latitude = 30.538669,
                    Name = "Печерська",
                    BrunchColor = Colors.Green,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "08GreenLine",
                    Longitude = 50.417865,
                    Latitude = 30.543982,
                    Name = "Дружба народів",
                    BrunchColor = Colors.Green,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "09GreenLine",
                    Longitude = 50.401896,
                    Latitude = 30.561954,
                    Name = "Видубичі",
                    BrunchColor = Colors.Green,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "10GreenLine",
                    Longitude = 50.394399,
                    Latitude = 30.604117,
                    Name = "Славутич",
                    BrunchColor = Colors.Green,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "11GreenLine",
                    Longitude = 50.395595,
                    Latitude = 30.616420,
                    Name = "Оскорки",
                    BrunchColor = Colors.Green,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "12GreenLine",
                    Longitude = 50.398111,
                    Latitude = 30.633715,
                    Name = "Позняки",
                    BrunchColor = Colors.Green,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "13GreenLine",
                    Longitude = 50.401150,
                    Latitude = 30.652994,
                    Name = "Харківська",
                    BrunchColor = Colors.Green,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "14GreenLine",
                    Longitude = 50.403770,
                    Latitude = 30.666408,
                    Name = "Вирлиця",
                    BrunchColor = Colors.Green,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "15GreenLine",
                    Longitude = 50.403482,
                    Latitude = 30.681847,
                    Name = "Бориспільська",
                    BrunchColor = Colors.Green,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                },
                new Station()
                {
                    Id = "16GreenLine",
                    Longitude = 50.409073,
                    Latitude = 30.695323,
                    Name = "Червоний Хутір",
                    BrunchColor = Colors.Green,
                    NeighborStationId = new List<string>(),
                    IsVisited = false
                }
            };

            List<Station> redStation = stations.Where(s => s.BrunchColor == Colors.Red).ToList();
            for (int i = 0; i < redStation.Count - 1; i++)
            {
                redStation[i].NeighborStationId.Add(redStation[i + 1].Id);
            }
            for (int i = redStation.Count - 1; i >= 1; i--)
            {
                redStation[i].NeighborStationId.Add(redStation[i - 1].Id);
            }

            List<Station> blueStation = stations.Where(s => s.BrunchColor == Colors.Blue).ToList();
            for (int i = 0; i < blueStation.Count - 1; i++)
            {
                blueStation[i].NeighborStationId.Add(blueStation[i + 1].Id);
            }
            for (int i = blueStation.Count - 1; i >= 1; i--)
            {
                blueStation[i].NeighborStationId.Add(blueStation[i - 1].Id);
            }

            List<Station> greenStation = stations.Where(s => s.BrunchColor == Colors.Green).ToList();
            for (int i = 0; i < greenStation.Count - 1; i++)
            {
                greenStation[i].NeighborStationId.Add(greenStation[i + 1].Id);
            }
            for (int i = greenStation.Count - 1; i >= 1; i--)
            {
                greenStation[i].NeighborStationId.Add(greenStation[i - 1].Id);
            }

            // Переходи
            Station redMainStationOne = stations.Where(s => s.Name == "Театральна").First();
            Station greenMainStationOne = stations.Where(s => s.Name == "Золоті Ворота").First();
            redMainStationOne.NeighborStationId.Add(greenMainStationOne.Id);
            greenMainStationOne.NeighborStationId.Add(redMainStationOne.Id);

            Station redMainStationTwo = stations.Where(s => s.Name == "Хрещатик").First();
            Station blueMainStationOne = stations.Where(s => s.Name == "Майдан Незалежності").First();
            redMainStationTwo.NeighborStationId.Add(blueMainStationOne.Id);
            blueMainStationOne.NeighborStationId.Add(redMainStationTwo.Id);

            Station greenMainStationTwo = stations.Where(s => s.Name == "Палац спорту").First();
            Station blueMainStationTwo = stations.Where(s => s.Name == "Площа Льва Толстого").First();
            greenMainStationTwo.NeighborStationId.Add(blueMainStationTwo.Id);
            blueMainStationTwo.NeighborStationId.Add(greenMainStationTwo.Id);


            XmlSerializer ser = new XmlSerializer(typeof(List<Station>));
            TextWriter writer = new StreamWriter(@"Stations.xml");
            ser.Serialize(writer, stations);
            writer.Close();
        }
    }
}
