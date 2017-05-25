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
    public partial class FiscalTestForm : Form
    {
        services.Fiscal fiscal;

        public FiscalTestForm()
        {
            fiscal = new services.Fiscal();
            
            InitializeComponent();

            labelStatus.Text = fiscal.GetStatus().ToString();
        }

        private void FiscalTestForm_Load(object sender, EventArgs e)
        {

        }

        private void printText_Click(object sender, EventArgs e)
        {
            fiscal.TestPrintString(textBox.Text);
            labelStatus.Text = fiscal.GetStatus().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fiscal.TestPrint();
            labelStatus.Text = fiscal.GetStatus().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fiscal.ReportPrint();
            labelStatus.Text = fiscal.GetStatus().ToString();
        }
    }
}
