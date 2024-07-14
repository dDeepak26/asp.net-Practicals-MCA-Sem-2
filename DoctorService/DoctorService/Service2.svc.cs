using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DoctorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service2" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service2.svc or Service2.svc.cs at the Solution Explorer and start debugging.
    public class Service2 : IService2
    {
        public List<Doctor> GetDoctorDetails()
        {
            List<Doctor> doctors = new List<Doctor>();

            string connectionString = ConfigurationManager.ConnectionStrings["MedicalDBConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT DoctorID, FirstName, LastName, Specialty, Phone, Email FROM Doctor", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    doctors.Add(new Doctor
                    {
                        DoctorID = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Specialty = reader.GetString(3),
                        Phone = reader.GetString(4),
                        Email = reader.GetString(5)
                    });
                }
            }

            return doctors;
        }
    }
}
