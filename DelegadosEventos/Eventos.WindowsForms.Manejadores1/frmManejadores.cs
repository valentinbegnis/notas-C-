﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos.WindowsForms.Manejadores1
{
    public partial class frmManejadores : Form
    {
        public frmManejadores()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #region Manejadores Dinámicos

        /// <summary>
        /// METODO CON TAREA COMUN A TODOS LOS CONTROLES
        /// </summary>
        /// <param name="sender">EMISOR DEL EVENTO</param>
        /// <param name="e">EVENTOS RELACIONADOS CON EL OBJETO</param>
        private void CambiarLetrasMayusculas(object sender, EventArgs e)
        {
            //ANTES DE CAMBIAR A MAYUSCULAS LAS LETRAS
            //DEBO CASTEAR EL 'SENDER' A 'BUTTON'
            ((Button)sender).Text = ((Button)sender).Text.ToUpper();
        }

        /// <summary>
        /// METODO CON TAREA PARTICULAR PARA CADA CONTROL
        /// </summary>
        /// <param name="sender">EMISOR DEL EVENTO</param>
        /// <param name="e">EVENTOS RELACIONADOS CON EL OBJETO</param>
        private void CambiarColorFondo(object sender, EventArgs e)
        {
            Button cual = (Button)sender;

            //IDENTIFICO QUE BOTON FUE PULSADO
            if (cual == this.btnBotonUno)
            {
                this.btnBotonUno.BackColor = Color.BurlyWood;
            }
            if (cual == this.btnBotonDos)
            {
                this.btnBotonDos.BackColor = Color.Cornsilk;
            }
            if (cual == this.btnBotonTres)
            {
                this.btnBotonTres.BackColor = Color.HotPink;
            }
        }

        #endregion

        #region Manejadores Estáticos

        private void tareaComúnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AGREGO EL MANEJADOR DE TAREAS COMUNES
            this.btnBotonUno.Click += new EventHandler(CambiarLetrasMayusculas);
            this.btnBotonDos.Click += new EventHandler(CambiarLetrasMayusculas);
            this.btnBotonTres.Click += new EventHandler(CambiarLetrasMayusculas);

        }

        private void tareaParticularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AGREGO EL MANEJADOR DE TAREAS PARTICULARES
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    item.Click += new EventHandler(CambiarColorFondo);
                }
            }
        }

        private void btnUnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //REMUEVO EL MANEJADOR AL EVENTO 'CLICK' DE 'BTNBOTONUNO'
            this.btnBotonUno.Click -= new EventHandler(this.CambiarLetrasMayusculas);
            this.btnBotonUno.Click -= new EventHandler(this.CambiarColorFondo);
        }

        private void btnDosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //REMUEVO EL MANEJADOR AL EVENTO 'CLICK' DE 'BTNBOTONDOS'
            this.btnBotonDos.Click -= new EventHandler(this.CambiarLetrasMayusculas);
            this.btnBotonDos.Click -= new EventHandler(this.CambiarColorFondo);
        }

        private void btnTresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //REMUEVO EL MANEJADOR AL EVENTO 'CLICK' DE 'BTNBOTONTRES'
            this.btnBotonTres.Click -= new EventHandler(this.CambiarLetrasMayusculas);
            this.btnBotonTres.Click -= new EventHandler(this.CambiarColorFondo);
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //REMUEVO EL MANEJADOR AL EVENTO 'CLICK' DE 'BTNBOTONUNO'
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    item.Click -= new EventHandler(this.CambiarLetrasMayusculas);
                    item.Click -= new EventHandler(this.CambiarColorFondo);
                }
            }
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            // RECORRO LOS CONTROLES Y COLOCO EL VALOR INICIAL
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    item.Text = item.Text.ToLower();
                    item.BackColor = Button.DefaultBackColor;
                }
            }
        }

        #endregion

    }
}
