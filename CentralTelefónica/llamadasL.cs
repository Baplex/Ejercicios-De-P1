using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefónica
{
    public class llamadasL : Central
    {
       public override string llamadaLocal()
        {
            return "Su llamada se encuentra dentro de su provincia, por lo tanto costará 15 céntimos por segundo";
        }
    }
}
