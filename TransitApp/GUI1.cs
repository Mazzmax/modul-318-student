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
        //Membervariable

        Transport transport = new Transport();

        public GUI1()
        {
            InitializeComponent();
        }

        //Fahrplan

        private void bSuchen_Click(object sender, EventArgs e)
        {
            Fahrplan(lvFahrplan);
        }

        private void Fahrplan(ListView ListViewName)
        {
            ListViewName.Items.Clear();
                        
            Connections verbindungen = transport.GetConnections(cbVon.Text, cbNach.Text);

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

                    ListViewName.Items.Add(verbindung1);
                }
                catch
                {

                }
            }
        }

        //Aushangfahrplan

        private void bSuchen2_Click(object sender, EventArgs e)
        {
            Aushangfahrplan(cbStation.Text, lvAushangfahrplan);
        }
        private void Aushangfahrplan(string StationName, ListView ListViewName)
        {
            ListViewName.Items.Clear();

            Station station = transport.GetStations(StationName).StationList.First();
            StationBoardRoot stationBoardRoot = transport.GetStationBoard(StationName, station.Id);

            foreach (StationBoard stationBoard in stationBoardRoot.Entries)
            {
                try
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = stationBoard.Name;
                    listViewItem.SubItems.Add(stationBoard.Stop.Departure.ToShortTimeString());
                    listViewItem.SubItems.Add(stationBoard.To);

                    ListViewName.Items.Add(listViewItem);
                }
                catch
                {

                }
            }
        }

        //Autocomplete

        private void autoComplete(object sender, EventArgs e)
        {
            Transport transport = new Transport();
            Stations stations = new Stations();
            ComboBox input = (ComboBox)sender;

            if (input.Text.Length >= 2)
            {
                stations = transport.GetStations(input.Text);
                foreach (var station in stations.StationList)
                {
                    try
                    {
                        input.Items.Add(station.Name);
                    }
                    catch (ArgumentNullException exception)
                    {
                        Console.WriteLine(exception);
                    }
                }
            }
        }        
    }
}
