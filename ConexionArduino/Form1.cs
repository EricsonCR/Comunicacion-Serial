using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionArduino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            puertoSerie.PortName = "COM4";
            puertoSerie.BaudRate = 115200;
        }

        private void butConectar_Click(object sender, EventArgs e)
        {
            puertoSerie.Open();
            listMensajes.Items.Add("CONECTADO");
        }

        private void butDesconectar_Click(object sender, EventArgs e)
        {
            puertoSerie.Close();
            listMensajes.Items.Add("DESCONECTADO");
        }

        private void puertoSerie_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Invoke(new EventHandler(RecibeDatos));
        }

        private void RecibeDatos(object sender, EventArgs e)
        {
            string datos = puertoSerie.ReadLine();
            listMensajes.Items.Add(datos);
            listMensajes.SelectedIndex = listMensajes.Items.Count - 1;
            listMensajes.SelectedIndex = -1;
        }
    }
}
