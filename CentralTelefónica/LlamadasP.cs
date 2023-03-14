using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefónica
{
    public class LlamadasP : Central
    {

        public override string llamadaP20()
        {
            return "Su llamada se encuentra fuera de su provincia (franja 1), por lo tanto costará 20 céntimos por segundo";
        }
        public override string llamadaP25()
        {
            return "Su llamada se encuentra fuera de su provincia (franja 2), por lo tanto costará 25 céntimos por segundo";
        }
        public override string llamadaP30()
        {
            return "Su llamada se encuentra fuera de su provincia (franja 3), por lo tanto costará 30 céntimos por segundo";
        }
    }
}
