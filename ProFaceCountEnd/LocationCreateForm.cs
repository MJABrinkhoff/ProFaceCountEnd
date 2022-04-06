using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProFaceCountEnd.Classes;

namespace ProFaceCountEnd
{
    public partial class LocationCreateForm : Form
    {
        DAL dal;
        public LocationCreateForm()
        {
            InitializeComponent();
            dal = new DAL();
            dal.FillLocationListFromDatabase();
            DGLocation.DataSource = dal.Locations;
        }

        private void BtnCreateLocation_Click(object sender, EventArgs e)
        {
            Location location = new Location(0, TbNameLocation.Text, Int32.Parse(TbMaxPersonsLocation.Text));
            dal.CreateLocation(location);
            dal.FillLocationListFromDatabase();
            TbNameLocation.Text = TbMaxPersonsLocation.Text = String.Empty;
        }

        private void LocationCreateForm_Load(object sender, EventArgs e)
        {
            DGLocation.Columns["Id"].Visible = false;    //Hides datagrid
            DGLocation.AutoGenerateColumns = false;
        }

        private void TbNameLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGLocation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
