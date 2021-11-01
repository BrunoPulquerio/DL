using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ICarService
    {
        IEnumerable<CarViewModel> GetAll();

        CarViewModel GetbyId(int Id);

        CarViewModel Create(CarViewModel obj);

        CarViewModel Update(CarViewModel obj);

        CarViewModel Delete(int Id);

        CarViewModel GetByNameOrCpf(string modelOrPlaca);

    }
}
