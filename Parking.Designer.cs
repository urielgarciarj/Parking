﻿namespace Parking
{
    partial class Parking
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnTicket = new System.Windows.Forms.Button();
            this.lvParking = new System.Windows.Forms.ListView();
            this.ColumnTicket = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEntry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnExit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTicket = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(12, 149);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(202, 64);
            this.btnTicket.TabIndex = 0;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.BtnTicket_Click);
            // 
            // lvParking
            // 
            this.lvParking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnTicket,
            this.columnEntry,
            this.columnExit,
            this.columnPrice});
            this.lvParking.Location = new System.Drawing.Point(254, 30);
            this.lvParking.Name = "lvParking";
            this.lvParking.Size = new System.Drawing.Size(698, 303);
            this.lvParking.TabIndex = 1;
            this.lvParking.UseCompatibleStateImageBehavior = false;
            this.lvParking.View = System.Windows.Forms.View.Details;
            // 
            // ColumnTicket
            // 
            this.ColumnTicket.Text = "Ticket";
            this.ColumnTicket.Width = 146;
            // 
            // columnEntry
            // 
            this.columnEntry.Text = "Hora de entrada";
            this.columnEntry.Width = 162;
            // 
            // columnExit
            // 
            this.columnExit.Text = "Hora de Salida";
            this.columnExit.Width = 213;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "A pagar";
            this.columnPrice.Width = 148;
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Location = new System.Drawing.Point(97, 96);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(37, 13);
            this.lblTicket.TabIndex = 2;
            this.lblTicket.Text = "Ticket";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Parking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 696);
            this.Controls.Add(this.lblTicket);
            this.Controls.Add(this.lvParking);
            this.Controls.Add(this.btnTicket);
            this.Name = "Parking";
            this.Text = "Parking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvParking;
        private System.Windows.Forms.ColumnHeader ColumnTicket;
        private System.Windows.Forms.ColumnHeader columnEntry;
        private System.Windows.Forms.ColumnHeader columnExit;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button btnTicket;
        public System.Windows.Forms.Label lblTicket;
    }
}
