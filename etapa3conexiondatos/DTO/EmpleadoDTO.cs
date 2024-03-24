using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etapa3conexiondatos.DTO
{
    public partial class EmpleadoDTO
    {
        public EmpleadoDTO()
        {

        }
        
        public string nrodocidentidad { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string numerotel { get; set; }
        
        public string cargo { get; set;}
        public string oficina { get; set; }
        public string foto { get; set;}
        public byte[] datosfoto { get; set;}
    }
}
