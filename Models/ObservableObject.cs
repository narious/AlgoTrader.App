using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTrader.App.Models
{
    /*
     * This class is to simply prevent reimplementing the INotifyPropertyChanged and other Observable properties
     * Small notes on INotifyPropertChanged
     * How the INotifyProperyChanged works
        When the view uses this as the view model and has a binding
        In the background that view will know that the binding implements the PropertyChangedEventHandler
        It will auto subscribe to the PropertyChangedEventHandler event.
        Now when we have a proprty change we can update that event by calling PropertyChangedEventHandler usually done by implementing a 
        helper method called OnPropertyChanged
     */
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
