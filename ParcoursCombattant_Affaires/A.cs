using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcoursCombattant_Affaires
{
    public abstract class A
    {
        protected int _valeurA, _valeurB;
        public A(int a, int b)
        {
            _valeurA = a + 1;
            _valeurB = b + 2;
        }

        public int ValeurA { get { return _valeurA; } set { _valeurA = value; } }
        public int ValeurB { get { return _valeurB; } set { _valeurB = value; } }

        public virtual int calculer()
        {
            return _valeurA + _valeurB + this.determinerHandicap();
        }

        public abstract int determinerHandicap();
    }
}
