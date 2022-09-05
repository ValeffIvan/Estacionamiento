using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Modelos
{
    public interface crud <T>
    {
        void agregar();
        void modificar();
        void eliminar();
    }
}
