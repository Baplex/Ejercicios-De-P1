using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo
{
    public class Pug : Perro
    {
        public override string bark()
        {
            return "Pug bao wao";
        }
        public override string slep()
        {
            return "Pug mimimimimi";
        }
        public override string eat()
        {
            return "Pug yummy";
        }
        public override string play()
        {
            return "El pug está jugando con la pelota. boioioioioing";
        }
        public override string walk()
        {
            return "Es tiempo de pasear al pug.";
        }
        public override string vet()
        {
            return "Es tiempo de llevar el pug al veterinario.";
        }
    }
}
