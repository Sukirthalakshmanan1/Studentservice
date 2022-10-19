using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentservice
{
    public class StudentEnrollment
    {
       // Enrollment e = new Enrollment();
       public bool EnrollStudent(Enrollment e)
        {
            if (e.Fees > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
