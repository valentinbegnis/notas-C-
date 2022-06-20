using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos.WindowsForms.Manejadores3
{
    public partial class frmPasarManejador : Form
    {
        public frmPasarManejador()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            //ASIGNO 'DINAMICAMENTE' EL MANEJADOR AL EVENTO LOAD
            this.Load += new EventHandler(this.Inicializar);
        }

        private void Inicializar(object sender, EventArgs e)
        {
            this.button1.Click += new EventHandler(Mostrar);

            this.lblMensaje.Text = "Manejador en el Button1";
        }

        private void Mostrar(object sender, EventArgs e)
        {
            Button unBoton = (Button)sender;

            this.PasarManejador(unBoton, e);
        }

        private void PasarManejador(Object boton, EventArgs evento)
        {
            Button unBoton = (Button)boton;

            //AGREGO EL MANEJADOR AL SIGUIENTE BOTON
            //Y REMUEVO EL MANEJADOR AL BOTON ACTUAL
            if (unBoton == this.button1)
            {
                this.button2.Click += new EventHandler(Mostrar);
                this.button1.Click -= new EventHandler(Mostrar);
                this.lblMensaje.Text = "Manejador en el Button2";
                this.button2.Focus();
            }
            if (unBoton == this.button2)
            {
                this.button3.Click += new EventHandler(Mostrar);
                this.button2.Click -= new EventHandler(Mostrar);
                this.lblMensaje.Text = "Manejador en el Button3";
                this.button3.Focus();
            }
            if (unBoton == this.button3)
            {
                this.button4.Click += new EventHandler(Mostrar);
                this.button3.Click -= new EventHandler(Mostrar);
                this.lblMensaje.Text = "Manejador en el Button4";
                this.button4.Focus();
            }
            if (unBoton == this.button4)
            {
                this.button1.Click += new EventHandler(Mostrar);
                this.button4.Click -= new EventHandler(Mostrar);
                this.lblMensaje.Text = "Manejador en el Button1";
                this.button1.Focus();
            }
        }

        //MANEJADOR AGREGADO 'ESTATICAMENTE'
        private void frmPasarManejador_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro de salir?", "Terminar la aplicación",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

    }
}
