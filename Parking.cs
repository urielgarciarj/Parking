using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Parking
{
    public partial class Parking : Form
    {
      
        public Parking()
        {
            InitializeComponent();
        }

        public static class GlobalData
        {
            public static int numTicket = 1;
        }

        private void BtnTicket_Click(object sender, EventArgs e)
        {
            lblTicket.Show();
            lblTicket.Text = GlobalData.numTicket.ToString();
            ListViewItem lista = new ListViewItem(lblTicket.Text); //Agrega el numero de ticket
            lista.SubItems.Add(lblTicket.Text); //Agrega la hora de entrada
            lvParking.Items.Add(lista); //Le mando mi objeto, los datos a la listView
            this.timer1.Start();
            GlobalData.numTicket++;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTicket.Text = GlobalData.numTicket.ToString();
            lblTicket.Hide();
        }

    }
}
