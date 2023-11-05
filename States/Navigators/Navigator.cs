using AlgoTrader.App.Commands;
using AlgoTrader.App.Models;
using AlgoTrader.App.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AlgoTrader.App.States.Navigators
{
    public enum ViewModelTypes_e
    {
        Home,
        Portfolio
    }

    public class Navigator : ObservableObject, INavigator
    {
        private ViewModelBase _viewModelBase;
        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _viewModelBase;
            }
            set
            {
                _viewModelBase = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        public Navigator() 
        {
            _viewModelBase = new HomeViewModel();
        }

        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);

    }
}
