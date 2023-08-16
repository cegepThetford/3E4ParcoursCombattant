using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcoursCombattant_Affaires
{
    public class B : A
    {
        protected int _valeurC;

        public B(int a, int b, int c)
            : base(a, b)
        {
            _valeurC = c;
        }

        public int ValeurC { get { return _valeurC; } set { _valeurC = value; } }

        public override int determinerHandicap()
        {
            return _valeurA % 3;
        }
    }
}
