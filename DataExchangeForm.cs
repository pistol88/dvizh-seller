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
    public partial class DataExchangeForm : Form
    {
        public DataExchangeForm()
        {
            InitializeComponent();
        }

        private void DataExchangeForm_Load(object sender, EventArgs e)
        {
             
        }

        public void Step()
        {
            totalProgressBar.Value++;
        }

        public void SetMessage(string message)
        {
            messageBox.Visible = true;
            messageBox.Text = message;
        }

        public void SetMessage2(string message)
        {
            messageBox2.Visible = true;
            messageBox2.Text = message;
        }
    }
}
