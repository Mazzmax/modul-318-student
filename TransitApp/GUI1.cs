using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace TransitApp
{
    public partial class GUI1 : Form
    {
        // Member
        Transport transport = new Transport();
        
        public GUI1()
        {
            InitializeComponent();
        }

        private void Verbindung(ListView ListViewName)
        {
            ListViewName.Items.Clear();

            Connections verbindungen = transport.GetConnections(tVon.Text, tNach.Text);

            foreach (Connection verbindung in verbindungen.ConnectionList)
            {
                DateTime abfahrt = DateTime.Parse(verbindung.From.Departure);
                DateTime ankunft = DateTime.Parse(verbindung.To.Arrival);
                try
                {
                    ListViewItem verbindung1 = new ListViewItem();
                    verbindung1.Text = null;
                    verbindung1.SubItems.Add(abfahrt.ToShortTimeString());
                    verbindung1.SubItems.Add(verbindung.From.Station.Name);
                    verbindung1.SubItems.Add(verbindung.From.Platform);
                    verbindung1.SubItems.Add(ankunft.ToShortTimeString());
                    verbindung1.SubItems.Add(verbindung.To.Station.Name);
                    verbindung1.SubItems.Add(verbindung.To.Platform);
                    verbindung1.SubItems.Add(verbindung.Duration);

                    ListViewName.Items.Add(verbindung1);
                }
                catch
                {

                }
            }
        }

        // Ereignisse
        private void bSuchen_Click(object sender, EventArgs e)
        {
            Verbindung(lvFahrplan);
        }
    }
}
