using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcoursCombattant_Affaires
{
    public class C : B
    {
        public C(int a, int b, int c) : base(a, b, c) { }
        public override int calculer()
        {
            return _valeurA + 2 * _valeurB + 3 * _valeurC;
        }
    }
}
