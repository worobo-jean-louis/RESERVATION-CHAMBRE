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
    public partial class FormListChambre : Form
    {
        ChambreController chambreController;
        public FormListChambre()
        {
            InitializeComponent();
        }
        
       
        public void addgrid(List<Chambres> Chambre)
        {
            ListChambre.Rows.Clear();

            Chambre.ForEach(delegate (Chambres item)
            {
                ListChambre.Rows.Add(item.Id_chambre, item.Nom_chambre, item.Numero_chambre, item.Type_chambre);
            }
          );

        }

        private void button_pri_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "liste des Chambres";
            printer.SubTitle = String.Format("Date:{0}", DateTime.Now.ToString());
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Center;
            printer.Footer = "Application de Gestions Des Hotels";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(ListChambre);

        }

        private void FormListChambre_Load(object sender, EventArgs e)
        {
            List<Chambres> chambres = chambreController.GetChambres();
            addgrid(chambres);
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            chambreController.Supprimer((int)ListChambre.SelectedRows[0].Cells[0].Value);
        }

        private void REFRESH_Click(object sender, EventArgs e)
        {
            List<Chambres> chambres = chambreController.GetChambres();
            addgrid(chambres);
        }
    }
}
