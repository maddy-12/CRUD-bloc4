using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetBloc4Individuel.GestionSites
{
    public class Site
    {
        int id; 
        string name;
        DateTime creationDate;
        DateTime updateDate;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }
        public DateTime UpdateDate { get => updateDate; set => updateDate = value; }
    }
}
