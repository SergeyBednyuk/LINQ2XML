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
using TZ_TexodeTechnologies.ViewModel;

namespace TZ_TexodeTechnologies.ViewModel
{
    public class EditWindowViewModel : ViewModelBase
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

        private int CurrectElementIdMainWindow = MainVindowViewModel.CurrectElementIdMainWindow;
        //public XElement CurrentElement = MainVindowViewModel.XElement;
        private int _id;
        public int Id
        {
            get { return _id; }
            set
            {
                _id = CurrectElementIdMainWindow;
                RaisePropertyChanged("Id");
            }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }

       private ICommand _clickEdit;

        public ICommand ClickEdit
        {
            get
            {
                if (_clickEdit == null)
                {
                    _clickEdit = new RelayCommand(ClickEditExecute, EditCanExecute);
                }
                return _clickEdit;
            }
        }

        private bool EditCanExecute()
        {
            if (CurrectElementIdMainWindow <= -1 && FirstName != String.Empty && LastName != String.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void ClickEditExecute()
        {
            Data.XDoc.Element("Students")
                .Elements("Student")
                .Where(x => x.Attribute("Id").Value == Convert.ToString(CurrectElementIdMainWindow)).First()
                .SetElementValue("FirstName", FirstName);

            Data.XDoc.Element("Students")
                .Elements("Student")
                .Where(x => x.Attribute("Id").Value == Convert.ToString(CurrectElementIdMainWindow)).First()
                .SetElementValue("Last", LastName);

            Data.XDoc.Element("Students")
                .Elements("Student")
                .Where(x => x.Attribute("Id").Value == Convert.ToString(CurrectElementIdMainWindow)).First()
                .SetElementValue("Age", Age);

            Data.XDoc.Element("Students")
                .Elements("Student")
                .Where(x => x.Attribute("Id").Value == Convert.ToString(CurrectElementIdMainWindow)).First()
                .SetElementValue("Gender", Gender);

            Data.XDoc.Save(MainVindowViewModel.Path);
        }
    }
}
