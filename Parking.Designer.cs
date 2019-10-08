namespace Parking
{
    partial class btn5coins
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
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.btnpaid = new System.Windows.Forms.Button();
            this.btn20coins = new System.Windows.Forms.Button();
            this.btn10coins = new System.Windows.Forms.Button();
            this.btn2coins = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn1coins = new System.Windows.Forms.Button();
            this.lblTotalCoins = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.SystemColors.Window;
            this.btnTicket.Location = new System.Drawing.Point(12, 149);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(202, 64);
            this.btnTicket.TabIndex = 0;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.UseVisualStyleBackColor = false;
            this.btnTicket.Click += new System.EventHandler(this.BtnTicket_Click);
            // 
            // lvParking
            // 
            this.lvParking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnTicket,
            this.columnEntry,
            this.columnExit,
            this.columnPrice});
            this.lvParking.Location = new System.Drawing.Point(258, 31);
            this.lvParking.Name = "lvParking";
            this.lvParking.Size = new System.Drawing.Size(673, 303);
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
            // txtTicket
            // 
            this.txtTicket.Location = new System.Drawing.Point(978, 31);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(119, 20);
            this.txtTicket.TabIndex = 3;
            // 
            // btnpaid
            // 
            this.btnpaid.Location = new System.Drawing.Point(1141, 25);
            this.btnpaid.Name = "btnpaid";
            this.btnpaid.Size = new System.Drawing.Size(109, 30);
            this.btnpaid.TabIndex = 4;
            this.btnpaid.Text = "Pagar";
            this.btnpaid.UseVisualStyleBackColor = true;
            this.btnpaid.Click += new System.EventHandler(this.Btnpaid_Click);
            // 
            // btn20coins
            // 
            this.btn20coins.Location = new System.Drawing.Point(979, 126);
            this.btn20coins.Name = "btn20coins";
            this.btn20coins.Size = new System.Drawing.Size(109, 23);
            this.btn20coins.TabIndex = 5;
            this.btn20coins.Text = "20$";
            this.btn20coins.UseVisualStyleBackColor = true;
            this.btn20coins.Click += new System.EventHandler(this.Btn20coins_Click);
            // 
            // btn10coins
            // 
            this.btn10coins.Location = new System.Drawing.Point(1112, 126);
            this.btn10coins.Name = "btn10coins";
            this.btn10coins.Size = new System.Drawing.Size(109, 23);
            this.btn10coins.TabIndex = 6;
            this.btn10coins.Text = "10$";
            this.btn10coins.UseVisualStyleBackColor = true;
            this.btn10coins.Click += new System.EventHandler(this.Btn10coins_Click);
            // 
            // btn2coins
            // 
            this.btn2coins.Location = new System.Drawing.Point(1112, 170);
            this.btn2coins.Name = "btn2coins";
            this.btn2coins.Size = new System.Drawing.Size(109, 23);
            this.btn2coins.TabIndex = 7;
            this.btn2coins.Text = "2$";
            this.btn2coins.UseVisualStyleBackColor = true;
            this.btn2coins.Click += new System.EventHandler(this.Btn2coins_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(979, 170);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "5$";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btn1coins
            // 
            this.btn1coins.Location = new System.Drawing.Point(1040, 220);
            this.btn1coins.Name = "btn1coins";
            this.btn1coins.Size = new System.Drawing.Size(109, 23);
            this.btn1coins.TabIndex = 9;
            this.btn1coins.Text = "1$";
            this.btn1coins.UseVisualStyleBackColor = true;
            this.btn1coins.Click += new System.EventHandler(this.Btn1coins_Click);
            // 
            // lblTotalCoins
            // 
            this.lblTotalCoins.AutoSize = true;
            this.lblTotalCoins.Location = new System.Drawing.Point(1070, 81);
            this.lblTotalCoins.Name = "lblTotalCoins";
            this.lblTotalCoins.Size = new System.Drawing.Size(51, 13);
            this.lblTotalCoins.TabIndex = 10;
            this.lblTotalCoins.Text = "Monedas";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(979, 275);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Cambio en 20";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(1112, 275);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(91, 17);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Cambio en 10";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(978, 307);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(85, 17);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "Cambio en 5";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(1112, 307);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 14;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(1041, 344);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(85, 17);
            this.checkBox5.TabIndex = 15;
            this.checkBox5.Text = "Cambio en 1";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // btn5coins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1416, 696);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblTotalCoins);
            this.Controls.Add(this.btn1coins);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn2coins);
            this.Controls.Add(this.btn10coins);
            this.Controls.Add(this.btn20coins);
            this.Controls.Add(this.btnpaid);
            this.Controls.Add(this.txtTicket);
            this.Controls.Add(this.lblTicket);
            this.Controls.Add(this.lvParking);
            this.Controls.Add(this.btnTicket);
            this.Name = "btn5coins";
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
        private System.Windows.Forms.TextBox txtTicket;
        private System.Windows.Forms.Button btnpaid;
        private System.Windows.Forms.Button btn20coins;
        private System.Windows.Forms.Button btn10coins;
        private System.Windows.Forms.Button btn2coins;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn1coins;
        private System.Windows.Forms.Label lblTotalCoins;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}

