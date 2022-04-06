using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProFaceCountEnd.Classes
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxPersons { get; set; }
        public List<Sensor> Sensors { get; set; }
        public List<Employee> Employees { get; set; }

        

        public Location(int Id, string Name, int MaxPersons)
        {
            this.Id = Id;
            this.Name = Name;
            this.MaxPersons = MaxPersons;
            
        }

        //Not needed, Needs to work in DAL!
        public void ConnectSensorToLocation(Sensor sensor)
        {
            Sensors.Add(sensor);
            sensor.Locations.Add(this);
        }

        //Not needed, Needs to work in DAL!
        public void ConnectEmployeeToLocation(Employee employee)
        {
            Employees.Add(employee);
            employee.Locations.Add(this);
        }
    }
}
