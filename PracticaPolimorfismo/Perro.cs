using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo
{
    public abstract class Perro
    {
        public virtual string bark()
        {
            return "Wau Wau";
        }
        public virtual string slep()
        {
            return "Slep";
        }
        public virtual string eat()
        {
            return "yum";
        }
        public virtual string play()
        {
            return "El perro está jugando con la pelota. Boing boing";
        }
        public virtual string walk()
        {
            return "Es tiempo de pasear el perro.";
        }
        public virtual string vet()
        {
            return "Es tiempo de llevar el perro al veterinario.";
        }
    }
}
