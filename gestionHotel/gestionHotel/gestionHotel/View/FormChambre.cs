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
    public partial class FormChambre : Form
    {
        public ChambreController chambreController;
        public FormChambre()
        {
            InitializeComponent();
            this.chambreController=new ChambreController();
        }

        

        public void creerChambre()
        {
            
            int Chambre = chambreController.Enregistrer(textboxNom.Text, int.Parse(textBoxnumero.Text), comboBox.Text);
            MessageBox.Show("Sucess", "Chambre enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            creerChambre();
        }
        public void effacer()
        {
            textboxNom.Text = "";
            textBoxnumero.Text = "";
            comboBox.Text = "";
        }

        private void button_sp_Click(object sender, EventArgs e)
        {
            effacer();
        }

        private void button_voir_Click(object sender, EventArgs e)
        {
            FormListChambre formListChambre=new FormListChambre();
            formListChambre.Show();
          
        }
    }
}
