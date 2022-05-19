using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.ViewModel
{
    public abstract class ViewModel :INotifyPropertyChanged
    {
        /// <summary>
        /// Allows notifying when properties change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        /// <summary>
        /// Call this when you've changed a property
        /// </summary>
        /// <param name="property"></param>
        public void Change(string property)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
