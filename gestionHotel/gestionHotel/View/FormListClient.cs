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
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\2022 - 2023\gestion hotel\RESERVATION - CHAMBRE\gestionHotel\gestionHotel\gestionHotel.mdf;Integrated Security=True;Connect Timeout=30");
        public FormListClient()
        {
            InitializeComponent();
            this.clientController = new ClientController();
        }
       /* public void afficheGrid()
        {
            string afficheDonnee = "SELECT * FROM Client";
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(afficheDonnee, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var dataset = new DataSet();
            adapter.Fill(dataset);
            listClients.DataSource = dataset.Tables[0];
            connection.Close();
        }*/
        public void ajouterdatagrid(List<Client> clients)
        {
            listClients.Rows.Clear();
            clients.ForEach(delegate (Client item)
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
        /* public int RowsCountListSelected()
        {
            int RowsSelected = 0;
            try
            {
                for (int i = 0; i <listClients.Rows.Count - 1; i++)
                {
                    int cellsCount = listClients.Rows[i].Cells.Count;
                    if ((bool)listClients.Rows[i].Cells[cellsCount - 1].Value == true)
                    {
                        RowsSelected++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return RowsSelected;
        }
        public int GetBuildingIdFromRowList()
        {
            int Id = 0;
            int RowSelected = RowsCountListSelected();
            if (RowSelected == 1)
            {
                for (int i = 0; i < listClients.Rows.Count - 1; i++)
                {
                    int cellsCount = listClients.Rows[i].Cells.Count - 1;
                    if (
                        listClients.Rows[i].Cells[cellsCount] != null &&
                        (bool)listClients.Rows[i].Cells[cellsCount].Value == true
                        )
                    {
                        Id = (int)listClients.Rows[i].Cells[0].Value;
                    }
                }
            }
            else if (RowSelected > 1)
            {
                MessageBox.Show("You have to select only one item from the list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (RowSelected < 1)
            {
                MessageBox.Show("You have to select an item from the list to process!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Id;
        }
        private Client GetDataFromSelctedItemInRows()
        {
            int RowSelected = RowsCountListSelected();
            if (RowSelected == 1)
            {
                for (int i = 0; i < listClients.Rows.Count - 1; i++)
                {
                    int Id = (int)listClients.Rows[i].Cells[0].Value;
                    String Nom = (String)listClients.Rows[i].Cells[1].Value;
                    String Prenom = (String)listClients.Rows[i].Cells[2].Value;
                    String Adresse = (String)listClients.Rows[i].Cells[3].Value;
                    String Genre= (String)listClients.Rows[i].Cells[4].Value;
                    String Status= (String)listClients.Rows[i].Cells[5].Value;
                    int Telephone = (int)listClients.Rows[i].Cells[6].Value;

                    return new Client(Id, Nom, Prenom, Adresse, Genre, Status, Telephone);
                }
            }
            else if (RowSelected > 1)
            {
                MessageBox.Show("You have to select only one item from the list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (RowSelected < 1)
            {
                MessageBox.Show("You have to select an item from the list to process!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private void DeleteBuilding_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = GetBuildingIdFromRowList();
                if (Id > 0)
                {
                    DialogResult CanDelete = MessageBox.Show("Do you really want to delete this item?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (CanDelete == DialogResult.Yes)
                    {
                       clientController.Supprimer(Id);
                        MessageBox.Show("Item deleted!");
                        FormListClient_Load();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void RefreshBuildingList_btn_Click(object sender, EventArgs e)
        {
            FormListClient_Load();
        }

        private void FormListClient_Load()
        {
            List<Client> clients = clientController.FindAll();
            ajouterdatagrid(clients);

        }

        private void FormListClient_Load(object sender, EventArgs e)
        {
            FormListClient_Load();
        }
    }
    
}
