using ProjectArbeteBrädspel.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.ViewModel
{
    public class WindowViewModel : ViewModel
    {
        private ApplicationPage page;
        public ApplicationPage Page 
        { 
            get { return page; } 
            set 
            { 
                page = value; 
                Change(nameof(Page));
            }
        }

        public WindowViewModel(ApplicationPage page)
        {
            this.page = page;
        }
    }
}
