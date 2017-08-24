using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using TZ_TexodeTechnologies.ViewModel;

namespace TZ_TexodeTechnologies.ViewModel
{
    public class EditWindowViewModel : ViewModelBase
    {
       

        public XElement CurrectElement
        {
            get { return CurrectElement; }
            set
            {
                CurrectElement = value;
                RaisePropertyChanged("CurrectElement");
            }
        }

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
            if (CurrectElement == null)
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
            
        }
    }
}
