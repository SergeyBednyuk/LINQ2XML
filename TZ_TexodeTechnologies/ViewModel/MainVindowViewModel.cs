using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;
using GalaSoft.MvvmLight.CommandWpf;
using TZ_TexodeTechnologies.Model;


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

        private ICommand _remove;

        public ICommand Remove
        {
            get
            {
                if (_remove == null)
                {
                    _remove = new RelayCommand();
                }
            }
        }

        private void RemoveExecute()
        {
          
        }

        private bool RemoveCanExecute()
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

      
    }
}
