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
using System.Data.SqlClient;
namespace gestionHotel.View
{
    public partial class FormClient : Form
    {
        public ClientController clientController;
        public FormClient()
        {
            InitializeComponent();
            this.clientController = new ClientController();
        }
        public void creerClient()
        {
            Client clientel = clientController.Enregistrer(textBox_nom.Text, textBox_prenom.Text, textBox_adresse.Text, comboBox_genre.Text, comboBox_status.Text, int.Parse(textBox_tel.Text));
           // if (textBox_nom.Text == " " || textBox_prenom.Text =="" || textBox_adresse.Text==" " || comboBox_genre.Text==" " || comboBox_status.Text==" "|| textBox_tel.Text=="")
            if(clientel.IsNull())
            {
                MessageBox.Show("erreur", "veuillez remplir les champs",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Sucess", "Client enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            this.creerClient();
        }

        private void btn_effacer_Click(object sender, EventArgs e)
        {
            this.effacer();
        }
        public void effacer()
        {
            textBox_nom.Text = "";
            textBox_prenom.Text = " ";
            textBox_adresse.Text = " ";
            comboBox_genre.Text = " ";
            comboBox_status.Text = " ";
            textBox_tel.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormListClient formListClient = new FormListClient();
            formListClient.Show();
          
        }
    }
}
