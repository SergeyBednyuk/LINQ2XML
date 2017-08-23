using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;
using System.Xml.Linq;
using TZ_TexodeTechnologies.Annotations;

namespace TZ_TexodeTechnologies.Model
{
    public class Data 
    {
        private XDocument _xDoc;

        public XDocument Xdoc { get; set; }

        public Data()
        {
            _xDoc = XDocument.Load(@"D:\itstep\TZ\TZ_TexodeTechnologies\TZ_TexodeTechnologies\Students.xml");
        }

        //public static Data GetStudents()
        //{
        //    lock (_xDoc)
        //    {
        //        if (_students == null)
        //        {
        //            _students = new Data();
        //            return _students;
        //        }
        //        return _students;
        //    }
        //}
     
    }

}
