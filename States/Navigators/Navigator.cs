using AlgoTrader.App.Commands;
using AlgoTrader.App.ViewModels;
using System;
using System.Collections.Generic;
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

    public class Navigator : INavigator
    {
        public ViewModelBase CurrentViewModel { get; set; } 

        public Navigator() 
        {
            CurrentViewModel = new HomeViewModel();
        }

        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);
    }
}
