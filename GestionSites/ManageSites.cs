using projetBloc4Individuel.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetBloc4Individuel.GestionSites
{
   public class ManageSites
    {
        List<Site> liste_sites = new List<Site>();
        private static int NumberOfSites;

        //Add a new site
        public int Ajouter(Site site)
        {
            if(site.Id != 0)
            {
                throw new AddExistingSiteException("Impossible d'ajouter un site déjà existant.");
            } else
            {
                site.Id = ++ManageSites.NumberOfSites;
                liste_sites.Add(site);
            }
            return site.Id;
        }

        //Update site

             public int Update(Site site)
              {
                  if (site.Id == 0)
                      throw new UpdateInexsitantObject("Impossible");
                  Site s = this.SearchById(site.Id);

                  s.Id = site.Id;
                  s.Name = site.Name;
                  s.CreationDate = site.CreationDate;
                  s.UpdateDate = site.UpdateDate;

                  return site.Id;
              }

              //Delete Site

              public int Supprimer(int id)
              {
                  Site site = this.SearchById(id);
                  liste_sites.Remove(site);

                  return site.Id;
              }
        
        //Search site by id
        public Site SearchById(int id)
        {
            foreach (var item in liste_sites)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
        public List<Site> GetSites()
        {
            return liste_sites;
        }
    }
}
