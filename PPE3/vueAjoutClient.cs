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
    public partial class vueAjoutClient : Form1
    {
        videoppe3groupe2Entities maconnexion;
        SqlConnection connection;
      //  List<client> clients;
        //        List<emprunt> emprunts;
        //      List<episode> episodes;
        //    List<film> films;
        //  List<genre> genres;
        //List<saison> saisons;
        //List<serie> series;
        //List<support> supports;
        client newclient;

        public vueAjoutClient(videoppe3groupe2Entities maconnexionForm1/*, List<client> clients, List<emprunt> emprunts,List<episode> episodes,List<film> films,List<genre> genres,List<saison> saisons,List<serie> series,List<support> supports*/)
        {
            InitializeComponent();
            Form activeChild = this.ActiveMdiChild;
            maconnexion = maconnexionForm1;
      //      this.clients = clients;
     //       this.emprunts = emprunts;
   //         this.episodes = episodes;
    //        this.films = films;
     //       this.genres = genres;
     //       this.saisons = saisons;
      //      this.series = series;
     //       this.supports = supports;
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PwdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void validate_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("L'une des valeurs ci-dessus est null, veuillez la remplir avant de valider le nouveau compte.", "Erreur", MessageBoxButtons.OK);
            if ((string.IsNullOrWhiteSpace(NameBox.Text) || !(NameBox.Text is String)) || (string.IsNullOrWhiteSpace(PrenomBox.Text) || !(PrenomBox.Text is String)) || string.IsNullOrWhiteSpace(EmailBox.Text) || string.IsNullOrWhiteSpace(LoginBox.Text) || string.IsNullOrWhiteSpace(PwdBox.Text))
            {
                MessageBox.Show("L'une des valeurs ci-dessus est nulle, ou ne correspond pas aux type de données souhaité, veuillez la remplir avant de valider le nouveau compte.", "Erreur", MessageBoxButtons.OK);
            }
            else
            {
                int actif = 0;
                int admin = 0;
                if (checkBox1.Checked == true) {
                    actif = 1;
                    admin = 1;
                }
                newclient = new client();
                newclient.actif = actif;
                newclient.admin = admin;
                newclient.dateAbonnementClient = DateTime.Now;
                newclient.emailClient = EmailBox.Text;
                newclient.login = LoginBox.Text;
                newclient.nomClient = NameBox.Text;
                newclient.prenomClient = PrenomBox.Text;
                newclient.pwd = PwdBox.Text;
                //(NameBox.Text, PrenomBox.Text, EmailBox.Text, DateTime.Now, LoginBox.Text, PwdBox.Text, actif, admin);
                ajoutclient(newclient);
                MessageBox.Show("Le client à bien été ajouté", "Client Ajouté", MessageBoxButtons.OK);
            }
            
        }
        public void ajoutclient(client MonClient)
        {
            maconnexion.client.Add(MonClient);
            maconnexion.SaveChanges();
        }

        private void cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
