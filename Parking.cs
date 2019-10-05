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
            public static int numTicket = 0;
            public static Boolean flag = true;
        }

        private void BtnTicket_Click(object sender, EventArgs e)
        {
            if (GlobalData.flag == true)
            {
                agregarTicket();
                lblTicket.Show();
                lblTicket.Text = GlobalData.numTicket.ToString();
                ListViewItem lista = new ListViewItem(lblTicket.Text); //Agrega el numero de ticket
                lista.SubItems.Add(lblTicket.Text); //Agrega la hora de entrada
                lvParking.Items.Add(lista); //Le mando mi objeto, los datos a la listView
                this.timer1.Start();
            }
            else
            {
                MessageBox.Show("El tiempo de espera aun no termina");
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTicket.Text = GlobalData.numTicket.ToString();
            lblTicket.Hide();
        }

        static async void agregarTicket()
        {
            GlobalData.flag = false;
            GlobalData.numTicket++;
            await Task.Delay(5000);
            GlobalData.flag = true;
        }

    }
}
