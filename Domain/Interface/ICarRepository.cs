using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface ICarRepository 
    {
        IEnumerable<Car> GetAll();

        Car GetById(int id);

        IEnumerable<Car> GetByModelOrPlaca(int idModelOrPlaca);
        int GetTotal();
    }
}
