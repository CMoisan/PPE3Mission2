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
    public partial class VueActiv : Form
    {
        videoppe3groupe2Entities maconnexion;
        public VueActiv(videoppe3groupe2Entities maConnexion)
        {
            InitializeComponent();
            Form activeChild = this.ActiveMdiChild;
            maconnexion = maConnexion;
            comboBox1.DataSource = maConnexion.client.ToList();
            comboBox1.DisplayMember = "login";
        }

        private void VueActiv_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int actif = ((client)comboBox1.SelectedItem).actif;
            
           // MessageBox.Show("Actif : "+actif.ToString());
            if (actif == 1)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int actif;
            if (checkBox1.Checked == true)
            {
                actif = 1;
                MessageBox.Show("Le client a été activé", "Client activé", MessageBoxButtons.OK);
            }
            else
            {
                actif = 0;
                MessageBox.Show("Le client a été désactivé", "Client désactivé", MessageBoxButtons.OK);
            }
            maconnexion.client.ToList().Find(c => c.idClient == ((client)comboBox1.SelectedItem).idClient).actif = actif;
            maconnexion.SaveChanges();
        }
    }
}
