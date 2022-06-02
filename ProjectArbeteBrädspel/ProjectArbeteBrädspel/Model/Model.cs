using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.Model
{
    public abstract class Model : INotifyPropertyChanged
    {
        /// <summary>
        /// Allows notifying when properties change
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged = (sender, e) => { };

        /// <summary>
        /// Call this when you've changed a property
        /// </summary>
        /// <param name="property">Name of the changed property</param>
        public void Change(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
