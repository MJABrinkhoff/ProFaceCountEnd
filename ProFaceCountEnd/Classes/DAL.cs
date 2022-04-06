using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;

namespace ProFaceCountEnd.Classes
{
    public class DAL
    {
        string connectionString = "Data Source=.;Initial Catalog=ProFaceCountEnd;Integrated Security=True";
        public List<Sensor> Sensors = new List<Sensor>();
        public BindingList<Location> Locations = new BindingList<Location>();

        public void CreateSensor(Sensor sensor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO Sensor(Name) VALUES(@Name)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", sensor.Name);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { throw ex; }

        }

        public void CreateLocation(Location location)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO Location(Name, MaxPersons) VALUES(@Name, @MaxPersons)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", location.Name);
                        command.Parameters.AddWithValue("@MaxPersons", location.MaxPersons);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { throw ex; }

        }
        public void FillLocationListFromDatabase()
        {
            Locations.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT Id, Name, MaxPersons FROM Location ORDER BY ID ";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Locations.Add(new Location(Int32.Parse(reader[0].ToString())
                                                        , reader[1].ToString()
                                                        , Int32.Parse(reader[2].ToString())));
                        }
                    }
                }
            }
        }

        //Crud voor sensor, measurement, location. 
        
    }
}
