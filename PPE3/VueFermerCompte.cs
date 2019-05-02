using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3
{
    public partial class VueFermerCompte : Form
    {
        videoppe3groupe2Entities maconnexion;
        public VueFermerCompte(videoppe3groupe2Entities maConnexion)
        {
            InitializeComponent();
            Form activeChild = this.ActiveMdiChild;
            maconnexion = maConnexion;
            comboBox1.DataSource = maConnexion.client.ToList();
            comboBox1.DisplayMember = "login";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client leClientACloturer = maconnexion.client.ToList().Find(c => c.idClient == ((client)comboBox1.SelectedItem).idClient);

            /* List<emprunt> lesEmprunts = maconnexion.emprunt.Where(c => c.idClient == ((client)comboBox1.SelectedItem).idClient).ToList();
             foreach (emprunt lEmprunt in lesEmprunts)
                 maconnexion.emprunt.Remove(lEmprunt);
             maconnexion.client.Remove(leClientACloturer);*/ // -> code pour suprrimer
            maconnexion.client.ToList().Find(c => c.idClient == ((client)comboBox1.SelectedItem).idClient).actif = '2';// 0: Pas actif 1: Actif 2: Fermé
            maconnexion.SaveChanges();
            MessageBox.Show("Le compte à bien été cloturé.", "Compte Cloturé", MessageBoxButtons.OK);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
