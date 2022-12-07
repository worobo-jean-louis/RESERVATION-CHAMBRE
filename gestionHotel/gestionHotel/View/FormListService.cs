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
    public partial class FormListService : Form
    {
        ServiceController ServiceController;
        public FormListService()
        {
            InitializeComponent();
            this.ServiceController =new ServiceController();
        }
        public void ajouterdatagrid(List<Service> services)
        {
            ListService.Rows.Clear();
            services.ForEach(delegate (Service item)
            {
                ListService.Rows.Add(item.Id_service, item.Nom_service, item.Prix_unitaire, item.Quantite, item.Total, item.Id_chambre);
            }
          );
        }
        private void FormListService_Load()
        {
            List<Service> services = ServiceController.FindAll();
            ajouterdatagrid(services);

        }

        private void FormListService_Load(object sender, EventArgs e)
        {
            FormListService_Load();
        }
    }
}
