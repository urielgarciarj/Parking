﻿using System;
using System.Collections;
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
    public partial class btn5coins : Form
    {
        ArrayList ticketsList = new ArrayList();//Se crea un arrayList para poder manejar los tickets y sus datos
        public btn5coins()
        {
            InitializeComponent();
        }

        public static class GlobalData
        {
            public static int numTicket = 0;//Esta variable ayuda a controlar los números de los tickets
            public static Boolean flag = true;//Ayuda para el control del tiempo de cuando sacar un ticket
            public static int creditos = 0;//Variable que ayuda a saber cuanto dinero se ha depositado
            public static double finaltime = 0;//Variable que me ayuda a saber cuanto tiempo se quedo el carro
            public static double finalpay = 0;//Variable que me ayuda a saber cuanto se le cobrara dependiendo el tiempo
        }

        private void BtnTicket_Click(object sender, EventArgs e)
        {
            if (GlobalData.flag == true)
            {
                agregarTicket();//Funcion asyncrona para agregar los tickets y no permitir que se metan mas si no han pasado 5 segundos
                lblTicket.Show();//Muestra el número de ticket que recién se saco
                lblTicket.Text = GlobalData.numTicket.ToString();//El label toma el número que tenga la variable de numTicket
                
                ListViewItem lista = new ListViewItem(lblTicket.Text); //Agrega el numero de ticket
                lista.SubItems.Add(DateTime.Now.ToLongTimeString().ToString()); //Agrega la hora de entrada
                lista.SubItems.Add("Vacio");
                lista.SubItems.Add("Vacio");

                //ticketsList.Add(GlobalData.numTicket);//Agrego el ticket a la arraylist de tickets
                ticketsList.AddRange(new ArrayList() {GlobalData.numTicket, DateTime.Now.ToLongTimeString().ToString(), "Vacio", "Vacio"});

                lvParking.Items.Add(lista); //Le mando mi objeto, los datos a la listView, para que muestre el nuevo objeto

                this.timer1.Start();//Inicia el timer de 5 segundos
            }
            else
            {
                MessageBox.Show("El tiempo de espera aun no termina");//Indica el tiempo de espera aun no finalizado para depositar otro ticket
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTicket.Text = GlobalData.numTicket.ToString();//El label toma el número que tenga la variable de numTicket
            lblTicket.Hide();//Esconde el label una vez terminado el tiempo
        }

        static async void agregarTicket()
        {
            GlobalData.flag = false;//Lo pone en false para en caso de que se quiera agregar otro item sin que este sea permitido
            GlobalData.numTicket++;//Aumenta el número del ticket.
            await Task.Delay(5000);//Tiempo de espera de 5 segundos
            GlobalData.flag = true;//CX
        }
         
        private void Btnpaid_Click(object sender, EventArgs e)
        {
            int myInt;//Variable para controlar la eliminacion de los tickets
            myInt = Int16.Parse(txtTicket.Text.ToString());//Le doy el valor del entero que se dio en el textbox a mi variable

            if (ticketsList.Contains(myInt)) //Función para saber si existe o no el valor dado
            {
                parkingpayment(myInt);//Función a llamar para verificar lo que cierto ticket debe
                if (GlobalData.finalpay <= Int32.Parse(lblTotalCoins.Text.ToString()))//Si la cantidad a pagar es menor que los creditos que existen entonces excenta la validación
                {
                    MessageBox.Show("La cantidad si es suficiente");
                    myInt = ticketsList.IndexOf(myInt);//Saca el index del numero que se me dio en el textbox
                    ticketsList.RemoveRange(myInt, 4);//Con el index dado le digo que me elimine otros 3 espacios mas para poder remover hora, paga y todo
                }
                else
                {
                    MessageBox.Show("La cantidad ingresada no es suficiente para pagar el ticket, son: " +GlobalData.finalpay);
                }
                
            }
            else
            {
                MessageBox.Show("El ticket no existe o ha sido eliminado ya");
            }


            /*foreach (var value in ticketsList)//Función para imprimir el ArrayList
            {
                MessageBox.Show(value.ToString());
            }*/

        }

        public double parkingpayment(int ticket)
        {
            ticket = ticketsList.IndexOf(ticket);
            for (int i = 0; i < ticket + 4; i++)
            {
                if (i == 1)
                {
                    DateTime fechaentrada = Convert.ToDateTime(ticketsList[1].ToString());//La hora de entrada de ticket se convierte a DateTime
                    DateTime fechasalida = Convert.ToDateTime(DateTime.Now.ToLongTimeString().ToString());//La hora de salida también se convierte a DateTime
                    GlobalData.finaltime = fechasalida.Subtract(fechaentrada).TotalSeconds;//Resta de horas calculada en segundos
                    MessageBox.Show(GlobalData.finaltime.ToString());//Muestra la cantidad de tiempo que se ha quedado cierto ticket
                    if(GlobalData.finaltime >= 15)//validaciones para saber cuanto se le tiene que cobrar al ticket
                    {
                        GlobalData.finalpay = 5;
                    }
                    else if(GlobalData.finaltime >= 30)//validacion para saber cuanto se le tiene que cobrar al ticket
                    {
                        GlobalData.finalpay = 9;
                    }
                }
            }
            MessageBox.Show("Monto a pagar: " + GlobalData.finalpay.ToString());
            return GlobalData.finaltime;
        }

        private void Btn20coins_Click(object sender, EventArgs e)
        {
            GlobalData.creditos = GlobalData.creditos + 20;
            this.lblTotalCoins.Text = GlobalData.creditos.ToString();
        }

        private void Btn10coins_Click(object sender, EventArgs e)
        {
            GlobalData.creditos = GlobalData.creditos + 10;
            this.lblTotalCoins.Text = GlobalData.creditos.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            GlobalData.creditos = GlobalData.creditos + 5;
            this.lblTotalCoins.Text = GlobalData.creditos.ToString();
        }

        private void Btn2coins_Click(object sender, EventArgs e)
        {
            GlobalData.creditos = GlobalData.creditos + 2;
            this.lblTotalCoins.Text = GlobalData.creditos.ToString();
        }

        private void Btn1coins_Click(object sender, EventArgs e)
        {
            GlobalData.creditos = GlobalData.creditos + 1;
            this.lblTotalCoins.Text = GlobalData.creditos.ToString();
        }
    }
}
