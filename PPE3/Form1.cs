using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PPE3
{
    public partial class Form1 : Form
    {
        videoppe3groupe2Entities maconnexion;
        public string typerecherche;
        public Form1()
        {
            InitializeComponent();
            maconnexion = new videoppe3groupe2Entities();
        }
        public List<client> clients() {
            return maconnexion.client.ToList();
            }
        public List<emprunt> emprunts()
        {
            return maconnexion.emprunt.ToList();
        }
        public List<episode> episodes()
        {
            return maconnexion.episode.ToList();
        }
        public List<film> films()
        {
            return maconnexion.film.ToList();
        }
        public List<genre> genres()
        {
            return maconnexion.genre.ToList();
        }
        public List<saison> saisons()
        {
            return maconnexion.saison.ToList();
        }
        public List<serie> series()
        {
            return maconnexion.serie.ToList();
        }
        public List<support> supports()
        {
            return maconnexion.support.ToList();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
         typerecherche = "genre";
         VuesRecherche newMDIChild = new VuesRecherche();
         IsMdiContainer = true;
         // Set the Parent Form of the Child window.  
         newMDIChild.Text = typerecherche;
        
         newMDIChild.MdiParent = this;
         // Display the new form.  
         newMDIChild.Show();          

        }

        private void ajouterCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vueAjoutClient newMDIChild = new vueAjoutClient(maconnexion/*,clients,emprunts, episodes,films,genres,saisons,series,supports*/);
            IsMdiContainer = true;
            // Set the Parent Form of the Child window.  
            newMDIChild.maconnexion = maconnexion;
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            VueActiv newMDIChild = new VueActiv(maconnexion/*,clients,emprunts, episodes,films,genres,saisons,series,supports*/);
            IsMdiContainer = true;
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            VueFermerCompte newMDIChild = new VueFermerCompte(maconnexion);
            IsMdiContainer = true;
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();
        }

        private void modifierCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VueModifClient newMDIChild = new VueModifClient(maconnexion);
            IsMdiContainer = true;
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
