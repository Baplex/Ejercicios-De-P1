using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo
{
    public class BorderCollie : Perro
    {
        public override string bark()
        {
            return "Border Collie wauwando";
        }
        public override string slep()
        {
            return "Border Collie zzz";
        }
        public override string eat()
        {
            return "Border Collie munch crunch";
        }
        public override string play()
        {
            return "El collie está jugando con la pelota. Boing boing";
        }
        public override string walk()
        {
            return "Es tiempo de pasear al collie.";
        }
        public override string vet()
        {
            return "Es tiempo de llevar el collie al veterinario.";
        }
    }
}
