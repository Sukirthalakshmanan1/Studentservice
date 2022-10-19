using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentservice
{
    public enum Coursename
    {
        AIML, Dotnet, Java
    }
    public class Student1
    {
        public int rollno { get; set; }
        public string name { get; set; }
        public Coursename coursename { get; set; }
    }
}
