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
using System.Data.SqlClient;

namespace gestionHotel.View
{
    public partial class FormListClient : Form
    {
        ClientController clientController;
        //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\2022 - 2023\gestion hotel\RESERVATION - CHAMBRE\gestionHotel\gestionHotel\gestionHotel.mdf;Integrated Security=True;Connect Timeout=30");
        public FormListClient()
        {
            InitializeComponent();
            this.clientController = new ClientController();
        }
       
        
        public void addgrid(List<Clients> clients)
        {
            listClients.Rows.Clear();
           // listClients.DataSource = clients;
            clients.ForEach(delegate (Clients item)
            {
                listClients.Rows.Add(item.Id_client, item.Nom, item.Prenom, item.Adresse, item.Genre, item.Status, item.Telephone);
            }
          );
           
        }

        private void PrintBuilding_btn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "liste des Clients";
            printer.SubTitle = String.Format("Date:{0}", DateTime.Now.ToString());
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Center;
            printer.Footer = "Application de Gestions Des Hotels";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(listClients);

        }

        private void FormListClient_Load(object sender, EventArgs e)
        {
            List<Clients> clients = clientController.GetClients();
            addgrid(clients);
            
            
        }

        private void DeleteBuilding_btn_Click(object sender, EventArgs e)
        {
            clientController.Supprimer((int)listClients.SelectedRows[0].Cells[0].Value);
        }

        private void RefreshBuildingList_btn_Click(object sender, EventArgs e)
        {
            List<Clients> clients = clientController.GetClients();
            addgrid(clients);
        }

        private void BuildingFilterInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateBuilding_btn_Click(object sender, EventArgs e)
        {

        }

        /*private void btnRech_Click(object sender, EventArgs e)
        {
            if(txtRech.Text!="")
            {
                clientController.Rechercher(string nom);
            }
        }*/
    }
}
