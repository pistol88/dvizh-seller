using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DvizhSeller
{
    public partial class OrdersForm : Form
    {
        tools.OrderProvider ordersProvider = new tools.OrderProvider();
        repositories.Order orders = new repositories.Order();
        services.DataMapper dataMapper;
        tools.OrderElementProvider elementsProvider;
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            dataMapper = new services.DataMapper();
            dataMapper.FillOrders(orders);

            foreach(entities.Order order in orders.GetList())
            {
                ordersProvider.Add(order);
            }

            ordersListGridView.DataSource = ordersProvider;
        }

        private void ordersListGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            orderElementsBox.Visible = true;

            int index = ordersListGridView.CurrentCell.RowIndex;

            entities.Order order = orders.GetList()[index];

            orderTotal.Text = order.Total.ToString() + Properties.Settings.Default.currency;

            elementsProvider = new tools.OrderElementProvider();

            foreach(entities.OrderElement orderElement in order.GetElements())
            {
                elementsProvider.Add(orderElement);
            }

            elementsListGridView.DataSource = elementsProvider;
        }
    }
}
