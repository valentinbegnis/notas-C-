
namespace Eventos.WindowsForms.Manejadores1
{
    partial class frmManejadores
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.agregarManejadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tareaComúnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tareaParticularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerManejadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBotonUno = new System.Windows.Forms.Button();
            this.btnBotonDos = new System.Windows.Forms.Button();
            this.btnBotonTres = new System.Windows.Forms.Button();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarManejadoresToolStripMenuItem,
            this.removerManejadoresToolStripMenuItem});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(350, 24);
            this.mnuMenu.TabIndex = 0;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // agregarManejadoresToolStripMenuItem
            // 
            this.agregarManejadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tareaComúnToolStripMenuItem,
            this.tareaParticularToolStripMenuItem});
            this.agregarManejadoresToolStripMenuItem.Name = "agregarManejadoresToolStripMenuItem";
            this.agregarManejadoresToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.agregarManejadoresToolStripMenuItem.Text = "Agregar Manejadores";
            // 
            // tareaComúnToolStripMenuItem
            // 
            this.tareaComúnToolStripMenuItem.Name = "tareaComúnToolStripMenuItem";
            this.tareaComúnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tareaComúnToolStripMenuItem.Text = "Tarea común";
            this.tareaComúnToolStripMenuItem.Click += new System.EventHandler(this.tareaComúnToolStripMenuItem_Click);
            // 
            // tareaParticularToolStripMenuItem
            // 
            this.tareaParticularToolStripMenuItem.Name = "tareaParticularToolStripMenuItem";
            this.tareaParticularToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tareaParticularToolStripMenuItem.Text = "Tarea particular";
            this.tareaParticularToolStripMenuItem.Click += new System.EventHandler(this.tareaParticularToolStripMenuItem_Click);
            // 
            // removerManejadoresToolStripMenuItem
            // 
            this.removerManejadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUnoToolStripMenuItem,
            this.btnDosToolStripMenuItem,
            this.btnTresToolStripMenuItem,
            this.todosToolStripMenuItem});
            this.removerManejadoresToolStripMenuItem.Name = "removerManejadoresToolStripMenuItem";
            this.removerManejadoresToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.removerManejadoresToolStripMenuItem.Text = "Remover Manejadores";
            // 
            // btnUnoToolStripMenuItem
            // 
            this.btnUnoToolStripMenuItem.Name = "btnUnoToolStripMenuItem";
            this.btnUnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.btnUnoToolStripMenuItem.Text = "btnUno";
            this.btnUnoToolStripMenuItem.Click += new System.EventHandler(this.btnUnoToolStripMenuItem_Click);
            // 
            // btnDosToolStripMenuItem
            // 
            this.btnDosToolStripMenuItem.Name = "btnDosToolStripMenuItem";
            this.btnDosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.btnDosToolStripMenuItem.Text = "btnDos";
            this.btnDosToolStripMenuItem.Click += new System.EventHandler(this.btnDosToolStripMenuItem_Click);
            // 
            // btnTresToolStripMenuItem
            // 
            this.btnTresToolStripMenuItem.Name = "btnTresToolStripMenuItem";
            this.btnTresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.btnTresToolStripMenuItem.Text = "btnTres";
            this.btnTresToolStripMenuItem.Click += new System.EventHandler(this.btnTresToolStripMenuItem_Click);
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.todosToolStripMenuItem.Text = "Todos";
            this.todosToolStripMenuItem.Click += new System.EventHandler(this.todosToolStripMenuItem_Click);
            // 
            // btnBotonUno
            // 
            this.btnBotonUno.Location = new System.Drawing.Point(75, 62);
            this.btnBotonUno.Name = "btnBotonUno";
            this.btnBotonUno.Size = new System.Drawing.Size(201, 23);
            this.btnBotonUno.TabIndex = 1;
            this.btnBotonUno.Text = "Esto es una pequeña prueba";
            this.btnBotonUno.UseVisualStyleBackColor = true;
            // 
            // btnBotonDos
            // 
            this.btnBotonDos.Location = new System.Drawing.Point(75, 91);
            this.btnBotonDos.Name = "btnBotonDos";
            this.btnBotonDos.Size = new System.Drawing.Size(201, 23);
            this.btnBotonDos.TabIndex = 2;
            this.btnBotonDos.Text = "para compartir código";
            this.btnBotonDos.UseVisualStyleBackColor = true;
            // 
            // btnBotonTres
            // 
            this.btnBotonTres.Location = new System.Drawing.Point(75, 120);
            this.btnBotonTres.Name = "btnBotonTres";
            this.btnBotonTres.Size = new System.Drawing.Size(201, 23);
            this.btnBotonTres.TabIndex = 3;
            this.btnBotonTres.Text = "con un manejador de eventos";
            this.btnBotonTres.UseVisualStyleBackColor = true;
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.Location = new System.Drawing.Point(75, 208);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(201, 23);
            this.btnRestablecer.TabIndex = 4;
            this.btnRestablecer.Text = "Restablecer valores iniciales";
            this.btnRestablecer.UseVisualStyleBackColor = true;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // frmManejadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 253);
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.btnBotonTres);
            this.Controls.Add(this.btnBotonDos);
            this.Controls.Add(this.btnBotonUno);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "frmManejadores";
            this.Text = "Manejadores a controles de igual tipo";
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem agregarManejadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tareaComúnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tareaParticularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerManejadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnUnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnDosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnTresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.Button btnBotonUno;
        private System.Windows.Forms.Button btnBotonDos;
        private System.Windows.Forms.Button btnBotonTres;
        private System.Windows.Forms.Button btnRestablecer;
    }
}

