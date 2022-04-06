using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProFaceCountEnd.Classes
{
    public class SensorMeasurement
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int CurrentPersons { get; set; }
        public int NeededPersonal { get; set; }
        public DateTime Date { get; set; }
        public List<Sensor> Sensors { get; set; }

        public SensorMeasurement(int Id, string Description)
        {
            this.Id = Id;
            this.Description = Description;
        }
    }
}
