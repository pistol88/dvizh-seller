using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace DvizhSeller
{
    public partial class AboutForm : Form
    {
        services.Fiscal fiscal = new services.Fiscal(new drivers.FiscalAbstractFabric());

        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "http://dvizh.net/";
            dvizhLink.Links.Add(link);

            LinkLabel.Link link2 = new LinkLabel.Link();
            link2.LinkData = "mailto:admin@nethammer.ru";
            montanaMail.Links.Add(link2);
        }

        private void dvizhLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void montanaMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fiscal.March();
        }
    }
}
