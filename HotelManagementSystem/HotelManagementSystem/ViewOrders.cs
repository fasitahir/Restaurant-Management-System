using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystem.DL;

namespace HotelManagementSystem
{
    public partial class ViewOrders : UserControl
    {
        public ViewOrders()
        {
            InitializeComponent();
            DataBind();
        }

        private void menuGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int rowIndex = orderGridView.CurrentCell.RowIndex;
            orderGridView.Rows.RemoveAt(rowIndex);
        }

        private void DataBind()
        {
            List<BL.Order> order = OrderDL.orders;
            BL.Order order1 = new BL.Order("Tayyab", "Burger", 2);
            BL.Order order2 = new BL.Order("Manan", "Pizza", 1);
            BL.Order order3 = new BL.Order("Afraz", "Bottle", 4);
            BL.Order order4 = new BL.Order("Asghar", "Soup", 3);
            order.Add(order1);
            order.Add(order2);
            order.Add(order3);
            order.Add(order4);

            OrderDL.orders.Add(order1);
            OrderDL.orders.Add(order2);
            OrderDL.orders.Add(order3);
            OrderDL.orders.Add(order4);

            orderGridView.DataSource = null;
            orderGridView.DataSource = order;
            orderGridView.AutoGenerateColumns = true;
            orderGridView.Refresh();
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}
