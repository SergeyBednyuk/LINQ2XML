using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using TZ_TexodeTechnologies.Model;

namespace TZ_TexodeTechnologies.ViewModel
{
    class AddWindowViewModel : ViewModelBase
    {
        private Data _data;
        public Data Data
        {
            get
            {
                if (_data == null)
                {
                    _data = new Data();
                }
                return _data;
            }
            set
            {
                _data = value;
                RaisePropertyChanged("Data");
            }
        }


        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Gender{ get; set; }

        private ICommand _addInfo;

        public ICommand AddInfo
        {
            get
            {
                if (_addInfo == null)
                {
                    _addInfo = new RelayCommand(AddInfoExecute, AddInfoCanExecute);

                }
                return _addInfo;
            }
        }

        private bool AddInfoCanExecute()
        {
            if (Data == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void AddInfoExecute()
        {
            XElement xElementNew = new XElement("Student", 
                new XAttribute("Id",Id),
                new XElement("FirstName", FirstName),
                new XElement("Last", LastName),
                new XElement("Age", Age),
                new XElement("Gender", Gender));

            Data.XDoc.Root.Add(xElementNew);
            Data.XDoc.Save(@"D:\itstep\TZ\TZ_TexodeTechnologies\TZ_TexodeTechnologies\Students.xml");
      
        }
    }
}
