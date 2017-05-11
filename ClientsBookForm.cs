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
    public partial class ClientsBookForm : Form
    {
        services.Database db = new services.Database();

        tools.ClientProvider clientsProvider = new tools.ClientProvider();
        tools.ClientProvider searchClientsProvider = new tools.ClientProvider();

        repositories.Client clients;

        services.DataMapper dataMapper;

        public ClientsBookForm()
        {
            InitializeComponent();

            clients = new repositories.Client(db);

            dataMapper = new services.DataMapper(db);
            dataMapper.FillClients(clients);

            foreach (entities.Client client in clients.GetList())
            {
                clientsProvider.Add(client);
            }

            clientsGridView.DataSource = clientsProvider;

            clientsGridView.Update();
        }

        private void ClientsBookForm_Load(object sender, EventArgs e)
        {
            clientsGridView.Update();
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (searchBox.Text == "")
                    clientsGridView.DataSource = clientsProvider;
                else
                {
                    searchClientsProvider = new tools.ClientProvider();

                    foreach (entities.Client client in clients.FindByString(searchBox.Text))
                    {
                        searchClientsProvider.Add(client);
                    }

                    clientsGridView.DataSource = searchClientsProvider;
                }
            }
        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            if (searchBox.Text == "Имя или телефон")
            {
                searchBox.Text = "";
            }
        }
    }
}
