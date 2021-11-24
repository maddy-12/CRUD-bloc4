using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetBloc4Individuel.Exceptions
{
    class UpdateInexsitantObject : Exception
    {
        public UpdateInexsitantObject(string message) : base(message)
        {
        }
    }
}
