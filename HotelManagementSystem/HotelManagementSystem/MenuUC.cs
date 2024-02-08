using HotelManagementSystem.DL;
using HotelManagementSystem.BL;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections.Generic;

namespace HotelManagementSystem
{
    public partial class MenuUC : UserControl
    {
        public MenuUC()
        {
            InitializeComponent();
            DataBind();
        }

        private void MenuUC_Load(object sender, EventArgs e)
        {
            
        }
        private void DataBind()
        {
            List<BL.Menu> menu = MenuDL.menu;
            menuDLBindingSource.DataSource = null;
            menuDLBindingSource.DataSource = menu;
            menuGridView.DataSource = menuDLBindingSource;
            menuGridView.AutoGenerateColumns = true;
            menuGridView.Refresh();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        
        private void timer1_Tick(object sender, EventArgs e)
        {
            DataBind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
