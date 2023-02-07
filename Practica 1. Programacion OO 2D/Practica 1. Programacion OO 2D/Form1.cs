using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1.Programacion_OO_2D
{
    public partial class Form1 : Form
    {
        Distanciaentredospuntos Form = new Distanciaentredospuntos();
        public Form1()
        {
            InitializeComponent();
        }

        private void PbxCalculaDistancia_Click(object sender, EventArgs e)
        {
            double x1, x2, y1, y2, z1, z2;
            x1 = Double.Parse(Txtx1.Text);
            x2 = Double.Parse(Txtx2.Text);
            y1 = Double.Parse(Txty1.Text);
            y2 = Double.Parse(Txty2.Text);
            z1 = Double.Parse(Txtz1.Text);
            z2 = Double.Parse(Txtz2.Text);
            Distanciaentredospuntos distancia1;
            distancia1 = new Distanciaentredospuntos();
            TxtDistancia.Text = (Convert.ToString((Form.ConocerDistancia(x1, x2, y1, y2, z1, z2))));
        }          
    }
}
