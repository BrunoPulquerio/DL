using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Car:Entity
    {

        public string Brand{ get; set; }

        public string Model { get; set; }

        public string Version { get; set; }

        public string Placa { get; set; }

        public string RENAVAM { get; set; }

        public string Chassi { get; set; }

    }
}
