using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TZ_TexodeTechnologies.Model
{
    public class StudentsXML
    {
        private static StudentsXML _students;
        private static readonly XmlDocument _locker = new XmlDocument();

        private StudentsXML()
        {
            _locker.Load("Students.xml");
        }

        public static StudentsXML GetStudents()
        {
            lock (_locker)
            {
                if (_students == null)
                {
                    _students = new StudentsXML();
                    return _students;
                }
                return _students;
            }
        }
    }
}
