using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi;

HotelsService hs = new HotelsService();
var hotels = hs.GetHotels().GetAwaiter().GetResult();