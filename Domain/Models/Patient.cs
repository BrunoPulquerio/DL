using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Patient : Entity
    {
        public string Name { get; set; }

        public string CPF { get; set; }

    }

}
