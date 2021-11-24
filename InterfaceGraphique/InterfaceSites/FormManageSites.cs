using projetBloc4Individuel.GestionSites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Site = projetBloc4Individuel.GestionSites.Site;

namespace projetBloc4Individuel.InterfaceGraphique.InterfaceSites
{
    public partial class FormManageSites : Form
    {
        public FormManageSites()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void FormManageSites_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_creation_date_Click(object sender, EventArgs e)
        {

        }

        private void lbl_update_date_Click(object sender, EventArgs e)
        {

        }
        //Bouton Enregistrer
        private void bt_save_Click(object sender, EventArgs e)
        {
            Site site = new Site();
            site.Name = lbl_city.Text;
            new ManageSites().Ajouter(site);

        }

        //Bouton fini
        private void bt_finish_Click(object sender, EventArgs e)
        {

        }
        //Bouton Suivant
        private void bt_next_Click(object sender, EventArgs e)
        {

        }
        //Bouton Précédent
        private void bt_previous_Click(object sender, EventArgs e)
        {

        }
        //Bouton Début
        private void bt_start_Click(object sender, EventArgs e)
        {
            Site site = new ManageSites().Start();
            this.Afficher(site);
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {

        }

        private void bt_addNew_Click(object sender, EventArgs e)
        {
            lbl_id.Text = "";
            txt_ville.Text = "";
            lbl_dateUpdate.Text = "";
            lbl_dateCreation.Text = DateTime.Now.ToShortDateString();

        }

        private void Afficher(Site site)
        {
            lbl_id.Text = "";
            txt_ville.Text = "";
            lbl_dateUpdate.Text = "";
            lbl_dateCreation.Text = DateTime.Now.ToShortDateString();
        }
    }
}
