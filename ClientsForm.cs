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
    public partial class ClientsForm : Form
    {
        Cashier cashierForm;

        repositories.Client clients = new repositories.Client();
        services.DataMapper dataMapper;

        public ClientsForm(Cashier setCashierForm)
        {
            cashierForm = setCashierForm;

            dataMapper = new services.DataMapper();
            dataMapper.FillClients(clients);

            InitializeComponent();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            RenderClients(clients.GetList());
        }


        private void RenderClients(List<entities.Client> products)
        {
            clientsListView.Items.Clear();

            foreach (entities.Client client in products)
            {
                Item item = new Item(client.GetName(), client.GetId());

                dynamic row = clientsListView.Items.Add(client.GetName());

                row.Tag = item.Value;

                int index = row.Index;

                clientsListView.Items[index].SubItems.Add(client.GetPhone().ToString());
            }
        }

        private class Item
        {
            public string Name;
            public int Value;

            public Item(string name, int value)
            {
                Name = name; Value = value;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (searchBox.Text == "")
                RenderClients(clients.GetList());
            else
                RenderClients(clients.FindByString(searchBox.Text));
        }

        private void clientsListView_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in clientsListView.SelectedItems)
            {
                entities.Client client = clients.FindOne(Convert.ToInt32(item.Tag));
                cashierForm.ChooseClient(client.GetId(), client.GetName());
            }
            
            this.Close();
        }
    }
}
