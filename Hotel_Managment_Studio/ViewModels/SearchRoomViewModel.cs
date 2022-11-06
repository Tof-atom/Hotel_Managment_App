using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Managment_Studio.ViewModels
{
    public class SearchRoomViewModel : ViewModelBase
    {
        public MajorIndexViewModel MajorIndexViewModel { get; set; }

        public SearchRoomViewModel(MajorIndexViewModel majorIndexViewModel)
        {
            MajorIndexViewModel = majorIndexViewModel;
        }
    }
}
