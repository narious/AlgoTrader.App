using AlgoTrader.App.States.Navigators;
using AlgoTrader.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTrader.App.Commands
{
    public class UpdateCurrentViewModelCommand : CommandBase
    {
        private INavigator _navigator;
        public UpdateCurrentViewModelCommand(INavigator inav) 
        {
            _navigator = inav;
        }

        public override bool CanExecute(object? parameter)
        {
            return base.CanExecute(parameter);
        }

        public override void Execute(object? parameter)
        {
            if (parameter != null && parameter is ViewModelTypes_e)
            {
                ViewModelTypes_e viewModelType = (ViewModelTypes_e)parameter;
                switch (viewModelType)
                {
                    case ViewModelTypes_e.Home:
                        _navigator.CurrentViewModel = new HomeViewModel();
                        break;
                    case ViewModelTypes_e.Portfolio:
                        _navigator.CurrentViewModel = new PortfolioViewModel();
                        break;

                    default: break;
                }
            }
        }
    }
}
