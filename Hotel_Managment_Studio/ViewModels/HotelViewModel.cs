using Hotel_Managment_Studio.Models;
using Hotel_Managment_Studio.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Managment_Studio.ViewModels
{
    public class HotelViewModel : ViewModelBase
    {
        private List<Hotel> _hotel;      
        public IEnumerable<Hotel> Hotel=> _hotel;

        public HotelViewModel()
        {
            //hotel = HotelsListService.GetHotels().GetAwaiter().GetResult();
            _hotel = new List<Hotel>();
        }

        public static HotelViewModel LoadHotelViewModel()
        {
            HotelViewModel viewModel = new HotelViewModel();
            viewModel.LoadHotels();
            return viewModel;
        }
        
        private async void LoadHotels()
        {            
            _hotel = await HotelsListService.GetHotels();
        }
    }
}
