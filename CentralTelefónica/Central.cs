using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefónica
{
    public abstract class Central
    {
        public virtual string llamadaLocal()
        {
            return "";
        }
        public virtual string llamadaP20()
        {
            return "";
        }
        public virtual string llamadaP25()
        {
            return "";
        }
        public virtual string llamadaP30()
        {
            return "";
        }
    }
}
