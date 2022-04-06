using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProFaceCountEnd
{
    public partial class HomePage : Form
    {
        private Form activeForm = null; //Sets activeform to Null.
        
        public HomePage()
        {
            InitializeComponent();
        }

        private void BtnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Stops Application.
        }
        private void openChildForm(Form childForm)
        {
            //Opens forms inside 'PnlPage'.
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PnlPage.Controls.Add(childForm);
            PnlPage.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void BtnLibrary_Click(object sender, EventArgs e)
        {
            //niks
        }
        private void SideNavSlider_Tick(object sender, EventArgs e)
        {
            //Slides the pnl in or out when called(visible or hidden). 
            if (SideNav.Width == 150)
            {
                TLPnlSideNav.Visible = false;
                for (int i = 0; i < 10; i++)
                {
                    SideNav.Width = SideNav.Width - 15;
                }
                SideNavSlider.Stop();
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    SideNav.Width = SideNav.Width + 15;
                }
                TLPnlSideNav.Visible = true;
                SideNavSlider.Stop();
            }
        }
        private void BtnNavExpand_Click(object sender, EventArgs e)
        {
            SideNavSlider.Start(); //Opens/closes 'SideNav'.
        }
        private void HomePage_Load(object sender, EventArgs e)
        {
            SideNav.Width = 0; //Sets SideNav to 0.
        }
        private void BtnFullscreen_Click(object sender, EventArgs e)
        {
            //Maximizes window or set to normal.
            if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }
        private void BtnMinimalise_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; //Minimalises window.
        }

        private void BtnLocationCreate_Click(object sender, EventArgs e)
        {
            openChildForm(new LocationCreateForm()); //Opens 'LocationCreateForm' form.
        }
    }
}
