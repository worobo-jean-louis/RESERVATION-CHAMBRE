using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestionHotel.Entity;
using gestionHotel.Dal;
using gestionHotel.Services;
using gestionHotel.Controller;

namespace gestionHotel.View
{
    public partial class FormListClient : Form
    {
        ClientController clientController;
        public FormListClient()
        {
            InitializeComponent();
            this.clientController = new ClientController();
        }
        public void ajouterdatagrid(List<Client> clients)
        {
            listClients.Rows.Clear();
            clients.ForEach(delegate (Client item)
            {
                listClients.Rows.Add(item.Id_client, item.Nom, item.Prenom, item.Adresse, item.Genre, item.Status, item.Telephone);
            }
          );
        }

        private void FormListClient_Load(object sender, EventArgs e)
        {
            List<Client> clients = clientController.FindAll();
            ajouterdatagrid(clients);
        }
    }
}
