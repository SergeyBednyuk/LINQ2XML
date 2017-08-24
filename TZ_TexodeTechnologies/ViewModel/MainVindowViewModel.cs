using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;
using GalaSoft.MvvmLight.CommandWpf;
using TZ_TexodeTechnologies.Model;
using TZ_TexodeTechnologies.View;


namespace TZ_TexodeTechnologies.ViewModel
{
    public class MainVindowViewModel : ViewModelBase
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

        public int CurrectElementIdMainWindow { get; set; }


        private ICommand _clickAdd;
        public ICommand ClickAdd
        {
            get
            {
                _clickAdd = new RelayCommand(() =>
                {
                    AddWindow addWindow = new AddWindow();
                    addWindow.Show();
                });
                return _clickAdd;
            }

        }

        private ICommand _clickEdit;
        public ICommand ClickEdit
        {
            get
            {
                if (_clickEdit == null)
                {
                    _clickEdit = new RelayCommand(() =>
                    {
                        EditWindow editWindow = new EditWindow();
                        editWindow.Show();

                    });
                }
                return _clickEdit;
            }
        }

        private ICommand _clickRemove;
        public ICommand ClickRemove
        {
            get
            {
                if (_clickRemove == null)
                {
                    _clickRemove = new RelayCommand(ClickRemoveExecute, RemoveCanExecute);
                }
                return _clickRemove;
            }
        }
        private bool RemoveCanExecute()
        {
            if (CurrectElementIdMainWindow <= -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void ClickRemoveExecute()
        {
            var removeElement = from element in Data.XDoc.Element("Students").Elements()
                                where element.Attribute("Id").Value == Convert.ToString(CurrectElementIdMainWindow)
                                select element;

            removeElement.Remove();
            Data.XDoc.Save(@"D:\itstep\TZ\TZ_TexodeTechnologies\TZ_TexodeTechnologies\Students.xml");
        }
    }
}
