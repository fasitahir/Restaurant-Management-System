using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystem.BL;
using HotelManagementSystem.DL;

namespace HotelManagementSystem
{
    public partial class BillCalculate : UserControl
    {
        public BillCalculate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = orderNameTb.Text;
            string itemName = "";
            int itemQuantity = 0;
            double bill;

            bool flag = false;
            foreach(Order o in OrderDL.orders)
            {
                if(o.Name.ToUpper() == name.ToUpper())
                {
                    itemName = o.OrderedItem;
                    itemQuantity = o.OrderQuantity;
                    flag = true;
                    break;
                }
            }
            if(flag == true)
            {
                BL.Menu m = BL.Menu.IsItemExist(itemName);
                bill = int.Parse(m.Price) * itemQuantity;
                billLabel.Text = "Bill for " + " " + itemName + " " + itemQuantity + " is " + bill;
            }
            else
            {
                MessageBox.Show("This order is not placed");
            }
        }
    }
}
