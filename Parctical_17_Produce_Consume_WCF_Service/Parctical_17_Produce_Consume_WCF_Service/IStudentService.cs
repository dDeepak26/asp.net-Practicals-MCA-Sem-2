using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Parctical_17_Produce_Consume_WCF_Service
{
    [ServiceContract]
    public interface IStudentService
    {
        [OperationContract]
        int getStudentId(int studentId);

        [OperationContract]
        string getStudentName(string studentName);
    }
}
