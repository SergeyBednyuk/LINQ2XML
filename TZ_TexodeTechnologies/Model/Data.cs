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
    public class Data : INotifyPropertyChanged
    {
        private XDocument _xDoc;

        public XDocument XDoc
        {
            get {
                if (_xDoc == null)
                {
                    _xDoc = XDocument.Load(@"D:\itstep\TZ\TZ_TexodeTechnologies\TZ_TexodeTechnologies\Students.xml");
                }
                return _xDoc;
            }
            set
            {
                _xDoc = value;
                //TODO SERIALIZATION don't work from XML
                NotifyPropertyChanged("XDoc");
            }
        }

        //public Data()
        //{
        //    _xDoc = XDocument.Load(@"D:\itstep\TZ\TZ_TexodeTechnologies\TZ_TexodeTechnologies\Students.xml");
        //}

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


        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }

}
