using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoPPT
{
    public partial class Form1 : Form
    {
        Random imgAleatorio = new Random();
        bool nombreAgregado = false;
        String Nombre;
        int contU = 0;
        int contM = 0;
        public Form1()
        {
            InitializeComponent();
            lblPuntajeM.Text = "0";
            lblPuntajeU.Text = "0";
            lblInicioM.Visible = true;
            lblInicioU.Visible = true;
            pnlInicio.Visible = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (nombreAgregado)
            {
                pnlInicio.Visible = false;
                pnlJuego.Visible = true;
                lblNombre.Text = Nombre;
                
            }
            else
            {
                MessageBox.Show("Para jugar, primero ingrese un nombre de jugador...");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                Nombre = txtNombre.Text;
                nombreAgregado = true;
                MessageBox.Show("Nombre agregado correctamente...");
                txtNombre.Text = "¡Suerte " + Nombre + "!";
            }
            else
            {
                MessageBox.Show("Ingrese nombre de jugador...");
            }
        }

        private void btnPiedra_Click(object sender, EventArgs e)
        {
            int valor = imgAleatorio.Next(1, 4);
            lblimg1.Visible = true;
            lblimg2.Visible = false;
            lblimg3.Visible = false;
            lblInicioM.Visible = false;
            lblInicioU.Visible = false;
            if (valor == 1)
            {
                lblM1.Visible= true;
                lblM2.Visible = false;
                lblM3.Visible = false;
                lblMensaje.Text = "Empate!";
            }
            if (valor == 2)
            {
                lblM1.Visible = false;
                lblM2.Visible = true;
                lblM3.Visible = false;
                lblMensaje.Text = "Maquina gana!";
                contM = contM + 1;
                lblPuntajeM.Text = Convert.ToString(contM);
            }
            if (valor == 3)
            {
                lblM1.Visible = false;
                lblM2.Visible = false;
                lblM3.Visible = true;
                lblMensaje.Text = Nombre + " gana!";
                contU = contU + 1;
                lblPuntajeU.Text = Convert.ToString(contU);
            }
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            int valor = imgAleatorio.Next(1, 4);
            lblimg1.Visible = false;
            lblimg2.Visible = true;
            lblimg3.Visible = false;
            lblInicioM.Visible = false;
            lblInicioU.Visible = false;
            if (valor == 1)
            {
                lblM1.Visible = true;
                lblM2.Visible = false;
                lblM3.Visible = false;
                lblMensaje.Text = Nombre + " gana!";
                contU = contU + 1;
                lblPuntajeU.Text = Convert.ToString(contU);
            }
            if (valor == 2)
            {
                lblM1.Visible = false;
                lblM2.Visible = true;
                lblM3.Visible = false;
                lblMensaje.Text ="Empate!";
            }
            if (valor == 3)
            {
                lblM1.Visible = false;
                lblM2.Visible = false;
                lblM3.Visible = true;
                lblMensaje.Text = "Maquina gana!";
                contM = contM + 1;
                lblPuntajeM.Text = Convert.ToString(contM);
            }
        }

        private void btnTijera_Click(object sender, EventArgs e)
        {
            int valor = imgAleatorio.Next(1, 4);
            lblimg1.Visible = false;
            lblimg2.Visible = false;
            lblimg3.Visible = true;
            lblInicioM.Visible = false;
            lblInicioU.Visible = false;
            if (valor == 1)
            {
                lblM1.Visible = true;
                lblM2.Visible = false;
                lblM3.Visible = false;
                lblMensaje.Text = "Maquina gana!";
                contM = contM + 1;
                lblPuntajeM.Text = Convert.ToString(contM);
            }
            if (valor == 2)
            {
                lblM1.Visible = false;
                lblM2.Visible = true;
                lblM3.Visible = false;
                lblMensaje.Text = Nombre + " gana!";
                contU = contU + 1;
                lblPuntajeU.Text = Convert.ToString(contU);
            }
            if (valor == 3)
            {
                lblM1.Visible = false;
                lblM2.Visible = false;
                lblM3.Visible = true;
                lblMensaje.Text = "Empate!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            pnlJuego.Visible = false;
            pnlInicio.Visible = true;
            nombreAgregado = false;
            txtNombre.Text = "";
            Nombre = "";
        }
        public void Limpiar()
        {
            lblInicioM.Visible = true;
            lblInicioU.Visible = true;
            lblPuntajeU.Text = "0";
            lblPuntajeM.Text = "0";
            contM = 0;
            contU = 0;
            lblMensaje.Text = "¡Que gane el mejor!";
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {    //Metodo que convierte mayuscula la primera letra
            if (txtNombre.Text.Length == 0)

                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];

            else if (txtNombre.Text.Length > 0)

                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }
    }
}
