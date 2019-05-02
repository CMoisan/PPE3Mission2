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
    public partial class VueModifClient : Form
    {
        videoppe3groupe2Entities maconnexion;
        public VueModifClient(videoppe3groupe2Entities maConnexion)
        {
            InitializeComponent();
            Form activeChild = this.ActiveMdiChild;
            maconnexion = maConnexion;
            comboBox1.DataSource = maConnexion.client.ToList();
            comboBox1.DisplayMember = "login";

        }

        private void PrenomBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PwdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nom_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int actif = ((client)comboBox1.SelectedItem).actif;

            // MessageBox.Show("Actif : "+actif.ToString());
            NameBox.Text = ((client)comboBox1.SelectedItem).nomClient.Replace(" ", "");
            PrenomBox.Text = ((client)comboBox1.SelectedItem).prenomClient.Replace(" ", "");
            EmailBox.Text = ((client)comboBox1.SelectedItem).emailClient.Replace(" ", "");
            LoginBox.Text = ((client)comboBox1.SelectedItem).login.Replace(" ", "");
            textBox1.Text = (((client)comboBox1.SelectedItem).admin).ToString().Replace(" ", "");
            PwdBox.Text = (((client)comboBox1.SelectedItem).pwd).ToString().Replace(" ", "");
        }

        private void validate_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(NameBox.Text) || !(NameBox.Text is String)) || (string.IsNullOrWhiteSpace(PrenomBox.Text) || !(PrenomBox.Text is String)) || string.IsNullOrWhiteSpace(EmailBox.Text) || string.IsNullOrWhiteSpace(LoginBox.Text) || string.IsNullOrWhiteSpace(PwdBox.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Tous les champs ne sont pas remplis correctement", "Erreur", MessageBoxButtons.OK);
            }
            else
            {
                maconnexion.client.ToList().Find(c => c.idClient == ((client)comboBox1.SelectedItem).idClient).login = LoginBox.Text;
                maconnexion.client.ToList().Find(c => c.idClient == ((client)comboBox1.SelectedItem).idClient).nomClient = NameBox.Text;
                maconnexion.client.ToList().Find(c => c.idClient == ((client)comboBox1.SelectedItem).idClient).prenomClient = PrenomBox.Text;
                maconnexion.client.ToList().Find(c => c.idClient == ((client)comboBox1.SelectedItem).idClient).emailClient = EmailBox.Text;
                maconnexion.client.ToList().Find(c => c.idClient == ((client)comboBox1.SelectedItem).idClient).pwd = PwdBox.Text;
                maconnexion.client.ToList().Find(c => c.idClient == ((client)comboBox1.SelectedItem).idClient).admin = Int32.Parse(textBox1.Text);
                maconnexion.SaveChanges();
                MessageBox.Show("Le client a été modifié", "Client modifié", MessageBoxButtons.OK);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
           DialogResult dialogResult = MessageBox.Show("Les modifications ne vont pas être enregistrées. Voulez vous réellement quitté ?", "Quiitez sans sauvegarder ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) this.Close();
        }
    }
}
