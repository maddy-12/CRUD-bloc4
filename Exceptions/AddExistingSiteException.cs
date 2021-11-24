using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetBloc4Individuel.Exceptions
{
    class AddExistingSiteException : Exception
    {
        //base: C'est pour rappeler le code de la classe parent
        public AddExistingSiteException(string message) : base(message)
        {
        }
    }
}
