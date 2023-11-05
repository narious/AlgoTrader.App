using AlgoTrader.App.Commands;
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

    /*
     * Small notes on INotifyPropertChanged
     * How the INotifyProperyChanged works
        When the view uses this as the view model and has a binding
        In the background that view will know that the binding implements the PropertyChangedEventHandler
        It will auto subscribe to the PropertyChangedEventHandler event.
        Now when we have a proprty change we can update that event by calling PropertyChangedEventHandler usually done by implementing a 
        helper method called OnPropertyChanged
     */
    public class Navigator : INavigator, INotifyPropertyChanged
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

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
