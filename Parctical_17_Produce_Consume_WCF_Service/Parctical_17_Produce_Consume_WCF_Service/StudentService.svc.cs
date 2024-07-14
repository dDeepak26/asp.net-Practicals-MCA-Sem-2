using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Parctical_17_Produce_Consume_WCF_Service
{
    public class StudentService : IStudentService
    {
        public int getStudentId(int studentId)
        {
            return studentId;
        }
        public string getStudentName(string studentName)
        {
            return studentName;
        }
    }
}
