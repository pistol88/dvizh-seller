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
        services.Database db = new services.Database();

        tools.OrderProvider ordersProvider = new tools.OrderProvider();
        tools.OrderElementProvider elementsProvider;

        repositories.Order orders;
        services.DataMapper dataMapper;
        
        services.Fiscal fiscal;

        public OrdersForm()
        {
            InitializeComponent();

            fiscal = new services.Fiscal();

            orders = new repositories.Order(db);

            dataMapper = new services.DataMapper(db);
            dataMapper.FillOrders(orders);

            foreach (entities.Order order in orders.GetList())
            {
                ordersProvider.Add(order);
            }

            ordersListGridView.DataSource = ordersProvider;

            if (orders.GetList().Count() > 0)
            {
                orderElementsBox.Visible = true;

                entities.Order order = orders.GetList()[0];

                elementsProvider = new tools.OrderElementProvider();

                foreach (entities.OrderElement orderElement in order.GetElements())
                {
                    elementsProvider.Add(orderElement);
                }

                elementsListGridView.DataSource = elementsProvider;
            }
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {

        }

        private void ordersListGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            orderElementsBox.Visible = true;

            int index = ordersListGridView.CurrentCell.RowIndex;

            entities.Order order = orders.GetList()[index];
            
            elementsProvider = new tools.OrderElementProvider();

            foreach(entities.OrderElement orderElement in order.GetElements())
            {
                elementsProvider.Add(orderElement);
            }

            elementsListGridView.DataSource = elementsProvider;
        }

        private void canceSelectedElement_Click(object sender, EventArgs e)
        {
            int index = elementsListGridView.CurrentCell.RowIndex;
            entities.OrderElement orderElement = elementsProvider[index];

            orderElement.SetCancelAt(DateTime.Now.ToLongDateString());
            orders.CancelElement(orderElement);

            if(Properties.Settings.Default.fiscal)
                fiscal.Annulate(orderElement);

            elementsListGridView.Update();
            elementsListGridView.Focus();
        }
    }
}
