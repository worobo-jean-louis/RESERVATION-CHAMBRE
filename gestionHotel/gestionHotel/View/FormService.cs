using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestionHotel.Controller;
using gestionHotel.Entity;
using gestionHotel.Dal;
using gestionHotel.Services;


namespace gestionHotel.View
{
    public partial class FormService : Form
    {
        public FormService()
        {
            InitializeComponent();
        }
        public ServiceController serviceController;
       
        public void creerService()
        {
            Service comm = serviceController.Enregistrer( textBox_nom.Text, int.Parse(textBox_prix.Text), int.Parse(textBox_qte.Text), int.Parse(textBox_total.Text), int.Parse(textBox_chambre.Text));
            // if (textBox_nom.Text == " " || textBox_prenom.Text =="" || textBox_adresse.Text==" " || comboBox_genre.Text==" " || comboBox_status.Text==" "|| textBox_tel.Text=="")
            if (comm.IsNull())
            {
                MessageBox.Show("erreur", "veuillez remplir les champs", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Sucess", "service enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            creerService();
        }
        public void effacer()
        {
            textBox_chambre.Text = "";
            textBox_nom.Text = "";
            textBox_prix.Text = "";
            textBox_qte.Text = "";
            textBox_total.Text = "";
        }

        private void btn_effacer_Click(object sender, EventArgs e)
        {
            effacer();
        }
        public int prix()
        {
            int total = 0;
            total = int.Parse(textBox_qte.Text) * int.Parse(textBox_prix.Text);
            return total;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormListService formListservice = new FormListService();
            formListservice.Show();
        }
    }
}
