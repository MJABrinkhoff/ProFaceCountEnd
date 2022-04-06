using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFaceCountEnd.Classes
{
    public class Sensor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Location> Locations { get; set;}
        public List<SensorMeasurement> sensorMeasurements { get; set; }

        public Sensor(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        //Not needed, Needs to work in DAL!
        public void ConnectSensorMeasurement(SensorMeasurement sensorMeasurement)
        {
            sensorMeasurements.Add(sensorMeasurement);
            sensorMeasurement.Sensors.Add(this);
        }
    }
}
