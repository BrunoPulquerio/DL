using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AutoMapper
{
    public class CarProfile
    {
        public CarProfile()
        {
            CreateMap<Car, CarViewModel>().ReverseMap();
        }
    }
}
